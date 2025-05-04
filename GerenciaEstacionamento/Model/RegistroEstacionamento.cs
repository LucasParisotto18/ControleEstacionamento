using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaEstacionamento.Model
{
    public class RegistroEstacionamento
    {
        private int id;
        private String placaCarro { get; set; } 
        private DateTime dataEntrada { get; set; } 
        private DateTime? dataSaida;
        private bool isEstacionado;
        private TimeOnly? tempoEstacionado;
        private decimal? valorCobrado;
        private decimal? totalAPagar;

        public RegistroEstacionamento(int id, string placaCarro, DateTime dataEntrada)
        {
            this.id = id;
            this.placaCarro = placaCarro;
            this.dataEntrada = dataEntrada;
            this.isEstacionado = true;
            this.tempoEstacionado = null;
            this.valorCobrado = null;
            this.totalAPagar = null;
        }

        public RegistroEstacionamento()
        {
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setPlacaCarro(string placaCarro)
        {
            this.placaCarro = placaCarro;
        }

        public string getPlacaCarro()
        {
            return this.placaCarro;
        }

        public void setDataEntrada(DateTime dataEntrada)
        {
            this.dataEntrada = dataEntrada;
        }

        public DateTime getDataEntrada()
        {
            return this.dataEntrada;
        }

        public void setDataSaida(DateTime? dataSaida)
        {
            this.dataSaida = dataSaida;
        }

        public DateTime? getDataSaida()
        {
            return this.dataSaida;
        }

        public void setIsEstacionado(bool isEstacionado)
        {
            this.isEstacionado = isEstacionado;
        }

        public bool getIsEstacionado()
        {
            return this.isEstacionado;
        }

        public void setTempoEstacionado(TimeOnly? tempoEstacionado)
        {
            this.tempoEstacionado = tempoEstacionado;
        }

        public TimeOnly? getTempoEstacionado()
        {
            return this.tempoEstacionado;
        }

        public void setValorCobrado(decimal? valorCobrado)
        {
            this.valorCobrado = valorCobrado;
        }

        public decimal? getValorCobrado()
        {
            return this.valorCobrado;
        }

        public void setTotalAPagar(decimal? totalAPagar)
        {
            this.totalAPagar = totalAPagar;
        }

        public decimal? getTotalAPagar()
        {
            return this.totalAPagar;
        }

        public override string ToString()
        {
            return $"ID: {id}, Placa: {placaCarro}, Data Entrada: {dataEntrada}, Data Saida: {dataSaida}, Estacionado: {isEstacionado}, Tempo Estacionado: {tempoEstacionado}, Valor Cobrado: {valorCobrado}, Total a Pagar: {totalAPagar}";
        }
    }
}
