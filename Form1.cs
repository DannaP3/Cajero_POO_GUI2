using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BancoUTP
{
    public partial class Form1 : Form
    {
        int intentos = 0;

        Autenticacion login = new Autenticacion();
        Cuenta cuen = new Cuenta();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

            if (txtCrearUsuario.Text == "" || txtCrearContraseña.Text == "" || txtAñoNac.Text=="")
            {
                MessageBox.Show("Por favor, rellena todos los campos antes de continuar.");
            }
            else
            {
                bool esNumero = true;

                foreach (char c in txtAñoNac.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        esNumero = false;
                    }
                }

                if (esNumero == false)
                {
                    MessageBox.Show("El año de nacimiento debe ser un número válido (ejemplo: 2004).");
                }
                else
                {
                    if (login.ValidarContrasenia(txtCrearContraseña.Text))
                    {
                        MessageBox.Show("¡Cuenta creada con éxito! La contraseña cumple con los requisitos.\n" + login.EvaluarContrasenia(txtCrearContraseña.Text));
                        tabControl1.SelectedIndex = 2;
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es muy débil. Debe tener al menos 8 caracteres, mayúsculas, minúsculas y números\n" + login.EvaluarContrasenia(txtCrearContraseña.Text));
                        txtCrearContraseña.Clear();
                    }
                }
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnRegresar_CrearCuenta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnContinuar_Menu_Click(object sender, EventArgs e)
        {
            
            if (txtIngreseUsuario.Text == "" || txtIngreseContraseña.Text == "")
            {
                MessageBox.Show("Por favor, introduce tu usuario y contraseña.");
            }
            else
            {
                if (txtIngreseUsuario.Text == txtCrearUsuario.Text && txtIngreseContraseña.Text== txtCrearContraseña.Text)
                {
                    MessageBox.Show("¡Bienvenido a Banco UTP");
                    tabControl1.SelectedIndex = 3;
                }
                else
                {
                    intentos = intentos + 1;

                    if (intentos > 3)
                    {
                        MessageBox.Show("Has perdido tus intentos, has quedado BLOQUEADO.");
                        tabControl1.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Tus datos son incorrectos. Inténtalo nuevamente \n \tError de Autenticación");
                        txtIngreseUsuario.Clear();
                        txtIngreseContraseña.Clear();
                    }
                }
            }
        }

        private void btnSalirInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbMostrarDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMostrarDatos.Checked)
            {
               lblAccionRealizada.Text= cuen.MostrarDatosCuenta();
            }
        }

        private void rdbPagoUTP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPagoUTP.Checked)
            {
                gpbMenuServicios.Visible = true;
                lblAccionRealizada.Text = "";
            }
            else
            {
                gpbMenuServicios.Visible = false;
                txtOpcionServicio.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmarPag_Click(object sender, EventArgs e)
        {
            if (txtOpcionServicio.Text == "")
            {
                MessageBox.Show("Por favor, introduce el número de opción (1, 2 o 3) antes de continuar.", "Campo Vacío");
            }
            else
            {
                int opcionSeleccionada = Convert.ToInt32(txtOpcionServicio.Text);

                if (opcionSeleccionada == 1 || opcionSeleccionada == 2 || opcionSeleccionada == 3)
                {
                    lblAccionRealizada.Text = cuen.PagoServicios(opcionSeleccionada);
                }
                else
                {
                    MessageBox.Show("Opción incorrecta. Por favor, ingresa solo 1, 2 o 3.", "Opción No Válida");
                }
            }
        }

        private void rdbRetirarSaldo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRetirarSaldo.Checked)
            {
                gpbRetiro.Visible = true;
                lblAccionRealizada.Text = "";
            }
            else
            {
                gpbRetiro.Visible = false;
                txtMontoRetiro.Text = "";
            }
        }

        private void btnConfirmarRetiro_Click(object sender, EventArgs e)
        {
            if (txtMontoRetiro.Text == "")
            {
                MessageBox.Show("Por favor, ingresa la cantidad que deseas retirar.", "Campo Vacío");
            }
            else
            {
                int cantidadRetirar = Convert.ToInt32(txtMontoRetiro.Text);
                bool exito = cuen.RetirtarCuenta(cantidadRetirar);

                if (exito == true)
                {
                    lblAccionRealizada.Text = "Retiro exitoso de: $" + cantidadRetirar + "\nNuevo saldo disponible: $" + cuen.SaldoA;
                    MessageBox.Show("Retiro Completado");
                    txtMontoRetiro.Text = "";
                }
                else
                {
                    lblAccionRealizada.Text = "Error Saldo Insuficiente";
                    MessageBox.Show("No cuentas con saldo suficiente para retirar esa cantidad.");
                }
            }
        }

        private void rdbDepositoCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDepositoCuenta.Checked)
            {
                lblAccionRealizada.Text = "";
                gpbDeposito.Visible = true;
            }
            else
            {
                gpbDeposito.Visible = false;
                txtMontoDeposito.Text = "";
            }
        }

        private void btnConfirmarDeposito_Click(object sender, EventArgs e)
        {
            if (txtMontoDeposito.Text == "")
                MessageBox.Show("Por favor, ingresa la cantidad que deseas depositar.");
            else
            {
                double cantidadDepositar = Convert.ToDouble(txtMontoDeposito.Text);

                if (cuen.DepositarCuenta(cantidadDepositar))
                {
                    lblAccionRealizada.Text = "Depósito exitoso de: $" + cantidadDepositar + "\nNuevo saldo disponible: $" + cuen.SaldoA;
                    MessageBox.Show("Depósito exitoso ");
                    txtMontoDeposito.Text = "";
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCrearUsuario.Clear();
            txtCrearUsuario.Clear();
            txtCrearContraseña.Clear();
        }

      
    }
}
