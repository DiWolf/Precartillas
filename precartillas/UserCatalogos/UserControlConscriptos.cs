using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using precartillas.frm;

namespace precartillas.UserCatalogos
{
    public partial class UserControlConscriptos : UserControl
    {
        public UserControlConscriptos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmConscriptos frm = new FrmConscriptos();
            frm.ShowDialog();
        }
    }
}
