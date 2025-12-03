namespace TIENDA_DID
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label9;
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.cmbDidTypes = new System.Windows.Forms.ComboBox();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.BarrasSeleccion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchPrefijos = new System.Windows.Forms.Button();
            this.LstGroups = new System.Windows.Forms.ListBox();
            this.cmbRegions = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbQtyRamdom = new System.Windows.Forms.ComboBox();
            this.btnSearchPrefijosRamdom = new System.Windows.Forms.Button();
            this.btnBuyRamdom = new System.Windows.Forms.Button();
            this.LstGroupsRamdom = new System.Windows.Forms.ListBox();
            this.cmbRegionsRamdom = new System.Windows.Forms.ComboBox();
            this.cmbCountriesRamdom = new System.Windows.Forms.ComboBox();
            this.cmbCitiesRamdom = new System.Windows.Forms.ComboBox();
            this.cmbDidTypesRamdom = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            label9 = new System.Windows.Forms.Label();
            this.BarrasSeleccion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(420, 117);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(64, 16);
            label9.TabIndex = 21;
            label9.Text = "Cantidad:";
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(154, 23);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(135, 21);
            this.cmbCountries.TabIndex = 0;
            this.cmbCountries.SelectedIndexChanged += new System.EventHandler(this.cmbCountries_SelectedIndexChanged);
            // 
            // cmbCities
            // 
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(304, 23);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(123, 21);
            this.cmbCities.TabIndex = 1;
            this.cmbCities.SelectedIndexChanged += new System.EventHandler(this.cmbCities_SelectedIndexChanged);
            // 
            // cmbDidTypes
            // 
            this.cmbDidTypes.FormattingEnabled = true;
            this.cmbDidTypes.Location = new System.Drawing.Point(13, 23);
            this.cmbDidTypes.Name = "cmbDidTypes";
            this.cmbDidTypes.Size = new System.Drawing.Size(124, 21);
            this.cmbDidTypes.TabIndex = 2;
            this.cmbDidTypes.SelectedIndexChanged += new System.EventHandler(this.cmbDidTypes_SelectedIndexChanged);
            // 
            // lstNumbers
            // 
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 16;
            this.lstNumbers.Items.AddRange(new object[] {
            "Números disponibles"});
            this.lstNumbers.Location = new System.Drawing.Point(234, 70);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(205, 132);
            this.lstNumbers.TabIndex = 5;
            this.lstNumbers.SelectedIndexChanged += new System.EventHandler(this.lstNumbers_SelectedIndexChanged);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(183)))), ((int)(((byte)(103)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuy.Location = new System.Drawing.Point(455, 147);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(103, 28);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "COMPRAR";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // BarrasSeleccion
            // 
            this.BarrasSeleccion.Controls.Add(this.tabPage1);
            this.BarrasSeleccion.Controls.Add(this.tabPage2);
            this.BarrasSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarrasSeleccion.Location = new System.Drawing.Point(0, 30);
            this.BarrasSeleccion.Name = "BarrasSeleccion";
            this.BarrasSeleccion.SelectedIndex = 0;
            this.BarrasSeleccion.Size = new System.Drawing.Size(589, 265);
            this.BarrasSeleccion.TabIndex = 7;
            this.BarrasSeleccion.SelectedIndexChanged += new System.EventHandler(this.BarrasSeleccion_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSearchPrefijos);
            this.tabPage1.Controls.Add(this.btnBuy);
            this.tabPage1.Controls.Add(this.LstGroups);
            this.tabPage1.Controls.Add(this.cmbRegions);
            this.tabPage1.Controls.Add(this.cmbCountries);
            this.tabPage1.Controls.Add(this.cmbCities);
            this.tabPage1.Controls.Add(this.lstNumbers);
            this.tabPage1.Controls.Add(this.cmbDidTypes);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "📍 COMPRAR NUMERACIÓN ESPECÍFICA";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Región:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de línea:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ciudad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "País:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearchPrefijos
            // 
            this.btnSearchPrefijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(240)))));
            this.btnSearchPrefijos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPrefijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPrefijos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchPrefijos.Location = new System.Drawing.Point(455, 86);
            this.btnSearchPrefijos.Name = "btnSearchPrefijos";
            this.btnSearchPrefijos.Size = new System.Drawing.Size(103, 26);
            this.btnSearchPrefijos.TabIndex = 8;
            this.btnSearchPrefijos.Text = "Consultar Prefijos";
            this.btnSearchPrefijos.UseVisualStyleBackColor = false;
            this.btnSearchPrefijos.Click += new System.EventHandler(this.btnSearchPrefijos_Click);
            // 
            // LstGroups
            // 
            this.LstGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstGroups.FormattingEnabled = true;
            this.LstGroups.ItemHeight = 16;
            this.LstGroups.Items.AddRange(new object[] {
            "Prefijos disponibles"});
            this.LstGroups.Location = new System.Drawing.Point(18, 70);
            this.LstGroups.Name = "LstGroups";
            this.LstGroups.Size = new System.Drawing.Size(199, 132);
            this.LstGroups.TabIndex = 7;
            this.LstGroups.SelectedIndexChanged += new System.EventHandler(this.LstGroups_SelectedIndexChanged);
            // 
            // cmbRegions
            // 
            this.cmbRegions.FormattingEnabled = true;
            this.cmbRegions.Location = new System.Drawing.Point(445, 23);
            this.cmbRegions.Name = "cmbRegions";
            this.cmbRegions.Size = new System.Drawing.Size(123, 21);
            this.cmbRegions.TabIndex = 6;
            this.cmbRegions.SelectedIndexChanged += new System.EventHandler(this.cmbRegions_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tabPage2.Controls.Add(label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbQtyRamdom);
            this.tabPage2.Controls.Add(this.btnSearchPrefijosRamdom);
            this.tabPage2.Controls.Add(this.btnBuyRamdom);
            this.tabPage2.Controls.Add(this.LstGroupsRamdom);
            this.tabPage2.Controls.Add(this.cmbRegionsRamdom);
            this.tabPage2.Controls.Add(this.cmbCountriesRamdom);
            this.tabPage2.Controls.Add(this.cmbCitiesRamdom);
            this.tabPage2.Controls.Add(this.cmbDidTypesRamdom);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "🎲 COMPRAR NUMERACIÓN RAMDOM";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Región:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ciudad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "País:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de línea:";
            // 
            // cmbQtyRamdom
            // 
            this.cmbQtyRamdom.FormattingEnabled = true;
            this.cmbQtyRamdom.Location = new System.Drawing.Point(487, 116);
            this.cmbQtyRamdom.Name = "cmbQtyRamdom";
            this.cmbQtyRamdom.Size = new System.Drawing.Size(50, 21);
            this.cmbQtyRamdom.TabIndex = 17;
            this.cmbQtyRamdom.SelectedIndexChanged += new System.EventHandler(this.cmbQtyRamdom_SelectedIndexChanged);
            // 
            // btnSearchPrefijosRamdom
            // 
            this.btnSearchPrefijosRamdom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(240)))));
            this.btnSearchPrefijosRamdom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPrefijosRamdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPrefijosRamdom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchPrefijosRamdom.Location = new System.Drawing.Point(404, 66);
            this.btnSearchPrefijosRamdom.Name = "btnSearchPrefijosRamdom";
            this.btnSearchPrefijosRamdom.Size = new System.Drawing.Size(149, 31);
            this.btnSearchPrefijosRamdom.TabIndex = 16;
            this.btnSearchPrefijosRamdom.Text = "Consultar Prefijos";
            this.btnSearchPrefijosRamdom.UseVisualStyleBackColor = false;
            this.btnSearchPrefijosRamdom.Click += new System.EventHandler(this.btnSearchPrefijosRamdom_Click);
            // 
            // btnBuyRamdom
            // 
            this.btnBuyRamdom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(183)))), ((int)(((byte)(103)))));
            this.btnBuyRamdom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyRamdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyRamdom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuyRamdom.Location = new System.Drawing.Point(406, 176);
            this.btnBuyRamdom.Name = "btnBuyRamdom";
            this.btnBuyRamdom.Size = new System.Drawing.Size(147, 38);
            this.btnBuyRamdom.TabIndex = 13;
            this.btnBuyRamdom.Text = "COMPRAR RAMDOM";
            this.btnBuyRamdom.UseVisualStyleBackColor = false;
            this.btnBuyRamdom.Click += new System.EventHandler(this.btnBuyRamdom_Click);
            // 
            // LstGroupsRamdom
            // 
            this.LstGroupsRamdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstGroupsRamdom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LstGroupsRamdom.FormattingEnabled = true;
            this.LstGroupsRamdom.ItemHeight = 16;
            this.LstGroupsRamdom.Items.AddRange(new object[] {
            "Prefijos disponibles"});
            this.LstGroupsRamdom.Location = new System.Drawing.Point(25, 66);
            this.LstGroupsRamdom.Name = "LstGroupsRamdom";
            this.LstGroupsRamdom.Size = new System.Drawing.Size(348, 148);
            this.LstGroupsRamdom.TabIndex = 15;
            this.LstGroupsRamdom.SelectedIndexChanged += new System.EventHandler(this.LstGroupsRamdom_SelectedIndexChanged);
            // 
            // cmbRegionsRamdom
            // 
            this.cmbRegionsRamdom.FormattingEnabled = true;
            this.cmbRegionsRamdom.Location = new System.Drawing.Point(445, 23);
            this.cmbRegionsRamdom.Name = "cmbRegionsRamdom";
            this.cmbRegionsRamdom.Size = new System.Drawing.Size(123, 21);
            this.cmbRegionsRamdom.TabIndex = 14;
            this.cmbRegionsRamdom.SelectedIndexChanged += new System.EventHandler(this.cmbRegionsRamdom_SelectedIndexChanged);
            // 
            // cmbCountriesRamdom
            // 
            this.cmbCountriesRamdom.FormattingEnabled = true;
            this.cmbCountriesRamdom.Location = new System.Drawing.Point(154, 23);
            this.cmbCountriesRamdom.Name = "cmbCountriesRamdom";
            this.cmbCountriesRamdom.Size = new System.Drawing.Size(135, 21);
            this.cmbCountriesRamdom.TabIndex = 9;
            this.cmbCountriesRamdom.SelectedIndexChanged += new System.EventHandler(this.cmbCountriesRamdom_SelectedIndexChanged);
            // 
            // cmbCitiesRamdom
            // 
            this.cmbCitiesRamdom.FormattingEnabled = true;
            this.cmbCitiesRamdom.Location = new System.Drawing.Point(304, 23);
            this.cmbCitiesRamdom.Name = "cmbCitiesRamdom";
            this.cmbCitiesRamdom.Size = new System.Drawing.Size(123, 21);
            this.cmbCitiesRamdom.TabIndex = 10;
            this.cmbCitiesRamdom.SelectedIndexChanged += new System.EventHandler(this.cmbCitiesRamdom_SelectedIndexChanged);
            // 
            // cmbDidTypesRamdom
            // 
            this.cmbDidTypesRamdom.FormattingEnabled = true;
            this.cmbDidTypesRamdom.Location = new System.Drawing.Point(13, 23);
            this.cmbDidTypesRamdom.Name = "cmbDidTypesRamdom";
            this.cmbDidTypesRamdom.Size = new System.Drawing.Size(124, 21);
            this.cmbDidTypesRamdom.TabIndex = 11;
            this.cmbDidTypesRamdom.SelectedIndexChanged += new System.EventHandler(this.cmbDidTypesRamdom_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 30);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TIENDA_DID.Properties.Resources.faviconColombiared;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Image = global::TIENDA_DID.Properties.Resources.minimizar_signo;
            this.btnMin.Location = new System.Drawing.Point(538, 8);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(19, 16);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::TIENDA_DID.Properties.Resources.icons8_cerrar_ventana_50;
            this.btnClose.Location = new System.Drawing.Point(563, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(19, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(589, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarrasSeleccion);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "COMPRAMESTA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarrasSeleccion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.ComboBox cmbDidTypes;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TabControl BarrasSeleccion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbRegions;
        private System.Windows.Forms.ListBox LstGroups;
        private System.Windows.Forms.Button btnSearchPrefijos;
        private System.Windows.Forms.Button btnSearchPrefijosRamdom;
        private System.Windows.Forms.Button btnBuyRamdom;
        private System.Windows.Forms.ListBox LstGroupsRamdom;
        private System.Windows.Forms.ComboBox cmbRegionsRamdom;
        private System.Windows.Forms.ComboBox cmbCountriesRamdom;
        private System.Windows.Forms.ComboBox cmbCitiesRamdom;
        private System.Windows.Forms.ComboBox cmbDidTypesRamdom;
        private System.Windows.Forms.ComboBox cmbQtyRamdom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

