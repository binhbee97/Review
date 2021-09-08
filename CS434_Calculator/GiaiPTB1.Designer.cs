
namespace CS434_Calculator
{
    partial class GiaiPTB1
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
            this.RS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(89, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Giải";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RS
            // 
            this.RS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS.Location = new System.Drawing.Point(186, 290);
            this.RS.Name = "RS";
            this.RS.Size = new System.Drawing.Size(224, 32);
            this.RS.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ket Qua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhap B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhap A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Giai Phuong Trinh Bac 1";
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(186, 147);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(225, 32);
            this.A.TabIndex = 9;
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(186, 189);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(225, 32);
            this.B.TabIndex = 8;
            // 
            // GiaiPTB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A);
            this.Controls.Add(this.B);
            this.Name = "GiaiPTB1";
            this.Text = "GiaiPT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
    }
}