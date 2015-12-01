using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppEnvioPaquetes.PackagesRepo
{
    public class Package
    {
        #region "Propiedades"
        public int Codigo { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public int CodPosRemitente { get; set; }
        public int CodPosDestinatario { get; set; }
        public double Peso { get; set; }
        public double CostoPorGramos { get; set; }
        public double ValorEnvio;
        #endregion

        #region constructores
        public Package()
        {
            Codigo = 0;
            Direccion = "Direccion del destinatario";
            Nombre = "Nombre del destinatario";
            Pais = "Pais del destinatario";
            Departamento = "Departamento o estado";
            CodPosRemitente = 0000;
            CodPosDestinatario = 0000;
            Peso = 0.0;
            CostoPorGramos = 0.0;
            ValorEnvio = calculateCost();
        }
        public Package( int codigo, string direccion, string nombre, string pais, 
            string departamento, int codpostrem, int codpostdest, double peso, double costoporgramos)
        {
            Codigo = codigo;
            Direccion = direccion;
            Nombre = nombre;
            Pais = pais;
            Departamento = departamento;
            CodPosRemitente = codpostrem;
            CodPosDestinatario = codpostdest;
            Peso = peso;
            CostoPorGramos = costoporgramos;
            ValorEnvio = calculateCost();
        }
        #endregion
        #region metodos sobreescritos
        public override string ToString()
        {
            return
                "\nCodigo: " + Codigo +
                "\nDireccion: " + Direccion +
                "\nNombre: " + Nombre +
                "\nPais: " + Pais +
                "\nDepartamento: " + Departamento +
                "\nCod Postal Remitente: " + CodPosRemitente +
                "\nCod Postal Destinatario: " + CodPosDestinatario +
                "\nPeso (Kg): " + Peso +
                "\nCosto por Gramos: " + CostoPorGramos +
                "\nValor del Envio: " + ValorEnvio;
        }
        public override bool Equals(object obj)
        {
            Package p = (Package)obj;
            bool result = false;
            if((Codigo == p.Codigo) && 
                (Direccion == p.Direccion) &&
                (Nombre == p.Nombre) &&
                (Pais == p.Pais) &&
                (Departamento == p.Departamento) &&
                (CodPosRemitente == p.CodPosRemitente) &&
                (CodPosDestinatario == p.CodPosDestinatario) &&
                (Peso == p.Peso) &&
                (CostoPorGramos == p.CostoPorGramos) &&
                (ValorEnvio == p.ValorEnvio))
            {
                result = true;
            }
            return result;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion
        public virtual double calculateCost()
        {
            double costo;
            costo = CostoPorGramos * (Peso * 1000);
            return costo;
        }
    }
}