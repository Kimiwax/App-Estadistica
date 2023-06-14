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
    public partial class CalcularDesagrupados : Form
    {
        public CalcularDesagrupados()
        {
            InitializeComponent();
        }

        private void btn_desagrupados_Click(object sender, EventArgs e)
        {
            if (txt_desagrupados.Text != "")
            {
                double variableQueSeEstaCargando = 0;
                int agregarFila = 0;

                variableQueSeEstaCargando = Convert.ToDouble(txt_desagrupados.Text);
                agregarFila = dgv_Estadistica.Rows.Add();
                Variables.listaDeVariablesIngresadasDesa.Add(variableQueSeEstaCargando);
                txt_desagrupados.Clear();
                
                dgv_Estadistica.Rows[agregarFila].Cells[0].Value = (variableQueSeEstaCargando);
                btn_listo.Enabled = true;
                
            }
        }

        private void btn_listo_Click(object sender, EventArgs e)
        {
            Variables.listaDeVariablesIngresadasDesa.Sort();
            Variables.listaDeFrecuenciasDesagrupadas = Variables.listaDeVariablesIngresadasDesa.Distinct().ToList();
            Variables.listaDeFrecuenciasDesagrupadas.Sort();

            dgv_Estadistica.Rows.Clear();

            for (int i = 0; i < Variables.listaDeFrecuenciasDesagrupadas.Count; i++)
            {
                dgv_Estadistica.Rows.Add();
                dgv_Estadistica.Rows[i].Cells[0].Value = Convert.ToString(Variables.listaDeFrecuenciasDesagrupadas[i]);
                Variables.VariablesDesagrupadasFinal.Add(Variables.listaDeFrecuenciasDesagrupadas[i]);
            }

            for (int i = 0; i < Variables.listaDeFrecuenciasDesagrupadas.Count; i++)
            {
                int contador = 0;

                for (int index = 0; index < Variables.listaDeVariablesIngresadasDesa.Count; index++)
                {
                    if (Variables.listaDeFrecuenciasDesagrupadas[i] == Variables.listaDeVariablesIngresadasDesa[index])
                    {
                        contador += 1;
                    }
                
                }
                
                
                dgv_Estadistica.Rows[i].Cells[1].Value = contador;
            }

            foreach (DataGridViewRow rows in dgv_Estadistica.Rows)
            {
                
                int celda = Convert.ToInt32(rows.Cells[1].Value);

                Variables.FrecuenciasDesagrupadasFinal.Add(celda);
                VariablesEst.Variables.frecuenciaAbsTotal += celda;
            }

            Metodos.CargaDeFrecuenciaAbsAcumulada(Variables.FrecuenciasDesagrupadasFinal, Variables.listaDeFrecuenciaAcumulada, dgv_Estadistica);
            Metodos.CalculoDeMediaDesa(Variables.FrecuenciasDesagrupadasFinal, dgv_Estadistica, Variables.VariablesDesagrupadasFinal);
            Metodos.CargaDeColVarianza(Variables.FrecuenciasDesagrupadasFinal, dgv_Estadistica, Variables.VariablesDesagrupadasFinal);
            Metodos.CalculoDeModa(Variables.FrecuenciasDesagrupadasFinal, dgv_Estadistica);
            Metodos.CalculoCoeficienteVari(Variables.desvioStandard, Variables.mediaVal);
            Metodos.CalculoDeMediana(dgv_Estadistica);
            Metodos.CalculoDeVarianza(Variables.colVarianzaTotal, Variables.frecuenciaAbsTotal);
            Metodos.CalculoDesvioStandard(Variables.varianza);
            Metodos.CalculoCoeficienteVari(Variables.desvioStandard, Variables.mediaVal);


            lbl_mediaVacio.Text = Convert.ToString(Variables.mediaVal);
            lbl_modaVacio.Text = Convert.ToString(Variables.moda);
            lbl_medianaVacio.Text = Convert.ToString(Variables.mediana);
            lbl_cvVacio.Text = Convert.ToString(Variables.varianza);
            lbl_desvioStanVacio.Text = Convert.ToString(Variables.desvioStandard);
            lbl_CoefiVa.Text = Convert.ToString(Variables.cv);

            Dictionary<double, double> dict = new Dictionary<double, double>();

            for (int i = 0; i < Variables.VariablesDesagrupadasFinal.Count; i++)
            {
                dict.Add(Variables.VariablesDesagrupadasFinal[i], Variables.FrecuenciasDesagrupadasFinal[i]);
                // Add series.
                Series series = this.chart_grafico1.Series.Add(Convert.ToString(Variables.VariablesDesagrupadasFinal[i]));

                foreach (KeyValuePair<double, double> d in dict)
                {
                    //chart_grafico1.Series["Series1"].Points.AddXY(d.Key, d.Value);
                    series.Palette = ChartColorPalette.BrightPastel;
                    series.Points.AddXY(d.Key, d.Value);
                }
                //// Add point.
                //series.Points.Add(Variables.listaDeFrecuencias[i]);
            }
            btn_listo.Enabled = false;
            btn_listo.FlatAppearance.BorderColor = Color.FromArgb(66, 69, 68);
            btn_listo.ForeColor = Color.Gray;
            btn_desagrupados.Enabled = false;
            btn_desagrupados.FlatAppearance.BorderColor = Color.FromArgb(66, 69, 68);
            btn_desagrupados.ForeColor = Color.FromArgb(66, 69, 68);
         
               
        }

        private void btn_nuevoCalculo_Click(object sender, EventArgs e)
        {
        //    Variables.variableIngresada = 0;
        //    Variables.frecuenciaAbsTotal= 0;
        //Variables.media= 0;
        //Variables.mediaVal= 0;
        //Variables.moda= 0;
        //Variables.mediana= 0;
        //Variables.varianza= 0;
        //Variables.colVarianzaTotal= 0;
        //Variables.desvioStandard= 0;
        //Variables.cv= 0;

       

        //List<double> listaDeVariablesIngresadas = new List<double>();
        //List<double> listaDeFrecuencias = new List<double>();
        //List<double> listaDeFrecuenciaAcumulada = new List<double>();
        //List<double> listaDeVariablesIngresadasDesa = new List<double>();
        //List<double> listaDeFrecuenciasDesagrupadas = new List<double>();
        //List<double> FrecuenciasDesagrupadasFinal = new List<double>();
        // List<double> VariablesDesagrupadasFinal = new List<double>();
        // dgv_Estadistica.Rows.Clear();
            Application.Restart();
        }
    }
}
