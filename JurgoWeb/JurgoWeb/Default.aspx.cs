using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mail;
using System.Net.Mail;

namespace JurgoWeb
{
    public partial class Default : System.Web.UI.Page
    {
        public Prueba PruebaActual 
        {
            get 
            {
                if (ViewState["Prueba"] == null) return null;
                return ViewState["Prueba"] as Prueba;
            }
            private set
            {
                ViewState["Prueba"] = value;
            }
        }
        public int Indice 
        {
            get 
            {
                if (ViewState["Indice"] == null) return 1;
                return (int)ViewState["Indice"];
            }
            private set
            {
                ViewState["Indice"] = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            RegistroPanel.Visible = !IsPostBack;
            PreguntaPanel.Visible = IsPostBack;
            ResultadoPanel.Visible = false;
        }

        void CargarPregunta()
        {
            IndiceLabel.Text = Indice.ToString();
            PreguntaLabel.Text = Pregunta.CatalogoPreguntas[Indice].Texto;
        }

        void CargarResultado()
        {
            PreguntaPanel.Visible = false;
            ResultadoPanel.Visible = true;
            NombreLabel.Text = PruebaActual.Nombre;
            ResultadoLabel.Text = PruebaActual.Resultado.ToString("P");
            InicoLabel.Text = Convert.ToString(PruebaActual.Inicio);

            if (PruebaActual.Resultado >= 0.60)
            {
                Panel1.Visible = true;
            }
            else
           {
                Panel2.Visible = true;
            }
            
          EnviarEmail();
        }

        //Este metodo se encarga de enviar cooreo electronico


        public bool EnviarEmail()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            //System.Net.MailMessage msg = new MailMessage();

            msg.To.Add("diorel_x@hotmail.com");

            msg.From = new MailAddress("diorelx@gmail.com", "Sistamas Agentia", System.Text.Encoding.UTF8);

            msg.Subject = "Resultado de Juego el que quien no sabe";

            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            msg.Body = "Saludos  RH\n\n Este es el resultado del colaborador:" + PruebaActual.Nombre + "\n Del de partamento de :" + PruebaActual.Departamento+ "\n El cual obtubo el siguiente puntaje:" + PruebaActual.Resultado.ToString("P") + "\n En la fecha:" + PruebaActual.Inicio;

            msg.BodyEncoding = System.Text.Encoding.UTF8;

            msg.IsBodyHtml = false; //Si vas a enviar un correo con contenido html entonces cambia el valor a true
                                    //Aquí es donde se hace lo especial
                                    

            SmtpClient client = new SmtpClient();

            client.Credentials = new System.Net.NetworkCredential("diorelx@gmail.com", "diorelyon19");

            client.Port = 587;

            client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail

            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail

            try

            {
                client.Send(msg);

                return true;
            }

            catch (ArgumentException  e)

            {
                return false;
            }

        }


        // Fin de metodo para enviar correo electronico 


        protected void IniciarButton_Click(object sender, EventArgs e)
        {
            //if (NombreTextBox.Text == null)
            //{
            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('esto es una alerta'); </script>");
            //}


            PruebaActual = new Prueba(NombreTextBox.Text, DepartamentoTextBox.Text);
            CargarPregunta();
        }

        protected void Responder(object sender, CommandEventArgs e)
        {
            bool respuestaSeleccionada = Convert.ToBoolean(e.CommandArgument);
            PruebaActual.Contestar(Indice, respuestaSeleccionada);
            if (Indice < PruebaActual.Respuestas.Count())
            {
                Indice++;
                CargarPregunta();
            }
            else
            {
                Indice = 0;
                PruebaActual.Terminar();
                CargarResultado();
            }
        }

    }
}