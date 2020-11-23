namespace HouseRooms
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
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.goHere = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Location = new System.Drawing.Point(30, 281);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(415, 23);
            this.goThroughTheDoor.TabIndex = 0;
            this.goThroughTheDoor.Text = "Go through the door";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Visible = false;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(40, 240);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(75, 23);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Go here:";
            this.goHere.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(138, 240);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(307, 21);
            this.exits.TabIndex = 2;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.description.Location = new System.Drawing.Point(27, 33);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(418, 182);
            this.description.TabIndex = 4;
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(30, 339);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(415, 23);
            this.hide.TabIndex = 5;
            this.hide.Text = "Hide!";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(30, 310);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(415, 23);
            this.check.TabIndex = 6;
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 373);
            this.Controls.Add(this.check);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.description);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.goThroughTheDoor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button check;
    }
}

