namespace precartillas.frm
{
    partial class FrmConscriptos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGridInfoConscripto = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // propertyGridInfoConscripto
            // 
            this.propertyGridInfoConscripto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridInfoConscripto.Location = new System.Drawing.Point(0, 0);
            this.propertyGridInfoConscripto.Name = "propertyGridInfoConscripto";
            this.propertyGridInfoConscripto.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGridInfoConscripto.Size = new System.Drawing.Size(522, 420);
            this.propertyGridInfoConscripto.TabIndex = 0;
            this.propertyGridInfoConscripto.ToolbarVisible = false;
            // 
            // FrmConscriptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 420);
            this.Controls.Add(this.propertyGridInfoConscripto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConscriptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Conscriptos";
            this.Load += new System.EventHandler(this.FrmConscriptos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGridInfoConscripto;
    }
}