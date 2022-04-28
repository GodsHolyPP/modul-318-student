namespace SwissTransportGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AbfahrtstafelTab = new System.Windows.Forms.TabPage();
            this.AbfahrtstafelDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbfahrtstafelButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.AbfahrtstafelTextBox = new System.Windows.Forms.TextBox();
            this.StationSuchenTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.StationSuchenButton = new System.Windows.Forms.Button();
            this.StationSuchenTextBox = new System.Windows.Forms.TextBox();
            this.VerbindungSuchenTab = new System.Windows.Forms.TabPage();
            this.MailButton = new System.Windows.Forms.Button();
            this.DatumCheckBox = new System.Windows.Forms.CheckBox();
            this.GewählteUhrzeit = new System.Windows.Forms.DateTimePicker();
            this.EndStationComboBox = new System.Windows.Forms.ComboBox();
            this.StartStationComboBox = new System.Windows.Forms.ComboBox();
            this.VerbindungSuchenDataGridView = new System.Windows.Forms.DataGridView();
            this.StartStationDataGridViev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NachLabel = new System.Windows.Forms.Label();
            this.VonLabel = new System.Windows.Forms.Label();
            this.VerbindungSuchenButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AbfahrtstafelTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtstafelDataGridView)).BeginInit();
            this.StationSuchenTab.SuspendLayout();
            this.VerbindungSuchenTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungSuchenDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbfahrtstafelTab
            // 
            this.AbfahrtstafelTab.Controls.Add(this.AbfahrtstafelDataGridView);
            this.AbfahrtstafelTab.Controls.Add(this.AbfahrtstafelButton);
            this.AbfahrtstafelTab.Controls.Add(this.Label1);
            this.AbfahrtstafelTab.Controls.Add(this.AbfahrtstafelTextBox);
            this.AbfahrtstafelTab.Location = new System.Drawing.Point(4, 29);
            this.AbfahrtstafelTab.Name = "AbfahrtstafelTab";
            this.AbfahrtstafelTab.Padding = new System.Windows.Forms.Padding(3);
            this.AbfahrtstafelTab.Size = new System.Drawing.Size(792, 767);
            this.AbfahrtstafelTab.TabIndex = 2;
            this.AbfahrtstafelTab.Text = "Abfahrtstafel";
            this.AbfahrtstafelTab.UseVisualStyleBackColor = true;
            // 
            // AbfahrtstafelDataGridView
            // 
            this.AbfahrtstafelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbfahrtstafelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.AbfahrtstafelDataGridView.Location = new System.Drawing.Point(204, 359);
            this.AbfahrtstafelDataGridView.Name = "AbfahrtstafelDataGridView";
            this.AbfahrtstafelDataGridView.RowHeadersWidth = 51;
            this.AbfahrtstafelDataGridView.RowTemplate.Height = 29;
            this.AbfahrtstafelDataGridView.Size = new System.Drawing.Size(300, 188);
            this.AbfahrtstafelDataGridView.TabIndex = 3;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Endstation";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ankunft Uhrzeit";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // AbfahrtstafelButton
            // 
            this.AbfahrtstafelButton.Location = new System.Drawing.Point(486, 143);
            this.AbfahrtstafelButton.Name = "AbfahrtstafelButton";
            this.AbfahrtstafelButton.Size = new System.Drawing.Size(155, 29);
            this.AbfahrtstafelButton.TabIndex = 2;
            this.AbfahrtstafelButton.Text = "Abfahrtstafel";
            this.AbfahrtstafelButton.UseVisualStyleBackColor = true;
            this.AbfahrtstafelButton.Click += new System.EventHandler(this.AbfahrtstafelButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(113, 64);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(102, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "StationsName";
            // 
            // AbfahrtstafelTextBox
            // 
            this.AbfahrtstafelTextBox.Location = new System.Drawing.Point(113, 145);
            this.AbfahrtstafelTextBox.Name = "AbfahrtstafelTextBox";
            this.AbfahrtstafelTextBox.Size = new System.Drawing.Size(125, 27);
            this.AbfahrtstafelTextBox.TabIndex = 0;
            // 
            // StationSuchenTab
            // 
            this.StationSuchenTab.Controls.Add(this.label3);
            this.StationSuchenTab.Controls.Add(this.StationSuchenButton);
            this.StationSuchenTab.Controls.Add(this.StationSuchenTextBox);
            this.StationSuchenTab.Location = new System.Drawing.Point(4, 29);
            this.StationSuchenTab.Name = "StationSuchenTab";
            this.StationSuchenTab.Padding = new System.Windows.Forms.Padding(3);
            this.StationSuchenTab.Size = new System.Drawing.Size(792, 767);
            this.StationSuchenTab.TabIndex = 1;
            this.StationSuchenTab.Text = "Station Suchen";
            this.StationSuchenTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Station Suchen";
            // 
            // StationSuchenButton
            // 
            this.StationSuchenButton.Location = new System.Drawing.Point(486, 113);
            this.StationSuchenButton.Name = "StationSuchenButton";
            this.StationSuchenButton.Size = new System.Drawing.Size(178, 29);
            this.StationSuchenButton.TabIndex = 1;
            this.StationSuchenButton.Text = "Station Suchen";
            this.StationSuchenButton.UseVisualStyleBackColor = true;
            this.StationSuchenButton.Click += new System.EventHandler(this.StationSuchenButton_Click);
            // 
            // StationSuchenTextBox
            // 
            this.StationSuchenTextBox.Location = new System.Drawing.Point(128, 115);
            this.StationSuchenTextBox.Name = "StationSuchenTextBox";
            this.StationSuchenTextBox.Size = new System.Drawing.Size(125, 27);
            this.StationSuchenTextBox.TabIndex = 0;
            // 
            // VerbindungSuchenTab
            // 
            this.VerbindungSuchenTab.Controls.Add(this.MailButton);
            this.VerbindungSuchenTab.Controls.Add(this.DatumCheckBox);
            this.VerbindungSuchenTab.Controls.Add(this.GewählteUhrzeit);
            this.VerbindungSuchenTab.Controls.Add(this.EndStationComboBox);
            this.VerbindungSuchenTab.Controls.Add(this.StartStationComboBox);
            this.VerbindungSuchenTab.Controls.Add(this.VerbindungSuchenDataGridView);
            this.VerbindungSuchenTab.Controls.Add(this.NachLabel);
            this.VerbindungSuchenTab.Controls.Add(this.VonLabel);
            this.VerbindungSuchenTab.Controls.Add(this.VerbindungSuchenButton);
            this.VerbindungSuchenTab.Location = new System.Drawing.Point(4, 29);
            this.VerbindungSuchenTab.Name = "VerbindungSuchenTab";
            this.VerbindungSuchenTab.Padding = new System.Windows.Forms.Padding(3);
            this.VerbindungSuchenTab.Size = new System.Drawing.Size(792, 767);
            this.VerbindungSuchenTab.TabIndex = 0;
            this.VerbindungSuchenTab.Text = "Verbindung Suchen";
            this.VerbindungSuchenTab.UseVisualStyleBackColor = true;
            this.VerbindungSuchenTab.Click += new System.EventHandler(this.VerbindungSuchenTab_Click);
            // 
            // MailButton
            // 
            this.MailButton.Location = new System.Drawing.Point(575, 37);
            this.MailButton.Name = "MailButton";
            this.MailButton.Size = new System.Drawing.Size(94, 29);
            this.MailButton.TabIndex = 10;
            this.MailButton.Text = "Mail Schicken";
            this.MailButton.UseVisualStyleBackColor = true;
            this.MailButton.Click += new System.EventHandler(this.MailButton_Click);
            // 
            // DatumCheckBox
            // 
            this.DatumCheckBox.AutoSize = true;
            this.DatumCheckBox.Location = new System.Drawing.Point(568, 269);
            this.DatumCheckBox.Name = "DatumCheckBox";
            this.DatumCheckBox.Size = new System.Drawing.Size(101, 24);
            this.DatumCheckBox.TabIndex = 9;
            this.DatumCheckBox.Text = "checkBox1";
            this.DatumCheckBox.UseVisualStyleBackColor = true;
            this.DatumCheckBox.CheckedChanged += new System.EventHandler(this.DatumCheckBox_CheckedChanged);
            // 
            // GewählteUhrzeit
            // 
            this.GewählteUhrzeit.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.GewählteUhrzeit.Location = new System.Drawing.Point(31, 269);
            this.GewählteUhrzeit.Name = "GewählteUhrzeit";
            this.GewählteUhrzeit.Size = new System.Drawing.Size(250, 27);
            this.GewählteUhrzeit.TabIndex = 8;
            // 
            // EndStationComboBox
            // 
            this.EndStationComboBox.FormattingEnabled = true;
            this.EndStationComboBox.Location = new System.Drawing.Point(287, 134);
            this.EndStationComboBox.Name = "EndStationComboBox";
            this.EndStationComboBox.Size = new System.Drawing.Size(151, 28);
            this.EndStationComboBox.TabIndex = 7;
            this.EndStationComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EndStationComboBox_KeyUp);
            // 
            // StartStationComboBox
            // 
            this.StartStationComboBox.FormattingEnabled = true;
            this.StartStationComboBox.Location = new System.Drawing.Point(31, 134);
            this.StartStationComboBox.Name = "StartStationComboBox";
            this.StartStationComboBox.Size = new System.Drawing.Size(151, 28);
            this.StartStationComboBox.TabIndex = 6;
            this.StartStationComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartStationComboBox_KeyUp);
            // 
            // VerbindungSuchenDataGridView
            // 
            this.VerbindungSuchenDataGridView.AllowUserToAddRows = false;
            this.VerbindungSuchenDataGridView.AllowUserToDeleteRows = false;
            this.VerbindungSuchenDataGridView.AllowUserToResizeColumns = false;
            this.VerbindungSuchenDataGridView.AllowUserToResizeRows = false;
            this.VerbindungSuchenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerbindungSuchenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartStationDataGridViev,
            this.EndStation,
            this.Column1,
            this.Column2,
            this.Column3});
            this.VerbindungSuchenDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VerbindungSuchenDataGridView.Location = new System.Drawing.Point(3, 352);
            this.VerbindungSuchenDataGridView.Name = "VerbindungSuchenDataGridView";
            this.VerbindungSuchenDataGridView.RowHeadersVisible = false;
            this.VerbindungSuchenDataGridView.RowHeadersWidth = 51;
            this.VerbindungSuchenDataGridView.RowTemplate.Height = 29;
            this.VerbindungSuchenDataGridView.Size = new System.Drawing.Size(786, 412);
            this.VerbindungSuchenDataGridView.TabIndex = 5;
            this.VerbindungSuchenDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerbindungSuchenDataGridView_CellContentClick);
            // 
            // StartStationDataGridViev
            // 
            this.StartStationDataGridViev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartStationDataGridViev.HeaderText = "Startstation";
            this.StartStationDataGridViev.MinimumWidth = 6;
            this.StartStationDataGridViev.Name = "StartStationDataGridViev";
            // 
            // EndStation
            // 
            this.EndStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndStation.HeaderText = "Endstation";
            this.EndStation.MinimumWidth = 6;
            this.EndStation.Name = "EndStation";
            this.EndStation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Abreise Uhrzeit";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Ankufts Uhrzeit";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Gleis / Borderkante";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // NachLabel
            // 
            this.NachLabel.AutoSize = true;
            this.NachLabel.Location = new System.Drawing.Point(332, 62);
            this.NachLabel.Name = "NachLabel";
            this.NachLabel.Size = new System.Drawing.Size(43, 20);
            this.NachLabel.TabIndex = 4;
            this.NachLabel.Text = "Nach";
            // 
            // VonLabel
            // 
            this.VonLabel.AutoSize = true;
            this.VonLabel.Location = new System.Drawing.Point(87, 66);
            this.VonLabel.Name = "VonLabel";
            this.VonLabel.Size = new System.Drawing.Size(34, 20);
            this.VonLabel.TabIndex = 3;
            this.VonLabel.Text = "Von";
            // 
            // VerbindungSuchenButton
            // 
            this.VerbindungSuchenButton.Location = new System.Drawing.Point(575, 133);
            this.VerbindungSuchenButton.Name = "VerbindungSuchenButton";
            this.VerbindungSuchenButton.Size = new System.Drawing.Size(158, 29);
            this.VerbindungSuchenButton.TabIndex = 2;
            this.VerbindungSuchenButton.Text = "Verbindung Suchen ";
            this.VerbindungSuchenButton.UseVisualStyleBackColor = true;
            this.VerbindungSuchenButton.Click += new System.EventHandler(this.VerbindungSuchenButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.VerbindungSuchenTab);
            this.tabControl1.Controls.Add(this.StationSuchenTab);
            this.tabControl1.Controls.Add(this.AbfahrtstafelTab);
            this.tabControl1.Location = new System.Drawing.Point(75, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 800);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AbfahrtstafelTab.ResumeLayout(false);
            this.AbfahrtstafelTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtstafelDataGridView)).EndInit();
            this.StationSuchenTab.ResumeLayout(false);
            this.StationSuchenTab.PerformLayout();
            this.VerbindungSuchenTab.ResumeLayout(false);
            this.VerbindungSuchenTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungSuchenDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage AbfahrtstafelTab;
        private DataGridView AbfahrtstafelDataGridView;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button AbfahrtstafelButton;
        private Label Label1;
        private TextBox AbfahrtstafelTextBox;
        private TabPage StationSuchenTab;
        private Label label3;
        private Button StationSuchenButton;
        private TextBox StationSuchenTextBox;
        private TabPage VerbindungSuchenTab;
        private CheckBox DatumCheckBox;
        private DateTimePicker GewählteUhrzeit;
        private ComboBox EndStationComboBox;
        private ComboBox StartStationComboBox;
        private DataGridView VerbindungSuchenDataGridView;
        private DataGridViewTextBoxColumn StartStationDataGridViev;
        private DataGridViewTextBoxColumn EndStation;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label NachLabel;
        private Label VonLabel;
        private Button VerbindungSuchenButton;
        private TabControl tabControl1;
        private Button MailButton;
    }
}