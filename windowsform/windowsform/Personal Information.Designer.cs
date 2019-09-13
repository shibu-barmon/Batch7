namespace windowsform
{
    partial class Personal_Information
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
            this.nameTextbox1 = new System.Windows.Forms.TextBox();
            this.nameTextbox2 = new System.Windows.Forms.TextBox();
            this.nameTextbox3 = new System.Windows.Forms.TextBox();
            this.nameTextbox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.showinformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Father\'sname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mother\'sname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // nameTextbox1
            // 
            this.nameTextbox1.Location = new System.Drawing.Point(286, 42);
            this.nameTextbox1.Name = "nameTextbox1";
            this.nameTextbox1.Size = new System.Drawing.Size(172, 20);
            this.nameTextbox1.TabIndex = 4;
            // 
            // nameTextbox2
            // 
            this.nameTextbox2.Location = new System.Drawing.Point(286, 87);
            this.nameTextbox2.Name = "nameTextbox2";
            this.nameTextbox2.Size = new System.Drawing.Size(172, 20);
            this.nameTextbox2.TabIndex = 5;
            // 
            // nameTextbox3
            // 
            this.nameTextbox3.Location = new System.Drawing.Point(286, 135);
            this.nameTextbox3.Name = "nameTextbox3";
            this.nameTextbox3.Size = new System.Drawing.Size(172, 20);
            this.nameTextbox3.TabIndex = 6;
            // 
            // nameTextbox4
            // 
            this.nameTextbox4.Location = new System.Drawing.Point(286, 180);
            this.nameTextbox4.Name = "nameTextbox4";
            this.nameTextbox4.Size = new System.Drawing.Size(172, 20);
            this.nameTextbox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showinformation
            // 
            this.showinformation.AutoSize = true;
            this.showinformation.Location = new System.Drawing.Point(555, 41);
            this.showinformation.Name = "showinformation";
            this.showinformation.Size = new System.Drawing.Size(83, 13);
            this.showinformation.TabIndex = 9;
            this.showinformation.Text = "showinformation";
            // 
            // Personal_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showinformation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTextbox4);
            this.Controls.Add(this.nameTextbox3);
            this.Controls.Add(this.nameTextbox2);
            this.Controls.Add(this.nameTextbox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Personal_Information";
            this.Text = "Personal_Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextbox1;
        private System.Windows.Forms.TextBox nameTextbox2;
        private System.Windows.Forms.TextBox nameTextbox3;
        private System.Windows.Forms.TextBox nameTextbox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label showinformation;
    }
}