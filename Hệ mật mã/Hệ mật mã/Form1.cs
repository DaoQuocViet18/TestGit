namespace Hệ_mật_mã
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPlayfair());
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCaesar());
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_thaythe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThaythe());
        }

        private void btn_affine_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAffine());
        }

        private void btn_vigenere_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormVigenere());

        }

        private void btn_hill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHill());
        }

        private void btn_hang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHang());

        }
    }
}
