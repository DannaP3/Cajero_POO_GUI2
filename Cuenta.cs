using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BancoUTP
{
    internal class Cuenta :Usuario
    {
        //aatributos
        private string nombre, fecha;
        private double SaldoActual1;
        private bool realizado = false;

        //propiedades get y set
        public string P_nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string P_fecha
        {
            set { fecha = value; }
            get { return fecha; }
        }

        public double SaldoA
        {
            set { SaldoActual1 = value; }
            get { return SaldoActual1; }
        }

        //Metodo constructor

        public Cuenta():base(0)
        {
            this.nombre = "";
            this.fecha = "";
            this.SaldoActual1 = 0.0;
        }

        public string MostrarDatosCuenta()
        {
            return "--------BANCO UTP--------\n" +
                   "Fecha: " + fecha + "\n" +
                   "Nombre: " + nombre + "\n" +
                   "Edad: " + CalcularEdad() + " años\n" +
                   "Saldo Actual: $ " + SaldoActual1 + "\n" +
                   "-------------------------";
        }
        public bool DepositarCuenta(double deposito)
        {
            if (deposito >= 0)
            {
                SaldoActual1 += deposito;
                realizado = true;
            }
            return realizado;
        }

        public bool RetirtarCuenta(int retiro)
        { 
            if (retiro <= SaldoActual1)
            {

                SaldoActual1 = SaldoActual1 - retiro;
                realizado = true;
            }
            return realizado;
        }
        public string PagoServicios(int opcion)
        {
            double totalPago = 0.0;

            switch (opcion)
            {
                case 1:
                    totalPago = 100.0;
                    break;
                case 2:
                    totalPago = 50.0;
                    break;
                case 3:
                    totalPago = 2600.0;
                    break;
                default:
                    return "Opción no válida.";
            }

            if (SaldoActual1 >= totalPago)
            {
                SaldoActual1 = SaldoActual1 - totalPago;
                return "Pago realizado correctamente.\nMonto: $" + totalPago + "\nNuevo Saldo: $" + SaldoActual1;
            }
            else
            {
                return "Error: Saldo insuficiente.";
            }
        }
    }
}
