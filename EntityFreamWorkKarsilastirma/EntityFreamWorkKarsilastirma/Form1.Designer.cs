namespace EntityFreamWorkKarsilastirma
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstEF = new System.Windows.Forms.ListBox();
            this.lstDisconnected = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDataAdap = new System.Windows.Forms.Button();
            this.btnSqlCon = new System.Windows.Forms.Button();
            this.lstConnected = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(376, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "................................";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(215, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "................................";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(58, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "................................";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstEF
            // 
            this.lstEF.FormattingEnabled = true;
            this.lstEF.Location = new System.Drawing.Point(379, 75);
            this.lstEF.Name = "lstEF";
            this.lstEF.Size = new System.Drawing.Size(120, 251);
            this.lstEF.TabIndex = 20;
            // 
            // lstDisconnected
            // 
            this.lstDisconnected.FormattingEnabled = true;
            this.lstDisconnected.Location = new System.Drawing.Point(218, 75);
            this.lstDisconnected.Name = "lstDisconnected";
            this.lstDisconnected.Size = new System.Drawing.Size(120, 251);
            this.lstDisconnected.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Entity Framework";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDataAdap
            // 
            this.btnDataAdap.Location = new System.Drawing.Point(218, 43);
            this.btnDataAdap.Name = "btnDataAdap";
            this.btnDataAdap.Size = new System.Drawing.Size(120, 23);
            this.btnDataAdap.TabIndex = 17;
            this.btnDataAdap.Text = "Disconnected";
            this.btnDataAdap.UseVisualStyleBackColor = true;
            this.btnDataAdap.Click += new System.EventHandler(this.btnDataAdap_Click);
            // 
            // btnSqlCon
            // 
            this.btnSqlCon.Location = new System.Drawing.Point(58, 43);
            this.btnSqlCon.Name = "btnSqlCon";
            this.btnSqlCon.Size = new System.Drawing.Size(120, 23);
            this.btnSqlCon.TabIndex = 16;
            this.btnSqlCon.Text = "Connected";
            this.btnSqlCon.UseVisualStyleBackColor = true;
            this.btnSqlCon.Click += new System.EventHandler(this.btnSqlCon_Click);
            // 
            // lstConnected
            // 
            this.lstConnected.FormattingEnabled = true;
            this.lstConnected.Location = new System.Drawing.Point(58, 75);
            this.lstConnected.Name = "lstConnected";
            this.lstConnected.Size = new System.Drawing.Size(120, 251);
            this.lstConnected.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Entity Framework";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Disconnected Mimari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Connected Mimari";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 394);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstEF);
            this.Controls.Add(this.lstDisconnected);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDataAdap);
            this.Controls.Add(this.btnSqlCon);
            this.Controls.Add(this.lstConnected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstEF;
        private System.Windows.Forms.ListBox lstDisconnected;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDataAdap;
        private System.Windows.Forms.Button btnSqlCon;
        private System.Windows.Forms.ListBox lstConnected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

