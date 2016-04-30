using System;
using System.Windows.Forms;
using precartillas.frm;
using ado;

namespace precartillas.UserCatalogos
{
    public partial class UserControlConscriptos : UserControl
    {
        private DaoConscripto dao = new DaoConscripto();
        private int index = 0x0; 
        public UserControlConscriptos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmConscriptos frm = new FrmConscriptos();
            frm.ShowDialog();
        }

        private void btnLlenarGrid_Click(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = dao.VistaConscripto();
            //var rst = MessageBox.Show(string.Format("¿Deseas obtener solo los registros del año {0} ?", DateTime.Now.Year), "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
            ////Si selecciona si 
            //if (rst == DialogResult.Yes)
            //{
            //    //cargar solo registros del año en curso. 
            //}
            //else
            //{
            //    //cargar todos los registros
            //    var result = MessageBox.Show("Este proceso podría tardar unos minutos ¿Deseas continuar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //    if(result== DialogResult.Yes)
            //    {
                 
            //    }
            //    else
            //    {

            //    }
            //}
        
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewX1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    index = Convert.ToInt32(dataGridViewX1.Rows[e.RowIndex].Cells[0x0].Value);
                }
                
            }
            catch(Exception ex)
            {

            }
            
        }

        private void btnEditarSeleccionado_Click(object sender, EventArgs e)
        {
            FrmConscriptos frm = new FrmConscriptos(index);
            frm.ShowDialog();
        }
    }
}
