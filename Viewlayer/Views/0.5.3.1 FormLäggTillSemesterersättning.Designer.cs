namespace Viewlayer.Views
{
    partial class FormLäggTillSemesterersättning
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
            this.tbÅr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProcentsats = new System.Windows.Forms.TextBox();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.tbAvdrag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbÅr
            // 
            this.tbÅr.Location = new System.Drawing.Point(192, 11);
            this.tbÅr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbÅr.Name = "tbÅr";
            this.tbÅr.Size = new System.Drawing.Size(200, 22);
            this.tbÅr.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ange år:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ange procentsats:";
            // 
            // tbProcentsats
            // 
            this.tbProcentsats.Location = new System.Drawing.Point(192, 37);
            this.tbProcentsats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProcentsats.Name = "tbProcentsats";
            this.tbProcentsats.Size = new System.Drawing.Size(200, 22);
            this.tbProcentsats.TabIndex = 2;
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(317, 99);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(75, 23);
            this.btnAvbryt.TabIndex = 5;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ange avdrag:";
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(237, 99);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(75, 23);
            this.btnSpara.TabIndex = 4;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // tbAvdrag
            // 
            this.tbAvdrag.Location = new System.Drawing.Point(192, 63);
            this.tbAvdrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAvdrag.Name = "tbAvdrag";
            this.tbAvdrag.Size = new System.Drawing.Size(200, 22);
            this.tbAvdrag.TabIndex = 3;
            // 
            // FormLäggTillSemesterersättning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 139);
            this.Controls.Add(this.tbÅr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProcentsats);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.tbAvdrag);
            this.Name = "FormLäggTillSemesterersättning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till semesterersättning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbÅr;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbProcentsats;
        public System.Windows.Forms.Button btnAvbryt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSpara;
        public System.Windows.Forms.TextBox tbAvdrag;
    }
}