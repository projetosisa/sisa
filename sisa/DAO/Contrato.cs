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
            //return Conexao.Banco.TB_CONTRATO.Where(c => c.CD_CLIENTE == codcli).ToList();
            string qry = string.Format("SELECT * FROM TB_CONTRATO C" +
                         "  LEFT JOIN TB_BANCO B on B.ID_BANCO=C.ID_BANCO" +
                         "  WHERE C.CD_CLIENTE={0}", codcli);
            return Conexao.Banco.TB_CONTRATO.SqlQuery(qry).ToList();
        }

        public DataTable ListaTbl(int codcli)
        {
            //return Conexao.Banco.TB_CONTRATO.Where(c => c.CD_CLIENTE == codcli).ToList();
            string qry = string.Format("SELECT * FROM TB_CONTRATO C" +
                         "  LEFT JOIN TB_BANCO B on B.ID_BANCO=C.ID_BANCO" +
                         "  WHERE C.CD_CLIENTE={0}", codcli);
            return new Dados().RetornaDados(qry);
        }

        public List<VW_TITULOS> ListaParcelas(string codcontrato)
        {
            return Conexao.Banco.VW_TITULOS.Where(c => c.CD_CONTRATO.Equals(codcontrato)).ToList();
        }
        public List<VW_CONTRATOS> RetornaContratos(int idcli)
        {
            return Conexao.Banco.VW_CONTRATOS.Where(c => c.CD_CLIENTE == idcli).ToList();
        }
        public List<VW_CONTRATOS> RetornaContratos(int idcli, string banco)
        {
            return Conexao.Banco.VW_CONTRATOS.Where(c => c.CD_CLIENTE == idcli && c.DS_BANCO.Equals(banco)).ToList();
        }
        public DataTable RetornaBancos(int idcli)
        {
            //string sqltxt = String.Format("SELECT distinct C.NM_BANCO, C.CD_CLIENTE FROM TB_CONTRATO C WHERE C.CD_CLIENTE={0}",idcli);
            string sqltxt = string.Format("SELECT distinct B.DS_BANCO, C.CD_CLIENTE FROM TB_CONTRATO C" +
                         "  LEFT JOIN TB_BANCO B on B.ID_BANCO=C.ID_BANCO" +
                         "  WHERE C.CD_CLIENTE={0}", idcli);

            return new Dados().RetornaDados(sqltxt);
        }


        


    }
}