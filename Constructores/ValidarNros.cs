using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    public static class ValidarNros
    {
        /* El this en el parametro hace que tome lo que encuentra en la propiedad
         * seleccionada del control a evaluar al momento de llamarlo
         * 
         * Ejemplo: 
         * txtdatos.Text.IsNumeric();
         * cmbProvincias.Text.IsNumeric();
         */
        public static bool IsNumeric(this string texto)
        {            
            try
            {
                decimal numero = Convert.ToDecimal(texto);
                return true;
            }
            catch (Exception)
            {
                return false;                
            }
        }
    }
}
