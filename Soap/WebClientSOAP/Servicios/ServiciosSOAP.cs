﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using WebClientSOAP.Models;


namespace WebClientSOAP.Servicios
{
    public class ServiciosSOAP
    {
        public RutModel RunRut(string Rut) 
        {

            WsSOAP.funcionesClient run = new WsSOAP.funcionesClient();
            if(Rut == null)
            {
                Rut = "";
            }
            return new RutModel()
            {
                Rut = run.digitoVerificador(Rut)
                
            };
        }

        public NombresModel RunSeparacion(string Nombre)
        {

            WsSOAP.funcionesClient run = new WsSOAP.funcionesClient();
            if(Nombre == null)
            {
                Nombre = "";
            }
            return new NombresModel()
            {
                Nombre = run.separarNombre(Nombre)

            };

        }
    }
}
