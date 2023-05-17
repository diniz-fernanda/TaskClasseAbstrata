using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClasseAbstrata.Entities
{
    class PessoaFisica : Imposto
    {
        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base (nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }
        public double GastoSaude { get; set; }

        public override double ImpostoPago()
        {
            if(RendaAnual < 20000.0)
            {
                return RendaAnual * 0.15 - GastoSaude * 0.5;
            }
            else 
            {
                return RendaAnual * 0.25 - GastoSaude * 0.5;
            }
                       
        }
    }
}
