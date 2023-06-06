using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Net_2.Model
{
    internal class Validación_Mod11
    {
        static bool ValidarModulo11(string numero)
        {
            int factor = 2;
            int suma = 0;

            // Recorremos el número de derecha a izquierda
            for (int i = numero.Length - 1; i >= 0; i--)
            {
                int digito = int.Parse(numero[i].ToString());
                suma += digito * factor;

                factor++;
                if (factor > 7)
                    factor = 2;
            }

            int resto = suma % 11;
            int digitoVerificador = 11 - resto;

            if (digitoVerificador == 10)
                digitoVerificador = 1; // Si el dígito verificador calculado es 10, lo consideramos como 1
            else if (digitoVerificador == 11)
                digitoVerificador = 0; // Si el dígito verificador calculado es 11, lo consideramos como 0

            int ultimoDigito = int.Parse(numero[numero.Length - 1].ToString());

            return digitoVerificador == ultimoDigito;
        }
    }
}

