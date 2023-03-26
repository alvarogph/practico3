using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
    public class Auto
    {
        public string Marca { get; set; }
        public Modelo Modelo { get; set; }
        public int Anio { get; set; }
        public bool Usado { get; set; }
        public int Matricula { get; set; }
        public DateTime FechaServicio { get; set; }


        public Auto(string marca, Modelo modelo, int anio, bool usado, int matricula, DateTime fechaServicio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Usado = usado;
            Matricula = matricula;
            FechaServicio = fechaServicio;
        }

        public string ProximoServicio(DateTime fechaServicio)
        {
            string mensaje;
            int dias = (DateTime.Now - fechaServicio).Days;

            if (dias < 365)
            {
                mensaje = "La proxima fecha de servicio es en " + (365 - dias + " dias");
            }
            else
            {
                mensaje = "El período de servicio ha expirado. Haga un servicio urgente para evitar problemas";
            }

            return mensaje;
        }


        public string mensajeUsado(bool Usado)
        {
            string mensaje;
            if (Usado == true)
            {
                 mensaje = "Si";
            
            }
            else
            {
                 mensaje = "No";
            }

            return mensaje;
        }

        public override string ToString()
        {
            string respuesta = string.Empty;
            respuesta += "********************\n";
            respuesta += $"Marca {Marca}\n";
            respuesta += $"Nombre {Modelo.Nombre}\n ";
            respuesta += $"Anio {Anio}\n ";
            respuesta += $"Es usado? {mensajeUsado(Usado)}\n ";
            respuesta += $"Matricula {Matricula}\n ";
            respuesta += $"Última fecha de servicio {FechaServicio}\n ";
            respuesta += $"Proximo servicios {ProximoServicio(FechaServicio)}\n";
            return respuesta;
        }




    }
}
