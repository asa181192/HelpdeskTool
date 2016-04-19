using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace HelpdeskTool
{
    class AccesoDatos
    {
        private CapaDatos data;
        public AccesoDatos()
        {
            data = new CapaDatos(); 
        }

        public String reversa(string claimNumber, string note) // acceso a metodos para reverso de remesas .
        {
            String message; 
            message =  data.STreversa(claimNumber,note);
            
            return message; 

        }

        public String anulacion(string claimNumber, string note ,string operacion) // aceso a metodos para anulaciones , pagos y rechazos de remesas 
        {
            String message;          
            message = data.STanulacionRechazo(claimNumber, note ,operacion);
            return message; 
        }

        public DataTable validar(string claimNumber) //Validacion para estatus de una remesa 
        {
           
           return data.ValidarRemesa(claimNumber);

        }


    }
}
