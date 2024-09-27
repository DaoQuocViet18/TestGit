namespace Hệ_mật_mã
{
    partial class FormHang
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txt_khoa = new Guna.UI2.WinForms.Guna2TextBox();
            rb_dauvao = new RichTextBox();
            rb_daura = new RichTextBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btn_giaima = new Guna.UI2.WinForms.Guna2GradientButton();
            btn_Mahoa = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // txt_khoa
            // 
            txt_khoa.CustomizableEdges = customizableEdges1;
            txt_khoa.DefaultText = "";
            txt_khoa.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_khoa.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_khoa.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_khoa.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_khoa.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_khoa.Font = new Font("Segoe UI", 9F);
            txt_khoa.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_khoa.Location = new Point(140, 195);
            txt_khoa.Name = "txt_khoa";
            txt_khoa.PasswordChar = '\0';
            txt_khoa.PlaceholderText = "";
            txt_khoa.SelectedText = "";
            txt_khoa.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_khoa.Size = new Size(200, 36);
            txt_khoa.TabIndex = 40;
            // 
            // rb_dauvao
            // 
            rb_dauvao.Location = new Point(140, 68);
            rb_dauvao.Name = "rb_dauvao";
            rb_dauvao.Size = new Size(322, 105);
            rb_dauvao.TabIndex = 39;
            rb_dauvao.Text = "";
            rb_dauvao.TextChanged += rb_dauvao_TextChanged;
            // 
            // rb_daura
            // 
            rb_daura.Location = new Point(140, 372);
            rb_daura.Name = "rb_daura";
            rb_daura.Size = new Size(322, 105);
            rb_daura.TabIndex = 38;
            rb_daura.Text = "";
            rb_daura.TextChanged += rb_daura_TextChanged;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = SystemColors.ControlLightLight;
            guna2HtmlLabel3.Location = new Point(14, 421);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(54, 21);
            guna2HtmlLabel3.TabIndex = 37;
            guna2HtmlLabel3.Text = "Đầu ra: ";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = SystemColors.ControlLightLight;
            guna2HtmlLabel2.Location = new Point(14, 210);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(39, 21);
            guna2HtmlLabel2.TabIndex = 36;
            guna2HtmlLabel2.Text = "Khoá ";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = SystemColors.ButtonHighlight;
            guna2HtmlLabel4.Location = new Point(14, 113);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(64, 21);
            guna2HtmlLabel4.TabIndex = 35;
            guna2HtmlLabel4.Text = "Đầu vào: ";
            // 
            // btn_giaima
            // 
            btn_giaima.Animated = true;
            btn_giaima.BackColor = Color.Transparent;
            btn_giaima.BorderRadius = 15;
            btn_giaima.BorderThickness = 2;
            btn_giaima.CustomizableEdges = customizableEdges3;
            btn_giaima.DisabledState.BorderColor = Color.DarkGray;
            btn_giaima.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_giaima.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_giaima.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_giaima.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_giaima.FillColor = Color.FromArgb(82, 83, 85);
            btn_giaima.FillColor2 = Color.FromArgb(40, 42, 52);
            btn_giaima.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_giaima.ForeColor = Color.White;
            btn_giaima.Location = new Point(362, 274);
            btn_giaima.Name = "btn_giaima";
            btn_giaima.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_giaima.Size = new Size(180, 45);
            btn_giaima.TabIndex = 34;
            btn_giaima.Text = "Giải mã";
            btn_giaima.UseTransparentBackground = true;
            btn_giaima.Click += btn_giaima_Click;
            // 
            // btn_Mahoa
            // 
            btn_Mahoa.Animated = true;
            btn_Mahoa.BackColor = Color.Transparent;
            btn_Mahoa.BorderRadius = 15;
            btn_Mahoa.BorderThickness = 2;
            btn_Mahoa.CustomizableEdges = customizableEdges5;
            btn_Mahoa.DisabledState.BorderColor = Color.DarkGray;
            btn_Mahoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Mahoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Mahoa.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_Mahoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Mahoa.FillColor = Color.FromArgb(82, 83, 85);
            btn_Mahoa.FillColor2 = Color.FromArgb(40, 42, 52);
            btn_Mahoa.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Mahoa.ForeColor = Color.White;
            btn_Mahoa.Location = new Point(56, 274);
            btn_Mahoa.Name = "btn_Mahoa";
            btn_Mahoa.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_Mahoa.Size = new Size(180, 45);
            btn_Mahoa.TabIndex = 33;
            btn_Mahoa.Text = "Mã hoá";
            btn_Mahoa.UseTransparentBackground = true;
            btn_Mahoa.Click += btn_Mahoa_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(188, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(422, 33);
            guna2HtmlLabel1.TabIndex = 32;
            guna2HtmlLabel1.Text = "Mật mã Hàng - Hoán vị - Chuyển vị";
            // 
            // FormHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 77, 93);
            ClientSize = new Size(800, 538);
            Controls.Add(txt_khoa);
            Controls.Add(rb_dauvao);
            Controls.Add(rb_daura);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(btn_giaima);
            Controls.Add(btn_Mahoa);
            Controls.Add(guna2HtmlLabel1);
            Name = "FormHang";
            Text = "FormHang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_khoa;
        private RichTextBox rb_dauvao;
        private RichTextBox rb_daura;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2GradientButton btn_giaima;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Mahoa;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}