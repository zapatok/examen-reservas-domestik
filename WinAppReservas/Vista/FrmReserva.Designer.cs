namespace WinAppReservas.Vista
{
    partial class FrmReserva
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codigo generado por el Disenador de Windows Forms

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtNumVlo = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblTipoPasajero = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblNumVlo = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoBus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnModFecha = new System.Windows.Forms.Button();
            this.dtpFechaMod = new System.Windows.Forms.DateTimePicker();
            this.lblHoraMod = new System.Windows.Forms.Label();
            this.lblDestinoMod = new System.Windows.Forms.Label();
            this.lblNumVloMod = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuscarMod = new System.Windows.Forms.Button();
            this.txtCodigoMod = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataReservas = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReservas)).BeginInit();
            this.SuspendLayout();
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(36, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 540);
            this.tabControl1.TabIndex = 0;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Reserva";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.txtNumVlo);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(98, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Reserva";
            //
            // btnIngresar
            //
            this.btnIngresar.Location = new System.Drawing.Point(287, 44);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(103, 23);
            this.btnIngresar.TabIndex = 10;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            //
            // txtCosto
            //
            this.txtCosto.Location = new System.Drawing.Point(125, 186);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 9;
            //
            // txtNumVlo
            //
            this.txtNumVlo.Location = new System.Drawing.Point(125, 151);
            this.txtNumVlo.Name = "txtNumVlo";
            this.txtNumVlo.Size = new System.Drawing.Size(100, 20);
            this.txtNumVlo.TabIndex = 8;
            //
            // txtRut
            //
            this.txtRut.Location = new System.Drawing.Point(125, 116);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 7;
            //
            // cboTipo
            //
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Economica",
            "Turista",
            "Ejecutivo"});
            this.cboTipo.Location = new System.Drawing.Point(125, 81);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(140, 21);
            this.cboTipo.TabIndex = 6;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            //
            // txtCodigo
            //
            this.txtCodigo.Location = new System.Drawing.Point(125, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo Pasaje:";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° Vuelo:";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUT Pasajero:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Reserva";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // groupBox3
            //
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtCodigoBus);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(98, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 80);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda por Código";
            //
            // btnBuscar
            //
            this.btnBuscar.Location = new System.Drawing.Point(287, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // txtCodigoBus
            //
            this.txtCodigoBus.Location = new System.Drawing.Point(125, 37);
            this.txtCodigoBus.Name = "txtCodigoBus";
            this.txtCodigoBus.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoBus.TabIndex = 1;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código:";
            //
            // groupBox4
            //
            this.groupBox4.Controls.Add(this.lblPuntaje);
            this.groupBox4.Controls.Add(this.lblTipoPasajero);
            this.groupBox4.Controls.Add(this.lblCosto);
            this.groupBox4.Controls.Add(this.lblCondicion);
            this.groupBox4.Controls.Add(this.lblNumVlo);
            this.groupBox4.Controls.Add(this.lblRut);
            this.groupBox4.Controls.Add(this.lblValor);
            this.groupBox4.Controls.Add(this.lblTipo);
            this.groupBox4.Controls.Add(this.lblCodigo);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(98, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 400);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información de la Reserva";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código:";
            //
            // lblCodigo
            //
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(150, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 1;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tipo Reserva:";
            //
            // lblTipo
            //
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(150, 60);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 13);
            this.lblTipo.TabIndex = 3;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Valor:";
            //
            // lblValor
            //
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(150, 85);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 13);
            this.lblValor.TabIndex = 5;
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "RUT:";
            //
            // lblRut
            //
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(150, 110);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(0, 13);
            this.lblRut.TabIndex = 7;
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "N° Vuelo:";
            //
            // lblNumVlo
            //
            this.lblNumVlo.AutoSize = true;
            this.lblNumVlo.Location = new System.Drawing.Point(150, 135);
            this.lblNumVlo.Name = "lblNumVlo";
            this.lblNumVlo.Size = new System.Drawing.Size(0, 13);
            this.lblNumVlo.TabIndex = 9;
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(39, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Condición:";
            //
            // lblCondicion
            //
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCondicion.ForeColor = System.Drawing.Color.Blue;
            this.lblCondicion.Location = new System.Drawing.Point(150, 175);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(0, 13);
            this.lblCondicion.TabIndex = 11;
            //
            // label13
            //
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Costo Pasaje:";
            //
            // lblCosto
            //
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(150, 205);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(0, 13);
            this.lblCosto.TabIndex = 13;
            //
            // label14
            //
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Tipo Pasajero:";
            //
            // lblTipoPasajero
            //
            this.lblTipoPasajero.AutoSize = true;
            this.lblTipoPasajero.Location = new System.Drawing.Point(150, 235);
            this.lblTipoPasajero.Name = "lblTipoPasajero";
            this.lblTipoPasajero.Size = new System.Drawing.Size(0, 13);
            this.lblTipoPasajero.TabIndex = 15;
            //
            // label15
            //
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Puntaje Acumulado:";
            //
            // lblPuntaje
            //
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(150, 265);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(0, 13);
            this.lblPuntaje.TabIndex = 17;
            //
            // tabPage3
            //
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(874, 514);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar Fecha";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // groupBox5
            //
            this.groupBox5.Controls.Add(this.btnBuscarMod);
            this.groupBox5.Controls.Add(this.txtCodigoMod);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(98, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(504, 80);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Búsqueda de Reserva";
            //
            // btnBuscarMod
            //
            this.btnBuscarMod.Location = new System.Drawing.Point(287, 35);
            this.btnBuscarMod.Name = "btnBuscarMod";
            this.btnBuscarMod.Size = new System.Drawing.Size(103, 23);
            this.btnBuscarMod.TabIndex = 2;
            this.btnBuscarMod.Text = "Buscar";
            this.btnBuscarMod.UseVisualStyleBackColor = true;
            this.btnBuscarMod.Click += new System.EventHandler(this.btnBuscarMod_Click);
            //
            // txtCodigoMod
            //
            this.txtCodigoMod.Location = new System.Drawing.Point(125, 37);
            this.txtCodigoMod.Name = "txtCodigoMod";
            this.txtCodigoMod.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMod.TabIndex = 1;
            //
            // label16
            //
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Código:";
            //
            // groupBox6
            //
            this.groupBox6.Controls.Add(this.btnModFecha);
            this.groupBox6.Controls.Add(this.dtpFechaMod);
            this.groupBox6.Controls.Add(this.lblHoraMod);
            this.groupBox6.Controls.Add(this.lblDestinoMod);
            this.groupBox6.Controls.Add(this.lblNumVloMod);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(98, 106);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(504, 250);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datos del Vuelo Asociado";
            //
            // label17
            //
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "N° Vuelo:";
            //
            // lblNumVloMod
            //
            this.lblNumVloMod.AutoSize = true;
            this.lblNumVloMod.Location = new System.Drawing.Point(150, 35);
            this.lblNumVloMod.Name = "lblNumVloMod";
            this.lblNumVloMod.Size = new System.Drawing.Size(0, 13);
            this.lblNumVloMod.TabIndex = 1;
            //
            // label18
            //
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Destino:";
            //
            // lblDestinoMod
            //
            this.lblDestinoMod.AutoSize = true;
            this.lblDestinoMod.Location = new System.Drawing.Point(150, 65);
            this.lblDestinoMod.Name = "lblDestinoMod";
            this.lblDestinoMod.Size = new System.Drawing.Size(0, 13);
            this.lblDestinoMod.TabIndex = 3;
            //
            // label19
            //
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(39, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Hora:";
            //
            // lblHoraMod
            //
            this.lblHoraMod.AutoSize = true;
            this.lblHoraMod.Location = new System.Drawing.Point(150, 95);
            this.lblHoraMod.Name = "lblHoraMod";
            this.lblHoraMod.Size = new System.Drawing.Size(0, 13);
            this.lblHoraMod.TabIndex = 5;
            //
            // label20
            //
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Nueva Fecha:";
            //
            // dtpFechaMod
            //
            this.dtpFechaMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMod.Location = new System.Drawing.Point(150, 132);
            this.dtpFechaMod.Name = "dtpFechaMod";
            this.dtpFechaMod.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaMod.TabIndex = 7;
            //
            // btnModFecha
            //
            this.btnModFecha.Location = new System.Drawing.Point(150, 175);
            this.btnModFecha.Name = "btnModFecha";
            this.btnModFecha.Size = new System.Drawing.Size(130, 30);
            this.btnModFecha.TabIndex = 8;
            this.btnModFecha.Text = "Modificar Fecha";
            this.btnModFecha.UseVisualStyleBackColor = true;
            this.btnModFecha.Click += new System.EventHandler(this.btnModFecha_Click);
            //
            // tabPage4
            //
            this.tabPage4.Controls.Add(this.dataReservas);
            this.tabPage4.Controls.Add(this.btnListar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(874, 514);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Listar Reservas";
            this.tabPage4.UseVisualStyleBackColor = true;
            //
            // btnListar
            //
            this.btnListar.Location = new System.Drawing.Point(308, 30);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(125, 41);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            //
            // dataReservas
            //
            this.dataReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReservas.Location = new System.Drawing.Point(113, 93);
            this.dataReservas.Name = "dataReservas";
            this.dataReservas.Size = new System.Drawing.Size(650, 280);
            this.dataReservas.TabIndex = 1;
            //
            // FrmReserva
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 620);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmReserva";
            this.Text = "Reservas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtNumVlo;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblTipoPasajero;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblNumVlo;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoBus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnModFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaMod;
        private System.Windows.Forms.Label lblHoraMod;
        private System.Windows.Forms.Label lblDestinoMod;
        private System.Windows.Forms.Label lblNumVloMod;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBuscarMod;
        private System.Windows.Forms.TextBox txtCodigoMod;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataReservas;
        private System.Windows.Forms.Button btnListar;
    }
}
