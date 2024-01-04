namespace _11_1
{
    partial class Form1
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
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtBoxEmpName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblEmployeeNum = new System.Windows.Forms.Label();
            this.lblShiftNum = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblShiftNumInstruction = new System.Windows.Forms.Label();
            this.txtBoxEmpNum = new System.Windows.Forms.TextBox();
            this.txtBoxShiftNum = new System.Windows.Forms.TextBox();
            this.txtBoxRate = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblAnnualSalary = new System.Windows.Forms.Label();
            this.lblAnnualBonus = new System.Windows.Forms.Label();
            this.txtBoxAnnualSalary = new System.Windows.Forms.TextBox();
            this.txtBoxAnnualBonus = new System.Windows.Forms.TextBox();
            this.radBtnProWorker = new System.Windows.Forms.RadioButton();
            this.radBtnShiftSup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(62, 94);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(129, 20);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // txtBoxEmpName
            // 
            this.txtBoxEmpName.Location = new System.Drawing.Point(209, 88);
            this.txtBoxEmpName.Name = "txtBoxEmpName";
            this.txtBoxEmpName.Size = new System.Drawing.Size(220, 26);
            this.txtBoxEmpName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(60, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 43);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEmployeeNum
            // 
            this.lblEmployeeNum.AutoSize = true;
            this.lblEmployeeNum.Location = new System.Drawing.Point(49, 135);
            this.lblEmployeeNum.Name = "lblEmployeeNum";
            this.lblEmployeeNum.Size = new System.Drawing.Size(143, 20);
            this.lblEmployeeNum.TabIndex = 3;
            this.lblEmployeeNum.Text = "Employee Number:";
            // 
            // lblShiftNum
            // 
            this.lblShiftNum.AutoSize = true;
            this.lblShiftNum.Location = new System.Drawing.Point(86, 179);
            this.lblShiftNum.Name = "lblShiftNum";
            this.lblShiftNum.Size = new System.Drawing.Size(106, 20);
            this.lblShiftNum.TabIndex = 4;
            this.lblShiftNum.Text = "Shift Number:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(94, 233);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(97, 20);
            this.lblHourlyRate.TabIndex = 5;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // lblShiftNumInstruction
            // 
            this.lblShiftNumInstruction.AutoSize = true;
            this.lblShiftNumInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftNumInstruction.Location = new System.Drawing.Point(95, 199);
            this.lblShiftNumInstruction.Name = "lblShiftNumInstruction";
            this.lblShiftNumInstruction.Size = new System.Drawing.Size(379, 17);
            this.lblShiftNumInstruction.TabIndex = 6;
            this.lblShiftNumInstruction.Text = "(Enter 1 for first shift, 2 for second shift, or 3 for third shift.)";
            // 
            // txtBoxEmpNum
            // 
            this.txtBoxEmpNum.Location = new System.Drawing.Point(207, 129);
            this.txtBoxEmpNum.Name = "txtBoxEmpNum";
            this.txtBoxEmpNum.Size = new System.Drawing.Size(154, 26);
            this.txtBoxEmpNum.TabIndex = 7;
            // 
            // txtBoxShiftNum
            // 
            this.txtBoxShiftNum.Location = new System.Drawing.Point(207, 170);
            this.txtBoxShiftNum.Name = "txtBoxShiftNum";
            this.txtBoxShiftNum.Size = new System.Drawing.Size(30, 26);
            this.txtBoxShiftNum.TabIndex = 8;
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.Location = new System.Drawing.Point(207, 227);
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.Size = new System.Drawing.Size(102, 26);
            this.txtBoxRate.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(207, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 43);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(360, 346);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(101, 43);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblAnnualSalary
            // 
            this.lblAnnualSalary.AutoSize = true;
            this.lblAnnualSalary.Location = new System.Drawing.Point(80, 271);
            this.lblAnnualSalary.Name = "lblAnnualSalary";
            this.lblAnnualSalary.Size = new System.Drawing.Size(111, 20);
            this.lblAnnualSalary.TabIndex = 12;
            this.lblAnnualSalary.Text = "Annual Salary:";
            // 
            // lblAnnualBonus
            // 
            this.lblAnnualBonus.AutoSize = true;
            this.lblAnnualBonus.Location = new System.Drawing.Point(78, 307);
            this.lblAnnualBonus.Name = "lblAnnualBonus";
            this.lblAnnualBonus.Size = new System.Drawing.Size(113, 20);
            this.lblAnnualBonus.TabIndex = 13;
            this.lblAnnualBonus.Text = "Annual Bonus:";
            // 
            // txtBoxAnnualSalary
            // 
            this.txtBoxAnnualSalary.Location = new System.Drawing.Point(209, 265);
            this.txtBoxAnnualSalary.Name = "txtBoxAnnualSalary";
            this.txtBoxAnnualSalary.Size = new System.Drawing.Size(102, 26);
            this.txtBoxAnnualSalary.TabIndex = 14;
            // 
            // txtBoxAnnualBonus
            // 
            this.txtBoxAnnualBonus.Location = new System.Drawing.Point(210, 301);
            this.txtBoxAnnualBonus.Name = "txtBoxAnnualBonus";
            this.txtBoxAnnualBonus.Size = new System.Drawing.Size(102, 26);
            this.txtBoxAnnualBonus.TabIndex = 15;
            // 
            // radBtnProWorker
            // 
            this.radBtnProWorker.AutoSize = true;
            this.radBtnProWorker.Location = new System.Drawing.Point(60, 37);
            this.radBtnProWorker.Name = "radBtnProWorker";
            this.radBtnProWorker.Size = new System.Drawing.Size(165, 24);
            this.radBtnProWorker.TabIndex = 16;
            this.radBtnProWorker.TabStop = true;
            this.radBtnProWorker.Text = "Production Worker";
            this.radBtnProWorker.UseVisualStyleBackColor = true;
            // 
            // radBtnShiftSup
            // 
            this.radBtnShiftSup.AutoSize = true;
            this.radBtnShiftSup.Location = new System.Drawing.Point(333, 37);
            this.radBtnShiftSup.Name = "radBtnShiftSup";
            this.radBtnShiftSup.Size = new System.Drawing.Size(146, 24);
            this.radBtnShiftSup.TabIndex = 17;
            this.radBtnShiftSup.TabStop = true;
            this.radBtnShiftSup.Text = "Shift Supervisor";
            this.radBtnShiftSup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 478);
            this.Controls.Add(this.radBtnShiftSup);
            this.Controls.Add(this.radBtnProWorker);
            this.Controls.Add(this.txtBoxAnnualBonus);
            this.Controls.Add(this.txtBoxAnnualSalary);
            this.Controls.Add(this.lblAnnualBonus);
            this.Controls.Add(this.lblAnnualSalary);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxRate);
            this.Controls.Add(this.txtBoxShiftNum);
            this.Controls.Add(this.txtBoxEmpNum);
            this.Controls.Add(this.lblShiftNumInstruction);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblShiftNum);
            this.Controls.Add(this.lblEmployeeNum);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxEmpName);
            this.Controls.Add(this.lblEmployeeName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtBoxEmpName;
        private System.Windows.Forms.Button btnSubmit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblEmployeeNum;
        private System.Windows.Forms.Label lblShiftNum;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblShiftNumInstruction;
        private System.Windows.Forms.TextBox txtBoxEmpNum;
        private System.Windows.Forms.TextBox txtBoxShiftNum;
        private System.Windows.Forms.TextBox txtBoxRate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblAnnualSalary;
        private System.Windows.Forms.Label lblAnnualBonus;
        private System.Windows.Forms.TextBox txtBoxAnnualSalary;
        private System.Windows.Forms.TextBox txtBoxAnnualBonus;
        private System.Windows.Forms.RadioButton radBtnProWorker;
        private System.Windows.Forms.RadioButton radBtnShiftSup;
    }
}

