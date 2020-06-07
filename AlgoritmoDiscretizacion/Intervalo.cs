using System;
using System.Collections.Generic;

namespace AlgoritmoDiscretizacion {

    class Intervalo {

        public List<Double> esquemaD = new List<double>();
        public Double caim;
        public int [,] matrizCuantica;

        /// <summary>
        /// contructor de la clase
        /// </summary>
        /// <param name="valoresK">Contiene el esquema de discreción </param>
        /// <param name="matriz"> Matriz cuantica</param>
        public Intervalo (List<Double> valoresD, int[,] matriz) {

            foreach(Double valor in valoresD) {

                esquemaD.Add(valor);
            }

            matrizCuantica = matriz;
            CalcularCAIM();
        }

        /// <summary>
        /// Metodo que calcula CAIM
        /// </summary>
        public void CalcularCAIM () {

            double suma = 0;

            for (int i = 0; i < 3; i++) {

                suma += ((Math.Pow(ObtenerMayor(i), 2)) / SumaColumna(i));
            }

            this.caim = (suma / (esquemaD.Count - 1));
        }

        /// <summary>
        /// Metodod que obtiene el valor mayor cierta columan
        /// </summary>
        /// <param name="i">Columna a obtener el mayor</param>
        /// <returns>El valor mayor</returns>
        public int ObtenerMayor (int i) {

            int mayor = this.matrizCuantica [i, 0];

            for (int j = 1; j < (esquemaD.Count-1); j++) {

                if (mayor < this.matrizCuantica[i,j]) {

                    mayor = this.matrizCuantica [i, j];
                }
            }

            return mayor;
        }

        /// <summary>
        /// Metodo que suma la columan
        /// </summary>
        /// <param name="i">Columan a sumar</param>
        /// <returns>La suma de la columna</returns>
        public int SumaColumna (int i) {

            int resultado = 0;

            for (int j = 0; j < (esquemaD.Count-1); j++) {

                resultado += this.matrizCuantica [i, j];
            }

            return resultado;
        }

        public void ImprimirD () {

            String lista = "{ ";
            int tamanio = this.esquemaD.Count;
            int iterador = 1;

            foreach (Double valor in this.esquemaD) {

                if (iterador == tamanio) {

                    lista += valor + " }";

                } else {

                    lista += valor + ", ";
                }

                iterador++;
            }

            Console.WriteLine("");
            Console.WriteLine("Esquema D = " + lista);
        }

        public void ImprimirMatriz () {

            String fila = "";

            for (int i = 0; i < 3; i++) {

                for (int j = 0; j < this.esquemaD.Count-1; j++) {

                    fila += this.matrizCuantica [i, j] + ", ";
                }

                Console.WriteLine("");
                Console.WriteLine(fila);
                fila = "";
            }
        }
    }
}
