using Randomizer;
using Randomizer.Classes;
using Randomizer.Helpers;
using Randomizer.HypothesisTests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsApp.Classes;

namespace SIM_Front
{
    public partial class Form1 : Form
    {
        private List<RandomGridValue> fullGridSample { get; set; } = new List<RandomGridValue>();
        private List<double> fullUnformatedSample { get; set; } = new List<double>();

        private Dictionary<string, IEnumerable<double>> intervals { get; set; } = new Dictionary<string, IEnumerable<double>>();
        private double accResult { get; set; } = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargamos los posibles metodos generadores de números
            var comboMetodosSource = new List<ComboBoxItemClass>()
            {
                new ComboBoxItemClass(0, "Método Congruencial Lineal"),
                new ComboBoxItemClass(1, "Método Congruencial Multiplicativo"),
                new ComboBoxItemClass(2, "Método Nativo .Net")
            };

            cmb_metodos.ValueMember = "Value";
            cmb_metodos.DisplayMember = "Text";
            cmb_metodos.DataSource = comboMetodosSource;

            //Bloqueo los campos que no apliquen
            int selectedMethod = Int32.Parse(cmb_metodos.SelectedValue.ToString());
            EnableParameterFields(selectedMethod);

            //Cargamos los posibles grados de significancia
            var comboGradosSignificanciaSource = new List<ComboBoxItemClass>();
            foreach (var item in CriticalValues.GetSignificantValues())
            {
                comboGradosSignificanciaSource.Add(new ComboBoxItemClass(item, item.ToString()));
            }

            cmb_significantValue.ValueMember = "Value";
            cmb_significantValue.DisplayMember = "Text";
            cmb_significantValue.DataSource = comboGradosSignificanciaSource;
        }

        private void btn_generarNumeros_Click(object sender, EventArgs e)
        {
            try
            {
                int sampleSize, numberOfIntervals, seed, multiplicative, aditive, modulus;

                #region Region control y asignación de variables
                this.lbl_fail.Hide();
                // Controlamos valores inválidos y asignamos el valor a las variables
                if (!Int32.TryParse(txt_sampleSize.Text, out sampleSize) && String.IsNullOrEmpty(txt_sampleSize.Text))
                    throw new ArgumentException("Ingrese un tamaño de muestra válida.");

                if(sampleSize > 1000000)
                    throw new ArgumentException("El tamaño de la muestra no puede ser mayor a 1.000.000");

                if (!Int32.TryParse(txt_seedValue.Text, out seed) && String.IsNullOrEmpty(txt_seedValue.Text))
                    throw new ArgumentException("Ingrese un valor semilla válido.");

                if (!Int32.TryParse(txt_intervals.Text, out numberOfIntervals) && String.IsNullOrEmpty(txt_intervals.Text))
                    throw new ArgumentException("Ingrese una cantidad de intervalos válida.");

                if (!Int32.TryParse(txt_multiplicative.Text, out multiplicative) && String.IsNullOrEmpty(txt_multiplicative.Text) && txt_multiplicative.Enabled)
                    throw new ArgumentException("Ingrese una constante multiplicativa válida.");

                if (!Int32.TryParse(txt_aditive.Text, out aditive) && String.IsNullOrEmpty(txt_aditive.Text) && txt_aditive.Enabled)
                    throw new ArgumentException("Ingrese una constante aditiva válida.");

                if (!Int32.TryParse(txt_modulus.Text, out modulus) && String.IsNullOrEmpty(txt_modulus.Text) && txt_modulus.Enabled)
                    throw new ArgumentException("Ingrese un módulo válido.");

                #endregion

                // Genera la muestra de números pseudo aleatorios 
                ObtainRandomValues(sampleSize, seed, multiplicative, aditive, modulus);

                // Carga la grilla de intervalo y el histograma
                LoadIntervalGrid(numberOfIntervals);
            }
            catch (ArgumentException ex)
            {
                this.lbl_fail.Text = ex.Message;
                this.lbl_fail.Show();
            }
        }

