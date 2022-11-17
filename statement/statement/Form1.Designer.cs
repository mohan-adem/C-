namespace statement
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
            this.lblname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtcheking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(64, 61);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(121, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Please Entre your Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtcheking
            // 
            this.txtcheking.Location = new System.Drawing.Point(298, 131);
            this.txtcheking.Name = "txtcheking";
            this.txtcheking.Size = new System.Drawing.Size(75, 23);
            this.txtcheking.TabIndex = 2;
            this.txtcheking.Text = "Checking";
            this.txtcheking.UseVisualStyleBackColor = true;
            this.txtcheking.Click += new System.EventHandler(this.btncheking_Click);
            // 
            // frmdemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 183);
            this.Controls.Add(this.txtcheking);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblname);
            this.Name = "frmdemo";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button txtcheking;
    }
}

