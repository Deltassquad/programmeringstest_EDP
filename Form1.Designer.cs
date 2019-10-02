namespace WindowsApplication1
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
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.Location = new System.Drawing.Point(299, 91);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(160, 225);
            this.ListBox1.TabIndex = 7;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(75, 163);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(120, 20);
            this.TextBox2.TabIndex = 6;
            this.TextBox2.Text = "TextBox2";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(75, 139);
            this.TextBox1.MaxLength = 100;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(120, 20);
            this.TextBox1.TabIndex = 5;
            this.TextBox1.Text = "abc@klm%pz";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(75, 107);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 23);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Replace";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 407);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button Button1;
    }
}

