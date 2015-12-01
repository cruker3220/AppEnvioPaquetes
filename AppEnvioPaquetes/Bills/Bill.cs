using AppEnvioPaquetes.Customers;
using AppEnvioPaquetes.PackagesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppEnvioPaquetes.Bills
{
    public class Bill
    {
        public int IdBill { get; set; }        
        public Customer Cliente { get; set; }
        public List<Package> Items { get; set; }
        public double ValorFactura;

        public Bill()
        {
            IdBill = 0;
            Cliente = new Customer();
            Items = new List<Package>();
            ValorFactura = totalCost();
        }

        public Bill(int id, Customer c, List<Package> p)
        {
            IdBill = id;
            Cliente = c;
            Items = p;
            ValorFactura = totalCost();
        }

        public double totalCost()
        {            
            double suma = 0.0;
            foreach (Package p in Items)
                suma += p.ValorEnvio;
            return suma;
        }

        public override string ToString()
        {
            return
                "\nId Factura: " + IdBill +
                "\nId Cliente: " + Cliente.IdCliente +
                "\nNombre Cliente: " + Cliente.NombreCliente +
                "\nDireccion Cliente: " + Cliente.DirCliente +
                "\nTelefono: " + Cliente.Telefono +
                "\nTipo cliente: " + Cliente.TipoCliente +
                "\n"
                ;
                
        }
    }
}