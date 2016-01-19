namespace Polynomial_Solver
{
    partial class Main
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
            this.solveBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.AtxtBox = new System.Windows.Forms.TextBox();
            this.BtxtBox = new System.Windows.Forms.TextBox();
            this.CtxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x1txtbx = new System.Windows.Forms.TextBox();
            this.x2txtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.abtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // solveBtn
            // 
            this.solveBtn.BackColor = System.Drawing.Color.LightBlue;
            this.solveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.solveBtn.FlatAppearance.BorderSize = 3;
            this.solveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveBtn.Location = new System.Drawing.Point(111, 442);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(151, 75);
            this.solveBtn.TabIndex = 3;
            this.solveBtn.Text = "SOLVE";
            this.solveBtn.UseVisualStyleBackColor = false;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.LightBlue;
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetBtn.FlatAppearance.BorderSize = 3;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(294, 442);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(151, 75);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // AtxtBox
            // 
            this.AtxtBox.Location = new System.Drawing.Point(81, 197);
            this.AtxtBox.Name = "AtxtBox";
            this.AtxtBox.Size = new System.Drawing.Size(100, 25);
            this.AtxtBox.TabIndex = 0;
            this.AtxtBox.Text = "Enter A";
            this.AtxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AtxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AtxtBox_MouseClick);
            this.AtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AtxtBox_KeyPress);
            this.AtxtBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AtxtBox_MouseDoubleClick);
            // 
            // BtxtBox
            // 
            this.BtxtBox.Location = new System.Drawing.Point(228, 197);
            this.BtxtBox.Name = "BtxtBox";
            this.BtxtBox.Size = new System.Drawing.Size(100, 25);
            this.BtxtBox.TabIndex = 1;
            this.BtxtBox.Text = "Enter B";
            this.BtxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtxtBox_MouseClick);
            this.BtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtxtBox_KeyPress);
            this.BtxtBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtxtBox_MouseDoubleClick);
            // 
            // CtxtBox
            // 
            this.CtxtBox.Location = new System.Drawing.Point(375, 197);
            this.CtxtBox.Name = "CtxtBox";
            this.CtxtBox.Size = new System.Drawing.Size(100, 25);
            this.CtxtBox.TabIndex = 2;
            this.CtxtBox.Text = "Enter C";
            this.CtxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CtxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CtxtBox_MouseClick);
            this.CtxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CtxtBox_KeyPress);
            this.CtxtBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CtxtBox_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter the coefficients of the polynomial and follow the standard form:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ax^2  +  Bx  +  C  =  0";
            // 
            // x1txtbx
            // 
            this.x1txtbx.BackColor = System.Drawing.Color.White;
            this.x1txtbx.Cursor = System.Windows.Forms.Cursors.Default;
            this.x1txtbx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1txtbx.Location = new System.Drawing.Point(169, 278);
            this.x1txtbx.Name = "x1txtbx";
            this.x1txtbx.ReadOnly = true;
            this.x1txtbx.Size = new System.Drawing.Size(219, 25);
            this.x1txtbx.TabIndex = 5;
            this.x1txtbx.TabStop = false;
            this.x1txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x2txtbx
            // 
            this.x2txtbx.BackColor = System.Drawing.Color.White;
            this.x2txtbx.Cursor = System.Windows.Forms.Cursors.Default;
            this.x2txtbx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2txtbx.Location = new System.Drawing.Point(169, 322);
            this.x2txtbx.Name = "x2txtbx";
            this.x2txtbx.ReadOnly = true;
            this.x2txtbx.Size = new System.Drawing.Size(219, 25);
            this.x2txtbx.TabIndex = 6;
            this.x2txtbx.TabStop = false;
            this.x2txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "x1 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "x2 =";
            // 
            // abtBtn
            // 
            this.abtBtn.BackColor = System.Drawing.Color.Transparent;
            this.abtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtBtn.Location = new System.Drawing.Point(486, 555);
            this.abtBtn.Name = "abtBtn";
            this.abtBtn.Size = new System.Drawing.Size(59, 32);
            this.abtBtn.TabIndex = 8;
            this.abtBtn.Text = "About";
            this.abtBtn.UseVisualStyleBackColor = false;
            this.abtBtn.Click += new System.EventHandler(this.abtBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(557, 599);
            this.Controls.Add(this.abtBtn);
            this.Controls.Add(this.AtxtBox);
            this.Controls.Add(this.BtxtBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x2txtbx);
            this.Controls.Add(this.x1txtbx);
            this.Controls.Add(this.CtxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second Order Homogeneous Polynomial Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox AtxtBox;
        private System.Windows.Forms.TextBox BtxtBox;
        private System.Windows.Forms.TextBox CtxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x1txtbx;
        private System.Windows.Forms.TextBox x2txtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button abtBtn;

    }
}

