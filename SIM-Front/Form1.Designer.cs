namespace SIM_Front
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement3 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.GradientEffect gradientEffect3 = new Infragistics.UltraChart.Resources.Appearance.GradientEffect();
            Infragistics.UltraChart.Resources.Appearance.HistogramChartAppearance histogramChartAppearance3 = new Infragistics.UltraChart.Resources.Appearance.HistogramChartAppearance();
            this.btn_generarNumeros = new System.Windows.Forms.Button();
            this.grp_parametros = new System.Windows.Forms.GroupBox();
            this.cmb_significantValue = new System.Windows.Forms.ComboBox();
            this.lbl_significantValue = new System.Windows.Forms.Label();
            this.txt_modulus = new System.Windows.Forms.TextBox();
            this.txt_aditive = new System.Windows.Forms.TextBox();
            this.txt_multiplicative = new System.Windows.Forms.TextBox();
            this.txt_intervals = new System.Windows.Forms.TextBox();
            this.txt_sampleSize = new System.Windows.Forms.TextBox();
            this.txt_seedValue = new System.Windows.Forms.TextBox();
            this.lbl_modulus = new System.Windows.Forms.Label();
            this.lbl_aditive = new System.Windows.Forms.Label();
            this.lbl_multiplicative = new System.Windows.Forms.Label();
            this.lbl_intervals = new System.Windows.Forms.Label();
            this.lbl_sampleSize = new System.Windows.Forms.Label();
            this.lbl_seedValue = new System.Windows.Forms.Label();
            this.cmb_metodos = new System.Windows.Forms.ComboBox();
            this.lbl_method = new System.Windows.Forms.Label();
            this.lbl_sample = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IntervalsGrid = new System.Windows.Forms.DataGridView();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedFrecuency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservedFrecuency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccumResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullSampleGrid = new System.Windows.Forms.DataGridView();
            this.ultraChart1 = new Infragistics.Win.UltraWinChart.UltraChart();
            this.lbl_histogram = new System.Windows.Forms.Label();
            this.btn_validate = new System.Windows.Forms.Button();
            this.lbl_success = new System.Windows.Forms.Label();
            this.lbl_fail = new System.Windows.Forms.Label();
            this.grp_data = new System.Windows.Forms.GroupBox();
            this.grp_parametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullSampleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraChart1)).BeginInit();
            this.grp_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generarNumeros
            // 
            this.btn_generarNumeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_generarNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarNumeros.Location = new System.Drawing.Point(1118, 133);
            this.btn_generarNumeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_generarNumeros.Name = "btn_generarNumeros";
            this.btn_generarNumeros.Size = new System.Drawing.Size(164, 41);
            this.btn_generarNumeros.TabIndex = 1;
            this.btn_generarNumeros.Text = "Generar números";
            this.btn_generarNumeros.UseVisualStyleBackColor = true;
            this.btn_generarNumeros.Click += new System.EventHandler(this.btn_generarNumeros_Click);
            // 
            // grp_parametros
            // 
            this.grp_parametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_parametros.Controls.Add(this.cmb_significantValue);
            this.grp_parametros.Controls.Add(this.lbl_significantValue);
            this.grp_parametros.Controls.Add(this.txt_modulus);
            this.grp_parametros.Controls.Add(this.txt_aditive);
            this.grp_parametros.Controls.Add(this.txt_multiplicative);
            this.grp_parametros.Controls.Add(this.txt_intervals);
            this.grp_parametros.Controls.Add(this.txt_sampleSize);
            this.grp_parametros.Controls.Add(this.txt_seedValue);
            this.grp_parametros.Controls.Add(this.lbl_modulus);
            this.grp_parametros.Controls.Add(this.lbl_aditive);
            this.grp_parametros.Controls.Add(this.lbl_multiplicative);
            this.grp_parametros.Controls.Add(this.lbl_intervals);
            this.grp_parametros.Controls.Add(this.lbl_sampleSize);
            this.grp_parametros.Controls.Add(this.lbl_seedValue);
            this.grp_parametros.Controls.Add(this.cmb_metodos);
            this.grp_parametros.Controls.Add(this.btn_generarNumeros);
            this.grp_parametros.Controls.Add(this.lbl_method);
            this.grp_parametros.Location = new System.Drawing.Point(23, 19);
            this.grp_parametros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_parametros.Name = "grp_parametros";
            this.grp_parametros.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_parametros.Size = new System.Drawing.Size(1289, 193);
            this.grp_parametros.TabIndex = 2;
            this.grp_parametros.TabStop = false;
            this.grp_parametros.Text = "Parámetros";
            // 
            // cmb_significantValue
            // 
            this.cmb_significantValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_significantValue.FormattingEnabled = true;
            this.cmb_significantValue.Location = new System.Drawing.Point(219, 83);
            this.cmb_significantValue.Name = "cmb_significantValue";
            this.cmb_significantValue.Size = new System.Drawing.Size(165, 28);
            this.cmb_significantValue.TabIndex = 15;
            // 
            // lbl_significantValue
            // 
            this.lbl_significantValue.AutoSize = true;
            this.lbl_significantValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_significantValue.Location = new System.Drawing.Point(20, 86);
            this.lbl_significantValue.Name = "lbl_significantValue";
            this.lbl_significantValue.Size = new System.Drawing.Size(171, 20);
            this.lbl_significantValue.TabIndex = 14;
            this.lbl_significantValue.Text = "Valor de Significancia";
            // 
            // txt_modulus
            // 
            this.txt_modulus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_modulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modulus.Location = new System.Drawing.Point(982, 140);
            this.txt_modulus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_modulus.Name = "txt_modulus";
            this.txt_modulus.Size = new System.Drawing.Size(92, 26);
            this.txt_modulus.TabIndex = 13;
            // 
            // txt_aditive
            // 
            this.txt_aditive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_aditive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_aditive.Location = new System.Drawing.Point(982, 83);
            this.txt_aditive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_aditive.Name = "txt_aditive";
            this.txt_aditive.Size = new System.Drawing.Size(92, 26);
            this.txt_aditive.TabIndex = 12;
            // 
            // txt_multiplicative
            // 
            this.txt_multiplicative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_multiplicative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_multiplicative.Location = new System.Drawing.Point(982, 31);
            this.txt_multiplicative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_multiplicative.Name = "txt_multiplicative";
            this.txt_multiplicative.Size = new System.Drawing.Size(92, 26);
            this.txt_multiplicative.TabIndex = 11;
            // 
            // txt_intervals
            // 
            this.txt_intervals.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_intervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_intervals.Location = new System.Drawing.Point(608, 140);
            this.txt_intervals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_intervals.Name = "txt_intervals";
            this.txt_intervals.Size = new System.Drawing.Size(90, 26);
            this.txt_intervals.TabIndex = 10;
            // 
            // txt_sampleSize
            // 
            this.txt_sampleSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_sampleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sampleSize.Location = new System.Drawing.Point(607, 83);
            this.txt_sampleSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sampleSize.Name = "txt_sampleSize";
            this.txt_sampleSize.Size = new System.Drawing.Size(91, 26);
            this.txt_sampleSize.TabIndex = 9;
            // 
            // txt_seedValue
            // 
            this.txt_seedValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_seedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seedValue.Location = new System.Drawing.Point(606, 31);
            this.txt_seedValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_seedValue.Name = "txt_seedValue";
            this.txt_seedValue.Size = new System.Drawing.Size(92, 26);
            this.txt_seedValue.TabIndex = 8;
            // 
            // lbl_modulus
            // 
            this.lbl_modulus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_modulus.AutoSize = true;
            this.lbl_modulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modulus.Location = new System.Drawing.Point(884, 143);
            this.lbl_modulus.Name = "lbl_modulus";
            this.lbl_modulus.Size = new System.Drawing.Size(63, 20);
            this.lbl_modulus.TabIndex = 7;
            this.lbl_modulus.Text = "Modulo";
            // 
            // lbl_aditive
            // 
            this.lbl_aditive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_aditive.AutoSize = true;
            this.lbl_aditive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aditive.Location = new System.Drawing.Point(809, 86);
            this.lbl_aditive.Name = "lbl_aditive";
            this.lbl_aditive.Size = new System.Drawing.Size(138, 20);
            this.lbl_aditive.TabIndex = 6;
            this.lbl_aditive.Text = "Constante aditiva";
            // 
            // lbl_multiplicative
            // 
            this.lbl_multiplicative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_multiplicative.AutoSize = true;
            this.lbl_multiplicative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_multiplicative.Location = new System.Drawing.Point(760, 34);
            this.lbl_multiplicative.Name = "lbl_multiplicative";
            this.lbl_multiplicative.Size = new System.Drawing.Size(187, 20);
            this.lbl_multiplicative.TabIndex = 5;
            this.lbl_multiplicative.Text = "Constante Multiplicativa";
            // 
            // lbl_intervals
            // 
            this.lbl_intervals.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_intervals.AutoSize = true;
            this.lbl_intervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervals.Location = new System.Drawing.Point(398, 143);
            this.lbl_intervals.Name = "lbl_intervals";
            this.lbl_intervals.Size = new System.Drawing.Size(175, 20);
            this.lbl_intervals.TabIndex = 4;
            this.lbl_intervals.Text = "Cantidad de intervalos";
            // 
            // lbl_sampleSize
            // 
            this.lbl_sampleSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sampleSize.AutoSize = true;
            this.lbl_sampleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sampleSize.Location = new System.Drawing.Point(438, 86);
            this.lbl_sampleSize.Name = "lbl_sampleSize";
            this.lbl_sampleSize.Size = new System.Drawing.Size(135, 20);
            this.lbl_sampleSize.TabIndex = 3;
            this.lbl_sampleSize.Text = "Tamaño Muestra";
            // 
            // lbl_seedValue
            // 
            this.lbl_seedValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_seedValue.AutoSize = true;
            this.lbl_seedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seedValue.Location = new System.Drawing.Point(465, 34);
            this.lbl_seedValue.Name = "lbl_seedValue";
            this.lbl_seedValue.Size = new System.Drawing.Size(108, 20);
            this.lbl_seedValue.TabIndex = 2;
            this.lbl_seedValue.Text = "Valor Semilla";
            // 
            // cmb_metodos
            // 
            this.cmb_metodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_metodos.FormattingEnabled = true;
            this.cmb_metodos.Location = new System.Drawing.Point(112, 31);
            this.cmb_metodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_metodos.Name = "cmb_metodos";
            this.cmb_metodos.Size = new System.Drawing.Size(272, 28);
            this.cmb_metodos.TabIndex = 1;
            this.cmb_metodos.SelectedIndexChanged += new System.EventHandler(this.cmb_metodos_SelectedIndexChanged);
            // 
            // lbl_method
            // 
            this.lbl_method.AutoSize = true;
            this.lbl_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_method.Location = new System.Drawing.Point(20, 34);
            this.lbl_method.Name = "lbl_method";
            this.lbl_method.Size = new System.Drawing.Size(64, 20);
            this.lbl_method.TabIndex = 0;
            this.lbl_method.Text = "Método";
            // 
            // lbl_sample
            // 
            this.lbl_sample.AutoSize = true;
            this.lbl_sample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sample.Location = new System.Drawing.Point(19, 27);
            this.lbl_sample.Name = "lbl_sample";
            this.lbl_sample.Size = new System.Drawing.Size(171, 25);
            this.lbl_sample.TabIndex = 3;
            this.lbl_sample.Text = "Muestra generada";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(313, 441);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // IntervalsGrid
            // 
            this.IntervalsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IntervalsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IntervalsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Interval,
            this.ExpectedFrecuency,
            this.ObservedFrecuency,
            this.Result,
            this.AccumResult});
            this.IntervalsGrid.Location = new System.Drawing.Point(239, 61);
            this.IntervalsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IntervalsGrid.Name = "IntervalsGrid";
            this.IntervalsGrid.RowHeadersWidth = 51;
            this.IntervalsGrid.Size = new System.Drawing.Size(512, 354);
            this.IntervalsGrid.TabIndex = 4;
            this.IntervalsGrid.Text = "dataGridView1";
            // 
            // Interval
            // 
            this.Interval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Interval.HeaderText = "Intervalo";
            this.Interval.MinimumWidth = 6;
            this.Interval.Name = "Interval";
            this.Interval.ReadOnly = true;
            this.Interval.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ExpectedFrecuency
            // 
            this.ExpectedFrecuency.HeaderText = "fe";
            this.ExpectedFrecuency.MinimumWidth = 25;
            this.ExpectedFrecuency.Name = "ExpectedFrecuency";
            this.ExpectedFrecuency.ReadOnly = true;
            this.ExpectedFrecuency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpectedFrecuency.Width = 40;
            // 
            // ObservedFrecuency
            // 
            this.ObservedFrecuency.HeaderText = "fo";
            this.ObservedFrecuency.MinimumWidth = 25;
            this.ObservedFrecuency.Name = "ObservedFrecuency";
            this.ObservedFrecuency.ReadOnly = true;
            this.ObservedFrecuency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ObservedFrecuency.Width = 40;
            // 
            // Result
            // 
            this.Result.HeaderText = "C";
            this.Result.MinimumWidth = 50;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Result.Width = 75;
            // 
            // AccumResult
            // 
            this.AccumResult.HeaderText = "C(AC)";
            this.AccumResult.MinimumWidth = 50;
            this.AccumResult.Name = "AccumResult";
            this.AccumResult.ReadOnly = true;
            this.AccumResult.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccumResult.Width = 75;
            // 
            // FullSampleGrid
            // 
            this.FullSampleGrid.AllowUserToAddRows = false;
            this.FullSampleGrid.AllowUserToDeleteRows = false;
            this.FullSampleGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FullSampleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FullSampleGrid.Location = new System.Drawing.Point(6, 61);
            this.FullSampleGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullSampleGrid.Name = "FullSampleGrid";
            this.FullSampleGrid.ReadOnly = true;
            this.FullSampleGrid.RowHeadersWidth = 51;
            this.FullSampleGrid.Size = new System.Drawing.Size(227, 354);
            this.FullSampleGrid.TabIndex = 0;
            this.FullSampleGrid.Text = "dataGridView1";
            // 
