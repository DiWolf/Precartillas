﻿namespace precartillas.UserCatalogos
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewEstudios = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.propertyGridEstudios = new System.Windows.Forms.PropertyGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuArbol = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElementoSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.MenuArbol.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.treeViewEstudios);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(485, 485);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewEstudios
            // 
            this.treeViewEstudios.ContextMenuStrip = this.MenuArbol;
            this.treeViewEstudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewEstudios.Location = new System.Drawing.Point(0, 0);
            this.treeViewEstudios.Name = "treeViewEstudios";
            this.treeViewEstudios.Size = new System.Drawing.Size(217, 485);
            this.treeViewEstudios.TabIndex = 0;
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
            this.splitContainer2.Panel2.Controls.Add(this.button1);
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuArbol
            // 
            this.MenuArbol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarElementoToolStripMenuItem,
            this.eliminarElementoSeleccionadoToolStripMenuItem});
            this.MenuArbol.Name = "MenuArbol";
            this.MenuArbol.Size = new System.Drawing.Size(243, 48);
            // 
            // agregarElementoToolStripMenuItem
            // 
            this.agregarElementoToolStripMenuItem.Name = "agregarElementoToolStripMenuItem";
            this.agregarElementoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.agregarElementoToolStripMenuItem.Text = "Agregar elemento";
            // 
            // eliminarElementoSeleccionadoToolStripMenuItem
            // 
            this.eliminarElementoSeleccionadoToolStripMenuItem.Name = "eliminarElementoSeleccionadoToolStripMenuItem";
            this.eliminarElementoSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.eliminarElementoSeleccionadoToolStripMenuItem.Text = "Eliminar elemento seleccionado";
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.MenuArbol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewEstudios;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propertyGridEstudios;
        private System.Windows.Forms.ContextMenuStrip MenuArbol;
        private System.Windows.Forms.ToolStripMenuItem agregarElementoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElementoSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}