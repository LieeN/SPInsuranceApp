namespace Viewlayer.Views
{
    partial class FormTrend
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrend));
            this.användare = new System.Windows.Forms.Label();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.företagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btnExportera = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbÅr = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.privatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.företagToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.visaProvsionsvärdetabellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaSemesterersättningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prospektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.behörighetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.visaStatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaTrendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datasourceProvision = new Viewlayer.DatasourceProvision();
            this.personalSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalSetTableAdapter = new Viewlayer.DatasourceProvisionTableAdapters.PersonalSetTableAdapter();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasourceProvision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // användare
            // 
            this.användare.AutoSize = true;
            this.användare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.användare.Location = new System.Drawing.Point(333, 46);
            this.användare.Name = "användare";
            this.användare.Size = new System.Drawing.Size(94, 20);
            this.användare.TabIndex = 1;
            this.användare.Text = "Användare: ";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem16,
            this.företagToolStripMenuItem});
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItem15.Text = "Försäkringar";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem16.Text = "Privat";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.mSFörsäkringarVisaPrivat);
            // 
            // företagToolStripMenuItem
            // 
            this.företagToolStripMenuItem.Name = "företagToolStripMenuItem";
            this.företagToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.företagToolStripMenuItem.Text = "Företag";
            this.företagToolStripMenuItem.Click += new System.EventHandler(this.mSFörsäkringarVisaFöretag);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.btnExportera);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbÅr);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 66);
            this.panel3.TabIndex = 88;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(44, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(221, 15);
            this.label19.TabIndex = 85;
            this.label19.Text = "Sålda sjuk och olycksförsäkringar";
            // 
            // btnExportera
            // 
            this.btnExportera.Location = new System.Drawing.Point(563, 19);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(75, 41);
            this.btnExportera.TabIndex = 3;
            this.btnExportera.Text = "Exportera till Excel";
            this.btnExportera.UseVisualStyleBackColor = true;
            this.btnExportera.Click += new System.EventHandler(this.Exportera_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "År:";
            // 
            // cbÅr
            // 
            this.cbÅr.FormattingEnabled = true;
            this.cbÅr.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cbÅr.Location = new System.Drawing.Point(70, 39);
            this.cbÅr.Name = "cbÅr";
            this.cbÅr.Size = new System.Drawing.Size(121, 21);
            this.cbÅr.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.användare);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 131);
            this.panel1.TabIndex = 87;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem10,
            this.toolStripMenuItem15,
            this.toolStripMenuItem17,
            this.prospektToolStripMenuItem,
            this.toolStripMenuItem21,
            this.provisionToolStripMenuItem,
            this.toolStripMenuItem26});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(650, 24);
            this.menuStrip2.TabIndex = 89;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "Start";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem2.Text = "Huvudmeny";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.mSStartHuvudMeny);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem3.Text = "Min profil";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.mSStartMinProfil);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem4.Text = "Logga ut";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem5.Text = "Register";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem6.Text = "Privat";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.mSRegisterPrivat);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem7.Text = "Företag";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.mSRegisterFöretag);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem14});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(86, 20);
            this.toolStripMenuItem10.Text = "Ansökningar";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem11.Text = "Skapa ny ";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem12.Text = "Privat";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.mSSkapaNyAnsökanPrivat);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem13.Text = "Företag";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.mSSkapaNyAnsökanFöretag);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privatToolStripMenuItem,
            this.företagToolStripMenuItem1});
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem14.Text = "Visa ansökningar";
            // 
            // privatToolStripMenuItem
            // 
            this.privatToolStripMenuItem.Name = "privatToolStripMenuItem";
            this.privatToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.privatToolStripMenuItem.Text = "Privat";
            this.privatToolStripMenuItem.Click += new System.EventHandler(this.mSAnsökningarVisaPrivat);
            // 
            // företagToolStripMenuItem1
            // 
            this.företagToolStripMenuItem1.Name = "företagToolStripMenuItem1";
            this.företagToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.företagToolStripMenuItem1.Text = "Företag";
            this.företagToolStripMenuItem1.Click += new System.EventHandler(this.mSAnsökningarVisaFöretag);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem18,
            this.visaProvsionsvärdetabellToolStripMenuItem,
            this.visaSemesterersättningToolStripMenuItem});
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(101, 20);
            this.toolStripMenuItem17.Text = "Grunduppgifter";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItem18.Text = "Visa Försäkringstyp/Tillval";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.mSVisaFörsäkringstypTillval);
            // 
            // visaProvsionsvärdetabellToolStripMenuItem
            // 
            this.visaProvsionsvärdetabellToolStripMenuItem.Name = "visaProvsionsvärdetabellToolStripMenuItem";
            this.visaProvsionsvärdetabellToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.visaProvsionsvärdetabellToolStripMenuItem.Text = "Visa Provsionsvärdetabell";
            this.visaProvsionsvärdetabellToolStripMenuItem.Click += new System.EventHandler(this.mSVisaProvisionsvärdetabell);
            // 
            // visaSemesterersättningToolStripMenuItem
            // 
            this.visaSemesterersättningToolStripMenuItem.Name = "visaSemesterersättningToolStripMenuItem";
            this.visaSemesterersättningToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.visaSemesterersättningToolStripMenuItem.Text = "Visa Semesterersättning";
            this.visaSemesterersättningToolStripMenuItem.Click += new System.EventHandler(this.mSVisaSemesterersättning);
            // 
            // prospektToolStripMenuItem
            // 
            this.prospektToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem20});
            this.prospektToolStripMenuItem.Name = "prospektToolStripMenuItem";
            this.prospektToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.prospektToolStripMenuItem.Text = "Prospekt";
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem20.Text = "Skriv ut";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem20_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem22,
            this.behörighetToolStripMenuItem});
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItem21.Text = "Personal";
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem22.Text = "Visa personal";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.mSVisaPersonal);
            // 
            // behörighetToolStripMenuItem
            // 
            this.behörighetToolStripMenuItem.Name = "behörighetToolStripMenuItem";
            this.behörighetToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.behörighetToolStripMenuItem.Text = "Behörighet";
            this.behörighetToolStripMenuItem.Click += new System.EventHandler(this.mSVisaBehörighet);
            // 
            // provisionToolStripMenuItem
            // 
            this.provisionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem25});
            this.provisionToolStripMenuItem.Name = "provisionToolStripMenuItem";
            this.provisionToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.provisionToolStripMenuItem.Text = "Provision";
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem25.Text = "Visa provision";
            this.toolStripMenuItem25.Click += new System.EventHandler(this.mSVisaProvision);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visaStatistikToolStripMenuItem,
            this.visaTrendToolStripMenuItem});
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem26.Text = "Statistik";
            // 
            // visaStatistikToolStripMenuItem
            // 
            this.visaStatistikToolStripMenuItem.Name = "visaStatistikToolStripMenuItem";
            this.visaStatistikToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.visaStatistikToolStripMenuItem.Text = "Visa försäljningsstatistik";
            this.visaStatistikToolStripMenuItem.Click += new System.EventHandler(this.mSVisaFörsäljningsstatistik);
            // 
            // visaTrendToolStripMenuItem
            // 
            this.visaTrendToolStripMenuItem.Name = "visaTrendToolStripMenuItem";
            this.visaTrendToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.visaTrendToolStripMenuItem.Text = "Visa trend";
            this.visaTrendToolStripMenuItem.Click += new System.EventHandler(this.mSVisaTrend);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 37);
            this.label3.TabIndex = 88;
            this.label3.Text = "Trend";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // datasourceProvision
            // 
            this.datasourceProvision.DataSetName = "DatasourceProvision";
            this.datasourceProvision.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalSetBindingSource
            // 
            this.personalSetBindingSource.DataMember = "PersonalSet";
            this.personalSetBindingSource.DataSource = this.datasourceProvision;
            // 
            // personalSetTableAdapter
            // 
            this.personalSetTableAdapter.ClearBeforeFill = true;
            // 
            // FormTrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 463);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormTrend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trend";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTrend_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasourceProvision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label användare;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem företagToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnExportera;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbÅr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem privatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem företagToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem visaProvsionsvärdetabellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaSemesterersättningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prospektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem behörighetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem visaStatistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaTrendToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatasourceProvision datasourceProvision;
        private System.Windows.Forms.BindingSource personalSetBindingSource;
        private DatasourceProvisionTableAdapters.PersonalSetTableAdapter personalSetTableAdapter;
    }
}