using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sisa.Models;

namespace sisa.DAO
{
    public class Processo
    {
        public List<VW_PROCESSO> Lista(int codcli, string banco)
        {
            return Conexao.Banco.VW_PROCESSO.Where(p=>p.CD_CLIENTE==codcli && p.DS_BANCO.Equals(banco)).ToList();
        }
    }
}