using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String01.Servicios
{
    internal interface ValidadoresInterfaz
    {
        public bool nombreValidador(string nombreCliente, string apellidoCliente, string segundoApellidoCliente);

        public bool dniValidador(long numeroDniClinete, string letraDniCliene);

        public bool postalValidador(string postalCliente);
    }
}
