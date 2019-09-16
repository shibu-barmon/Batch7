namespace Assignment2
{
    partial class coffeshop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.Contacttextbox = new System.Windows.Forms.TextBox();
            this.Addressbox = new System.Windows.Forms.TextBox();
            this.quantbox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.orderbox = new System.Windows.Forms.ComboBox();
            this.perorderpriceTextbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.showrichtextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(226, 72);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(223, 20);
            this.nametextbox.TabIndex = 6;
            this.nametextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Contacttextbox
            // 
            this.Contacttextbox.Location = new System.Drawing.Point(226, 113);
            this.Contacttextbox.Name = "Contacttextbox";
            this.Contacttextbox.Size = new System.Drawing.Size(223, 20);
            this.Contacttextbox.TabIndex = 7;
            // 
            // Addressbox
            // 
            this.Addressbox.Location = new System.Drawing.Point(226, 158);
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.Size = new System.Drawing.Size(223, 20);
            this.Addressbox.TabIndex = 8;
            // 
            // quantbox
            // 
            this.quantbox.Location = new System.Drawing.Point(226, 242);
            this.quantbox.Name = "quantbox";
            this.quantbox.Size = new System.Drawing.Size(223, 20);
            this.quantbox.TabIndex = 9;
            this.quantbox.TextChanged += new System.EventHandler(this.quantbox_TextChanged);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(241, 305);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(130, 39);
            this.save.TabIndex = 11;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // orderbox
            // 
            this.orderbox.FormattingEnabled = true;
            this.orderbox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderbox.Location = new System.Drawing.Point(226, 204);
            this.orderbox.Name = "orderbox";
            this.orderbox.Size = new System.Drawing.Size(223, 21);
            this.orderbox.TabIndex = 13;
            // 
            // perorderpriceTextbox
            // 
            this.perorderpriceTextbox.Location = new System.Drawing.Point(226, 279);
            this.perorderpriceTextbox.Name = "perorderpriceTextbox";
            this.perorderpriceTextbox.Size = new System.Drawing.Size(223, 20);
            this.perorderpriceTextbox.TabIndex = 9;
            this.perorderpriceTextbox.TextChanged += new System.EventHandler(this.quantbox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(87, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "per order price";
            // 
            // showrichtextbox
            // 
            this.showrichtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showrichtextbox.Location = new System.Drawing.Point(522, 66);
            this.showrichtextbox.Name = "showrichtextbox";
            this.showrichtextbox.Size = new System.Drawing.Size(250, 317);
            this.showrichtextbox.TabIndex = 12;
            this.showrichtextbox.Text = "";
            // 
            // coffeshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderbox);
            this.Controls.Add(this.showrichtextbox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.perorderpriceTextbox);
            this.Controls.Add(this.quantbox);
            this.Controls.Add(this.Addressbox);
            this.Controls.Add(this.Contacttextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "coffeshop";
            this.Text = "coffeshop";
            this.Load += new System.EventHandler(this.coffeshop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox Contacttextbox;
        private System.Windows.Forms.TextBox Addressbox;
        private System.Windows.Forms.TextBox quantbox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox orderbox;
        private System.Windows.Forms.TextBox perorderpriceTextbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox showrichtextbox;
    }
}

