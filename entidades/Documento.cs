using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Documento
    {
        [Category("Documentación")]
        public bool ActaNacimiento { get; set; }
        [Category("Documentación")]
        public bool ReciboAgua { get; set; }
    }
}
