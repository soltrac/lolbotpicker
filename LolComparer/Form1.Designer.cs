﻿namespace LolComparer
{
    partial class Form1
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
            this.comboBoxMyADC = new System.Windows.Forms.ComboBox();
            this.comboBoxTheirADC = new System.Windows.Forms.ComboBox();
            this.comboBoxTheirSup = new System.Windows.Forms.ComboBox();
            this.labelSup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelADC = new System.Windows.Forms.Label();
            this.comboBoxMySup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMyADC
            // 
            this.comboBoxMyADC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMyADC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMyADC.FormattingEnabled = true;
            this.comboBoxMyADC.Location = new System.Drawing.Point(45, 156);
            this.comboBoxMyADC.Name = "comboBoxMyADC";
            this.comboBoxMyADC.Size = new System.Drawing.Size(228, 21);
            this.comboBoxMyADC.TabIndex = 0;
            this.comboBoxMyADC.SelectedIndexChanged += new System.EventHandler(this.comboBoxMyADC_SelectedIndexChanged);
            // 
            // comboBoxTheirADC
            // 
            this.comboBoxTheirADC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTheirADC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTheirADC.FormattingEnabled = true;
            this.comboBoxTheirADC.Location = new System.Drawing.Point(389, 156);
            this.comboBoxTheirADC.Name = "comboBoxTheirADC";
            this.comboBoxTheirADC.Size = new System.Drawing.Size(228, 21);
            this.comboBoxTheirADC.TabIndex = 1;
            this.comboBoxTheirADC.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheirADC_SelectedIndexChanged);
            // 
            // comboBoxTheirSup
            // 
            this.comboBoxTheirSup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTheirSup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTheirSup.FormattingEnabled = true;
            this.comboBoxTheirSup.Location = new System.Drawing.Point(389, 212);
            this.comboBoxTheirSup.Name = "comboBoxTheirSup";
            this.comboBoxTheirSup.Size = new System.Drawing.Size(228, 21);
            this.comboBoxTheirSup.TabIndex = 2;
            this.comboBoxTheirSup.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheirSup_SelectedIndexChanged);
            // 
            // labelSup
            // 
            this.labelSup.AutoSize = true;
            this.labelSup.Location = new System.Drawing.Point(43, 196);
            this.labelSup.Name = "labelSup";
            this.labelSup.Size = new System.Drawing.Size(61, 13);
            this.labelSup.TabIndex = 3;
            this.labelSup.Text = "My Support";
            this.labelSup.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Their ADC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Their Support";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(197, 281);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 212);
            this.listBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Election order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Only more than";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(386, 26);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "games";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "I\'m going to play as...";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Support";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(45, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "ADC";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // labelADC
            // 
            this.labelADC.AutoSize = true;
            this.labelADC.Location = new System.Drawing.Point(46, 140);
            this.labelADC.Name = "labelADC";
            this.labelADC.Size = new System.Drawing.Size(46, 13);
            this.labelADC.TabIndex = 16;
            this.labelADC.Text = "My ADC";
            // 
            // comboBoxMySup
            // 
            this.comboBoxMySup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMySup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMySup.FormattingEnabled = true;
            this.comboBoxMySup.Location = new System.Drawing.Point(45, 212);
            this.comboBoxMySup.Name = "comboBoxMySup";
            this.comboBoxMySup.Size = new System.Drawing.Size(228, 21);
            this.comboBoxMySup.TabIndex = 15;
            this.comboBoxMySup.Visible = false;
            this.comboBoxMySup.SelectedIndexChanged += new System.EventHandler(this.comboBoxMySup_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 510);
            this.Controls.Add(this.labelADC);
            this.Controls.Add(this.comboBoxMySup);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSup);
            this.Controls.Add(this.comboBoxTheirSup);
            this.Controls.Add(this.comboBoxTheirADC);
            this.Controls.Add(this.comboBoxMyADC);
            this.Name = "Form1";
            this.Text = "Bot Counter pick";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMyADC;
        private System.Windows.Forms.ComboBox comboBoxTheirADC;
        private System.Windows.Forms.ComboBox comboBoxTheirSup;
        private System.Windows.Forms.Label labelSup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label labelADC;
        private System.Windows.Forms.ComboBox comboBoxMySup;
    }
}
