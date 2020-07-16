namespace Cegkereso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.imageBox = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.other_info = new System.Windows.Forms.Label();
            this.ceg_nev = new System.Windows.Forms.Label();
            this.ceg_szam = new System.Windows.Forms.Label();
            this.map_loc = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.otherRb = new System.Windows.Forms.RadioButton();
            this.cegRb = new System.Windows.Forms.RadioButton();
            this.keresTb = new System.Windows.Forms.TextBox();
            this.keresBtn = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.imageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(503, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 404);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.imageBox);
            this.GroupBox2.Controls.Add(this.label3);
            this.GroupBox2.Controls.Add(this.other_info);
            this.GroupBox2.Controls.Add(this.ceg_nev);
            this.GroupBox2.Controls.Add(this.ceg_szam);
            this.GroupBox2.Controls.Add(this.map_loc);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBox2.Location = new System.Drawing.Point(12, 140);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(485, 328);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Eredmény";
            // 
            // imageBox
            // 
            this.imageBox.Controls.Add(this.PictureBox1);
            this.imageBox.Location = new System.Drawing.Point(252, 18);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(228, 298);
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            this.imageBox.Text = "Térkép részlet";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(19, 28);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(193, 254);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Egyéb:";
            // 
            // other_info
            // 
            this.other_info.AutoSize = true;
            this.other_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.other_info.Location = new System.Drawing.Point(14, 162);
            this.other_info.Name = "other_info";
            this.other_info.Size = new System.Drawing.Size(15, 20);
            this.other_info.TabIndex = 0;
            this.other_info.Text = "-";
            // 
            // ceg_nev
            // 
            this.ceg_nev.AutoSize = true;
            this.ceg_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ceg_nev.Location = new System.Drawing.Point(6, 25);
            this.ceg_nev.Name = "ceg_nev";
            this.ceg_nev.Size = new System.Drawing.Size(16, 20);
            this.ceg_nev.TabIndex = 0;
            this.ceg_nev.Text = "-";
            // 
            // ceg_szam
            // 
            this.ceg_szam.AutoSize = true;
            this.ceg_szam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ceg_szam.Location = new System.Drawing.Point(100, 82);
            this.ceg_szam.Name = "ceg_szam";
            this.ceg_szam.Size = new System.Drawing.Size(17, 24);
            this.ceg_szam.TabIndex = 0;
            this.ceg_szam.Text = "-";
            // 
            // map_loc
            // 
            this.map_loc.AutoSize = true;
            this.map_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.map_loc.Location = new System.Drawing.Point(100, 54);
            this.map_loc.Name = "map_loc";
            this.map_loc.Size = new System.Drawing.Size(17, 24);
            this.map_loc.TabIndex = 0;
            this.map_loc.Text = "-";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.Location = new System.Drawing.Point(14, 57);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 20);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Zóna";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szám:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.otherRb);
            this.GroupBox1.Controls.Add(this.cegRb);
            this.GroupBox1.Controls.Add(this.keresTb);
            this.GroupBox1.Controls.Add(this.keresBtn);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(480, 107);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Hely keresés";
            // 
            // otherRb
            // 
            this.otherRb.AutoSize = true;
            this.otherRb.Location = new System.Drawing.Point(134, 63);
            this.otherRb.Name = "otherRb";
            this.otherRb.Size = new System.Drawing.Size(118, 28);
            this.otherRb.TabIndex = 2;
            this.otherRb.TabStop = true;
            this.otherRb.Text = "Egyéb infó";
            this.otherRb.UseVisualStyleBackColor = true;
            // 
            // cegRb
            // 
            this.cegRb.AutoSize = true;
            this.cegRb.Location = new System.Drawing.Point(18, 63);
            this.cegRb.Name = "cegRb";
            this.cegRb.Size = new System.Drawing.Size(99, 28);
            this.cegRb.TabIndex = 2;
            this.cegRb.TabStop = true;
            this.cegRb.Text = "Cég név";
            this.cegRb.UseVisualStyleBackColor = true;
            // 
            // keresTb
            // 
            this.keresTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keresTb.Location = new System.Drawing.Point(18, 28);
            this.keresTb.Name = "keresTb";
            this.keresTb.Size = new System.Drawing.Size(274, 29);
            this.keresTb.TabIndex = 0;
            this.keresTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keresTb_KeyDown);
            // 
            // keresBtn
            // 
            this.keresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keresBtn.Location = new System.Drawing.Point(310, 28);
            this.keresBtn.Name = "keresBtn";
            this.keresBtn.Size = new System.Drawing.Size(132, 29);
            this.keresBtn.TabIndex = 1;
            this.keresBtn.Text = "Keres";
            this.keresBtn.UseVisualStyleBackColor = true;
            this.keresBtn.Click += new System.EventHandler(this.keresBtn_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label4.Location = new System.Drawing.Point(498, 36);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 25);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Találatok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 481);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cégkereső";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.imageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox listBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.GroupBox imageBox;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label other_info;
        internal System.Windows.Forms.Label ceg_nev;
        internal System.Windows.Forms.Label ceg_szam;
        internal System.Windows.Forms.Label map_loc;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton otherRb;
        internal System.Windows.Forms.RadioButton cegRb;
        internal System.Windows.Forms.TextBox keresTb;
        internal System.Windows.Forms.Button keresBtn;
        internal System.Windows.Forms.Label Label4;
    }
}

