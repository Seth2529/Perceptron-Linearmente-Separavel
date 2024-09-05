using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Perceptron_Linearmente_Separavel
{
        public class NeuronioArtificial
        {
            public Pesos pesos { get; private set; }

            public double o { get; private set; } //resultado do calculo do x1 * w1 + x2 * w2 (combinação linear)

            public double taxaAprendizado { get; private set; }

            public NeuronioArtificial(double pTaxaAprendizado)
            {
                o = 0.0;
                taxaAprendizado = pTaxaAprendizado;
                pesos = new Pesos();
                this.taxaAprendizado = taxaAprendizado;

            }

        public void Treinar(List<Entradas> listaEntradas)
        {

            foreach (var item in listaEntradas)
            {
                o = item.Entrada1 * pesos.W1
                    + item.Entrada2 * pesos.W2;
                if (FuncaoClassificacao(o) != item.ResultadoEsperado)
                {
                    double erro = item.ResultadoEsperado - FuncaoClassificacao(o);
                    RecalcularNovoPeso(erro, item);
                }

            }
        }

        private int FuncaoClassificacao(double o)
        {
            if (o >= 0) return 1; return 0;
        }


        private bool CalcularErro()
        {
            return true;
        }

        private void RecalcularNovoPeso(double erro, Entradas entrada)
        {
            double novoW1 = pesos.W1 + taxaAprendizado * erro * entrada.Entrada1;
            double novoW2 = pesos.W2 + taxaAprendizado * erro * entrada.Entrada2;
        pesos.AjustarPesos(novoW1, novoW2);
        }


        public int Perguntar(double X1, double X2)
        {
            double resultado = X1 * pesos.W1 + X2 * pesos.W2;
            return FuncaoClassificacao(resultado);
        }
    }
}

