namespace ProjectSaleManagement
{
    partial class Function
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
            this.bItem = new System.Windows.Forms.Button();
            this.bGR = new System.Windows.Forms.Button();
            this.bStatictical = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bRevenue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bItem
            // 
            this.bItem.Location = new System.Drawing.Point(98, 60);
            this.bItem.Name = "bItem";
            this.bItem.Size = new System.Drawing.Size(149, 65);
            this.bItem.TabIndex = 0;
            this.bItem.Text = "Item Management";
            this.bItem.UseVisualStyleBackColor = true;
            this.bItem.Click += new System.EventHandler(this.bItem_Click);
            // 
            // bGR
            // 
            this.bGR.Location = new System.Drawing.Point(449, 60);
            this.bGR.Name = "bGR";
            this.bGR.Size = new System.Drawing.Size(171, 65);
            this.bGR.TabIndex = 1;
            this.bGR.Text = "Good Received";
            this.bGR.UseVisualStyleBackColor = true;
            this.bGR.Click += new System.EventHandler(this.bGR_Click);
            // 
            // bStatictical
            // 
            this.bStatictical.Location = new System.Drawing.Point(91, 265);
            this.bStatictical.Name = "bStatictical";
            this.bStatictical.Size = new System.Drawing.Size(156, 71);
            this.bStatictical.TabIndex = 2;
            this.bStatictical.Text = "Statictical";
            this.bStatictical.UseVisualStyleBackColor = true;
            this.bStatictical.Click += new System.EventHandler(this.bStatictical_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(274, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 71);
            this.button4.TabIndex = 3;
            this.button4.Text = "Good Delivery Note";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bRevenue
            // 
            this.bRevenue.Location = new System.Drawing.Point(449, 277);
            this.bRevenue.Name = "bRevenue";
            this.bRevenue.Size = new System.Drawing.Size(171, 78);
            this.bRevenue.TabIndex = 4;
            this.bRevenue.Text = "Revenue report monthly";
            this.bRevenue.UseVisualStyleBackColor = true;
            this.bRevenue.Click += new System.EventHandler(this.bRevenue_Click);
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRevenue);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bStatictical);
            this.Controls.Add(this.bGR);
            this.Controls.Add(this.bItem);
            this.Name = "Function";
            this.Text = "Sale management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bItem;
        private System.Windows.Forms.Button bGR;
        private System.Windows.Forms.Button bStatictical;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bRevenue;
    }
}