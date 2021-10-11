using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace JSONNET
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona
            {
                Nombre = txtNombre.Text,
                Edad = Convert.ToInt32(txtEdad.Text),
                Email = txtEmail.Text
            };

            txtNombre.Text = "";
            txtEdad.Text = "";
            txtEmail.Text = "";

            if (Session["ARCHIVOJSON"].ToString() == string.Empty)
            {
                Session["ARCHIVOJSON"] = JsonConvert.SerializeObject(persona);
            }
            else
            {
                Session["ARCHIVOJSON"] = Session["ARCHIVOJSON"].ToString() + "," + JsonConvert.SerializeObject(persona);

            }
            ltbPersona.Items.Add("Nombre: " + persona.Nombre + " Edad: " + persona.Edad + " Email: " + persona.Email);
        }

        protected void btnJSON_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\www\aspnetJSON.json", "[" + Session["ARCHIVOJSON"].ToString() + "]");
            Response.Write("<script>alert('JSON listo !!');</script>");
        }
    }
}