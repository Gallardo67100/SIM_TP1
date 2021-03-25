using Randomizer;
using Randomizer.Helpers;
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
        private List<double> fullSample { get; set; } = new List<double>();
        private Dictionary<string, IEnumerable<double>> intervals { get; set; } = new Dictionary<string, IEnumerable<double>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generarNumeros_Click(object sender, EventArgs e)
        {
            // Controlamos valores inválidos

            // Asignamos los valores de los campos a variables
            int sampleSize, numberOfIntervals, seed, multiplicative, aditive, modulus;

            Int32.TryParse(txt_sampleSize.Text, out sampleSize);
            Int32.TryParse(txt_intervals.Text, out numberOfIntervals);
            Int32.TryParse(txt_seedValue.Text, out seed);
            Int32.TryParse(txt_multiplicative.Text, out multiplicative);
            Int32.TryParse(txt_aditive.Text, out aditive);
            Int32.TryParse(txt_modulus.Text, out modulus);

            ObtainRandomValues(sampleSize, seed, multiplicative, aditive, modulus);

            LoadIntervalGrid(numberOfIntervals);

        }

        private void ObtainRandomValues(int sampleSize, int seed, int multiplicative = 0, int aditive = 0, int modulus = 0)
        {
            IRandomGenerator generator = new NativeRandomGenerator(0.0000, 1.0000, sampleSize);
            this.fullSample = generator.Generate(seed, multiplicative, aditive, modulus).ToList();

            ClearDGV(this.FullSampleGrid);
            foreach (var item in this.fullSample)
            {
                this.FullSampleGrid.Rows.Add(item.ToString("0.0000"));
            }
        }

        private void LoadIntervalGrid(int numberOfIntervals){
            this.intervals = IntervalHandler.DefineIntervals(this.fullSample, numberOfIntervals);
            var accResult = 0.0;

            //TODO: Arreglar el metodo que limpia grillas
            ClearDGV(this.IntervalsGrid);
            foreach (var item in this.intervals)
            {
                var expectedFrecuency = (double)this.fullSample.Count / numberOfIntervals;
                var observedFrecuency = item.Value.Count();

                var individualResult = (Math.Pow((expectedFrecuency - observedFrecuency), 2) / expectedFrecuency); ;
                accResult += individualResult;

                this.IntervalsGrid.Rows.Add(item.Key, 6, item.Value.Count(), individualResult, accResult);
            }

            ShowHistogram();
        }

        private void ShowHistogram()
        {
            this.ultraChart1.Axis.X.TickmarkInterval = 0.2;
            this.ultraChart1.Data.DataSource = this.fullSample.ToArray();
            this.ultraChart1.Data.DataBind();
            this.ultraChart1.Show();
            this.lbl_histogram.Show();
            this.btn_validate.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var comboMetodosSource = new List<ComboBoxItemClass>()
            {
                new ComboBoxItemClass(0, "Método Congruencial Lineal"),
                new ComboBoxItemClass(1, "Método Congruencial Multiplicativo"),
                new ComboBoxItemClass(2, "Método Nativo .Net")
            };

            cmb_metodos.ValueMember = "Value";
            cmb_metodos.DisplayMember = "Text";
            cmb_metodos.DataSource = comboMetodosSource;

        }

        private void ClearDGV(DataGridView grid)
        {
            if(grid.Rows.Count > 0 )
            {
                foreach(DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[0].Value != null)
                        grid.Rows.Remove(row);  
                }
            }
        }
    }
}
