
namespace KullaniciUI.Formlar
{
    partial class KargoTakip
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
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KargoTakip));
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.yolCizgi = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaSa = new Guna.UI.WinForms.GunaLabel();
            this.gunaYol = new Guna.UI.WinForms.GunaLabel();
            this.gunaTeslim = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransfarantPictureBox3 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaTransfarantPictureBox2 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yolCizgi)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.gunaTextBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaTextBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gunaTextBox1.Location = new System.Drawing.Point(3, 5);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 20;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(222, 53);
            this.gunaTextBox1.TabIndex = 0;
            this.gunaTextBox1.Text = "Takip numarasını buraya giriniz";
            this.gunaTextBox1.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            this.gunaTextBox1.Click += new System.EventHandler(this.gunaTextBox1_Click);
            this.gunaTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gunaTextBox1_KeyPress);
            this.gunaTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaTextBox1_MouseClick);
            // 
            // yolCizgi
            // 
            this.yolCizgi.BackColor = System.Drawing.Color.Transparent;
            this.yolCizgi.BaseColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.yolCizgi, Guna.UI.Animation.DecorationType.None);
            this.yolCizgi.Image = ((System.Drawing.Image)(resources.GetObject("yolCizgi.Image")));
            this.yolCizgi.Location = new System.Drawing.Point(161, 37);
            this.yolCizgi.Name = "yolCizgi";
            this.yolCizgi.Size = new System.Drawing.Size(27, 265);
            this.yolCizgi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yolCizgi.TabIndex = 21;
            this.yolCizgi.TabStop = false;
            this.yolCizgi.Visible = false;
            this.yolCizgi.Click += new System.EventHandler(this.gunaTransfarantPictureBox4_Click);
            // 
            // gunaSa
            // 
            this.gunaSa.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaSa, Guna.UI.Animation.DecorationType.None);
            this.gunaSa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaSa.Location = new System.Drawing.Point(190, 242);
            this.gunaSa.Name = "gunaSa";
            this.gunaSa.Size = new System.Drawing.Size(74, 15);
            this.gunaSa.TabIndex = 22;
            this.gunaSa.Text = "Kargo Alındı";
            this.gunaSa.Visible = false;
            // 
            // gunaYol
            // 
            this.gunaYol.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaYol, Guna.UI.Animation.DecorationType.None);
            this.gunaYol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaYol.Location = new System.Drawing.Point(190, 166);
            this.gunaYol.Name = "gunaYol";
            this.gunaYol.Size = new System.Drawing.Size(36, 15);
            this.gunaYol.TabIndex = 23;
            this.gunaYol.Text = "Yolda";
            this.gunaYol.Visible = false;
            // 
            // gunaTeslim
            // 
            this.gunaTeslim.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaTeslim, Guna.UI.Animation.DecorationType.None);
            this.gunaTeslim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaTeslim.Location = new System.Drawing.Point(190, 88);
            this.gunaTeslim.Name = "gunaTeslim";
            this.gunaTeslim.Size = new System.Drawing.Size(74, 15);
            this.gunaTeslim.TabIndex = 24;
            this.gunaTeslim.Text = "Teslim Edildi";
            this.gunaTeslim.Visible = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaButton1);
            this.gunaElipsePanel1.Controls.Add(this.gunaTextBox1);
            this.gunaTransition1.SetDecoration(this.gunaElipsePanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(106, 56);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(228, 105);
            this.gunaElipsePanel1.TabIndex = 28;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.gunaButton1, Guna.UI.Animation.DecorationType.None);
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(180, 13);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(36, 37);
            this.gunaButton1.TabIndex = 29;
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click_1);
            this.gunaButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaButton1_MouseClick);
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.gunaTextBox2);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel2.Controls.Add(this.gunaTransfarantPictureBox3);
            this.gunaElipsePanel2.Controls.Add(this.gunaTransfarantPictureBox2);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel2.Controls.Add(this.gunaTransfarantPictureBox1);
            this.gunaElipsePanel2.Controls.Add(this.yolCizgi);
            this.gunaElipsePanel2.Controls.Add(this.gunaSa);
            this.gunaElipsePanel2.Controls.Add(this.gunaTeslim);
            this.gunaElipsePanel2.Controls.Add(this.gunaYol);
            this.gunaTransition1.SetDecoration(this.gunaElipsePanel2, Guna.UI.Animation.DecorationType.None);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(411, 56);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 10;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(364, 324);
            this.gunaElipsePanel2.TabIndex = 29;
            this.gunaElipsePanel2.Visible = false;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.gunaTextBox2, Guna.UI.Animation.DecorationType.None);
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaTextBox2.Location = new System.Drawing.Point(6, 28);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(138, 30);
            this.gunaTextBox2.TabIndex = 30;
            this.gunaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaTextBox2.Visible = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gunaLabel3.Location = new System.Drawing.Point(20, 42);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(0, 16);
            this.gunaLabel3.TabIndex = 29;
            this.gunaLabel3.Visible = false;
            // 
            // gunaTransfarantPictureBox3
            // 
            this.gunaTransfarantPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox3.BaseColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.gunaTransfarantPictureBox3, Guna.UI.Animation.DecorationType.None);
            this.gunaTransfarantPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox3.Image")));
            this.gunaTransfarantPictureBox3.Location = new System.Drawing.Point(112, 242);
            this.gunaTransfarantPictureBox3.Name = "gunaTransfarantPictureBox3";
            this.gunaTransfarantPictureBox3.Size = new System.Drawing.Size(120, 60);
            this.gunaTransfarantPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox3.TabIndex = 27;
            this.gunaTransfarantPictureBox3.TabStop = false;
            this.gunaTransfarantPictureBox3.Visible = false;
            // 
            // gunaTransfarantPictureBox2
            // 
            this.gunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.gunaTransfarantPictureBox2, Guna.UI.Animation.DecorationType.None);
            this.gunaTransfarantPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox2.Image")));
            this.gunaTransfarantPictureBox2.Location = new System.Drawing.Point(112, 155);
            this.gunaTransfarantPictureBox2.Name = "gunaTransfarantPictureBox2";
            this.gunaTransfarantPictureBox2.Size = new System.Drawing.Size(120, 153);
            this.gunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox2.TabIndex = 26;
            this.gunaTransfarantPictureBox2.TabStop = false;
            this.gunaTransfarantPictureBox2.Visible = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(20, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(97, 16);
            this.gunaLabel2.TabIndex = 28;
            this.gunaLabel2.Text = "Takip Numarası";
            this.gunaLabel2.Visible = false;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.gunaTransfarantPictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaTransfarantPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox1.Image")));
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(112, 76);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(120, 238);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 25;
            this.gunaTransfarantPictureBox1.TabStop = false;
            this.gunaTransfarantPictureBox1.Visible = false;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.gunaTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(116, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // KargoTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(225)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 425);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KargoTakip";
            this.Text = "KargoTakip";
            this.Load += new System.EventHandler(this.KargoTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yolCizgi)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox yolCizgi;
        private Guna.UI.WinForms.GunaLabel gunaSa;
        private Guna.UI.WinForms.GunaLabel gunaYol;
        private Guna.UI.WinForms.GunaLabel gunaTeslim;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox3;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox2;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Label label1;
    }
}