        private void ObtainRandomValues(int sampleSize, int seed, int multiplicative = 0, int aditive = 0, int modulus = 0)
        {
            // Creamos el generador según el tipo seleccionado
            IRandomGenerator generator;

            int selectedMethod = Int32.Parse(cmb_metodos.SelectedValue.ToString());
            switch (selectedMethod)
            {
                case 0:
                    generator = new LinearCongruentialGenerator(0.0000, 1.0000, sampleSize);
                    break;
                case 1:
                    generator = new MultiplicativeCongruentialGenerator(0.0000, 1.0000, sampleSize);
                    break;
                default:
                    generator = new NativeRandomGenerator(0.0000, 1.0000, sampleSize);
                    break;
            }

            //TODO: Mejorar la carga de la grilla.
            this.fullGridSample = generator.Generate(seed, multiplicative, aditive, modulus).ToList();
            this.fullUnformatedSample = generator.GenerateUnformated(seed, multiplicative, aditive, modulus).ToList();

            //Cargamos la grilla de números psuedo aleatorios
            this.FullSampleGrid.DataSource = this.fullGridSample;
        }

        private void LoadIntervalGrid(int numberOfIntervals){
            this.intervals = IntervalHandler.DefineIntervals(this.fullUnformatedSample, numberOfIntervals);
            this.accResult = 0.0;

            IntervalsGrid.Rows.Clear();
            //Cargamos la grilla de intervalos, calculando los valores para cada fila y el acumulado
            foreach (var item in this.intervals)
            {
                var expectedFrecuency = this.fullUnformatedSample.Count / numberOfIntervals;
                var observedFrecuency = item.Value.Count();

                var individualResult = (Math.Pow((expectedFrecuency - observedFrecuency), 2) / expectedFrecuency);
                accResult += individualResult;

                this.IntervalsGrid.Rows.Add(item.Key, expectedFrecuency, observedFrecuency, individualResult, accResult);
            }

            ShowHistogram();
        }

        private void ShowHistogram()
        {
            //Mostramos el histograma y todo lo relacionado
            var histogramData = IntervalHandler.FormatIntervalsForHistogram(this.intervals);

            this.histogramControl1.DataSource = histogramData;
            this.histogramControl1.CleanLabels();
            this.histogramControl1.Refresh();
            this.histogramControl1.Show();
            this.lbl_histogram.Show();
            this.btn_validate.Show();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            double significanceValue;
            int numberOfIntervals;

            this.lbl_success.Hide();
            this.lbl_fail.Hide();

            //Validamos si el resultado obtenido es menor al valor crítico de la tabla
            if (double.TryParse(cmb_significantValue.SelectedValue.ToString(), out significanceValue) && Int32.TryParse(txt_intervals.Text, out numberOfIntervals))
            {
                var criticalValue = CriticalValues.GetCriticalValue(numberOfIntervals - 1, significanceValue);
                lbl_tableValue.Text = "Valor de tabla: " + criticalValue;
                lbl_tableValue.Show();

                if (accResult <= criticalValue)
                {
                    this.lbl_success.Show();
                }
                else
                {
                    this.lbl_fail.Text = "La hipótesis no es válida";
                    this.lbl_fail.Show();
                }
            }
            else
            {
                this.lbl_fail.Text = "Ocurrió un problema al validar la hipótesis";
                this.lbl_fail.Show();
                lbl_tableValue.Hide();
            }

        }

        private void EnableParameterFields(int selectedMethod)
        {
            txt_aditive.Enabled = false;
            txt_multiplicative.Enabled = false;
            txt_modulus.Enabled = false;
            switch (selectedMethod)
            {
                case 0:
                    txt_aditive.Enabled = true;
                    txt_multiplicative.Enabled = true;
                    txt_modulus.Enabled = true;
                    break;
                case 1:
                    txt_multiplicative.Enabled = true;
                    txt_modulus.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void cmb_metodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMethod = Int32.Parse(cmb_metodos.SelectedValue.ToString());
            EnableParameterFields(selectedMethod);
        }
    }
}
