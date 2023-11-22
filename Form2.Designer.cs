namespace project
{
    partial class Form2
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_paw = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_paw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(32, 133);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(41, 12);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "아이디";
            // 
            // label_paw
            // 
            this.label_paw.AutoSize = true;
            this.label_paw.Location = new System.Drawing.Point(32, 216);
            this.label_paw.Name = "label_paw";
            this.label_paw.Size = new System.Drawing.Size(53, 12);
            this.label_paw.TabIndex = 1;
            this.label_paw.Text = "비밀번호";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(108, 130);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 21);
            this.text_id.TabIndex = 2;
            // 
            // text_paw
            // 
            this.text_paw.Location = new System.Drawing.Point(108, 207);
            this.text_paw.Name = "text_paw";
            this.text_paw.Size = new System.Drawing.Size(100, 21);
            this.text_paw.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.Location = new System.Drawing.Point(102, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "로그인";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_paw);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label_paw);
            this.Controls.Add(this.label_id);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_paw;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_paw;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
    }
}