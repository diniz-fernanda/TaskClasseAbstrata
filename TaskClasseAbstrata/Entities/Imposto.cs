using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClasseAbstrata.Entities
{
    abstract class Imposto
    {
        protected Imposto(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public abstract double ImpostoPago();
    }
}
