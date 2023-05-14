namespace nyoba
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.txtBox_abv = new System.Windows.Forms.TextBox();
            this.txtBox_Nation = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_iddelete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_nationupdate = new System.Windows.Forms.TextBox();
            this.txtBox_abvupdate = new System.Windows.Forms.TextBox();
            this.txtBox_idupdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(128, 52);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(100, 20);
            this.txtBox_id.TabIndex = 1;
            // 
            // txtBox_abv
            // 
            this.txtBox_abv.Location = new System.Drawing.Point(128, 78);
            this.txtBox_abv.Name = "txtBox_abv";
            this.txtBox_abv.Size = new System.Drawing.Size(100, 20);
            this.txtBox_abv.TabIndex = 2;
            // 
            // txtBox_Nation
            // 
            this.txtBox_Nation.Location = new System.Drawing.Point(128, 104);
            this.txtBox_Nation.Name = "txtBox_Nation";
            this.txtBox_Nation.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Nation.TabIndex = 3;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(128, 130);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Abbrevation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nation";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(128, 262);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(128, 335);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID";
            // 
            // txtBox_iddelete
            // 
            this.txtBox_iddelete.Enabled = false;
            this.txtBox_iddelete.Location = new System.Drawing.Point(128, 309);
            this.txtBox_iddelete.Name = "txtBox_iddelete";
            this.txtBox_iddelete.Size = new System.Drawing.Size(100, 20);
            this.txtBox_iddelete.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Abbrevation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID";
            // 
            // txtBox_nationupdate
            // 
            this.txtBox_nationupdate.Location = new System.Drawing.Point(128, 236);
            this.txtBox_nationupdate.Name = "txtBox_nationupdate";
            this.txtBox_nationupdate.Size = new System.Drawing.Size(100, 20);
            this.txtBox_nationupdate.TabIndex = 14;
            // 
            // txtBox_abvupdate
            // 
            this.txtBox_abvupdate.Location = new System.Drawing.Point(128, 210);
            this.txtBox_abvupdate.Name = "txtBox_abvupdate";
            this.txtBox_abvupdate.Size = new System.Drawing.Size(100, 20);
            this.txtBox_abvupdate.TabIndex = 13;
            // 
            // txtBox_idupdate
            // 
            this.txtBox_idupdate.Enabled = false;
            this.txtBox_idupdate.Location = new System.Drawing.Point(128, 184);
            this.txtBox_idupdate.Name = "txtBox_idupdate";
            this.txtBox_idupdate.Size = new System.Drawing.Size(100, 20);
            this.txtBox_idupdate.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBox_nationupdate);
            this.Controls.Add(this.txtBox_abvupdate);
            this.Controls.Add(this.txtBox_idupdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_iddelete);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txtBox_Nation);
            this.Controls.Add(this.txtBox_abv);
            this.Controls.Add(this.txtBox_id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.TextBox txtBox_abv;
        private System.Windows.Forms.TextBox txtBox_Nation;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_iddelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_nationupdate;
        private System.Windows.Forms.TextBox txtBox_abvupdate;
        private System.Windows.Forms.TextBox txtBox_idupdate;
    }
}

