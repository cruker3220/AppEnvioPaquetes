using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppEnvioPaquetes.PackagesRepo
{
    public class OvernightPackage : Package
    {
        public double CuotaEnvio { get; set; }

        public OvernightPackage() : base()
        {
            CuotaEnvio = 0.0;
        }
        public OvernightPackage(int codigo, string direccion, string nombre, string pais,
            string departamento, int codpostrem, int codpostdest, double peso, double costoporgramos, double cuota)
            : base (codigo, direccion, nombre, pais, departamento, codpostrem, codpostdest, peso, costoporgramos)
        {
            CuotaEnvio = cuota;
        }
        public override string ToString()
        {
            return base.ToString() +
                "\nCuota envio nocturno: " + CuotaEnvio;
        }
        public override bool Equals(object obj)
        {
            OvernightPackage  t = (OvernightPackage)obj;
            bool result = false;
            if ((base.Equals(t)) &&
                this.CuotaEnvio == t.CuotaEnvio)
            {
                result = true;
            }
            return result;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override double calculateCost()
        {
            double costo;
            costo = base.calculateCost();
            costo += CuotaEnvio;
            return costo;
        }
    }
}