﻿namespace Biblioteka_AS
{
    partial class Knjige
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
            this.osvjezibtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ispisKnjigetxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // osvjezibtn
            // 
            this.osvjezibtn.Location = new System.Drawing.Point(229, 27);
            this.osvjezibtn.Name = "osvjezibtn";
            this.osvjezibtn.Size = new System.Drawing.Size(75, 23);
            this.osvjezibtn.TabIndex = 7;
            this.osvjezibtn.Text = "Osvježi";
            this.osvjezibtn.UseVisualStyleBackColor = true;
            this.osvjezibtn.Click += new System.EventHandler(this.osvjezibtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sortiraj po:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Naziv",
            "Autor",
            "Godina izdanja"});
            this.comboBox1.Location = new System.Drawing.Point(75, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ispisKnjigetxt
            // 
            this.ispisKnjigetxt.Location = new System.Drawing.Point(12, 56);
            this.ispisKnjigetxt.Name = "ispisKnjigetxt";
            this.ispisKnjigetxt.Size = new System.Drawing.Size(776, 368);
            this.ispisKnjigetxt.TabIndex = 4;
            this.ispisKnjigetxt.Text = "";
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.osvjezibtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ispisKnjigetxt);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button osvjezibtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox ispisKnjigetxt;
    }
}