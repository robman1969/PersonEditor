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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbAddPersonType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstNameAdd = new System.Windows.Forms.TextBox();
            this.txtLastNameAdd = new System.Windows.Forms.TextBox();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.txtPhoneAdd = new System.Windows.Forms.TextBox();
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
            this.PeopleGridView.Size = new System.Drawing.Size(1150, 290);
            this.PeopleGridView.TabIndex = 1;
            this.PeopleGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleGridView_CellValueChanged);
            this.PeopleGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleGridView_RowLeave);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(754, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 51);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(835, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(916, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 51);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(997, 308);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 51);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1078, 308);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 51);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 541);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 51);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbAddPersonType
            // 
            this.cbAddPersonType.FormattingEnabled = true;
            this.cbAddPersonType.Location = new System.Drawing.Point(128, 308);
            this.cbAddPersonType.Name = "cbAddPersonType";
            this.cbAddPersonType.Size = new System.Drawing.Size(283, 28);
            this.cbAddPersonType.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Person Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone";
            // 
            // txtFirstNameAdd
            // 
            this.txtFirstNameAdd.Location = new System.Drawing.Point(128, 357);
            this.txtFirstNameAdd.Name = "txtFirstNameAdd";
            this.txtFirstNameAdd.Size = new System.Drawing.Size(283, 26);
            this.txtFirstNameAdd.TabIndex = 14;
            // 
            // txtLastNameAdd
            // 
            this.txtLastNameAdd.Location = new System.Drawing.Point(128, 401);
            this.txtLastNameAdd.Name = "txtLastNameAdd";
            this.txtLastNameAdd.Size = new System.Drawing.Size(283, 26);
            this.txtLastNameAdd.TabIndex = 15;
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Location = new System.Drawing.Point(128, 445);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(283, 26);
            this.txtEmailAdd.TabIndex = 16;
            // 
            // txtPhoneAdd
            // 
            this.txtPhoneAdd.Location = new System.Drawing.Point(128, 489);
            this.txtPhoneAdd.Name = "txtPhoneAdd";
            this.txtPhoneAdd.Size = new System.Drawing.Size(283, 26);
            this.txtPhoneAdd.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 692);
            this.Controls.Add(this.txtPhoneAdd);
            this.Controls.Add(this.txtEmailAdd);
            this.Controls.Add(this.txtLastNameAdd);
            this.Controls.Add(this.txtFirstNameAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAddPersonType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.PeopleGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "People Editor ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PeopleGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPersonId;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbPersonType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbAddPersonType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstNameAdd;
        private System.Windows.Forms.TextBox txtLastNameAdd;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.TextBox txtPhoneAdd;
    }
}

