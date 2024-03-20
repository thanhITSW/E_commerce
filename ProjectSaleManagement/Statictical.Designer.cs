namespace ProjectSaleManagement
{
    partial class Statictical
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
            this.bIncoming = new System.Windows.Forms.Button();
            this.bOutgoing = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // bIncoming
            // 
            this.bIncoming.Location = new System.Drawing.Point(176, 12);
            this.bIncoming.Name = "bIncoming";
            this.bIncoming.Size = new System.Drawing.Size(149, 79);
            this.bIncoming.TabIndex = 0;
            this.bIncoming.Text = "Incoming stock";
            this.bIncoming.UseVisualStyleBackColor = true;
            this.bIncoming.Click += new System.EventHandler(this.bIncoming_Click);
            // 
            // bOutgoing
            // 
            this.bOutgoing.Location = new System.Drawing.Point(670, 12);
            this.bOutgoing.Name = "bOutgoing";
            this.bOutgoing.Size = new System.Drawing.Size(154, 79);
            this.bOutgoing.TabIndex = 1;
            this.bOutgoing.Text = "Outgoing stock";
            this.bOutgoing.UseVisualStyleBackColor = true;
            this.bOutgoing.Click += new System.EventHandler(this.bOutgoing_Click);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(12, 117);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 28;
            this.grd.Size = new System.Drawing.Size(1015, 441);
            this.grd.TabIndex = 2;
            // 
            // Statictical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 570);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.bOutgoing);
            this.Controls.Add(this.bIncoming);
            this.Name = "Statictical";
            this.Text = "Statictical";
            this.Load += new System.EventHandler(this.Statictical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bIncoming;
        private System.Windows.Forms.Button bOutgoing;
        private System.Windows.Forms.DataGridView grd;
    }
}