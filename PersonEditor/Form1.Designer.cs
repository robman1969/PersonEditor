namespace PersonEditor
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
            this.PeopleGridView = new System.Windows.Forms.DataGridView();
            this.txtPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPersonType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleGridView
            // 
            this.PeopleGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeopleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtPersonId,
            this.cbPersonType,
            this.txtFirstName,
            this.txtLastName,
            this.txtEmail,
            this.txtPhone});
            this.PeopleGridView.Location = new System.Drawing.Point(2, 3);
            this.PeopleGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PeopleGridView.Name = "PeopleGridView";
            this.PeopleGridView.RowHeadersWidth = 62;
            this.PeopleGridView.Size = new System.Drawing.Size(1150, 549);
            this.PeopleGridView.TabIndex = 1;
            this.PeopleGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleGridView_CellValueChanged);
            this.PeopleGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.PeopleGridView_UserDeletingRow);
            // 
            // txtPersonId
            // 
            this.txtPersonId.DataPropertyName = "PersonId";
            this.txtPersonId.HeaderText = "Person Id";
            this.txtPersonId.MinimumWidth = 8;
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Visible = false;
            this.txtPersonId.Width = 150;
            // 
            // cbPersonType
            // 
            this.cbPersonType.DataPropertyName = "PersonTypeId";
            this.cbPersonType.HeaderText = "Person Type";
            this.cbPersonType.MinimumWidth = 8;
            this.cbPersonType.Name = "cbPersonType";
            this.cbPersonType.Width = 150;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataPropertyName = "FirstName";
            this.txtFirstName.HeaderText = "First Name";
            this.txtFirstName.MinimumWidth = 8;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Width = 150;
            // 
            // txtLastName
            // 
            this.txtLastName.DataPropertyName = "LastName";
            this.txtLastName.HeaderText = "Last Name";
            this.txtLastName.MinimumWidth = 8;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Width = 150;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtEmail.DataPropertyName = "Email";
            this.txtEmail.HeaderText = "Email";
            this.txtEmail.MinimumWidth = 8;
            this.txtEmail.Name = "txtEmail";
            // 
            // txtPhone
            // 
            this.txtPhone.DataPropertyName = "Phone";
            this.txtPhone.HeaderText = "Phone";
            this.txtPhone.MinimumWidth = 8;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 692);
            this.Controls.Add(this.PeopleGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "People Editor ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView PeopleGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPersonId;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbPersonType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhone;
    }
}

