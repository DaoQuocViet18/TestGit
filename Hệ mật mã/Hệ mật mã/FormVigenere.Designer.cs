namespace Hệ_mật_mã
{
    partial class FormVigenere
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtPlainText = new RichTextBox();
            btnDecrypt = new Guna.UI2.WinForms.Guna2GradientButton();
            btnEncrypt = new Guna.UI2.WinForms.Guna2GradientButton();
            txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            txtResult = new RichTextBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            contextmenustrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            fToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            contextmenustrip.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.ContextMenuStrip = contextmenustrip;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(284, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(207, 33);
            guna2HtmlLabel1.TabIndex = 33;
            guna2HtmlLabel1.Text = "Mật Mã Vigenère";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.ContextMenuStrip = contextmenustrip;
            guna2HtmlLabel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = SystemColors.ControlLightLight;
            guna2HtmlLabel2.Location = new Point(54, 108);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(100, 21);
            guna2HtmlLabel2.TabIndex = 34;
            guna2HtmlLabel2.Text = "Nhập văn bản: ";
            // 
            // txtPlainText
            // 
            txtPlainText.ContextMenuStrip = contextmenustrip;
            txtPlainText.Location = new Point(213, 67);
            txtPlainText.Name = "txtPlainText";
            txtPlainText.Size = new Size(435, 101);
            txtPlainText.TabIndex = 40;
            txtPlainText.Text = "";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Animated = true;
            btnDecrypt.BackColor = Color.Transparent;
            btnDecrypt.BorderRadius = 15;
            btnDecrypt.BorderThickness = 2;
            btnDecrypt.ContextMenuStrip = contextmenustrip;
            btnDecrypt.CustomizableEdges = customizableEdges1;
            btnDecrypt.DisabledState.BorderColor = Color.DarkGray;
            btnDecrypt.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDecrypt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDecrypt.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnDecrypt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDecrypt.FillColor = Color.FromArgb(82, 83, 85);
            btnDecrypt.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDecrypt.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecrypt.ForeColor = Color.White;
            btnDecrypt.Location = new Point(426, 263);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDecrypt.Size = new Size(180, 45);
            btnDecrypt.TabIndex = 42;
            btnDecrypt.Text = "Giải mã";
            btnDecrypt.UseTransparentBackground = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Animated = true;
            btnEncrypt.BackColor = Color.Transparent;
            btnEncrypt.BorderRadius = 15;
            btnEncrypt.BorderThickness = 2;
            btnEncrypt.ContextMenuStrip = contextmenustrip;
            btnEncrypt.CustomizableEdges = customizableEdges3;
            btnEncrypt.DisabledState.BorderColor = Color.DarkGray;
            btnEncrypt.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEncrypt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEncrypt.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnEncrypt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEncrypt.FillColor = Color.FromArgb(82, 83, 85);
            btnEncrypt.FillColor2 = Color.FromArgb(40, 42, 52);
            btnEncrypt.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncrypt.ForeColor = Color.White;
            btnEncrypt.Location = new Point(120, 263);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEncrypt.Size = new Size(180, 45);
            btnEncrypt.TabIndex = 41;
            btnEncrypt.Text = "Mã hoá";
            btnEncrypt.UseTransparentBackground = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // txtKey
            // 
            txtKey.ContextMenuStrip = contextmenustrip;
            txtKey.CustomizableEdges = customizableEdges5;
            txtKey.DefaultText = "";
            txtKey.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtKey.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtKey.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtKey.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtKey.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtKey.Font = new Font("Segoe UI", 9F);
            txtKey.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtKey.Location = new Point(213, 204);
            txtKey.Name = "txtKey";
            txtKey.PasswordChar = '\0';
            txtKey.PlaceholderText = "";
            txtKey.SelectedText = "";
            txtKey.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtKey.Size = new Size(200, 36);
            txtKey.TabIndex = 43;
            // 
            // txtResult
            // 
            txtResult.ContextMenuStrip = contextmenustrip;
            txtResult.Location = new Point(213, 338);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(435, 101);
            txtResult.TabIndex = 45;
            txtResult.Text = "";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.ContextMenuStrip = contextmenustrip;
            guna2HtmlLabel3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = SystemColors.ControlLightLight;
            guna2HtmlLabel3.Location = new Point(54, 219);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(39, 21);
            guna2HtmlLabel3.TabIndex = 46;
            guna2HtmlLabel3.Text = "Khoá";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.ContextMenuStrip = contextmenustrip;
            guna2HtmlLabel4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = SystemColors.ControlLightLight;
            guna2HtmlLabel4.Location = new Point(54, 380);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(61, 21);
            guna2HtmlLabel4.TabIndex = 47;
            guna2HtmlLabel4.Text = "Kết quả:";
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
            // FormVigenere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 77, 93);
            ClientSize = new Size(800, 481);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(txtResult);
            Controls.Add(txtKey);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtPlainText);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Name = "FormVigenere";
            Text = "FormVigenere";
            Load += FormVigenere_Load;
            contextmenustrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private RichTextBox txtPlainText;
        private Guna.UI2.WinForms.Guna2GradientButton btnDecrypt;
        private Guna.UI2.WinForms.Guna2GradientButton btnEncrypt;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private RichTextBox txtResult;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip contextmenustrip;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
    }
}