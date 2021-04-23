
namespace PlayGameProject
{
    partial class PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.StartButton = new System.Windows.Forms.Button();
            this.countdown3 = new System.Windows.Forms.Label();
            this.countdown1 = new System.Windows.Forms.Label();
            this.countdown2 = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartButton.Font = new System.Drawing.Font("Vineta BT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.LightGray;
            this.StartButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartButton.Location = new System.Drawing.Point(155, 73);
            this.StartButton.Margin = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(264, 84);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Play Game";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // countdown3
            // 
            this.countdown3.AutoSize = true;
            this.countdown3.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown3.ForeColor = System.Drawing.Color.Silver;
            this.countdown3.Location = new System.Drawing.Point(158, 193);
            this.countdown3.Name = "countdown3";
            this.countdown3.Size = new System.Drawing.Size(261, 25);
            this.countdown3.TabIndex = 1;
            this.countdown3.Text = "Game Starting in . . . 3";
            // 
            // countdown1
            // 
            this.countdown1.AutoSize = true;
            this.countdown1.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown1.ForeColor = System.Drawing.Color.Silver;
            this.countdown1.Location = new System.Drawing.Point(158, 270);
            this.countdown1.Name = "countdown1";
            this.countdown1.Size = new System.Drawing.Size(256, 25);
            this.countdown1.TabIndex = 2;
            this.countdown1.Text = "Game Starting in . . . 1";
            // 
            // countdown2
            // 
            this.countdown2.AutoSize = true;
            this.countdown2.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown2.ForeColor = System.Drawing.Color.Silver;
            this.countdown2.Location = new System.Drawing.Point(158, 232);
            this.countdown2.Name = "countdown2";
            this.countdown2.Size = new System.Drawing.Size(262, 25);
            this.countdown2.TabIndex = 3;
            this.countdown2.Text = "Game Starting in . . . 2";
            // 
            // go
            // 
            this.go.AutoSize = true;
            this.go.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.ForeColor = System.Drawing.SystemColors.Window;
            this.go.Location = new System.Drawing.Point(261, 161);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(64, 32);
            this.go.TabIndex = 4;
            this.go.Text = "Go!";
            // 
            // PlayGame
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.go);
            this.Controls.Add(this.countdown2);
            this.Controls.Add(this.countdown1);
            this.Controls.Add(this.countdown3);
            this.Controls.Add(this.StartButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Vineta BT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.Name = "PlayGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label countdown3;
        private System.Windows.Forms.Label countdown1;
        private System.Windows.Forms.Label countdown2;
        private System.Windows.Forms.Label go;
    }
}

