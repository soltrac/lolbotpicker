namespace LolComparer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelADC = new System.Windows.Forms.Label();
            this.comboBoxMySup = new System.Windows.Forms.ComboBox();
            this.radioButtonStatRating = new System.Windows.Forms.RadioButton();
            this.radioButtonWinrate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelSup = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAnalyzeSummoners = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxSummoner = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPaste = new System.Windows.Forms.TextBox();
            this.playerItem4 = new LolComparer.Controls.PlayerItem();
            this.playerItem3 = new LolComparer.Controls.PlayerItem();
            this.playerItem2 = new LolComparer.Controls.PlayerItem();
            this.playerItem1 = new LolComparer.Controls.PlayerItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMyADC
            // 
            this.comboBoxMyADC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMyADC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMyADC.FormattingEnabled = true;
            this.comboBoxMyADC.Location = new System.Drawing.Point(42, 123);
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
            this.comboBoxTheirADC.Location = new System.Drawing.Point(386, 123);
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
            this.comboBoxTheirSup.Location = new System.Drawing.Point(386, 179);
            this.comboBoxTheirSup.Name = "comboBoxTheirSup";
            this.comboBoxTheirSup.Size = new System.Drawing.Size(228, 21);
            this.comboBoxTheirSup.TabIndex = 2;
            this.comboBoxTheirSup.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheirSup_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(194, 245);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 212);
            this.listBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Election order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Only more than";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(446, 42);
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
            this.label6.Location = new System.Drawing.Point(530, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "games";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
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
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "ADC";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // labelADC
            // 
            this.labelADC.AutoSize = true;
            this.labelADC.Location = new System.Drawing.Point(43, 107);
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
            this.comboBoxMySup.Location = new System.Drawing.Point(42, 179);
            this.comboBoxMySup.Name = "comboBoxMySup";
            this.comboBoxMySup.Size = new System.Drawing.Size(228, 21);
            this.comboBoxMySup.TabIndex = 15;
            this.comboBoxMySup.Visible = false;
            this.comboBoxMySup.SelectedIndexChanged += new System.EventHandler(this.comboBoxMySup_SelectedIndexChanged);
            // 
            // radioButtonStatRating
            // 
            this.radioButtonStatRating.AutoSize = true;
            this.radioButtonStatRating.Checked = true;
            this.radioButtonStatRating.Location = new System.Drawing.Point(7, 19);
            this.radioButtonStatRating.Name = "radioButtonStatRating";
            this.radioButtonStatRating.Size = new System.Drawing.Size(104, 17);
            this.radioButtonStatRating.TabIndex = 18;
            this.radioButtonStatRating.TabStop = true;
            this.radioButtonStatRating.Text = "Statistical Rating";
            this.radioButtonStatRating.UseVisualStyleBackColor = true;
            this.radioButtonStatRating.CheckedChanged += new System.EventHandler(this.radioButtonStatRating_CheckedChanged);
            // 
            // radioButtonWinrate
            // 
            this.radioButtonWinrate.AutoSize = true;
            this.radioButtonWinrate.Location = new System.Drawing.Point(7, 42);
            this.radioButtonWinrate.Name = "radioButtonWinrate";
            this.radioButtonWinrate.Size = new System.Drawing.Size(62, 17);
            this.radioButtonWinrate.TabIndex = 19;
            this.radioButtonWinrate.Text = "Winrate";
            this.radioButtonWinrate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 69);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "I\'m going to play as";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonStatRating);
            this.groupBox2.Controls.Add(this.radioButtonWinrate);
            this.groupBox2.Location = new System.Drawing.Point(227, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 69);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Count";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 618);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxMyADC);
            this.tabPage1.Controls.Add(this.comboBoxTheirADC);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.comboBoxTheirSup);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.labelADC);
            this.tabPage1.Controls.Add(this.comboBoxMySup);
            this.tabPage1.Controls.Add(this.labelSup);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bot picker";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelSup
            // 
            this.labelSup.AutoSize = true;
            this.labelSup.Location = new System.Drawing.Point(40, 163);
            this.labelSup.Name = "labelSup";
            this.labelSup.Size = new System.Drawing.Size(61, 13);
            this.labelSup.TabIndex = 3;
            this.labelSup.Text = "My Support";
            this.labelSup.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Their ADC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Their Support";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.playerItem4);
            this.tabPage2.Controls.Add(this.playerItem3);
            this.tabPage2.Controls.Add(this.playerItem2);
            this.tabPage2.Controls.Add(this.playerItem1);
            this.tabPage2.Controls.Add(this.buttonAnalyzeSummoners);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.textBoxSummoner);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBoxPaste);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(932, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check my team";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAnalyzeSummoners
            // 
            this.buttonAnalyzeSummoners.Location = new System.Drawing.Point(11, 191);
            this.buttonAnalyzeSummoners.Name = "buttonAnalyzeSummoners";
            this.buttonAnalyzeSummoners.Size = new System.Drawing.Size(163, 23);
            this.buttonAnalyzeSummoners.TabIndex = 4;
            this.buttonAnalyzeSummoners.Text = "Analyze Players";
            this.buttonAnalyzeSummoners.UseVisualStyleBackColor = true;
            this.buttonAnalyzeSummoners.Click += new System.EventHandler(this.buttonAnalyzeSummoners_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(8, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(641, 18);
            this.label14.TabIndex = 3;
            this.label14.Text = "Put your summoner name here so you will be filtered out (right now only EUW)";
            // 
            // textBoxSummoner
            // 
            this.textBoxSummoner.Location = new System.Drawing.Point(8, 29);
            this.textBoxSummoner.Name = "textBoxSummoner";
            this.textBoxSummoner.Size = new System.Drawing.Size(646, 20);
            this.textBoxSummoner.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(8, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(641, 32);
            this.label13.TabIndex = 1;
            this.label13.Text = "During the pre-game lobby, copy the summoner names into the input field box above" +
    " (you can leave in the \"joined the lobby\" part, then click anywhere outside of t" +
    "he box (client Spanish or English)";
            // 
            // textBoxPaste
            // 
            this.textBoxPaste.Location = new System.Drawing.Point(8, 100);
            this.textBoxPaste.Multiline = true;
            this.textBoxPaste.Name = "textBoxPaste";
            this.textBoxPaste.Size = new System.Drawing.Size(646, 84);
            this.textBoxPaste.TabIndex = 0;
            // 
            // playerItem4
            // 
            this.playerItem4.BackColor = System.Drawing.Color.Bisque;
            this.playerItem4.Location = new System.Drawing.Point(470, 404);
            this.playerItem4.Name = "playerItem4";
            this.playerItem4.Size = new System.Drawing.Size(451, 180);
            this.playerItem4.TabIndex = 8;
            this.playerItem4.Visible = false;
            // 
            // playerItem3
            // 
            this.playerItem3.BackColor = System.Drawing.Color.Bisque;
            this.playerItem3.Location = new System.Drawing.Point(11, 404);
            this.playerItem3.Name = "playerItem3";
            this.playerItem3.Size = new System.Drawing.Size(453, 180);
            this.playerItem3.TabIndex = 7;
            this.playerItem3.Visible = false;
            // 
            // playerItem2
            // 
            this.playerItem2.BackColor = System.Drawing.Color.Bisque;
            this.playerItem2.Location = new System.Drawing.Point(470, 220);
            this.playerItem2.Name = "playerItem2";
            this.playerItem2.Size = new System.Drawing.Size(451, 178);
            this.playerItem2.TabIndex = 6;
            this.playerItem2.Visible = false;
            // 
            // playerItem1
            // 
            this.playerItem1.BackColor = System.Drawing.Color.Bisque;
            this.playerItem1.Location = new System.Drawing.Point(11, 220);
            this.playerItem1.Name = "playerItem1";
            this.playerItem1.Size = new System.Drawing.Size(453, 178);
            this.playerItem1.TabIndex = 5;
            this.playerItem1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 618);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lol Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMyADC;
        private System.Windows.Forms.ComboBox comboBoxTheirADC;
        private System.Windows.Forms.ComboBox comboBoxTheirSup;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label labelADC;
        private System.Windows.Forms.ComboBox comboBoxMySup;
        private System.Windows.Forms.RadioButton radioButtonStatRating;
        private System.Windows.Forms.RadioButton radioButtonWinrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelSup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxSummoner;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPaste;
        private System.Windows.Forms.Button buttonAnalyzeSummoners;
        private Controls.PlayerItem playerItem4;
        private Controls.PlayerItem playerItem3;
        private Controls.PlayerItem playerItem2;
        private Controls.PlayerItem playerItem1;
    }
}

