namespace ProjectSaleManagement
{
    partial class GoodDeliveryNote
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTran = new System.Windows.Forms.RadioButton();
            this.rdDeli = new System.Windows.Forms.RadioButton();
            this.rdUnpaid = new System.Windows.Forms.RadioButton();
            this.rdPaid = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.grd2 = new System.Windows.Forms.DataGridView();
            this.bExport = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDeli);
            this.groupBox1.Controls.Add(this.rdTran);
            this.groupBox1.Location = new System.Drawing.Point(27, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oder status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdPaid);
            this.groupBox2.Controls.Add(this.rdUnpaid);
            this.groupBox2.Location = new System.Drawing.Point(27, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment status";
            // 
            // rdTran
            // 
            this.rdTran.AutoSize = true;
            this.rdTran.Location = new System.Drawing.Point(29, 50);
            this.rdTran.Name = "rdTran";
            this.rdTran.Size = new System.Drawing.Size(155, 24);
            this.rdTran.TabIndex = 0;
            this.rdTran.TabStop = true;
            this.rdTran.Text = "being transferred";
            this.rdTran.UseVisualStyleBackColor = true;
            // 
            // rdDeli
            // 
            this.rdDeli.AutoSize = true;
            this.rdDeli.Location = new System.Drawing.Point(29, 107);
            this.rdDeli.Name = "rdDeli";
            this.rdDeli.Size = new System.Drawing.Size(100, 24);
            this.rdDeli.TabIndex = 1;
            this.rdDeli.TabStop = true;
            this.rdDeli.Text = "Delivered";
            this.rdDeli.UseVisualStyleBackColor = true;
            // 
            // rdUnpaid
            // 
            this.rdUnpaid.AutoSize = true;
            this.rdUnpaid.Location = new System.Drawing.Point(29, 44);
            this.rdUnpaid.Name = "rdUnpaid";
            this.rdUnpaid.Size = new System.Drawing.Size(82, 24);
            this.rdUnpaid.TabIndex = 0;
            this.rdUnpaid.TabStop = true;
            this.rdUnpaid.Text = "unpaid";
            this.rdUnpaid.UseVisualStyleBackColor = true;
            // 
            // rdPaid
            // 
            this.rdPaid.AutoSize = true;
            this.rdPaid.Location = new System.Drawing.Point(29, 97);
            this.rdPaid.Name = "rdPaid";
            this.rdPaid.Size = new System.Drawing.Size(64, 24);
            this.rdPaid.TabIndex = 1;
            this.rdPaid.TabStop = true;
            this.rdPaid.Text = "paid";
            this.rdPaid.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grd1);
            this.groupBox3.Location = new System.Drawing.Point(286, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(886, 338);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orders";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd2);
            this.groupBox4.Location = new System.Drawing.Point(12, 528);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1010, 335);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delivery Bill";
            // 
            // grd1
            // 
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Location = new System.Drawing.Point(6, 25);
            this.grd1.Name = "grd1";
            this.grd1.RowHeadersWidth = 62;
            this.grd1.RowTemplate.Height = 28;
            this.grd1.Size = new System.Drawing.Size(864, 307);
            this.grd1.TabIndex = 0;
            // 
            // grd2
            // 
            this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd2.Location = new System.Drawing.Point(6, 25);
            this.grd2.Name = "grd2";
            this.grd2.RowHeadersWidth = 62;
            this.grd2.RowTemplate.Height = 28;
            this.grd2.Size = new System.Drawing.Size(998, 413);
            this.grd2.TabIndex = 0;
            this.grd2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd2_CellClick);
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(163, 431);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(154, 68);
            this.bExport.TabIndex = 4;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(27, 431);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(95, 68);
            this.bEdit.TabIndex = 5;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Delivery";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(134, 26);
            this.txtID.TabIndex = 7;
            // 
            // GoodDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 935);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GoodDeliveryNote";
            this.Text = "Goods_Delivery_Note";
            this.Load += new System.EventHandler(this.GoodDeliveryNote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDeli;
        private System.Windows.Forms.RadioButton rdTran;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdPaid;
        private System.Windows.Forms.RadioButton rdUnpaid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grd1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grd2;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
    }
}