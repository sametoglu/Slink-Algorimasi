namespace veri_maden_33
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
            this.btn_hesap = new System.Windows.Forms.Button();
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_tablo = new System.Windows.Forms.ListBox();
            this.label0 = new System.Windows.Forms.Label();
            this.nud_k = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_k)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hesap
            // 
            this.btn_hesap.Location = new System.Drawing.Point(606, 38);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(120, 23);
            this.btn_hesap.TabIndex = 1;
            this.btn_hesap.Text = "Hesap";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // drawingArea
            // 
            this.drawingArea.Location = new System.Drawing.Point(12, 12);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(485, 500);
            this.drawingArea.TabIndex = 2;
            this.drawingArea.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E";
            // 
            // lb_tablo
            // 
            this.lb_tablo.FormattingEnabled = true;
            this.lb_tablo.Location = new System.Drawing.Point(503, 365);
            this.lb_tablo.Name = "lb_tablo";
            this.lb_tablo.Size = new System.Drawing.Size(223, 147);
            this.lb_tablo.TabIndex = 7;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(225, 50);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(14, 13);
            this.label0.TabIndex = 8;
            this.label0.Text = "A";
            // 
            // nud_k
            // 
            this.nud_k.Location = new System.Drawing.Point(606, 12);
            this.nud_k.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_k.Name = "nud_k";
            this.nud_k.Size = new System.Drawing.Size(120, 20);
            this.nud_k.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 518);
            this.Controls.Add(this.nud_k);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.lb_tablo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.btn_hesap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_k)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hesap;
        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_tablo;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.NumericUpDown nud_k;
    }
}

