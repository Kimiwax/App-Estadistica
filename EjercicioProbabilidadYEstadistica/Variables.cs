using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariablesEst
{
    public class Variables
    {
        public static double variableIngresada;
        public static double frecuenciaAbsTotal;
        public static double media;
        public static double mediaVal;
        public static double moda;
        public static double mediana;
        public static double varianza;
        public static double colVarianzaTotal;
        public static double desvioStandard;
        public static double cv;

        public static bool numRepetido = false;
       

        public static List<double> listaDeVariablesIngresadas = new List<double>();
        public static List<double> listaDeFrecuencias = new List<double>();
        public static List<double> listaDeFrecuenciaAcumulada = new List<double>();
        public static List<double> listaDeVariablesIngresadasDesa = new List<double>();
        public static List<double> listaDeFrecuenciasDesagrupadas = new List<double>();
        public static List<double> FrecuenciasDesagrupadasFinal = new List<double>();
         public static List<double> VariablesDesagrupadasFinal = new List<double>();
    }
}
