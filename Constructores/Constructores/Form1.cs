using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
              Con esta estructura selecciono dependiendo de los datos cargados
              a que Sobrecarga de Constructores voy a invocar
             */

            if (txtDato1.Text == "" && txtDato2.Text == "")
                //si los dos TextBox estan vacios invoco a la sobrecarga que no recibe 
                //parametros
            {
                Mensajes Mjes = new Mensajes();
                
            }
            else if (txtDato1.Text.IsNumeric())
            //si el dato del Textbox es numerico, invoco a la sobrecarga que
            //recibe un dato de tipo numerico entero
            {
                int Dto = Convert.ToInt32(txtDato1.Text);
                Mensajes Mjes = new Mensajes(Dto);
            }
            else if (txtDato1.Text != "" && txtDato2.Text != "")
            //si ambos textbox estan con datos invoco a la sobrecarga que
            //recibe dos parametros de tipo texto
            {
                string dto = txtDato1.Text;
                string  dto2 =  txtDato2.Text;
                Mensajes Mjes = new Mensajes(dto, dto2);
            }
            else if (txtDato1.Text != "" || txtDato2.Text != "")
            //si alguno de los textbox tiene datos invoco a la sobrecarga que
            //recibe un solo parametro de tipo texto
            {
                string dto = txtDato1.Text + txtDato2.Text;
                Mensajes Mjes = new Mensajes(dto);
            }
 
        }
    }
}
