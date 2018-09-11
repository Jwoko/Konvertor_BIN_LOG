namespace Konvertor_BIN_LOG
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_analyzuj = new System.Windows.Forms.Button();
            this.tbx_cesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label(); 
            this.label6 = new System.Windows.Forms.Label();
            this.tlac_preklad = new System.Windows.Forms.Button();
            this.checkBoxP = new System.Windows.Forms.CheckBox();
            this.checkBoxL = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxS = new System.Windows.Forms.CheckBox();
            this.checkBoxF = new System.Windows.Forms.CheckBox();
            this.tbx_cestavystup = new System.Windows.Forms.TextBox();
            this.tlac_otevrislozku = new System.Windows.Forms.Button();
            this.tlac_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_analyzuj
            // 
            this.but_analyzuj.Location = new System.Drawing.Point(12, 48);
            this.but_analyzuj.Name = "but_analyzuj";
            this.but_analyzuj.Size = new System.Drawing.Size(360, 38);
            this.but_analyzuj.TabIndex = 0;
            this.but_analyzuj.Text = "Analýza";
            this.but_analyzuj.UseVisualStyleBackColor = true;
            this.but_analyzuj.Click += new System.EventHandler(this.but_analyzuj_Click);
            // 
            // tbx_cesta
            // 
            this.tbx_cesta.Location = new System.Drawing.Point(12, 22);
            this.tbx_cesta.Name = "tbx_cesta";
            this.tbx_cesta.ReadOnly = true;
            this.tbx_cesta.Size = new System.Drawing.Size(361, 20);
            this.tbx_cesta.TabIndex = 1;
            this.tbx_cesta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // tlac_preklad
            // 
            this.tlac_preklad.Enabled = false;
            this.tlac_preklad.Location = new System.Drawing.Point(11, 269);
            this.tlac_preklad.Name = "tlac_preklad";
            this.tlac_preklad.Size = new System.Drawing.Size(361, 51);
            this.tlac_preklad.TabIndex = 9;
            this.tlac_preklad.Text = "Překlad";
            this.tlac_preklad.UseVisualStyleBackColor = true;
            this.tlac_preklad.Visible = false;
            this.tlac_preklad.Click += new System.EventHandler(this.tlac_preklad_Click);
            // 
            // checkBoxP
            // 
            this.checkBoxP.AutoSize = true;
            this.checkBoxP.Location = new System.Drawing.Point(12, 112);
            this.checkBoxP.Name = "checkBoxP";
            this.checkBoxP.Size = new System.Drawing.Size(33, 17);
            this.checkBoxP.TabIndex = 10;
            this.checkBoxP.Text = "P";
            this.checkBoxP.UseVisualStyleBackColor = true;
            this.checkBoxP.Visible = false;
            this.checkBoxP.CheckedChanged += new System.EventHandler(this.checkBoxP_CheckedChanged);
            // 
            // checkBoxL
            // 
            this.checkBoxL.AutoSize = true;
            this.checkBoxL.Location = new System.Drawing.Point(12, 205);
            this.checkBoxL.Name = "checkBoxL";
            this.checkBoxL.Size = new System.Drawing.Size(32, 17);
            this.checkBoxL.TabIndex = 11;
            this.checkBoxL.Text = "L";
            this.checkBoxL.UseVisualStyleBackColor = true;
            this.checkBoxL.Visible = false;
            this.checkBoxL.CheckedChanged += new System.EventHandler(this.checkBoxP_CheckedChanged);
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(12, 136);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(33, 17);
            this.checkBoxA.TabIndex = 12;
            this.checkBoxA.Text = "A";
            this.checkBoxA.UseVisualStyleBackColor = true;
            this.checkBoxA.Visible = false;
            this.checkBoxA.CheckedChanged += new System.EventHandler(this.checkBoxP_CheckedChanged);
            // 
            // checkBoxS
            // 
            this.checkBoxS.AutoSize = true;
            this.checkBoxS.Location = new System.Drawing.Point(12, 159);
            this.checkBoxS.Name = "checkBoxS";
            this.checkBoxS.Size = new System.Drawing.Size(33, 17);
            this.checkBoxS.TabIndex = 13;
            this.checkBoxS.Text = "S";
            this.checkBoxS.UseVisualStyleBackColor = true;
            this.checkBoxS.Visible = false;
            this.checkBoxS.CheckedChanged += new System.EventHandler(this.checkBoxP_CheckedChanged);
            // 
            // checkBoxF
            // 
            this.checkBoxF.AutoSize = true;
            this.checkBoxF.Location = new System.Drawing.Point(12, 182);
            this.checkBoxF.Name = "checkBoxF";
            this.checkBoxF.Size = new System.Drawing.Size(32, 17);
            this.checkBoxF.TabIndex = 14;
            this.checkBoxF.Text = "F";
            this.checkBoxF.UseVisualStyleBackColor = true;
            this.checkBoxF.Visible = false;
            this.checkBoxF.CheckedChanged += new System.EventHandler(this.checkBoxP_CheckedChanged);
            // 
            // tbx_cestavystup
            // 
            this.tbx_cestavystup.Location = new System.Drawing.Point(12, 243);
            this.tbx_cestavystup.Name = "tbx_cestavystup";
            this.tbx_cestavystup.ReadOnly = true;
            this.tbx_cestavystup.Size = new System.Drawing.Size(361, 20);
            this.tbx_cestavystup.TabIndex = 16;
            this.tbx_cestavystup.Visible = false;
            this.tbx_cestavystup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbx_cestavystup_MouseDown);
            // 
            // tlac_otevrislozku
            // 
            this.tlac_otevrislozku.Enabled = false;
            this.tlac_otevrislozku.Location = new System.Drawing.Point(12, 337);
            this.tlac_otevrislozku.Name = "tlac_otevrislozku";
            this.tlac_otevrislozku.Size = new System.Drawing.Size(361, 51);
            this.tlac_otevrislozku.TabIndex = 17;
            this.tlac_otevrislozku.Text = "Otevřít složku s výstupem";
            this.tlac_otevrislozku.UseVisualStyleBackColor = true;
            this.tlac_otevrislozku.Visible = false;
            this.tlac_otevrislozku.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlac_stop
            // 
            this.tlac_stop.Enabled = false;
            this.tlac_stop.Location = new System.Drawing.Point(12, 269);
            this.tlac_stop.Name = "tlac_stop";
            this.tlac_stop.Size = new System.Drawing.Size(361, 51);
            this.tlac_stop.TabIndex = 18;
            this.tlac_stop.Text = "Stop";
            this.tlac_stop.UseVisualStyleBackColor = true;
            this.tlac_stop.Visible = false;
            this.tlac_stop.Click += new System.EventHandler(this.tlac_Estop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 414);
            this.Controls.Add(this.tlac_stop);
            this.Controls.Add(this.tlac_otevrislozku);
            this.Controls.Add(this.tbx_cestavystup);
            this.Controls.Add(this.checkBoxF);
            this.Controls.Add(this.checkBoxS);
            this.Controls.Add(this.checkBoxA);
            this.Controls.Add(this.checkBoxL);
            this.Controls.Add(this.checkBoxP);
            this.Controls.Add(this.tlac_preklad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_cesta);
            this.Controls.Add(this.but_analyzuj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_analyzuj;
        private System.Windows.Forms.TextBox tbx_cesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tlac_preklad;
        private System.Windows.Forms.CheckBox checkBoxP;
        private System.Windows.Forms.CheckBox checkBoxL;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxS;
        private System.Windows.Forms.CheckBox checkBoxF;
        private System.Windows.Forms.TextBox tbx_cestavystup;
        private System.Windows.Forms.Button tlac_otevrislozku;
        private System.Windows.Forms.Button tlac_stop;
    }
}

