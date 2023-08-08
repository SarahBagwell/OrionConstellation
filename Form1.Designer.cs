namespace Orion_Constellation___Bagwell
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
            this.showStarNamesButton = new System.Windows.Forms.Button();
            this.hideStarNamesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.orionPictureBox = new System.Windows.Forms.PictureBox();
            this.betelgeuseLabel = new System.Windows.Forms.Label();
            this.meissaLabel = new System.Windows.Forms.Label();
            this.alnitakLabel = new System.Windows.Forms.Label();
            this.alnilamLabel = new System.Windows.Forms.Label();
            this.mintakaLabel = new System.Windows.Forms.Label();
            this.saiphLabel = new System.Windows.Forms.Label();
            this.rigelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showStarNamesButton
            // 
            this.showStarNamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStarNamesButton.Location = new System.Drawing.Point(64, 508);
            this.showStarNamesButton.Name = "showStarNamesButton";
            this.showStarNamesButton.Size = new System.Drawing.Size(97, 52);
            this.showStarNamesButton.TabIndex = 0;
            this.showStarNamesButton.Text = "Show Star Names";
            this.showStarNamesButton.UseVisualStyleBackColor = true;
            this.showStarNamesButton.Click += new System.EventHandler(this.showStarNamesButton_Click);
            // 
            // hideStarNamesButton
            // 
            this.hideStarNamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideStarNamesButton.Location = new System.Drawing.Point(189, 508);
            this.hideStarNamesButton.Name = "hideStarNamesButton";
            this.hideStarNamesButton.Size = new System.Drawing.Size(89, 52);
            this.hideStarNamesButton.TabIndex = 1;
            this.hideStarNamesButton.Text = "Hide Star Names";
            this.hideStarNamesButton.UseVisualStyleBackColor = true;
            this.hideStarNamesButton.Click += new System.EventHandler(this.hideStarNamesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(308, 508);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 52);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // orionPictureBox
            // 
            this.orionPictureBox.Image = global::Orion_Constellation___Bagwell.Properties.Resources.Orion;
            this.orionPictureBox.Location = new System.Drawing.Point(12, 12);
            this.orionPictureBox.Name = "orionPictureBox";
            this.orionPictureBox.Size = new System.Drawing.Size(444, 476);
            this.orionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orionPictureBox.TabIndex = 3;
            this.orionPictureBox.TabStop = false;
            // 
            // betelgeuseLabel
            // 
            this.betelgeuseLabel.AutoSize = true;
            this.betelgeuseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betelgeuseLabel.Location = new System.Drawing.Point(25, 37);
            this.betelgeuseLabel.Name = "betelgeuseLabel";
            this.betelgeuseLabel.Size = new System.Drawing.Size(90, 20);
            this.betelgeuseLabel.TabIndex = 4;
            this.betelgeuseLabel.Text = "Betelgeuse";
            this.betelgeuseLabel.Visible = false;
            // 
            // meissaLabel
            // 
            this.meissaLabel.AutoSize = true;
            this.meissaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meissaLabel.Location = new System.Drawing.Point(319, 70);
            this.meissaLabel.Name = "meissaLabel";
            this.meissaLabel.Size = new System.Drawing.Size(59, 20);
            this.meissaLabel.TabIndex = 5;
            this.meissaLabel.Text = "Meissa";
            this.meissaLabel.Visible = false;
            // 
            // alnitakLabel
            // 
            this.alnitakLabel.AutoSize = true;
            this.alnitakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alnitakLabel.Location = new System.Drawing.Point(85, 237);
            this.alnitakLabel.Name = "alnitakLabel";
            this.alnitakLabel.Size = new System.Drawing.Size(57, 20);
            this.alnitakLabel.TabIndex = 6;
            this.alnitakLabel.Text = "Alnitak";
            this.alnitakLabel.Visible = false;
            // 
            // alnilamLabel
            // 
            this.alnilamLabel.AutoSize = true;
            this.alnilamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alnilamLabel.Location = new System.Drawing.Point(186, 253);
            this.alnilamLabel.Name = "alnilamLabel";
            this.alnilamLabel.Size = new System.Drawing.Size(60, 20);
            this.alnilamLabel.TabIndex = 7;
            this.alnilamLabel.Text = "Alnilam";
            this.alnilamLabel.Visible = false;
            // 
            // mintakaLabel
            // 
            this.mintakaLabel.AutoSize = true;
            this.mintakaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintakaLabel.Location = new System.Drawing.Point(278, 214);
            this.mintakaLabel.Name = "mintakaLabel";
            this.mintakaLabel.Size = new System.Drawing.Size(65, 20);
            this.mintakaLabel.TabIndex = 8;
            this.mintakaLabel.Text = "Mintaka";
            this.mintakaLabel.Visible = false;
            // 
            // saiphLabel
            // 
            this.saiphLabel.AutoSize = true;
            this.saiphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saiphLabel.Location = new System.Drawing.Point(92, 413);
            this.saiphLabel.Name = "saiphLabel";
            this.saiphLabel.Size = new System.Drawing.Size(50, 20);
            this.saiphLabel.TabIndex = 9;
            this.saiphLabel.Text = "Saiph";
            this.saiphLabel.Visible = false;
            // 
            // rigelLabel
            // 
            this.rigelLabel.AutoSize = true;
            this.rigelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rigelLabel.Location = new System.Drawing.Point(309, 380);
            this.rigelLabel.Name = "rigelLabel";
            this.rigelLabel.Size = new System.Drawing.Size(45, 20);
            this.rigelLabel.TabIndex = 10;
            this.rigelLabel.Text = "Rigel";
            this.rigelLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 581);
            this.Controls.Add(this.rigelLabel);
            this.Controls.Add(this.saiphLabel);
            this.Controls.Add(this.mintakaLabel);
            this.Controls.Add(this.alnilamLabel);
            this.Controls.Add(this.alnitakLabel);
            this.Controls.Add(this.meissaLabel);
            this.Controls.Add(this.betelgeuseLabel);
            this.Controls.Add(this.orionPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hideStarNamesButton);
            this.Controls.Add(this.showStarNamesButton);
            this.Name = "Form1";
            this.Text = "Orion Constellation";
            ((System.ComponentModel.ISupportInitialize)(this.orionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showStarNamesButton;
        private System.Windows.Forms.Button hideStarNamesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox orionPictureBox;
        private System.Windows.Forms.Label betelgeuseLabel;
        private System.Windows.Forms.Label meissaLabel;
        private System.Windows.Forms.Label alnitakLabel;
        private System.Windows.Forms.Label alnilamLabel;
        private System.Windows.Forms.Label mintakaLabel;
        private System.Windows.Forms.Label saiphLabel;
        private System.Windows.Forms.Label rigelLabel;
    }
}

