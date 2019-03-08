namespace Viewlayer.Views
{
    partial class FormSkapaNyFöretagsFörsäkring
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
            this.tbFörsäkringsNr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProvisionsbelopp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.tbFörsäkringsID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBetald = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbFörsäkringsNr
            // 
            this.tbFörsäkringsNr.Location = new System.Drawing.Point(303, 35);
            this.tbFörsäkringsNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFörsäkringsNr.Name = "tbFörsäkringsNr";
            this.tbFörsäkringsNr.Size = new System.Drawing.Size(187, 22);
            this.tbFörsäkringsNr.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Önskad försäkringnummer:";
            // 
            // tbProvisionsbelopp
            // 
            this.tbProvisionsbelopp.Location = new System.Drawing.Point(303, 61);
            this.tbProvisionsbelopp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProvisionsbelopp.Name = "tbProvisionsbelopp";
            this.tbProvisionsbelopp.Size = new System.Drawing.Size(187, 22);
            this.tbProvisionsbelopp.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ange eventuellt provisionsbelopp:";
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(415, 118);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(75, 23);
            this.btnAvbryt.TabIndex = 21;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(334, 118);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(75, 23);
            this.btnSpara.TabIndex = 20;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // tbFörsäkringsID
            // 
            this.tbFörsäkringsID.Location = new System.Drawing.Point(303, 9);
            this.tbFörsäkringsID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFörsäkringsID.Name = "tbFörsäkringsID";
            this.tbFörsäkringsID.Size = new System.Drawing.Size(187, 22);
            this.tbFörsäkringsID.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Önskad ansökningsId att göra till försäkring:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Betald:";
            // 
            // cbBetald
            // 
            this.cbBetald.FormattingEnabled = true;
            this.cbBetald.Items.AddRange(new object[] {
            "Ja",
            "Nej"});
            this.cbBetald.Location = new System.Drawing.Point(303, 89);
            this.cbBetald.Name = "cbBetald";
            this.cbBetald.Size = new System.Drawing.Size(187, 24);
            this.cbBetald.TabIndex = 29;
            // 
            // FormSkapaNyFöretagsFörsäkring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 157);
            this.Controls.Add(this.cbBetald);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFörsäkringsID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFörsäkringsNr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProvisionsbelopp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnSpara);
            this.Name = "FormSkapaNyFöretagsFörsäkring";
            this.Text = "Skapa ny företags försäkring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbFörsäkringsNr;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbProvisionsbelopp;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnAvbryt;
        public System.Windows.Forms.Button btnSpara;
        public System.Windows.Forms.TextBox tbFörsäkringsID;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBetald;
    }
}