namespace Viewlayer.Views
{
    partial class FormSkapaBehörighet
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
            this.tbBehörighetstyp = new System.Windows.Forms.TextBox();
            this.btnSpara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRoll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbBehörighetstyp
            // 
            this.tbBehörighetstyp.Location = new System.Drawing.Point(122, 8);
            this.tbBehörighetstyp.Margin = new System.Windows.Forms.Padding(2);
            this.tbBehörighetstyp.Name = "tbBehörighetstyp";
            this.tbBehörighetstyp.Size = new System.Drawing.Size(76, 20);
            this.tbBehörighetstyp.TabIndex = 1;
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(82, 57);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(56, 19);
            this.btnSpara.TabIndex = 3;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ange Behörighetstyp:";
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(142, 57);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(56, 19);
            this.btnAvbryt.TabIndex = 4;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ange roll";
            // 
            // tbRoll
            // 
            this.tbRoll.Location = new System.Drawing.Point(122, 33);
            this.tbRoll.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoll.Name = "tbRoll";
            this.tbRoll.Size = new System.Drawing.Size(76, 20);
            this.tbRoll.TabIndex = 2;
            // 
            // FormSkapaBehörighet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 89);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRoll);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.tbBehörighetstyp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSkapaBehörighet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrera behörighet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBehörighetstyp;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRoll;
    }
}