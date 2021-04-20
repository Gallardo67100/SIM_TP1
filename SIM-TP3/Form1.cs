using Randomizer.Classes;
using Randomizer.Distributions;
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

namespace SIM_TP3
{
    public partial class Form1 : Form
    {
        private List<RandomGridValue> fullGridSample { get; set; } = new List<RandomGridValue>();
        private Dictionary<string, IEnumerable<double>> intervals { get; set; } = new Dictionary<string, IEnumerable<double>>();
        private double accResult { get; set; } = 0.0;
        private double infLimit;
        private double supLimit;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargamos los posibles metodos generadores de números
            var comboDistributionSource = new List<ComboBoxItemClass>()
            {
                new ComboBoxItemClass(0, "Uniforme"),
                new ComboBoxItemClass(1, "Exponencial"),
                new ComboBoxItemClass(2, "Normal")
            };

            cmb_distribution.ValueMember = "Value";
            cmb_distribution.DisplayMember = "Text";
            cmb_distribution.DataSource = comboDistributionSource;

            var comboDistributionSource1 = new List<ComboBoxItemClass>()
            {
                new ComboBoxItemClass(0, "10"),
                new ComboBoxItemClass(1, "15"),
                new ComboBoxItemClass(2, "20")
            };

            cmb_intervals.ValueMember = "Value";
            cmb_intervals.DisplayMember = "Text";
            cmb_intervals.DataSource = comboDistributionSource1;

            //Bloqueo los campos que no apliquen
            int selectedDistribution = Int32.Parse(cmb_distribution.SelectedValue.ToString());
            EnableParameterFields(selectedDistribution);

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

