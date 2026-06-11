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
            btnZoom = new Button();
            btnDrehen = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRechne
            // 
            btnRechne.Location = new Point(596, 305);
            btnRechne.Margin = new Padding(3, 2, 3, 2);
            btnRechne.Name = "btnRechne";
            btnRechne.Size = new Size(82, 22);
            btnRechne.TabIndex = 0;
            btnRechne.Text = "Berechnen";
            btnRechne.UseVisualStyleBackColor = true;
            btnRechne.Click += btnRechne_Click;
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(36, 37);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(40, 15);
            lblBreite.TabIndex = 1;
            lblBreite.Text = "Breite:";
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(37, 107);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(39, 15);
            lblHoehe.TabIndex = 2;
            lblHoehe.Text = "Höhe:";
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(155, 37);
            tbxBreite.Margin = new Padding(3, 2, 3, 2);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(110, 23);
            tbxBreite.TabIndex = 3;
            tbxBreite.TextChanged += textBox1_TextChanged;
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(155, 107);
            tbxHoehe.Margin = new Padding(3, 2, 3, 2);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(110, 23);
            tbxHoehe.TabIndex = 4;
            // 
            // lblflaeche
            // 
            lblflaeche.AutoSize = true;
            lblflaeche.Location = new Point(36, 164);
            lblflaeche.Name = "lblflaeche";
            lblflaeche.Size = new Size(44, 15);
            lblflaeche.TabIndex = 5;
            lblflaeche.Text = "Fläche:";
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(36, 225);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(53, 15);
            lblUmfang.TabIndex = 6;
            lblUmfang.Text = "Umfang:";
            // 
            // tbxFlaeche
            // 
            tbxFlaeche.Location = new Point(155, 164);
            tbxFlaeche.Margin = new Padding(3, 2, 3, 2);
            tbxFlaeche.Name = "tbxFlaeche";
            tbxFlaeche.Size = new Size(110, 23);
            tbxFlaeche.TabIndex = 7;
            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(155, 225);
            tbxUmfang.Margin = new Padding(3, 2, 3, 2);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.Size = new Size(110, 23);
            tbxUmfang.TabIndex = 8;
            // 
            // btnZoom
            // 
            btnZoom.Location = new Point(603, 37);
            btnZoom.Name = "btnZoom";
            btnZoom.Size = new Size(75, 23);
            btnZoom.TabIndex = 9;
            btnZoom.Text = "Zoom: 10%";
            btnZoom.UseVisualStyleBackColor = true;
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(603, 66);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(75, 23);
            btnDrehen.TabIndex = 10;
            btnDrehen.Text = "90° drehen";
            btnDrehen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 290);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 12;
            label1.Text = "Diagonal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(btnDrehen);
            Controls.Add(btnZoom);
            Controls.Add(tbxUmfang);
            Controls.Add(tbxFlaeche);
            Controls.Add(lblUmfang);
            Controls.Add(lblflaeche);
            Controls.Add(tbxHoehe);
            Controls.Add(tbxBreite);
            Controls.Add(lblHoehe);
            Controls.Add(lblBreite);
            Controls.Add(btnRechne);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnZoom;
        private Button btnDrehen;
        private Label label1;
    }
}
