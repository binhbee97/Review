
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
            this.btnGiaiPTB2 = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnGiaiPTB1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiaiPTB2
            // 
            this.btnGiaiPTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiPTB2.Location = new System.Drawing.Point(109, 197);
            this.btnGiaiPTB2.Name = "btnGiaiPTB2";
            this.btnGiaiPTB2.Size = new System.Drawing.Size(272, 60);
            this.btnGiaiPTB2.TabIndex = 5;
            this.btnGiaiPTB2.Text = "Giải Phương Trình Bậc 2";
            this.btnGiaiPTB2.UseVisualStyleBackColor = true;
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(108, 286);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(272, 60);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Calculator";
            this.btnCal.UseVisualStyleBackColor = true;
            // 
            // btnGiaiPTB1
            // 
            this.btnGiaiPTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiPTB1.Location = new System.Drawing.Point(108, 104);
            this.btnGiaiPTB1.Name = "btnGiaiPTB1";
            this.btnGiaiPTB1.Size = new System.Drawing.Size(272, 60);
            this.btnGiaiPTB1.TabIndex = 3;
            this.btnGiaiPTB1.Text = "Giải Phương Trình Bậc 1";
            this.btnGiaiPTB1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.btnGiaiPTB2);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnGiaiPTB1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGiaiPTB2;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnGiaiPTB1;
    }
}