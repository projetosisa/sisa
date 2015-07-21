using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisa.DAO
{
    public class Usuario
    {
        public string Nome { get; set; }
        public Usuario()
        {

        }
        public Usuario(int idUsu)
        {
            try
            {
                Nome = Conexao.Banco.TB_USUARIO.Single(u => u.ID_USUARIO == idUsu).NM_NOME.ToString();
            }catch(Exception ex)
            {
                throw new Exception("Erro DAO.Usuario, " + ex.Message);
            }
        }
    }
}