namespace Exercicio60
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbResposta = new System.Windows.Forms.TextBox();
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbResposta
            // 
            this.tbResposta.Location = new System.Drawing.Point(250, 57);
            this.tbResposta.Name = "tbResposta";
            this.tbResposta.Size = new System.Drawing.Size(122, 20);
            this.tbResposta.TabIndex = 0;
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Location = new System.Drawing.Point(41, 57);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(0, 13);
            this.lbNum1.TabIndex = 1;
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(186, 57);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(0, 13);
            this.lbNum2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "+";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(146, 129);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submeter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resposta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.Controls.Add(this.tbResposta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResposta;
        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
    }
}

