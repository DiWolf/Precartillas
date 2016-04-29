using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;

namespace precartillas.frm
{
    public partial class FrmConscriptos : Form
    {
        private Conscripto cons = new Conscripto();
        public FrmConscriptos()
        {
            InitializeComponent();
        }

        private void FrmConscriptos_Load(object sender, EventArgs e)
        {
            propertyGridInfoConscripto.SelectedObject = cons;
        }
    }
}
