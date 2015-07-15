using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sisa.Models;
using sisa.DAO;

namespace sisa.DAO
{
    public class Pessoa
    {
        public List<TB_PESSOA> Lista(int codcli)
        {
            return Conexao.Banco.TB_PESSOA.Where(c => c.CD_CLIENTE == codcli).ToList();
        }
        public TB_PESSOA Dados(int codcli)
        {
            return Conexao.Banco.TB_PESSOA.Where(c => c.CD_CLIENTE == codcli).SingleOrDefault();
        }
        
    }
}