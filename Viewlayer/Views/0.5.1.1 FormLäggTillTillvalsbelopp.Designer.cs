namespace Viewlayer.Views
{
    partial class FormLäggTillTillvalsbelopp
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
            this.tbFormTillvalFörsäkringsId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.tbFormTillvalGrundbelopp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFormTillvalFörsäkringsId
            // 
            this.tbFormTillvalFörsäkringsId.Location = new System.Drawing.Point(121, 10);
            this.tbFormTillvalFörsäkringsId.Margin = new System.Windows.Forms.Padding(2);
            this.tbFormTillvalFörsäkringsId.Name = "tbFormTillvalFörsäkringsId";
            this.tbFormTillvalFörsäkringsId.Size = new System.Drawing.Size(141, 20);
            this.tbFormTillvalFörsäkringsId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Önskat tillval:";
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(205, 55);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(56, 19);
            this.btnAvbryt.TabIndex = 4;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ange grundbelopp:";
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(144, 55);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(56, 19);
            this.btnSpara.TabIndex = 3;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // tbFormTillvalGrundbelopp
            // 
            this.tbFormTillvalGrundbelopp.Location = new System.Drawing.Point(121, 32);
            this.tbFormTillvalGrundbelopp.Margin = new System.Windows.Forms.Padding(2);
            this.tbFormTillvalGrundbelopp.Name = "tbFormTillvalGrundbelopp";
            this.tbFormTillvalGrundbelopp.Size = new System.Drawing.Size(141, 20);
            this.tbFormTillvalGrundbelopp.TabIndex = 2;
            // 
            // FormLäggTillTillvalsbelopp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 85);
            this.Controls.Add(this.tbFormTillvalFörsäkringsId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.tbFormTillvalGrundbelopp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLäggTillTillvalsbelopp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till tillvalsbelopp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbFormTillvalFörsäkringsId;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnAvbryt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSpara;
        public System.Windows.Forms.TextBox tbFormTillvalGrundbelopp;
    }
}