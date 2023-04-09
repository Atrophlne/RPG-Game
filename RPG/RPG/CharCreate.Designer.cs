namespace RPG
    {
    partial class CharCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharCreate));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.role_slct = new System.Windows.Forms.ComboBox();
            this.fmale_btn = new System.Windows.Forms.RadioButton();
            this.male_btn = new System.Windows.Forms.RadioButton();
            this.gb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(206, 63);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(136, 23);
            this.txt_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(285, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // gb_info
            // 
            this.gb_info.BackColor = System.Drawing.Color.Transparent;
            this.gb_info.Controls.Add(this.btn_Save);
            this.gb_info.Controls.Add(this.role_slct);
            this.gb_info.Controls.Add(this.fmale_btn);
            this.gb_info.Controls.Add(this.male_btn);
            this.gb_info.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gb_info.Location = new System.Drawing.Point(154, 102);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(188, 157);
            this.gb_info.TabIndex = 2;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "Info";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.BackgroundImage = global::RPG.Properties.Resources.tmp;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(40, 94);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 43);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // role_slct
            // 
            this.role_slct.BackColor = System.Drawing.SystemColors.Control;
            this.role_slct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_slct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.role_slct.FormattingEnabled = true;
            this.role_slct.Items.AddRange(new object[] {
            "Assassin",
            "Fighter",
            "Mage",
            "Marksman",
            "Support",
            "Tank"});
            this.role_slct.Location = new System.Drawing.Point(19, 53);
            this.role_slct.Name = "role_slct";
            this.role_slct.Size = new System.Drawing.Size(153, 24);
            this.role_slct.TabIndex = 2;
            this.role_slct.Text = "----------Roles----------";
            // 
            // fmale_btn
            // 
            this.fmale_btn.AutoSize = true;
            this.fmale_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmale_btn.ForeColor = System.Drawing.Color.Violet;
            this.fmale_btn.Location = new System.Drawing.Point(102, 25);
            this.fmale_btn.Name = "fmale_btn";
            this.fmale_btn.Size = new System.Drawing.Size(70, 21);
            this.fmale_btn.TabIndex = 1;
            this.fmale_btn.TabStop = true;
            this.fmale_btn.Text = "Female";
            this.fmale_btn.UseVisualStyleBackColor = true;
            // 
            // male_btn
            // 
            this.male_btn.AutoSize = true;
            this.male_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_btn.ForeColor = System.Drawing.Color.Cyan;
            this.male_btn.Location = new System.Drawing.Point(19, 25);
            this.male_btn.Name = "male_btn";
            this.male_btn.Size = new System.Drawing.Size(56, 21);
            this.male_btn.TabIndex = 0;
            this.male_btn.TabStop = true;
            this.male_btn.Text = "Male";
            this.male_btn.UseVisualStyleBackColor = true;
            // 
            // CharCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::RPG.Properties.Resources.crtchr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(354, 331);
            this.Controls.Add(this.gb_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharCreate";
            this.Text = "Create Character";
            this.gb_info.ResumeLayout(false);
            this.gb_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.ComboBox role_slct;
        private System.Windows.Forms.RadioButton fmale_btn;
        private System.Windows.Forms.RadioButton male_btn;
        private System.Windows.Forms.Button btn_Save;
        }
    }