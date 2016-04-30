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
using Microsoft.VisualBasic;
using ado;

namespace precartillas.UserCatalogos
{
    public partial class UserControlEstudios : UserControl
    {

        private Estudio estudio = new Estudio();
        private DaoEstudios dao;
        private DevComponents.AdvTree.Node nodo = new DevComponents.AdvTree.Node();
        private int index;
        
        public UserControlEstudios()
        {
            InitializeComponent();
            this.GenerarPropiedades();
        }

        private void UserControlEstudios_Load(object sender, EventArgs e)
        {
           
        }

        private void GenerarPropiedades()
        {
            propertyGridEstudios.SelectedObject = estudio;
        }

        private void agregarElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AgregarGrado(); 
        }

        //Crear nuevo grado de estudio 
        private void AgregarGrado()
        {
            var value = Interaction.InputBox("Ingrese el grado de estudios", "Ingresar datos", "");
            dao = new DaoEstudios();
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("La información proporcionada es incorrecta o nula", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                estudio = new Estudio();
                estudio.Grado = value;
                estudio.Id = 0;
                dao.AgAct(estudio);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.GenerarArbol();
        }

        private void GenerarArbol()
        {
            dao = new DaoEstudios();
            advTreeEstudios.BeginUpdate();
            nodeRoot.Nodes.Clear();
            foreach (var item in dao.Listar())
            {
                nodo = new DevComponents.AdvTree.Node();
                nodo.Text =  item.Id.ToString();
                nodo.Cells.Add(new DevComponents.AdvTree.Cell(item.Grado));
                nodeRoot.Nodes.Add(nodo);
            }
            advTreeEstudios.EndUpdate();  
        }

        private void advTreeEstudios_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            try
            {
                dao = new DaoEstudios();
                index = Convert.ToInt32(e.Node.Text);
                var result = dao.ListarById(index);
                estudio = result;
                propertyGridEstudios.SelectedObject = estudio;
                this.GenerarPropiedades();
            }
            catch(Exception)
            {
                propertyGridEstudios.SelectedObject = estudio;
                this.GenerarPropiedades(); 
            }
            
        }

        private void propertyGridEstudios_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            dao = new DaoEstudios();
            dao.AgAct(estudio);
        }

        private void eliminarElementoSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(string.Format("¿Deseas eliminar el registro {0} del sistema? ", estudio.Grado), "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                dao = new DaoEstudios();
                dao.Eliminar(index);
            }
        }
    }
}
