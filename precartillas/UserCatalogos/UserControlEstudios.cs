using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;

namespace precartillas.UserCatalogos
{
    public partial class UserControlEstudios : UserControl
    {

        private Estudio estudio = new Estudio();
        
        public UserControlEstudios()
        {
            InitializeComponent();
            this.GenerarPropiedades();
        }

        private void UserControlEstudios_Load(object sender, EventArgs e)
        {
            propertyGridEstudios.SelectedObject = estudio;
        }

        private void GenerarPropiedades()
        {
            
        }
    }
}
