namespace Viewlayer.Views
{
    partial class FormLäggTillGrundbelopp
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.tbGrundbelopp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAckVärde = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFörsäkringsTyp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ange datum:";
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(208, 101);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(56, 19);
            this.btnAvbryt.TabIndex = 6;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ange grundbelopp:";
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(147, 101);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(56, 19);
            this.btnSpara.TabIndex = 5;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // tbGrundbelopp
            // 
            this.tbGrundbelopp.Location = new System.Drawing.Point(124, 32);
            this.tbGrundbelopp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGrundbelopp.Name = "tbGrundbelopp";
            this.tbGrundbelopp.Size = new System.Drawing.Size(141, 20);
            this.tbGrundbelopp.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ange ack.värde:";
            // 
            // tbAckVärde
            // 
            this.tbAckVärde.Location = new System.Drawing.Point(124, 78);
            this.tbAckVärde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAckVärde.Name = "tbAckVärde";
            this.tbAckVärde.Size = new System.Drawing.Size(141, 20);
            this.tbAckVärde.TabIndex = 4;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(124, 55);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(141, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Önskad försäkring:";
            // 
            // tbFörsäkringsTyp
            // 
            this.tbFörsäkringsTyp.Location = new System.Drawing.Point(124, 10);
            this.tbFörsäkringsTyp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFörsäkringsTyp.Name = "tbFörsäkringsTyp";
            this.tbFörsäkringsTyp.Size = new System.Drawing.Size(141, 20);
            this.tbFörsäkringsTyp.TabIndex = 1;
            // 
            // FormLäggTillGrundbelopp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 130);
            this.Controls.Add(this.tbFörsäkringsTyp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbAckVärde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.tbGrundbelopp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLäggTillGrundbelopp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till grundbelopp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbFörsäkringsTyp;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAvbryt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSpara;
        public System.Windows.Forms.TextBox tbGrundbelopp;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbAckVärde;
        public System.Windows.Forms.DateTimePicker dtpDatum;
    }
}