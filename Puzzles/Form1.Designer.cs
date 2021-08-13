
namespace Puzzles
{
    partial class Form1
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
            this.pnl_ctrl = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_load_puz = new System.Windows.Forms.Button();
            this.btn_sel_img = new System.Windows.Forms.Button();
            this.btn_auto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_6 = new System.Windows.Forms.RadioButton();
            this.rb_5 = new System.Windows.Forms.RadioButton();
            this.rb_4 = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.pnl_puzzl = new System.Windows.Forms.Panel();
            this.tb_form = new System.Windows.Forms.TableLayoutPanel();
            this.tb_right = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_ctrl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.tb_form.SuspendLayout();
            this.tb_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ctrl
            // 
            this.pnl_ctrl.Controls.Add(this.progressBar1);
            this.pnl_ctrl.Controls.Add(this.label1);
            this.pnl_ctrl.Controls.Add(this.btn_load_puz);
            this.pnl_ctrl.Controls.Add(this.btn_sel_img);
            this.pnl_ctrl.Controls.Add(this.btn_auto);
            this.pnl_ctrl.Controls.Add(this.groupBox1);
            this.pnl_ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ctrl.Location = new System.Drawing.Point(0, 257);
            this.pnl_ctrl.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_ctrl.Name = "pnl_ctrl";
            this.pnl_ctrl.Size = new System.Drawing.Size(235, 257);
            this.pnl_ctrl.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.progressBar1.Location = new System.Drawing.Point(3, 224);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(228, 21);
            this.progressBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(3, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 56);
            this.label1.TabIndex = 6;
            // 
            // btn_load_puz
            // 
            this.btn_load_puz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_load_puz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load_puz.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_load_puz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btn_load_puz.Location = new System.Drawing.Point(4, 40);
            this.btn_load_puz.Name = "btn_load_puz";
            this.btn_load_puz.Size = new System.Drawing.Size(121, 33);
            this.btn_load_puz.TabIndex = 6;
            this.btn_load_puz.Text = "Load Puzzle";
            this.btn_load_puz.UseVisualStyleBackColor = false;
            this.btn_load_puz.Click += new System.EventHandler(this.BtnLoadPuzzle_Click);
            // 
            // btn_sel_img
            // 
            this.btn_sel_img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_sel_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sel_img.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sel_img.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btn_sel_img.Location = new System.Drawing.Point(4, 0);
            this.btn_sel_img.Name = "btn_sel_img";
            this.btn_sel_img.Size = new System.Drawing.Size(121, 34);
            this.btn_sel_img.TabIndex = 6;
            this.btn_sel_img.Text = "Select Image";
            this.btn_sel_img.UseVisualStyleBackColor = false;
            this.btn_sel_img.Click += new System.EventHandler(this.BtnSelectImg_Click);
            // 
            // btn_auto
            // 
            this.btn_auto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auto.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_auto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btn_auto.Location = new System.Drawing.Point(3, 79);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(122, 61);
            this.btn_auto.TabIndex = 5;
            this.btn_auto.Text = "AutoPuzzle";
            this.btn_auto.UseVisualStyleBackColor = false;
            this.btn_auto.Click += new System.EventHandler(this.AutoPuzzle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb_6);
            this.groupBox1.Controls.Add(this.rb_5);
            this.groupBox1.Controls.Add(this.rb_4);
            this.groupBox1.Controls.Add(this.rb_3);
            this.groupBox1.Controls.Add(this.rb_2);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(131, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level";
            // 
            // rb_6
            // 
            this.rb_6.AutoSize = true;
            this.rb_6.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_6.Location = new System.Drawing.Point(3, 129);
            this.rb_6.Name = "rb_6";
            this.rb_6.Size = new System.Drawing.Size(98, 25);
            this.rb_6.TabIndex = 9;
            this.rb_6.Text = "6 x 6";
            this.rb_6.UseVisualStyleBackColor = true;
            this.rb_6.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rb_5
            // 
            this.rb_5.AutoSize = true;
            this.rb_5.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_5.Location = new System.Drawing.Point(3, 104);
            this.rb_5.Name = "rb_5";
            this.rb_5.Size = new System.Drawing.Size(98, 25);
            this.rb_5.TabIndex = 8;
            this.rb_5.Text = "5 x 5";
            this.rb_5.UseVisualStyleBackColor = true;
            this.rb_5.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rb_4
            // 
            this.rb_4.AutoSize = true;
            this.rb_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_4.Location = new System.Drawing.Point(3, 79);
            this.rb_4.Name = "rb_4";
            this.rb_4.Size = new System.Drawing.Size(98, 25);
            this.rb_4.TabIndex = 7;
            this.rb_4.Text = "4 x 4";
            this.rb_4.UseVisualStyleBackColor = true;
            this.rb_4.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_3.Location = new System.Drawing.Point(3, 54);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(98, 25);
            this.rb_3.TabIndex = 4;
            this.rb_3.Text = "3 x 3";
            this.rb_3.UseVisualStyleBackColor = true;
            this.rb_3.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Checked = true;
            this.rb_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_2.Location = new System.Drawing.Point(3, 29);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(98, 25);
            this.rb_2.TabIndex = 1;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "2 x 2";
            this.rb_2.UseVisualStyleBackColor = true;
            this.rb_2.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // pb_img
            // 
            this.pb_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_img.Location = new System.Drawing.Point(0, 0);
            this.pb_img.Margin = new System.Windows.Forms.Padding(0);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(235, 257);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img.TabIndex = 4;
            this.pb_img.TabStop = false;
            // 
            // pnl_puzzl
            // 
            this.pnl_puzzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_puzzl.Location = new System.Drawing.Point(5, 5);
            this.pnl_puzzl.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_puzzl.Name = "pnl_puzzl";
            this.pnl_puzzl.Size = new System.Drawing.Size(695, 504);
            this.pnl_puzzl.TabIndex = 5;
            // 
            // tb_form
            // 
            this.tb_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.tb_form.ColumnCount = 2;
            this.tb_form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tb_form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tb_form.Controls.Add(this.pnl_puzzl, 0, 0);
            this.tb_form.Controls.Add(this.tb_right, 1, 0);
            this.tb_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_form.Location = new System.Drawing.Point(0, 0);
            this.tb_form.Margin = new System.Windows.Forms.Padding(0);
            this.tb_form.Name = "tb_form";
            this.tb_form.RowCount = 1;
            this.tb_form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_form.Size = new System.Drawing.Size(940, 514);
            this.tb_form.TabIndex = 1;
            // 
            // tb_right
            // 
            this.tb_right.ColumnCount = 1;
            this.tb_right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_right.Controls.Add(this.pb_img, 0, 0);
            this.tb_right.Controls.Add(this.pnl_ctrl, 0, 1);
            this.tb_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_right.Location = new System.Drawing.Point(705, 0);
            this.tb_right.Margin = new System.Windows.Forms.Padding(0);
            this.tb_right.Name = "tb_right";
            this.tb_right.RowCount = 2;
            this.tb_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_right.Size = new System.Drawing.Size(235, 514);
            this.tb_right.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 514);
            this.Controls.Add(this.tb_form);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_ctrl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.tb_form.ResumeLayout(false);
            this.tb_right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.Panel pnl_puzzl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_ctrl;
        private System.Windows.Forms.Button btn_sel_img;
        private System.Windows.Forms.Button btn_auto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_load_puz;
        private System.Windows.Forms.TableLayoutPanel tb_form;
        private System.Windows.Forms.TableLayoutPanel tb_right;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_6;
        private System.Windows.Forms.RadioButton rb_5;
        private System.Windows.Forms.RadioButton rb_4;
        private System.Windows.Forms.RadioButton rb_3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

