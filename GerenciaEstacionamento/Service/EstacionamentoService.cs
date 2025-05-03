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



        public int getUltimoID(List<RegistroEstacionamento> listaRegistroEstacionamento)
        {
            if (listaRegistroEstacionamento.Count == 0)
            {
                return 0;
            }
            return listaRegistroEstacionamento.Last().getId();
        }

    }
}
