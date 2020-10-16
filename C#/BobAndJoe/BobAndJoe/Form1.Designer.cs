namespace BobAndJoe
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
            this.giveToJoe = new System.Windows.Forms.Button();
            this.receiveFromBob = new System.Windows.Forms.Button();
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.joeGiveBob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giveToJoe
            // 
            this.giveToJoe.Location = new System.Drawing.Point(29, 187);
            this.giveToJoe.Name = "giveToJoe";
            this.giveToJoe.Size = new System.Drawing.Size(82, 43);
            this.giveToJoe.TabIndex = 0;
            this.giveToJoe.Text = "Дать $10 Joe";
            this.giveToJoe.UseVisualStyleBackColor = true;
            this.giveToJoe.Click += new System.EventHandler(this.giveToJoe_Click);
            // 
            // receiveFromBob
            // 
            this.receiveFromBob.Location = new System.Drawing.Point(161, 187);
            this.receiveFromBob.Name = "receiveFromBob";
            this.receiveFromBob.Size = new System.Drawing.Size(86, 43);
            this.receiveFromBob.TabIndex = 1;
            this.receiveFromBob.Text = "Получить $5 от Bob";
            this.receiveFromBob.UseVisualStyleBackColor = true;
            this.receiveFromBob.Click += new System.EventHandler(this.receiveFromBob_Click);
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(76, 13);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(35, 13);
            this.joesCashLabel.TabIndex = 2;
            this.joesCashLabel.Text = "label1";
            // 
            // bobCashLabel
            // 
            this.bobCashLabel.AutoSize = true;
            this.bobCashLabel.Location = new System.Drawing.Point(75, 38);
            this.bobCashLabel.Name = "bobCashLabel";
            this.bobCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bobCashLabel.TabIndex = 3;
            this.bobCashLabel.Text = "label2";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(75, 66);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bankCashLabel.TabIndex = 4;
            this.bankCashLabel.Text = "label3";
            // 
            // joeGiveBob
            // 
            this.joeGiveBob.Location = new System.Drawing.Point(29, 111);
            this.joeGiveBob.Name = "joeGiveBob";
            this.joeGiveBob.Size = new System.Drawing.Size(75, 40);
            this.joeGiveBob.TabIndex = 5;
            this.joeGiveBob.Text = "Joe дает Bob $15";
            this.joeGiveBob.UseVisualStyleBackColor = true;
            this.joeGiveBob.Click += new System.EventHandler(this.joeGiveBob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.joeGiveBob);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Controls.Add(this.receiveFromBob);
            this.Controls.Add(this.giveToJoe);
            this.Name = "Form1";
            this.Text = "Fun Bob and Joe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giveToJoe;
        private System.Windows.Forms.Button receiveFromBob;
        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button joeGiveBob;
    }
}

