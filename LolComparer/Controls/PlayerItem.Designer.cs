namespace LolComparer.Controls
{
    partial class PlayerItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxChampions = new System.Windows.Forms.ListBox();
            this.listBoxLastGames = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLastResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(3, 11);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(64, 13);
            this.labelPlayerName.TabIndex = 0;
            this.labelPlayerName.Text = "PlayerName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Most champions used in season 7";
            // 
            // listBoxChampions
            // 
            this.listBoxChampions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxChampions.FormattingEnabled = true;
            this.listBoxChampions.Location = new System.Drawing.Point(3, 60);
            this.listBoxChampions.Name = "listBoxChampions";
            this.listBoxChampions.Size = new System.Drawing.Size(217, 108);
            this.listBoxChampions.TabIndex = 3;
            this.listBoxChampions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxChampions_DrawItem);
            // 
            // listBoxLastGames
            // 
            this.listBoxLastGames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxLastGames.FormattingEnabled = true;
            this.listBoxLastGames.Location = new System.Drawing.Point(226, 60);
            this.listBoxLastGames.Name = "listBoxLastGames";
            this.listBoxLastGames.Size = new System.Drawing.Size(217, 108);
            this.listBoxLastGames.TabIndex = 4;
            this.listBoxLastGames.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxLastGames_DrawItem);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last games";
            // 
            // labelLastResults
            // 
            this.labelLastResults.Location = new System.Drawing.Point(334, 44);
            this.labelLastResults.Name = "labelLastResults";
            this.labelLastResults.Size = new System.Drawing.Size(109, 13);
            this.labelLastResults.TabIndex = 6;
            this.labelLastResults.Text = "0V / 0L";
            this.labelLastResults.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelLastResults.Visible = false;
            // 
            // PlayerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.labelLastResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxLastGames);
            this.Controls.Add(this.listBoxChampions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlayerName);
            this.Name = "PlayerItem";
            this.Size = new System.Drawing.Size(454, 175);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxChampions;
        private System.Windows.Forms.ListBox listBoxLastGames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLastResults;
    }
}
