using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppEnvioPaquetes.Customers
{
    public class Customer
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string DirCliente { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string TipoCliente;

        #region constructores
        public Customer()
        {
            IdCliente = 0;
            NombreCliente = "Nombre del cliente";
            DirCliente = "Direccion del cliente";
            Telefono = "Telefono del cliente";
            Email = "Correo del cliente";
            TipoCliente = clientType(3);
        }
        public Customer(int idCliente, string nombre, string direccion, string telefono, string email, int tip)
        {
            IdCliente = idCliente;
            NombreCliente = nombre;
            DirCliente = direccion;
            Telefono = telefono;
            Email = email;
            TipoCliente = clientType(tip);
        }
        #endregion
        #region metodos sobreescritos
        public override string ToString()
        {
            return
                "\nID: " + IdCliente +
                "\nDireccion: " + DirCliente +
                "\nNombre: " + NombreCliente +
                "\nTelefono: " + Telefono +
                "\nEmail: " + Email +
                "\nTipo de Cliente: " + TipoCliente;
        }
        public override bool Equals(object obj)
        {
            Customer p = (Customer)obj;
            bool result = false;
            if ((IdCliente == p.IdCliente) &&
                (DirCliente == p.DirCliente) &&
                (NombreCliente == p.NombreCliente) &&
                (Telefono == p.Telefono) &&
                (Email == p.Email) && 
                (TipoCliente == p.TipoCliente))
            {
                result = true;
            }
            return result;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public virtual string clientType(int op)
        {
            string type;
            type = "Regular";            
            if (op == 1)
            {
                type = "VIP";
            }
            else if (op == 2)
            {
                type = "Afiliado";
            }
            return type;
        }
        #endregion
    }
}