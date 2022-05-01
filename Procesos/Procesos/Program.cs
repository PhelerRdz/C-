using System;
using System.Collections.Generic;

namespace Procesos{
    class Program{
        static void Main(string[] args){
            //INSTANCIAS
            List<int> ActivosDatos = new List<int>();
            Boolean band = false;
            int memoria, numdatos,limpiar=0,y=0;

            //SOLICITAR MEMORIA Y PROCESOS
            Console.Write("Memoria Maxima a utilizar: ");
            memoria = Int32.Parse(Console.ReadLine());
            Console.Write("\nNumero de Datos: ");
            numdatos = Int32.Parse(Console.ReadLine());

            //INSTANCIAS
            string[] NombreDatos = new string[numdatos];
            int [] MemoriaDatos = new int[numdatos];
            int[] UsoDatos = new int[numdatos];
            int[] SalidaDatos = new int[numdatos];

            //SOLICITAR DATOS (CICLO)
            for (int i = 0; i < numdatos; i++){
                Console.Write("\nNombre del "+(i+1)+"° Valor: ");
                NombreDatos[i] = Console.ReadLine();
                Console.Write("\nMemoria Necesaria del Proceso: ");
                MemoriaDatos[i] = Int32.Parse(Console.ReadLine());
                Console.Write("\nTiempo de Uso del Proceso: ");
                UsoDatos[i] = Int32.Parse(Console.ReadLine());
            }

            //METODO GENERAL
            for (int i = 0; i < numdatos; i++){
                if (memoria>=MemoriaDatos[i]){
                    if (band==false){
                        memoria = memoria - MemoriaDatos[i];
                        SalidaDatos[i] = UsoDatos[i];
                        ActivosDatos.Add(i);
                    }else{
                        memoria = memoria - MemoriaDatos[i];
                        SalidaDatos[i] = UsoDatos[i] + limpiar;
                        ActivosDatos.Add(i);
                    }
                }else{
                    band = true;
                    //METODO RECUPERAR MEMORIA (ELIMINACION DE PROCESO EN LISTA)
                    do{
                        for (int j = 0; j < ActivosDatos.Count; j++){
                            if (j == 0){
                                limpiar = SalidaDatos[ActivosDatos[j]];
                                y = j;
                            }else{
                                if (limpiar > SalidaDatos[ActivosDatos[j]]){
                                    limpiar = SalidaDatos[ActivosDatos[j]];
                                    y = j;
                                }
                            }
                        }
                        memoria = memoria + MemoriaDatos[ActivosDatos[y]];
                        ActivosDatos.RemoveAt(y);
                        ActivosDatos.Sort();
                    } while (memoria < MemoriaDatos[i]);
                    memoria = memoria - MemoriaDatos[i];
                    SalidaDatos[i] = UsoDatos[i]+limpiar;
                    ActivosDatos.Add(i);
                }
            }

            //IMPRESION DE TABLA
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("|    Proceso    |    Memoria    | Tiempo de Uso | Tiempo Salida |");
            for (int i = 0; i < numdatos; i++){
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("|\t" + NombreDatos[i] + "\t|\t" + MemoriaDatos[i] + "\t|\t" + UsoDatos[i] + "\t|\t" + SalidaDatos[i] + "\t|");
                if (i==numdatos-1){
                    Console.WriteLine("----------------------------------------------------------------");
                }
            }
            Console.ReadKey();
        }
    }
}