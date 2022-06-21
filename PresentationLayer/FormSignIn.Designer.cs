
namespace PresentationLayer
{
    partial class FormSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_confirmPasssword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_loginNavigate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 144);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 104;
            this.label6.Text = "Account Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(101, 202);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(314, 22);
            this.txt_username.TabIndex = 103;
            this.txt_username.Validating += new System.ComponentModel.CancelEventHandler(this.txt_username_Validating_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Confirm Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_confirmPasssword
            // 
            this.txt_confirmPasssword.Location = new System.Drawing.Point(101, 264);
            this.txt_confirmPasssword.Multiline = true;
            this.txt_confirmPasssword.Name = "txt_confirmPasssword";
            this.txt_confirmPasssword.Size = new System.Drawing.Size(314, 22);
            this.txt_confirmPasssword.TabIndex = 101;
            this.txt_confirmPasssword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_confirmPasssword_Validating_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Already have a account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_loginNavigate
            // 
            this.btn_loginNavigate.Location = new System.Drawing.Point(179, 386);
            this.btn_loginNavigate.Name = "btn_loginNavigate";
            this.btn_loginNavigate.Size = new System.Drawing.Size(236, 25);
            this.btn_loginNavigate.TabIndex = 99;
            this.btn_loginNavigate.Text = "I WANT TO LOGIN...";
            this.btn_loginNavigate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loginNavigate.UseVisualStyleBackColor = true;
            this.btn_loginNavigate.Click += new System.EventHandler(this.btn_loginNavigate_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(20, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 2);
            this.label3.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(101, 230);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(314, 22);
            this.txt_password.TabIndex = 96;
            this.txt_password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_password_Validating_1);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(263, 304);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(152, 25);
            this.btn_register.TabIndex = 94;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 440);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_confirmPasssword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_loginNavigate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSignIn";
            this.Text = "FormSignIn";
            this.Load += new System.EventHandler(this.FormSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_confirmPasssword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_loginNavigate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}