namespace Conference_Project
{
    partial class conferenceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.totalsButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.lunchGroupBox = new System.Windows.Forms.GroupBox();
            this.dinnerGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.lunchGroupBox.SuspendLayout();
            this.dinnerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname: ";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(132, 84);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(191, 22);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(132, 137);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(191, 22);
            this.surnameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "School: ";
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Items.AddRange(new object[] {
            "Buckinghamshire New University Wycombe Campus",
            "Buckinghamshire New University Uxbridge Campus",
            "University of Reading"});
            this.schoolComboBox.Location = new System.Drawing.Point(132, 190);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(191, 24);
            this.schoolComboBox.TabIndex = 5;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(825, 369);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(137, 57);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.closeApplication);
            // 
            // totalsButton
            // 
            this.totalsButton.Location = new System.Drawing.Point(379, 363);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(138, 63);
            this.totalsButton.TabIndex = 7;
            this.totalsButton.Text = "Totals";
            this.totalsButton.UseVisualStyleBackColor = true;
            this.totalsButton.Click += new System.EventHandler(this.showTotals);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(165, 363);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(138, 63);
            this.billButton.TabIndex = 8;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.showBill);
            // 
            // lunchGroupBox
            // 
            this.lunchGroupBox.Controls.Add(this.checkBox3);
            this.lunchGroupBox.Controls.Add(this.checkBox2);
            this.lunchGroupBox.Controls.Add(this.checkBox1);
            this.lunchGroupBox.Location = new System.Drawing.Point(396, 53);
            this.lunchGroupBox.Name = "lunchGroupBox";
            this.lunchGroupBox.Size = new System.Drawing.Size(273, 291);
            this.lunchGroupBox.TabIndex = 9;
            this.lunchGroupBox.TabStop = false;
            this.lunchGroupBox.Text = "Lunch Selection";
            // 
            // dinnerGroupBox
            // 
            this.dinnerGroupBox.Controls.Add(this.checkBox6);
            this.dinnerGroupBox.Controls.Add(this.checkBox5);
            this.dinnerGroupBox.Controls.Add(this.checkBox4);
            this.dinnerGroupBox.Location = new System.Drawing.Point(701, 53);
            this.dinnerGroupBox.Name = "dinnerGroupBox";
            this.dinnerGroupBox.Size = new System.Drawing.Size(273, 291);
            this.dinnerGroupBox.TabIndex = 10;
            this.dinnerGroupBox.TabStop = false;
            this.dinnerGroupBox.Text = "Dinner Selection";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(39, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(227, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Chicken and Bacon Panini";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(39, 133);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(213, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Jacket Potato with sides";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(39, 193);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(143, 24);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Fish and Chips";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(28, 68);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(153, 24);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Steak and Chips";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(28, 133);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(210, 24);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Spaghetti and Meatballs";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(26, 193);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(241, 24);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Peri Peri Chicken and Chips";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // conferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.dinnerGroupBox);
            this.Controls.Add(this.lunchGroupBox);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.schoolComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "conferenceForm";
            this.Text = "Conference Data Entry";
            this.lunchGroupBox.ResumeLayout(false);
            this.lunchGroupBox.PerformLayout();
            this.dinnerGroupBox.ResumeLayout(false);
            this.dinnerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button totalsButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.GroupBox lunchGroupBox;
        private System.Windows.Forms.GroupBox dinnerGroupBox;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.TextBox surnameTextBox;
        public System.Windows.Forms.ComboBox schoolComboBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

