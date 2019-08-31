namespace Test
{
    partial class Form1
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t1_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1_Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1_Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1_DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1_BPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.t2_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2_Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2_Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2_Auto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.t2_Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.t3_Auto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3_Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3_Coins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3_Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3_Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1036, 755);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(81, 38);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(605, 71);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 38);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t1_id,
            this.t1_Fname,
            this.t1_Sname,
            this.t1_DOB,
            this.t1_BPL});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 213);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // t1_id
            // 
            this.t1_id.HeaderText = "ID";
            this.t1_id.Name = "t1_id";
            this.t1_id.ReadOnly = true;
            // 
            // t1_Fname
            // 
            this.t1_Fname.HeaderText = "First Name";
            this.t1_Fname.Name = "t1_Fname";
            this.t1_Fname.ReadOnly = true;
            // 
            // t1_Sname
            // 
            this.t1_Sname.HeaderText = "Last Name";
            this.t1_Sname.Name = "t1_Sname";
            this.t1_Sname.ReadOnly = true;
            // 
            // t1_DOB
            // 
            this.t1_DOB.HeaderText = "DOB";
            this.t1_DOB.Name = "t1_DOB";
            this.t1_DOB.ReadOnly = true;
            // 
            // t1_BPL
            // 
            this.t1_BPL.HeaderText = "BPL";
            this.t1_BPL.Name = "t1_BPL";
            this.t1_BPL.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t2_id,
            this.t2_Fname,
            this.t2_Sname,
            this.t2_Auto,
            this.t2_Pid});
            this.dataGridView2.Location = new System.Drawing.Point(12, 270);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(543, 228);
            this.dataGridView2.TabIndex = 4;
            // 
            // t2_id
            // 
            this.t2_id.HeaderText = "ID";
            this.t2_id.Name = "t2_id";
            this.t2_id.ReadOnly = true;
            // 
            // t2_Fname
            // 
            this.t2_Fname.HeaderText = "First Name";
            this.t2_Fname.Name = "t2_Fname";
            this.t2_Fname.ReadOnly = true;
            // 
            // t2_Sname
            // 
            this.t2_Sname.HeaderText = "Last Name";
            this.t2_Sname.Name = "t2_Sname";
            this.t2_Sname.ReadOnly = true;
            // 
            // t2_Auto
            // 
            this.t2_Auto.HeaderText = "Auto";
            this.t2_Auto.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Lada"});
            this.t2_Auto.Name = "t2_Auto";
            this.t2_Auto.ReadOnly = true;
            // 
            // t2_Pid
            // 
            this.t2_Pid.HeaderText = "Parrents ID";
            this.t2_Pid.Name = "t2_Pid";
            this.t2_Pid.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t3_id,
            this.t3_Fname,
            this.t3_Sname,
            this.t3_Coins,
            this.t3_Pid,
            this.t3_Auto});
            this.dataGridView3.Location = new System.Drawing.Point(12, 526);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(543, 255);
            this.dataGridView3.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(605, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 38);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(605, 134);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(81, 38);
            this.buttonDel.TabIndex = 9;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(711, 71);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(81, 38);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // t3_Auto
            // 
            this.t3_Auto.HeaderText = "Column1";
            this.t3_Auto.Name = "t3_Auto";
            this.t3_Auto.ReadOnly = true;
            // 
            // t3_Pid
            // 
            this.t3_Pid.HeaderText = "Parrents ID";
            this.t3_Pid.Name = "t3_Pid";
            this.t3_Pid.ReadOnly = true;
            // 
            // t3_Coins
            // 
            this.t3_Coins.HeaderText = "Coins";
            this.t3_Coins.Name = "t3_Coins";
            this.t3_Coins.ReadOnly = true;
            // 
            // t3_Sname
            // 
            this.t3_Sname.HeaderText = "Last Name";
            this.t3_Sname.Name = "t3_Sname";
            this.t3_Sname.ReadOnly = true;
            // 
            // t3_Fname
            // 
            this.t3_Fname.HeaderText = "First Name";
            this.t3_Fname.Name = "t3_Fname";
            this.t3_Fname.ReadOnly = true;
            // 
            // t3_id
            // 
            this.t3_id.HeaderText = "ID";
            this.t3_id.Name = "t3_id";
            this.t3_id.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 805);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1_Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1_Sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1_DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1_BPL;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2_Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2_Sname;
        private System.Windows.Forms.DataGridViewComboBoxColumn t2_Auto;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2_Pid;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn t3_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn t3_Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn t3_Sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn t3_Coins;
        private System.Windows.Forms.DataGridViewTextBoxColumn t3_Pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn t3_Auto;
    }
}

