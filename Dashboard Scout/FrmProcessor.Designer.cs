namespace Dashboard_Scout
{
    partial class FrmProcessor
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_txt1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_txt2 = new System.Windows.Forms.Label();
            this.lbl_txt3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard_Scout.Properties.Resources.Novo_Projeto__20_;
            this.pictureBox1.Location = new System.Drawing.Point(293, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(7, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Details of Last 28 Days";
            // 
            // lbl_txt1
            // 
            this.lbl_txt1.AutoSize = true;
            this.lbl_txt1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_txt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.lbl_txt1.Location = new System.Drawing.Point(7, 9);
            this.lbl_txt1.Name = "lbl_txt1";
            this.lbl_txt1.Size = new System.Drawing.Size(123, 38);
            this.lbl_txt1.TabIndex = 5;
            this.lbl_txt1.Text = "R$ 1234";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(332, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPU";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_txt2
            // 
            this.lbl_txt2.AutoSize = true;
            this.lbl_txt2.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_txt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.lbl_txt2.Location = new System.Drawing.Point(12, 65);
            this.lbl_txt2.Name = "lbl_txt2";
            this.lbl_txt2.Size = new System.Drawing.Size(123, 38);
            this.lbl_txt2.TabIndex = 8;
            this.lbl_txt2.Text = "R$ 1234";
            // 
            // lbl_txt3
            // 
            this.lbl_txt3.AutoSize = true;
            this.lbl_txt3.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_txt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.lbl_txt3.Location = new System.Drawing.Point(12, 119);
            this.lbl_txt3.Name = "lbl_txt3";
            this.lbl_txt3.Size = new System.Drawing.Size(123, 38);
            this.lbl_txt3.TabIndex = 9;
            this.lbl_txt3.Text = "R$ 1234";
            // 
            // FrmProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(401, 199);
            this.Controls.Add(this.lbl_txt3);
            this.Controls.Add(this.lbl_txt2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_txt1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProcessor";
            this.Text = "FrmProcessor";
            this.Load += new System.EventHandler(this.FrmProcessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label lbl_txt1;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_txt2;
        private Label lbl_txt3;
    }
}