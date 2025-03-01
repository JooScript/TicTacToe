namespace TicTacToe
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pb33 = new System.Windows.Forms.PictureBox();
            this.pb23 = new System.Windows.Forms.PictureBox();
            this.pb13 = new System.Windows.Forms.PictureBox();
            this.pb32 = new System.Windows.Forms.PictureBox();
            this.pb22 = new System.Windows.Forms.PictureBox();
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb31 = new System.Windows.Forms.PictureBox();
            this.pb21 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(454, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tic-Tac-Toe Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.ForeColor = System.Drawing.Color.White;
            this.lbPlayer.Location = new System.Drawing.Point(86, 272);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(170, 45);
            this.lbPlayer.TabIndex = 11;
            this.lbPlayer.Tag = "X";
            this.lbPlayer.Text = "Player 1";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Lime;
            this.lbStatus.Location = new System.Drawing.Point(32, 345);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(236, 44);
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Tag = "X";
            this.lbStatus.Text = "In Progress";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::TicTacToe.Properties.Resources.Logo;
            this.pictureBox11.Location = new System.Drawing.Point(276, 345);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(143, 141);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::TicTacToe.Properties.Resources.XOGame;
            this.pictureBox10.Location = new System.Drawing.Point(80, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(179, 160);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            // 
            // pb33
            // 
            this.pb33.BackColor = System.Drawing.Color.Black;
            this.pb33.Image = global::TicTacToe.Properties.Resources.QuestionMark;
            this.pb33.Location = new System.Drawing.Point(785, 408);
            this.pb33.Name = "pb33";
            this.pb33.Size = new System.Drawing.Size(100, 96);
            this.pb33.TabIndex = 8;
            this.pb33.TabStop = false;
            this.pb33.Tag = "0";
            this.pb33.Click += new System.EventHandler(this.pb33_Click);
            // 
            // pb23
            // 
            this.pb23.BackColor = System.Drawing.Color.Black;
            this.pb23.Image = global::TicTacToe.Properties.Resources.QuestionMark;
            this.pb23.Location = new System.Drawing.Point(785, 272);
            this.pb23.Name = "pb23";
            this.pb23.Size = new System.Drawing.Size(100, 96);
            this.pb23.TabIndex = 7;
            this.pb23.TabStop = false;
            this.pb23.Tag = "0";
            this.pb23.Click += new System.EventHandler(this.pb23_Click);
            // 
            // pb13
            // 
            this.pb13.BackColor = System.Drawing.Color.Black;
            this.pb13.Image = global::TicTacToe.Properties.Resources.QuestionMark;
            this.pb13.Location = new System.Drawing.Point(785, 136);
            this.pb13.Name = "pb13";
            this.pb13.Size = new System.Drawing.Size(100, 96);
            this.pb13.TabIndex = 6;
            this.pb13.TabStop = false;
            this.pb13.Tag = "0";
            this.pb13.Click += new System.EventHandler(this.pb13_Click);
            // 
            // pb32
            // 
            this.pb32.BackColor = System.Drawing.Color.Black;
            this.pb32.Image = global::TicTacToe.Properties.Resources.QuestionMark;
            this.pb32.Location = new System.Drawing.Point(630, 408);
            this.pb32.Name = "pb32";
            this.pb32.Size = new System.Drawing.Size(100, 96);
            this.pb32.TabIndex = 5;
            this.pb32.TabStop = false;
            this.pb32.Tag = "0";
            this.pb32.Click += new System.EventHandler(this.pb32_Click);
            // 
            // pb22
            // 
            this.pb22.BackColor = System.Drawing.Color.Black;
            this.pb22.Image = global::TicTacToe.Properties.Resources.QuestionMark;
            this.pb22.Location = new System.Drawing.Point(630, 272);
            this.pb22.Name = "pb22";
            this.pb22.Size = new System.Drawing.Size(100, 96);
            this.pb22.TabIndex = 4;
            this.pb22.TabStop = false;
            this.pb22.Tag = "0";
            this.pb22.Click += new System.EventHandler(this.pb22_Click);
            // 
            // pb12
            // 
            this.pb12.BackColor = System.Drawing.Color.Black;
            this.pb12.Image = global::TicTacToe.Properties.Resources.QuestionMark;
            this.pb12.Location = new System.Drawing.Point(630, 136);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(100, 96);
            this.pb12.TabIndex = 3;
            this.pb12.TabStop = false;
            this.pb12.Tag = "0";
            this.pb12.Click += new System.EventHandler(this.pb12_Click);
            // 
            // pb31
            // 
            this.pb31.BackColor = System.Drawing.Color.Black;
            this.pb31.Image = global::TicTacToe.Properties.Resources.QuestionMark;
            this.pb31.Location = new System.Drawing.Point(475, 408);
            this.pb31.Name = "pb31";
            this.pb31.Size = new System.Drawing.Size(100, 96);
            this.pb31.TabIndex = 2;
            this.pb31.TabStop = false;
            this.pb31.Tag = "0";
            this.pb31.Click += new System.EventHandler(this.pb31_Click);
            // 
            // pb21
            // 
            this.pb21.BackColor = System.Drawing.Color.Black;
            this.pb21.Image = global::TicTacToe.Properties.Resources.QuestionMark;
            this.pb21.Location = new System.Drawing.Point(475, 272);
            this.pb21.Name = "pb21";
            this.pb21.Size = new System.Drawing.Size(100, 96);
            this.pb21.TabIndex = 1;
            this.pb21.TabStop = false;
            this.pb21.Tag = "0";
            this.pb21.Click += new System.EventHandler(this.pb21_Click);
            // 
            // pb11
            // 
            this.pb11.BackColor = System.Drawing.Color.Black;
            this.pb11.Image = global::TicTacToe.Properties.Resources.QuestionMark;
            this.pb11.Location = new System.Drawing.Point(475, 136);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(100, 96);
            this.pb11.TabIndex = 0;
            this.pb11.TabStop = false;
            this.pb11.Tag = "0";
            this.pb11.Click += new System.EventHandler(this.pb11_Click);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnRestartGame.FlatAppearance.BorderSize = 2;
            this.btnRestartGame.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRestartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestartGame.Location = new System.Drawing.Point(40, 451);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(152, 53);
            this.btnRestartGame.TabIndex = 14;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(19, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 47);
            this.label2.TabIndex = 15;
            this.label2.Tag = "";
            this.label2.Text = "Turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(977, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb33);
            this.Controls.Add(this.pb23);
            this.Controls.Add(this.pb13);
            this.Controls.Add(this.pb32);
            this.Controls.Add(this.pb22);
            this.Controls.Add(this.pb12);
            this.Controls.Add(this.pb31);
            this.Controls.Add(this.pb21);
            this.Controls.Add(this.pb11);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb21;
        private System.Windows.Forms.PictureBox pb31;
        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb22;
        private System.Windows.Forms.PictureBox pb32;
        private System.Windows.Forms.PictureBox pb13;
        private System.Windows.Forms.PictureBox pb23;
        private System.Windows.Forms.PictureBox pb33;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label label2;
    }
}

