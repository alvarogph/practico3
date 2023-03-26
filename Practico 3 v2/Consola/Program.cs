
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;


internal class Program


{
    static private Sistema _sistema = new Sistema();
    static void Main(string[] args)
    {


        try
        {

            for (int i = 0; i < _sistema.Autos.Count; i++)
            {
                Console.WriteLine(_sistema.Autos[i]);
            }

        }
        catch (Exception)
        {
            Console.WriteLine("no");
        }

    }
}