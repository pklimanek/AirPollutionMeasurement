namespace MeteoWF
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.reportbutton = new System.Windows.Forms.Button();
            this.weekbutton = new System.Windows.Forms.Button();
            this.todaybutton = new System.Windows.Forms.Button();
            this.dashbutton = new System.Windows.Forms.Button();
            this.logopanel = new System.Windows.Forms.Panel();
            this.iconpic = new System.Windows.Forms.PictureBox();
            this.appname = new System.Windows.Forms.Label();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.minimisePic = new System.Windows.Forms.PictureBox();
            this.closePic = new System.Windows.Forms.PictureBox();
            this.openNowlabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lastWeek1 = new MeteoWF.historicData();
            this.today1 = new MeteoWF.Today();
            this.dashboard1 = new MeteoWF.dashboard();
            this.generateReport1 = new MeteoWF.generateReport();
            this.sidepanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconpic)).BeginInit();
            this.headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimisePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.SteelBlue;
            this.sidepanel.Controls.Add(this.reportbutton);
            this.sidepanel.Controls.Add(this.weekbutton);
            this.sidepanel.Controls.Add(this.todaybutton);
            this.sidepanel.Controls.Add(this.dashbutton);
            this.sidepanel.Controls.Add(this.logopanel);
            this.sidepanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(195, 511);
            this.sidepanel.TabIndex = 0;
            this.sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // reportbutton
            // 
            this.reportbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportbutton.FlatAppearance.BorderSize = 0;
            this.reportbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.reportbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.reportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbutton.Location = new System.Drawing.Point(0, 222);
            this.reportbutton.Name = "reportbutton";
            this.reportbutton.Size = new System.Drawing.Size(195, 51);
            this.reportbutton.TabIndex = 5;
            this.reportbutton.Text = "Report        ";
            this.reportbutton.UseVisualStyleBackColor = true;
            this.reportbutton.Click += new System.EventHandler(this.reportbutton_Click);
            // 
            // weekbutton
            // 
            this.weekbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.weekbutton.FlatAppearance.BorderSize = 0;
            this.weekbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.weekbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.weekbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekbutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekbutton.Location = new System.Drawing.Point(0, 171);
            this.weekbutton.Name = "weekbutton";
            this.weekbutton.Size = new System.Drawing.Size(195, 51);
            this.weekbutton.TabIndex = 4;
            this.weekbutton.Text = "  Historic data";
            this.weekbutton.UseVisualStyleBackColor = true;
            this.weekbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // todaybutton
            // 
            this.todaybutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.todaybutton.FlatAppearance.BorderSize = 0;
            this.todaybutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.todaybutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.todaybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todaybutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaybutton.Location = new System.Drawing.Point(0, 120);
            this.todaybutton.Name = "todaybutton";
            this.todaybutton.Size = new System.Drawing.Size(195, 51);
            this.todaybutton.TabIndex = 3;
            this.todaybutton.Text = "Today          ";
            this.todaybutton.UseVisualStyleBackColor = true;
            this.todaybutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashbutton
            // 
            this.dashbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashbutton.FlatAppearance.BorderSize = 0;
            this.dashbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.dashbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.dashbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbutton.Location = new System.Drawing.Point(0, 69);
            this.dashbutton.Name = "dashbutton";
            this.dashbutton.Size = new System.Drawing.Size(195, 51);
            this.dashbutton.TabIndex = 2;
            this.dashbutton.Text = "Dashboard";
            this.dashbutton.UseVisualStyleBackColor = true;
            this.dashbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.Color.AliceBlue;
            this.logopanel.Controls.Add(this.iconpic);
            this.logopanel.Controls.Add(this.appname);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(195, 69);
            this.logopanel.TabIndex = 0;
            this.logopanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logopanel_Paint);
            // 
            // iconpic
            // 
            this.iconpic.Image = ((System.Drawing.Image)(resources.GetObject("iconpic.Image")));
            this.iconpic.Location = new System.Drawing.Point(12, 25);
            this.iconpic.Name = "iconpic";
            this.iconpic.Size = new System.Drawing.Size(32, 32);
            this.iconpic.TabIndex = 1;
            this.iconpic.TabStop = false;
            this.iconpic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // appname
            // 
            this.appname.AutoSize = true;
            this.appname.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appname.Location = new System.Drawing.Point(52, 25);
            this.appname.Name = "appname";
            this.appname.Size = new System.Drawing.Size(137, 30);
            this.appname.TabIndex = 0;
            this.appname.Text = "AirControll";
            this.appname.Click += new System.EventHandler(this.label1_Click);
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.LightGray;
            this.headerpanel.Controls.Add(this.minimisePic);
            this.headerpanel.Controls.Add(this.closePic);
            this.headerpanel.Controls.Add(this.openNowlabel);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(195, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(687, 69);
            this.headerpanel.TabIndex = 1;
            // 
            // minimisePic
            // 
            this.minimisePic.Image = ((System.Drawing.Image)(resources.GetObject("minimisePic.Image")));
            this.minimisePic.Location = new System.Drawing.Point(605, 23);
            this.minimisePic.Name = "minimisePic";
            this.minimisePic.Size = new System.Drawing.Size(32, 32);
            this.minimisePic.TabIndex = 2;
            this.minimisePic.TabStop = false;
            this.minimisePic.Click += new System.EventHandler(this.minimisePic_Click);
            // 
            // closePic
            // 
            this.closePic.Image = ((System.Drawing.Image)(resources.GetObject("closePic.Image")));
            this.closePic.Location = new System.Drawing.Point(643, 23);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(32, 32);
            this.closePic.TabIndex = 1;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            // 
            // openNowlabel
            // 
            this.openNowlabel.AutoSize = true;
            this.openNowlabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openNowlabel.Location = new System.Drawing.Point(24, 26);
            this.openNowlabel.Name = "openNowlabel";
            this.openNowlabel.Size = new System.Drawing.Size(143, 30);
            this.openNowlabel.TabIndex = 0;
            this.openNowlabel.Text = "Dashboard";
            this.openNowlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lastWeek1
            // 
            this.lastWeek1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lastWeek1.Location = new System.Drawing.Point(195, 69);
            this.lastWeek1.Name = "lastWeek1";
            this.lastWeek1.Size = new System.Drawing.Size(687, 439);
            this.lastWeek1.TabIndex = 4;
            // 
            // today1
            // 
            this.today1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.today1.Location = new System.Drawing.Point(195, 69);
            this.today1.Name = "today1";
            this.today1.Size = new System.Drawing.Size(687, 439);
            this.today1.TabIndex = 3;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(195, 69);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(687, 439);
            this.dashboard1.TabIndex = 2;
            // 
            // generateReport1
            // 
            this.generateReport1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.generateReport1.Location = new System.Drawing.Point(195, 69);
            this.generateReport1.Name = "generateReport1";
            this.generateReport1.Size = new System.Drawing.Size(687, 439);
            this.generateReport1.TabIndex = 5;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(882, 511);
            this.Controls.Add(this.generateReport1);
            this.Controls.Add(this.lastWeek1);
            this.Controls.Add(this.today1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidepanel.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            this.logopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconpic)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimisePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Label appname;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox iconpic;
        private System.Windows.Forms.Button dashbutton;
        private System.Windows.Forms.Button reportbutton;
        private System.Windows.Forms.Button weekbutton;
        private System.Windows.Forms.Button todaybutton;
        private System.Windows.Forms.Label openNowlabel;
        private System.Windows.Forms.PictureBox closePic;
        private System.Windows.Forms.PictureBox minimisePic;
        private dashboard dashboard1;
        private Today today1;
        private historicData lastWeek1;
        private generateReport generateReport1;
    }
}

