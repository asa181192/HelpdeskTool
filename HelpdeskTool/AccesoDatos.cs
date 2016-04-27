using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;

/*
 *Esta clase nos permite acceder a la base de datos fuciona como puente seguiendo un diseño de 3 capas 
 *su principal funcion es generar hilos para realizar actividades costosas en operaciones sobre remesas .
 *evita bloquear la UI del hilo principal .
 */
namespace HelpdeskTool
{
    class AccesoDatos
    {
        private CapaDatos data;
        public Thread th;

        private DataTable table;

        public DataTable Table
        {
            get { return data.Table; }
            set { table = value; }
        } 

        private String message;

        public String Message
        {
            get { return data.Message; }
            set { message = value; }
        } 


        public AccesoDatos()
        {
            data = new CapaDatos(); 
            
        }

        public void reversa(string claimNumber, string note) // acceso a metodos para reverso de remesas .
        {
            try
            {
                data.Claimnumber = claimNumber; 
                data.Note = note;
                th = new Thread(data.STreversa); // creacion de hilo para realizar la operacion sobre DB 
                th.Start();
               

            }
            catch(Exception ex ) 
            {
                message = ex.ToString();
   
            }
           

        }

        public void anulacion(string claimNumber, string note ,string operacion) // aceso a metodos para anulaciones , pagos y rechazos de remesas 
        {
            try
            {
             
                data.Operacion = operacion;
                data.Note = note;
                data.Claimnumber = claimNumber;
                th = new Thread(data.STanulacionRechazo); // creacion de hilo para realizar la operacion sobre DB 
                th.Start();
                
             
            }
            catch(Exception ex)
            {
                message = ex.ToString();
            }
         
           
        }

        public void validar(string claimNumber) //Validacion para estatus de una remesa 
        {

            try

            {
             data.Claimnumber = claimNumber;
             th = new Thread(data.ValidarRemesa);    // creacion de hilo para realizar la operacion sobre DB     
             th.Start();           
             
            
            }
            catch(Exception ex)
            {
                message = ex.ToString();
            }
      
                

        }

       

    }
}
