using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisa.DAO
{
    static public class Conexao
    {
        static public sisa.Models.SisaModel Banco
        {
            get
            {
                return new sisa.Models.SisaModel();
            }
        } 
    }
}