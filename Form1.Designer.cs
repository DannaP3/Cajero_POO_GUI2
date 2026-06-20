namespace BancoUTP
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSeleccionarboton = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtAñoNac = new System.Windows.Forms.TextBox();
            this.txtCrearContraseña = new System.Windows.Forms.TextBox();
            this.txtCrearUsuario = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblCrearContraseña = new System.Windows.Forms.Label();
            this.lblCrearUsuario = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnContinuar_Menu = new System.Windows.Forms.Button();
            this.btnRegresar_CrearCuenta = new System.Windows.Forms.Button();
            this.txtIngreseContraseña = new System.Windows.Forms.TextBox();
            this.txtIngreseUsuario = new System.Windows.Forms.TextBox();
            this.lblNomContraseña = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSalirInicio = new System.Windows.Forms.Button();
            this.rdbPagoUTP = new System.Windows.Forms.RadioButton();
            this.rdbRetirarSaldo = new System.Windows.Forms.RadioButton();
            this.rdbDepositoCuenta = new System.Windows.Forms.RadioButton();
            this.rdbMostrarDatos = new System.Windows.Forms.RadioButton();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.lblAccionRealizada = new System.Windows.Forms.Label();
            this.gpbMenuServicios = new System.Windows.Forms.GroupBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpcionServicio = new System.Windows.Forms.TextBox();
            this.btnConfirmarPag = new System.Windows.Forms.Button();
            this.gpbRetiro = new System.Windows.Forms.GroupBox();
            this.btnConfirmarRetiro = new System.Windows.Forms.Button();
            this.txtMontoRetiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbDeposito = new System.Windows.Forms.GroupBox();
            this.btnConfirmarDeposito = new System.Windows.Forms.Button();
            this.txtMontoDeposito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gpbMenuServicios.SuspendLayout();
            this.gpbRetiro.SuspendLayout();
            this.gpbDeposito.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(43, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 714);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSeleccionarboton);
            this.tabPage1.Controls.Add(this.btnIngresar);
            this.tabPage1.Controls.Add(this.btnCrearCuenta);
            this.tabPage1.Controls.Add(this.pbLogo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionarboton
            // 
            this.lblSeleccionarboton.AutoSize = true;
            this.lblSeleccionarboton.Location = new System.Drawing.Point(295, 71);
            this.lblSeleccionarboton.Name = "lblSeleccionarboton";
            this.lblSeleccionarboton.Size = new System.Drawing.Size(146, 20);
            this.lblSeleccionarboton.TabIndex = 11;
            this.lblSeleccionarboton.Text = "Precione un boton :";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(328, 219);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(154, 61);
            this.btnIngresar.TabIndex = 10;
            this.btnIngresar.Text = "Ingresar Cuenta";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(328, 122);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(154, 68);
            this.btnCrearCuenta.TabIndex = 9;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(27, 71);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(230, 209);
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.btnRegresar);
            this.tabPage2.Controls.Add(this.btnValidar);
            this.tabPage2.Controls.Add(this.txtAñoNac);
            this.tabPage2.Controls.Add(this.txtCrearContraseña);
            this.tabPage2.Controls.Add(this.txtCrearUsuario);
            this.tabPage2.Controls.Add(this.lblEdad);
            this.tabPage2.Controls.Add(this.lblCrearContraseña);
            this.tabPage2.Controls.Add(this.lblCrearUsuario);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 681);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(31, 271);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(224, 49);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(483, 271);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(224, 49);
            this.btnValidar.TabIndex = 15;
            this.btnValidar.Text = "Continuar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtAñoNac
            // 
            this.txtAñoNac.Location = new System.Drawing.Point(107, 217);
            this.txtAñoNac.Name = "txtAñoNac";
            this.txtAñoNac.Size = new System.Drawing.Size(238, 26);
            this.txtAñoNac.TabIndex = 14;
            // 
            // txtCrearContraseña
            // 
            this.txtCrearContraseña.Location = new System.Drawing.Point(107, 136);
            this.txtCrearContraseña.Name = "txtCrearContraseña";
            this.txtCrearContraseña.Size = new System.Drawing.Size(238, 26);
            this.txtCrearContraseña.TabIndex = 13;
            // 
            // txtCrearUsuario
            // 
            this.txtCrearUsuario.Location = new System.Drawing.Point(107, 54);
            this.txtCrearUsuario.Name = "txtCrearUsuario";
            this.txtCrearUsuario.Size = new System.Drawing.Size(238, 26);
            this.txtCrearUsuario.TabIndex = 12;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(112, 185);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(223, 20);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Ingresa tu año de nacimiento :";
            // 
            // lblCrearContraseña
            // 
            this.lblCrearContraseña.AutoSize = true;
            this.lblCrearContraseña.Location = new System.Drawing.Point(103, 113);
            this.lblCrearContraseña.Name = "lblCrearContraseña";
            this.lblCrearContraseña.Size = new System.Drawing.Size(219, 20);
            this.lblCrearContraseña.TabIndex = 10;
            this.lblCrearContraseña.Text = "Crea una contraseña segura :";
            // 
            // lblCrearUsuario
            // 
            this.lblCrearUsuario.AutoSize = true;
            this.lblCrearUsuario.Location = new System.Drawing.Point(103, 31);
            this.lblCrearUsuario.Name = "lblCrearUsuario";
            this.lblCrearUsuario.Size = new System.Drawing.Size(209, 20);
            this.lblCrearUsuario.TabIndex = 9;
            this.lblCrearUsuario.Text = "Crea un nombre de usuario :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnContinuar_Menu);
            this.tabPage3.Controls.Add(this.btnRegresar_CrearCuenta);
            this.tabPage3.Controls.Add(this.txtIngreseContraseña);
            this.tabPage3.Controls.Add(this.txtIngreseUsuario);
            this.tabPage3.Controls.Add(this.lblNomContraseña);
            this.tabPage3.Controls.Add(this.lblNomUsuario);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(816, 681);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnContinuar_Menu
            // 
            this.btnContinuar_Menu.Location = new System.Drawing.Point(502, 264);
            this.btnContinuar_Menu.Name = "btnContinuar_Menu";
            this.btnContinuar_Menu.Size = new System.Drawing.Size(224, 49);
            this.btnContinuar_Menu.TabIndex = 22;
            this.btnContinuar_Menu.Text = "Continuar";
            this.btnContinuar_Menu.UseVisualStyleBackColor = true;
            this.btnContinuar_Menu.Click += new System.EventHandler(this.btnContinuar_Menu_Click);
            // 
            // btnRegresar_CrearCuenta
            // 
            this.btnRegresar_CrearCuenta.Location = new System.Drawing.Point(41, 264);
            this.btnRegresar_CrearCuenta.Name = "btnRegresar_CrearCuenta";
            this.btnRegresar_CrearCuenta.Size = new System.Drawing.Size(224, 49);
            this.btnRegresar_CrearCuenta.TabIndex = 21;
            this.btnRegresar_CrearCuenta.Text = "Regresar";
            this.btnRegresar_CrearCuenta.UseVisualStyleBackColor = true;
            this.btnRegresar_CrearCuenta.Click += new System.EventHandler(this.btnRegresar_CrearCuenta_Click);
            // 
            // txtIngreseContraseña
            // 
            this.txtIngreseContraseña.Location = new System.Drawing.Point(162, 183);
            this.txtIngreseContraseña.Name = "txtIngreseContraseña";
            this.txtIngreseContraseña.Size = new System.Drawing.Size(238, 26);
            this.txtIngreseContraseña.TabIndex = 20;
            // 
            // txtIngreseUsuario
            // 
            this.txtIngreseUsuario.Location = new System.Drawing.Point(162, 81);
            this.txtIngreseUsuario.Name = "txtIngreseUsuario";
            this.txtIngreseUsuario.Size = new System.Drawing.Size(238, 26);
            this.txtIngreseUsuario.TabIndex = 19;
            // 
            // lblNomContraseña
            // 
            this.lblNomContraseña.AutoSize = true;
            this.lblNomContraseña.Location = new System.Drawing.Point(96, 152);
            this.lblNomContraseña.Name = "lblNomContraseña";
            this.lblNomContraseña.Size = new System.Drawing.Size(176, 20);
            this.lblNomContraseña.TabIndex = 18;
            this.lblNomContraseña.Text = "Ingrese su contraseña :";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(96, 40);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(225, 20);
            this.lblNomUsuario.TabIndex = 17;
            this.lblNomUsuario.Text = "Ingresa tu nombre de usuario :";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gpbDeposito);
            this.tabPage4.Controls.Add(this.gpbRetiro);
            this.tabPage4.Controls.Add(this.gpbMenuServicios);
            this.tabPage4.Controls.Add(this.lblAccionRealizada);
            this.tabPage4.Controls.Add(this.btnSalirInicio);
            this.tabPage4.Controls.Add(this.rdbPagoUTP);
            this.tabPage4.Controls.Add(this.rdbRetirarSaldo);
            this.tabPage4.Controls.Add(this.rdbDepositoCuenta);
            this.tabPage4.Controls.Add(this.rdbMostrarDatos);
            this.tabPage4.Controls.Add(this.lblOpciones);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(816, 681);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSalirInicio
            // 
            this.btnSalirInicio.Location = new System.Drawing.Point(477, 478);
            this.btnSalirInicio.Name = "btnSalirInicio";
            this.btnSalirInicio.Size = new System.Drawing.Size(183, 85);
            this.btnSalirInicio.TabIndex = 21;
            this.btnSalirInicio.Text = "Salir";
            this.btnSalirInicio.UseVisualStyleBackColor = true;
            this.btnSalirInicio.Click += new System.EventHandler(this.btnSalirInicio_Click);
            // 
            // rdbPagoUTP
            // 
            this.rdbPagoUTP.AutoSize = true;
            this.rdbPagoUTP.Location = new System.Drawing.Point(33, 380);
            this.rdbPagoUTP.Name = "rdbPagoUTP";
            this.rdbPagoUTP.Size = new System.Drawing.Size(192, 24);
            this.rdbPagoUTP.TabIndex = 20;
            this.rdbPagoUTP.Text = "Pago de servicios UTP";
            this.rdbPagoUTP.UseVisualStyleBackColor = true;
            this.rdbPagoUTP.CheckedChanged += new System.EventHandler(this.rdbPagoUTP_CheckedChanged);
            // 
            // rdbRetirarSaldo
            // 
            this.rdbRetirarSaldo.AutoSize = true;
            this.rdbRetirarSaldo.Location = new System.Drawing.Point(33, 197);
            this.rdbRetirarSaldo.Name = "rdbRetirarSaldo";
            this.rdbRetirarSaldo.Size = new System.Drawing.Size(124, 24);
            this.rdbRetirarSaldo.TabIndex = 19;
            this.rdbRetirarSaldo.Text = "Retirar saldo";
            this.rdbRetirarSaldo.UseVisualStyleBackColor = true;
            this.rdbRetirarSaldo.CheckedChanged += new System.EventHandler(this.rdbRetirarSaldo_CheckedChanged);
            // 
            // rdbDepositoCuenta
            // 
            this.rdbDepositoCuenta.AutoSize = true;
            this.rdbDepositoCuenta.Location = new System.Drawing.Point(33, 295);
            this.rdbDepositoCuenta.Name = "rdbDepositoCuenta";
            this.rdbDepositoCuenta.Size = new System.Drawing.Size(151, 24);
            this.rdbDepositoCuenta.TabIndex = 18;
            this.rdbDepositoCuenta.Text = "Deposito cuenta";
            this.rdbDepositoCuenta.UseVisualStyleBackColor = true;
            this.rdbDepositoCuenta.CheckedChanged += new System.EventHandler(this.rdbDepositoCuenta_CheckedChanged);
            // 
            // rdbMostrarDatos
            // 
            this.rdbMostrarDatos.AutoSize = true;
            this.rdbMostrarDatos.Checked = true;
            this.rdbMostrarDatos.Location = new System.Drawing.Point(33, 103);
            this.rdbMostrarDatos.Name = "rdbMostrarDatos";
            this.rdbMostrarDatos.Size = new System.Drawing.Size(229, 24);
            this.rdbMostrarDatos.TabIndex = 17;
            this.rdbMostrarDatos.TabStop = true;
            this.rdbMostrarDatos.Text = "Mostrar Datos de la Cuenta";
            this.rdbMostrarDatos.UseVisualStyleBackColor = true;
            this.rdbMostrarDatos.CheckedChanged += new System.EventHandler(this.rdbMostrarDatos_CheckedChanged);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(79, 51);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(160, 20);
            this.lblOpciones.TabIndex = 16;
            this.lblOpciones.Text = "¿Qué desea realizar?";
            // 
            // lblAccionRealizada
            // 
            this.lblAccionRealizada.AutoSize = true;
            this.lblAccionRealizada.Location = new System.Drawing.Point(352, 105);
            this.lblAccionRealizada.Name = "lblAccionRealizada";
            this.lblAccionRealizada.Size = new System.Drawing.Size(0, 20);
            this.lblAccionRealizada.TabIndex = 22;
            // 
            // gpbMenuServicios
            // 
            this.gpbMenuServicios.Controls.Add(this.btnConfirmarPag);
            this.gpbMenuServicios.Controls.Add(this.txtOpcionServicio);
            this.gpbMenuServicios.Controls.Add(this.label1);
            this.gpbMenuServicios.Controls.Add(this.lblMenu);
            this.gpbMenuServicios.Location = new System.Drawing.Point(23, 428);
            this.gpbMenuServicios.Name = "gpbMenuServicios";
            this.gpbMenuServicios.Size = new System.Drawing.Size(425, 188);
            this.gpbMenuServicios.TabIndex = 23;
            this.gpbMenuServicios.TabStop = false;
            this.gpbMenuServicios.Text = "Menu Servicios UTP";
            this.gpbMenuServicios.Visible = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(15, 32);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(261, 60);
            this.lblMenu.TabIndex = 24;
            this.lblMenu.Text = "1) Constancia de Estudios: $100.00\n2) Reposición de credencial: $50.00\n3) Pago de" +
    " cuatrimestre: $2600.00";
            this.lblMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Escribe el número de opción (1, 2 o 3):";
            // 
            // txtOpcionServicio
            // 
            this.txtOpcionServicio.Location = new System.Drawing.Point(291, 95);
            this.txtOpcionServicio.Name = "txtOpcionServicio";
            this.txtOpcionServicio.Size = new System.Drawing.Size(100, 26);
            this.txtOpcionServicio.TabIndex = 26;
            // 
            // btnConfirmarPag
            // 
            this.btnConfirmarPag.Location = new System.Drawing.Point(71, 138);
            this.btnConfirmarPag.Name = "btnConfirmarPag";
            this.btnConfirmarPag.Size = new System.Drawing.Size(274, 44);
            this.btnConfirmarPag.TabIndex = 27;
            this.btnConfirmarPag.Text = "Confirmar Pago";
            this.btnConfirmarPag.UseVisualStyleBackColor = true;
            this.btnConfirmarPag.Click += new System.EventHandler(this.btnConfirmarPag_Click);
            // 
            // gpbRetiro
            // 
            this.gpbRetiro.Controls.Add(this.btnConfirmarRetiro);
            this.gpbRetiro.Controls.Add(this.txtMontoRetiro);
            this.gpbRetiro.Controls.Add(this.label3);
            this.gpbRetiro.Location = new System.Drawing.Point(314, 144);
            this.gpbRetiro.Name = "gpbRetiro";
            this.gpbRetiro.Size = new System.Drawing.Size(337, 127);
            this.gpbRetiro.TabIndex = 24;
            this.gpbRetiro.TabStop = false;
            this.gpbRetiro.Text = "Retirar Saldo de la Cuenta";
            this.gpbRetiro.Visible = false;
            // 
            // btnConfirmarRetiro
            // 
            this.btnConfirmarRetiro.Location = new System.Drawing.Point(38, 69);
            this.btnConfirmarRetiro.Name = "btnConfirmarRetiro";
            this.btnConfirmarRetiro.Size = new System.Drawing.Size(274, 44);
            this.btnConfirmarRetiro.TabIndex = 27;
            this.btnConfirmarRetiro.Text = "Confirmar Retiro";
            this.btnConfirmarRetiro.UseVisualStyleBackColor = true;
            this.btnConfirmarRetiro.Click += new System.EventHandler(this.btnConfirmarRetiro_Click);
            // 
            // txtMontoRetiro
            // 
            this.txtMontoRetiro.Location = new System.Drawing.Point(185, 37);
            this.txtMontoRetiro.Name = "txtMontoRetiro";
            this.txtMontoRetiro.Size = new System.Drawing.Size(100, 26);
            this.txtMontoRetiro.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Monto a retirar: $";
            // 
            // gpbDeposito
            // 
            this.gpbDeposito.Controls.Add(this.btnConfirmarDeposito);
            this.gpbDeposito.Controls.Add(this.txtMontoDeposito);
            this.gpbDeposito.Controls.Add(this.label2);
            this.gpbDeposito.Location = new System.Drawing.Point(314, 277);
            this.gpbDeposito.Name = "gpbDeposito";
            this.gpbDeposito.Size = new System.Drawing.Size(337, 127);
            this.gpbDeposito.TabIndex = 25;
            this.gpbDeposito.TabStop = false;
            this.gpbDeposito.Text = "Depositar Saldo a la Cuenta";
            this.gpbDeposito.Visible = false;
            // 
            // btnConfirmarDeposito
            // 
            this.btnConfirmarDeposito.Location = new System.Drawing.Point(38, 69);
            this.btnConfirmarDeposito.Name = "btnConfirmarDeposito";
            this.btnConfirmarDeposito.Size = new System.Drawing.Size(274, 44);
            this.btnConfirmarDeposito.TabIndex = 27;
            this.btnConfirmarDeposito.Text = "Confirmar Depósito";
            this.btnConfirmarDeposito.UseVisualStyleBackColor = true;
            this.btnConfirmarDeposito.Click += new System.EventHandler(this.btnConfirmarDeposito_Click);
            // 
            // txtMontoDeposito
            // 
            this.txtMontoDeposito.Location = new System.Drawing.Point(185, 32);
            this.txtMontoDeposito.Name = "txtMontoDeposito";
            this.txtMontoDeposito.Size = new System.Drawing.Size(100, 26);
            this.txtMontoDeposito.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Monto a depositar: $";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(259, 357);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(224, 49);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 812);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "BANCO_UTP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gpbMenuServicios.ResumeLayout(false);
            this.gpbMenuServicios.PerformLayout();
            this.gpbRetiro.ResumeLayout(false);
            this.gpbRetiro.PerformLayout();
            this.gpbDeposito.ResumeLayout(false);
            this.gpbDeposito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblSeleccionarboton;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtAñoNac;
        private System.Windows.Forms.TextBox txtCrearContraseña;
        private System.Windows.Forms.TextBox txtCrearUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCrearContraseña;
        private System.Windows.Forms.Label lblCrearUsuario;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnContinuar_Menu;
        private System.Windows.Forms.Button btnRegresar_CrearCuenta;
        private System.Windows.Forms.TextBox txtIngreseContraseña;
        private System.Windows.Forms.TextBox txtIngreseUsuario;
        private System.Windows.Forms.Label lblNomContraseña;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSalirInicio;
        private System.Windows.Forms.RadioButton rdbPagoUTP;
        private System.Windows.Forms.RadioButton rdbRetirarSaldo;
        private System.Windows.Forms.RadioButton rdbDepositoCuenta;
        private System.Windows.Forms.RadioButton rdbMostrarDatos;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Label lblAccionRealizada;
        private System.Windows.Forms.GroupBox gpbMenuServicios;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarPag;
        private System.Windows.Forms.TextBox txtOpcionServicio;
        private System.Windows.Forms.GroupBox gpbRetiro;
        private System.Windows.Forms.Button btnConfirmarRetiro;
        private System.Windows.Forms.TextBox txtMontoRetiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbDeposito;
        private System.Windows.Forms.Button btnConfirmarDeposito;
        private System.Windows.Forms.TextBox txtMontoDeposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

