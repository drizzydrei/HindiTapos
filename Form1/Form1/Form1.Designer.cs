namespace Form1
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
            studentNo = new Label();
            program = new Label();
            lastName = new Label();
            firstName = new Label();
            middleName = new Label();
            age = new Label();
            contactNumber = new Label();
            address = new Label();
            textBoxStudentNo = new TextBox();
            textBoxLName = new TextBox();
            textBoxFName = new TextBox();
            textBoxMName = new TextBox();
            textBoxAge = new TextBox();
            textBoxContactNum = new TextBox();
            textBoxAddress = new TextBox();
            buttonNext = new Button();
            cbProgram = new ComboBox();
            SuspendLayout();
            // 
            // studentNo
            // 
            studentNo.AutoSize = true;
            studentNo.Location = new Point(97, 45);
            studentNo.Name = "studentNo";
            studentNo.Size = new Size(95, 15);
            studentNo.TabIndex = 0;
            studentNo.Text = "Student Number";
            // 
            // program
            // 
            program.AutoSize = true;
            program.Location = new Point(278, 45);
            program.Name = "program";
            program.Size = new Size(53, 15);
            program.TabIndex = 1;
            program.Text = "Program";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(97, 100);
            lastName.Name = "lastName";
            lastName.Size = new Size(63, 15);
            lastName.TabIndex = 2;
            lastName.Text = "Last Name";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(276, 100);
            firstName.Name = "firstName";
            firstName.Size = new Size(64, 15);
            firstName.TabIndex = 3;
            firstName.Text = "First Name";
            // 
            // middleName
            // 
            middleName.AutoSize = true;
            middleName.Location = new Point(453, 100);
            middleName.Name = "middleName";
            middleName.Size = new Size(79, 15);
            middleName.TabIndex = 4;
            middleName.Text = "Middle Name";
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(97, 159);
            age.Name = "age";
            age.Size = new Size(28, 15);
            age.TabIndex = 5;
            age.Text = "Age";
            // 
            // contactNumber
            // 
            contactNumber.AutoSize = true;
            contactNumber.Location = new Point(276, 159);
            contactNumber.Name = "contactNumber";
            contactNumber.Size = new Size(96, 15);
            contactNumber.TabIndex = 6;
            contactNumber.Text = "Contact Number";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(97, 212);
            address.Name = "address";
            address.Size = new Size(49, 15);
            address.TabIndex = 7;
            address.Text = "Address";
            // 
            // textBoxStudentNo
            // 
            textBoxStudentNo.Location = new Point(97, 63);
            textBoxStudentNo.Name = "textBoxStudentNo";
            textBoxStudentNo.Size = new Size(175, 23);
            textBoxStudentNo.TabIndex = 8;
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(97, 118);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(175, 23);
            textBoxLName.TabIndex = 10;
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(276, 118);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(171, 23);
            textBoxFName.TabIndex = 11;
            // 
            // textBoxMName
            // 
            textBoxMName.Location = new Point(453, 118);
            textBoxMName.Name = "textBoxMName";
            textBoxMName.Size = new Size(100, 23);
            textBoxMName.TabIndex = 12;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(97, 177);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(100, 23);
            textBoxAge.TabIndex = 13;
            // 
            // textBoxContactNum
            // 
            textBoxContactNum.Location = new Point(276, 177);
            textBoxContactNum.Name = "textBoxContactNum";
            textBoxContactNum.Size = new Size(146, 23);
            textBoxContactNum.TabIndex = 14;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(97, 230);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(456, 186);
            textBoxAddress.TabIndex = 15;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(571, 360);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(195, 56);
            buttonNext.TabIndex = 16;
            buttonNext.Text = "SUBMIT";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += button1_Click;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(278, 63);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(254, 23);
            cbProgram.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbProgram);
            Controls.Add(buttonNext);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxContactNum);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxMName);
            Controls.Add(textBoxFName);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxStudentNo);
            Controls.Add(address);
            Controls.Add(contactNumber);
            Controls.Add(age);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(lastName);
            Controls.Add(program);
            Controls.Add(studentNo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentNo;
        private Label program;
        private Label lastName;
        private Label firstName;
        private Label middleName;
        private Label age;
        private Label contactNumber;
        private Label address;
        private TextBox textBoxStudentNo;
        private TextBox textBoxLName;
        private TextBox textBoxFName;
        private TextBox textBoxMName;
        private TextBox textBoxAge;
        private TextBox textBoxContactNum;
        private TextBox textBoxAddress;
        private Button buttonNext;
        private ComboBox cbProgram;
    }
}