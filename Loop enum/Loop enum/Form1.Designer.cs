namespace Loop_enum
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
            this.btnloopenum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnloopenum
            // 
            this.btnloopenum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnloopenum.Location = new System.Drawing.Point(365, 178);
            this.btnloopenum.Name = "btnloopenum";
            this.btnloopenum.Size = new System.Drawing.Size(98, 23);
            this.btnloopenum.TabIndex = 0;
            this.btnloopenum.Text = "LoopEnum";
            this.btnloopenum.UseVisualStyleBackColor = true;
            this.btnloopenum.Click += new System.EventHandler(this.btnloopenum_Click);
            // 
            // frmdemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Loop_enum.Properties.Resources.duuliye;
            this.ClientSize = new System.Drawing.Size(818, 375);
            this.Controls.Add(this.btnloopenum);
            this.Name = "frmdemo";
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnloopenum;
    }
}

