using AppEnvioPaquetes.Bills;
using AppEnvioPaquetes.Customers;
using AppEnvioPaquetes.Data;
using AppEnvioPaquetes.PackagesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AppEnvioPaquetes
{
    /// <summary>
    /// Descripción breve de ServicioEnvioDePaquetes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioEnvioDePaquetes : System.Web.Services.WebService
    {
        PackagesRepositorio packages = new PackagesRepositorio();
        CustomersRepositorio customers = new CustomersRepositorio();
        BillsRepositorio facturas = new BillsRepositorio();

        [WebMethod]
        public void addPaquetes(int Codigo,
                               string Nombre,
                               string Direccion,
                               string Pais,
                               string Departamento,
                               int CodPosRemitente,
                               int CodPosDestinatario,
                               double Peso,
                               double CostoPorGramos)
        {
            Package pkg = new Package(Codigo,
                                        Nombre,
                                        Direccion,
                                        Pais,
                                        Departamento,
                                        CodPosRemitente,
                                        CodPosDestinatario,
                                        Peso,
                                        CostoPorGramos);

            packages.addPackage(pkg);

        }

        [WebMethod]
        public string showPackages()
        {
            string result = "";
            foreach (Package i in packages.getPackage())
                result += i.ToString();
            return result;
        }

        [WebMethod]
        public void addTDP(int Codigo,
                               string Nombre,
                               string Direccion,
                               string Pais,
                               string Departamento,
                               int CodPosRemitente,
                               int CodPosDestinatario,
                               double Peso,
                               double CostoPorGramos,
                                double Cuota)
        {
            TwoDayPackage pkg = new TwoDayPackage(Codigo,
                                        Nombre,
                                        Direccion,
                                        Pais,
                                        Departamento,
                                        CodPosRemitente,
                                        CodPosDestinatario,
                                        Peso,
                                        CostoPorGramos,
                                        Cuota);

            packages.addTDP(pkg);

        }

        [WebMethod]
        public string showTDP()
        {
            string result = "";
            foreach (TwoDayPackage i in packages.getTDP())
                result += i.ToString();
            return result;
        }

        [WebMethod]
        public void addNightPackage(int Codigo,
                               string Nombre,
                               string Direccion,
                               string Pais,
                               string Departamento,
                               int CodPosRemitente,
                               int CodPosDestinatario,
                               double Peso,
                               double CostoPorGramos,
                                double Cuota)
        {
            OvernightPackage pkg = new OvernightPackage(Codigo,
                                        Nombre,
                                        Direccion,
                                        Pais,
                                        Departamento,
                                        CodPosRemitente,
                                        CodPosDestinatario,
                                        Peso,
                                        CostoPorGramos,
                                        Cuota);

            packages.addNightPackage(pkg);

        }

        [WebMethod]
        public string showNoghtPackages()
        {
            string result = "";
            foreach (OvernightPackage i in packages.getNightPackage())
                result += i.ToString();
            return result;
        }

        [WebMethod]
        public void AgregarCliente(int IdC, string NombreC, string DireccionC, string TelefonoC, string EmailC, int tipoC)
        {
            Customer c = new Customer(IdC, NombreC, DireccionC, TelefonoC, EmailC, tipoC);
            customers.addCustomer(c);
        }
        [WebMethod]
        public string MostrarClientes()
        {
            string result = "";
            foreach (Customer c in customers.getCustomer())
                result += c.ToString();
            return result;
        }

        [WebMethod]
        public string BuscarClientes(int id)
        {
            string result = "El cliente solicitado no existe!";
            foreach (Customer c in customers.getCustomer())
                if (c.IdCliente == id)
                {
                    result = "";
                    result += c.ToString();
                }               
            return result;
        }
        [WebMethod]
        public Customer EditarClientes(int id)
        {
            Customer cli = new Customer();
            foreach (Customer c in customers.getCustomer())
                if (c.IdCliente == id)
                {
                    cli = c;                   
                }
            return cli;
        }

        [WebMethod]
        public string TipoBusquedaClientes(string tipo)
        {
            string result = "";
            foreach (Customer c in customers.getCustomer())
                if (c.TipoCliente == tipo)
                {                    
                    result += c.ToString();
                }
            return result;
        }

       
    }
}
