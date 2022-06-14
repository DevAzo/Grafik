namespace Grafik
{
    partial class MainDlg
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDlg));
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnFertig = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.colHeadID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStopX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStopY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFarbe = new System.Windows.Forms.Label();
            this.cbxFarbe = new System.Windows.Forms.ComboBox();
            this.cbxStopY = new System.Windows.Forms.ComboBox();
            this.cbxStopX = new System.Windows.Forms.ComboBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStil = new System.Windows.Forms.Label();
            this.cbxStartY = new System.Windows.Forms.ComboBox();
            this.cbxStartX = new System.Windows.Forms.ComboBox();
            this.cbxStil = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.btnFertig);
            this.grpBox.Controls.Add(this.btnDelete);
            this.grpBox.Controls.Add(this.btnPrint);
            this.grpBox.Controls.Add(this.listView);
            this.grpBox.Controls.Add(this.btnShow);
            this.grpBox.Controls.Add(this.btnAdd);
            this.grpBox.Controls.Add(this.lblFarbe);
            this.grpBox.Controls.Add(this.cbxFarbe);
            this.grpBox.Controls.Add(this.cbxStopY);
            this.grpBox.Controls.Add(this.cbxStopX);
            this.grpBox.Controls.Add(this.lblStop);
            this.grpBox.Controls.Add(this.lblStart);
            this.grpBox.Controls.Add(this.lblStil);
            this.grpBox.Controls.Add(this.cbxStartY);
            this.grpBox.Controls.Add(this.cbxStartX);
            this.grpBox.Controls.Add(this.cbxStil);
            this.grpBox.Location = new System.Drawing.Point(582, 10);
            this.grpBox.Margin = new System.Windows.Forms.Padding(2);
            this.grpBox.Name = "grpBox";
            this.grpBox.Padding = new System.Windows.Forms.Padding(2);
            this.grpBox.Size = new System.Drawing.Size(440, 547);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Daten-Eingabe";
            // 
            // btnFertig
            // 
            this.btnFertig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFertig.Location = new System.Drawing.Point(350, 62);
            this.btnFertig.Margin = new System.Windows.Forms.Padding(2);
            this.btnFertig.Name = "btnFertig";
            this.btnFertig.Size = new System.Drawing.Size(64, 34);
            this.btnFertig.TabIndex = 15;
            this.btnFertig.Text = "Fertig";
            this.btnFertig.UseVisualStyleBackColor = false;
            this.btnFertig.Click += new System.EventHandler(this.btnFertig_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Location = new System.Drawing.Point(279, 62);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 34);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrint.Location = new System.Drawing.Point(196, 62);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 34);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Drucken";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadID,
            this.colStil,
            this.colStartX,
            this.colStartY,
            this.colStopX,
            this.colStopY,
            this.colColor});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Location = new System.Drawing.Point(4, 118);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(432, 424);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // colHeadID
            // 
            this.colHeadID.Text = "#";
            this.colHeadID.Width = 30;
            // 
            // colStil
            // 
            this.colStil.Text = "Stil";
            // 
            // colStartX
            // 
            this.colStartX.Text = "Start: X";
            // 
            // colStartY
            // 
            this.colStartY.Text = "Start: Y";
            // 
            // colStopX
            // 
            this.colStopX.Text = "Stop: X";
            // 
            // colStopY
            // 
            this.colStopY.Text = "Stop: Y";
            // 
            // colColor
            // 
            this.colColor.Text = "Farbe";
            this.colColor.Width = 80;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnShow.Location = new System.Drawing.Point(106, 61);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(80, 36);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Anzeigen";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(11, 62);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 37);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFarbe
            // 
            this.lblFarbe.AutoSize = true;
            this.lblFarbe.Location = new System.Drawing.Point(280, 20);
            this.lblFarbe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFarbe.Name = "lblFarbe";
            this.lblFarbe.Size = new System.Drawing.Size(34, 13);
            this.lblFarbe.TabIndex = 10;
            this.lblFarbe.Text = "Farbe";
            // 
            // cbxFarbe
            // 
            this.cbxFarbe.FormattingEnabled = true;
            this.cbxFarbe.Items.AddRange(new object[] {
            "Schwarz",
            "Rot",
            "Blau",
            "Grün"});
            this.cbxFarbe.Location = new System.Drawing.Point(279, 37);
            this.cbxFarbe.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFarbe.Name = "cbxFarbe";
            this.cbxFarbe.Size = new System.Drawing.Size(68, 21);
            this.cbxFarbe.TabIndex = 9;
            // 
            // cbxStopY
            // 
            this.cbxStopY.FormattingEnabled = true;
            this.cbxStopY.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxStopY.Location = new System.Drawing.Point(238, 37);
            this.cbxStopY.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStopY.Name = "cbxStopY";
            this.cbxStopY.Size = new System.Drawing.Size(37, 21);
            this.cbxStopY.TabIndex = 8;
            // 
            // cbxStopX
            // 
            this.cbxStopX.FormattingEnabled = true;
            this.cbxStopX.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxStopX.Location = new System.Drawing.Point(196, 37);
            this.cbxStopX.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStopX.Name = "cbxStopX";
            this.cbxStopX.Size = new System.Drawing.Size(37, 21);
            this.cbxStopX.TabIndex = 7;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(196, 20);
            this.lblStop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(50, 13);
            this.lblStop.TabIndex = 6;
            this.lblStop.Text = "Stop: x/y";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(111, 18);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(56, 13);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start: x / y";
            // 
            // lblStil
            // 
            this.lblStil.AutoSize = true;
            this.lblStil.Location = new System.Drawing.Point(14, 20);
            this.lblStil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStil.Name = "lblStil";
            this.lblStil.Size = new System.Drawing.Size(21, 13);
            this.lblStil.TabIndex = 4;
            this.lblStil.Text = "Stil";
            // 
            // cbxStartY
            // 
            this.cbxStartY.FormattingEnabled = true;
            this.cbxStartY.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxStartY.Location = new System.Drawing.Point(152, 37);
            this.cbxStartY.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStartY.Name = "cbxStartY";
            this.cbxStartY.Size = new System.Drawing.Size(37, 21);
            this.cbxStartY.TabIndex = 3;
            // 
            // cbxStartX
            // 
            this.cbxStartX.FormattingEnabled = true;
            this.cbxStartX.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxStartX.Location = new System.Drawing.Point(109, 37);
            this.cbxStartX.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStartX.Name = "cbxStartX";
            this.cbxStartX.Size = new System.Drawing.Size(37, 21);
            this.cbxStartX.TabIndex = 2;
            // 
            // cbxStil
            // 
            this.cbxStil.FormattingEnabled = true;
            this.cbxStil.Items.AddRange(new object[] {
            "Linie",
            "Striche",
            "Punkte"});
            this.cbxStil.Location = new System.Drawing.Point(11, 37);
            this.cbxStil.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStil.Name = "cbxStil";
            this.cbxStil.Size = new System.Drawing.Size(92, 21);
            this.cbxStil.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(9, 10);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(25, 13);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "Zeit";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(102, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 13);
            this.lblUserName.TabIndex = 17;
            // 
            // MainDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1064, 569);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.grpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDlg";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Schnuppi Zeichnen 1.1 (7.9.2017)";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintAll);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.ComboBox cbxStil;
        private System.Windows.Forms.ComboBox cbxStartX;
        private System.Windows.Forms.ComboBox cbxStartY;
        private System.Windows.Forms.Label lblStil;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.ComboBox cbxStopX;
        private System.Windows.Forms.ComboBox cbxStopY;
        private System.Windows.Forms.ComboBox cbxFarbe;
        private System.Windows.Forms.Label lblFarbe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader colHeadID;
        private System.Windows.Forms.ColumnHeader colStartX;
        private System.Windows.Forms.ColumnHeader colStartY;
        private System.Windows.Forms.ColumnHeader colStopX;
        private System.Windows.Forms.ColumnHeader colStopY;
        private System.Windows.Forms.ColumnHeader colStil;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFertig;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblUserName;
    }
}

