namespace WinFormsAppMiniHesapMakinesi
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
            label1 = new Label();
            textBox1Sayı = new TextBox();
            textBox2Sayı = new TextBox();
            label2 = new Label();
            buttonTopla = new Button();
            buttonÇıkar = new Button();
            buttonÇarp = new Button();
            buttonBöl = new Button();
            label3 = new Label();
            textBox1Sonuç = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 36);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "1.Sayı";
            // 
            // textBox1Sayı
            // 
            textBox1Sayı.Location = new Point(307, 28);
            textBox1Sayı.Name = "textBox1Sayı";
            textBox1Sayı.Size = new Size(100, 23);
            textBox1Sayı.TabIndex = 1;
            // 
            // textBox2Sayı
            // 
            textBox2Sayı.Location = new Point(307, 70);
            textBox2Sayı.Name = "textBox2Sayı";
            textBox2Sayı.Size = new Size(100, 23);
            textBox2Sayı.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 78);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "2.Sayı";
            // 
            // buttonTopla
            // 
            buttonTopla.Location = new Point(232, 122);
            buttonTopla.Name = "buttonTopla";
            buttonTopla.Size = new Size(75, 23);
            buttonTopla.TabIndex = 4;
            buttonTopla.Text = "Topla";
            buttonTopla.UseVisualStyleBackColor = true;
            buttonTopla.Click += buttonTopla_Click;
            // 
            // buttonÇıkar
            // 
            buttonÇıkar.Location = new Point(332, 122);
            buttonÇıkar.Name = "buttonÇıkar";
            buttonÇıkar.Size = new Size(75, 23);
            buttonÇıkar.TabIndex = 5;
            buttonÇıkar.Text = "Çıkar";
            buttonÇıkar.UseVisualStyleBackColor = true;
            buttonÇıkar.Click += buttonÇıkar_Click;
            // 
            // buttonÇarp
            // 
            buttonÇarp.Location = new Point(232, 169);
            buttonÇarp.Name = "buttonÇarp";
            buttonÇarp.Size = new Size(75, 23);
            buttonÇarp.TabIndex = 6;
            buttonÇarp.Text = "Çarp";
            buttonÇarp.UseVisualStyleBackColor = true;
            buttonÇarp.Click += buttonÇarp_Click;
            // 
            // buttonBöl
            // 
            buttonBöl.Location = new Point(332, 169);
            buttonBöl.Name = "buttonBöl";
            buttonBöl.Size = new Size(75, 23);
            buttonBöl.TabIndex = 7;
            buttonBöl.Text = "Böl";
            buttonBöl.UseVisualStyleBackColor = true;
            buttonBöl.Click += buttonBöl_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 217);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Sonuç";
            // 
            // textBox1Sonuç
            // 
            textBox1Sonuç.Location = new Point(307, 209);
            textBox1Sonuç.Name = "textBox1Sonuç";
            textBox1Sonuç.Size = new Size(100, 23);
            textBox1Sonuç.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1Sonuç);
            Controls.Add(label3);
            Controls.Add(buttonBöl);
            Controls.Add(buttonÇarp);
            Controls.Add(buttonÇıkar);
            Controls.Add(buttonTopla);
            Controls.Add(label2);
            Controls.Add(textBox2Sayı);
            Controls.Add(textBox1Sayı);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1Sayı;
        private TextBox textBox2Sayı;
        private Label label2;
        private Button buttonTopla;
        private Button buttonÇıkar;
        private Button buttonÇarp;
        private Button buttonBöl;
        private Label label3;
        private TextBox textBox1Sonuç;
    }
}
