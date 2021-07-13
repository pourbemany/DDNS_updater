
namespace noip_updater
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
            this.button1 = new System.Windows.Forms.Button();
            this.ddns_add = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.third_pa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.last_update = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send directly";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ddns_add
            // 
            this.ddns_add.Location = new System.Drawing.Point(100, 50);
            this.ddns_add.Name = "ddns_add";
            this.ddns_add.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ddns_add.Size = new System.Drawing.Size(270, 23);
            this.ddns_add.TabIndex = 1;
            this.ddns_add.Text = "my.ddns.net";
            this.ddns_add.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(100, 94);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(270, 23);
            this.user.TabIndex = 2;
            this.user.Text = "pourbemany";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(100, 137);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(270, 23);
            this.pass.TabIndex = 3;
            this.pass.Text = "896";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "DDNS Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "IP";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(100, 180);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(270, 23);
            this.ip.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Send via third party";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Third party add.";
            // 
            // third_pa
            // 
            this.third_pa.Location = new System.Drawing.Point(100, 222);
            this.third_pa.Name = "third_pa";
            this.third_pa.Size = new System.Drawing.Size(270, 23);
            this.third_pa.TabIndex = 10;
            this.third_pa.Text = "http://www.bimepishgaman.ir/noip_updater.php";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Time interval (sec)";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(113, 319);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(34, 23);
            this.interval.TabIndex = 12;
            this.interval.Text = "60";
            this.interval.TextChanged += new System.EventHandler(this.interval_TextChanged);
            this.interval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.interval_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(49, 365);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(88, 15);
            this.status.TabIndex = 15;
            this.status.Text = "No Connection";
            // 
            // last_update
            // 
            this.last_update.AutoSize = true;
            this.last_update.Location = new System.Drawing.Point(81, 384);
            this.last_update.Name = "last_update";
            this.last_update.Size = new System.Drawing.Size(27, 15);
            this.last_update.TabIndex = 17;
            this.last_update.Text = "null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Last update:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 408);
            this.Controls.Add(this.last_update);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.third_pa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.ddns_add);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoIP Updater";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ddns_add;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox third_pa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label last_update;
        private System.Windows.Forms.Label label9;
    }
}

