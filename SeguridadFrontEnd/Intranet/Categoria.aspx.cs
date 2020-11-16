using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeguridadFrontEnd.Intranet
{
    public partial class Categoria : System.Web.UI.Page
    {
        ServiceReferenceCategoria.wsCategoriaSoapClient servicio = new ServiceReferenceCategoria.wsCategoriaSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvCategoria.DataSource = servicio.Listar();
                gvCategoria.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codCat = txtIdCodigoCategoria.Text;
            string nombre = txtNombre.Text;
            string catPadre = txtCatPadre.Text;


            string[] rsta = servicio.Agregar(codCat, nombre, catPadre).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Categoria.aspx';</script>");

            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string codCat = txtIdCodigoCategoria.Text;
            string nombre = txtNombre.Text;
            string catPadre = txtCatPadre.Text;


            string[] rsta = servicio.Actualizar(codCat, nombre, catPadre).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Categoria.aspx';</script>");

            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string codCat = txtIdCodigoCategoria.Text;
            string[] rsta = servicio.Eliminar(codCat).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Categoria.aspx';</script>");

            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            int criterio = ddlCriterio.SelectedIndex;
            if (criterio == 0)
            {
                gvCategoria.DataSource = servicio.Buscar(texto, "CodCategoria");
                gvCategoria.DataBind();
            }
            else if (criterio == 1)
            {
                gvCategoria.DataSource = servicio.Buscar(texto, "Nombre");
                gvCategoria.DataBind();
            }
        }
    }
}