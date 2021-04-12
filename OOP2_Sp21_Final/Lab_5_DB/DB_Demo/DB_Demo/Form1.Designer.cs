namespace DB_Demo
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
            this.label_userName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_userType = new System.Windows.Forms.Label();
            this.comboBox_userType = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.button_load = new System.Windows.Forms.Button();
            this.label_userID = new System.Windows.Forms.Label();
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.SuspendLayout();
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.Location = new System.Drawing.Point(30, 30);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(115, 24);
            this.label_userName.TabIndex = 0;
            this.label_userName.Text = "User Name: ";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(152, 33);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(238, 20);
            this.textBox_UserName.TabIndex = 1;
            // 
            // label_userType
            // 
            this.label_userType.AutoSize = true;
            this.label_userType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userType.Location = new System.Drawing.Point(38, 74);
            this.label_userType.Name = "label_userType";
            this.label_userType.Size = new System.Drawing.Size(107, 24);
            this.label_userType.TabIndex = 2;
            this.label_userType.Text = "User Type: ";
            // 
            // comboBox_userType
            // 
            this.comboBox_userType.FormattingEnabled = true;
            this.comboBox_userType.Items.AddRange(new object[] {
            "USER",
            "ADMIN"});
            this.comboBox_userType.Location = new System.Drawing.Point(152, 76);
            this.comboBox_userType.Name = "comboBox_userType";
            this.comboBox_userType.Size = new System.Drawing.Size(238, 21);
            this.comboBox_userType.TabIndex = 3;
            this.comboBox_userType.Text = "SELECT TYPE";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(396, 30);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(112, 23);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Location = new System.Drawing.Point(34, 174);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.Size = new System.Drawing.Size(474, 207);
            this.dataGridView_users.TabIndex = 5;
            this.dataGridView_users.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_users_CellDoubleClick);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(396, 117);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(112, 23);
            this.button_load.TabIndex = 6;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userID.Location = new System.Drawing.Point(64, 117);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(81, 24);
            this.label_userID.TabIndex = 7;
            this.label_userID.Text = "User ID: ";
            // 
            // textBox_userID
            // 
            this.textBox_userID.Location = new System.Drawing.Point(152, 119);
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.Size = new System.Drawing.Size(160, 20);
            this.textBox_userID.TabIndex = 8;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(318, 117);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(72, 23);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(396, 59);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(112, 23);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(396, 88);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(112, 23);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 407);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_userID);
            this.Controls.Add(this.label_userID);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.dataGridView_users);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_userType);
            this.Controls.Add(this.label_userType);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_userName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_userType;
        private System.Windows.Forms.ComboBox comboBox_userType;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.TextBox textBox_userID;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
    }
}

