using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaEstacionamento.Model
{
    public class TabelaPrecos
    {
        private int id;
        private DateTime dataInicioVigencia;
        private DateTime dataFinalVigencia;
        private decimal custoHoraInicial;
        private decimal custoHoraAdicional;

        public TabelaPrecos()
        {
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public void setDataInicioVigencia(DateTime dataInicioVigencia)
        {
            this.dataInicioVigencia = dataInicioVigencia;
        }

        public DateTime getDataInicioVigencia()
        {
            return dataInicioVigencia;
        }

        public void setDataFinalVigencia(DateTime dataFinalVigencia)
        {
            this.dataFinalVigencia = dataFinalVigencia;
        }

        public DateTime getDataFinalVigencia()
        {
            return dataFinalVigencia;
        }

        public void setCustoHoraInicial(decimal custoHoraInicial)
        {
            this.custoHoraInicial = custoHoraInicial;
        }
        public decimal getCustoHoraInicial()
        {
            return custoHoraInicial;
        }

        public void setCustoHoraAdicional(decimal custoHoraAdicional)
        {
            this.custoHoraAdicional = custoHoraAdicional;
        }

        public decimal getCustoHoraAdicional()
        {
            return custoHoraAdicional;
        }

    }
}
