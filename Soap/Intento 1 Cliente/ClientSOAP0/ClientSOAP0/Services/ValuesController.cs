using ClientSOAP0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClientSOAP0.Services
{
    public class ServicioSoap
    {
        public RutSOAP DVrut(string rut)
        {
            ServiceReference1.funcionesClient run = new ServiceReference1.funcionesClient();
            if(rut == null)
            {
                rut = "";
            }
            return new RutSOAP()
            {
                Rut = run.dv_rut(DVrut)
            };
        }
        public 
    }
}