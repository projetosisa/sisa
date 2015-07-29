using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Mvc;

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

        public Dictionary<int, string> ListaSelecione()
        {
            Dictionary<int, string> myDic = new Dictionary<int, string>();
            //myDic.Add(System.DBNull.Value.ToString(), "Selecione");
            myDic.Add(-1, "Selecione");
            myDic.Add(0, "Não");
            myDic.Add(1, "Sim");
            return myDic;
        }
        public Dictionary<int, string> RetornaSelectList(string qry)
        {
            var db = RetornaDados(qry);
            var myDic = new Dictionary<int, string>();
            myDic.Add(-1, "Selecione");

            int i = 0;
            foreach (DataRow itm in db.Rows)
            {
                myDic.Add(i, itm[0].ToString());
                i++;
            }
            return myDic;
        }
    }
}