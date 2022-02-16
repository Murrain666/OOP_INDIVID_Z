namespace OOP_INDIVID_Z
{
    partial class FUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBoxLKV = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxClients = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RentDays = new System.Windows.Forms.TextBox();
            this.labelRentDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывести список квартир и клиентов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(30, 367);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(194, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Оформить заявку на аренду";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 524);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBoxLKV
            // 
            this.checkedListBoxLKV.FormattingEnabled = true;
            this.checkedListBoxLKV.Location = new System.Drawing.Point(230, 8);
            this.checkedListBoxLKV.Name = "checkedListBoxLKV";
            this.checkedListBoxLKV.Size = new System.Drawing.Size(1124, 310);
            this.checkedListBoxLKV.TabIndex = 5;
            // 
            // checkedListBoxClients
            // 
            this.checkedListBoxClients.FormattingEnabled = true;
            this.checkedListBoxClients.Location = new System.Drawing.Point(230, 330);
            this.checkedListBoxClients.Name = "checkedListBoxClients";
            this.checkedListBoxClients.Size = new System.Drawing.Size(1124, 225);
            this.checkedListBoxClients.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 251);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата начала аренды";
            // 
            // RentDays
            // 
            this.RentDays.Location = new System.Drawing.Point(24, 325);
            this.RentDays.Name = "RentDays";
            this.RentDays.Size = new System.Drawing.Size(100, 22);
            this.RentDays.TabIndex = 9;
            this.RentDays.Text = "1";
            // 
            // labelRentDays
            // 
            this.labelRentDays.AutoSize = true;
            this.labelRentDays.Location = new System.Drawing.Point(27, 302);
            this.labelRentDays.Name = "labelRentDays";
            this.labelRentDays.Size = new System.Drawing.Size(161, 20);
            this.labelRentDays.TabIndex = 10;
            this.labelRentDays.Text = "Срок аренды, дней";
            // 
            // FUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 565);
            this.Controls.Add(this.labelRentDays);
            this.Controls.Add(this.RentDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkedListBoxClients);
            this.Controls.Add(this.checkedListBoxLKV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FUser";
            this.Text = "FUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBoxLKV;
        private System.Windows.Forms.CheckedListBox checkedListBoxClients;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RentDays;
        private System.Windows.Forms.Label labelRentDays;
    }
}