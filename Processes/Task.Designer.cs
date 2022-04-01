
namespace Processes
{
    partial class Task
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dGrdProcess = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(264, 375);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 63);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dGrdProcess
            // 
            this.dGrdProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrdProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.executable,
            this.Owner});
            this.dGrdProcess.Location = new System.Drawing.Point(12, 12);
            this.dGrdProcess.Name = "dGrdProcess";
            this.dGrdProcess.RowHeadersWidth = 51;
            this.dGrdProcess.RowTemplate.Height = 24;
            this.dGrdProcess.Size = new System.Drawing.Size(797, 339);
            this.dGrdProcess.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "Process ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 100;
            // 
            // Name
            // 
            this.Name.HeaderText = "Process Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 160;
            // 
            // executable
            // 
            this.executable.HeaderText = "Executable Name";
            this.executable.MinimumWidth = 6;
            this.executable.Name = "executable";
            this.executable.ReadOnly = true;
            this.executable.Width = 160;
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Owner";
            this.Owner.MinimumWidth = 6;
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            this.Owner.Width = 100;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.dGrdProcess);
            this.Controls.Add(this.btnRefresh); 
            this.Text = "Process";
            this.Load += new System.EventHandler(this.Task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrdProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dGrdProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn executable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
    }
}

