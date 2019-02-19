namespace DataBaseApp
{
    partial class StudentInformationUi
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.depatmentIdTextBox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(130, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(130, 93);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(130, 59);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.regNoTextBox.TabIndex = 0;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(31, 66);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(44, 13);
            this.Address.TabIndex = 1;
            this.Address.Text = "Reg No";
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(130, 123);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactNoTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contact No";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(284, 26);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(355, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DepartmentID";
            // 
            // depatmentIdTextBox
            // 
            this.depatmentIdTextBox.Location = new System.Drawing.Point(130, 156);
            this.depatmentIdTextBox.Name = "depatmentIdTextBox";
            this.depatmentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.depatmentIdTextBox.TabIndex = 0;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(264, 253);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(33, 310);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(592, 101);
            this.showDataGridView.TabIndex = 5;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(526, 81);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 6;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(296, 176);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(421, 176);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(541, 176);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID";
            // 
            // StudentInformationUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depatmentIdTextBox);
            this.Controls.Add(this.contactNoTextBox);
            this.Controls.Add(this.regNoTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "StudentInformationUi";
            this.Text = "Student Information";
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox depatmentIdTextBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label3;
    }
}

