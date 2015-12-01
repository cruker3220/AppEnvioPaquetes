using AppEnvioPaquetes.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppEnvioPaquetes.Customers;
using AppEnvioPaquetes.PackagesRepo;

namespace AppEnvioPaquetes.Data
{
    public class BillsRepositorio
    {
        static List<Bill> bills = new List<Bill>();
        private static Customer c;
        private static List<Package> p;
        Bill fac1 = new Bill(1,c,p);

        public void addBill(Bill b)
        {
            bills.Add(b);
        }

        public IEnumerable<Bill> getBills()
        {
            return bills;
        }
    }
}