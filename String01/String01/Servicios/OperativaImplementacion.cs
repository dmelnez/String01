using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String01.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public string solNombre()
        {
            Console.WriteLine("Introduzca su Nombre");
            string nombreCliente = Console.ReadLine();
            return nombreCliente;
        }

        public string solPrimerApellido()
        {
            Console.WriteLine("Introduzca su Primer Apellido");
            string apellidoCliente = Console.ReadLine();
            return apellidoCliente;

        }


        public string solSegundoApellido()
        {
            Console.WriteLine("Introduzca su Nombre");
            string segundoApellidoCliente = Console.ReadLine();
            return segundoApellidoCliente;
        }

        public long solDniClienteNum()
        {
            Console.WriteLine("Introduzca su DNI");
            long dniCliente = Convert.ToInt64(Console.ReadLine());

            return dniCliente;

        }

        public string solDniClienteLetra()
        {
            Console.WriteLine("Introduzca la letra de su DNI");
            string dniCliente = Console.ReadLine();

            return dniCliente;

        }

        public string solCodigoPostal()
        {
            Console.WriteLine("Introduzca su codigo postal");
            string codPostalCliente = Console.ReadLine();
            return codPostalCliente;


        }



    }
}
