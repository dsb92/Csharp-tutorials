namespace SuperKartoteket_Windows
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            ""}, -1);
            this.grpKunde = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnnuller = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKundeoversigt = new System.Windows.Forms.Panel();
            this.btnSlet = new System.Windows.Forms.Button();
            this.btnRediger = new System.Windows.Forms.Button();
            this.btnNy = new System.Windows.Forms.Button();
            this.lstKundeoversigt = new System.Windows.Forms.ListView();
            this.clnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnAdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTlf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.grpKunde.SuspendLayout();
            this.grpKundeoversigt.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKunde
            // 
            this.grpKunde.Controls.Add(this.label4);
            this.grpKunde.Controls.Add(this.btnAnnuller);
            this.grpKunde.Controls.Add(this.btnOK);
            this.grpKunde.Controls.Add(this.txtTlf);
            this.grpKunde.Controls.Add(this.txtAdr);
            this.grpKunde.Controls.Add(this.txtNavn);
            this.grpKunde.Controls.Add(this.label3);
            this.grpKunde.Controls.Add(this.label2);
            this.grpKunde.Controls.Add(this.label1);
            this.grpKunde.Location = new System.Drawing.Point(13, 13);
            this.grpKunde.Name = "grpKunde";
            this.grpKunde.Size = new System.Drawing.Size(445, 215);
            this.grpKunde.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kunde";
            // 
            // btnAnnuller
            // 
            this.btnAnnuller.Location = new System.Drawing.Point(153, 158);
            this.btnAnnuller.Name = "btnAnnuller";
            this.btnAnnuller.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuller.TabIndex = 7;
            this.btnAnnuller.Text = "Annuller";
            this.btnAnnuller.UseVisualStyleBackColor = true;
            this.btnAnnuller.Click += new System.EventHandler(this.btnAnnuller_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(50, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(153, 106);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(225, 20);
            this.txtTlf.TabIndex = 5;
            // 
            // txtAdr
            // 
            this.txtAdr.Location = new System.Drawing.Point(153, 73);
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(225, 20);
            this.txtAdr.TabIndex = 4;
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(153, 40);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.Size = new System.Drawing.Size(225, 20);
            this.txtNavn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navn :";
            // 
            // grpKundeoversigt
            // 
            this.grpKundeoversigt.Controls.Add(this.lstKundeoversigt);
            this.grpKundeoversigt.Controls.Add(this.btnSlet);
            this.grpKundeoversigt.Controls.Add(this.btnRediger);
            this.grpKundeoversigt.Controls.Add(this.btnNy);
            this.grpKundeoversigt.Controls.Add(this.label5);
            this.grpKundeoversigt.Location = new System.Drawing.Point(13, 231);
            this.grpKundeoversigt.Name = "grpKundeoversigt";
            this.grpKundeoversigt.Size = new System.Drawing.Size(445, 182);
            this.grpKundeoversigt.TabIndex = 1;
            this.grpKundeoversigt.Paint += new System.Windows.Forms.PaintEventHandler(this.grpKundeoversigt_Paint);
            // 
            // btnSlet
            // 
            this.btnSlet.Location = new System.Drawing.Point(251, 144);
            this.btnSlet.Name = "btnSlet";
            this.btnSlet.Size = new System.Drawing.Size(75, 23);
            this.btnSlet.TabIndex = 4;
            this.btnSlet.Text = "Slet";
            this.btnSlet.UseVisualStyleBackColor = true;
            this.btnSlet.Click += new System.EventHandler(this.btnSlet_Click);
            // 
            // btnRediger
            // 
            this.btnRediger.Location = new System.Drawing.Point(153, 145);
            this.btnRediger.Name = "btnRediger";
            this.btnRediger.Size = new System.Drawing.Size(75, 23);
            this.btnRediger.TabIndex = 3;
            this.btnRediger.Text = "Rediger";
            this.btnRediger.UseVisualStyleBackColor = true;
            this.btnRediger.Click += new System.EventHandler(this.btnRediger_Click);
            // 
            // btnNy
            // 
            this.btnNy.Location = new System.Drawing.Point(50, 145);
            this.btnNy.Name = "btnNy";
            this.btnNy.Size = new System.Drawing.Size(75, 23);
            this.btnNy.TabIndex = 2;
            this.btnNy.Text = "Ny";
            this.btnNy.UseVisualStyleBackColor = true;
            this.btnNy.Click += new System.EventHandler(this.btnNy_Click);
            // 
            // lstKundeoversigt
            // 
            this.lstKundeoversigt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnID,
            this.clnNavn,
            this.clnAdr,
            this.clnTlf});
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            this.lstKundeoversigt.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstKundeoversigt.Location = new System.Drawing.Point(14, 16);
            this.lstKundeoversigt.Name = "lstKundeoversigt";
            this.lstKundeoversigt.Size = new System.Drawing.Size(428, 122);
            this.lstKundeoversigt.TabIndex = 9;
            this.lstKundeoversigt.UseCompatibleStateImageBehavior = false;
            this.lstKundeoversigt.View = System.Windows.Forms.View.Details;
            this.lstKundeoversigt.SelectedIndexChanged += new System.EventHandler(this.lstKundeoversigt_SelectedIndexChanged);
            // 
            // clnID
            // 
            this.clnID.Text = "ID";
            this.clnID.Width = 83;
            // 
            // clnNavn
            // 
            this.clnNavn.Text = "Navn";
            this.clnNavn.Width = 82;
            // 
            // clnAdr
            // 
            this.clnAdr.Text = "Adresse";
            this.clnAdr.Width = 154;
            // 
            // clnTlf
            // 
            this.clnTlf.Text = "Telefon";
            this.clnTlf.Width = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kundeoversigt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 423);
            this.Controls.Add(this.grpKundeoversigt);
            this.Controls.Add(this.grpKunde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpKunde.ResumeLayout(false);
            this.grpKunde.PerformLayout();
            this.grpKundeoversigt.ResumeLayout(false);
            this.grpKundeoversigt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel grpKunde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnnuller;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.TextBox txtAdr;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grpKundeoversigt;
        private System.Windows.Forms.Button btnSlet;
        private System.Windows.Forms.Button btnRediger;
        private System.Windows.Forms.Button btnNy;
        private System.Windows.Forms.ListView lstKundeoversigt;
        private System.Windows.Forms.ColumnHeader clnNavn;
        private System.Windows.Forms.ColumnHeader clnAdr;
        private System.Windows.Forms.ColumnHeader clnTlf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader clnID;


    }
}

