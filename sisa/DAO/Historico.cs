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
                    CD_USUARIO_ALT = Usuario,
                    AN_PROGRAMA =  "SISA"
                };

                var db = Conexao.Banco;
                db.TB_HISTORICO.Add(hist);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro Método Alteração do Histórico, "+ex.Message);
            }
        }

        public void Exclusao(int CdCliente, int CdBanco, string Obs, DateTime DtExclusao, string Usuario)
        {
            try
            {
                var hist = new TB_HISTORICO()
                {
                    CD_CLIENTE = CdCliente,
                    ID_BANCO = CdBanco,
                    AN_OBSERVACAO = Obs,
                    DT_ALTERACAO = DtExclusao,
                    CD_USUARIO_ALT = Usuario,
                    AN_PROGRAMA = "SISA"
                };

                var db = Conexao.Banco;
                db.TB_HISTORICO.Add(hist);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro Método Exclusão do Histórico, " + ex.Message);
            }
        }

    }
}