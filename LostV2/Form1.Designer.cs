﻿namespace LostV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.redImage = new System.Windows.Forms.PictureBox();
            this.greenImage = new System.Windows.Forms.PictureBox();
            this.greenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(24, 28);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(391, 256);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "label1";
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Transparent;
            this.redLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(67, 313);
            this.redLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(257, 23);
            this.redLabel.TabIndex = 3;
            this.redLabel.Text = "label1";
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Transparent;
            this.blueLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(67, 349);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(257, 23);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Text = "label1";
            // 
            // blueImage
            // 
            this.blueImage.BackColor = System.Drawing.Color.Transparent;
            this.blueImage.Image = global::LostV2.Properties.Resources.blue_50x50;
            this.blueImage.Location = new System.Drawing.Point(24, 339);
            this.blueImage.Margin = new System.Windows.Forms.Padding(2);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(39, 32);
            this.blueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueImage.TabIndex = 1;
            this.blueImage.TabStop = false;
            // 
            // redImage
            // 
            this.redImage.BackColor = System.Drawing.Color.Transparent;
            this.redImage.Image = global::LostV2.Properties.Resources.red_50x50;
            this.redImage.Location = new System.Drawing.Point(24, 303);
            this.redImage.Margin = new System.Windows.Forms.Padding(2);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(39, 32);
            this.redImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redImage.TabIndex = 0;
            this.redImage.TabStop = false;
            // 
            // greenImage
            // 
            this.greenImage.BackColor = System.Drawing.Color.Transparent;
            this.greenImage.BackgroundImage = global::LostV2.Properties.Resources.green_50x50;
            this.greenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.greenImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.greenImage.InitialImage = null;
            this.greenImage.Location = new System.Drawing.Point(24, 377);
            this.greenImage.Margin = new System.Windows.Forms.Padding(2);
            this.greenImage.Name = "greenImage";
            this.greenImage.Size = new System.Drawing.Size(39, 32);
            this.greenImage.TabIndex = 5;
            this.greenImage.TabStop = false;
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.BackColor = System.Drawing.Color.Transparent;
            this.greenLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLabel.ForeColor = System.Drawing.Color.White;
            this.greenLabel.Location = new System.Drawing.Point(68, 386);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(0, 18);
            this.greenLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 422);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.greenImage);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.redImage);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adventure Island";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redImage;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.PictureBox greenImage;
        private System.Windows.Forms.Label greenLabel;
    }
}

