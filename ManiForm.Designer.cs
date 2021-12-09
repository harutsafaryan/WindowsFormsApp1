
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    partial class ManiForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.stringlstBx = new System.Windows.Forms.ListBox();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // stringlstBx
            // 
            this.stringlstBx.FormattingEnabled = true;
            this.stringlstBx.Location = new System.Drawing.Point(31, 86);
            this.stringlstBx.Name = "stringlstBx";
            this.stringlstBx.Size = new System.Drawing.Size(124, 199);
            this.stringlstBx.TabIndex = 2;
            // 
            // textBox1
            // 
            this.txtBx.Location = new System.Drawing.Point(31, 60);
            this.txtBx.Name = "textBox1";
            this.txtBx.Size = new System.Drawing.Size(124, 20);
            this.txtBx.TabIndex = 3;
            this.txtBx.TextChanged += TxtBx_TextChanged;
            // 
            // ManiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.stringlstBx);
            this.Controls.Add(this.button1);
            this.Name = "ManiForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.ManiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TxtBx_TextChanged(object sender, System.EventArgs e)
        {
            List<string> source = new List<string> { "lok", "mlo", "klop", "loc", "alo", "look", "lamp", "lov", "lop", "aslo", "sdtg", "bslo", "dslo" };
            string temp = txtBx.Text;

            var result = source.Where(x => x.StartsWith(temp)).OrderBy(x => temp)
                            .Union(source.Where(x => x.Contains(temp)).OrderBy(x => x)).ToList();

            stringlstBx.DataSource = result;

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox stringlstBx;
        private System.Windows.Forms.TextBox txtBx;
    }
}

