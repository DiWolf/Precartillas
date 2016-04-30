namespace precartillas.UserCatalogos
{
    partial class UserControlEstudios
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEstudios));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.advTreeEstudios = new DevComponents.AdvTree.AdvTree();
            this.MenuArbol = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElementoSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeRoot = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.propertyGridEstudios = new System.Windows.Forms.PropertyGrid();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTreeEstudios)).BeginInit();
            this.MenuArbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.advTreeEstudios);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(485, 485);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 0;
            // 
            // advTreeEstudios
            // 
            this.advTreeEstudios.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTreeEstudios.AllowDrop = true;
            this.advTreeEstudios.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTreeEstudios.BackgroundStyle.Class = "TreeBorderKey";
            this.advTreeEstudios.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTreeEstudios.ContextMenuStrip = this.MenuArbol;
            this.advTreeEstudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advTreeEstudios.Location = new System.Drawing.Point(0, 0);
            this.advTreeEstudios.Name = "advTreeEstudios";
            this.advTreeEstudios.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.nodeRoot});
            this.advTreeEstudios.NodesConnector = this.nodeConnector1;
            this.advTreeEstudios.NodeStyle = this.elementStyle1;
            this.advTreeEstudios.PathSeparator = ";";
            this.advTreeEstudios.Size = new System.Drawing.Size(217, 485);
            this.advTreeEstudios.Styles.Add(this.elementStyle1);
            this.advTreeEstudios.TabIndex = 0;
            this.advTreeEstudios.Text = "advTreeEstudios";
            this.advTreeEstudios.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.advTreeEstudios_AfterNodeSelect);
            // 
            // MenuArbol
            // 
            this.MenuArbol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarElementoToolStripMenuItem,
            this.eliminarElementoSeleccionadoToolStripMenuItem});
            this.MenuArbol.Name = "MenuArbol";
            this.MenuArbol.Size = new System.Drawing.Size(243, 70);
            // 
            // agregarElementoToolStripMenuItem
            // 
            this.agregarElementoToolStripMenuItem.Name = "agregarElementoToolStripMenuItem";
            this.agregarElementoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.agregarElementoToolStripMenuItem.Text = "Agregar elemento";
            this.agregarElementoToolStripMenuItem.Click += new System.EventHandler(this.agregarElementoToolStripMenuItem_Click);
            // 
            // eliminarElementoSeleccionadoToolStripMenuItem
            // 
            this.eliminarElementoSeleccionadoToolStripMenuItem.Name = "eliminarElementoSeleccionadoToolStripMenuItem";
            this.eliminarElementoSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.eliminarElementoSeleccionadoToolStripMenuItem.Text = "Eliminar elemento seleccionado";
            this.eliminarElementoSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarElementoSeleccionadoToolStripMenuItem_Click);
            // 
            // nodeRoot
            // 
            this.nodeRoot.Expanded = true;
            this.nodeRoot.Image = ((System.Drawing.Image)(resources.GetObject("nodeRoot.Image")));
            this.nodeRoot.Name = "nodeRoot";
            this.nodeRoot.Text = "Grados de estudios";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Class = "";
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.propertyGridEstudios);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnActualizar);
            this.splitContainer2.Size = new System.Drawing.Size(264, 485);
            this.splitContainer2.SplitterDistance = 348;
            this.splitContainer2.TabIndex = 0;
            // 
            // propertyGridEstudios
            // 
            this.propertyGridEstudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridEstudios.Location = new System.Drawing.Point(0, 0);
            this.propertyGridEstudios.Name = "propertyGridEstudios";
            this.propertyGridEstudios.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGridEstudios.Size = new System.Drawing.Size(264, 348);
            this.propertyGridEstudios.TabIndex = 0;
            this.propertyGridEstudios.ToolbarVisible = false;
            this.propertyGridEstudios.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridEstudios_PropertyValueChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(21, 19);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actulizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // UserControlEstudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControlEstudios";
            this.Size = new System.Drawing.Size(485, 485);
            this.Load += new System.EventHandler(this.UserControlEstudios_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTreeEstudios)).EndInit();
            this.MenuArbol.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propertyGridEstudios;
        private System.Windows.Forms.ContextMenuStrip MenuArbol;
        private System.Windows.Forms.ToolStripMenuItem agregarElementoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElementoSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.Button btnActualizar;
        private DevComponents.AdvTree.AdvTree advTreeEstudios;
        private DevComponents.AdvTree.Node nodeRoot;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
    }
}
