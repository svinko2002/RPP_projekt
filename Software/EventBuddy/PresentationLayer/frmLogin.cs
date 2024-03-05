using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmLogin : MaterialForm
    {
        private UserServices userServices = new UserServices();
        public static korisnik user = null;
        MaterialSkinManager changeTheme = MaterialSkinManager.Instance;
        public static MaterialSkinManager.Themes theme = MaterialSkinManager.Themes.LIGHT;

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string relativePath = Path.Combine(exeDirectory, "Resources", "frmLogin.pdf");
            helpProvider1.HelpNamespace = relativePath;
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void btnSignIn_Click(object sender, EventArgs e) 
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var LoggedUser = userServices.loginUser(txtUsername.Text, txtPassword.Text);
                if(LoggedUser != null)
                {
                    var isAdmin = userServices.checkForAdminRole(LoggedUser);
                    var isMod = userServices.checkForModRole(LoggedUser);
                    if(isAdmin || isMod)
                    {
                        user = LoggedUser;
                        Hide();
                        frmMain frmMain = new frmMain();
                        frmMain.ShowDialog();
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        MessageBox.Show("Nemate dozvoljen pristup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Neuspješna prijava", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
