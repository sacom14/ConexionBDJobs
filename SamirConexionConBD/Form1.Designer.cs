namespace SamirConexionConBD
{
    partial class Form1
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
            this.butConnectBD = new System.Windows.Forms.Button();
            this.butDesconnectBD = new System.Windows.Forms.Button();
            this.textBoxConnectionStatus = new System.Windows.Forms.TextBox();
            this.LabJobTitle = new System.Windows.Forms.Label();
            this.labMinSalary = new System.Windows.Forms.Label();
            this.labMaxSalary = new System.Windows.Forms.Label();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.textBoxMinSalary = new System.Windows.Forms.TextBox();
            this.textBoxMaxSalary = new System.Windows.Forms.TextBox();
            this.listBoxJobsList = new System.Windows.Forms.ListBox();
            this.butAddJob = new System.Windows.Forms.Button();
            this.butRefreshList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butConnectBD
            // 
            this.butConnectBD.Location = new System.Drawing.Point(61, 29);
            this.butConnectBD.Name = "butConnectBD";
            this.butConnectBD.Size = new System.Drawing.Size(184, 67);
            this.butConnectBD.TabIndex = 0;
            this.butConnectBD.Text = "Connect BD";
            this.butConnectBD.UseVisualStyleBackColor = true;
            this.butConnectBD.Click += new System.EventHandler(this.connectBD);
            // 
            // butDesconnectBD
            // 
            this.butDesconnectBD.Location = new System.Drawing.Point(302, 29);
            this.butDesconnectBD.Name = "butDesconnectBD";
            this.butDesconnectBD.Size = new System.Drawing.Size(184, 67);
            this.butDesconnectBD.TabIndex = 1;
            this.butDesconnectBD.Text = "Desconnect BD";
            this.butDesconnectBD.UseVisualStyleBackColor = true;
            this.butDesconnectBD.Click += new System.EventHandler(this.DesconnectBD);
            // 
            // textBoxConnectionStatus
            // 
            this.textBoxConnectionStatus.Location = new System.Drawing.Point(61, 112);
            this.textBoxConnectionStatus.Name = "textBoxConnectionStatus";
            this.textBoxConnectionStatus.Size = new System.Drawing.Size(425, 31);
            this.textBoxConnectionStatus.TabIndex = 2;
            this.textBoxConnectionStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxConnectionStatus.Visible = false;
            // 
            // LabJobTitle
            // 
            this.LabJobTitle.AutoSize = true;
            this.LabJobTitle.Location = new System.Drawing.Point(209, 179);
            this.LabJobTitle.Name = "LabJobTitle";
            this.LabJobTitle.Size = new System.Drawing.Size(94, 25);
            this.LabJobTitle.TabIndex = 3;
            this.LabJobTitle.Text = "Job Title";
            // 
            // labMinSalary
            // 
            this.labMinSalary.AutoSize = true;
            this.labMinSalary.Location = new System.Drawing.Point(209, 265);
            this.labMinSalary.Name = "labMinSalary";
            this.labMinSalary.Size = new System.Drawing.Size(114, 25);
            this.labMinSalary.TabIndex = 4;
            this.labMinSalary.Text = "Min Salary";
            // 
            // labMaxSalary
            // 
            this.labMaxSalary.AutoSize = true;
            this.labMaxSalary.Location = new System.Drawing.Point(209, 349);
            this.labMaxSalary.Name = "labMaxSalary";
            this.labMaxSalary.Size = new System.Drawing.Size(120, 25);
            this.labMaxSalary.TabIndex = 5;
            this.labMaxSalary.Text = "Max Salary";
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(135, 207);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(247, 31);
            this.textBoxJobTitle.TabIndex = 6;
            // 
            // textBoxMinSalary
            // 
            this.textBoxMinSalary.Location = new System.Drawing.Point(135, 293);
            this.textBoxMinSalary.Name = "textBoxMinSalary";
            this.textBoxMinSalary.Size = new System.Drawing.Size(247, 31);
            this.textBoxMinSalary.TabIndex = 7;
            // 
            // textBoxMaxSalary
            // 
            this.textBoxMaxSalary.Location = new System.Drawing.Point(135, 389);
            this.textBoxMaxSalary.Name = "textBoxMaxSalary";
            this.textBoxMaxSalary.Size = new System.Drawing.Size(247, 31);
            this.textBoxMaxSalary.TabIndex = 8;
            // 
            // listBoxJobsList
            // 
            this.listBoxJobsList.FormattingEnabled = true;
            this.listBoxJobsList.ItemHeight = 25;
            this.listBoxJobsList.Location = new System.Drawing.Point(32, 526);
            this.listBoxJobsList.Name = "listBoxJobsList";
            this.listBoxJobsList.Size = new System.Drawing.Size(497, 229);
            this.listBoxJobsList.TabIndex = 9;
            // 
            // butAddJob
            // 
            this.butAddJob.Location = new System.Drawing.Point(169, 444);
            this.butAddJob.Name = "butAddJob";
            this.butAddJob.Size = new System.Drawing.Size(175, 43);
            this.butAddJob.TabIndex = 10;
            this.butAddJob.Text = "Add New Job";
            this.butAddJob.UseVisualStyleBackColor = true;
            this.butAddJob.Click += new System.EventHandler(this.AddNewJob);
            // 
            // butRefreshList
            // 
            this.butRefreshList.Location = new System.Drawing.Point(156, 780);
            this.butRefreshList.Name = "butRefreshList";
            this.butRefreshList.Size = new System.Drawing.Size(226, 43);
            this.butRefreshList.TabIndex = 11;
            this.butRefreshList.Text = "Refresh List";
            this.butRefreshList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 867);
            this.Controls.Add(this.butRefreshList);
            this.Controls.Add(this.butAddJob);
            this.Controls.Add(this.listBoxJobsList);
            this.Controls.Add(this.textBoxMaxSalary);
            this.Controls.Add(this.textBoxMinSalary);
            this.Controls.Add(this.textBoxJobTitle);
            this.Controls.Add(this.labMaxSalary);
            this.Controls.Add(this.labMinSalary);
            this.Controls.Add(this.LabJobTitle);
            this.Controls.Add(this.textBoxConnectionStatus);
            this.Controls.Add(this.butDesconnectBD);
            this.Controls.Add(this.butConnectBD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butConnectBD;
        private System.Windows.Forms.Button butDesconnectBD;
        private System.Windows.Forms.TextBox textBoxConnectionStatus;
        private System.Windows.Forms.Label LabJobTitle;
        private System.Windows.Forms.Label labMinSalary;
        private System.Windows.Forms.Label labMaxSalary;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.TextBox textBoxMinSalary;
        private System.Windows.Forms.TextBox textBoxMaxSalary;
        private System.Windows.Forms.ListBox listBoxJobsList;
        private System.Windows.Forms.Button butAddJob;
        private System.Windows.Forms.Button butRefreshList;
    }
}

