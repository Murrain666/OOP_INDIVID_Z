namespace OOP_INDIVID_Z
{
    partial class FormKV
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.adres = new System.Windows.Forms.TextBox();
            this.s_kv = new System.Windows.Forms.TextBox();
            this.n_kv = new System.Windows.Forms.TextBox();
            this.v_kv = new System.Windows.Forms.TextBox();
            this.buttonAddKv = new System.Windows.Forms.Button();
            this.listBoxKv = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClFl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(71, 53);
            this.adres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(177, 22);
            this.adres.TabIndex = 0;
            // 
            // s_kv
            // 
            this.s_kv.Location = new System.Drawing.Point(71, 105);
            this.s_kv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s_kv.Name = "s_kv";
            this.s_kv.Size = new System.Drawing.Size(177, 22);
            this.s_kv.TabIndex = 1;
            // 
            // n_kv
            // 
            this.n_kv.Location = new System.Drawing.Point(71, 158);
            this.n_kv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n_kv.Name = "n_kv";
            this.n_kv.Size = new System.Drawing.Size(177, 22);
            this.n_kv.TabIndex = 2;
            // 
            // v_kv
            // 
            this.v_kv.Location = new System.Drawing.Point(71, 210);
            this.v_kv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.v_kv.Name = "v_kv";
            this.v_kv.Size = new System.Drawing.Size(177, 22);
            this.v_kv.TabIndex = 3;
            // 
            // buttonAddKv
            // 
            this.buttonAddKv.Location = new System.Drawing.Point(308, 53);
            this.buttonAddKv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddKv.Name = "buttonAddKv";
            this.buttonAddKv.Size = new System.Drawing.Size(156, 41);
            this.buttonAddKv.TabIndex = 4;
            this.buttonAddKv.Text = "Внести квартиру";
            this.buttonAddKv.UseVisualStyleBackColor = true;
            this.buttonAddKv.Click += new System.EventHandler(this.buttonAddKv_Click);
            // 
            // listBoxKv
            // 
            this.listBoxKv.FormattingEnabled = true;
            this.listBoxKv.ItemHeight = 16;
            this.listBoxKv.Location = new System.Drawing.Point(308, 114);
            this.listBoxKv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxKv.Name = "listBoxKv";
            this.listBoxKv.Size = new System.Drawing.Size(376, 212);
            this.listBoxKv.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ввод адреса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "площадь квартиры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "количество комнат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "стоимость аренды в сутки";
            // 
            // buttonClFl
            // 
            this.buttonClFl.Location = new System.Drawing.Point(71, 270);
            this.buttonClFl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClFl.Name = "buttonClFl";
            this.buttonClFl.Size = new System.Drawing.Size(140, 38);
            this.buttonClFl.TabIndex = 10;
            this.buttonClFl.Text = "Закрыть";
            this.buttonClFl.UseVisualStyleBackColor = true;
            this.buttonClFl.Click += new System.EventHandler(this.buttonClFl_Click);
            // 
            // FormKV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.buttonClFl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxKv);
            this.Controls.Add(this.buttonAddKv);
            this.Controls.Add(this.v_kv);
            this.Controls.Add(this.n_kv);
            this.Controls.Add(this.s_kv);
            this.Controls.Add(this.adres);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKV";
            this.Text = "FormKV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox s_kv;
        private System.Windows.Forms.TextBox n_kv;
        private System.Windows.Forms.TextBox v_kv;
        private System.Windows.Forms.Button buttonAddKv;
        private System.Windows.Forms.ListBox listBoxKv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClFl;
    }
}

