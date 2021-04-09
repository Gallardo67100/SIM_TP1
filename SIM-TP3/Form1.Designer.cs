namespace SIM_TP3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_tableValue = new System.Windows.Forms.Label();
            this.lbl_success = new System.Windows.Forms.Label();
            this.btn_validate = new System.Windows.Forms.Button();
            this.grp_parametros = new System.Windows.Forms.GroupBox();
            this.txt_standarDev = new System.Windows.Forms.TextBox();
            this.txt_medium = new System.Windows.Forms.TextBox();
            this.lbl_standarDev = new System.Windows.Forms.Label();
            this.lbl_medium = new System.Windows.Forms.Label();
            this.cmb_significantValue = new System.Windows.Forms.ComboBox();
            this.lbl_significantValue = new System.Windows.Forms.Label();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.txt_supLimit = new System.Windows.Forms.TextBox();
            this.txt_infLimit = new System.Windows.Forms.TextBox();
            this.txt_intervals = new System.Windows.Forms.TextBox();
            this.txt_sampleSize = new System.Windows.Forms.TextBox();
            this.txt_seedValue = new System.Windows.Forms.TextBox();
            this.lbl_lambda = new System.Windows.Forms.Label();
            this.lbl_supLimit = new System.Windows.Forms.Label();
            this.lbl_infLimit = new System.Windows.Forms.Label();
            this.lbl_intervals = new System.Windows.Forms.Label();
            this.lbl_sampleSize = new System.Windows.Forms.Label();
            this.lbl_seedValue = new System.Windows.Forms.Label();
            this.cmb_distribution = new System.Windows.Forms.ComboBox();
            this.btn_generarNumeros = new System.Windows.Forms.Button();
            this.lbl_distribution = new System.Windows.Forms.Label();
            this.grp_data = new System.Windows.Forms.GroupBox();
            this.lbl_sample = new System.Windows.Forms.Label();
            this.lbl_histogram = new System.Windows.Forms.Label();
            this.FullSampleGrid = new System.Windows.Forms.DataGridView();
            this.IntervalsGrid = new System.Windows.Forms.DataGridView();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedFrecuency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservedFrecuency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccumResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_fail = new System.Windows.Forms.Label();
            this.histogramControl1 = new HistogramControl.HistogramControl();
            this.grp_parametros.SuspendLayout();
            this.grp_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullSampleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tableValue
            // 
            this.lbl_tableValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_tableValue.AutoSize = true;
            this.lbl_tableValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tableValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tableValue.Location = new System.Drawing.Point(565, 669);
            this.lbl_tableValue.Name = "lbl_tableValue";
            this.lbl_tableValue.Size = new System.Drawing.Size(199, 29);
            this.lbl_tableValue.TabIndex = 17;
            this.lbl_tableValue.Text = "Valor de tabla: ";
            this.lbl_tableValue.Visible = false;
            // 
            // lbl_success
            // 
            this.lbl_success.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_success.AutoSize = true;
            this.lbl_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_success.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_success.Location = new System.Drawing.Point(8, 669);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(465, 29);
            this.lbl_success.TabIndex = 14;
            this.lbl_success.Text = "No se rechaza la hipótesis planteada";
            this.lbl_success.Visible = false;
            // 
            // btn_validate
            // 
            this.btn_validate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validate.Location = new System.Drawing.Point(1084, 661);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(218, 52);
            this.btn_validate.TabIndex = 13;
            this.btn_validate.Text = "Validar Hipotesis";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Visible = false;
            // 
            // grp_parametros
            // 
            this.grp_parametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_parametros.Controls.Add(this.txt_standarDev);
            this.grp_parametros.Controls.Add(this.txt_medium);
            this.grp_parametros.Controls.Add(this.lbl_standarDev);
            this.grp_parametros.Controls.Add(this.lbl_medium);
            this.grp_parametros.Controls.Add(this.cmb_significantValue);
            this.grp_parametros.Controls.Add(this.lbl_significantValue);
            this.grp_parametros.Controls.Add(this.txt_lambda);
            this.grp_parametros.Controls.Add(this.txt_supLimit);
            this.grp_parametros.Controls.Add(this.txt_infLimit);
            this.grp_parametros.Controls.Add(this.txt_intervals);
            this.grp_parametros.Controls.Add(this.txt_sampleSize);
            this.grp_parametros.Controls.Add(this.txt_seedValue);
            this.grp_parametros.Controls.Add(this.lbl_lambda);
            this.grp_parametros.Controls.Add(this.lbl_supLimit);
            this.grp_parametros.Controls.Add(this.lbl_infLimit);
            this.grp_parametros.Controls.Add(this.lbl_intervals);
            this.grp_parametros.Controls.Add(this.lbl_sampleSize);
            this.grp_parametros.Controls.Add(this.lbl_seedValue);
            this.grp_parametros.Controls.Add(this.cmb_distribution);
            this.grp_parametros.Controls.Add(this.btn_generarNumeros);
            this.grp_parametros.Controls.Add(this.lbl_distribution);
            this.grp_parametros.Location = new System.Drawing.Point(13, 4);
            this.grp_parametros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_parametros.Name = "grp_parametros";
            this.grp_parametros.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_parametros.Size = new System.Drawing.Size(1289, 193);
            this.grp_parametros.TabIndex = 12;
            this.grp_parametros.TabStop = false;
            this.grp_parametros.Text = "Parámetros";
            // 
            // txt_standarDev
            // 
            this.txt_standarDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_standarDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_standarDev.Location = new System.Drawing.Point(1190, 83);
            this.txt_standarDev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_standarDev.Name = "txt_standarDev";
            this.txt_standarDev.Size = new System.Drawing.Size(92, 26);
            this.txt_standarDev.TabIndex = 19;
            // 
            // txt_medium
            // 
            this.txt_medium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medium.Location = new System.Drawing.Point(1190, 31);
            this.txt_medium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_medium.Name = "txt_medium";
            this.txt_medium.Size = new System.Drawing.Size(92, 26);
            this.txt_medium.TabIndex = 18;
            // 
            // lbl_standarDev
            // 
            this.lbl_standarDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_standarDev.AutoSize = true;
            this.lbl_standarDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_standarDev.Location = new System.Drawing.Point(1031, 86);
            this.lbl_standarDev.Name = "lbl_standarDev";
            this.lbl_standarDev.Size = new System.Drawing.Size(124, 20);
            this.lbl_standarDev.TabIndex = 17;
            this.lbl_standarDev.Text = "Desv. Estandar";
            // 
            // lbl_medium
            // 
            this.lbl_medium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_medium.AutoSize = true;
            this.lbl_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medium.Location = new System.Drawing.Point(1101, 34);
            this.lbl_medium.Name = "lbl_medium";
            this.lbl_medium.Size = new System.Drawing.Size(54, 20);
            this.lbl_medium.TabIndex = 16;
            this.lbl_medium.Text = "Media";
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
            // txt_lambda
            // 
            this.txt_lambda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_lambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lambda.Location = new System.Drawing.Point(885, 140);
            this.txt_lambda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(92, 26);
            this.txt_lambda.TabIndex = 13;
            // 
            // txt_supLimit
            // 
            this.txt_supLimit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_supLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supLimit.Location = new System.Drawing.Point(885, 83);
            this.txt_supLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_supLimit.Name = "txt_supLimit";
            this.txt_supLimit.Size = new System.Drawing.Size(92, 26);
            this.txt_supLimit.TabIndex = 12;
            // 
            // txt_infLimit
            // 
            this.txt_infLimit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_infLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_infLimit.Location = new System.Drawing.Point(885, 31);
            this.txt_infLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_infLimit.Name = "txt_infLimit";
            this.txt_infLimit.Size = new System.Drawing.Size(92, 26);
            this.txt_infLimit.TabIndex = 11;
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
            // lbl_lambda
            // 
            this.lbl_lambda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_lambda.AutoSize = true;
            this.lbl_lambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lambda.Location = new System.Drawing.Point(781, 143);
            this.lbl_lambda.Name = "lbl_lambda";
            this.lbl_lambda.Size = new System.Drawing.Size(69, 20);
            this.lbl_lambda.TabIndex = 7;
            this.lbl_lambda.Text = "Lambda";
            // 
            // lbl_supLimit
            // 
            this.lbl_supLimit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_supLimit.AutoSize = true;
            this.lbl_supLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supLimit.Location = new System.Drawing.Point(729, 86);
            this.lbl_supLimit.Name = "lbl_supLimit";
            this.lbl_supLimit.Size = new System.Drawing.Size(121, 20);
            this.lbl_supLimit.TabIndex = 6;
            this.lbl_supLimit.Text = "Límite superior";
            // 
            // lbl_infLimit
            // 
            this.lbl_infLimit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_infLimit.AutoSize = true;
            this.lbl_infLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infLimit.Location = new System.Drawing.Point(738, 34);
            this.lbl_infLimit.Name = "lbl_infLimit";
            this.lbl_infLimit.Size = new System.Drawing.Size(112, 20);
            this.lbl_infLimit.TabIndex = 5;
            this.lbl_infLimit.Text = "Límite inferior";
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
            // cmb_distribution
            // 
            this.cmb_distribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_distribution.FormattingEnabled = true;
            this.cmb_distribution.Location = new System.Drawing.Point(141, 31);
            this.cmb_distribution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_distribution.Name = "cmb_distribution";
            this.cmb_distribution.Size = new System.Drawing.Size(243, 28);
            this.cmb_distribution.TabIndex = 1;
            this.cmb_distribution.SelectedIndexChanged += new System.EventHandler(this.cmb_distribution_SelectedIndexChanged);
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
            // lbl_distribution
            // 
            this.lbl_distribution.AutoSize = true;
            this.lbl_distribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_distribution.Location = new System.Drawing.Point(20, 34);
            this.lbl_distribution.Name = "lbl_distribution";
            this.lbl_distribution.Size = new System.Drawing.Size(99, 20);
            this.lbl_distribution.TabIndex = 0;
            this.lbl_distribution.Text = "Distribución";
            // 
            // grp_data
            // 
            this.grp_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_data.Controls.Add(this.histogramControl1);
            this.grp_data.Controls.Add(this.lbl_sample);
            this.grp_data.Controls.Add(this.lbl_histogram);
            this.grp_data.Controls.Add(this.FullSampleGrid);
            this.grp_data.Controls.Add(this.IntervalsGrid);
            this.grp_data.Location = new System.Drawing.Point(13, 207);
            this.grp_data.Name = "grp_data";
            this.grp_data.Size = new System.Drawing.Size(1289, 448);
            this.grp_data.TabIndex = 16;
            this.grp_data.TabStop = false;
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
            // lbl_histogram
            // 
            this.lbl_histogram.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_histogram.AutoSize = true;
            this.lbl_histogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_histogram.Location = new System.Drawing.Point(977, 27);
            this.lbl_histogram.Name = "lbl_histogram";
            this.lbl_histogram.Size = new System.Drawing.Size(111, 25);
            this.lbl_histogram.TabIndex = 6;
            this.lbl_histogram.Text = "Histograma";
            this.lbl_histogram.Visible = false;
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
            // lbl_fail
            // 
            this.lbl_fail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_fail.AutoSize = true;
            this.lbl_fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fail.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_fail.Location = new System.Drawing.Point(8, 669);
            this.lbl_fail.Name = "lbl_fail";
            this.lbl_fail.Size = new System.Drawing.Size(176, 29);
            this.lbl_fail.TabIndex = 15;
            this.lbl_fail.Text = "Mensaje fallo";
            this.lbl_fail.Visible = false;
            // 
            // histogramControl1
            // 
            this.histogramControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.histogramControl1.DataSource = null;
            this.histogramControl1.Location = new System.Drawing.Point(772, 61);
            this.histogramControl1.minX = 0;
            this.histogramControl1.Name = "histogramControl1";
            this.histogramControl1.Size = new System.Drawing.Size(510, 354);
            this.histogramControl1.TabIndex = 7;
            this.histogramControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 716);
            this.Controls.Add(this.lbl_tableValue);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.grp_parametros);
            this.Controls.Add(this.grp_data);
            this.Controls.Add(this.lbl_fail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_parametros.ResumeLayout(false);
            this.grp_parametros.PerformLayout();
            this.grp_data.ResumeLayout(false);
            this.grp_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullSampleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tableValue;
        private System.Windows.Forms.Label lbl_success;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.GroupBox grp_parametros;
        private System.Windows.Forms.ComboBox cmb_significantValue;
        private System.Windows.Forms.Label lbl_significantValue;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.TextBox txt_supLimit;
        private System.Windows.Forms.TextBox txt_infLimit;
        private System.Windows.Forms.TextBox txt_intervals;
        private System.Windows.Forms.TextBox txt_sampleSize;
        private System.Windows.Forms.TextBox txt_seedValue;
        private System.Windows.Forms.Label lbl_lambda;
        private System.Windows.Forms.Label lbl_supLimit;
        private System.Windows.Forms.Label lbl_infLimit;
        private System.Windows.Forms.Label lbl_intervals;
        private System.Windows.Forms.Label lbl_sampleSize;
        private System.Windows.Forms.Label lbl_seedValue;
        private System.Windows.Forms.ComboBox cmb_distribution;
        private System.Windows.Forms.Button btn_generarNumeros;
        private System.Windows.Forms.Label lbl_distribution;
        private System.Windows.Forms.GroupBox grp_data;
        private System.Windows.Forms.Label lbl_sample;
        private System.Windows.Forms.Label lbl_histogram;
        private System.Windows.Forms.DataGridView FullSampleGrid;
        private System.Windows.Forms.DataGridView IntervalsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedFrecuency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservedFrecuency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccumResult;
        private System.Windows.Forms.Label lbl_fail;
        private System.Windows.Forms.TextBox txt_standarDev;
        private System.Windows.Forms.TextBox txt_medium;
        private System.Windows.Forms.Label lbl_standarDev;
        private System.Windows.Forms.Label lbl_medium;
        private HistogramControl.HistogramControl histogramControl1;
    }
}

