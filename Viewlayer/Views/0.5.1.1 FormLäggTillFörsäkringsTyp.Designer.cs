namespace Viewlayer.Views
{
    partial class FormLäggTillFörsäkringsTyp
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
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.tbFörsäkringstyp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(204, 32);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(56, 19);
            this.btnAvbryt.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ange försäkringstyp";
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(143, 32);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(56, 19);
            this.btnSpara.TabIndex = 2;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // tbFörsäkringstyp
            // 
            this.tbFörsäkringstyp.Location = new System.Drawing.Point(120, 10);
            this.tbFörsäkringstyp.Margin = new System.Windows.Forms.Padding(2);
            this.tbFörsäkringstyp.Name = "tbFörsäkringstyp";
            this.tbFörsäkringstyp.Size = new System.Drawing.Size(141, 20);
            this.tbFörsäkringstyp.TabIndex = 1;
            // 
            // FormLäggTillFörsäkringsTyp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 62);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.tbFörsäkringstyp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLäggTillFörsäkringsTyp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till försäkringsTyp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.TextBox tbFörsäkringstyp;
    }
}