using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VariablesEst;
using MetodosEst;

namespace EjercicioProbabilidadYEstadistica
{
    public partial class Calcular : Form
    {
        public Calcular()
        {
            InitializeComponent();
        }
        List<double> listvariables = new List<double>();
        List<int> frecuencia = new List<int>();
        List<double> frecuenciaAcu = new List<double>();
        public static double variableAg;
        public static int frecuenciaAg;
        public static double media;
        public static double frecuenciaAbsolutaTotal;
        public static int contador = 0;
        public int agregarFila;
        public int index5 = 0;
        public int medianaFinal = 0;
        public string medianaFinalDos = " ";
        public static bool habilitar = false;
        public static bool habilitar2 = false;

        private void btn_agrupados_Click(object sender, EventArgs e)
        {


            if (txt_agrupados.Text != "")
            {

                Metodos.CargarVariablesADGV(dgv_Estadistica, txt_agrupados, Variables.listaDeVariablesIngresadas);
                Variables.listaDeVariablesIngresadas.Sort();
                txt_agrupados.Clear();
                btn_frecuencia.Enabled = true;
                habilitar = true;
            }
            else
            {
                MessageBox.Show("Debe Ingresar Una Variable");
            }
            
        }
        int contador2 = 0;

        private void btn_frecuencia_Click(object sender, EventArgs e)
        {
            btn_agrupados.Enabled = false;
            btn_agrupados.FlatAppearance.BorderColor = Color.FromArgb(66, 69, 68);
            btn_agrupados.ForeColor = Color.FromArgb(66, 69, 68);

                if (txt_frecuencia.Text != "" && contador2 <= dgv_Estadistica.Rows.Count)
                {

                    Metodos.CargaDeFrecuencias(dgv_Estadistica, txt_frecuencia, Variables.listaDeFrecuencias, contador2);
                    contador2 += 1;
                }
                else
                {
                    MessageBox.Show("tiro error porque me la re banco");
                }


            if (contador2 == dgv_Estadistica.Rows.Count && contador2 != 0)
            {
                btn_frecuencia.Enabled = false;
                btn_frecuenciaAcumulada.Enabled = true;
                btn_frecuencia.FlatAppearance.BorderColor = Color.FromArgb(66, 69, 68);
                    btn_frecuencia.ForeColor = Color.FromArgb(66, 69, 68);
                habilitar2 = true;
            }

            
                
        }

  

        private void txt_frecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }


        }
        
        

        private void btn_frecuenciaAcumulada_Click(object sender, EventArgs e)
        {
            
            if (habilitar == true && habilitar2 == true)
            {
                
                   
                
                Metodos.CargaDeFrecuenciaAbsAcumulada(Variables.listaDeFrecuencias, Variables.listaDeFrecuenciaAcumulada, dgv_Estadistica);

                Metodos.CalculoDeMedia(Variables.listaDeFrecuencias, dgv_Estadistica, Variables.listaDeVariablesIngresadas);

                Metodos.CargaDeColVarianza(Variables.listaDeFrecuencias, dgv_Estadistica, Variables.listaDeVariablesIngresadas);

                Metodos.CalculoDeModa(Variables.listaDeFrecuencias, dgv_Estadistica);

                Metodos.CalculoCoeficienteVari(Variables.desvioStandard, Variables.mediaVal);

                Metodos.CalculoDeMediana(dgv_Estadistica);
                Metodos.CalculoDeVarianza(Variables.colVarianzaTotal, Variables.frecuenciaAbsTotal);
                Metodos.CalculoDesvioStandard(Variables.varianza);
                Metodos.CalculoCoeficienteVari(Variables.desvioStandard, Variables.mediaVal);

                lbl_mediaVacio.Text = Convert.ToString(Metodos.TruncarNumeros(Variables.mediaVal, 6));
                lbl_modaVacio.Text = Convert.ToString(Variables.moda);
                lbl_medianaVacio.Text = Convert.ToString(Variables.mediana);
                lbl_cvVacio.Text = Convert.ToString(Metodos.TruncarNumeros(Variables.varianza, 6));
                lbl_desvioStanVacio.Text = Convert.ToString(Metodos.TruncarNumeros(Variables.desvioStandard, 6));
                lbl_CoefiVa.Text = Convert.ToString(Metodos.TruncarNumeros(Variables.cv, 6));


                //chart_grafico1.Series["Series1"].ChartType = SeriesChartType.Column;
                //chart_grafico1.Series["Series1"].BorderWidth = 5;
                //chart_grafico1.Series["Series1"].Palette = ChartColorPalette.Pastel;
                //chart_grafico1.Series["Series1"].LegendText = "Agrupados";



                Dictionary<double, double> dict = new Dictionary<double, double>();

                for (int i = 0; i < Variables.listaDeVariablesIngresadas.Count; i++)
                {
                    dict.Add(Variables.listaDeVariablesIngresadas[i], Variables.listaDeFrecuencias[i]);
                    // Add series.
                    Series series = this.chart_grafico1.Series.Add(Convert.ToString(Variables.listaDeVariablesIngresadas[i]));
                    


                    foreach (KeyValuePair<double, double> d in dict)
                    {
                        
                        series.Palette = ChartColorPalette.BrightPastel;
                        series.BorderWidth = 5;
                        series.Points.AddXY(d.Key, d.Value);
                        
                    }
                    //// Add point.
                    //series.Points.Add(Variables.listaDeFrecuencias[i]);
                }
            }
            else
            {
                MessageBox.Show("No se puede realizar el calculo sin todos los datos necesarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btn_frecuenciaAcumulada.Enabled = false;
            btn_frecuenciaAcumulada.FlatAppearance.BorderColor = Color.FromArgb(66, 69, 68);
            btn_frecuenciaAcumulada.ForeColor = Color.FromArgb(66, 69, 68);

        }

        private void btn_nuevoCalculo_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txt_agrupados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == Convert.ToChar(8))
            {

            }
            else if (e.KeyChar == ','){
                TextBox objtextBox = (TextBox)sender;
                if (objtextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }
       
    }
}
