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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Verbindung_Suchen = new System.Windows.Forms.Button();
            this.VerbindungenAnzeigen = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StationenauswahlTab = new System.Windows.Forms.TabPage();
            this.AbfahrtsplanTab = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxAbfahrtsplan = new System.Windows.Forms.ListBox();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.Verbindung_Suchen.Location = new System.Drawing.Point(416, 128);
            this.Verbindung_Suchen.Name = "Verbindung_Suchen";
            this.Verbindung_Suchen.Size = new System.Drawing.Size(200, 56);
            this.Verbindung_Suchen.TabIndex = 9;
            this.Verbindung_Suchen.Text = "Verbindung Suchen";
            this.Verbindung_Suchen.UseVisualStyleBackColor = true;
            this.Verbindung_Suchen.Click += new System.EventHandler(this.Verbindung_Suchen_Click);
            // 
            // VerbindungenAnzeigen
            // 
            this.VerbindungenAnzeigen.FormattingEnabled = true;
            this.VerbindungenAnzeigen.ItemHeight = 16;
            this.VerbindungenAnzeigen.Location = new System.Drawing.Point(88, 200);
            this.VerbindungenAnzeigen.Name = "VerbindungenAnzeigen";
            this.VerbindungenAnzeigen.Size = new System.Drawing.Size(632, 228);
            this.VerbindungenAnzeigen.TabIndex = 10;
            this.VerbindungenAnzeigen.SelectedIndexChanged += new System.EventHandler(this.VerbindungenAnzeigen_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StationenauswahlTab);
            this.tabControl1.Controls.Add(this.AbfahrtsplanTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 528);
            this.tabControl1.TabIndex = 11;
            // 
            // StationenauswahlTab
            // 
            this.StationenauswahlTab.Controls.Add(this.VerbindungenAnzeigen);
            this.StationenauswahlTab.Controls.Add(this.dateTimePicker1);
            this.StationenauswahlTab.Controls.Add(this.Verbindung_Suchen);
            this.StationenauswahlTab.Controls.Add(this.label1);
            this.StationenauswahlTab.Controls.Add(this.label3);
            this.StationenauswahlTab.Controls.Add(this.label2);
            this.StationenauswahlTab.Controls.Add(this.comboBoxVon);
            this.StationenauswahlTab.Controls.Add(this.comboBoxNach);
            this.StationenauswahlTab.Location = new System.Drawing.Point(4, 25);
            this.StationenauswahlTab.Name = "StationenauswahlTab";
            this.StationenauswahlTab.Padding = new System.Windows.Forms.Padding(3);
            this.StationenauswahlTab.Size = new System.Drawing.Size(912, 499);
            this.StationenauswahlTab.TabIndex = 0;
            this.StationenauswahlTab.Text = "Stationenauswahl";
            this.StationenauswahlTab.UseVisualStyleBackColor = true;
            // 
            // AbfahrtsplanTab
            // 
            this.AbfahrtsplanTab.Controls.Add(this.listBoxAbfahrtsplan);
            this.AbfahrtsplanTab.Controls.Add(this.button3);
            this.AbfahrtsplanTab.Controls.Add(this.button1);
            this.AbfahrtsplanTab.Controls.Add(this.label4);
            this.AbfahrtsplanTab.Controls.Add(this.comboBox1);
            this.AbfahrtsplanTab.Location = new System.Drawing.Point(4, 25);
            this.AbfahrtsplanTab.Name = "AbfahrtsplanTab";
            this.AbfahrtsplanTab.Padding = new System.Windows.Forms.Padding(3);
            this.AbfahrtsplanTab.Size = new System.Drawing.Size(912, 499);
            this.AbfahrtsplanTab.TabIndex = 1;
            this.AbfahrtsplanTab.Text = "Abfahrtsplan";
            this.AbfahrtsplanTab.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(480, 24);
            this.comboBox1.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abfahrtsplan anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Stationsort anzeigen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBoxAbfahrtsplan
            // 
            this.listBoxAbfahrtsplan.FormattingEnabled = true;
            this.listBoxAbfahrtsplan.ItemHeight = 16;
            this.listBoxAbfahrtsplan.Location = new System.Drawing.Point(40, 160);
            this.listBoxAbfahrtsplan.Name = "listBoxAbfahrtsplan";
            this.listBoxAbfahrtsplan.Size = new System.Drawing.Size(544, 276);
            this.listBoxAbfahrtsplan.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 523);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Verbindung_Suchen;
        private System.Windows.Forms.ListBox VerbindungenAnzeigen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StationenauswahlTab;
        private System.Windows.Forms.TabPage AbfahrtsplanTab;
        private System.Windows.Forms.ListBox listBoxAbfahrtsplan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

