namespace RPG
    {
    partial class Rpg_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rpg_Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.ctm_char_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHTHOLLY\'S ADVENTURE";
            // 
            // ctm_char_btn
            // 
            this.ctm_char_btn.BackColor = System.Drawing.Color.Transparent;
            this.ctm_char_btn.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctm_char_btn.ForeColor = System.Drawing.Color.Black;
            this.ctm_char_btn.Location = new System.Drawing.Point(12, 174);
            this.ctm_char_btn.Name = "ctm_char_btn";
            this.ctm_char_btn.Size = new System.Drawing.Size(97, 44);
            this.ctm_char_btn.TabIndex = 1;
            this.ctm_char_btn.Text = "Customize Character";
            this.ctm_char_btn.UseVisualStyleBackColor = false;
            this.ctm_char_btn.Click += new System.EventHandler(this.ctm_char_btn_Click);
            // 
            // Rpg_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(354, 331);
            this.Controls.Add(this.ctm_char_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rpg_Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ctm_char_btn;
        }
    }

