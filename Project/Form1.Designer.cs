namespace Project
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
            this.btn_con = new System.Windows.Forms.Button();
            this.rtb_client = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_con
            // 
            this.btn_con.Location = new System.Drawing.Point(54, 24);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(75, 23);
            this.btn_con.TabIndex = 0;
            this.btn_con.Text = "Connect";
            this.btn_con.UseVisualStyleBackColor = true;
            this.btn_con.Click += new System.EventHandler(this.btn_con_Click);
            // 
            // rtb_client
            // 
            this.rtb_client.Location = new System.Drawing.Point(-7, 88);
            this.rtb_client.Name = "rtb_client";
            this.rtb_client.Size = new System.Drawing.Size(812, 367);
            this.rtb_client.TabIndex = 1;
            this.rtb_client.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(406, 24);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "123";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.rtb_client);
            this.Controls.Add(this.btn_con);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_con;
        private RichTextBox rtb_client;
        private Button btn_send;
        private TextBox textBox1;
    }
}