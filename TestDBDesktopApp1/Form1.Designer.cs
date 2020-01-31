namespace TestDBDesktopApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClinetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHomePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            resources.ApplyResources(this.buttonNew, "buttonNew");
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            resources.ApplyResources(this.buttonEdit, "buttonEdit");
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAccountNumber,
            this.ColumnClinetName,
            this.ColumnCity,
            this.ColumnState,
            this.ColumnZip,
            this.ColumnHomePhone});
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ColumnAccountNumber
            // 
            resources.ApplyResources(this.ColumnAccountNumber, "ColumnAccountNumber");
            this.ColumnAccountNumber.Name = "ColumnAccountNumber";
            // 
            // ColumnClinetName
            // 
            resources.ApplyResources(this.ColumnClinetName, "ColumnClinetName");
            this.ColumnClinetName.Name = "ColumnClinetName";
            // 
            // ColumnCity
            // 
            resources.ApplyResources(this.ColumnCity, "ColumnCity");
            this.ColumnCity.Name = "ColumnCity";
            // 
            // ColumnState
            // 
            resources.ApplyResources(this.ColumnState, "ColumnState");
            this.ColumnState.Name = "ColumnState";
            // 
            // ColumnZip
            // 
            resources.ApplyResources(this.ColumnZip, "ColumnZip");
            this.ColumnZip.Name = "ColumnZip";
            // 
            // ColumnHomePhone
            // 
            resources.ApplyResources(this.ColumnHomePhone, "ColumnHomePhone");
            this.ColumnHomePhone.Name = "ColumnHomePhone";
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // buttonUpdate
            // 
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClinetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHomePhone;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

