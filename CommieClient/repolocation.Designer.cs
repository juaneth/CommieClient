﻿
namespace CommieClient
{
    partial class repolocation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_woc1 = new ePOSOne.btnProduct.Button_WOC();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(174, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome!";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(137, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(203, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Input path to repo file below:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(80, 150);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(336, 27);
			this.textBox1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(80, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(336, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "default is the repo folder in the installation folder";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
			this.panel1.Controls.Add(this.button_woc1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(485, 267);
			this.panel1.TabIndex = 5;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button_woc1
			// 
			this.button_woc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
			this.button_woc1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
			this.button_woc1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
			this.button_woc1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
			this.button_woc1.FlatAppearance.BorderSize = 0;
			this.button_woc1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
			this.button_woc1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
			this.button_woc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_woc1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button_woc1.Location = new System.Drawing.Point(165, 194);
			this.button_woc1.Name = "button_woc1";
			this.button_woc1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
			this.button_woc1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
			this.button_woc1.OnHoverTextColor = System.Drawing.Color.White;
			this.button_woc1.Size = new System.Drawing.Size(175, 61);
			this.button_woc1.TabIndex = 5;
			this.button_woc1.Text = "Continue and save!";
			this.button_woc1.TextColor = System.Drawing.Color.White;
			this.button_woc1.UseVisualStyleBackColor = true;
			this.button_woc1.Click += new System.EventHandler(this.button_woc1_Click);
			// 
			// repolocation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(509, 291);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "repolocation";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CommieClient";
			this.Load += new System.EventHandler(this.CommieClientHome_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private ePOSOne.btnProduct.Button_WOC button_woc1;
	}
}

