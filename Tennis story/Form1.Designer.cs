namespace Tennis_story
{
    partial class TennisPlayerSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TennisPlayerSim));
            this.outputLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.option1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Black;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(410, 58);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(394, 243);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "You\'re a professional tennis player and theres a tournament coming up, would you " +
    "like to enter it?\r\n";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.option2Button.BackgroundImage = global::Tennis_story.Properties.Resources.tennisball;
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option2Button.ForeColor = System.Drawing.Color.White;
            this.option2Button.Location = new System.Drawing.Point(442, 343);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(50, 50);
            this.option2Button.TabIndex = 4;
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.option3Button.BackgroundImage = global::Tennis_story.Properties.Resources.tennisball;
            this.option3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option3Button.ForeColor = System.Drawing.Color.White;
            this.option3Button.Location = new System.Drawing.Point(442, 387);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(50, 50);
            this.option3Button.TabIndex = 5;
            this.option3Button.UseVisualStyleBackColor = false;
            this.option3Button.Visible = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(403, 1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(401, 57);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Tennis Player Sim";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(509, 299);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(279, 42);
            this.option1Label.TabIndex = 8;
            this.option1Label.Text = "Yes";
            this.option1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(509, 344);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(279, 42);
            this.option2Label.TabIndex = 9;
            this.option2Label.Text = "No";
            this.option2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(509, 395);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(279, 42);
            this.option3Label.TabIndex = 10;
            this.option3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.option3Label.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Tennis_story.Properties.Resources.Calendar;
            this.pictureBox.Location = new System.Drawing.Point(3, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(394, 428);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.Black;
            this.option1Button.BackgroundImage = global::Tennis_story.Properties.Resources.tennisball;
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option1Button.ForeColor = System.Drawing.Color.White;
            this.option1Button.Location = new System.Drawing.Point(442, 295);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(50, 50);
            this.option1Button.TabIndex = 3;
            this.option1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // TennisPlayerSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TennisPlayerSim";
            this.Text = "Tennis Player Sim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
    }
}

