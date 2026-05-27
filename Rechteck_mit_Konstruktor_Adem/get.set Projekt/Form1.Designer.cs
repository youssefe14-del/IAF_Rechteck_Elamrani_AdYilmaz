namespace get.set_Projekt
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
            btnRechne = new Button();
            lblBreite = new Label();
            lblHoehe = new Label();
            tbxBreite = new TextBox();
            tbxHoehe = new TextBox();
            lblflaeche = new Label();
            lblUmfang = new Label();
            tbxFlaeche = new TextBox();
            tbxUmfang = new TextBox();
            SuspendLayout();
            // 
            // btnRechne
            // 
            btnRechne.Location = new Point(526, 168);
            btnRechne.Name = "btnRechne";
            btnRechne.Size = new Size(94, 29);
            btnRechne.TabIndex = 0;
            btnRechne.Text = "Berechnen";
            btnRechne.UseVisualStyleBackColor = true;
            btnRechne.Click += btnRechne_Click;
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(177, 56);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(51, 20);
            lblBreite.TabIndex = 1;
            lblBreite.Text = "Breite:";
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(177, 177);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(48, 20);
            lblHoehe.TabIndex = 2;
            lblHoehe.Text = "Höhe:";
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(248, 49);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(125, 27);
            tbxBreite.TabIndex = 3;
            tbxBreite.TextChanged += textBox1_TextChanged;
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(248, 170);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(125, 27);
            tbxHoehe.TabIndex = 4;
            // 
            // lblflaeche
            // 
            lblflaeche.AutoSize = true;
            lblflaeche.Location = new Point(177, 289);
            lblflaeche.Name = "lblflaeche";
            lblflaeche.Size = new Size(54, 20);
            lblflaeche.TabIndex = 5;
            lblflaeche.Text = "Fläche:";
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(177, 388);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(65, 20);
            lblUmfang.TabIndex = 6;
            lblUmfang.Text = "Umfang:";
            // 
            // tbxFlaeche
            // 
            tbxFlaeche.Location = new Point(248, 282);
            tbxFlaeche.Name = "tbxFlaeche";
            tbxFlaeche.Size = new Size(125, 27);
            tbxFlaeche.TabIndex = 7;
            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(248, 381);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.Size = new Size(125, 27);
            tbxUmfang.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxUmfang);
            Controls.Add(tbxFlaeche);
            Controls.Add(lblUmfang);
            Controls.Add(lblflaeche);
            Controls.Add(tbxHoehe);
            Controls.Add(tbxBreite);
            Controls.Add(lblHoehe);
            Controls.Add(lblBreite);
            Controls.Add(btnRechne);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRechne;
        private Label lblBreite;
        private Label lblHoehe;
        private TextBox tbxBreite;
        private TextBox tbxHoehe;
        private Label lblflaeche;
        private Label lblUmfang;
        private TextBox tbxFlaeche;
        private TextBox tbxUmfang;
    }
}
