using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUTP
{
    internal class Autenticacion 
    {
        private string contrasenia;
        private int Mayuscula, Minuscula, Numeros, Caracter, Espacio;

        public string Pcontrasenia
        {
            set { contrasenia = value; }
            get { return contrasenia; }
        }
        public int Pmayuscula
        {
            set { Mayuscula = value; }
            get { return Mayuscula; }
        }
        public int Pminuscula
        {
            set { Minuscula = value; }
            get { return Minuscula; }
        }
        public int Pnumeros
        {
            set { Numeros = value; }
            get { return Numeros; }
        }
        public int Pcaracteres
        {
            set { Caracter = value; }
            get { return Caracter; }
        }
        public int Pespacios
        {
            set { Espacio = value; }
            get { return Espacio; }
        }

        public void VerificarContrasenia(string palabra)
        {
            Minuscula = 0;
            Mayuscula = 0;
            Numeros = 0;
            Caracter = 0;
            Espacio = 0;
            foreach (char c in palabra)
            {
                if (char.IsLower(c))
                    Minuscula++;
                else if (char.IsUpper(c))
                    Mayuscula++;
                else if (char.IsDigit(c))
                    Numeros++;
                else if (char.IsWhiteSpace(c))
                    Espacio++;
                else
                    Caracter++;
            }
        }
        public string EvaluarContrasenia(string texto)
        {
            if (texto.Length > 0 && char.IsWhiteSpace(texto[0]))
                return " Es invalido empieza con espacios! ";
            if (texto.Length > 0 && char.IsDigit(texto[0]))
                return " Es invalido empieza con numero! ";

            VerificarContrasenia(texto);

            string cadena = "";
            int ContadorReglas = 0;
            if (texto.Length >= 8)
                ContadorReglas++;
            if (Mayuscula >= 1)
                ContadorReglas++;
            if (Minuscula >= 1)
                ContadorReglas++;
            if (Numeros >= 1)
                ContadorReglas++;
            if (Caracter >= 1)
                ContadorReglas++;
            if (Espacio == 0)
                ContadorReglas++;
            if (texto.Length > 0 && !char.IsDigit(texto[0]))
                ContadorReglas++;

            if (ContadorReglas <= 3)
                cadena = "Contraseña DEBIL!";
            else if (ContadorReglas == 4 || ContadorReglas == 5)
                cadena = "Contraseña MEDIA!";
            else
                cadena = "Contraseña FUERTE!";


            return cadena;
        }

        public bool ValidarContrasenia(string contrasenia)
        {
            string resultado = EvaluarContrasenia(contrasenia);

            if (resultado == "Contraseña FUERTE!" || resultado == "Contraseña MEDIA!")
                return true;
            else
                return false;
        }
    }
}
