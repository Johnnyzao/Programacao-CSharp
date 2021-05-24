namespace E13
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
            this.lbl_res = new System.Windows.Forms.Label();
            this.Btt_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_res.Location = new System.Drawing.Point(12, 72);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(20, 24);
            this.lbl_res.TabIndex = 0;
            this.lbl_res.Text = "x";
            // 
            // Btt_go
            // 
            this.Btt_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btt_go.Location = new System.Drawing.Point(12, 12);
            this.Btt_go.Name = "Btt_go";
            this.Btt_go.Size = new System.Drawing.Size(505, 57);
            this.Btt_go.TabIndex = 1;
            this.Btt_go.Text = "Go!";
            this.Btt_go.UseVisualStyleBackColor = true;
            this.Btt_go.Click += new System.EventHandler(this.Btt_go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 348);
            this.Controls.Add(this.Btt_go);
            this.Controls.Add(this.lbl_res);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button Btt_go;
    }
}

