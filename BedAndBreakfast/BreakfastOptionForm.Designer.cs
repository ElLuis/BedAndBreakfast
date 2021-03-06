﻿namespace BedAndBreakfast
{
    partial class BreakfastOptionForm
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
            this.optionsCaptionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.contBreakfastButton = new System.Windows.Forms.RadioButton();
            this.fullBreakfastButton = new System.Windows.Forms.RadioButton();
            this.deluxeBreakfastButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // optionsCaptionLabel
            // 
            this.optionsCaptionLabel.AutoSize = true;
            this.optionsCaptionLabel.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsCaptionLabel.Location = new System.Drawing.Point(42, 28);
            this.optionsCaptionLabel.Name = "optionsCaptionLabel";
            this.optionsCaptionLabel.Size = new System.Drawing.Size(135, 17);
            this.optionsCaptionLabel.TabIndex = 0;
            this.optionsCaptionLabel.Text = "Select your breakfast";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(138, 217);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // contBreakfastButton
            // 
            this.contBreakfastButton.AutoSize = true;
            this.contBreakfastButton.Location = new System.Drawing.Point(60, 76);
            this.contBreakfastButton.Name = "contBreakfastButton";
            this.contBreakfastButton.Size = new System.Drawing.Size(78, 17);
            this.contBreakfastButton.TabIndex = 5;
            this.contBreakfastButton.TabStop = true;
            this.contBreakfastButton.Text = "Continental";
            this.contBreakfastButton.UseVisualStyleBackColor = true;
            this.contBreakfastButton.CheckedChanged += new System.EventHandler(this.contBreakfastButton_CheckedChanged);
            // 
            // fullBreakfastButton
            // 
            this.fullBreakfastButton.AutoSize = true;
            this.fullBreakfastButton.Location = new System.Drawing.Point(60, 126);
            this.fullBreakfastButton.Name = "fullBreakfastButton";
            this.fullBreakfastButton.Size = new System.Drawing.Size(41, 17);
            this.fullBreakfastButton.TabIndex = 6;
            this.fullBreakfastButton.TabStop = true;
            this.fullBreakfastButton.Text = "Full";
            this.fullBreakfastButton.UseVisualStyleBackColor = true;
            this.fullBreakfastButton.CheckedChanged += new System.EventHandler(this.fullBreakfastButton_CheckedChanged);
            // 
            // deluxeBreakfastButton
            // 
            this.deluxeBreakfastButton.AutoSize = true;
            this.deluxeBreakfastButton.Location = new System.Drawing.Point(60, 178);
            this.deluxeBreakfastButton.Name = "deluxeBreakfastButton";
            this.deluxeBreakfastButton.Size = new System.Drawing.Size(58, 17);
            this.deluxeBreakfastButton.TabIndex = 7;
            this.deluxeBreakfastButton.TabStop = true;
            this.deluxeBreakfastButton.Text = "Deluxe";
            this.deluxeBreakfastButton.UseVisualStyleBackColor = true;
            this.deluxeBreakfastButton.CheckedChanged += new System.EventHandler(this.deluxeBreakfastButton_CheckedChanged);
            // 
            // BreakfastOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.deluxeBreakfastButton);
            this.Controls.Add(this.fullBreakfastButton);
            this.Controls.Add(this.contBreakfastButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.optionsCaptionLabel);
            this.Name = "BreakfastOptionForm";
            this.Text = "BreakfastOptionForm";
            this.Load += new System.EventHandler(this.BreakfastOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsCaptionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.RadioButton contBreakfastButton;
        private System.Windows.Forms.RadioButton fullBreakfastButton;
        private System.Windows.Forms.RadioButton deluxeBreakfastButton;
    }
}