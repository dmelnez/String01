
using String01.Servicios;


class Program
{


    static void Main(string[] args)
    {





        OperativaInterfaz op = new OperativaImplementacion();
        ValidadoresInterfaz va = new ValidoresImplementacion();

        

        string nombreCliente = op.solNombre();
        string primerApellidoCliente = op.solPrimerApellido();
        string segundoApellidoCliente = op.solSegundoApellido();



        bool nombreIgual = va.nombreValidador(nombreCliente, primerApellidoCliente, segundoApellidoCliente);


        Console.WriteLine(nombreIgual);
    


        long numerDniClinete = op.solDniClienteNum();
        string letraDniCliene = op.solDniClienteLetra();
       
        Console.WriteLine("Se va a validar la letra del dni");
     
        bool dnival = va.dniValidador(numerDniClinete, letraDniCliene);
        Console.WriteLine(dnival);

        // Solicitar Codigo Postal y validarlo 

        string codigoPostalCliente = op.solCodigoPostal();
      
        va.postalValidador(codigoPostalCliente);


        // -----------------------------------------------------------


        // Falta que el nombre no aparezca, solo la concatenacion de los apellidos
        string nombreCompletoCliente = primerApellidoCliente + " " + segundoApellidoCliente + "," + " " + nombreCliente;

        string[] apellidosCliente = nombreCompletoCliente.Split(',');
        foreach (string cliente in apellidosCliente)
        {
            Console.WriteLine(cliente);
        }
        // -----------------------------------------------------------

        //Cantidad de caracteres de la variable IMPORTANTE !! Quitar el Console
        Console.WriteLine(nombreCompletoCliente.Count());

        //Recupera y muestra por consola el décimo carácter de la variable con los apellidos.


        //Busca la primera vez que aparece la letra a en el nombre completo.
        nombreCompletoCliente.IndexOf('a');






        /*Si el codigo postal es 410 es de sevilla*/

    }




}
