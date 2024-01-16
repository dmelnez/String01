using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String01.Servicios
{
    internal class ValidoresImplementacion : ValidadoresInterfaz
    {
        public bool nombreValidador(string nombreCliente, string apellidoCliente, string segundoApellidoCliente)
        {
            bool validadorNombre = false;

            if (nombreCliente.Equals(apellidoCliente))
            {

                Console.WriteLine("############################################################");
                Console.WriteLine("# [INFO] -- El nombre es igual que el Primer Apellido      #");
                Console.WriteLine("############################################################");
                validadorNombre = true;

            }

            if (nombreCliente.Equals(segundoApellidoCliente))
            {
                Console.WriteLine("############################################################");
                Console.WriteLine("# [INFO] -- El nombre es igual que el Segundo Apellido     #");
                Console.WriteLine("############################################################");
                validadorNombre = true;

            }

            return validadorNombre;

        }


        public bool dniValidador(long numeroDniClinete, string letraDniCliene)
        {

            bool dniValidador = false;

            long restoDni = numeroDniClinete % 23;

            Console.WriteLine(restoDni);

            switch (restoDni)
            {
                case 0:
                    dniValidador = letraDniCliene.Equals("T");
                    
                    break;

                case 1:
                    dniValidador = letraDniCliene.Equals("R");
                    break;

                case 2:
                    dniValidador = letraDniCliene.Equals("W");
                    break;

                case 3:
                    dniValidador = letraDniCliene.Equals("A");
                    break;

                case 4:
                    dniValidador = letraDniCliene.Equals("G");
                    break;

                case 5:
                    dniValidador = letraDniCliene.Equals("M");
                    break;

                case 6:
                    dniValidador = letraDniCliene.Equals("Y");
                   
                    break;

                case 7:
                    dniValidador = letraDniCliene.Equals("F");
                    break;

                case 8:
                    dniValidador = letraDniCliene.Equals("P");
                    break;

                case 9:
                    dniValidador = letraDniCliene.Equals("D");
                    break;

                case 10:
                    dniValidador = letraDniCliene.Equals("X");
                    break;

                case 11:
                    dniValidador = letraDniCliene.Equals("B");
                    break;

                case 12:
                    dniValidador = letraDniCliene.Equals("N");
                    break;

                case 13:
                    dniValidador = letraDniCliene.Equals("J");
                    break;

                case 14:
                    dniValidador = letraDniCliene.Equals("Z");
                    break;

                case 15:
                    dniValidador = letraDniCliene.Equals("S");
                    break;

                case 16:
                    dniValidador = letraDniCliene.Equals("Q");
                    break;

                case 17:
                    dniValidador = letraDniCliene.Equals("V");
                    break;

                case 18:
                    dniValidador = letraDniCliene.Equals("H");
                    break;

                case 19:
                    dniValidador = letraDniCliene.Equals("L");
                    break;

                case 20:
                    dniValidador = letraDniCliene.Equals("C");
                    break;

                case 21:
                    dniValidador = letraDniCliene.Equals("K");
                    break;

                case 22:
                    dniValidador = letraDniCliene.Equals("E");
                    break;

                default:
                    Console.WriteLine("La letra del DNI, no es coincidente con el Numero de DNI");
                    break;



            }

            Console.WriteLine(dniValidador);
            return dniValidador;



        }


        public bool postalValidador(string postalCliente)
        {

           

            bool postalValidador = false;

            if (postalCliente.Equals(410)){

                Console.WriteLine("El cliente es de sevilla");

                postalValidador = true;


            }  

            else
            {

                Console.WriteLine("El cliente no es de sevilla");


            }



            return postalValidador;



        }



    }
}
