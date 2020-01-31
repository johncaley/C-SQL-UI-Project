namespace TestDBDesktopApp1
{
    partial class UpdatePatient
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
            this.labelSelectAccountNumber = new System.Windows.Forms.Label();
            this.textBoxSelectAccountNumber = new System.Windows.Forms.TextBox();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelMiddleInitial = new System.Windows.Forms.Label();
            this.textBoxMiddleInitial = new System.Windows.Forms.TextBox();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.labelHomePhone = new System.Windows.Forms.Label();
            this.textBoxHomePhone = new System.Windows.Forms.TextBox();
            this.labelBusinessPhone = new System.Windows.Forms.Label();
            this.textBoxBusinessPhone = new System.Windows.Forms.TextBox();
            this.textBoxCellPhone = new System.Windows.Forms.TextBox();
            this.labelCellPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectAccountNumber
            // 
            this.labelSelectAccountNumber.AutoSize = true;
            this.labelSelectAccountNumber.Location = new System.Drawing.Point(12, 19);
            this.labelSelectAccountNumber.Name = "labelSelectAccountNumber";
            this.labelSelectAccountNumber.Size = new System.Drawing.Size(123, 13);
            this.labelSelectAccountNumber.TabIndex = 0;
            this.labelSelectAccountNumber.Text = "Select Account Number:";
            // 
            // textBoxSelectAccountNumber
            // 
            this.textBoxSelectAccountNumber.Location = new System.Drawing.Point(141, 16);
            this.textBoxSelectAccountNumber.Name = "textBoxSelectAccountNumber";
            this.textBoxSelectAccountNumber.Size = new System.Drawing.Size(65, 20);
            this.textBoxSelectAccountNumber.TabIndex = 1;
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(212, 14);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(75, 23);
            this.buttonGetData.TabIndex = 2;
            this.buttonGetData.Text = "Get Data";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxEmail);
            this.groupBox.Controls.Add(this.labelEmail);
            this.groupBox.Controls.Add(this.labelCellPhone);
            this.groupBox.Controls.Add(this.textBoxCellPhone);
            this.groupBox.Controls.Add(this.textBoxBusinessPhone);
            this.groupBox.Controls.Add(this.labelBusinessPhone);
            this.groupBox.Controls.Add(this.textBoxHomePhone);
            this.groupBox.Controls.Add(this.labelHomePhone);
            this.groupBox.Controls.Add(this.textBoxZipCode);
            this.groupBox.Controls.Add(this.labelZipCode);
            this.groupBox.Controls.Add(this.textBoxState);
            this.groupBox.Controls.Add(this.labelState);
            this.groupBox.Controls.Add(this.textBoxCity);
            this.groupBox.Controls.Add(this.labelCity);
            this.groupBox.Controls.Add(this.textBoxAddress2);
            this.groupBox.Controls.Add(this.labelAddress2);
            this.groupBox.Controls.Add(this.textBoxAddress1);
            this.groupBox.Controls.Add(this.labelAddress1);
            this.groupBox.Controls.Add(this.textBoxMiddleInitial);
            this.groupBox.Controls.Add(this.labelMiddleInitial);
            this.groupBox.Controls.Add(this.textBoxLastName);
            this.groupBox.Controls.Add(this.labelLastName);
            this.groupBox.Controls.Add(this.textBoxFirstName);
            this.groupBox.Controls.Add(this.labelFirstName);
            this.groupBox.Controls.Add(this.buttonExit);
            this.groupBox.Controls.Add(this.buttonUpdate);
            this.groupBox.Location = new System.Drawing.Point(15, 49);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(508, 252);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(383, 176);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(119, 23);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(383, 215);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 16);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(72, 13);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(194, 16);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(261, 13);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // labelMiddleInitial
            // 
            this.labelMiddleInitial.AutoSize = true;
            this.labelMiddleInitial.Location = new System.Drawing.Point(391, 16);
            this.labelMiddleInitial.Name = "labelMiddleInitial";
            this.labelMiddleInitial.Size = new System.Drawing.Size(68, 13);
            this.labelMiddleInitial.TabIndex = 6;
            this.labelMiddleInitial.Text = "Middle Initial:";
            // 
            // textBoxMiddleInitial
            // 
            this.textBoxMiddleInitial.Location = new System.Drawing.Point(465, 13);
            this.textBoxMiddleInitial.Name = "textBoxMiddleInitial";
            this.textBoxMiddleInitial.Size = new System.Drawing.Size(37, 20);
            this.textBoxMiddleInitial.TabIndex = 7;
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(6, 57);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(54, 13);
            this.labelAddress1.TabIndex = 8;
            this.labelAddress1.Text = "Address1:";
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(66, 54);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(186, 20);
            this.textBoxAddress1.TabIndex = 9;
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(258, 57);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(54, 13);
            this.labelAddress2.TabIndex = 10;
            this.labelAddress2.Text = "Address2:";
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(316, 54);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(186, 20);
            this.textBoxAddress2.TabIndex = 11;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(6, 101);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 12;
            this.labelCity.Text = "City:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(39, 98);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(133, 20);
            this.textBoxCity.TabIndex = 13;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(194, 101);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 13);
            this.labelState.TabIndex = 14;
            this.labelState.Text = "State:";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(237, 98);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(35, 20);
            this.textBoxState.TabIndex = 15;
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(338, 101);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(50, 13);
            this.labelZipCode.TabIndex = 16;
            this.labelZipCode.Text = "ZipCode:";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(394, 98);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(108, 20);
            this.textBoxZipCode.TabIndex = 17;
            // 
            // labelHomePhone
            // 
            this.labelHomePhone.AutoSize = true;
            this.labelHomePhone.Location = new System.Drawing.Point(6, 142);
            this.labelHomePhone.Name = "labelHomePhone";
            this.labelHomePhone.Size = new System.Drawing.Size(72, 13);
            this.labelHomePhone.TabIndex = 18;
            this.labelHomePhone.Text = "Home Phone:";
            // 
            // textBoxHomePhone
            // 
            this.textBoxHomePhone.Location = new System.Drawing.Point(84, 139);
            this.textBoxHomePhone.Name = "textBoxHomePhone";
            this.textBoxHomePhone.Size = new System.Drawing.Size(145, 20);
            this.textBoxHomePhone.TabIndex = 19;
            // 
            // labelBusinessPhone
            // 
            this.labelBusinessPhone.AutoSize = true;
            this.labelBusinessPhone.Location = new System.Drawing.Point(257, 142);
            this.labelBusinessPhone.Name = "labelBusinessPhone";
            this.labelBusinessPhone.Size = new System.Drawing.Size(86, 13);
            this.labelBusinessPhone.TabIndex = 20;
            this.labelBusinessPhone.Text = "Business Phone:";
            // 
            // textBoxBusinessPhone
            // 
            this.textBoxBusinessPhone.Location = new System.Drawing.Point(349, 139);
            this.textBoxBusinessPhone.Name = "textBoxBusinessPhone";
            this.textBoxBusinessPhone.Size = new System.Drawing.Size(153, 20);
            this.textBoxBusinessPhone.TabIndex = 21;
            // 
            // textBoxCellPhone
            // 
            this.textBoxCellPhone.Location = new System.Drawing.Point(73, 178);
            this.textBoxCellPhone.Name = "textBoxCellPhone";
            this.textBoxCellPhone.Size = new System.Drawing.Size(145, 20);
            this.textBoxCellPhone.TabIndex = 22;
            // 
            // labelCellPhone
            // 
            this.labelCellPhone.AutoSize = true;
            this.labelCellPhone.Location = new System.Drawing.Point(6, 181);
            this.labelCellPhone.Name = "labelCellPhone";
            this.labelCellPhone.Size = new System.Drawing.Size(61, 13);
            this.labelCellPhone.TabIndex = 23;
            this.labelCellPhone.Text = "Cell Phone:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 220);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 24;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(47, 217);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(182, 20);
            this.textBoxEmail.TabIndex = 25;
            // 
            // UpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 311);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonGetData);
            this.Controls.Add(this.textBoxSelectAccountNumber);
            this.Controls.Add(this.labelSelectAccountNumber);
            this.Name = "UpdatePatient";
            this.Text = "UpdatePatient";
            this.Load += new System.EventHandler(this.UpdatePatient_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectAccountNumber;
        private System.Windows.Forms.TextBox textBoxSelectAccountNumber;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.TextBox textBoxMiddleInitial;
        private System.Windows.Forms.Label labelMiddleInitial;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCellPhone;
        private System.Windows.Forms.TextBox textBoxCellPhone;
        private System.Windows.Forms.TextBox textBoxBusinessPhone;
        private System.Windows.Forms.Label labelBusinessPhone;
        private System.Windows.Forms.TextBox textBoxHomePhone;
        private System.Windows.Forms.Label labelHomePhone;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.Label labelAddress2;
    }
}