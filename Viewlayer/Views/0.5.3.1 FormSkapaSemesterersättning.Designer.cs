namespace Viewlayer.Views
{
    partial class FormSkapaSemesterersättning
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbProcentsats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAvdrag = new System.Windows.Forms.TextBox();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.tbÅr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ange procentsats:";
            // 
            // tbProcentsats
            // 
            this.tbProcentsats.Location = new System.Drawing.Point(225, 63);
            this.tbProcentsats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProcentsats.Name = "tbProcentsats";
            this.tbProcentsats.Size = new System.Drawing.Size(100, 22);
            this.tbProcentsats.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ange avdrag/marginal:";
            // 
            // tbAvdrag
            // 
            this.tbAvdrag.Location = new System.Drawing.Point(225, 37);
            this.tbAvdrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAvdrag.Name = "tbAvdrag";
            this.tbAvdrag.Size = new System.Drawing.Size(100, 22);
            this.tbAvdrag.TabIndex = 20;
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(250, 89);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(75, 23);
            this.btnAvbryt.TabIndex = 23;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ange år:";
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(170, 89);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(75, 23);
            this.btnSpara.TabIndex = 22;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // tbÅr
            // 
            this.tbÅr.Location = new System.Drawing.Point(225, 11);
            this.tbÅr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbÅr.Name = "tbÅr";
            this.tbÅr.Size = new System.Drawing.Size(100, 22);
            this.tbÅr.TabIndex = 19;
            // 
            // FormSkapaSemesterersättning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 129);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProcentsats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAvdrag);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.tbÅr);
            this.Name = "FormSkapaSemesterersättning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skapa semesterersättning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbProcentsats;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbAvdrag;
        public System.Windows.Forms.Button btnAvbryt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSpara;
        public System.Windows.Forms.TextBox tbÅr;
    }
}