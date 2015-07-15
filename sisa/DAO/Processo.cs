using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sisa.Models;

namespace sisa.DAO
{
    public class Processo
    {
        public List<TB_PROCESSO> Lista(int codcli, string banco)
        {
            return Conexao.Banco.TB_PROCESSO.Where(x => x.CD_CLIENTE == codcli && x.NM_BANCO.Equals(banco)).ToList();
        }
    }
}