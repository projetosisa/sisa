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

        public Dictionary<string, string> ListaTipoProcesso()
        {
            var myDic = new Dictionary<string, string>();
            myDic.Add(System.DBNull.Value.ToString(), "Selecione");
            //myDic.Add(-1, "Selecione");
            myDic.Add("Ativa", "Ativa");
            myDic.Add("Contra", "Contra");
            return myDic;
        }

        public Dictionary<string, string> ListaAcao()
        {
            return new Dados().RetornaSelectList("SELECT AN_TIPO_ACAO FROM TB_TIPO_ACAO");    
        }

        public Dictionary<string, string> ListaChancePerda()
        {
            var myDic = new Dictionary<string, string>();
            myDic.Add(System.DBNull.Value.ToString(), "Selecione");
            myDic.Add("Provável", "Provável");
            myDic.Add("Remoto", "Remoto");
            myDic.Add("Possível", "Possível");
            return myDic;
        }

        public Dictionary<string, string> ListaSituacaoProcesso()
        {
            var myDic = new Dictionary<string, string>();
            myDic.Add(System.DBNull.Value.ToString(), "Selecione");
            //myDic.Add(-1, "Selecione");
            myDic.Add("Em Andamento", "Em Andamento");
            myDic.Add("Encerrado", "Encerrado");
            return myDic;
        }
         
        public Dictionary<string, string> ListaUF()
        {
            return new Dados().RetornaSelectList("SELECT AN_ESTADO FROM TB_UF");    
        }

        public Dictionary<string, string> ListaComarca()
        {
            return new Dados().RetornaSelectList("SELECT NM_COMARCA FROM TB_COMARCA");    
        }
        
        public Dictionary<int, string> ListaAdvogados()
        {
            return new Dados().RetornaSelectList3("SELECT CD_ADVOGADO,NM_ADVOGADO FROM TB_ADVOGADO");    
        }

        public Dictionary<int, string> ListaContratos(string cdCliente,string cdBanco)
        {
            string _qry = string.Format("SELECT ID_CONTRATO, CD_CONTRATO from TB_CONTRATO WHERE CD_CLIENTE={0} AND ID_BANCO={1}",
                    int.Parse(cdCliente), int.Parse(cdBanco));
            return new Dados().RetornaSelectList3(_qry);    
        }

        
        
        public Dictionary<string, string> ListaTribunal()
        {
            var myDic = new Dictionary<string, string>();
            myDic.Add(System.DBNull.Value.ToString(), "Selecione");
            //myDic.Add(-1, "Selecione");
            myDic.Add("Tribunal de Justiça Federal", "Tribunal de Justiça Federal");
            myDic.Add("Tribunal de Justiça do Rio Grande do Sul", "Tribunal de Justiça do Rio Grande do Sul");
            myDic.Add("Tribunal do Trabalho","Tribunal do Trabalho");
            myDic.Add("Tribunal de Justiça do Paraná","Tribunal de Justiça do Paraná");
            myDic.Add("Tribunal de Justiça de Santa Catarina","Tribunal de Justiça de Santa Catarina");
            myDic.Add("Tribunal de Justiça de São Paulo","Tribunal de Justiça de São Paulo");
            myDic.Add("Tribunal de Justiça do Rio de Janeiro","Tribunal de Justiça do Rio de Janeiro");
            myDic.Add("Tribunal de Justiça de Mias Gerais","Tribunal de Justiça de Mias Gerais");
            myDic.Add("Tribunal de Justiça da Bahia","Tribunal de Justiça da Bahia");
            return myDic;
        }
    }
}