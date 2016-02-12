namespace WindowsApp
{
    partial class Form1
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
            this.lblService = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.btnCheckService = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.SuspendLayout();
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(12, 43);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(73, 13);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Servicenavn :";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(105, 43);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(159, 20);
            this.txtService.TabIndex = 1;
            // 
            // btnCheckService
            // 
            this.btnCheckService.Location = new System.Drawing.Point(15, 97);
            this.btnCheckService.Name = "btnCheckService";
            this.btnCheckService.Size = new System.Drawing.Size(249, 43);
            this.btnCheckService.TabIndex = 2;
            this.btnCheckService.Text = "Check Status";
            this.btnCheckService.UseVisualStyleBackColor = true;
            this.btnCheckService.Click += new System.EventHandler(this.btnCheckService_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 169);
            this.Controls.Add(this.btnCheckService);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.lblService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Button btnCheckService;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}

