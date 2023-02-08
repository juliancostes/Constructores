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

        private void button1_Click(object sender, EventArgs e)
        {
            Mensajes Mjes;
            /*
              Con esta estructura selecciono dependiendo de los datos cargados
              a que Sobrecarga de Constructores voy a invocar
             */

            if (string.IsNullOrEmpty(txtDato1.Text.Trim()) && string.IsNullOrEmpty(txtDato2.Text.Trim()))
                //si los dos TextBox estan vacios invoco a la sobrecarga que no recibe 
                //parametros
            {
                Mjes = new Mensajes();                
            }
            else 
            //si el dato del Textbox es numerico, invoco a la sobrecarga que
            //recibe un dato de tipo numerico entero
            {                
                if (string.IsNullOrEmpty(txtDato1.Text.Trim()))
                {
                    // solo dato 2
                    if (txtDato2.Text.IsNumeric())
                    {
                        //es numero
                        int Dato = Convert.ToInt32(txtDato2.Text);
                        Mjes = new Mensajes(Dato);
                    }
                    else
                    {
                        //es string
                        string Dato = txtDato2.Text;
                        Mjes = new Mensajes(Dato);
                    }
                }
                else if (string.IsNullOrEmpty(txtDato2.Text.Trim()))
                {
                    // solo dato 1
                    if (txtDato1.Text.IsNumeric())
                    {
                        //es numero
                        int Dato = Convert.ToInt32(txtDato1.Text);
                        Mjes = new Mensajes(Dato);
                    }
                    else
                    {
                        //es string
                        string Dato = txtDato1.Text;
                        Mjes = new Mensajes(Dato);
                    }

                }
                else
                {
                    // ambos datos
                    if (!txtDato1.Text.IsNumeric() && !txtDato2.Text.IsNumeric())
                    {
                        //no son numeros ninguno
                        string Dato1 = txtDato1.Text;
                        string Dato2 = txtDato2.Text;
                        Mjes = new Mensajes(Dato1, Dato2);
                    }
                    else
                    {
                        //alguno es numerico
                        if (txtDato1.Text.IsNumeric() && txtDato2.Text.IsNumeric())
                        {
                            int Dato1 = Convert.ToInt32(txtDato1.Text);
                            int Dato2 = Convert.ToInt32(txtDato2.Text);
                            Mjes = new Mensajes(Dato1, Dato2);
                        }
                        else if (txtDato1.Text.IsNumeric())
                        {
                            // el primero es numerico
                            int Dato1 = Convert.ToInt32(txtDato1.Text);
                            string Dato2 = txtDato2.Text;
                            Mjes = new Mensajes(Dato1, Dato2);  
                        }
                        else
                        {
                            // el segundo es numerico
                            string Dato1 = txtDato1.Text;
                            int Dato2 = Convert.ToInt32(txtDato2.Text);
                            Mjes = new Mensajes(Dato1, Dato2);
                        }
                    }
                }                
            } 
        }
    }
}
