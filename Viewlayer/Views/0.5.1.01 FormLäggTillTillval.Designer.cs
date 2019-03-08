namespace Viewlayer.Views
{
    partial class FormLäggTillTillval
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbAckVärdeVariabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.tbTillValsNamn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(130, 32);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(141, 20);
            this.dtpDatum.TabIndex = 2;
            // 
            // tbAckVärdeVariabel
            // 
            this.tbAckVärdeVariabel.Location = new System.Drawing.Point(130, 55);
            this.tbAckVärdeVariabel.Margin = new System.Windows.Forms.Padding(2);
            this.tbAckVärdeVariabel.Name = "tbAckVärdeVariabel";
            this.tbAckVärdeVariabel.Size = new System.Drawing.Size(141, 20);
            this.tbAckVärdeVariabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ange ack.värdevariabel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ange datum:";
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(214, 78);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(56, 19);
            this.btnAvbryt.TabIndex = 5;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ange tillvalsnamn:";
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(153, 78);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(56, 19);
            this.btnSpara.TabIndex = 4;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // tbTillValsNamn
            // 
            this.tbTillValsNamn.Location = new System.Drawing.Point(130, 10);
            this.tbTillValsNamn.Margin = new System.Windows.Forms.Padding(2);
            this.tbTillValsNamn.Name = "tbTillValsNamn";
            this.tbTillValsNamn.Size = new System.Drawing.Size(141, 20);
            this.tbTillValsNamn.TabIndex = 1;
            // 
            // FormLäggTillTillval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 111);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbAckVärdeVariabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.tbTillValsNamn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLäggTillTillval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till tillval";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtpDatum;
        public System.Windows.Forms.TextBox tbAckVärdeVariabel;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAvbryt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSpara;
        public System.Windows.Forms.TextBox tbTillValsNamn;
    }
}