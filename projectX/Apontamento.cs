using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectX
{
    internal class Apontamento
    {
        //AtributosClasse;
        private int identificador;
        private int numeroOp;
        private string codigoPeca;
        private int funcionario;
        private string maquina;
        private int operacao;
        private string observacao;
        private string status;
        private Boolean ativo;
        DateTime dataAp;
        DateTime dataInicio;
        DateTime dataFinalizado;

        //metodoConstrutor
        public Apontamento()
        {
            this.identificador++;
            this.numeroOp = 0;
            this.codigoPeca = " ";
            this.funcionario = 0;
            this.maquina = " ";
            this.operacao = 0;
            this.observacao = " ";
            this.status = " ";
            this.ativo = false;
            this.dataAp = DateTime.Now;
            this.dataInicio = DateTime.Now;
            this.dataFinalizado = DateTime.Now;
      
        }


        //metodosSet's
        //TesteAuto
        public int Identificador { get => identificador; set => identificador = value; }

        public void setNumeroOp(int num)
        {
            this.numeroOp = num;
        }
        public void setCodigoPeca(string paramCodigo)
        {
            this.codigoPeca = paramCodigo;
        }
        public void setFuncionario(int paramFuncionario)
        {
            this.funcionario = paramFuncionario;
        }

        public void setMaquina(string paramMaquina)
        {
            this.maquina = paramMaquina;
        }

        public void setOperacao(int paramOp)
        {
            this.operacao = paramOp;
        }

        public void setObservacao(string paramObs)
        {
            this.observacao = paramObs;
        }

        public void setStatus(string paramStatus)
        {
            this.status = paramStatus;
        }
        public void setAtivo(Boolean paramAtivo)
        {
            this.ativo = paramAtivo;
        }

        public void setData(DateTime paramData)
        {
            this.dataAp = paramData;
        }

        public void setDataInicio(DateTime paramDataInicio)
        {
            this.dataInicio = paramDataInicio;
        }
        public void setDataFinalizado(DateTime paramDataFinalizado)
        {
            this.dataFinalizado = paramDataFinalizado;
        }

        //MetodosGets;
        public int getNumeroOp()
        {
            return this.numeroOp;
        }
        public string getCodigoPeca()
        {
            return this.codigoPeca; 
        }

        public int getFuncionario()
        {
          return this.funcionario;
        }

        public string getMaquina()
        {
            return this.maquina;
        }

        public int getOperacao()
        {
            return this.operacao;
        }

        public string getObservacao()
        {
            return this.observacao;
        }

        public string getStatus()
        {
            return this.status;
        }
        public Boolean getAtivo()
        {
            return this.ativo;
        }

        public DateTime getData()
        {
            return this.dataAp;
        }

        public DateTime getDataInico()
        {
            return this.dataInicio;
        }

        public DateTime getDataFinalizado()
        {
            return this.dataFinalizado;
        }


        //metodosGerais
        public void ativaApontamento()
        {
            this.ativo = true;
            this.dataInicio = DateTime.Now;
        }

        public void desativaApontamento()
        {   
            this.ativo = false;
            this.dataFinalizado = DateTime.Now;
        }

        public void verificaStatus()
        {
            if (this.ativo == true)
            {
                this.status = "Iniciado!";
            } else
            {
                this.status = "Encerrado!";
            }
        }

    }
}
