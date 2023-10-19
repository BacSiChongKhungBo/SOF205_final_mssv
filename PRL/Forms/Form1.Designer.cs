namespace PRL.Forms
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
            txtTen = new TextBox();
            txtDiachi = new TextBox();
            txtEmail = new TextBox();
            txtSdt = new TextBox();
            txtIdPh = new TextBox();
            txtSearch = new TextBox();
            btnShow = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dtgView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(59, 24);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(335, 23);
            txtTen.TabIndex = 0;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(59, 66);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(335, 23);
            txtDiachi.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(59, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(335, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(59, 156);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(335, 23);
            txtSdt.TabIndex = 3;
            // 
            // txtIdPh
            // 
            txtIdPh.Location = new Point(59, 200);
            txtIdPh.Name = "txtIdPh";
            txtIdPh.Size = new Size(335, 23);
            txtIdPh.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(59, 256);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(335, 23);
            txtSearch.TabIndex = 5;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(514, 24);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(252, 47);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(514, 77);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(252, 47);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(514, 130);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(252, 47);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(514, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(252, 47);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(12, 288);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(776, 150);
            dtgView.TabIndex = 10;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnShow);
            Controls.Add(txtSearch);
            Controls.Add(txtIdPh);
            Controls.Add(txtSdt);
            Controls.Add(txtEmail);
            Controls.Add(txtDiachi);
            Controls.Add(txtTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTen;
        private TextBox txtDiachi;
        private TextBox txtEmail;
        private TextBox txtSdt;
        private TextBox txtIdPh;
        private TextBox txtSearch;
        private Button btnShow;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dtgView;
    }
}