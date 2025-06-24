using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;

namespace UnicomTICManagementSystem.Views
{
    public partial class LoginForm : Form
    {
         public string SelectedRole { get; private set; }
         public LoginForm()
         {
             InitializeComponent();
         }


         private void btnLogin_Click(object sender, EventArgs e)
         {
             string username = txtUsername.Text.Trim();
             string password = txtPassword.Text.Trim();
             string role = Controllers.LoginController.CheckLogin(username, password);
             if (role != null)
             {
                 MessageBox.Show("Login Successful! Role:" + role);
                 this.Hide();
                 MainForm mainForm=new MainForm(role);
                 mainForm.ShowDialog();
                 this.Close();
             }
             else
             {
                 MessageBox.Show("Invalid Username or Password!");
             }
         }


         private void pictureBox1_Click(object sender, EventArgs e)
         {

         }
       
    }
}

    


