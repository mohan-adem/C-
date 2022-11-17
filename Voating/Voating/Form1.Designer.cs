namespace Voating
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
            this.btnvoating = new System.Windows.Forms.Button();
            this.txtAged = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnvoating
            // 
            this.btnvoating.Location = new System.Drawing.Point(247, 147);
            this.btnvoating.Name = "btnvoating";
            this.btnvoating.Size = new System.Drawing.Size(75, 23);
            this.btnvoating.TabIndex = 0;
            this.btnvoating.Text = "Voating";
            this.btnvoating.UseVisualStyleBackColor = true;
            this.btnvoating.Click += new System.EventHandler(this.btnvoating_Click);
            // 
            // txtAged
            // 
            this.txtAged.AutoSize = true;
            this.txtAged.Location = new System.Drawing.Point(35, 98);
            this.txtAged.Name = "txtAged";
            this.txtAged.Size = new System.Drawing.Size(82, 13);
            this.txtAged.TabIndex = 1;
            this.txtAged.Text = "plese Entre Age";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 2;
            // 
            // frmdemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 193);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAged);
            this.Controls.Add(this.btnvoating);
            this.Name = "frmdemo";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoating;
        private System.Windows.Forms.Label txtAged;
        private System.Windows.Forms.TextBox textBox1;
    }
}

