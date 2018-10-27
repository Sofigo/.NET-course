namespace Notes
{
    partial class FormNotes
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ADD = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.Logout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(51, 23);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(111, 76);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(51, 115);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(111, 76);
            this.DELETE.TabIndex = 1;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(193, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(193, 68);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(50, 13);
            this.Message.TabIndex = 3;
            this.Message.Text = "Message";
            this.Message.Click += new System.EventHandler(this.Message_Click);
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(196, 39);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(100, 20);
            this.textTitle.TabIndex = 4;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(196, 85);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(138, 58);
            this.textMessage.TabIndex = 5;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(51, 227);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 8;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 227);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormNotes
            // 
            this.ClientSize = new System.Drawing.Size(673, 278);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.ADD);
            this.Name = "FormNotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

