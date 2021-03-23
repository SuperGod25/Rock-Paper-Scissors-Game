
namespace RockPaperScissors
{
    partial class Joc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Joc));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.player_pictureBox = new System.Windows.Forms.PictureBox();
            this.computer_pictureBox = new System.Windows.Forms.PictureBox();
            this.playerScore_lbl = new System.Windows.Forms.Label();
            this.computerScore_lbl = new System.Windows.Forms.Label();
            this.playerName_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(510, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 158);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1017, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 158);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::RockPaperScissors.Properties.Resources.scissors;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(777, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 158);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // player_pictureBox
            // 
            this.player_pictureBox.Image = global::RockPaperScissors.Properties.Resources.intrebare;
            this.player_pictureBox.Location = new System.Drawing.Point(522, 383);
            this.player_pictureBox.Name = "player_pictureBox";
            this.player_pictureBox.Size = new System.Drawing.Size(233, 150);
            this.player_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_pictureBox.TabIndex = 3;
            this.player_pictureBox.TabStop = false;
            this.player_pictureBox.Click += new System.EventHandler(this.player_pictureBox_Click);
            // 
            // computer_pictureBox
            // 
            this.computer_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("computer_pictureBox.Image")));
            this.computer_pictureBox.Location = new System.Drawing.Point(1022, 383);
            this.computer_pictureBox.Name = "computer_pictureBox";
            this.computer_pictureBox.Size = new System.Drawing.Size(225, 150);
            this.computer_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computer_pictureBox.TabIndex = 4;
            this.computer_pictureBox.TabStop = false;
            this.computer_pictureBox.Click += new System.EventHandler(this.computer_pictureBox_Click);
            // 
            // playerScore_lbl
            // 
            this.playerScore_lbl.AutoSize = true;
            this.playerScore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore_lbl.Location = new System.Drawing.Point(610, 337);
            this.playerScore_lbl.Name = "playerScore_lbl";
            this.playerScore_lbl.Size = new System.Drawing.Size(30, 31);
            this.playerScore_lbl.TabIndex = 5;
            this.playerScore_lbl.Text = "0";
            this.playerScore_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // computerScore_lbl
            // 
            this.computerScore_lbl.AutoSize = true;
            this.computerScore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerScore_lbl.Location = new System.Drawing.Point(1121, 337);
            this.computerScore_lbl.Name = "computerScore_lbl";
            this.computerScore_lbl.Size = new System.Drawing.Size(30, 31);
            this.computerScore_lbl.TabIndex = 6;
            this.computerScore_lbl.Text = "0";
            this.computerScore_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // playerName_lbl
            // 
            this.playerName_lbl.AutoSize = true;
            this.playerName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName_lbl.Location = new System.Drawing.Point(583, 555);
            this.playerName_lbl.Name = "playerName_lbl";
            this.playerName_lbl.Size = new System.Drawing.Size(92, 31);
            this.playerName_lbl.TabIndex = 7;
            this.playerName_lbl.Text = "label3";
            this.playerName_lbl.Click += new System.EventHandler(this.playerName_lbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1077, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "computer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(867, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "6";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(73, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(267, 106);
            this.button4.TabIndex = 10;
            this.button4.Text = "Reguli";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(73, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(267, 94);
            this.button5.TabIndex = 11;
            this.button5.Text = "Meniu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Piatra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(835, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Foarfeca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1100, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hartie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(679, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Timp de alegere: ";
            // 
            // Joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1259, 655);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playerName_lbl);
            this.Controls.Add(this.computerScore_lbl);
            this.Controls.Add(this.playerScore_lbl);
            this.Controls.Add(this.computer_pictureBox);
            this.Controls.Add(this.player_pictureBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Joc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joc";
            this.Load += new System.EventHandler(this.Joc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox player_pictureBox;
        private System.Windows.Forms.PictureBox computer_pictureBox;
        private System.Windows.Forms.Label playerScore_lbl;
        private System.Windows.Forms.Label computerScore_lbl;
        private System.Windows.Forms.Label playerName_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}