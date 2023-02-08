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
            MessageBox.Show("No se escribieron datos");
        }
        public Mensajes(string dato) //Constructor que recibira un solo parametro de tipo texto
        {            
            //Envio el mensaje desde el constructor (funciona pero NO ES LO CORRECTO)
            MessageBox.Show("Se escribio en un TextBox el texto: " + dato);
        }

        public Mensajes(int nro) //Constructor que recibira un solo parametro de entero 
        {
            //Envio el mensaje desde el constructor (funciona pero NO ES LO CORRECTO)
            MessageBox.Show("Se escribio en un TextBox el Numero : " + nro);
        }

        public Mensajes(string dato1, string dato2) //Constructor que recibira dos parametros de tipo texto
        {
            //Envio el mensaje desde el constructor (funciona pero NO ES LO CORRECTO)
            MessageBox.Show("Se escribio en el TextBox1 el texto: " + dato1 + ", y en el TextBox 2 el texto: " + dato2);
        }

        public Mensajes(int dato1, int dato2) //Constructor que recibira dos parametros de tipo texto
        {
            //Envio el mensaje desde el constructor (funciona pero NO ES LO CORRECTO)
            MessageBox.Show("Se escribio en el TextBox1 el numero: " + dato1 + ", y en el TextBox 2 el numero: " + dato2);
        }

        public Mensajes(string dato1, int dato2) //Constructor que recibira dos parametros de tipo texto
        {
            //Envio el mensaje desde el constructor (funciona pero NO ES LO CORRECTO)
            MessageBox.Show("Se escribio en el TextBox1 el texto: " + dato1 + ", y en el TextBox 2 el numero: " + dato2);
        }

        public Mensajes(int dato1, string dato2) //Constructor que recibira dos parametros de tipo texto
        {
            //Envio el mensaje desde el constructor (funciona pero NO ES LO CORRECTO)
            MessageBox.Show("Se escribio en el TextBox1 el numero: " + dato1 + ", y en el TextBox 2 el texto: " + dato2);
        }
        #endregion
    }
}
