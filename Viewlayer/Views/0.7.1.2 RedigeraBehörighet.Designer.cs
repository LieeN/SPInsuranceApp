namespace Viewlayer.Views
{
    partial class FormRedigeraBehörighet
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
            this.tbUppdateraID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUppdateraBehörighet = new System.Windows.Forms.TextBox();
            this.tbRoll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(177, 82);
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
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Önskad ID att redigera: ";
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(116, 82);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(56, 19);
            this.btnSpara.TabIndex = 4;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // tbUppdateraID
            // 
            this.tbUppdateraID.Enabled = false;
            this.tbUppdateraID.Location = new System.Drawing.Point(158, 5);
            this.tbUppdateraID.Margin = new System.Windows.Forms.Padding(2);
            this.tbUppdateraID.Name = "tbUppdateraID";
            this.tbUppdateraID.Size = new System.Drawing.Size(76, 20);
            this.tbUppdateraID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ange önskad ny behörighet: ";
            // 
            // tbUppdateraBehörighet
            // 
            this.tbUppdateraBehörighet.Location = new System.Drawing.Point(158, 32);
            this.tbUppdateraBehörighet.Margin = new System.Windows.Forms.Padding(2);
            this.tbUppdateraBehörighet.Name = "tbUppdateraBehörighet";
            this.tbUppdateraBehörighet.Size = new System.Drawing.Size(76, 20);
            this.tbUppdateraBehörighet.TabIndex = 2;
            // 
            // tbRoll
            // 
            this.tbRoll.Location = new System.Drawing.Point(158, 58);
            this.tbRoll.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoll.Name = "tbRoll";
            this.tbRoll.Size = new System.Drawing.Size(76, 20);
            this.tbRoll.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Önskad ny roll:";
            // 
            // FormRedigeraBehörighet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 113);
            this.Controls.Add(this.tbRoll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUppdateraBehörighet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.tbUppdateraID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRedigeraBehörighet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redigera behörighet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbUppdateraID;
        public System.Windows.Forms.TextBox tbUppdateraBehörighet;
        public System.Windows.Forms.TextBox tbRoll;
        private System.Windows.Forms.Label label3;
    }
}