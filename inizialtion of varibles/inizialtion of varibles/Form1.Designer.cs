namespace inizialtion_of_varibles
{
    partial class frmdemo
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
            this.txtFname = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btncdisplay = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFname
            // 
            this.txtFname.AutoSize = true;
            this.txtFname.Location = new System.Drawing.Point(58, 44);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(119, 13);
            this.txtFname.TabIndex = 0;
            this.txtFname.Text = "please Entre First Name";
            // 
            // txtLname
            // 
            this.txtLname.AutoSize = true;
            this.txtLname.Location = new System.Drawing.Point(58, 103);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(123, 13);
            this.txtLname.TabIndex = 1;
            this.txtLname.Text = "please Entre  Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btncdisplay
            // 
            this.btncdisplay.Location = new System.Drawing.Point(203, 160);
            this.btncdisplay.Name = "btncdisplay";
            this.btncdisplay.Size = new System.Drawing.Size(75, 23);
            this.btncdisplay.TabIndex = 4;
            this.btncdisplay.Text = "Display";
            this.btncdisplay.UseVisualStyleBackColor = true;
            this.btncdisplay.Click += new System.EventHandler(this.btncdisplay_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(399, 160);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // frmdemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 211);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncdisplay);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Name = "frmdemo";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFname;
        private System.Windows.Forms.Label txtLname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btncdisplay;
        private System.Windows.Forms.Button btnclear;
    }
}

