using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructores
{
    class Mensajes
    {
        //Las regiones dentro de la clase nos permite "agrupar" los diversos 
        //componentes que conforman las clases (Atributos, Constructores, metodos, destructores, etc)
        #region ATRIBUTOS 
        //Los atributos privados solo se pueden ver y utilizar dentro de la clase
        private string dato;
        private int nro;
        #endregion

        #region CONSTRUCTORES
        /*
         CONSTRUCTORES con "Sobrecarga de Constructores"
         El Constructor SIEMPRE se debe llamar igual que la clase.
         No hay limite para la sobrecarga, se pueden codificar tantas sobrecargas como sean necesarias.
         El Constructor es lo primero que se ejecuta al iniciar la clase.
         El sistema identifica cual constructor utilizar, a travez de sus parametros,
         es decir, va a seleccionar segun la cantidad de parametros y el tipo de los mmismos.
        */
        public Mensajes() //Primer Constructor sin parametros
        {
            Nada(); //Llama al metodo
        }
        public Mensajes(string dato) //Constructor que recibira un solo parametro de tipo texto
        {
            if (dato != null)
            {
                //cuando tenemos 2 atributos que se llaman igual, uno de ambito de clase y otro de ambito de parametro
                // utilizamos la palabra reservada this para referirnos al del ambito de clase
                this.dato = dato;
                UnDato(); // llamo al metodo
            }
        }

        public Mensajes(int nro) //Constructor que recibira un solo parametro de entero 
        {
            this.nro = nro;
            UnDatoNumerico();
        }

        public Mensajes(string dato1, string dato2) //Constructor que recibira dos parametros de tipo texto
        {
            //Envio el mensaje desde el constructor (funciona pero NO ES LO CORRECTO)
            MessageBox.Show("Se eescribio en el TextBox1 : " + dato1 + ", y en el TextBox 2 : " + dato2);
        }
        #endregion

        #region METODOS

        private void Nada()
        {
            MessageBox.Show("No se escribieron datos");
        }

        private void UnDato()
        {
            MessageBox.Show("Se eescribio en el TextBox1 : " + dato);
        }

        private void UnDatoNumerico()
        {
            MessageBox.Show("Se eescribio en el TextBox1 el Numero : " + nro);
        }
        #endregion
    }
}
