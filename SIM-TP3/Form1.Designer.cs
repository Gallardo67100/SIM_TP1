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
            this.histogramControl1 = new HistogramControl.HistogramControl();
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
            this.cmb_intervals = new System.Windows.Forms.ComboBox();
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
            this.lbl_tableValue.Location = new System.Drawing.Point(424, 544);
            this.lbl_tableValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tableValue.Name = "lbl_tableValue";
            this.lbl_tableValue.Size = new System.Drawing.Size(159, 25);
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
            this.lbl_success.Location = new System.Drawing.Point(6, 544);
            this.lbl_success.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(367, 25);
            this.lbl_success.TabIndex = 14;
            this.lbl_success.Text = "No se rechaza la hipótesis planteada";
            this.lbl_success.Visible = false;
            // 
            // btn_validate
            // 
            this.btn_validate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validate.Location = new System.Drawing.Point(813, 537);
            this.btn_validate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(164, 42);
            this.btn_validate.TabIndex = 13;
            this.btn_validate.Text = "Validar Hipotesis";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Visible = false;
            // 
            // grp_parametros
            // 
            this.grp_parametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_parametros.Controls.Add(this.cmb_intervals);
            this.grp_parametros.Controls.Add(this.txt_standarDev);
            this.grp_parametros.Controls.Add(this.txt_medium);
            this.grp_parametros.Controls.Add(this.lbl_standarDev);
            this.grp_parametros.Controls.Add(this.lbl_medium);
            this.grp_parametros.Controls.Add(this.cmb_significantValue);
            this.grp_parametros.Controls.Add(this.lbl_significantValue);
            this.grp_parametros.Controls.Add(this.txt_lambda);
            this.grp_parametros.Controls.Add(this.txt_supLimit);
            this.grp_parametros.Controls.Add(this.txt_infLimit);
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
            this.grp_parametros.Location = new System.Drawing.Point(10, 3);
            this.grp_parametros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_parametros.Name = "grp_parametros";
            this.grp_parametros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_parametros.Size = new System.Drawing.Size(967, 157);
            this.grp_parametros.TabIndex = 12;
            this.grp_parametros.TabStop = false;
            this.grp_parametros.Text = "Parámetros";
            // 
            // txt_standarDev
            // 
            this.txt_standarDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_standarDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_standarDev.Location = new System.Drawing.Point(892, 67);
            this.txt_standarDev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_standarDev.Name = "txt_standarDev";
            this.txt_standarDev.Size = new System.Drawing.Size(70, 23);
            this.txt_standarDev.TabIndex = 19;
            // 
            // txt_medium
            // 
            this.txt_medium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medium.Location = new System.Drawing.Point(892, 25);
            this.txt_medium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_medium.Name = "txt_medium";
            this.txt_medium.Size = new System.Drawing.Size(70, 23);
            this.txt_medium.TabIndex = 18;
            // 
            // lbl_standarDev
            // 
            this.lbl_standarDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_standarDev.AutoSize = true;
            this.lbl_standarDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_standarDev.Location = new System.Drawing.Point(773, 70);
            this.lbl_standarDev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_standarDev.Name = "lbl_standarDev";
            this.lbl_standarDev.Size = new System.Drawing.Size(105, 17);
            this.lbl_standarDev.TabIndex = 17;
            this.lbl_standarDev.Text = "Desv. Estandar";
            // 
            // lbl_medium
            // 
            this.lbl_medium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_medium.AutoSize = true;
            this.lbl_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medium.Location = new System.Drawing.Point(826, 28);
            this.lbl_medium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_medium.Name = "lbl_medium";
            this.lbl_medium.Size = new System.Drawing.Size(46, 17);
            this.lbl_medium.TabIndex = 16;
            this.lbl_medium.Text = "Media";
            // 
            // cmb_significantValue
            // 
            this.cmb_significantValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_significantValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_significantValue.FormattingEnabled = true;
            this.cmb_significantValue.Location = new System.Drawing.Point(164, 67);
            this.cmb_significantValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_significantValue.Name = "cmb_significantValue";
            this.cmb_significantValue.Size = new System.Drawing.Size(125, 24);
            this.cmb_significantValue.TabIndex = 15;
            // 
            // lbl_significantValue
            // 
            this.lbl_significantValue.AutoSize = true;
            this.lbl_significantValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_significantValue.Location = new System.Drawing.Point(15, 70);
            this.lbl_significantValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_significantValue.Name = "lbl_significantValue";
            this.lbl_significantValue.Size = new System.Drawing.Size(144, 17);
            this.lbl_significantValue.TabIndex = 14;
            this.lbl_significantValue.Text = "Valor de Significancia";
            // 
            // txt_lambda
            // 
            this.txt_lambda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_lambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lambda.Location = new System.Drawing.Point(664, 114);
            this.txt_lambda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(70, 23);
            this.txt_lambda.TabIndex = 13;
            // 
            // txt_supLimit
            // 
            this.txt_supLimit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_supLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supLimit.Location = new System.Drawing.Point(664, 67);
            this.txt_supLimit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_supLimit.Name = "txt_supLimit";
            this.txt_supLimit.Size = new System.Drawing.Size(70, 23);
            this.txt_supLimit.TabIndex = 12;
            // 
            // txt_infLimit
            // 
            this.txt_infLimit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_infLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_infLimit.Location = new System.Drawing.Point(664, 25);
            this.txt_infLimit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_infLimit.Name = "txt_infLimit";
            this.txt_infLimit.Size = new System.Drawing.Size(70, 23);
            this.txt_infLimit.TabIndex = 11;
            // 
            // txt_sampleSize
            // 
            this.txt_sampleSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_sampleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sampleSize.Location = new System.Drawing.Point(455, 67);
            this.txt_sampleSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sampleSize.Name = "txt_sampleSize";
            this.txt_sampleSize.Size = new System.Drawing.Size(69, 23);
            this.txt_sampleSize.TabIndex = 9;
            // 
            // txt_seedValue
            // 
            this.txt_seedValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_seedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seedValue.Location = new System.Drawing.Point(454, 25);
            this.txt_seedValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_seedValue.Name = "txt_seedValue";
            this.txt_seedValue.Size = new System.Drawing.Size(70, 23);
            this.txt_seedValue.TabIndex = 8;
            // 
            // lbl_lambda
            // 
            this.lbl_lambda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_lambda.AutoSize = true;
            this.lbl_lambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lambda.Location = new System.Drawing.Point(586, 116);
            this.lbl_lambda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lambda.Name = "lbl_lambda";
            this.lbl_lambda.Size = new System.Drawing.Size(59, 17);
            this.lbl_lambda.TabIndex = 7;
            this.lbl_lambda.Text = "Lambda";
            // 
            // lbl_supLimit
            // 
            this.lbl_supLimit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_supLimit.AutoSize = true;
            this.lbl_supLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supLimit.Location = new System.Drawing.Point(547, 70);
            this.lbl_supLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_supLimit.Name = "lbl_supLimit";
            this.lbl_supLimit.Size = new System.Drawing.Size(101, 17);
            this.lbl_supLimit.TabIndex = 6;
            this.lbl_supLimit.Text = "Límite superior";
            // 
            // lbl_infLimit
            // 
            this.lbl_infLimit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_infLimit.AutoSize = true;
            this.lbl_infLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infLimit.Location = new System.Drawing.Point(554, 28);
            this.lbl_infLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_infLimit.Name = "lbl_infLimit";
            this.lbl_infLimit.Size = new System.Drawing.Size(93, 17);
            this.lbl_infLimit.TabIndex = 5;
            this.lbl_infLimit.Text = "Límite inferior";
            // 
            // lbl_intervals
            // 
            this.lbl_intervals.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_intervals.AutoSize = true;
            this.lbl_intervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervals.Location = new System.Drawing.Point(298, 116);
            this.lbl_intervals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_intervals.Name = "lbl_intervals";
            this.lbl_intervals.Size = new System.Drawing.Size(149, 17);
            this.lbl_intervals.TabIndex = 4;
            this.lbl_intervals.Text = "Cantidad de intervalos";
            // 
            // lbl_sampleSize
            // 
            this.lbl_sampleSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sampleSize.AutoSize = true;
            this.lbl_sampleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sampleSize.Location = new System.Drawing.Point(328, 70);
            this.lbl_sampleSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sampleSize.Name = "lbl_sampleSize";
            this.lbl_sampleSize.Size = new System.Drawing.Size(115, 17);
            this.lbl_sampleSize.TabIndex = 3;
            this.lbl_sampleSize.Text = "Tamaño Muestra";
            // 
            // lbl_seedValue
            // 
            this.lbl_seedValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_seedValue.AutoSize = true;
            this.lbl_seedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seedValue.Location = new System.Drawing.Point(349, 28);
            this.lbl_seedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_seedValue.Name = "lbl_seedValue";
            this.lbl_seedValue.Size = new System.Drawing.Size(90, 17);
            this.lbl_seedValue.TabIndex = 2;
            this.lbl_seedValue.Text = "Valor Semilla";
            // 
            // cmb_distribution
            // 
            this.cmb_distribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_distribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_distribution.FormattingEnabled = true;
            this.cmb_distribution.Location = new System.Drawing.Point(106, 25);
            this.cmb_distribution.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_distribution.Name = "cmb_distribution";
            this.cmb_distribution.Size = new System.Drawing.Size(183, 24);
            this.cmb_distribution.TabIndex = 1;
            this.cmb_distribution.SelectedIndexChanged += new System.EventHandler(this.cmb_distribution_SelectedIndexChanged);
            // 
            // btn_generarNumeros
            // 
            this.btn_generarNumeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_generarNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarNumeros.Location = new System.Drawing.Point(838, 108);
            this.btn_generarNumeros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_generarNumeros.Name = "btn_generarNumeros";
            this.btn_generarNumeros.Size = new System.Drawing.Size(123, 33);
            this.btn_generarNumeros.TabIndex = 1;
            this.btn_generarNumeros.Text = "Generar números";
            this.btn_generarNumeros.UseVisualStyleBackColor = true;
            this.btn_generarNumeros.Click += new System.EventHandler(this.btn_generarNumeros_Click);
            // 
            // lbl_distribution
            // 
            this.lbl_distribution.AutoSize = true;
            this.lbl_distribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_distribution.Location = new System.Drawing.Point(15, 28);
            this.lbl_distribution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_distribution.Name = "lbl_distribution";
            this.lbl_distribution.Size = new System.Drawing.Size(82, 17);
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
            this.grp_data.Location = new System.Drawing.Point(10, 168);
            this.grp_data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_data.Name = "grp_data";
            this.grp_data.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_data.Size = new System.Drawing.Size(967, 364);
            this.grp_data.TabIndex = 16;
            this.grp_data.TabStop = false;
            // 
            // histogramControl1
            // 
            this.histogramControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.histogramControl1.DataSource = null;
            this.histogramControl1.Location = new System.Drawing.Point(579, 50);
            this.histogramControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.histogramControl1.minX = 0D;
            this.histogramControl1.Name = "histogramControl1";
            this.histogramControl1.Size = new System.Drawing.Size(382, 288);
            this.histogramControl1.TabIndex = 7;
            this.histogramControl1.Visible = false;
            // 
            // lbl_sample
            // 
            this.lbl_sample.AutoSize = true;
            this.lbl_sample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sample.Location = new System.Drawing.Point(14, 22);
            this.lbl_sample.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sample.Name = "lbl_sample";
            this.lbl_sample.Size = new System.Drawing.Size(139, 20);
            this.lbl_sample.TabIndex = 3;
            this.lbl_sample.Text = "Muestra generada";
            // 
            // lbl_histogram
            // 
            this.lbl_histogram.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_histogram.AutoSize = true;
            this.lbl_histogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_histogram.Location = new System.Drawing.Point(733, 22);
            this.lbl_histogram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_histogram.Name = "lbl_histogram";
            this.lbl_histogram.Size = new System.Drawing.Size(91, 20);
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
            this.FullSampleGrid.Location = new System.Drawing.Point(4, 50);
            this.FullSampleGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FullSampleGrid.Name = "FullSampleGrid";
            this.FullSampleGrid.ReadOnly = true;
            this.FullSampleGrid.RowHeadersWidth = 51;
            this.FullSampleGrid.Size = new System.Drawing.Size(170, 288);
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
            this.IntervalsGrid.Location = new System.Drawing.Point(179, 50);
            this.IntervalsGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IntervalsGrid.Name = "IntervalsGrid";
            this.IntervalsGrid.RowHeadersWidth = 51;
            this.IntervalsGrid.Size = new System.Drawing.Size(384, 288);
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
            this.lbl_fail.Location = new System.Drawing.Point(6, 544);
            this.lbl_fail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fail.Name = "lbl_fail";
            this.lbl_fail.Size = new System.Drawing.Size(140, 25);
            this.lbl_fail.TabIndex = 15;
            this.lbl_fail.Text = "Mensaje fallo";
            this.lbl_fail.Visible = false;
            // 
            // cmb_intervals
            // 
            this.cmb_intervals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_intervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_intervals.FormattingEnabled = true;
            this.cmb_intervals.Location = new System.Drawing.Point(455, 113);
            this.cmb_intervals.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_intervals.Name = "cmb_intervals";
            this.cmb_intervals.Size = new System.Drawing.Size(69, 24);
            this.cmb_intervals.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 582);
            this.Controls.Add(this.lbl_tableValue);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.grp_parametros);
            this.Controls.Add(this.grp_data);
            this.Controls.Add(this.lbl_fail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ComboBox cmb_intervals;
    }
}

