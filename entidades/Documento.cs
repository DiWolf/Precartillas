using System.ComponentModel;

namespace entidades
{
    public class Documento
    {
        [Category("Documentación")]
        [DisplayName("Acta de nacimiento:")]
        public bool ActaNacimiento { get; set; }
        [Category("Documentación")]
        [DisplayName("Fotografías:")]
        public bool Fotografias { get; set; }
        [Category("Documentación")]
        [DisplayName("Comprobante de Estudios:")]
        public bool ComprobanteEstudios { get; set; }

        [Category("Documentación")]
        [DisplayName("C.U.R.P:")]
        public bool Curp { get; set; }
        [Category("Documentación")]
        [DisplayName("Constancia de no trámite de Cartilla:")]
        public bool ConstanciaNoTramite { get; set; }

        [Category("Documentación")]
        [DisplayName("Comprobante de Domicilio:")]
        public bool ComprobanteDomicilio { get; set; }
    }
}
