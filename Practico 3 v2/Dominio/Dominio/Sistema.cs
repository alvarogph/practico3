using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        private List<Auto> _auto = new List<Auto>();
        private List<Modelo> _modelo = new List<Modelo>();


        public List<Auto> Autos
        {
            get { return _auto; }
        }

        public List<Modelo> Modelos
        {
            get { return _modelo; }
        }

        public Sistema()
        {
            PrecargarDatosModelos();
            PrecargarDatosAutos();
        }

        public void PrecargarDatosModelos()
        {
            Modelo unMod1 = new Modelo("Escarabajo", "Alemania");
            AgregarModelo(unMod1);

            Modelo unMod2 = new Modelo("Twingo", "Francia");
            AgregarModelo(unMod2);

            Modelo unMod3 = new Modelo("Uno", "Italia");
            AgregarModelo(unMod2);
        }

        public void PrecargarDatosAutos()

        {
            DateTime fecha1 = new DateTime(2005, 01, 20);
            DateTime fecha2 = new DateTime(2022, 03, 24);
            DateTime fecha3 = new DateTime(2023, 01, 20);

            Auto unAuto1 = new Auto("Fiat", _modelo[0], 2005, true, 123456, fecha1);
            AgregarAuto(unAuto1);
            Auto unAuto2 = new Auto("Fiat", _modelo[1], 2005, false, 234567, fecha2);
            AgregarAuto(unAuto2);
            Auto unAuto3 = new Auto("Fiat", _modelo[2], 2005, true, 234567, fecha3);
            AgregarAuto(unAuto3);
        }

        public void AgregarAuto(Auto auto)
        {
            if (buscarMatricula(auto.Matricula) == true)
            {
                throw new Exception("El auto ingresado ya existe");
            }
            _auto.Add(auto);
        }


        public void AgregarModelo(Modelo modelo)
        {
            _modelo.Add(modelo);
        }

        private bool buscarMatricula(int matricula)
        {

            for (int i = 0; i < _auto.Count(); i++)
            {
                if (_auto[i].Matricula == matricula)
                {
                    return true;
                }
            }
            return false;

        }
    }
}