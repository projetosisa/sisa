using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using sisa.Models;
using sisa.DAO;

namespace sisa.DAO
{
    public class Pessoa
    {
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<TB_PESSOA> Lista(int codcli)
        {
            return Conexao.Banco.TB_PESSOA.Where(c => c.CD_CLIENTE == codcli).ToList();
        }
        public TB_PESSOA Dados(int codcli)
        {
            return Conexao.Banco.TB_PESSOA.SingleOrDefault(c => c.CD_CLIENTE == codcli);
        }

        public void ConsultaContato(int codcli)
        {
          string qry = string.Format("select top 1 AN_DDD,AN_TELEFONE,isnull(AN_EMAIL,'') from tb_contato where CD_CLIENTE={0}",codcli);
          var tb = new Dados().RetornaDados(qry);
          if(tb.Rows.Count>0)
          {
            DDD = tb.Rows[0][0].ToString();
            Telefone = tb.Rows[0][1].ToString();
            Email = tb.Rows[0][2].ToString();
          }
        }

        public bool ExisteTelefone(DataTable tbl)
        {
           return tbl.Rows.Count > 0;
        }
        
    }
}