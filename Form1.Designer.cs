namespace MySQLtest01
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.NAMEinsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.insertbt = new System.Windows.Forms.Button();
            this.IDdelete = new System.Windows.Forms.TextBox();
            this.NAMEdelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deletebt = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.namechangebt = new System.Windows.Forms.Button();
            this.NAMEupdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IDupdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IDchangebt = new System.Windows.Forms.Button();
            this.selectbt = new System.Windows.Forms.Button();
            this.situationtext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkIDtext = new System.Windows.Forms.TextBox();
            this.checkNAMEtext = new System.Windows.Forms.TextBox();
            this.checkID = new System.Windows.Forms.Button();
            this.checkNAME = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // NAMEinsert
            // 
            this.NAMEinsert.Location = new System.Drawing.Point(12, 30);
            this.NAMEinsert.Name = "NAMEinsert";
            this.NAMEinsert.Size = new System.Drawing.Size(100, 25);
            this.NAMEinsert.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "称号";
            // 
            // insertbt
            // 
            this.insertbt.Location = new System.Drawing.Point(37, 89);
            this.insertbt.Name = "insertbt";
            this.insertbt.Size = new System.Drawing.Size(75, 23);
            this.insertbt.TabIndex = 5;
            this.insertbt.Text = "增";
            this.insertbt.UseVisualStyleBackColor = true;
            this.insertbt.Click += new System.EventHandler(this.insertbt_Click);
            // 
            // IDdelete
            // 
            this.IDdelete.Location = new System.Drawing.Point(195, 27);
            this.IDdelete.Name = "IDdelete";
            this.IDdelete.Size = new System.Drawing.Size(100, 25);
            this.IDdelete.TabIndex = 6;
            // 
            // NAMEdelete
            // 
            this.NAMEdelete.Location = new System.Drawing.Point(195, 61);
            this.NAMEdelete.Name = "NAMEdelete";
            this.NAMEdelete.Size = new System.Drawing.Size(100, 25);
            this.NAMEdelete.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "称号";
            // 
            // deletebt
            // 
            this.deletebt.Location = new System.Drawing.Point(220, 92);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(75, 23);
            this.deletebt.TabIndex = 10;
            this.deletebt.Text = "删";
            this.deletebt.UseVisualStyleBackColor = true;
            this.deletebt.Click += new System.EventHandler(this.deletebt_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(12, 158);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 25);
            this.ID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // namechangebt
            // 
            this.namechangebt.Location = new System.Drawing.Point(37, 220);
            this.namechangebt.Name = "namechangebt";
            this.namechangebt.Size = new System.Drawing.Size(75, 23);
            this.namechangebt.TabIndex = 13;
            this.namechangebt.Text = "改称号";
            this.namechangebt.UseVisualStyleBackColor = true;
            this.namechangebt.Click += new System.EventHandler(this.namechangebt_Click);
            // 
            // NAMEupdate
            // 
            this.NAMEupdate.Location = new System.Drawing.Point(12, 189);
            this.NAMEupdate.Name = "NAMEupdate";
            this.NAMEupdate.Size = new System.Drawing.Size(100, 25);
            this.NAMEupdate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "改称号";
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(12, 282);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(100, 25);
            this.NAME.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "称号";
            // 
            // IDupdate
            // 
            this.IDupdate.Location = new System.Drawing.Point(12, 313);
            this.IDupdate.Name = "IDupdate";
            this.IDupdate.Size = new System.Drawing.Size(100, 25);
            this.IDupdate.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "改ID";
            // 
            // IDchangebt
            // 
            this.IDchangebt.Location = new System.Drawing.Point(37, 344);
            this.IDchangebt.Name = "IDchangebt";
            this.IDchangebt.Size = new System.Drawing.Size(75, 23);
            this.IDchangebt.TabIndex = 20;
            this.IDchangebt.Text = "改ID";
            this.IDchangebt.UseVisualStyleBackColor = true;
            this.IDchangebt.Click += new System.EventHandler(this.IDchangebt_Click);
            // 
            // selectbt
            // 
            this.selectbt.Location = new System.Drawing.Point(195, 160);
            this.selectbt.Name = "selectbt";
            this.selectbt.Size = new System.Drawing.Size(100, 54);
            this.selectbt.TabIndex = 21;
            this.selectbt.Text = "查询数据库";
            this.selectbt.UseVisualStyleBackColor = true;
            this.selectbt.Click += new System.EventHandler(this.selectbt_Click);
            // 
            // situationtext
            // 
            this.situationtext.Location = new System.Drawing.Point(12, 398);
            this.situationtext.Name = "situationtext";
            this.situationtext.Size = new System.Drawing.Size(100, 25);
            this.situationtext.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "功能状况";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(162, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(176, 203);
            this.dataGridView1.TabIndex = 24;
            // 
            // checkIDtext
            // 
            this.checkIDtext.Location = new System.Drawing.Point(12, 465);
            this.checkIDtext.Name = "checkIDtext";
            this.checkIDtext.Size = new System.Drawing.Size(100, 25);
            this.checkIDtext.TabIndex = 25;
            // 
            // checkNAMEtext
            // 
            this.checkNAMEtext.Location = new System.Drawing.Point(195, 465);
            this.checkNAMEtext.Name = "checkNAMEtext";
            this.checkNAMEtext.Size = new System.Drawing.Size(100, 25);
            this.checkNAMEtext.TabIndex = 27;
            // 
            // checkID
            // 
            this.checkID.Location = new System.Drawing.Point(27, 496);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(75, 23);
            this.checkID.TabIndex = 28;
            this.checkID.Text = "按ID查询";
            this.checkID.UseVisualStyleBackColor = true;
            this.checkID.Click += new System.EventHandler(this.checkID_Click);
            // 
            // checkNAME
            // 
            this.checkNAME.Location = new System.Drawing.Point(196, 496);
            this.checkNAME.Name = "checkNAME";
            this.checkNAME.Size = new System.Drawing.Size(99, 23);
            this.checkNAME.TabIndex = 29;
            this.checkNAME.Text = "按称号查询";
            this.checkNAME.UseVisualStyleBackColor = true;
            this.checkNAME.Click += new System.EventHandler(this.checkNAME_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 525);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(326, 102);
            this.dataGridView2.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 633);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.checkNAME);
            this.Controls.Add(this.checkID);
            this.Controls.Add(this.checkNAMEtext);
            this.Controls.Add(this.checkIDtext);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.situationtext);
            this.Controls.Add(this.selectbt);
            this.Controls.Add(this.IDchangebt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IDupdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NAMEupdate);
            this.Controls.Add(this.namechangebt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.deletebt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NAMEdelete);
            this.Controls.Add(this.IDdelete);
            this.Controls.Add(this.insertbt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NAMEinsert);
            this.Name = "Form1";
            this.Text = "mysql";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NAMEinsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertbt;
        private System.Windows.Forms.TextBox IDdelete;
        private System.Windows.Forms.TextBox NAMEdelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletebt;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button namechangebt;
        private System.Windows.Forms.TextBox NAMEupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDupdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button IDchangebt;
        private System.Windows.Forms.Button selectbt;
        private System.Windows.Forms.TextBox situationtext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox checkIDtext;
        private System.Windows.Forms.TextBox checkNAMEtext;
        private System.Windows.Forms.Button checkID;
        private System.Windows.Forms.Button checkNAME;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

