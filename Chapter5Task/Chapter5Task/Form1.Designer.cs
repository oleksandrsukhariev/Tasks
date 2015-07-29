namespace Chapter5Task
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stop_generate_btn = new System.Windows.Forms.Button();
            this.generate_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(393, 450);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stop_generate_btn
            // 
            this.stop_generate_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.stop_generate_btn.Location = new System.Drawing.Point(31, 147);
            this.stop_generate_btn.Name = "stop_generate_btn";
            this.stop_generate_btn.Size = new System.Drawing.Size(75, 60);
            this.stop_generate_btn.TabIndex = 1;
            this.stop_generate_btn.Text = "Stop generate";
            this.stop_generate_btn.UseVisualStyleBackColor = false;
            this.stop_generate_btn.Click += new System.EventHandler(this.stop_generate_btn_Click);
            // 
            // generate_btn
            // 
            this.generate_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.generate_btn.Location = new System.Drawing.Point(31, 46);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(75, 60);
            this.generate_btn.TabIndex = 3;
            this.generate_btn.Text = "Generate";
            this.generate_btn.UseVisualStyleBackColor = false;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.Window;
            this.exit_btn.Location = new System.Drawing.Point(31, 481);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 542);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.generate_btn);
            this.Controls.Add(this.stop_generate_btn);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Exceptions App";
            this.Shown += new System.EventHandler(this.start_btn_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button stop_generate_btn;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