//			'UltraChart' properties's serialization: Since 'ChartType' changes the way axes look,
//			'ChartType' must be persisted ahead of any Axes change made in design time.
//		
            this.ultraChart1.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.HistogramChart;
            // 
            // ultraChart1
            // 
            this.ultraChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraChart1.Axis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            paintElement3.ElementType = Infragistics.UltraChart.Shared.Styles.PaintElementType.None;
            paintElement3.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.ultraChart1.Axis.PE = paintElement3;
            this.ultraChart1.Axis.X.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.X.Labels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.X.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            this.ultraChart1.Axis.X.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.X.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.X.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.FormatString = "";
            this.ultraChart1.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.Visible = true;
            this.ultraChart1.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X.Labels.Visible = true;
            this.ultraChart1.Axis.X.LineThickness = 1;
            this.ultraChart1.Axis.X.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.X.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.X.RangeMax = 1D;
            this.ultraChart1.Axis.X.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.DataInterval;
            this.ultraChart1.Axis.X.Visible = true;
            this.ultraChart1.Axis.X2.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.X2.Labels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.X2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            this.ultraChart1.Axis.X2.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.X2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.FormatString = "";
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.Visible = true;
            this.ultraChart1.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X2.Labels.Visible = false;
            this.ultraChart1.Axis.X2.LineThickness = 1;
            this.ultraChart1.Axis.X2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X2.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.X2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X2.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.X2.TickmarkInterval = 1D;
            this.ultraChart1.Axis.X2.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.X2.Visible = false;
            this.ultraChart1.Axis.Y.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Y.Labels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            this.ultraChart1.Axis.Y.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Y.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.FormatString = "";
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.Visible = true;
            this.ultraChart1.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y.Labels.Visible = true;
            this.ultraChart1.Axis.Y.LineThickness = 1;
            this.ultraChart1.Axis.Y.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Y.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Y.TickmarkInterval = 0.5D;
            this.ultraChart1.Axis.Y.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.Y.Visible = true;
            this.ultraChart1.Axis.Y2.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Y2.Labels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            this.ultraChart1.Axis.Y2.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.FormatString = "";
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Visible = true;
            this.ultraChart1.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y2.Labels.Visible = true;
            this.ultraChart1.Axis.Y2.LineThickness = 1;
            this.ultraChart1.Axis.Y2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y2.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Y2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y2.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Y2.TickmarkInterval = 0.02D;
            this.ultraChart1.Axis.Y2.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.Y2.Visible = true;
            this.ultraChart1.Axis.Z.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Z.Labels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.Z.Labels.ItemFormatString = "";
            this.ultraChart1.Axis.Z.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Z.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.Visible = true;
            this.ultraChart1.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z.Labels.Visible = true;
            this.ultraChart1.Axis.Z.LineThickness = 1;
            this.ultraChart1.Axis.Z.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Z.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Z.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.Z.Visible = false;
            this.ultraChart1.Axis.Z2.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Z2.Labels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Z2.Labels.ItemFormatString = "";
            this.ultraChart1.Axis.Z2.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Visible = true;
            this.ultraChart1.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z2.Labels.Visible = false;
            this.ultraChart1.Axis.Z2.LineThickness = 1;
            this.ultraChart1.Axis.Z2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z2.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Z2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z2.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Z2.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.Z2.Visible = false;
            this.ultraChart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ultraChart1.ColorModel.AlphaLevel = ((byte)(150));
            this.ultraChart1.ColorModel.ColorBegin = System.Drawing.Color.Pink;
            this.ultraChart1.ColorModel.ColorEnd = System.Drawing.Color.DarkRed;
            this.ultraChart1.ColorModel.ModelStyle = Infragistics.UltraChart.Shared.Styles.ColorModels.CustomLinear;
            this.ultraChart1.Data.MaxValue = 1D;
            this.ultraChart1.Data.MinValue = 0D;
            this.ultraChart1.Data.RowLabelsColumn = 0;
            this.ultraChart1.Effects.Effects.Add(gradientEffect3);
            histogramChartAppearance3.ColumnAppearance.ColumnSpacing = 0D;
            histogramChartAppearance3.ColumnAppearance.StringAxis = false;
            histogramChartAppearance3.LineAppearance.PE.Fill = System.Drawing.Color.Red;
            histogramChartAppearance3.LineAppearance.Visible = false;
            this.ultraChart1.HistogramChart = histogramChartAppearance3;
            this.ultraChart1.Location = new System.Drawing.Point(757, 61);
            this.ultraChart1.Name = "ultraChart1";
            this.ultraChart1.Size = new System.Drawing.Size(526, 354);
            this.ultraChart1.TabIndex = 5;
            this.ultraChart1.Tooltips.HighlightFillColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Tooltips.HighlightOutlineColor = System.Drawing.Color.DarkGray;
            this.ultraChart1.Visible = false;
            // 
            // lbl_histogram
            // 
            this.lbl_histogram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_histogram.AutoSize = true;
            this.lbl_histogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_histogram.Location = new System.Drawing.Point(977, 27);
            this.lbl_histogram.Name = "lbl_histogram";
            this.lbl_histogram.Size = new System.Drawing.Size(111, 25);
            this.lbl_histogram.TabIndex = 6;
            this.lbl_histogram.Text = "Histograma";
            this.lbl_histogram.Visible = false;
            // 
            // btn_validate
            // 
            this.btn_validate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validate.Location = new System.Drawing.Point(1094, 676);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(218, 52);
            this.btn_validate.TabIndex = 7;
            this.btn_validate.Text = "Validar Hipotesis";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Visible = false;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // lbl_success
            // 
            this.lbl_success.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_success.AutoSize = true;
            this.lbl_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_success.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_success.Location = new System.Drawing.Point(18, 684);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(182, 29);
            this.lbl_success.TabIndex = 8;
            this.lbl_success.Text = "Mensaje exito";
            this.lbl_success.Visible = false;
            // 
            // lbl_fail
            // 
            this.lbl_fail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_fail.AutoSize = true;
            this.lbl_fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fail.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_fail.Location = new System.Drawing.Point(18, 684);
            this.lbl_fail.Name = "lbl_fail";
            this.lbl_fail.Size = new System.Drawing.Size(176, 29);
            this.lbl_fail.TabIndex = 9;
            this.lbl_fail.Text = "Mensaje fallo";
            this.lbl_fail.Visible = false;
            // 
            // grp_data
            // 
            this.grp_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_data.Controls.Add(this.lbl_sample);
            this.grp_data.Controls.Add(this.lbl_histogram);
            this.grp_data.Controls.Add(this.FullSampleGrid);
            this.grp_data.Controls.Add(this.ultraChart1);
            this.grp_data.Controls.Add(this.IntervalsGrid);
            this.grp_data.Location = new System.Drawing.Point(23, 222);
            this.grp_data.Name = "grp_data";
            this.grp_data.Size = new System.Drawing.Size(1289, 448);
            this.grp_data.TabIndex = 10;
            this.grp_data.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 751);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.grp_parametros);
            this.Controls.Add(this.grp_data);
            this.Controls.Add(this.lbl_fail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Muestra generada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_parametros.ResumeLayout(false);
            this.grp_parametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullSampleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraChart1)).EndInit();
            this.grp_data.ResumeLayout(false);
            this.grp_data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView FullSampleGrid;
        private System.Windows.Forms.Button btn_generarNumeros;
        private System.Windows.Forms.GroupBox grp_parametros;
        private System.Windows.Forms.Label lbl_method;
        private System.Windows.Forms.ComboBox cmb_metodos;
        private System.Windows.Forms.Label lbl_sample;
        private System.Windows.Forms.TextBox txt_modulus;
        private System.Windows.Forms.TextBox txt_aditive;
        private System.Windows.Forms.TextBox txt_multiplicative;
        private System.Windows.Forms.TextBox txt_intervals;
        private System.Windows.Forms.TextBox txt_sampleSize;
        private System.Windows.Forms.TextBox txt_seedValue;
        private System.Windows.Forms.Label lbl_modulus;
        private System.Windows.Forms.Label lbl_aditive;
        private System.Windows.Forms.Label lbl_multiplicative;
        private System.Windows.Forms.Label lbl_intervals;
        private System.Windows.Forms.Label lbl_sampleSize;
        private System.Windows.Forms.Label lbl_seedValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView IntervalsGrid;
        private Infragistics.Win.UltraWinChart.UltraChart ultraChart1;
        private System.Windows.Forms.Label lbl_histogram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedFrecuency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservedFrecuency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccumResult;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.ComboBox cmb_significantValue;
        private System.Windows.Forms.Label lbl_significantValue;
        private System.Windows.Forms.Label lbl_success;
        private System.Windows.Forms.Label lbl_fail;
        private System.Windows.Forms.GroupBox grp_data;
    }
}

