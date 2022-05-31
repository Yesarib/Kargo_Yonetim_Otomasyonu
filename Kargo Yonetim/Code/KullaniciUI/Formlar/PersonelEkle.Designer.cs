
namespace KullaniciUI.Formlar
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaTextBoxSifre = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBoxE = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBoxTC = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBoxTel = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBoxAD = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton1.Location = new System.Drawing.Point(260, 1);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(44, 40);
            this.gunaButton1.TabIndex = 33;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.gunaComboBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBoxE);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.gunaButton2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBoxTC);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBoxTel);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel7);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBoxAD);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(39, 31);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 10;
            this.gunaGroupBox1.Size = new System.Drawing.Size(265, 305);
            this.gunaGroupBox1.TabIndex = 31;
            this.gunaGroupBox1.Text = "Kişi Bilgileri";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(59, 178);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(47, 20);
            this.gunaLabel5.TabIndex = 34;
            this.gunaLabel5.Text = "Yetki :";
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Çalışan",
            "Müdür Yardımcısı"});
            this.gunaComboBox1.Location = new System.Drawing.Point(106, 175);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(121, 26);
            this.gunaComboBox1.TabIndex = 33;
            // 
            // gunaTextBoxSifre
            // 
            this.gunaTextBoxSifre.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxSifre.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxSifre.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxSifre.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxSifre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBoxSifre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxSifre.Location = new System.Drawing.Point(127, 352);
            this.gunaTextBoxSifre.Name = "gunaTextBoxSifre";
            this.gunaTextBoxSifre.PasswordChar = '\0';
            this.gunaTextBoxSifre.Radius = 5;
            this.gunaTextBoxSifre.SelectedText = "";
            this.gunaTextBoxSifre.Size = new System.Drawing.Size(115, 26);
            this.gunaTextBoxSifre.TabIndex = 32;
            this.gunaTextBoxSifre.Visible = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(81, 354);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(46, 20);
            this.gunaLabel2.TabIndex = 31;
            this.gunaLabel2.Text = "Şifre :";
            this.gunaLabel2.Visible = false;
            // 
            // gunaTextBoxE
            // 
            this.gunaTextBoxE.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxE.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxE.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxE.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxE.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBoxE.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxE.Location = new System.Drawing.Point(106, 140);
            this.gunaTextBoxE.Name = "gunaTextBoxE";
            this.gunaTextBoxE.PasswordChar = '\0';
            this.gunaTextBoxE.Radius = 5;
            this.gunaTextBoxE.SelectedText = "";
            this.gunaTextBoxE.Size = new System.Drawing.Size(115, 26);
            this.gunaTextBoxE.TabIndex = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(42, 142);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(67, 20);
            this.gunaLabel1.TabIndex = 9;
            this.gunaLabel1.Text = "E-posta :";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(125)))), ((int)(((byte)(172)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(71, 220);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(115, 38);
            this.gunaButton2.TabIndex = 30;
            this.gunaButton2.Text = "Ekle";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaTextBoxTC
            // 
            this.gunaTextBoxTC.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxTC.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxTC.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxTC.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxTC.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBoxTC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxTC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxTC.Location = new System.Drawing.Point(106, 38);
            this.gunaTextBoxTC.Name = "gunaTextBoxTC";
            this.gunaTextBoxTC.PasswordChar = '\0';
            this.gunaTextBoxTC.Radius = 5;
            this.gunaTextBoxTC.SelectedText = "";
            this.gunaTextBoxTC.Size = new System.Drawing.Size(115, 26);
            this.gunaTextBoxTC.TabIndex = 8;
            // 
            // gunaTextBoxTel
            // 
            this.gunaTextBoxTel.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxTel.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxTel.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxTel.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxTel.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBoxTel.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxTel.Location = new System.Drawing.Point(106, 107);
            this.gunaTextBoxTel.Name = "gunaTextBoxTel";
            this.gunaTextBoxTel.PasswordChar = '\0';
            this.gunaTextBoxTel.Radius = 5;
            this.gunaTextBoxTel.SelectedText = "";
            this.gunaTextBoxTel.Size = new System.Drawing.Size(115, 26);
            this.gunaTextBoxTel.TabIndex = 5;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel7.Location = new System.Drawing.Point(67, 39);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(39, 20);
            this.gunaLabel7.TabIndex = 7;
            this.gunaLabel7.Text = "T.C. :";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(42, 109);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(65, 20);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Telefon :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel3.Location = new System.Drawing.Point(17, 74);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(90, 20);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Adı-Soyadı :";
            // 
            // gunaTextBoxAD
            // 
            this.gunaTextBoxAD.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxAD.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxAD.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxAD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxAD.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxAD.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBoxAD.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxAD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxAD.Location = new System.Drawing.Point(106, 72);
            this.gunaTextBoxAD.Name = "gunaTextBoxAD";
            this.gunaTextBoxAD.PasswordChar = '\0';
            this.gunaTextBoxAD.Radius = 5;
            this.gunaTextBoxAD.SelectedText = "";
            this.gunaTextBoxAD.Size = new System.Drawing.Size(115, 26);
            this.gunaTextBoxAD.TabIndex = 4;
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 383);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaTextBoxSifre);
            this.Controls.Add(this.gunaLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkle";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxSifre;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxE;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxTC;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxTel;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxAD;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
    }
}