        private void EnableParameterFields(int selectedDistribution)
        {
            txt_infLimit.Enabled = false;
            txt_supLimit.Enabled = false;
            txt_lambda.Enabled = false;
            txt_medium.Enabled = false;
            txt_standarDev.Enabled = false;

            txt_infLimit.Text = "";
            txt_supLimit.Text = "";
            txt_lambda.Text = "";
            txt_medium.Text = "";
            txt_standarDev.Text = "";

            switch (selectedDistribution)
            {
                case 0:
                    txt_infLimit.Enabled = true;
                    txt_supLimit.Enabled = true;
                    break;
                case 1:
                    txt_lambda.Enabled = true;
                    break;
                case 2:
                    txt_medium.Enabled = true;
                    txt_standarDev.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void cmb_distribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMethod = Int32.Parse(cmb_distribution.SelectedValue.ToString());
            EnableParameterFields(selectedMethod);
        }

        private void btn_generarNumeros_Click(object sender, EventArgs e)
        {
            try
            {
                int sampleSize, numberOfIntervals, seed; 
                double lambda, medium, standardDev;

                #region Region control y asignación de variables
                this.lbl_fail.Hide();
                // Controlamos valores inválidos y asignamos el valor a las variables
                if (!Int32.TryParse(txt_sampleSize.Text, out sampleSize) && String.IsNullOrEmpty(txt_sampleSize.Text))
                    throw new ArgumentException("Ingrese un tamaño de muestra válida.");

                if (sampleSize > 1000000)
                    throw new ArgumentException("El tamaño de la muestra no puede ser mayor a 1.000.000");

                if (!Int32.TryParse(txt_seedValue.Text, out seed) && String.IsNullOrEmpty(txt_seedValue.Text))
                    throw new ArgumentException("Ingrese un valor semilla válido.");

                if (!Int32.TryParse(cmb_intervals.Text, out numberOfIntervals) && String.IsNullOrEmpty(cmb_intervals.Text))
                    throw new ArgumentException("Ingrese una cantidad de intervalos válida.");

                if (!double.TryParse(txt_infLimit.Text, out this.infLimit) && String.IsNullOrEmpty(txt_infLimit.Text) && txt_infLimit.Enabled)
                    throw new ArgumentException("Ingrese un límite inferior válido.");

                if (!double.TryParse(txt_supLimit.Text, out this.supLimit) && String.IsNullOrEmpty(txt_supLimit.Text) && txt_supLimit.Enabled)
                    throw new ArgumentException("Ingrese un límite superior válido.");

                if (!double.TryParse(txt_lambda.Text, out lambda) && String.IsNullOrEmpty(txt_lambda.Text) && txt_lambda.Enabled)
                    throw new ArgumentException("Ingrese un lambda válido.");

                if (!double.TryParse(txt_medium.Text, out medium) && String.IsNullOrEmpty(txt_medium.Text) && txt_medium.Enabled)
                    throw new ArgumentException("Ingrese una media válida.");

                if (!double.TryParse(txt_standarDev.Text, out standardDev) && String.IsNullOrEmpty(txt_standarDev.Text) && txt_standarDev.Enabled)
                    throw new ArgumentException("Ingrese una desviación estandar válida.");

                #endregion

                // Genera la muestra de números pseudo aleatorios 
                ObtainDistribution(sampleSize, seed, this.infLimit != this.supLimit ? this.infLimit : 0.0, this.supLimit != this.infLimit ? this.supLimit : 1.0, lambda, medium, standardDev);

                // Carga la grilla de intervalo y el histograma
                LoadIntervalGrid(numberOfIntervals, this.infLimit != this.supLimit ? this.infLimit : 0.0, this.supLimit != this.infLimit ? this.supLimit : (this.fullGridSample.Max(x => x.RandomValue)));
            }
            catch (ArgumentException ex)
            {
                this.lbl_fail.Text = ex.Message;
                this.lbl_fail.Show();
            }
        }

        private void ObtainDistribution(int sampleSize, int seed, double infLimit = 0.0, double supLimit = 1.0, double lambda = 0.0, double medium = 0.0, double standardDev = 0.0)
        {
            // Creamos el generador según el tipo seleccionado
            Distribution distribution;

            int selectedDistribution = Int32.Parse(cmb_distribution.SelectedValue.ToString());
            switch (selectedDistribution)
            {
                case 0:
                    distribution = new UniformDistribution(seed, sampleSize);
                    this.fullGridSample = ((UniformDistribution)distribution).GenerateUniformAB(infLimit, supLimit).ToList();
                    break;
                case 1:
                    distribution = new ExponentialDistribution(seed, sampleSize);
                    this.fullGridSample = ((ExponentialDistribution)distribution).GenerateExponential(lambda).ToList();

                    break;
                default:
                    distribution = new NormalDistribution(seed, sampleSize);
                    this.fullGridSample = ((NormalDistribution)distribution).GenerateNormal(medium, standardDev).ToList();
                    this.infLimit = this.fullGridSample.Min(x => x.RandomValue);
                    this.supLimit = this.fullGridSample.Max(x => x.RandomValue);
                    break;
            }

            //Cargamos la grilla de números psuedo aleatorios
            this.FullSampleGrid.DataSource = this.fullGridSample;
        }

        private void LoadIntervalGrid(int numberOfIntervals, double infLimit = 0.0, double supLimit = 1.0)
        {
            this.intervals = IntervalHandler.DefineIntervals(this.fullGridSample, numberOfIntervals, infLimit, supLimit);
            this.accResult = 0.0;
            var previousIntervalKey = "";

            IntervalsGrid.Rows.Clear();
            //Cargamos la grilla de intervalos, calculando los valores para cada fila y el acumulado
            foreach (var item in this.intervals)
            {
                var expectedFrecuency = this.GetExpectedFrecuency(item.Key);
                var observedFrecuency = item.Value.Count();

                var individualResult = (Math.Pow((expectedFrecuency - observedFrecuency), 2) / expectedFrecuency);
                accResult += individualResult;

                this.IntervalsGrid.Rows.Add(item.Key, expectedFrecuency.ToString("0.00"), observedFrecuency, individualResult, accResult);
                previousIntervalKey = item.Key;
            }

            ShowHistogram(infLimit);
        }

        private double GetExpectedFrecuency(string currentInterval)
        {
            double result = 0.0;
            int numberOfValues = fullGridSample.Count();
            int numberOfIntervals = intervals.Count();
            int selectedDistribution = Int32.Parse(cmb_distribution.SelectedValue.ToString());
            double infLimit = double.Parse(currentInterval.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries)[0]);
            double supLimit = double.Parse(currentInterval.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries)[1]);

            switch (selectedDistribution)
            {
                case 0:
                    result = (double)numberOfValues / numberOfIntervals;
                    break;
                case 1:
                    double lambda = double.Parse(txt_lambda.Text);
                    double prevAccum = 1.0 - (Math.Exp(-1 * lambda * infLimit));
                    double currAccum = 1.0 - (Math.Exp(-1 * lambda * supLimit));

                    result = (currAccum - prevAccum) * numberOfValues;
                    break;
                default:
                    double standardDeviation = double.Parse(txt_standarDev.Text);
                    double medium = double.Parse(txt_medium.Text);
                    double mediumValue = (supLimit + infLimit) / 2;

                    var probability = (1 / standardDeviation * Math.Sqrt(2 * Math.PI)) * Math.Exp(-0.5 * Math.Pow((mediumValue - medium) / standardDeviation, 2));
                    result = probability * numberOfValues;
                    break;
            }

            return result;
        }

        private void ShowHistogram(double infLimit)
        {
            //Mostramos el histograma y todo lo relacionado
            var histogramData = IntervalHandler.FormatIntervalsForHistogram(this.intervals);

            this.histogramControl1.DataSource = histogramData;
            this.histogramControl1.CleanLabels();
            this.histogramControl1.Refresh();
            this.histogramControl1.minX = infLimit;
            this.histogramControl1.Show();
            this.lbl_histogram.Show();
            //this.btn_validate.Show();
        }
    }
}
