﻿
namespace CS434_Calculator
{
    partial class Menu
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
            this.btnGiaiPTB1 = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnGiaiPTB2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiaiPTB1
            // 
            this.btnGiaiPTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiPTB1.Location = new System.Drawing.Point(83, 39);
            this.btnGiaiPTB1.Name = "btnGiaiPTB1";
            this.btnGiaiPTB1.Size = new System.Drawing.Size(272, 60);
            this.btnGiaiPTB1.TabIndex = 0;
            this.btnGiaiPTB1.Text = "Giải Phương Trình Bậc 1";
            this.btnGiaiPTB1.UseVisualStyleBackColor = true;
            this.btnGiaiPTB1.Click += new System.EventHandler(this.btnGiaiPTB1_Click);
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(83, 221);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(272, 60);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "Calculator";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnGiaiPTB2
            // 
            this.btnGiaiPTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiPTB2.Location = new System.Drawing.Point(84, 132);
            this.btnGiaiPTB2.Name = "btnGiaiPTB2";
            this.btnGiaiPTB2.Size = new System.Drawing.Size(272, 60);
            this.btnGiaiPTB2.TabIndex = 2;
            this.btnGiaiPTB2.Text = "Giải Phương Trình Bậc 2";
            this.btnGiaiPTB2.UseVisualStyleBackColor = true;
            this.btnGiaiPTB2.Click += new System.EventHandler(this.btnGiaiPTB2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 325);
            this.Controls.Add(this.btnGiaiPTB2);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnGiaiPTB1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGiaiPTB1;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnGiaiPTB2;
    }
}