namespace BedAndBreakfast
{
    partial class BaileysForm
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
            this.welcomeLabel1 = new System.Windows.Forms.Label();
            this.rateLabel1 = new System.Windows.Forms.Label();
            this.belleAireCheckBox = new System.Windows.Forms.CheckBox();
            this.lincolnCheckBox = new System.Windows.Forms.CheckBox();
            this.mealButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel1
            // 
            this.welcomeLabel1.AutoSize = true;
            this.welcomeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel1.Location = new System.Drawing.Point(20, 30);
            this.welcomeLabel1.Name = "welcomeLabel1";
            this.welcomeLabel1.Size = new System.Drawing.Size(248, 29);
            this.welcomeLabel1.TabIndex = 0;
            this.welcomeLabel1.Text = "Welcome to Bailey\'s";
            // 
            // rateLabel1
            // 
            this.rateLabel1.AutoSize = true;
            this.rateLabel1.Location = new System.Drawing.Point(112, 86);
            this.rateLabel1.Name = "rateLabel1";
            this.rateLabel1.Size = new System.Drawing.Size(82, 13);
            this.rateLabel1.TabIndex = 1;
            this.rateLabel1.Text = "Check our rates";
            // 
            // belleAireCheckBox
            // 
            this.belleAireCheckBox.AutoSize = true;
            this.belleAireCheckBox.Location = new System.Drawing.Point(115, 132);
            this.belleAireCheckBox.Name = "belleAireCheckBox";
            this.belleAireCheckBox.Size = new System.Drawing.Size(91, 17);
            this.belleAireCheckBox.TabIndex = 2;
            this.belleAireCheckBox.Text = "BelleAireSuite";
            this.belleAireCheckBox.UseVisualStyleBackColor = true;
            this.belleAireCheckBox.CheckedChanged += new System.EventHandler(this.belleAireCheckBox_CheckedChanged);
            // 
            // lincolnCheckBox
            // 
            this.lincolnCheckBox.AutoSize = true;
            this.lincolnCheckBox.Location = new System.Drawing.Point(115, 176);
            this.lincolnCheckBox.Name = "lincolnCheckBox";
            this.lincolnCheckBox.Size = new System.Drawing.Size(91, 17);
            this.lincolnCheckBox.TabIndex = 3;
            this.lincolnCheckBox.Text = "Lincoln Room";
            this.lincolnCheckBox.UseVisualStyleBackColor = true;
            this.lincolnCheckBox.CheckedChanged += new System.EventHandler(this.lincolnCheckBox_CheckedChanged);
            // 
            // mealButton
            // 
            this.mealButton.Location = new System.Drawing.Point(115, 329);
            this.mealButton.Name = "mealButton";
            this.mealButton.Size = new System.Drawing.Size(115, 23);
            this.mealButton.TabIndex = 4;
            this.mealButton.Text = "Click for meal options";
            this.mealButton.UseVisualStyleBackColor = true;
            this.mealButton.Click += new System.EventHandler(this.mealButton_Click);
            // 
            // BaileysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(429, 364);
            this.Controls.Add(this.mealButton);
            this.Controls.Add(this.lincolnCheckBox);
            this.Controls.Add(this.belleAireCheckBox);
            this.Controls.Add(this.rateLabel1);
            this.Controls.Add(this.welcomeLabel1);
            this.Name = "BaileysForm";
            this.Text = "Bailey\'s Bed and Breakfast";
            this.Load += new System.EventHandler(this.BaileysForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel1;
        private System.Windows.Forms.Label rateLabel1;
        private System.Windows.Forms.CheckBox belleAireCheckBox;
        private System.Windows.Forms.CheckBox lincolnCheckBox;
        private System.Windows.Forms.Button mealButton;
    }
}

