namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxVon = new System.Windows.Forms.ComboBox();
            this.comboBoxNach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Verbindung_Suchen = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StationenauswahlTab = new System.Windows.Forms.TabPage();
            this.listBoxVonNach = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxZeit = new System.Windows.Forms.TextBox();
            this.AbfahrtsplanTab = new System.Windows.Forms.TabPage();
            this.websiteButton = new System.Windows.Forms.Button();
            this.BTN_Email = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.listBoxAbfahrtsplan = new System.Windows.Forms.ListBox();
            this.StationsortAnzeigen = new System.Windows.Forms.Button();
            this.AbfahrtsplanAnzeigen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStation = new System.Windows.Forms.ComboBox();
            this.webBrowserGM = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.StationenauswahlTab.SuspendLayout();
            this.AbfahrtsplanTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxVon
            // 
            this.comboBoxVon.FormattingEnabled = true;
            this.comboBoxVon.Location = new System.Drawing.Point(128, 96);
            this.comboBoxVon.Name = "comboBoxVon";
            this.comboBoxVon.Size = new System.Drawing.Size(220, 24);
            this.comboBoxVon.TabIndex = 3;
            this.comboBoxVon.DropDown += new System.EventHandler(this.comboBoxVon_DropDown);
            this.comboBoxVon.SelectedIndexChanged += new System.EventHandler(this.comboBoxVon_SelectedIndexChanged);
            // 
            // comboBoxNach
            // 
            this.comboBoxNach.FormattingEnabled = true;
            this.comboBoxNach.Location = new System.Drawing.Point(392, 96);
            this.comboBoxNach.Name = "comboBoxNach";
            this.comboBoxNach.Size = new System.Drawing.Size(216, 24);
            this.comboBoxNach.TabIndex = 4;
            this.comboBoxNach.DropDown += new System.EventHandler(this.comboBoxNach_DropDown);
            this.comboBoxNach.SelectedIndexChanged += new System.EventHandler(this.comboBoxNach_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nach";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(128, 160);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(256, 22);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datum";
            // 
            // Verbindung_Suchen
            // 
            this.Verbindung_Suchen.Location = new System.Drawing.Point(616, 128);
            this.Verbindung_Suchen.Name = "Verbindung_Suchen";
            this.Verbindung_Suchen.Size = new System.Drawing.Size(192, 56);
            this.Verbindung_Suchen.TabIndex = 9;
            this.Verbindung_Suchen.Text = "Verbindung Suchen";
            this.Verbindung_Suchen.UseVisualStyleBackColor = true;
            this.Verbindung_Suchen.Click += new System.EventHandler(this.Verbindung_Suchen_Click);
            this.Verbindung_Suchen.Enter += new System.EventHandler(this.Verbindung_Suchen_Enter);
            this.Verbindung_Suchen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Verbindung_Suchen_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StationenauswahlTab);
            this.tabControl1.Controls.Add(this.AbfahrtsplanTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 536);
            this.tabControl1.TabIndex = 11;
            // 
            // StationenauswahlTab
            // 
            this.StationenauswahlTab.Controls.Add(this.listBoxVonNach);
            this.StationenauswahlTab.Controls.Add(this.label5);
            this.StationenauswahlTab.Controls.Add(this.textBoxZeit);
            this.StationenauswahlTab.Controls.Add(this.dateTimePicker);
            this.StationenauswahlTab.Controls.Add(this.Verbindung_Suchen);
            this.StationenauswahlTab.Controls.Add(this.label1);
            this.StationenauswahlTab.Controls.Add(this.label3);
            this.StationenauswahlTab.Controls.Add(this.label2);
            this.StationenauswahlTab.Controls.Add(this.comboBoxVon);
            this.StationenauswahlTab.Controls.Add(this.comboBoxNach);
            this.StationenauswahlTab.Location = new System.Drawing.Point(4, 25);
            this.StationenauswahlTab.Name = "StationenauswahlTab";
            this.StationenauswahlTab.Padding = new System.Windows.Forms.Padding(3);
            this.StationenauswahlTab.Size = new System.Drawing.Size(920, 507);
            this.StationenauswahlTab.TabIndex = 0;
            this.StationenauswahlTab.Text = "Stationenauswahl";
            this.StationenauswahlTab.UseVisualStyleBackColor = true;
            // 
            // listBoxVonNach
            // 
            this.listBoxVonNach.FormattingEnabled = true;
            this.listBoxVonNach.ItemHeight = 16;
            this.listBoxVonNach.Location = new System.Drawing.Point(128, 208);
            this.listBoxVonNach.Name = "listBoxVonNach";
            this.listBoxVonNach.Size = new System.Drawing.Size(672, 276);
            this.listBoxVonNach.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Zeit";
            // 
            // textBoxZeit
            // 
            this.textBoxZeit.Location = new System.Drawing.Point(408, 160);
            this.textBoxZeit.Name = "textBoxZeit";
            this.textBoxZeit.Size = new System.Drawing.Size(104, 22);
            this.textBoxZeit.TabIndex = 11;
            this.textBoxZeit.TextChanged += new System.EventHandler(this.textBoxZeit_TextChanged);
            // 
            // AbfahrtsplanTab
            // 
            this.AbfahrtsplanTab.Controls.Add(this.websiteButton);
            this.AbfahrtsplanTab.Controls.Add(this.BTN_Email);
            this.AbfahrtsplanTab.Controls.Add(this.txt_Email);
            this.AbfahrtsplanTab.Controls.Add(this.listBoxAbfahrtsplan);
            this.AbfahrtsplanTab.Controls.Add(this.StationsortAnzeigen);
            this.AbfahrtsplanTab.Controls.Add(this.AbfahrtsplanAnzeigen);
            this.AbfahrtsplanTab.Controls.Add(this.label4);
            this.AbfahrtsplanTab.Controls.Add(this.comboBoxStation);
            this.AbfahrtsplanTab.Location = new System.Drawing.Point(4, 25);
            this.AbfahrtsplanTab.Name = "AbfahrtsplanTab";
            this.AbfahrtsplanTab.Padding = new System.Windows.Forms.Padding(3);
            this.AbfahrtsplanTab.Size = new System.Drawing.Size(920, 507);
            this.AbfahrtsplanTab.TabIndex = 1;
            this.AbfahrtsplanTab.Text = "Abfahrtsplan";
            this.AbfahrtsplanTab.UseVisualStyleBackColor = true;
            // 
            // websiteButton
            // 
            this.websiteButton.Location = new System.Drawing.Point(712, 440);
            this.websiteButton.Name = "websiteButton";
            this.websiteButton.Size = new System.Drawing.Size(184, 48);
            this.websiteButton.TabIndex = 7;
            this.websiteButton.Text = "Unsere Website";
            this.websiteButton.UseVisualStyleBackColor = true;
            this.websiteButton.Click += new System.EventHandler(this.websiteButton_Click);
            // 
            // BTN_Email
            // 
            this.BTN_Email.Location = new System.Drawing.Point(640, 296);
            this.BTN_Email.Name = "BTN_Email";
            this.BTN_Email.Size = new System.Drawing.Size(232, 48);
            this.BTN_Email.TabIndex = 6;
            this.BTN_Email.Text = "E-Mail senden";
            this.BTN_Email.UseVisualStyleBackColor = true;
            this.BTN_Email.Click += new System.EventHandler(this.BTN_Email_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(640, 264);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(232, 22);
            this.txt_Email.TabIndex = 5;
            // 
            // listBoxAbfahrtsplan
            // 
            this.listBoxAbfahrtsplan.FormattingEnabled = true;
            this.listBoxAbfahrtsplan.ItemHeight = 16;
            this.listBoxAbfahrtsplan.Location = new System.Drawing.Point(40, 160);
            this.listBoxAbfahrtsplan.Name = "listBoxAbfahrtsplan";
            this.listBoxAbfahrtsplan.Size = new System.Drawing.Size(544, 276);
            this.listBoxAbfahrtsplan.TabIndex = 4;
            this.listBoxAbfahrtsplan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxAbfahrtsplan_KeyDown);
            // 
            // StationsortAnzeigen
            // 
            this.StationsortAnzeigen.Location = new System.Drawing.Point(584, 104);
            this.StationsortAnzeigen.Name = "StationsortAnzeigen";
            this.StationsortAnzeigen.Size = new System.Drawing.Size(208, 40);
            this.StationsortAnzeigen.TabIndex = 3;
            this.StationsortAnzeigen.Text = "Stationsort anzeigen";
            this.StationsortAnzeigen.UseVisualStyleBackColor = true;
            this.StationsortAnzeigen.Click += new System.EventHandler(this.StationsortAnzeigen_Click);
            // 
            // AbfahrtsplanAnzeigen
            // 
            this.AbfahrtsplanAnzeigen.Location = new System.Drawing.Point(584, 56);
            this.AbfahrtsplanAnzeigen.Name = "AbfahrtsplanAnzeigen";
            this.AbfahrtsplanAnzeigen.Size = new System.Drawing.Size(208, 40);
            this.AbfahrtsplanAnzeigen.TabIndex = 2;
            this.AbfahrtsplanAnzeigen.Text = "Abfahrtsplan anzeigen";
            this.AbfahrtsplanAnzeigen.UseVisualStyleBackColor = true;
            this.AbfahrtsplanAnzeigen.Click += new System.EventHandler(this.AbfahrtsplanAnzeigen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Station";
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(40, 64);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(480, 24);
            this.comboBoxStation.TabIndex = 0;
            this.comboBoxStation.DropDown += new System.EventHandler(this.comboBoxStation_DropDown);
            this.comboBoxStation.SelectedIndexChanged += new System.EventHandler(this.comboBoxStation_SelectedIndexChanged);
            // 
            // webBrowserGM
            // 
            this.webBrowserGM.Location = new System.Drawing.Point(928, 0);
            this.webBrowserGM.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGM.Name = "webBrowserGM";
            this.webBrowserGM.Size = new System.Drawing.Size(856, 800);
            this.webBrowserGM.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.Verbindung_Suchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 803);
            this.Controls.Add(this.webBrowserGM);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.StationenauswahlTab.ResumeLayout(false);
            this.StationenauswahlTab.PerformLayout();
            this.AbfahrtsplanTab.ResumeLayout(false);
            this.AbfahrtsplanTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxVon;
        private System.Windows.Forms.ComboBox comboBoxNach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Verbindung_Suchen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StationenauswahlTab;
        private System.Windows.Forms.TabPage AbfahrtsplanTab;
        private System.Windows.Forms.ListBox listBoxAbfahrtsplan;
        private System.Windows.Forms.Button StationsortAnzeigen;
        private System.Windows.Forms.Button AbfahrtsplanAnzeigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStation;
        private System.Windows.Forms.Button BTN_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button websiteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxZeit;
        private System.Windows.Forms.ListBox listBoxVonNach;
        private System.Windows.Forms.WebBrowser webBrowserGM;
    }
}

