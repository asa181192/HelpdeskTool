using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpdeskTool
{
    class AccesoDatos
    {

        public String reversa(string claimNumber, string note) // acceso a metodos para reverso de remesas .
        {
            String message; 
            CapaDatos data = new CapaDatos(); // se genera una instancia para la ejecucion de la base de datos . 
            message =  data.STreversa(claimNumber,note);
            
            return message; 

        }

        public String anulacion(string claimNumber, string note ,string operacion) // aceso a metodos para anulaciones , pagos y rechazos de remesas 
        {
            String message;
            CapaDatos data = new CapaDatos(); 
            message = data.STanulacionRechazo(claimNumber, note ,operacion);
            return message; 
        }

    }
}
