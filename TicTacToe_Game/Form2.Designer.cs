namespace TicTacToe_Game
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerOneTB = new System.Windows.Forms.TextBox();
            this.playerTwoTB = new System.Windows.Forms.TextBox();
            this.play_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player One Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Two Name";
            // 
            // playerOneTB
            // 
            this.playerOneTB.Location = new System.Drawing.Point(114, 12);
            this.playerOneTB.Name = "playerOneTB";
            this.playerOneTB.Size = new System.Drawing.Size(175, 20);
            this.playerOneTB.TabIndex = 2;
            // 
            // playerTwoTB
            // 
            this.playerTwoTB.Location = new System.Drawing.Point(114, 38);
            this.playerTwoTB.Name = "playerTwoTB";
            this.playerTwoTB.Size = new System.Drawing.Size(175, 20);
            this.playerTwoTB.TabIndex = 3;
            // 
            // play_button
            // 
            this.play_button.Location = new System.Drawing.Point(214, 64);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(75, 23);
            this.play_button.TabIndex = 4;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 97);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.playerTwoTB);
            this.Controls.Add(this.playerOneTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerOneTB;
        private System.Windows.Forms.TextBox playerTwoTB;
        private System.Windows.Forms.Button play_button;
    }
}