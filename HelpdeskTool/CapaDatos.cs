using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace HelpdeskTool
{
    class CapaDatos
    {

        private String connection;
        private SqlConnection conn;
        private DataTable table ; 

        public CapaDatos()
        {
            connection =  System.Configuration.ConfigurationManager.ConnectionStrings["DBconnect"].ConnectionString;
            conn = new SqlConnection();
            conn.ConnectionString = connection;
            
           
        }

        public string STreversa(string claimNumber, string note)
        {
            string message = null;
            SqlParameter param1, param2, param3, param4, param5;
            SqlCommand cmd = new SqlCommand("dbo.ST_REVERSE_PAYMENT",conn); 
            cmd.CommandType = CommandType.StoredProcedure;

            #region parametros

            param1 = new SqlParameter("@v_claim_number",claimNumber); 
            param1.Direction = ParameterDirection.Input;
            param1.SqlDbType = SqlDbType.VarChar;
            param1.Size = 32;

            param2 = new SqlParameter("@v_user_name","mcandelas");
            param2.Direction = ParameterDirection.Input;
            param2.SqlDbType = SqlDbType.VarChar;
            param2.Size = 250;

            param3 = new SqlParameter("@v_note", note);
            param3.Direction = ParameterDirection.Input;
            param3.SqlDbType = SqlDbType.VarChar;
            param3.Size = 250;
           
            param4 = new SqlParameter("@v_return_code",SqlDbType.Int,10);
            param4.Direction = ParameterDirection.Output;
            
            param5 = new SqlParameter("@v_return_str", SqlDbType.NVarChar, 800);
            param5.Direction = ParameterDirection.Output; 


            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2); 
            cmd.Parameters.Add(param3);
            cmd.Parameters.Add(param4);
            cmd.Parameters.Add(param5);

            #endregion

            try
            {

                conn.Open(); // ABRE LA CONECCION A LA BASE DE DATOS 
                cmd.ExecuteNonQuery(); // EJECUTAS EL QUERY 
                message =  String.Concat(String.Concat(cmd.Parameters["@v_return_code"].Value.ToString(), " "), cmd.Parameters["@v_return_str"].Value.ToString());
              
                return message;
            }
            catch (SqlException ex)
            {
                return  ex.ToString(); 
            }

            finally
            {
                conn.Close(); 
            }
        
            

           
        }

        public string STanulacionRechazo(string claimNumber, string note ,string operacion)
        {          
           

           String message = null ,transType=null,status=null;
           SqlParameter param1, param2, param3, param4, param5,param6,param7,param8,param9,param10,param11,param12,param13;
           SqlCommand cmd = new SqlCommand("dbo.ST_UPDATE_FROM_PAYER_FOR_MQ",conn);
           cmd.CommandType = CommandType.StoredProcedure;



            if (operacion.Equals("Cancelacion")) {
                transType = "CANCEL";
                status = "COMPLETE";
                        }
            else if (operacion.Equals("Rechazo")) {
                transType = "TRANSFER";
                status = "REJECTED";
            }
            else if (operacion.Equals("Pago"))
            {
                transType = "TRANSFER";
                status = "COMPLETE";
            }

            // SE GENERAN PARAMETROS DE SALIDA , SE ENVIAN NULL'S YA QUE ENVIANDO DOBLE COMILLA SE PRESENTA ERROR AL CONVERTIR DENTRO DEL STOREDPROCEDURE .
            #region parametros
            param1 = new SqlParameter("@v_transfer_id", DBNull.Value);
            param1.Direction = ParameterDirection.Input;
            param1.SqlDbType = SqlDbType.BigInt;
          

            param2 = new SqlParameter("@v_claim_number", claimNumber);
            param2.Direction = ParameterDirection.Input;
            param2.SqlDbType = SqlDbType.NVarChar;
            param2.Size = 30;

            param3 = new SqlParameter("@v_trans_type", transType);
            param3.Direction = ParameterDirection.Input;
            param3.SqlDbType = SqlDbType.NVarChar;
            param3.Size = 32;

            param4 = new SqlParameter("@v_status", status);
            param4.Direction = ParameterDirection.Input;
            param4.SqlDbType = SqlDbType.NVarChar;
            param4.Size = 32;

            param5 = new SqlParameter("@v_account_no", DBNull.Value);
            param5.Direction = ParameterDirection.Input;
            param5.SqlDbType = SqlDbType.NVarChar;
            param5.Size = 32;

            param6 = new SqlParameter("@v_id_type", DBNull.Value);
            param6.Direction = ParameterDirection.Input;
            param6.SqlDbType = SqlDbType.NVarChar;
            param6.Size = 32;

            param7 = new SqlParameter("@v_id_nbr",DBNull.Value);
            param7.Direction = ParameterDirection.Input;
            param7.SqlDbType = SqlDbType.NVarChar;
            param7.Size = 32;

            param8 = new SqlParameter("@v_branch", DBNull.Value);
            param8.Direction = ParameterDirection.Input;
            param8.SqlDbType = SqlDbType.NVarChar;
            param8.Size = 32;

            param9 = new SqlParameter("@v_date", DateTime.Now.ToString());
            param9.Direction = ParameterDirection.Input;
            param9.SqlDbType = SqlDbType.NVarChar;
            param9.Size = 32;

            param10 = new SqlParameter("@v_time", DBNull.Value);
            param10.Direction = ParameterDirection.Input;
            param10.SqlDbType = SqlDbType.NVarChar;
            param10.Size = 32;

            param11 = new SqlParameter("@v_note", note);
            param11.Direction = ParameterDirection.Input;
            param11.SqlDbType = SqlDbType.NVarChar;
            param11.Size = -1;

            param12 = new SqlParameter("@v_return_code", SqlDbType.Int, 10);
            param12.Direction = ParameterDirection.Output;

            param13 = new SqlParameter("@v_return_str", SqlDbType.NVarChar, 128);
            param13.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            cmd.Parameters.Add(param4);
            cmd.Parameters.Add(param5);
            cmd.Parameters.Add(param6);
            cmd.Parameters.Add(param7);
            cmd.Parameters.Add(param8);
            cmd.Parameters.Add(param9);
            cmd.Parameters.Add(param10);
            cmd.Parameters.Add(param11);
            cmd.Parameters.Add(param12);
            cmd.Parameters.Add(param13);
          
                    #endregion

            try
            {
                conn.Open() ;
                cmd.ExecuteNonQuery();
               message = String.Concat(String.Concat(cmd.Parameters["@v_return_code"].Value.ToString(), " "), cmd.Parameters["@v_return_str"].Value.ToString());
                conn.Close();
                return message;
            }
            catch(SqlException ex) {

                return ex.ToString();
            }
            finally {
                conn.Close();
            }
           
            
        }

        public DataTable ValidarRemesa(string claimnumber)
        {


            String query =  "if ( (select count(transferid) from production.Transfer where ClaimNumber = @claimNumber )>0) "
                            +"Select ts.TransferStatusName,Case t.PaymentTypeId "
                            +"when 1 " 
                            +"then 'Cash' "
                            +"when 2 "
                            +"then 'Deposit' "
                            +"end as 'PaymentTypeId'  from production.Transfer t (nolock) " 
                            +"join Production.TransferStatus ts(nolock) " 
                            +"on t.TransferStatusId = ts.TransferStatusId "  
                            +"where t.ClaimNumber = @claimNumber "
                            +"else "
                            + "select 'No existe informacion' as TransferStatusName , 'No existe Informacion' as PaymentTypeId"; 
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@claimNumber",claimnumber.ToString());
            table = new DataTable();
            table.Columns.Add("TransferStatusName",typeof(string));
            table.Columns.Add("PaymentTypeId", typeof(string));

            try
            {
                conn.Open();
                
                
                using( var lector = cmd.ExecuteReader()) 
                {
                                   
                    lector.Read();
                    if (lector["TransferStatusName"] != DBNull.Value)
                    {
                        table.Rows.Add(lector["TransferStatusName"].ToString(), lector["PaymentTypeId"].ToString());

                        return table;
                    }
                    else
                    {
                        table.Rows.Add(lector["TransferStatusName"].ToString(), lector["PaymentTypeId"].ToString());

                        return table;
                    }
                   

                }

            }
            catch(SqlException ex ) 
            {
                table.Rows.Add("null", "null");
                return null;
            }
            finally
            {
                conn.Close(); 
            }


          
        }
        
    }
}
