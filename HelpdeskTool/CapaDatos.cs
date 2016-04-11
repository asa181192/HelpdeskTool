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

        private String connection = System.Configuration.ConfigurationManager.ConnectionStrings["DBconnect"].ConnectionString;
        private SqlConnection conn;
          
        public CapaDatos()
        {

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

                conn.Open();
                cmd.ExecuteNonQuery();
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
            SqlCommand cmd = new SqlCommand("dbo.ST_UPDATE_FROM_PAYER_FOR_MQ ", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            if (operacion=="Cancelacion") {
                transType = "CANCEL";
                status = "COMPLETE";
                        }
            if (operacion=="Rechazo") {
                transType = "TRANSFER";
                status = "REJECTED";
            }
            if (operacion == "Pago")
            {
                transType = "TRANSFER";
                status = "COMPLETE";
            }


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

            param5 = new SqlParameter("@v_account_no", "");
            param5.Direction = ParameterDirection.Input;
            param5.SqlDbType = SqlDbType.NVarChar;
            param5.Size = 32;

            param6 = new SqlParameter("@v_id_type", "");
            param6.Direction = ParameterDirection.Input;
            param6.SqlDbType = SqlDbType.NVarChar;
            param6.Size = 32;

            param7 = new SqlParameter("@v_id_nbr", "");
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

            param10 = new SqlParameter("@v_time", "");
            param10.Direction = ParameterDirection.Input;
            param10.SqlDbType = SqlDbType.NVarChar;
            param10.Size = 32;

            param11 = new SqlParameter("@v_note", note);
            param11.Direction = ParameterDirection.Input;
            param11.SqlDbType = SqlDbType.NVarChar;
            param11.Size = 1000;        

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
                return message;
            }
            catch(SqlException ex) {

                return ex.ToString();
            }
            finally {
                conn.Close();
            }
           
            
        }
        
    }
}
