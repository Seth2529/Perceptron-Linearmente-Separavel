﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron_Linearmente_Separavel
{
    public class Pesos
    {
        public Pesos(double w1, double w2)
        {
            W1 = w1;
            W2 = w2;
        }
        public void AjustarPesos(double novoW1, double novoW2)
        {
            W1 = novoW1;
            W2 = novoW2;
        }

        public Pesos()
        {
            GerarAleatorio();
        }

        public double W1 { get; private set; }
        public double W2 { get; private set; }

        private static Random random = new Random(); // Valores aleatórios
        private void GerarAleatorio()
        {
            W1 = random.NextDouble();
            W2 = random.NextDouble();
        }

    }
}
