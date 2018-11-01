namespace ChromeDinoKI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(12, 41);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.Size = new System.Drawing.Size(284, 127);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 5000;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick_1);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(63, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(13, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 13);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Actions: ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(104, 9);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(61, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Highscore: ";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(160, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(20, 13);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "0A";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(233, 9);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(41, 13);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "Count: ";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(280, 9);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(13, 13);
            this.Label7.TabIndex = 7;
            this.Label7.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 159);
            this.button1.TabIndex = 8;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.RichTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ChromeDino AI | C#";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Button button1;
    }
}

