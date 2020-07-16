namespace Cegkereso
{
    partial class Leltar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leltar));
            this.numCb = new System.Windows.Forms.ComboBox();
            this.zoneCb = new System.Windows.Forms.ComboBox();
            this.felvitelBtn = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.egyebTb = new System.Windows.Forms.TextBox();
            this.cegTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numCb
            // 
            this.numCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numCb.FormattingEnabled = true;
            this.numCb.Location = new System.Drawing.Point(143, 95);
            this.numCb.Name = "numCb";
            this.numCb.Size = new System.Drawing.Size(105, 32);
            this.numCb.TabIndex = 2;
            // 
            // zoneCb
            // 
            this.zoneCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zoneCb.FormattingEnabled = true;
            this.zoneCb.Location = new System.Drawing.Point(9, 95);
            this.zoneCb.Name = "zoneCb";
            this.zoneCb.Size = new System.Drawing.Size(99, 32);
            this.zoneCb.TabIndex = 1;
            // 
            // felvitelBtn
            // 
            this.felvitelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.felvitelBtn.Location = new System.Drawing.Point(64, 312);
            this.felvitelBtn.Name = "felvitelBtn";
            this.felvitelBtn.Size = new System.Drawing.Size(135, 29);
            this.felvitelBtn.TabIndex = 4;
            this.felvitelBtn.Text = "Új cég felvitele";
            this.felvitelBtn.UseVisualStyleBackColor = true;
            this.felvitelBtn.Click += new System.EventHandler(this.felvitelBtn_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label5.Location = new System.Drawing.Point(4, 130);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(114, 25);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Egyéb infó";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label6.Location = new System.Drawing.Point(138, 67);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(120, 25);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Számozás*";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.Location = new System.Drawing.Point(4, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 25);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Zóna*";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(4, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 25);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Cég neve*";
            // 
            // egyebTb
            // 
            this.egyebTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.egyebTb.Location = new System.Drawing.Point(9, 158);
            this.egyebTb.Multiline = true;
            this.egyebTb.Name = "egyebTb";
            this.egyebTb.Size = new System.Drawing.Size(239, 125);
            this.egyebTb.TabIndex = 3;
            // 
            // cegTb
            // 
            this.cegTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegTb.Location = new System.Drawing.Point(9, 35);
            this.cegTb.Name = "cegTb";
            this.cegTb.Size = new System.Drawing.Size(239, 29);
            this.cegTb.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "(vesszővel elválasztva kell felsorolni az infókat)";
            // 
            // Leltar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCb);
            this.Controls.Add(this.zoneCb);
            this.Controls.Add(this.felvitelBtn);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.egyebTb);
            this.Controls.Add(this.cegTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Leltar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leltár";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Leltar_FormClosed);
            this.Load += new System.EventHandler(this.Leltar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox numCb;
        internal System.Windows.Forms.ComboBox zoneCb;
        internal System.Windows.Forms.Button felvitelBtn;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox egyebTb;
        internal System.Windows.Forms.TextBox cegTb;
        private System.Windows.Forms.Label label3;
    }
}