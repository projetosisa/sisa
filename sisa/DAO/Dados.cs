using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace sisa.DAO
{
    public class Dados
    {
        
        
        string Conexao = ConfigurationManager.ConnectionStrings["SisaModel"].ConnectionString; 
        //"data source=NBANDRE\SQLEXPRESS;initial catalog=SISABANCO;user id=sa;password=1234;MultipleActiveResultSets=True;App=EntityFramework"
        public Dados()
        {
         
        }

        public DataTable RetornaDados(string _sql)
        {
            var ds = new DataSet();
            var adp = new System.Data.SqlClient.SqlDataAdapter(_sql, Conexao);
            adp.Fill(ds,"Tabela");
            return ds.Tables[0];
        }
        
        
    }
}