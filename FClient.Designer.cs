namespace OOP_INDIVID_Z
{
    partial class FClient
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
            this.clname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clbdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ntel = new System.Windows.Forms.TextBox();
            this.AddClient = new System.Windows.Forms.Button();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.buttonClCl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clname
            // 
            this.clname.Location = new System.Drawing.Point(50, 37);
            this.clname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clname.Name = "clname";
            this.clname.Size = new System.Drawing.Size(202, 22);
            this.clname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "дата рождения";
            // 
            // clbdate
            // 
            this.clbdate.Location = new System.Drawing.Point(50, 79);
            this.clbdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbdate.Name = "clbdate";
            this.clbdate.Size = new System.Drawing.Size(202, 22);
            this.clbdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "номер телефона";
            // 
            // ntel
            // 
            this.ntel.Location = new System.Drawing.Point(50, 121);
            this.ntel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ntel.Name = "ntel";
            this.ntel.Size = new System.Drawing.Size(202, 22);
            this.ntel.TabIndex = 5;
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(166, 149);
            this.AddClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(171, 66);
            this.AddClient.TabIndex = 6;
            this.AddClient.Text = "Зарегистрировать клиента";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.ItemHeight = 16;
            this.listBoxClient.Location = new System.Drawing.Point(357, 19);
            this.listBoxClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(332, 196);
            this.listBoxClient.TabIndex = 7;
            // 
            // buttonClCl
            // 
            this.buttonClCl.Location = new System.Drawing.Point(50, 298);
            this.buttonClCl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClCl.Name = "buttonClCl";
            this.buttonClCl.Size = new System.Drawing.Size(182, 38);
            this.buttonClCl.TabIndex = 8;
            this.buttonClCl.Text = "Закрыть";
            this.buttonClCl.UseVisualStyleBackColor = true;
            this.buttonClCl.Click += new System.EventHandler(this.buttonClCl_Click);
            // 
            // FClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.buttonClCl);
            this.Controls.Add(this.listBoxClient);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.ntel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FClient";
            this.Text = "FClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clbdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ntel;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.Button buttonClCl;
    }
}