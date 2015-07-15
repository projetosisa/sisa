namespace sisa.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SisaModel : DbContext
    {
        public SisaModel()
            : base("name=SisaModel")
        {
        }

        public virtual DbSet<menuMaster> menuMaster { get; set; }
        public virtual DbSet<TB_ACORDO> TB_ACORDO { get; set; }
        public virtual DbSet<TB_ADVOGADO> TB_ADVOGADO { get; set; }
        public virtual DbSet<TB_ALVARAS_AUTOMATIZADOS> TB_ALVARAS_AUTOMATIZADOS { get; set; }
        public virtual DbSet<TB_AND_PROCESSO> TB_AND_PROCESSO { get; set; }
        public virtual DbSet<TB_AUDIENCIAS> TB_AUDIENCIAS { get; set; }
        public virtual DbSet<TB_AVALISTA> TB_AVALISTA { get; set; }
        public virtual DbSet<TB_BANCO> TB_BANCO { get; set; }
        public virtual DbSet<TB_BOLETO> TB_BOLETO { get; set; }
        public virtual DbSet<TB_COD_AND_PROCESSOS> TB_COD_AND_PROCESSOS { get; set; }
        public virtual DbSet<TB_COD_DESPESA> TB_COD_DESPESA { get; set; }
        public virtual DbSet<TB_COD_EVENTO> TB_COD_EVENTO { get; set; }
        public virtual DbSet<TB_COD_HONORARIO> TB_COD_HONORARIO { get; set; }
        public virtual DbSet<TB_COMARCA> TB_COMARCA { get; set; }
        public virtual DbSet<TB_CONTATO> TB_CONTATO { get; set; }
        public virtual DbSet<TB_CONTRATO> TB_CONTRATO { get; set; }
        public virtual DbSet<TB_CUSTAS> TB_CUSTAS { get; set; }
        public virtual DbSet<TB_DADOS_REFERENCIA> TB_DADOS_REFERENCIA { get; set; }
        public virtual DbSet<TB_DEPOSITOS_JUDICIAIS> TB_DEPOSITOS_JUDICIAIS { get; set; }
        public virtual DbSet<TB_DESPESA> TB_DESPESA { get; set; }
        public virtual DbSet<TB_DIC_DADOS> TB_DIC_DADOS { get; set; }
        public virtual DbSet<TB_DOMINIO> TB_DOMINIO { get; set; }
        public virtual DbSet<TB_EMAIL> TB_EMAIL { get; set; }
        public virtual DbSet<TB_ENDERECO> TB_ENDERECO { get; set; }
        public virtual DbSet<TB_EVENTO> TB_EVENTO { get; set; }
        public virtual DbSet<TB_FERIADO> TB_FERIADO { get; set; }
        public virtual DbSet<TB_GRUPO> TB_GRUPO { get; set; }
        public virtual DbSet<TB_HISTORICO> TB_HISTORICO { get; set; }
        public virtual DbSet<TB_HONORARIO> TB_HONORARIO { get; set; }
        public virtual DbSet<TB_HORARIOS> TB_HORARIOS { get; set; }
        public virtual DbSet<TB_INDICE> TB_INDICE { get; set; }
        public virtual DbSet<TB_LOGIN> TB_LOGIN { get; set; }
        public virtual DbSet<TB_MANDADOSOFICIAIS> TB_MANDADOSOFICIAIS { get; set; }
        public virtual DbSet<TB_MOVIMENTACOES> TB_MOVIMENTACOES { get; set; }
        public virtual DbSet<TB_NOTAS_EXPEDIENTE> TB_NOTAS_EXPEDIENTE { get; set; }
        public virtual DbSet<TB_NOTIFICACAO> TB_NOTIFICACAO { get; set; }
        public virtual DbSet<TB_OBSERVACAO_JUDICIAL> TB_OBSERVACAO_JUDICIAL { get; set; }
        public virtual DbSet<TB_OBSERVACAO_PREJUD> TB_OBSERVACAO_PREJUD { get; set; }
        public virtual DbSet<TB_PARTES_ENVOLVIDAS> TB_PARTES_ENVOLVIDAS { get; set; }
        public virtual DbSet<TB_PERMISSOES> TB_PERMISSOES { get; set; }
        public virtual DbSet<TB_PESSOA> TB_PESSOA { get; set; }
        public virtual DbSet<TB_PETICOES> TB_PETICOES { get; set; }
        public virtual DbSet<TB_PROCESSO> TB_PROCESSO { get; set; }
        public virtual DbSet<TB_SISTEMA> TB_SISTEMA { get; set; }
        public virtual DbSet<TB_TELA> TB_TELA { get; set; }
        public virtual DbSet<TB_TIPO_ACAO> TB_TIPO_ACAO { get; set; }
        public virtual DbSet<TB_TITULO> TB_TITULO { get; set; }
        public virtual DbSet<TB_UF> TB_UF { get; set; }
        public virtual DbSet<TB_USUARIO> TB_USUARIO { get; set; }
        public virtual DbSet<TB_VEICULO> TB_VEICULO { get; set; }
        public virtual DbSet<TB_CLIENTE> TB_CLIENTE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<menuMaster>()
                .Property(e => e.Menu_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<menuMaster>()
                .Property(e => e.Menu_Enable)
                .IsUnicode(false);

            modelBuilder.Entity<menuMaster>()
                .Property(e => e.Menu_Form)
                .IsUnicode(false);

            modelBuilder.Entity<menuMaster>()
                .Property(e => e.Menu_Texto)
                .IsUnicode(false);

            modelBuilder.Entity<menuMaster>()
                .Property(e => e.Menu_Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<menuMaster>()
                .Property(e => e.Menu_Icone)
                .IsUnicode(false);

            modelBuilder.Entity<menuMaster>()
                .Property(e => e.Menu_Modulo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.NM_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.NR_ACORDO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.CD_BOLETO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.NM_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.VL_TITULO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.VL_HONORARIOS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.VL_CUSTAS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.VL_TARIFA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.VL_TOTAL_GERAL)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.TX_OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.AN_TIPO_PAGTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.HR_ACORDO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.CD_USUARIO_ACORDO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.VL_BANCO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.VL_REPASSE)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.CD_USUARIO_REPASSE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.AN_TIPO_ACORDO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ACORDO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ADVOGADO>()
                .Property(e => e.NM_ADVOGADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ADVOGADO>()
                .Property(e => e.CD_OAB)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ADVOGADO>()
                .Property(e => e.AN_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ADVOGADO>()
                .Property(e => e.AN_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ADVOGADO>()
                .Property(e => e.NM_ESCRITORIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ADVOGADO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ADVOGADO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ALVARAS_AUTOMATIZADOS>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ALVARAS_AUTOMATIZADOS>()
                .Property(e => e.NR_PROCESSO_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ALVARAS_AUTOMATIZADOS>()
                .Property(e => e.NR_PROCESSO_THEMIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ALVARAS_AUTOMATIZADOS>()
                .Property(e => e.NR_ALVARA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ALVARAS_AUTOMATIZADOS>()
                .Property(e => e.BENEFICIARIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ALVARAS_AUTOMATIZADOS>()
                .Property(e => e.SITUACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ALVARAS_AUTOMATIZADOS>()
                .Property(e => e.TIPO_RESGATE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AND_PROCESSO>()
                .Property(e => e.NM_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AND_PROCESSO>()
                .Property(e => e.AN_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AND_PROCESSO>()
                .Property(e => e.CD_ANDAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AND_PROCESSO>()
                .Property(e => e.AN_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AND_PROCESSO>()
                .Property(e => e.DS_ANDAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AND_PROCESSO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AND_PROCESSO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AUDIENCIAS>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AUDIENCIAS>()
                .Property(e => e.NR_PROCESSO_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AUDIENCIAS>()
                .Property(e => e.NR_PROCESSO_THEMIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.NM_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.NM_AVALISTA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.IN_F_J_AVALISTA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.AN_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.AN_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.AN_BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.AN_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.CD_UF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.AN_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.AN_CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.AN_REF_AVALISTA1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.AN_REF_AVALISTA2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AVALISTA>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.CD_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.DS_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.AN_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.AN_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.CD_UF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.AN_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.AN_INS_EST)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.CD_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.CD_CEDENTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.FT_IND_DESCONTO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.FT_IND_JUROS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.VL_ENCARGOS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.VL_ESCRITORIO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.VL_NOTIFICACAO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.VL_HONORARIOS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.VL_META)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.VL_LOCALIZADOR)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.VL_MULTA)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.NM_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.CD_BOLETO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_TITULO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_ENCARGOS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_ESCRITORIO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_NOTIFICACAO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_HONORARIOS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_CPMF)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_LOCALIZADOR)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_CUSTAS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_DESP_EXTRA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_DESPESA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_TARIFA_BANCARIA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_MULTA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_PAGTO_S_HONO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_PAGTO_C_HONO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_DESCONTO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_TOTAL)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.FT_IND_DESCONTO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_POR_DIA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_JUROS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.FT_IND_BANCO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.FT_IND_JURIDICO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_COMISSIONAMENTO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_COMISS_PERM)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.VL_TOTAL_GERAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.TX_OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.TX_OBSERVACAO2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.TX_OBSERVACAO3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_TX_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.CD_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_CAMPO_1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_DIGITO_1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_CAMPO_2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_DIGITO_2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_CAMPO_3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_DIGITO_3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_DIGITO_GERAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_CODIGO_BARRA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.CD_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.CD_CEDENTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.NM_CEDENTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.CD_REPR_NUMERICA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.IN_TIPO_BLOQUETO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.CD_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_DESCR_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.IN_TIPO_COMISS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.NR_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_DESCR_BOLETO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_CONTRATOS_BOLETO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_PARCELAS_BOLETO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.AN_COD_AUTORIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.CD_PROGRAMA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BOLETO>()
                .Property(e => e.CD_USUARIO_EXC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_AND_PROCESSOS>()
                .Property(e => e.CD_ANDAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_AND_PROCESSOS>()
                .Property(e => e.DS_TIPO_ANDAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_AND_PROCESSOS>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_AND_PROCESSOS>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_DESPESA>()
                .Property(e => e.CD_DESPESA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_DESPESA>()
                .Property(e => e.DS_TIPO_DESPESA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_DESPESA>()
                .Property(e => e.VL_DESPESA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_COD_DESPESA>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_DESPESA>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_EVENTO>()
                .Property(e => e.CD_EVENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_EVENTO>()
                .Property(e => e.DS_TIPO_EVENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_EVENTO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_EVENTO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_HONORARIO>()
                .Property(e => e.CD_HONORARIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_HONORARIO>()
                .Property(e => e.DS_TIPO_HONORARIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_HONORARIO>()
                .Property(e => e.VL_HONORARIO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_COD_HONORARIO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COD_HONORARIO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COMARCA>()
                .Property(e => e.NM_COMARCA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COMARCA>()
                .Property(e => e.NM_VARA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COMARCA>()
                .Property(e => e.AN_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COMARCA>()
                .Property(e => e.AN_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COMARCA>()
                .Property(e => e.AN_FILIAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COMARCA>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COMARCA>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTATO>()
                .Property(e => e.IN_TP_CONTATO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTATO>()
                .Property(e => e.AN_DDD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTATO>()
                .Property(e => e.AN_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTATO>()
                .Property(e => e.AN_RAMAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTATO>()
                .Property(e => e.AN_RESPONSAVEL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTATO>()
                .Property(e => e.AN_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTATO>()
                .Property(e => e.AN_ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTATO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTATO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.NM_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.CD_USUARIO_RESP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.IN_J_A)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.AN_INFORMATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.IN_TP_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.VL_TOT_CONTRATO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.VL_SALDO_DEVEDOR)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.VL_TAXA_FINANCIAMENTO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.VL_INDICE_MOEDA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.IN_FAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.TX_OBSERVACAO_JUIZO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.NM_ARQUIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.CD_USUARIO_EXC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONTRATO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CUSTAS>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CUSTAS>()
                .Property(e => e.NR_PROCESSO_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CUSTAS>()
                .Property(e => e.NR_PROCESSO_THEMIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CUSTAS>()
                .Property(e => e.NR_GUIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CUSTAS>()
                .Property(e => e.VLR_GUIA)
                .HasPrecision(13, 2);

            modelBuilder.Entity<TB_DADOS_REFERENCIA>()
                .Property(e => e.AN_CONTATO_TEL_RES)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DADOS_REFERENCIA>()
                .Property(e => e.AN_NOME_CONJUGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DADOS_REFERENCIA>()
                .Property(e => e.AN_NOME_PRIM_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DADOS_REFERENCIA>()
                .Property(e => e.AN_TP_PARENTESCO_PRIM_PES)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DADOS_REFERENCIA>()
                .Property(e => e.AN_NOME_SEG_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DADOS_REFERENCIA>()
                .Property(e => e.AN_TP_PARENTESCO_SEG_PES)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DADOS_REFERENCIA>()
                .Property(e => e.AN_NOME_LOCALIZADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DADOS_REFERENCIA>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DADOS_REFERENCIA>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DEPOSITOS_JUDICIAIS>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DEPOSITOS_JUDICIAIS>()
                .Property(e => e.NR_PROCESSO_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DEPOSITOS_JUDICIAIS>()
                .Property(e => e.NR_PROCESSO_THEMIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DEPOSITOS_JUDICIAIS>()
                .Property(e => e.NR_GUIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DEPOSITOS_JUDICIAIS>()
                .Property(e => e.DEPOSITANTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.DS_DESPESA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.CD_DESPESA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.VL_DESPESA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.NR_CGC_CARTORIO)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.NR_VALE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.AN_JUSTIFICATIVA_MANUAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.AN_GRERJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.AN_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.NM_COMARCA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DESPESA>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DIC_DADOS>()
                .Property(e => e.CD_MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DIC_DADOS>()
                .Property(e => e.CD_TABELA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DIC_DADOS>()
                .Property(e => e.CD_CAMPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DIC_DADOS>()
                .Property(e => e.IN_TP_DADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DIC_DADOS>()
                .Property(e => e.IN_TP_OBJETO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DIC_DADOS>()
                .Property(e => e.DS_CAMPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DIC_DADOS>()
                .Property(e => e.AN_HELP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DOMINIO>()
                .Property(e => e.AN_TP_DOMINIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DOMINIO>()
                .Property(e => e.AN_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DOMINIO>()
                .Property(e => e.AN_DECRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DOMINIO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_DOMINIO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EMAIL>()
                .Property(e => e.AN_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EMAIL>()
                .Property(e => e.AN_RESPONSAVEL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EMAIL>()
                .Property(e => e.AN_ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EMAIL>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EMAIL>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.IN_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.AN_ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.AN_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.AN_COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.AN_BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.AN_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.CD_UF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.AN_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.AN_NOME_EMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENDERECO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.NM_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.CD_USUARIO_RESP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.HR_EVENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.CD_USUARIO_OPER)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.HR_INI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.HR_FIM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.IN_SIT_CONTATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.CD_TIPO_EVENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.AN_DS_EVENTO_ASSUNTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.AN_OBS_EVENTO_ASSUNTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.HR_TEMPO_LIGACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.HR_HORA_MARCADA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.AN_ARQUIVO_ENVIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.NR_DDD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.NR_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.IN_LIGACAO_EFETUADA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.AN_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.AN_SITUACAO_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.CD_PROGRAMA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EVENTO>()
                .Property(e => e.CD_USARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FERIADO>()
                .Property(e => e.AN_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FERIADO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FERIADO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_GRUPO>()
                .Property(e => e.CD_GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_GRUPO>()
                .Property(e => e.NM_GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_GRUPO>()
                .Property(e => e.DS_GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_GRUPO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_GRUPO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HISTORICO>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HISTORICO>()
                .Property(e => e.AN_OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HISTORICO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HISTORICO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HISTORICO>()
                .Property(e => e.AN_PROGRAMA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HONORARIO>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HONORARIO>()
                .Property(e => e.VL_HONORARIOS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_HONORARIO>()
                .Property(e => e.NM_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HONORARIO>()
                .Property(e => e.TX_OBS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HONORARIO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HONORARIO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HORARIOS>()
                .Property(e => e.HORARIO_INICIAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HORARIOS>()
                .Property(e => e.HORARIO_FINAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HORARIOS>()
                .Property(e => e.HORARIO_INTERVALO_INICIAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HORARIOS>()
                .Property(e => e.HORARIO_INTERVALO_FINAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HORARIOS>()
                .Property(e => e.HORAS_DIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_INDICE>()
                .Property(e => e.NM_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_INDICE>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_INDICE>()
                .Property(e => e.INTERVALO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_INDICE>()
                .Property(e => e.FT_DESC_PARCELA)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_INDICE>()
                .Property(e => e.FT_DESC_PRINCIPAL)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_INDICE>()
                .Property(e => e.FT_JUROS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_INDICE>()
                .Property(e => e.FT_MULTA)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_INDICE>()
                .Property(e => e.FT_HONORARIOS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_INDICE>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_INDICE>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LOGIN>()
                .Property(e => e.Login_PC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LOGIN>()
                .Property(e => e.Login_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LOGIN>()
                .Property(e => e.Login_MAC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANDADOSOFICIAIS>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANDADOSOFICIAIS>()
                .Property(e => e.NR_PROCESSO_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANDADOSOFICIAIS>()
                .Property(e => e.NR_PROCESSO_THEMIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANDADOSOFICIAIS>()
                .Property(e => e.NR_MANDADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANDADOSOFICIAIS>()
                .Property(e => e.TIPO_MANDADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANDADOSOFICIAIS>()
                .Property(e => e.DESTINATARIO_MANDADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANDADOSOFICIAIS>()
                .Property(e => e.OFICIAL_MANDADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANDADOSOFICIAIS>()
                .Property(e => e.RESULTADO_MANDADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANDADOSOFICIAIS>()
                .Property(e => e.VLR_CONDUCAO_MANDADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MOVIMENTACOES>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MOVIMENTACOES>()
                .Property(e => e.NR_PROCESSO_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MOVIMENTACOES>()
                .Property(e => e.NR_PROCESSO_THEMIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_NOTAS_EXPEDIENTE>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_NOTAS_EXPEDIENTE>()
                .Property(e => e.NR_PROCESSO_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_NOTAS_EXPEDIENTE>()
                .Property(e => e.NR_PROCESSO_THEMIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_NOTAS_EXPEDIENTE>()
                .Property(e => e.NR_NOTA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_NOTIFICACAO>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_NOTIFICACAO>()
                .Property(e => e.AN_TIPO_NOTIFICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_NOTIFICACAO>()
                .Property(e => e.VL_NOTIFICACAO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_NOTIFICACAO>()
                .Property(e => e.AN_RESULTADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_NOTIFICACAO>()
                .Property(e => e.AN_RENOTIFICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_NOTIFICACAO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_NOTIFICACAO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_JUDICIAL>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_JUDICIAL>()
                .Property(e => e.AN_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_JUDICIAL>()
                .Property(e => e.HR_OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_JUDICIAL>()
                .Property(e => e.CD_USUARIO_OBS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_JUDICIAL>()
                .Property(e => e.AN_OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_JUDICIAL>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_JUDICIAL>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_PREJUD>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_PREJUD>()
                .Property(e => e.HR_OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_PREJUD>()
                .Property(e => e.CD_USUARIO_OBS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_PREJUD>()
                .Property(e => e.AN_OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_PREJUD>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OBSERVACAO_PREJUD>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PARTES_ENVOLVIDAS>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PARTES_ENVOLVIDAS>()
                .Property(e => e.NR_PROCESSO_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PARTES_ENVOLVIDAS>()
                .Property(e => e.NR_PROCESSO_THEMIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PARTES_ENVOLVIDAS>()
                .Property(e => e.AN_REQUERENTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PARTES_ENVOLVIDAS>()
                .Property(e => e.AN_ADVOGADO_REQUERENTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PARTES_ENVOLVIDAS>()
                .Property(e => e.AN_REQUERIDO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PARTES_ENVOLVIDAS>()
                .Property(e => e.AN_ADVOGADO_REQUERIDO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PARTES_ENVOLVIDAS>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PARTES_ENVOLVIDAS>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.NM_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.IN_F_J)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_CNPJ_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_OCUPACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_RG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_ORGAO_EMISSAO_RG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.CD_UF_RG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_SEXO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_NATURALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_NACIONALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_ESTADO_CIVIL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_NOME_CONJUGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_NOME_PAI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.AN_NOME_MAE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PESSOA>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PETICOES>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PETICOES>()
                .Property(e => e.NR_PROCESSO_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PETICOES>()
                .Property(e => e.NR_PROCESSO_THEMIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.NM_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_CNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.IN_TP_ACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.IN_TP_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.NM_AUTOR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.NM_REU)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.NM_COMARCA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.VL_CUSTAS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.CD_VARA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.VL_ACAO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.IN_CHANCE_PERDA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.IN_FASE_PROCESSUAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.IN_LIMINAR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.VL_ALVARA_LEV)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.VL_TOT_ALVARA_LEV)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.VL_DEPOSITO_DEP)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.IN_TIPO_ACORDO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.VL_TOTAL_ACORDO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.VL_ENTRADA_ACORDO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.VL_PARCELA)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_SITUACAO_ACORDO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_PRESTACAO_CONTAS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_INSTANCIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_AGRAVO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.VL_PROVISIONAMENTO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_RAZAO_ENCERRAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_VL_CONDENACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_IDENTIFICACAO_ALVARA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_SITUACAO_PROCESSUAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_TIPO_ENVIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_SENTENCA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_VL_DISCUTIDO_EXTRA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_VL_ENTRADA_ACORDO_ESP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_FASE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.VL_ALVARA_ACORDO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_SPC_SERASA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.IN_RET_ACAO_COB)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.IN_PEND_LIQ_SENT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_PROVIDENCIAS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_VL_ALVARA_EXTRA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_SITUACAO_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_SETOR_RESPONSAVEL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.AN_JUSTICA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.NR_PASTA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PROCESSO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SISTEMA>()
                .Property(e => e.CD_SISTEMA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SISTEMA>()
                .Property(e => e.NM_SISTEMA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SISTEMA>()
                .Property(e => e.DS_SISTEMA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SISTEMA>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SISTEMA>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TELA>()
                .Property(e => e.CD_TELA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TELA>()
                .Property(e => e.CD_SISTEMA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TELA>()
                .Property(e => e.NM_TELA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TELA>()
                .Property(e => e.DS_TELA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TELA>()
                .Property(e => e.AN_URL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TELA>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TELA>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TIPO_ACAO>()
                .Property(e => e.AN_TIPO_ACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TIPO_ACAO>()
                .Property(e => e.AN_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TITULO>()
                .Property(e => e.NM_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TITULO>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TITULO>()
                .Property(e => e.CD_BOLETO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TITULO>()
                .Property(e => e.VL_TITULO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_TITULO>()
                .Property(e => e.AN_ARQUIVO_ENVIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TITULO>()
                .Property(e => e.CD_PROGRAMA_EXC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TITULO>()
                .Property(e => e.AN_MOTIVO_EXC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TITULO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TITULO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TITULO>()
                .Property(e => e.CD_USUARIO_EXC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_UF>()
                .Property(e => e.AN_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_UF>()
                .Property(e => e.NM_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.CD_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.AN_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.IN_NIVEL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.NM_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.AN_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.TEMPO_EVENTOS_DIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.VL_META)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.AN_GESTOR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.NM_CEDENTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.AN_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.AN_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.FL_ACESSA_ALFA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.FL_ACESSA_DAYCOVAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.FL_ACESSA_FICSA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.FL_ACESSA_OMNI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.FL_ACESSA_RENNER)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.FL_ACESSA_SULFINANCEIRA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.FL_ACESSA_OUTROBANCOS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.VL_META_ALFA)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.VL_META_DAYCOVAL)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.VL_META_FICSA)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.VL_META_RENNER)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.VL_META_OMNI)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.VL_META_SULFINANCEIRA)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.VL_META_OUTROSBANCOS)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.NR_CNPJ_CARTORIO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_USUARIO>()
                .Property(e => e.AN_TIPO_SELECAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.CD_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_MARCA_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_MODELO_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_MONTADORA_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_ANO_FAB_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_ANO_MODELO_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_COR_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_PLACA_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.CD_UF_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_CHASSI_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.CD_RENAVAN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.CD_COMBUST_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_CERTIF_VEIC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_END_GARAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_OBS_GARAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_DEPOSITARIO_GARAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_GUINCHO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_FONE_GARAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.AN_LOCAL_DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.VL_PAGO_REMOVIDO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.CD_USUARIO_INC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.CD_USUARIO_ALT)
                .IsUnicode(false);
        }
    }
}
