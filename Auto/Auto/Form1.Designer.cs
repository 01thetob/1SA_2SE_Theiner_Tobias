namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Marke = new System.Windows.Forms.TextBox();
            this.PS = new System.Windows.Forms.TextBox();
            this.Tankgroeße = new System.Windows.Forms.TextBox();
            this.Verbrauch = new System.Windows.Forms.TextBox();
            this.Farbe = new System.Windows.Forms.ComboBox();
            this.Erstellen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Informationen = new System.Windows.Forms.TextBox();
            this.Tanken = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neues Auto erstellen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marke:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Farbe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ps:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Verbrauch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tankgröße:";
            // 
            // Marke
            // 
            this.Marke.Location = new System.Drawing.Point(58, 50);
            this.Marke.Name = "Marke";
            this.Marke.Size = new System.Drawing.Size(100, 20);
            this.Marke.TabIndex = 6;
            this.Marke.Text = "Porsche";
            // 
            // PS
            // 
            this.PS.Location = new System.Drawing.Point(58, 102);
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(100, 20);
            this.PS.TabIndex = 7;
            this.PS.Text = "25";
            // 
            // Tankgroeße
            // 
            this.Tankgroeße.Location = new System.Drawing.Point(254, 50);
            this.Tankgroeße.Name = "Tankgroeße";
            this.Tankgroeße.Size = new System.Drawing.Size(100, 20);
            this.Tankgroeße.TabIndex = 8;
            this.Tankgroeße.Text = "40";
            // 
            // Verbrauch
            // 
            this.Verbrauch.Location = new System.Drawing.Point(254, 76);
            this.Verbrauch.Name = "Verbrauch";
            this.Verbrauch.Size = new System.Drawing.Size(100, 20);
            this.Verbrauch.TabIndex = 9;
            this.Verbrauch.Text = "7";
            // 
            // Farbe
            // 
            this.Farbe.FormattingEnabled = true;
            this.Farbe.Items.AddRange(new object[] {
            "schwarz",
            "grau",
            "blau",
            "rot",
            "weiß"});
            this.Farbe.Location = new System.Drawing.Point(58, 75);
            this.Farbe.Name = "Farbe";
            this.Farbe.Size = new System.Drawing.Size(100, 21);
            this.Farbe.TabIndex = 10;
            this.Farbe.Text = "rot";
            // 
            // Erstellen
            // 
            this.Erstellen.Location = new System.Drawing.Point(245, 125);
            this.Erstellen.Name = "Erstellen";
            this.Erstellen.Size = new System.Drawing.Size(109, 23);
            this.Erstellen.TabIndex = 11;
            this.Erstellen.Text = "Auto erstellen";
            this.Erstellen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Informationen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fahren";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tanken";
            // 
            // Informationen
            // 
            this.Informationen.Location = new System.Drawing.Point(222, 232);
            this.Informationen.Multiline = true;
            this.Informationen.Name = "Informationen";
            this.Informationen.Size = new System.Drawing.Size(184, 158);
            this.Informationen.TabIndex = 15;
            // 
            // Tanken
            // 
            this.Tanken.Location = new System.Drawing.Point(30, 232);
            this.Tanken.Name = "Tanken";
            this.Tanken.Size = new System.Drawing.Size(87, 20);
            this.Tanken.TabIndex = 16;
            this.Tanken.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 436);
            this.Controls.Add(this.Tanken);
            this.Controls.Add(this.Informationen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Erstellen);
            this.Controls.Add(this.Farbe);
            this.Controls.Add(this.Verbrauch);
            this.Controls.Add(this.Tankgroeße);
            this.Controls.Add(this.PS);
            this.Controls.Add(this.Marke);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Marke;
        private System.Windows.Forms.TextBox PS;
        private System.Windows.Forms.TextBox Tankgroeße;
        private System.Windows.Forms.TextBox Verbrauch;
        private System.Windows.Forms.ComboBox Farbe;
        private System.Windows.Forms.Button Erstellen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Informationen;
        private System.Windows.Forms.TextBox Tanken;
    }
}

