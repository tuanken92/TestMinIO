namespace TestMinIO
{
    partial class FormMinIO
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
            this.components = new System.ComponentModel.Container();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lb_path = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_bucket_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_create_bucket = new System.Windows.Forms.Button();
            this.list_all_bucket = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_check_exist = new System.Windows.Forms.Button();
            this.btn_list_bucket = new System.Windows.Forms.Button();
            this.context_list_bucket = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.context_list_bucket.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(873, 92);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(177, 52);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(873, 15);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(177, 52);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lb_path
            // 
            this.lb_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_path.Location = new System.Drawing.Point(564, 15);
            this.lb_path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(301, 50);
            this.lb_path.TabIndex = 2;
            this.lb_path.Text = "File\'s path";
            this.lb_path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(119, 34);
            this.txt_url.Margin = new System.Windows.Forms.Padding(4);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(132, 23);
            this.txt_url.TabIndex = 3;
            this.txt_url.Text = "192.168.3.11:9000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_url);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(277, 223);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MinIO Client";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(28, 155);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(222, 51);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(119, 115);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(132, 23);
            this.txt_password.TabIndex = 3;
            this.txt_password.Text = "tanhungha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(119, 74);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(132, 23);
            this.txt_user.TabIndex = 3;
            this.txt_user.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "User";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_all_bucket);
            this.groupBox2.Controls.Add(this.btn_list_bucket);
            this.groupBox2.Controls.Add(this.btn_create_bucket);
            this.groupBox2.Controls.Add(this.btn_check_exist);
            this.groupBox2.Controls.Add(this.txt_bucket_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(13, 244);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(363, 305);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MinIO Client";
            // 
            // txt_bucket_name
            // 
            this.txt_bucket_name.Location = new System.Drawing.Point(119, 34);
            this.txt_bucket_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bucket_name.Name = "txt_bucket_name";
            this.txt_bucket_name.Size = new System.Drawing.Size(132, 23);
            this.txt_bucket_name.TabIndex = 3;
            this.txt_bucket_name.Text = "TuanNa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bucket Name";
            // 
            // btn_create_bucket
            // 
            this.btn_create_bucket.Location = new System.Drawing.Point(267, 74);
            this.btn_create_bucket.Name = "btn_create_bucket";
            this.btn_create_bucket.Size = new System.Drawing.Size(79, 29);
            this.btn_create_bucket.TabIndex = 5;
            this.btn_create_bucket.Text = "Create";
            this.btn_create_bucket.UseVisualStyleBackColor = true;
            this.btn_create_bucket.Click += new System.EventHandler(this.btn_create_bucket_Click);
            // 
            // list_all_bucket
            // 
            this.list_all_bucket.ContextMenuStrip = this.context_list_bucket;
            this.list_all_bucket.FormattingEnabled = true;
            this.list_all_bucket.ItemHeight = 16;
            this.list_all_bucket.Location = new System.Drawing.Point(24, 109);
            this.list_all_bucket.Name = "list_all_bucket";
            this.list_all_bucket.Size = new System.Drawing.Size(322, 180);
            this.list_all_bucket.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "All bucket";
            // 
            // btn_check_exist
            // 
            this.btn_check_exist.Location = new System.Drawing.Point(267, 31);
            this.btn_check_exist.Name = "btn_check_exist";
            this.btn_check_exist.Size = new System.Drawing.Size(79, 29);
            this.btn_check_exist.TabIndex = 5;
            this.btn_check_exist.Text = "Is exist?";
            this.btn_check_exist.UseVisualStyleBackColor = true;
            this.btn_check_exist.Click += new System.EventHandler(this.btn_check_exist_Click);
            // 
            // btn_list_bucket
            // 
            this.btn_list_bucket.Location = new System.Drawing.Point(119, 74);
            this.btn_list_bucket.Name = "btn_list_bucket";
            this.btn_list_bucket.Size = new System.Drawing.Size(79, 29);
            this.btn_list_bucket.TabIndex = 5;
            this.btn_list_bucket.Text = "List";
            this.btn_list_bucket.UseVisualStyleBackColor = true;
            // 
            // context_list_bucket
            // 
            this.context_list_bucket.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.context_list_bucket.Name = "context_list_bucket";
            this.context_list_bucket.Size = new System.Drawing.Size(114, 48);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // FormMinIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_path);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnUpload);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMinIO";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.context_list_bucket.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_all_bucket;
        private System.Windows.Forms.Button btn_list_bucket;
        private System.Windows.Forms.Button btn_create_bucket;
        private System.Windows.Forms.Button btn_check_exist;
        private System.Windows.Forms.TextBox txt_bucket_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip context_list_bucket;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

