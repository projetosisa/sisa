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
        public string Status { get; set; }
        public int IdBanco { get; set; }
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }

        public Contrato(){
        }

        public Contrato(string contrato)
        {
            try
            {
                IdUsuario = int.Parse(Conexao.Banco.TB_CONTRATO.Single(c => c.CD_CONTRATO.Equals(contrato)).ID_USUARIO.ToString());
                NomeUsuario = new DAO.Usuario(IdUsuario).Nome;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro Construtor Contrato, " + ex.Message);
            }
        }

        public Contrato(int codcli, string nmbanco)
        {
            IdBanco = RetornaIdBanco(nmbanco);
            Status = RetornaStatus(codcli, IdBanco);
        }

        public Contrato(int codcli, string nmbanco, int contrato)
        {
            try
            {
                IdBanco = RetornaIdBanco(nmbanco);
                Status = RetornaStatus(codcli, IdBanco);
                if (contrato != 0)
                {
                    var ct = Conexao.Banco.TB_CONTRATO.Single(c => c.ID_CONTRATO==contrato);
                    if (ct.ID_USUARIO != null)
                    {
                        IdUsuario = int.Parse(ct.ID_USUARIO.ToString());
                        NomeUsuario = new DAO.Usuario(IdUsuario).Nome;
                    }
                    else
                    {
                        IdUsuario = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro Construtor Contrato 3 parametros, " + ex.Message);
            }
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
            try{
            //string sqltxt = String.Format("SELECT distinct C.NM_BANCO, C.CD_CLIENTE FROM TB_CONTRATO C WHERE C.CD_CLIENTE={0}",idcli);
            string sqltxt = string.Format("SELECT distinct B.DS_BANCO, C.CD_CLIENTE FROM TB_CONTRATO C" +
                         "  LEFT JOIN TB_BANCO B on B.ID_BANCO=C.ID_BANCO" +
                         "  WHERE C.CD_CLIENTE={0}", idcli);

            return new Dados().RetornaDados(sqltxt);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro RetornaStatus, " + ex.Message);
            }
        }

        public int RetornaIdBanco(string nmbanco)
        {
            try
            {
                return Conexao.Banco.TB_BANCO.Single(b => b.DS_BANCO.Equals(nmbanco)).ID_BANCO;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro RetornaIdBanco, " + ex.Message);
            }
        }

        public string RetornaStatus(int codcli, int idbanco)
        {
            try
            {
                string sqltxt = string.Format("SELECT CASE WHEN (COUNT(1)>0) THEN 'ATIVO' ELSE 'ENCERRADO' END AS STATUS FROM TB_CONTRATO WHERE CD_CLIENTE={0} AND ID_BANCO={1} AND FL_EXCLUIDO=0", codcli, idbanco);
                return new Dados().RetornaDados(sqltxt).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro RetornaStatus, " + ex.Message);
            }
        }

    }
}