namespace Login_Form_Application
{
    public partial class button_login : Form
    {
        public button_login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text=="John" && txt_password.Text=="Program251")
            {
                new Form1().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Username and Password is incorrect. Try again");
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}