using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sisa.Models;
using System.Data;

namespace sisa.DAO
{
    public class Contrato
    {

        public Contrato(){
        }

        public List<TB_CONTRATO> Lista(int codcli)
        {
            return Conexao.Banco.TB_CONTRATO.Where(c => c.CD_CLIENTE == codcli).ToList();
        }

        public List<TB_TITULO> ListaParcelas(string codcontrato)
        {
            return Conexao.Banco.TB_TITULO.Where(c => c.CD_CONTRATO.Equals(codcontrato)).ToList();
        }

        public List<TB_CONTRATO> RetornaContratos(int idcli, string banco)
        {
            return Conexao.Banco.TB_CONTRATO.Where(c => c.CD_CLIENTE == idcli && c.NM_BANCO.Equals(banco)).ToList();
        }
        public DataTable RetornaBancos(int idcli)
        {
            string sqltxt = String.Format("SELECT distinct C.NM_BANCO, C.CD_CLIENTE FROM TB_CONTRATO C WHERE C.CD_CLIENTE={0}",idcli);

            return new Dados().RetornaDados(sqltxt);
        }


        


    }
}