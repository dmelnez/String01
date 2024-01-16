using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String01.Servicios
{
    internal interface OperativaInterfaz
    {
        string solNombre();
        string solPrimerApellido();
        string solSegundoApellido();
        public long solDniClienteNum();
        public string solDniClienteLetra();

        public string solCodigoPostal();
    }
}
