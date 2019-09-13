namespace assignment_2
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
            this.itemcomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemcomboBox
            // 
            this.itemcomboBox.FormattingEnabled = true;
            this.itemcomboBox.Items.AddRange(new object[] {
            "Black-120",
            "Cold-100",
            "Hot-90",
            "Reguler-80"});
            this.itemcomboBox.Location = new System.Drawing.Point(254, 109);
            this.itemcomboBox.Name = "itemcomboBox";
            this.itemcomboBox.Size = new System.Drawing.Size(121, 21);
            this.itemcomboBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemcomboBox);
            this.Name = "Form1";
            this.Text = "Coffeshop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox itemcomboBox;
        private System.Windows.Forms.Button button1;
    }
}

