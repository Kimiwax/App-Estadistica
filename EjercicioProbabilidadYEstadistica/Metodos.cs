using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VariablesEst;

namespace MetodosEst
{
    public class Metodos
    {
        public static void CargarVariablesADGVDesagrupados()
        {
            


        }

        public static void CargarVariablesADGV(DataGridView dgv, TextBox txt, List<double> listaP)
        {
            double variableQueSeEstaCargando = 0;
            int agregarFila = 0;
            variableQueSeEstaCargando = Convert.ToDouble(txt.Text);
            Variables.numRepetido = false;
            for (int i = 0; i < listaP.Count(); i++)
            {
                if (variableQueSeEstaCargando == listaP[i])
                {
                    MessageBox.Show("numero repetido");
                    Variables.numRepetido = true;
                }
            }

            if (Variables.numRepetido == false)
            {
                

                agregarFila = dgv.Rows.Add();

                listaP.Add(variableQueSeEstaCargando);

                dgv.Rows[agregarFila].Cells[0].Value = (variableQueSeEstaCargando);
                dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
            }
            //variableQueSeEstaCargando = Convert.ToDouble(txt.Text);
            //agregarFila = dgv.Rows.Add();

            //listaP.Add(variableQueSeEstaCargando);

            //dgv.Rows[agregarFila].Cells[0].Value = (variableQueSeEstaCargando);
            //dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
        }

        public static void CargaDeFrecuencias(DataGridView dgv, TextBox txt, List<double> listaF, int contador)
        {
            int contador1 = contador;
            double contenedorDeFrecuencia = 0;

            contenedorDeFrecuencia = Convert.ToDouble(txt.Text);
            listaF.Add(Convert.ToDouble(txt.Text));
            dgv.Rows[contador].Cells[1].Value = (txt.Text);
            txt.Clear();

            VariablesEst.Variables.frecuenciaAbsTotal += contenedorDeFrecuencia;
        }

        public static void CargaDeFrecuenciaAbsAcumulada(List<double> listaF, List<double> listaFAcum, DataGridView dgv)
        {
            int contador = 0;
            int guardaValores = 0;

            foreach (int i in listaF)
            {
                listaFAcum.Add(i + guardaValores);
                dgv.Rows[contador].Cells[2].Value = (i + guardaValores);
                guardaValores = guardaValores + i;
                contador += 1;
            }

        }

        public static void CalculoDeMedia(List<double> listaF, DataGridView dgv, List<double> listaV)
        {
            int contador = 0;

            foreach (int i in listaV)
            {
                dgv.Rows[contador].Cells[3].Value = ((listaV[contador] * listaF[contador]));

                Variables.mediana = Variables.mediana + Variables.listaDeFrecuencias[contador];

                Variables.media = Variables.media + (listaV[contador] * listaF[contador]);
                contador += 1;
            }
            Variables.mediaVal = Variables.media / Variables.frecuenciaAbsTotal;
        }


        public static void CalculoDeMediaDesa(List<double> listaF, DataGridView dgv, List<double> listaV)
        {
            int contador = 0;

            foreach (int i in listaV)
            {
                dgv.Rows[contador].Cells[3].Value = ((listaV[contador] * listaF[contador]));

                Variables.mediana = Variables.mediana + Variables.FrecuenciasDesagrupadasFinal[contador];

                Variables.media = Variables.media + (listaV[contador] * listaF[contador]);
                contador += 1;
            }
            Variables.mediaVal = Variables.media / Variables.frecuenciaAbsTotal;
        }

        public static void CargaDeColVarianza(List<double> listaF, DataGridView dgv, List<double> listaV)
        {
            int contador = 0;
            foreach (int index in listaF)
            {
                dgv.Rows[contador].Cells[4].Value = ((listaV[contador] * listaV[contador]) * index);

                Variables.colVarianzaTotal = Variables.colVarianzaTotal + (listaV[contador] * listaV[contador]) * Convert.ToDouble(index);
                contador += 1;
            }
        }

        public static void CalculoDeModa(List<double> listaF, DataGridView dgv)
        {
            

            double valorMayorEnLaLista = listaF.Max();
            int valorDelIndice = listaF.IndexOf(valorMayorEnLaLista);
    

            foreach (DataGridViewRow row in dgv.Rows)
            {
                int indexDeFila = row.Index;

                if (indexDeFila == valorDelIndice)
                {
                    Variables.moda = Convert.ToDouble(dgv.Rows[valorDelIndice].Cells[0].Value);
                }

            }
        }

        public static void CalculoDeMediana(DataGridView dgv)
        {
            int contador = 0;
            double medianaAux = Convert.ToDouble( Variables.frecuenciaAbsTotal) / 2;

            foreach (DataGridViewRow rows in dgv.Rows)
            {
                
                int celda = Convert.ToInt32(rows.Cells[2].Value);

                if (celda >= medianaAux)
                {
                    int indexDeFila = rows.Index;
                    Variables.mediana = Convert.ToDouble(dgv.Rows[indexDeFila].Cells[0].Value);
                    break;
                }
                contador += 1;
            }
        }

        public static void CalculoDeVarianza(double val1, double val2)
        {
            double numeroAux = Variables.mediaVal;
            double numeroAux2 = Math.Pow(numeroAux, 2);
            Variables.varianza = (val1 / val2) - numeroAux2;
        }

        public static void CalculoDesvioStandard(double varianza)
        {
            Variables.desvioStandard = Math.Sqrt(varianza);
        }

        public static void CalculoCoeficienteVari(double desvioS, double mediaVal)
        {
            Variables.cv = desvioS / mediaVal;
        }

        public static double TruncarNumeros(double value, int decimales)
        {
            double val = Math.Pow(10, decimales);
            return (Math.Truncate(value * val) / val);
        }
    }
}
