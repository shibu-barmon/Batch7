namespace connectiontowebfrom
{
    partial class order
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
            this.orderShowDataGridView = new System.Windows.Forms.DataGridView();
            this.oderShowBtn = new System.Windows.Forms.Button();
            this.oderSearchBtn = new System.Windows.Forms.Button();
            this.oderUpdateBtn = new System.Windows.Forms.Button();
            this.oderDeleteBtn = new System.Windows.Forms.Button();
            this.oderAddBtn = new System.Windows.Forms.Button();
            this.OrderCustomerNameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPriceTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderItemNameTextbox = new System.Windows.Forms.TextBox();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderIdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderShowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderShowDataGridView
            // 
            this.orderShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderShowDataGridView.Location = new System.Drawing.Point(23, 312);
            this.orderShowDataGridView.Name = "orderShowDataGridView";
            this.orderShowDataGridView.Size = new System.Drawing.Size(648, 174);
            this.orderShowDataGridView.TabIndex = 23;
            // 
            // oderShowBtn
            // 
            this.oderShowBtn.Location = new System.Drawing.Point(210, 250);
            this.oderShowBtn.Name = "oderShowBtn";
            this.oderShowBtn.Size = new System.Drawing.Size(75, 23);
            this.oderShowBtn.TabIndex = 22;
            this.oderShowBtn.Text = "SHOW";
            this.oderShowBtn.UseVisualStyleBackColor = true;
            this.oderShowBtn.Click += new System.EventHandler(this.oderShowBtn_Click);
            // 
            // oderSearchBtn
            // 
            this.oderSearchBtn.Location = new System.Drawing.Point(596, 250);
            this.oderSearchBtn.Name = "oderSearchBtn";
            this.oderSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.oderSearchBtn.TabIndex = 21;
            this.oderSearchBtn.Text = "Search";
            this.oderSearchBtn.UseVisualStyleBackColor = true;
            this.oderSearchBtn.Click += new System.EventHandler(this.oderSearchBtn_Click);
            // 
            // oderUpdateBtn
            // 
            this.oderUpdateBtn.Location = new System.Drawing.Point(464, 250);
            this.oderUpdateBtn.Name = "oderUpdateBtn";
            this.oderUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.oderUpdateBtn.TabIndex = 20;
            this.oderUpdateBtn.Text = "UPDATE";
            this.oderUpdateBtn.UseVisualStyleBackColor = true;
            this.oderUpdateBtn.Click += new System.EventHandler(this.oderUpdateBtn_Click);
            // 
            // oderDeleteBtn
            // 
            this.oderDeleteBtn.Location = new System.Drawing.Point(338, 250);
            this.oderDeleteBtn.Name = "oderDeleteBtn";
            this.oderDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.oderDeleteBtn.TabIndex = 19;
            this.oderDeleteBtn.Text = "DELETE";
            this.oderDeleteBtn.UseVisualStyleBackColor = true;
            this.oderDeleteBtn.Click += new System.EventHandler(this.oderDeleteBtn_Click);
            // 
            // oderAddBtn
            // 
            this.oderAddBtn.Location = new System.Drawing.Point(83, 250);
            this.oderAddBtn.Name = "oderAddBtn";
            this.oderAddBtn.Size = new System.Drawing.Size(75, 23);
            this.oderAddBtn.TabIndex = 18;
            this.oderAddBtn.Text = "ADD";
            this.oderAddBtn.UseVisualStyleBackColor = true;
            this.oderAddBtn.Click += new System.EventHandler(this.oderAddBtn_Click);
            // 
            // OrderCustomerNameTextbox
            // 
            this.OrderCustomerNameTextbox.Location = new System.Drawing.Point(248, 186);
            this.OrderCustomerNameTextbox.Name = "OrderCustomerNameTextbox";
            this.OrderCustomerNameTextbox.Size = new System.Drawing.Size(227, 20);
            this.OrderCustomerNameTextbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer Name";
            // 
            // totalPriceTextbox
            // 
            this.totalPriceTextbox.Location = new System.Drawing.Point(248, 147);
            this.totalPriceTextbox.Name = "totalPriceTextbox";
            this.totalPriceTextbox.Size = new System.Drawing.Size(227, 20);
            this.totalPriceTextbox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Price";
            // 
            // orderItemNameTextbox
            // 
            this.orderItemNameTextbox.Location = new System.Drawing.Point(248, 65);
            this.orderItemNameTextbox.Name = "orderItemNameTextbox";
            this.orderItemNameTextbox.Size = new System.Drawing.Size(227, 20);
            this.orderItemNameTextbox.TabIndex = 15;
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(248, 107);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(227, 20);
            this.quantityTextbox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantity";
            // 
            // orderIdTextbox
            // 
            this.orderIdTextbox.Location = new System.Drawing.Point(248, 24);
            this.orderIdTextbox.Name = "orderIdTextbox";
            this.orderIdTextbox.Size = new System.Drawing.Size(227, 20);
            this.orderIdTextbox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Order Id";
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.orderShowDataGridView);
            this.Controls.Add(this.oderShowBtn);
            this.Controls.Add(this.oderSearchBtn);
            this.Controls.Add(this.oderUpdateBtn);
            this.Controls.Add(this.oderDeleteBtn);
            this.Controls.Add(this.oderAddBtn);
            this.Controls.Add(this.OrderCustomerNameTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalPriceTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderItemNameTextbox);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderIdTextbox);
            this.Controls.Add(this.label1);
            this.Name = "order";
            this.Text = "order";
            ((System.ComponentModel.ISupportInitialize)(this.orderShowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderShowDataGridView;
        private System.Windows.Forms.Button oderShowBtn;
        private System.Windows.Forms.Button oderSearchBtn;
        private System.Windows.Forms.Button oderUpdateBtn;
        private System.Windows.Forms.Button oderDeleteBtn;
        private System.Windows.Forms.Button oderAddBtn;
        private System.Windows.Forms.TextBox OrderCustomerNameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalPriceTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orderItemNameTextbox;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderIdTextbox;
        private System.Windows.Forms.Label label1;
    }
}