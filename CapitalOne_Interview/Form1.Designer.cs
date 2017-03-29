namespace CapitalOne_Interview
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
            this.btn_Process = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ckbIgnoreDonuts = new System.Windows.Forms.CheckBox();
            this.ckbShowCCPayments = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(22, 28);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(352, 76);
            this.btn_Process.TabIndex = 0;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(2470, 1464);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // ckbIgnoreDonuts
            // 
            this.ckbIgnoreDonuts.AutoSize = true;
            this.ckbIgnoreDonuts.Checked = true;
            this.ckbIgnoreDonuts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIgnoreDonuts.Location = new System.Drawing.Point(443, 53);
            this.ckbIgnoreDonuts.Name = "ckbIgnoreDonuts";
            this.ckbIgnoreDonuts.Size = new System.Drawing.Size(178, 29);
            this.ckbIgnoreDonuts.TabIndex = 2;
            this.ckbIgnoreDonuts.Text = "Ignore Donuts";
            this.ckbIgnoreDonuts.UseVisualStyleBackColor = true;
            // 
            // ckbShowCCPayments
            // 
            this.ckbShowCCPayments.AutoSize = true;
            this.ckbShowCCPayments.Checked = true;
            this.ckbShowCCPayments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbShowCCPayments.Location = new System.Drawing.Point(649, 53);
            this.ckbShowCCPayments.Name = "ckbShowCCPayments";
            this.ckbShowCCPayments.Size = new System.Drawing.Size(313, 29);
            this.ckbShowCCPayments.TabIndex = 3;
            this.ckbShowCCPayments.Text = "Show Credit Card Payments";
            this.ckbShowCCPayments.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2504, 1600);
            this.Controls.Add(this.ckbShowCCPayments);
            this.Controls.Add(this.ckbIgnoreDonuts);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Process);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox ckbIgnoreDonuts;
        private System.Windows.Forms.CheckBox ckbShowCCPayments;
    }
}

