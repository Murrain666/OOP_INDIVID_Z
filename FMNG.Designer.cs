namespace OOP_INDIVID_Z
{
    partial class FMNG
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
            this.linkLabel_AddClient = new System.Windows.Forms.LinkLabel();
            this.linkLabel_AddKV = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Reqs = new System.Windows.Forms.LinkLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonToDgv = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel_AddClient
            // 
            this.linkLabel_AddClient.AutoSize = true;
            this.linkLabel_AddClient.Location = new System.Drawing.Point(33, 41);
            this.linkLabel_AddClient.Name = "linkLabel_AddClient";
            this.linkLabel_AddClient.Size = new System.Drawing.Size(111, 16);
            this.linkLabel_AddClient.TabIndex = 0;
            this.linkLabel_AddClient.TabStop = true;
            this.linkLabel_AddClient.Text = "Внести клиента";
            this.linkLabel_AddClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AddClient_LinkClicked);
            // 
            // linkLabel_AddKV
            // 
            this.linkLabel_AddKV.AutoSize = true;
            this.linkLabel_AddKV.Location = new System.Drawing.Point(33, 100);
            this.linkLabel_AddKV.Name = "linkLabel_AddKV";
            this.linkLabel_AddKV.Size = new System.Drawing.Size(119, 16);
            this.linkLabel_AddKV.TabIndex = 1;
            this.linkLabel_AddKV.TabStop = true;
            this.linkLabel_AddKV.Text = "Внести квартиру";
            this.linkLabel_AddKV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AddKV_LinkClicked);
            // 
            // linkLabel_Reqs
            // 
            this.linkLabel_Reqs.AutoSize = true;
            this.linkLabel_Reqs.Location = new System.Drawing.Point(33, 178);
            this.linkLabel_Reqs.Name = "linkLabel_Reqs";
            this.linkLabel_Reqs.Size = new System.Drawing.Size(167, 16);
            this.linkLabel_Reqs.TabIndex = 2;
            this.linkLabel_Reqs.TabStop = true;
            this.linkLabel_Reqs.Text = "Смотреть список заявок";
            this.linkLabel_Reqs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Reqs_LinkClicked);
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 50;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 200;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(212, 12);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(1311, 212);
            this.listBox1.TabIndex = 3;
            // 
            // buttonToDgv
            // 
            this.buttonToDgv.Location = new System.Drawing.Point(267, 256);
            this.buttonToDgv.Name = "buttonToDgv";
            this.buttonToDgv.Size = new System.Drawing.Size(98, 43);
            this.buttonToDgv.TabIndex = 4;
            this.buttonToDgv.Text = "Утвердить заявку";
            this.buttonToDgv.UseVisualStyleBackColor = true;
            this.buttonToDgv.Click += new System.EventHandler(this.buttonToDgv_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.Location = new System.Drawing.Point(448, 256);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(95, 43);
            this.buttonReject.TabIndex = 5;
            this.buttonReject.Text = "Отклонить заявку";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.button1_Click);
            // 
            // FMNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 321);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.buttonToDgv);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.linkLabel_Reqs);
            this.Controls.Add(this.linkLabel_AddKV);
            this.Controls.Add(this.linkLabel_AddClient);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMNG";
            this.Text = "FMNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_AddClient;
        private System.Windows.Forms.LinkLabel linkLabel_AddKV;
        private System.Windows.Forms.LinkLabel linkLabel_Reqs;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonToDgv;
        private System.Windows.Forms.Button buttonReject;
    }
}