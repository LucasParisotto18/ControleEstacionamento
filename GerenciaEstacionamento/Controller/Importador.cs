using GerenciaEstacionamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaEstacionamento.Controller
{
    internal class Importador
    {

        public Importador()
        {
        }

        public List<RegistroEstacionamento> importarDadosEstacionamento(String caminhoArq)
        {
            List<RegistroEstacionamento> listaRegistroEstacionamento = new List<RegistroEstacionamento>();

            try
            {
                using (StreamReader sr = new StreamReader(caminhoArq))
                {
                    String linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        String[] dados = linha.Split(';');
                        RegistroEstacionamento registroEstacionamento = new RegistroEstacionamento();
                        registroEstacionamento.setId(int.Parse(dados[0]));
                        registroEstacionamento.setPlacaCarro(dados[1]);
                        registroEstacionamento.setDataEntrada(DateTime.Parse(dados[2]));
                        if (string.IsNullOrEmpty(dados[3]))
                        {
                            registroEstacionamento.setDataSaida(null);
                        }
                        else
                        {
                            registroEstacionamento.setDataSaida(DateTime.Parse(dados[3]));
                        }
                        registroEstacionamento.setIsEstacionado(bool.Parse(dados[4]));
                        if (string.IsNullOrEmpty(dados[5]))
                        {
                            registroEstacionamento.setTempoEstacionado(null);
                        }
                        else
                        {
                            registroEstacionamento.setTempoEstacionado(TimeSpan.Parse(dados[5]));
                        }
                        if (string.IsNullOrEmpty(dados[6]))
                        {
                            registroEstacionamento.setValorCobrado(null);
                        }
                        else
                        {
                            registroEstacionamento.setValorCobrado(decimal.Parse(dados[6]));
                        }
                        if (string.IsNullOrEmpty(dados[7]))
                        {
                            registroEstacionamento.setTotalAPagar(null);
                        }
                        else
                        {
                            registroEstacionamento.setTotalAPagar(decimal.Parse(dados[7]));
                        }
                        listaRegistroEstacionamento.Add(registroEstacionamento);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro ao importar dados do estacionamento: " + ex.Message);
            }
            return listaRegistroEstacionamento;
        }

        public List<TabelaPrecos> importarDadosTabelaPreco(String caminhoArq)
        {
            List<TabelaPrecos> listaTabelaPreco = new List<TabelaPrecos>();
            try
            {
                using (StreamReader sr = new StreamReader(caminhoArq))
                {
                    String linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        String[] dados = linha.Split(';');
                        TabelaPrecos tabelaPreco = new TabelaPrecos();
                        tabelaPreco.setId(int.Parse(dados[0]));
                        tabelaPreco.setDataInicioVigencia(DateTime.Parse(dados[1]));
                        tabelaPreco.setDataFinalVigencia(DateTime.Parse(dados[2]));
                        tabelaPreco.setCustoHoraInicial(decimal.Parse(dados[3]));
                        tabelaPreco.setCustoHoraAdicional(decimal.Parse(dados[4]));
                        listaTabelaPreco.Add(tabelaPreco);
                    }

                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro ao importar dados da tabela de preços: " + ex.Message);
            }

            return listaTabelaPreco;
        }

        public void exportarDadosEstacionamento(List<RegistroEstacionamento> listaRegistroEstacionamento, String caminhoArq)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoArq))
                {
                    foreach (RegistroEstacionamento registroAtual in listaRegistroEstacionamento)
                    {
                        sw.WriteLine($"{registroAtual.getId()};{registroAtual.getPlacaCarro()};{registroAtual.getDataEntrada()};" +
                            $"{registroAtual.getDataSaida()};{registroAtual.getIsEstacionado()};{registroAtual.getTempoEstacionado()};" +
                            $"{registroAtual.getValorCobrado()};{registroAtual.getTotalAPagar()}");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro ao salvar os dados do estacionamento: " + ex.Message);
            }
        }

        public void exportarDadosTabelaPreco(List<TabelaPrecos> listaTabelaPrecos, String caminhoArq)
        {
            try
            {
                using (StreamWriter sr = new StreamWriter(caminhoArq))
                {
                    foreach (TabelaPrecos tabelaPrecosAtual in listaTabelaPrecos)
                    {
                        sr.WriteLine($"{tabelaPrecosAtual.getId()};{tabelaPrecosAtual.getDataInicioVigencia()};{tabelaPrecosAtual.getDataFinalVigencia()};" +
                            $"{tabelaPrecosAtual.getCustoHoraInicial()};{tabelaPrecosAtual.getCustoHoraAdicional()}");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro ao salvar os dados da tabela de preços: " + ex.Message);
            }
        }
    }
}

