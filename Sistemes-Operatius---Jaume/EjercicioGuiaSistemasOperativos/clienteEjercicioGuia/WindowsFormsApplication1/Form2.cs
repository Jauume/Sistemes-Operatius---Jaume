using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        int nForm;
        Socket server;
        public Form2(int nForm, Socket server)
        {
            InitializeComponent();
            this.nForm = nForm;
            this.server = server;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Longitud.Checked)
            {
                string mensaje = "1/" + nForm + "/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

            }
            else if (Bonito.Checked)
            {
                string mensaje = "2/" + nForm + "/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }

            else if (Altura.Checked)
            {
                // Enviamos nombre y altura
                string mensaje = "3/" + nForm + "/" + nombre.Text + "/" + alturaBox.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else { //No hay ninguna casilla seleccionada
                string mensaje = "No se ha seleccionado nada";
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
             
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numForm.Text = nForm.ToString();
        
        }

        public void TomaRespuesta1(string mensaje)
        {
            MessageBox.Show("Longitud: " + mensaje);
        }
        public void TomaRespuesta2(string mensaje)
        {
            if (mensaje == "SI")
                MessageBox.Show("Tu nombre es bonito");
            else
                MessageBox.Show("Tu nombre No es bonito. Lo siento");
        }
        public void TomaRespuesta3(string mensaje)
        {
            MessageBox.Show(mensaje);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pedir el numero de servicios realizados
            string mensaje = "6/";
            
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            label1.Text = mensaje; //ponlo en el label del formulario
        }
    }
}
