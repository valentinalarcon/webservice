using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClientSOAP.Models;

namespace WebClientSOAP.Servicios
{
    public class ServiciosSOAP
    {
        public RutModel RunRut(string Rut) 
        {
            string aux;

            WsSOAP.funcionesClient run = new WsSOAP.funcionesClient();
            if(Rut == null)
            {
                Rut = "";
            }
            return new RutModel()
            {
                aux = run.digito_verificador(Rut),
                Rut = run.dv_rut(Rut)
                
            };
        }
    }
}
