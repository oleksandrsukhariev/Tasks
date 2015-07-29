namespace UI
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.sirnameBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.TextBox();
            this.homePhoneBox = new System.Windows.Forms.TextBox();
            this.workPhoneBox = new System.Windows.Forms.TextBox();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 420);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameBox.Location = new System.Drawing.Point(390, 18);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(283, 30);
            this.nameBox.TabIndex = 1;
            this.nameBox.Tag = "";
            this.nameBox.ModifiedChanged += new System.EventHandler(this.nameBox_ModifiedChanged);
            // 
            // sirnameBox
            // 
            this.sirnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sirnameBox.Location = new System.Drawing.Point(390, 69);
            this.sirnameBox.Multiline = true;
            this.sirnameBox.Name = "sirnameBox";
            this.sirnameBox.Size = new System.Drawing.Size(283, 30);
            this.sirnameBox.TabIndex = 2;
            this.sirnameBox.ModifiedChanged += new System.EventHandler(this.sirnameBox_ModifiedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox.Location = new System.Drawing.Point(390, 123);
            this.groupBox.Multiline = true;
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(283, 30);
            this.groupBox.TabIndex = 3;
            this.groupBox.ModifiedChanged += new System.EventHandler(this.groupBox_ModifiedChanged);
            // 
            // homePhoneBox
            // 
            this.homePhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.homePhoneBox.Location = new System.Drawing.Point(390, 175);
            this.homePhoneBox.Multiline = true;
            this.homePhoneBox.Name = "homePhoneBox";
            this.homePhoneBox.Size = new System.Drawing.Size(283, 30);
            this.homePhoneBox.TabIndex = 4;
            this.homePhoneBox.ModifiedChanged += new System.EventHandler(this.homePhoneBox_ModifiedChanged);
            // 
            // workPhoneBox
            // 
            this.workPhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.workPhoneBox.Location = new System.Drawing.Point(390, 226);
            this.workPhoneBox.Multiline = true;
            this.workPhoneBox.Name = "workPhoneBox";
            this.workPhoneBox.Size = new System.Drawing.Size(283, 30);
            this.workPhoneBox.TabIndex = 5;
            this.workPhoneBox.ModifiedChanged += new System.EventHandler(this.workPhoneBox_ModifiedChanged);
            // 
            // photoBox
            // 
            this.photoBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photoBox.Location = new System.Drawing.Point(390, 286);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(283, 185);
            this.photoBox.TabIndex = 6;
            this.photoBox.TabStop = false;
            this.photoBox.DoubleClick += new System.EventHandler(this.photoBox_DoubleClick);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.add_btn.Location = new System.Drawing.Point(12, 498);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(138, 35);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add new";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.IndianRed;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(204, 498);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(137, 35);
            this.remove_btn.TabIndex = 8;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.save_btn.Enabled = false;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.save_btn.Location = new System.Drawing.Point(425, 498);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(213, 36);
            this.save_btn.TabIndex = 9;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Group by Name and Sirname";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(204, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Show in groups";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sirname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Home phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Work phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Photo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.photoBox);
            this.Controls.Add(this.workPhoneBox);
            this.Controls.Add(this.homePhoneBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.sirnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Contact manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox sirnameBox;
        private System.Windows.Forms.TextBox groupBox;
        private System.Windows.Forms.TextBox homePhoneBox;
        private System.Windows.Forms.TextBox workPhoneBox;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

