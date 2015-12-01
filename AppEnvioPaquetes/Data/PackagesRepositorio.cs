using AppEnvioPaquetes.PackagesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppEnvioPaquetes.Data
{
    public class PackagesRepositorio
    {
        static List<Package> paquetes = new List<Package>();
        static List<TwoDayPackage> tdp = new List<TwoDayPackage>();
        static List<OvernightPackage> op = new List<OvernightPackage>();

        Package pkg1 = new Package(001, "Almirante", "Carlos", "Colombia","Bolivar", 0123, 0123, 0.8, 50 );
                
        public void addPackage(Package p)
        {            
            paquetes.Add(p);
        }
        public IEnumerable<Package> getPackage()
        {
            return paquetes;
        }
        public void addTDP(TwoDayPackage t)
        {
            tdp.Add(t);
        }
        public IEnumerable<TwoDayPackage> getTDP()
        {
            return tdp;
        }
        public void addNightPackage(OvernightPackage o)
        {
            op.Add(o);
        }
        public IEnumerable<OvernightPackage> getNightPackage()
        {
            return op;
        }
    }
}