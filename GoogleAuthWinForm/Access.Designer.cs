namespace GoogleAuthWinForm
{
    partial class Access
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
            this.btnAuth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AccessToken = new System.Windows.Forms.Label();
            this.Expire = new System.Windows.Forms.Label();
            this.refreshToken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(605, 137);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(75, 23);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "Login";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Access Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Refresh Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expires";
            // 
            // AccessToken
            // 
            this.AccessToken.AutoSize = true;
            this.AccessToken.Location = new System.Drawing.Point(96, 12);
            this.AccessToken.Name = "AccessToken";
            this.AccessToken.Size = new System.Drawing.Size(35, 13);
            this.AccessToken.TabIndex = 4;
            this.AccessToken.Text = "label4";
            // 
            // Expire
            // 
            this.Expire.AutoSize = true;
            this.Expire.Location = new System.Drawing.Point(96, 63);
            this.Expire.Name = "Expire";
            this.Expire.Size = new System.Drawing.Size(35, 13);
            this.Expire.TabIndex = 5;
            this.Expire.Text = "label4";
            // 
            // refreshToken
            // 
            this.refreshToken.AutoSize = true;
            this.refreshToken.Location = new System.Drawing.Point(96, 40);
            this.refreshToken.Name = "refreshToken";
            this.refreshToken.Size = new System.Drawing.Size(35, 13);
            this.refreshToken.TabIndex = 6;
            this.refreshToken.Text = "label4";
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 172);
            this.Controls.Add(this.refreshToken);
            this.Controls.Add(this.Expire);
            this.Controls.Add(this.AccessToken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAuth);
            this.Name = "Access";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AccessToken;
        private System.Windows.Forms.Label Expire;
        private System.Windows.Forms.Label refreshToken;
    }
}

