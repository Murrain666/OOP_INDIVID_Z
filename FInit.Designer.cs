namespace OOP_INDIVID_Z
{
    partial class FInit
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
            this.labelPIN = new System.Windows.Forms.Label();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.buttonIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Location = new System.Drawing.Point(65, 32);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(35, 20);
            this.labelPIN.TabIndex = 0;
            this.labelPIN.Text = "PIN";
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(69, 87);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(146, 26);
            this.textBoxPIN.TabIndex = 1;
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(372, 64);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(229, 100);
            this.buttonIn.TabIndex = 2;
            this.buttonIn.Text = "Войти";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // FInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.textBoxPIN);
            this.Controls.Add(this.labelPIN);
            this.Name = "FInit";
            this.Text = "FInit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Button buttonIn;
    }
}