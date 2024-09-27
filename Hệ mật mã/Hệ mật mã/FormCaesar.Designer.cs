namespace Hệ_mật_mã
{
    partial class FormCaesar
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
            btn_Mahoa = new Guna.UI2.WinForms.Guna2GradientButton();
            btn_giaima = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            rb_daura = new RichTextBox();
            contextmenustrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            fToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            rb_dauvao = new RichTextBox();
            txt_khoa = new Guna.UI2.WinForms.Guna2TextBox();
            contextmenustrip.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Mahoa
            // 
            btn_Mahoa.Animated = true;
            btn_Mahoa.BackColor = Color.Transparent;
            btn_Mahoa.BorderRadius = 15;
            btn_Mahoa.BorderThickness = 2;
            btn_Mahoa.CustomizableEdges = customizableEdges1;
            btn_Mahoa.DisabledState.BorderColor = Color.DarkGray;
            btn_Mahoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Mahoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Mahoa.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_Mahoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Mahoa.FillColor = Color.FromArgb(82, 83, 85);
            btn_Mahoa.FillColor2 = Color.FromArgb(40, 42, 52);
            btn_Mahoa.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Mahoa.ForeColor = Color.White;
            btn_Mahoa.Location = new Point(161, 218);
            btn_Mahoa.Name = "btn_Mahoa";
            btn_Mahoa.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_Mahoa.Size = new Size(180, 45);
            btn_Mahoa.TabIndex = 12;
            btn_Mahoa.Text = "Mã hoá";
            btn_Mahoa.UseTransparentBackground = true;
            btn_Mahoa.Click += btn_Mahoa_Click;
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
            btn_giaima.Location = new Point(467, 218);
            btn_giaima.Name = "btn_giaima";
            btn_giaima.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_giaima.Size = new Size(180, 45);
            btn_giaima.TabIndex = 13;
            btn_giaima.Text = "Giải mã";
            btn_giaima.UseTransparentBackground = true;
            btn_giaima.Click += btn_giaima_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.ButtonHighlight;
            guna2HtmlLabel1.Location = new Point(119, 57);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(64, 21);
            guna2HtmlLabel1.TabIndex = 14;
            guna2HtmlLabel1.Text = "Đầu vào: ";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = SystemColors.ControlLightLight;
            guna2HtmlLabel2.Location = new Point(119, 154);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(44, 21);
            guna2HtmlLabel2.TabIndex = 15;
            guna2HtmlLabel2.Text = "Khoá: ";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = SystemColors.ControlLightLight;
            guna2HtmlLabel3.Location = new Point(119, 365);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(54, 21);
            guna2HtmlLabel3.TabIndex = 16;
            guna2HtmlLabel3.Text = "Đầu ra: ";
            // 
            // rb_daura
            // 
            rb_daura.ContextMenuStrip = contextmenustrip;
            rb_daura.Location = new Point(245, 316);
            rb_daura.Name = "rb_daura";
            rb_daura.Size = new Size(322, 105);
            rb_daura.TabIndex = 17;
            rb_daura.Text = "";
            // 
            // contextmenustrip
            // 
            contextmenustrip.Items.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem, fToolStripMenuItem, clearToolStripMenuItem });
            contextmenustrip.Name = "guna2ContextMenuStrip1";
            contextmenustrip.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            contextmenustrip.RenderStyle.BorderColor = Color.Gainsboro;
            contextmenustrip.RenderStyle.ColorTable = null;
            contextmenustrip.RenderStyle.RoundedEdges = true;
            contextmenustrip.RenderStyle.SelectionArrowColor = Color.White;
            contextmenustrip.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            contextmenustrip.RenderStyle.SelectionForeColor = Color.White;
            contextmenustrip.RenderStyle.SeparatorColor = Color.Gainsboro;
            contextmenustrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            contextmenustrip.Size = new Size(123, 92);
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(122, 22);
            openFileToolStripMenuItem.Text = "Open file";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(122, 22);
            saveFileToolStripMenuItem.Text = "Save file";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.Size = new Size(122, 22);
            fToolStripMenuItem.Text = "Font";
            fToolStripMenuItem.Click += fToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(122, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // rb_dauvao
            // 
            rb_dauvao.ContextMenuStrip = contextmenustrip;
            rb_dauvao.Location = new Point(245, 12);
            rb_dauvao.Name = "rb_dauvao";
            rb_dauvao.Size = new Size(322, 105);
            rb_dauvao.TabIndex = 18;
            rb_dauvao.Text = "";
            // 
            // txt_khoa
            // 
            txt_khoa.CustomizableEdges = customizableEdges5;
            txt_khoa.DefaultText = "";
            txt_khoa.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_khoa.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_khoa.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_khoa.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_khoa.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_khoa.Font = new Font("Segoe UI", 9F);
            txt_khoa.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_khoa.Location = new Point(245, 139);
            txt_khoa.Name = "txt_khoa";
            txt_khoa.PasswordChar = '\0';
            txt_khoa.PlaceholderText = "";
            txt_khoa.SelectedText = "";
            txt_khoa.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_khoa.Size = new Size(200, 36);
            txt_khoa.TabIndex = 19;
            // 
            // FormCaesar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 77, 93);
            ClientSize = new Size(809, 466);
            Controls.Add(txt_khoa);
            Controls.Add(rb_dauvao);
            Controls.Add(rb_daura);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btn_giaima);
            Controls.Add(btn_Mahoa);
            Name = "FormCaesar";
            Text = "FormCaesar";
            contextmenustrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_Mahoa;
        private Guna.UI2.WinForms.Guna2GradientButton btn_giaima;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private RichTextBox rb_daura;
        private RichTextBox rb_dauvao;
        private Guna.UI2.WinForms.Guna2TextBox txt_khoa;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip contextmenustrip;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
    }
}