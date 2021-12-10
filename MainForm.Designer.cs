
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.stringlstBx = new System.Windows.Forms.ListBox();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.newTxtBx = new System.Windows.Forms.TextBox();
            this.newStringLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(348, 75);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += AddBtn_Click;
            // 
            // stringlstBx
            // 
            this.stringlstBx.FormattingEnabled = true;
            this.stringlstBx.Location = new System.Drawing.Point(57, 101);
            this.stringlstBx.Name = "stringlstBx";
            this.stringlstBx.Size = new System.Drawing.Size(124, 199);
            this.stringlstBx.TabIndex = 2;
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(57, 75);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(124, 20);
            this.txtBx.TabIndex = 3;
            this.txtBx.TextChanged += TxtBx_TextChanged;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(57, 56);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(39, 13);
            this.searchLbl.TabIndex = 4;
            this.searchLbl.Text = "search";
            // 
            // textBox1
            // 
            this.newTxtBx.Location = new System.Drawing.Point(203, 75);
            this.newTxtBx.Name = "newTxtBx";
            this.newTxtBx.Size = new System.Drawing.Size(121, 20);
            this.newTxtBx.TabIndex = 5;
            // 
            // label1
            // 
            this.newStringLbl.AutoSize = true;
            this.newStringLbl.Location = new System.Drawing.Point(203, 55);
            this.newStringLbl.Name = "label1";
            this.newStringLbl.Size = new System.Drawing.Size(35, 13);
            this.newStringLbl.TabIndex = 6;
            this.newStringLbl.Text = "new string";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 332);
            this.Controls.Add(this.newStringLbl);
            this.Controls.Add(this.newTxtBx);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.stringlstBx);
            this.Controls.Add(this.addBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.ManiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddBtn_Click(object sender, System.EventArgs e)
        {
            string text = newTxtBx.Text;
            if (text == "")
                return;
            else
            {
                source.Add(text);
                stringlstBx.DataSource = source;
            }
        }

        private void TxtBx_TextChanged(object sender, System.EventArgs e)
        {
            string inputString = txtBx.Text;

            var result = source.Where(x => x.StartsWith(inputString)).OrderBy(x => inputString)
                               .Union(source.Where(x => x.Contains(inputString)).OrderBy(x => x)).ToList();

            stringlstBx.DataSource = result;
        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox stringlstBx;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox newTxtBx;
        private System.Windows.Forms.Label newStringLbl;
    }
}

