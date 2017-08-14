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
            // BaileysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(429, 364);
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
    }
}

