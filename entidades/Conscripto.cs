using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace entidades
{
    public class Conscripto : Documento
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Category("Datos Básicos")]
        [DisplayName("Nombre:")]
        public string Nombre { get; set; }
        
        [MaxLength(70)]
        [Category("Datos Básicos")]
        [DisplayName("Matrícula:")]
        public string Matricula { get; set; }

        [Category("Datos Básicos")]
        [DisplayName("Clase:")]
        public int Clase { get; set; }
        [Category("Datos Básicos")]
        [DisplayName("Estudios:")]
        public int IdEstudios { get; set; }

        [Category("Dirección")]
        [DisplayName("Calle:")]
        public string Calle { get; set; }
        [Category("Dirección")]
        [DisplayName("Primer Cruzamiento:")]
        public string CruzamientoA { get; set; }

        [Category("Dirección")]
        [DisplayName("Segundo Cruzamiento:")]
        public string SegundoCruzamiento { get; set; }

        [Category("Dirección")]
        [DisplayName("No. Exterior:")]
        public string NoExterior { get; set; }
        [Category("Dirección")]
        [DisplayName("No. Interior:")]
        public string NoInterior { get; set; }

        [Category("Dirección")]
        [DisplayName("Colonia:")]
        public string Colonia { get; set; }

        [Category("Dirección")]
        [DisplayName("Ciudad:")]
        public string Ciudad { get; set; }
        [Category("Dirección")]
        [DisplayName("Municipio:")]

        public string Municipio { get; set; }
        [Category("Dirección")]
        [DisplayName("Código Postal:")]
        public string Cp { get; set; }
        [Category("Dirección")]
        [DisplayName("Estado:")]
        public string EdoResidencai { get; set; }
        [Category("Información de Contacto")]
        [DisplayName("Teléfono:")]
        [Phone]
        public string Telefono { get; set; }

        [Category("Información de Contacto")]
        [DisplayName("Celular:")]
        [Phone]
        public string Celular { get; set; }
        [Category("Información de Contacto")]
        [DisplayName("Correo Electrónico:")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
