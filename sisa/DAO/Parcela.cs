using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace sisa.DAO
{
    public class Parcela
    {
        public DataTable ListaTb(int idcli, string banco)
        {
            string sqltxt = string.Format("SELECT DISTINCT T.NR_PARCELA,T.NR_DIAS_ATRASO,CONVERT(varchar(max),T.DT_VCTO,103) as DT_VCTO,T.VL_TITULO,T.CD_BOLETO,"+
                                       " CONVERT(varchar(max),T.DT_RECEBIMENTO,103) as DT_RECEBIMENTO,T.NM_BANCO," +
                                       " CONVERT(varchar(max),B.DT_PAGTO,103) as DT_PAGTO," +
                                       " B.VL_HONORARIOS,B.VL_JUROS,B.VL_TOTAL" +
                                       " FROM TB_TITULO T" +
                                       " JOIN TB_BOLETO B ON B.CD_BOLETO=T.CD_BOLETO" +
                                       " WHERE T.CD_CLIENTE={0} AND T.NM_BANCO='{1}'" +
                                       " ORDER BY T.NR_PARCELA", idcli, banco);

            return new Dados().RetornaDados(sqltxt);
        }

    }
}