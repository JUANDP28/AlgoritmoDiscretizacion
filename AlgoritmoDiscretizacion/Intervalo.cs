using System;
using System.Collections.Generic;

namespace AlgoritmoDiscretizacion {

    class Intervalo {

        List<Double> k = new List<double>();
        Double CAIM;
        int [,] matrizCuantica;

        public Intervalo (List<Double> valoresK, int numeroIntervalos) {

            foreach (Double valor in valoresK) {

                k.Add(valor);
            }

            matrizCuantica = new int[4, numeroIntervalos];
        }
    }
}
