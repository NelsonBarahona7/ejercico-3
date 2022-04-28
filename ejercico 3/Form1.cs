namespace ejercico_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            public partial class FormLogin : Form
        {
            private void btnlogin_Click(object sender, EventArgs e)
            {
                if (txtuser.Text != "Username" && txtuser.TextLength > 2)
                {
                    if (txtpass.Text != "Password")
                    {
                        UserModel user = new UserModel();
                        var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                        if (validLogin == true)
                        {
                            FormMainMenu mainMenu = new FormMainMenu();
                            MessageBox.Show("Bienvenido " + UserCache.FirstName + ", " + UserCache.LastName);
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();
                        }
                        else
                        {
                            msgError("Incorrect username or password entered. \n   Please try again.");
                            txtpass.Text = "Password";
                            txtpass.UseSystemPasswordChar = false;
                            txtuser.Focus();
                        }
                    }
                    else msgError("Please enter password.");
                }
                else msgError("Please enter username.");
            }
            private void msgError(string msg)
            {
                lblErrorMessage.Text = "    " + msg;
                lblErrorMessage.Visible = true;
            }
            private void Logout(object sender, FormClosedEventArgs e)
            {
                txtpass.Text = "Password";
                txtpass.UseSystemPasswordChar = false;
                txtuser.Text = "Username";
                lblErrorMessage.Visible = false;
                this.Show();
            }
        }
    }
    }
}