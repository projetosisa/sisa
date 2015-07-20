using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace sisa.DAO
{
    public class Parcela
    {
        public DataTable ListaTb(int idcli, string banco, string contrato)
        {
            string sqltxt = string.Format("SELECT DISTINCT T.NR_PARCELA,T.NR_DIAS_ATRASO,CONVERT(varchar(max),T.DT_VCTO,103) as DT_VCTO,T.VL_TITULO,T.CD_BOLETO,C.CD_CONTRATO," +
                                       " CONVERT(varchar(max),B.DT_PAGTO,103) as DT_PAGTO,"+
                                       " B.VL_HONORARIOS,B.VL_JUROS,B.VL_TOTAL"+
                                       " FROM TB_TITULO T"+
                                       " LEFT JOIN TB_BOLETO B ON B.CD_BOLETO=T.CD_BOLETO"+
                                       " LEFT JOIN TB_BANCO BC ON T.ID_BANCO=BC.ID_BANCO"+
                                       " LEFT JOIN TB_CONTRATO C ON C.ID_CONTRATO=T.ID_CONTRATO"+
                                       " WHERE T.CD_CLIENTE= {0} AND BC.DS_BANCO='{1}'"+
                                       " AND C.CD_CONTRATO='{2}'"+
                                       " ORDER BY T.NR_PARCELA",idcli,banco,contrato);

            return new Dados().RetornaDados(sqltxt);
        }

    }
}