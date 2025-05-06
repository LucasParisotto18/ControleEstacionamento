using GerenciaEstacionamento.Controller;
using GerenciaEstacionamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaEstacionamento.Service
{
    internal class EstacionamentoService
    {
        RegistroEstacionamento registroEstacionamento = new RegistroEstacionamento();
        TabelaPrecos tabelaPrecos = new TabelaPrecos();
        List<TabelaPrecos> listaTabelaPrecos = new List<TabelaPrecos>();


        public int getUltimoIDEstacionamento(List<RegistroEstacionamento> listaRegistroEstacionamento)
        {
            if (listaRegistroEstacionamento.Count == 0)
            {
                return 0;
            }
            return listaRegistroEstacionamento.Last().getId();
        }

        public int getUltimoIDPreco(List<TabelaPrecos> listaRegistroTabelaPrecos)
        {
            if (listaRegistroTabelaPrecos.Count == 0)
            {
                return 0;
            }
            return listaRegistroTabelaPrecos.Last().getId();
        }

        public TimeSpan calculartempoEstacionado(DateTime dataEntrada, DateTime dataSaida)
        {
            TimeSpan tempo = dataSaida - dataEntrada;
            return tempo;
        }

        public decimal calcularValorCobrado(RegistroEstacionamento registroEstacionamento, List<TabelaPrecos> listaTabelaPrecos)
        {
            int IDTabelaPreco = buscarIDTabelaPreco(listaTabelaPrecos, registroEstacionamento.getDataEntrada());
            if (IDTabelaPreco == -1)
            {
                return -1;
            }
            decimal custoHoraInicial = listaTabelaPrecos[IDTabelaPreco].getCustoHoraInicial();
            decimal custoHoraAdicional = listaTabelaPrecos[IDTabelaPreco].getCustoHoraAdicional();
            TimeSpan tempoEstacionado = registroEstacionamento.getTempoEstacionado().Value;
            decimal valorCobrado = 0;

            if (tempoEstacionado.TotalMinutes <= 30)
            {
                valorCobrado = custoHoraInicial / 2;
            } 
            else
            {
                if (tempoEstacionado.TotalMinutes <= 70)
                {
                    valorCobrado = custoHoraInicial;
                }
                 else
                    {
                    int horasAdicionais = (int)((int)tempoEstacionado.TotalMinutes / 60) - 1;
                    int restoDivisao = (int) tempoEstacionado.TotalMinutes % 60;
                        if (restoDivisao > 10)
                        {
                        horasAdicionais++;
                        }
                    valorCobrado = custoHoraInicial + (horasAdicionais * custoHoraAdicional);

                    }
            }

            return valorCobrado;
        }

        public int buscarIDTabelaPreco(List<TabelaPrecos> lstTabelaPreco, DateTime dataEntradaVeiculo)
        {
            for (int i = 0; i < lstTabelaPreco.Count; i++)
            {
                if (lstTabelaPreco[i].getDataInicioVigencia() <= dataEntradaVeiculo && lstTabelaPreco[i].getDataFinalVigencia() >= dataEntradaVeiculo)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool verificarDataEntradaTabelaPreco(List<TabelaPrecos> lstTabelaPreco, DateTime HorarioEntrada)
        {
            for (int i = 0; i < lstTabelaPreco.Count; i++)
            {
                if (lstTabelaPreco[i].getDataInicioVigencia() <= HorarioEntrada && lstTabelaPreco[i].getDataFinalVigencia() >= HorarioEntrada)
                {
                    return true;
                }
            }
            return false;

        }
        

        

    }
}
