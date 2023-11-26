namespace University
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxAge = new TextBox();
            label3 = new Label();
            textBoxFaculty = new TextBox();
            label4 = new Label();
            textBoxDepartment = new TextBox();
            label5 = new Label();
            textBoxGroup = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(109, 20);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Ім'я студента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 59);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Рік студента";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(109, 59);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(100, 23);
            textBoxAge.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 100);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Факультет";
            // 
            // textBoxFaculty
            // 
            textBoxFaculty.Location = new Point(109, 100);
            textBoxFaculty.Name = "textBoxFaculty";
            textBoxFaculty.Size = new Size(100, 23);
            textBoxFaculty.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 148);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Кафедра";
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Location = new Point(109, 148);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(100, 23);
            textBoxDepartment.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 192);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Група";
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(109, 192);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(100, 23);
            textBoxGroup.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(266, 20);
            button1.Name = "button1";
            button1.Size = new Size(206, 62);
            button1.TabIndex = 10;
            button1.Text = "Вивести інформацію про студента";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(266, 122);
            button2.Name = "button2";
            button2.Size = new Size(206, 69);
            button2.TabIndex = 11;
            button2.Text = "Писати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBoxGroup);
            Controls.Add(label4);
            Controls.Add(textBoxDepartment);
            Controls.Add(label3);
            Controls.Add(textBoxFaculty);
            Controls.Add(label2);
            Controls.Add(textBoxAge);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private TextBox textBoxAge;
        private Label label3;
        private TextBox textBoxFaculty;
        private Label label4;
        private TextBox textBoxDepartment;
        private Label label5;
        private TextBox textBoxGroup;
        private Button button1;
        private Button button2;
    }
}