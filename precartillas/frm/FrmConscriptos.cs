using System;
using System.Windows.Forms;
using ado;
using entidades;

namespace precartillas.frm
{
    public partial class FrmConscriptos : Form
    {
        private Conscripto cons = new Conscripto();
        private DaoConscripto dao = new DaoConscripto();
        private int index; 
        public FrmConscriptos()
        {
            InitializeComponent();
        }

        public FrmConscriptos(int index)
        {
            InitializeComponent();
            this.GenerarPropiedades(index);
        }

        private void FrmConscriptos_Load(object sender, EventArgs e)
        {
            propertyGridInfoConscripto.SelectedObject = cons;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cons.FechaRegistro > DateTime.Now)
            {
                MessageBox.Show("La fecha de registro no puede ser mayor a la fecha actual", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                dao.AgAct(cons);
            }

        }

        private void GenerarPropiedades(int index)
        {
            try
            {
                cons = dao.ListarById(index);
                propertyGridInfoConscripto.SelectedObject = cons;
            }
            catch(Exception e)
            {

            }
            
        }
    }
}
