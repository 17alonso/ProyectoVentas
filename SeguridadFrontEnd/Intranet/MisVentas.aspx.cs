using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using iTextSharp.text;

using iTextSharp.text.pdf;

namespace SeguridadFrontEnd.Intranet
{
    public partial class MisVentas : System.Web.UI.Page
    {
        ServiceReferenceBoleta.wsBoletaSoapClient servicio = new ServiceReferenceBoleta.wsBoletaSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
            {
                gvMisVentas.DataSource = servicio.MisVentas((Page.User.Identity.Name).ToString());
                gvMisVentas.DataBind();
            }
        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = servicio.MisVentas((Page.User.Identity.Name).ToString());
            Stream s = DataTableToExcel(dt);
            if (s != null)
            {
                MemoryStream ms = s as MemoryStream;
                Response.AddHeader("Content-Disposition", string.Format("attachment;filename=" + HttpUtility.UrlEncode("MisVentas") + ".xlsx"));
                Response.ContentType = "application/vnd.ms-excel";
                Response.AddHeader("Content-Length", ms.ToArray().Length.ToString());
                Response.BinaryWrite(ms.ToArray());
                Response.Flush();
                ms.Close();
                ms.Dispose();
            }
        }

        public Stream DataTableToExcel(DataTable dt)
        {
            XSSFWorkbook workbook = new XSSFWorkbook();
            MemoryStream ms = new MemoryStream();
            ISheet sheet = workbook.CreateSheet("mis Ventas");
            XSSFRow headerRow = headerRow = (XSSFRow)sheet.CreateRow(0);
            try
            {
                foreach (DataColumn column in dt.Columns)
                    headerRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);
                int rowIndex = 1;
                foreach (DataRow row in dt.Rows)
                {
                    XSSFRow dataRow = (XSSFRow)sheet.CreateRow(rowIndex);
                    foreach (DataColumn column in dt.Columns)
                        dataRow.CreateCell(column.Ordinal).SetCellValue(row[column].ToString());
                    ++rowIndex;
                }
                for (int i = 0; i <= dt.Columns.Count; ++i)
                    sheet.AutoSizeColumn(i);
                workbook.Write(ms);
                ms.Flush();
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                ms.Close();
                sheet = null;
                headerRow = null;
                workbook = null;
            }
            return ms;
        }

        protected void btnPDF_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, HttpContext.Current.Response.OutputStream);
            dt = servicio.MisVentas((Page.User.Identity.Name).ToString());
            if (dt.Rows.Count > 0)
            {
                document.Open();
                Font fontTitle = FontFactory.GetFont(FontFactory.COURIER_BOLD, 25);
                Font font9 = FontFactory.GetFont(FontFactory.TIMES, 9);


                PdfPTable table = new PdfPTable(dt.Columns.Count);
                document.Add(new Paragraph(20, "Reporte de Mis Ventas 2020", fontTitle));
                document.Add(new Chunk("\n"));

                float[] widths = new float[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                    widths[i] = 4f;

                table.SetWidths(widths);
                table.WidthPercentage = 90;

                PdfPCell cell = new PdfPCell(new Phrase("columns"));
                cell.Colspan = dt.Columns.Count;

                foreach (DataColumn c in dt.Columns)
                {
                    table.AddCell(new Phrase(c.ColumnName, font9));
                }

                foreach (DataRow r in dt.Rows)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int h = 0; h < dt.Columns.Count; h++)
                        {
                            table.AddCell(new Phrase(r[h].ToString(), font9));
                        }
                    }
                }
                document.Add(table);
            }
            document.Close();

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=MisVentas" + ".pdf");
            HttpContext.Current.Response.Write(document);
            Response.Flush();
            Response.End();
        }


    }
}