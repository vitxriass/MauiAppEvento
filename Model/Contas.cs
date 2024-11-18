using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEvento.model
{
    public class contas
    {
        public Locais LocalSelecionado { get; set; }
        public int QntParticipantes { get; set; }
        public DateTime Datainicio { get; set; }
        public DateTime Datafim { get; set; }
        public int Dias
        {
            get => Datafim.Subtract(Datainicio).Days;
        }
        public double ValorTotal
        {

            get
            {
                double total = QntParticipantes * LocalSelecionado.Vdiaria; return total;
            }

        }
    }
}