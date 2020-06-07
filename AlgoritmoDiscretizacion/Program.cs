using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmoDiscretizacion {

    class Program {

        List<Double> fila1 = new List<double>() {
        5.1, 4.9, 4.7, 4.6, 5.0, 5.4, 4.6, 5.0, 4.4, 4.9, 5.4, 4.8, 4.8, 4.3, 5.8,
        5.7, 5.4, 5.1, 5.7, 5.1, 5.4, 5.1, 4.6, 5.1, 4.8, 5.0, 5.0, 5.2, 5.2, 4.7,
        4.8, 5.4, 5.2, 5.5, 4.9, 5.0, 5.5, 4.9, 4.4, 5.1, 5.0, 4.5, 4.4, 5.0, 5.1,
        4.8, 5.1, 4.6, 5.3, 5.0, 7.0, 6.4, 6.9, 5.5, 6.5, 5.7, 6.3, 4.9, 6.6, 5.2,
        5.0, 5.9, 6.0, 6.1, 5.6, 6.7, 5.6, 5.8, 6.2, 5.6, 5.9, 6.1, 6.3, 6.1, 6.4,
        6.6, 6.8, 6.7, 6.0, 5.7, 5.5, 5.5, 5.8, 6.0, 5.4, 6.0, 6.7, 6.3, 5.6, 5.5,
        5.5, 6.1, 5.8, 5.0, 5.6, 5.7, 5.7, 6.2, 5.1, 5.7, 6.3, 5.8, 7.1, 6.3, 6.5,
        7.6, 4.9, 7.3, 6.7, 7.2, 6.5, 6.4, 6.8, 5.7, 5.8, 6.4, 6.5, 7.7, 7.7, 6.0,
        6.9, 5.6, 7.7, 6.3, 6.7, 7.2, 6.2, 6.1, 6.4, 7.2, 7.4, 7.9, 6.4, 6.3, 6.1,
        7.7, 6.3, 6.4, 6.0, 6.9, 6.7, 6.9, 5.8, 6.8, 6.7, 6.7, 6.3, 6.5, 6.2, 5.9};

        List<Double> fila2 = new List<double>() {
        3.0, 3.4, 3.0, 2.5, 3.0, 3.3, 3.2, 2.7, 3.1, 3.1, 3.1, 3.0, 3.1, 3.4, 3.0,
        2.6, 2.8, 2.8, 3.8, 2.8, 3.0, 2.8, 3.0, 2.8, 3.2, 3.3, 2.7, 2.8, 2.8, 3.2,
        2.2, 2.6, 3.8, 3.0, 3.2, 2.8, 2.5, 3.0, 2.7, 3.2, 3.6, 2.5, 2.9, 2.5, 3.0,
        3.0, 2.9, 3.0, 2.7, 3.3, 2.8, 2.5, 2.9, 2.9, 3.0, 2.7, 2.3, 2.6, 3.0, 2.6,
        2.5, 3.0, 2.3, 3.1, 3.4, 3.0, 2.7, 2.7, 2.4, 2.4, 2.6, 2.9, 3.0, 2.8, 3.0,
        2.9, 2.8, 2.5, 2.8, 3.2, 2.5, 2.2, 2.7, 3.0, 3.1, 2.9, 2.9, 2.2, 3.0, 2.0,
        2.7, 2.9, 2.4, 3.3, 2.8, 2.8, 2.3, 3.1, 3.2, 3.2, 3.3, 3.7, 3.2, 3.8, 3.0,
        3.8, 3.5, 3.2, 2.3, 3.5, 3.4, 3.0, 3.1, 3.5, 3.2, 3.1, 4.2, 4.1, 3.4, 3.1,
        3.2, 3.4, 3.5, 3.4, 3.0, 3.4, 3.3, 3.6, 3.7, 3.4, 3.8, 3.8, 3.5, 3.9, 4.4,
        4.0, 3.0, 3.0, 3.4, 3.7, 3.1, 2.9, 3.4, 3.4, 3.9, 3.6, 3.1, 3.2, 3.0, 3.5};

        List<Double> fila3 = new List<double>() {
        1.4, 1.4, 1.3, 1.5, 1.4, 1.7, 1.4, 1.5, 1.4, 1.5, 1.5, 1.6, 1.4, 1.1, 1.2,
        1.5, 1.3, 1.4, 1.7, 1.5, 1.7, 1.5, 1.0, 1.7, 1.9, 1.6, 1.6, 1.5, 1.4, 1.6,
        1.6, 1.5, 1.5, 1.4, 1.5, 1.2, 1.3, 1.5, 1.3, 1.5, 1.3, 1.3, 1.3, 1.6, 1.9,
        1.4, 1.6, 1.4, 1.5, 1.4, 4.7, 4.5, 4.9, 4.0, 4.6, 4.5, 4.7, 3.3, 4.6, 3.9,
        3.5, 4.2, 4.0, 4.7, 3.6, 4.4, 4.5, 4.1, 4.5, 3.9, 4.8, 4.0, 4.9, 4.7, 4.3,
        4.4, 4.8, 5.0, 4.5, 3.5, 3.8, 3.7, 3.9, 5.1, 4.5, 4.5, 4.7, 4.4, 4.1, 4.0,
        4.4, 4.6, 4.0, 3.3, 4.2, 4.2, 4.2, 4.3, 3.0, 4.1, 6.0, 5.1, 5.9, 5.6, 5.8,
        6.6, 4.5, 6.3, 5.8, 6.1, 5.1, 5.3, 5.5, 5.0, 5.1, 5.3, 5.5, 6.7, 6.9, 5.0,
        5.7, 4.9, 6.7, 4.9, 5.7, 6.0, 4.8, 4.9, 5.6, 5.8, 6.1, 6.4, 5.6, 5.1, 5.6,
        6.1, 5.6, 5.5, 4.8, 5.4, 5.6, 5.1, 5.1, 5.9, 5.7, 5.2, 5.0, 5.2, 5.4, 5.1};

        List<Double> fila4 = new List<double>() {
        0.2, 0.2, 0.2, 0.2, 0.2, 0.4, 0.3, 0.2, 0.2, 0.1, 0.2, 0.2, 0.1, 0.1, 0.2,
        0.4, 0.4, 0.3, 0.3, 0.3, 0.2, 0.4, 0.2, 0.5, 0.2, 0.2, 0.4, 0.2, 0.2, 0.2,
        0.2, 0.4, 0.1, 0.2, 0.1, 0.2, 0.2, 0.1, 0.2, 0.2, 0.3, 0.3, 0.2, 0.6, 0.4,
        0.3, 0.2, 0.2, 0.2, 0.2, 1.4, 1.5, 1.5, 1.3, 1.5, 1.3, 1.6, 1.0, 1.3, 1.4,
        1.0, 1.5, 1.0, 1.4, 1.3, 1.4, 1.5, 1.0, 1.5, 1.1, 1.8, 1.3, 1.5, 1.2, 1.3,
        1.4, 1.4, 1.7, 1.5, 1.0, 1.1, 1.0, 1.2, 1.6, 1.5, 1.6, 1.5, 1.3, 1.3, 1.3,
        1.2, 1.4, 1.2, 1.0, 1.3, 1.2, 1.3, 1.3, 1.1, 1.3, 2.5, 1.9, 2.1, 1.8, 2.2,
        2.1, 1.7, 1.8, 1.8, 2.5, 2.0, 1.9, 2.1, 2.0, 2.4, 2.3, 1.8, 2.2, 2.3, 1.5,
        2.3, 2.0, 2.0, 1.8, 2.1, 1.8, 1.8, 1.8, 2.1, 1.6, 1.9, 2.0, 2.2, 1.5, 1.4,
        2.3, 2.4, 1.8, 1.8, 2.1, 2.4, 2.3, 1.9, 2.3, 2.5, 2.3, 1.9, 2.0, 2.3, 1.8};

        List<Double> valoresUnicos = new List<double>();
        List<Intervalo> intervalos = new List<Intervalo>();
        List<Double> esquemaD = new List<double>();
        Double minimo = 0.0, maximo = 0.0, caimGlobal;
        int s = 3;

        /// <summary>
        /// Metodo que inicia el proceso por fila
        /// </summary>
        /// <param name="listaDisponible"></param>
        public void IniciarAlgoritmo(List<Double> fila) {

            Console.WriteLine("");
            Console.WriteLine("==================================================");
            MinMax(fila);
            ValoresUnicos(fila);
            esquemaD.Clear();
            esquemaD.Add(this.minimo);
            esquemaD.Add(this.maximo);
            Console.WriteLine("");
            Console.WriteLine("D = " + ImprimirLista(this.esquemaD));
            this.caimGlobal = 0.0;
            Console.WriteLine("CAIM Global = " + this.caimGlobal);
            int k = 1;
            Boolean bandera = true;

            do {

                foreach (Double valor in this.valoresUnicos) {

                    List<Double> auxEsquemaD = new List<double>();

                    foreach(Double valor2 in esquemaD) {

                        auxEsquemaD.Add(valor2);
                    }

                    if(!auxEsquemaD.Contains(valor)) {

                        auxEsquemaD.Add(valor);
                        OrdenarLista(auxEsquemaD);
                        this.intervalos.Add(new Intervalo(
                            auxEsquemaD, CrearMatriz(auxEsquemaD, fila)));
                    }

                    auxEsquemaD.Clear();
                }

                Intervalo caimMayor = CAIMMayor(this.intervalos);
                
                if(caimMayor.caim > this.caimGlobal || k < s){

                    this.caimGlobal = caimMayor.caim;
                    this.esquemaD.Clear();
                } else {

                    bandera = false;
                    Console.WriteLine("");
                    Console.WriteLine("CAIM Global: " + this.caimGlobal);
                    Console.WriteLine("D: " + ImprimirLista(this.esquemaD));
                }

                k++;
                this.intervalos.Clear();
                foreach(Double valor in caimMayor.esquemaD) {

                    this.esquemaD.Add(valor);
                }

            } while (bandera == true);

            this.valoresUnicos.Clear();
        }

        /// <summary>
        /// Metodo que busca el minimo y el maximo de cada fila
        /// </summary>
        /// <param name="listaDisponible">Lista en la que buscara el minimo
        /// y el maximo</param>
        public void MinMax(List<Double> fila) {

            this.minimo = fila.Min();
            this.maximo = fila.Max();
            Console.WriteLine("");
            Console.WriteLine("Mínimo: " + this.minimo);
            Console.WriteLine("Máximo: " + this.maximo);
        }

        /// <summary>
        /// Metodo que obtiene los valores unicos del atributo
        /// </summary>
        /// <param name="listaDisponible"></param>
        public void ValoresUnicos(List<Double> fila) {

            foreach(Double valor in fila.OrderBy(x => x)) {

                if(!this.valoresUnicos.Contains(valor)) {

                    this.valoresUnicos.Add(valor);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("B = " + ImprimirLista(this.valoresUnicos));
        }

        /// <summary>
        /// Metodo para imprimir una lista
        /// </summary>
        /// <param name="listaDisponible">Lista que se desea imprimir</param>
        /// <returns>Variable String con la lista a imprimir</returns>
        public String ImprimirLista(List<Double> lista) {

            String impresion = "{ ";
            int tamanio = lista.Count;
            int iterador = 1;

            foreach(Double valor in lista) {

                if(iterador == tamanio) {

                    impresion += valor + " }";

                } else {

                    impresion += valor + ", ";
                }

                iterador++;
            }

            return impresion;
        }

        /// <summary>
        /// Metodo que crea la matrizCuantica de un intervalo
        /// </summary>
        /// <param name="esquema">esuqema posible</param>
        /// <param name="fila">Fila o f a utilizar</param>
        /// <returns>Matriz cunatica creada</returns>
        public int[,] CrearMatriz(List<Double> esquema, List<Double> fila) {

            int[,] matrizCuantica = new int[3, (esquema.Count - 1)];
            int elementosClase = 0, i = 0;

            while(i < 3) {

                foreach(Double valor in fila) {

                    for(int j = 0; j < (esquema.Count - 1); j++) {

                        if(j == esquema.Count-2) {

                            if(valor >= esquema[j] && valor <= esquema[j+1]) {
                                matrizCuantica[i, j] += 1;
                            }

                        } else {

                            if(valor >= esquema[j] && valor < esquema[j+1]) {
                                matrizCuantica[i, j] += 1;
                            }
                        }
                    }

                    elementosClase++;

                    if(elementosClase == 50) {
                        elementosClase = 0;
                        i++;
                    }
                }
            }

            return matrizCuantica;
        }

        /// <summary>
        /// Metodod que ordena la lista de menor a mayor
        /// </summary>
        /// <param name="lista"></param>
        public void OrdenarLista(List<Double> lista) {

            List<Double> auxiliar = new List<double>();

            foreach(Double valor in lista.OrderBy(x => x)) {

                auxiliar.Add(valor);
            }

            lista.Clear();

            foreach(Double valor in auxiliar) {

                lista.Add(valor);
            }
        }

        /// <summary>
        /// Metodod que encuentra el CAIM mayor de una lista
        /// </summary>
        /// <param name="lista">Lista proporcionada con Intervalos</param>
        /// <returns>Intervalo con el CAIM mayor</returns>
        public Intervalo CAIMMayor(List<Intervalo> lista) {

            Intervalo mayor = lista[0];

            foreach(Intervalo elemento in lista) {

                if(mayor.caim < elemento.caim) {

                    mayor = elemento;
                }
            }

            return mayor;
        }

        /// <summary>
        /// Metodo que inicia el algoritmo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {

            Console.WriteLine("");
            Console.WriteLine("=============== ALGORITMO DE CAIM ===============");
            Program algoritmo = new Program();
            algoritmo.IniciarAlgoritmo(algoritmo.fila1);
            algoritmo.IniciarAlgoritmo(algoritmo.fila2);
            algoritmo.IniciarAlgoritmo(algoritmo.fila3);
            algoritmo.IniciarAlgoritmo(algoritmo.fila4);
        }
    }
}
