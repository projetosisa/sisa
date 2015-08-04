using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sisa.Models;

namespace sisa.DAO
{
    public class Historico
    {
        public void Alteracao(int CdCliente, int CdBanco, string Obs, DateTime DtAlteracao, string Usuario)
        {
            try
            {
                var hist = new TB_HISTORICO()
                {
                    CD_CLIENTE = CdCliente,
                    ID_BANCO = CdBanco,
                    AN_OBSERVACAO = Obs,
                    DT_ALTERACAO = DtAlteracao,
                    CD_USUARIO_ALT = Usuario
                };

                var ctx = Conexao.Banco;
                ctx.TB_HISTORICO.Add(hist);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro Método Alteração do Histórico, "+ex.Message);
            }
        }

    }
}