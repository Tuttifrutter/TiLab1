namespace TiLab1
{
    partial class Form1
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
            this.txtBSource = new System.Windows.Forms.TextBox();
            this.txtBResult = new System.Windows.Forms.TextBox();
            this.txtBKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDencrypt = new System.Windows.Forms.Button();
            this.rbRus = new System.Windows.Forms.RadioButton();
            this.rbEng = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCrypt = new System.Windows.Forms.Label();
            this.rbColumn = new System.Windows.Forms.RadioButton();
            this.rbVigener = new System.Windows.Forms.RadioButton();
            this.rbPlayFair = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBSource
            // 
            this.txtBSource.Location = new System.Drawing.Point(12, 40);
            this.txtBSource.Multiline = true;
            this.txtBSource.Name = "txtBSource";
            this.txtBSource.Size = new System.Drawing.Size(162, 137);
            this.txtBSource.TabIndex = 0;
            // 
            // txtBResult
            // 
            this.txtBResult.Location = new System.Drawing.Point(200, 40);
            this.txtBResult.Multiline = true;
            this.txtBResult.Name = "txtBResult";
            this.txtBResult.Size = new System.Drawing.Size(169, 137);
            this.txtBResult.TabIndex = 1;
            // 
            // txtBKey
            // 
            this.txtBKey.Location = new System.Drawing.Point(12, 208);
            this.txtBKey.Name = "txtBKey";
            this.txtBKey.Size = new System.Drawing.Size(357, 20);
            this.txtBKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шифротекст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ключ";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(386, 40);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(89, 23);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Шифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // btnDencrypt
            // 
            this.btnDencrypt.Location = new System.Drawing.Point(386, 69);
            this.btnDencrypt.Name = "btnDencrypt";
            this.btnDencrypt.Size = new System.Drawing.Size(89, 23);
            this.btnDencrypt.TabIndex = 7;
            this.btnDencrypt.Text = "Дешифровать";
            this.btnDencrypt.UseVisualStyleBackColor = true;
            this.btnDencrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // rbRus
            // 
            this.rbRus.AutoSize = true;
            this.rbRus.Checked = true;
            this.rbRus.Location = new System.Drawing.Point(6, 19);
            this.rbRus.Name = "rbRus";
            this.rbRus.Size = new System.Drawing.Size(67, 17);
            this.rbRus.TabIndex = 8;
            this.rbRus.TabStop = true;
            this.rbRus.Text = "Русский";
            this.rbRus.UseVisualStyleBackColor = true;
            this.rbRus.CheckedChanged += new System.EventHandler(this.RbRus_CheckedChanged);
            // 
            // rbEng
            // 
            this.rbEng.AutoSize = true;
            this.rbEng.Location = new System.Drawing.Point(6, 42);
            this.rbEng.Name = "rbEng";
            this.rbEng.Size = new System.Drawing.Size(59, 17);
            this.rbEng.TabIndex = 9;
            this.rbEng.Text = "English";
            this.rbEng.UseVisualStyleBackColor = true;
            this.rbEng.CheckedChanged += new System.EventHandler(this.RbEng_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Язык алфавита";
            // 
            // lblCrypt
            // 
            this.lblCrypt.AutoSize = true;
            this.lblCrypt.Location = new System.Drawing.Point(6, 4);
            this.lblCrypt.Name = "lblCrypt";
            this.lblCrypt.Size = new System.Drawing.Size(36, 13);
            this.lblCrypt.TabIndex = 11;
            this.lblCrypt.Text = "Шифр";
            // 
            // rbColumn
            // 
            this.rbColumn.AutoSize = true;
            this.rbColumn.Checked = true;
            this.rbColumn.Location = new System.Drawing.Point(9, 20);
            this.rbColumn.Name = "rbColumn";
            this.rbColumn.Size = new System.Drawing.Size(121, 17);
            this.rbColumn.TabIndex = 12;
            this.rbColumn.TabStop = true;
            this.rbColumn.Text = "Столбцовый метод";
            this.rbColumn.UseVisualStyleBackColor = true;
            this.rbColumn.CheckedChanged += new System.EventHandler(this.RbColumn_CheckedChanged);
            // 
            // rbVigener
            // 
            this.rbVigener.AutoSize = true;
            this.rbVigener.Location = new System.Drawing.Point(9, 43);
            this.rbVigener.Name = "rbVigener";
            this.rbVigener.Size = new System.Drawing.Size(70, 17);
            this.rbVigener.TabIndex = 13;
            this.rbVigener.Text = "Виженер";
            this.rbVigener.UseVisualStyleBackColor = true;
            this.rbVigener.CheckedChanged += new System.EventHandler(this.RbVigener_CheckedChanged);
            // 
            // rbPlayFair
            // 
            this.rbPlayFair.AutoSize = true;
            this.rbPlayFair.Location = new System.Drawing.Point(9, 66);
            this.rbPlayFair.Name = "rbPlayFair";
            this.rbPlayFair.Size = new System.Drawing.Size(115, 17);
            this.rbPlayFair.TabIndex = 14;
            this.rbPlayFair.Text = "Шифр Плейфейра";
            this.rbPlayFair.UseVisualStyleBackColor = true;
            this.rbPlayFair.CheckedChanged += new System.EventHandler(this.RbPlayFair_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCrypt);
            this.groupBox1.Controls.Add(this.rbPlayFair);
            this.groupBox1.Controls.Add(this.rbColumn);
            this.groupBox1.Controls.Add(this.rbVigener);
            this.groupBox1.Location = new System.Drawing.Point(514, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 97);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbRus);
            this.groupBox2.Controls.Add(this.rbEng);
            this.groupBox2.Location = new System.Drawing.Point(674, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 70);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDencrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBKey);
            this.Controls.Add(this.txtBResult);
            this.Controls.Add(this.txtBSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBSource;
        private System.Windows.Forms.TextBox txtBResult;
        private System.Windows.Forms.TextBox txtBKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDencrypt;
        private System.Windows.Forms.RadioButton rbRus;
        private System.Windows.Forms.RadioButton rbEng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCrypt;
        private System.Windows.Forms.RadioButton rbColumn;
        private System.Windows.Forms.RadioButton rbVigener;
        private System.Windows.Forms.RadioButton rbPlayFair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

