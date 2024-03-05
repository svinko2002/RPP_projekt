using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using EntitiesLayer.Entities;
using System.IO;

namespace PresentationLayer
{
    public partial class Profil : MaterialForm
    {
        private UserServices userServices = new UserServices();
        MaterialSkinManager changeTheme = MaterialSkinManager.Instance;

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public Profil()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string relativePath = Path.Combine(exeDirectory, "Resources", "frmProfil.pdf");
            helpProvider1.HelpNamespace = relativePath;
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void frmProfil_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var newPassword = txtNewPassword.Text;
            var user = frmLogin.user;
            if (txtOldPassword.Text == user.lozinka)
            {
                if (string.IsNullOrEmpty(txtOldPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtNewPassword2.Text))
                {
                    MessageBox.Show("Nisu sva polja popunjena!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtNewPassword2.Text == newPassword)
                {
                    user.lozinka = newPassword;
                    if (userServices.updateUser(user))
                    {
                        frmLogin.user = user;
                        MessageBox.Show("Uspješno ažurirani podaci!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom ažuriranja profila!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Lozinke se ne podudarajui!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Molimo unesite staru lozinku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void RefreshGUI()
        {
            msChangeTheme.Checked = frmLogin.theme == MaterialSkinManager.Themes.DARK;
            var user = frmLogin.user;
            txtKorime.Text = user.korime;
            txtNewPassword.Text = "";
            txtNewPassword2.Text = "";
            txtOldPassword.Text = "";

            cbLanguage.DataSource = userServices.getLanguages();
            var userLanguage = userServices.getUserLanguage(user);

            if (userLanguage != null)
            {
                for(int i = 0; i < cbLanguage.Items.Count; i++)
                {
                    var item = cbLanguage.Items[i] as jezik;
                    if (item.ID == userLanguage.ID)
                    {
                        cbLanguage.SelectedIndex = i;
                        break;
                    }
                }
            }

            lblMyProfile.Text = "Moj Profil";
            lblTheme.Text = "Promijeni temu:";
            btnCancel.Text = "Odustani";
            btnSave.Text = "Spremi";

            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                lblMyProfile.Text = translations.First(t => t.ID_atributa == "lblMyProfile").prijevod;
                lblTheme.Text = translations.First(t => t.ID_atributa == "lblTheme").prijevod;
                btnCancel.Text = translations.First(t => t.ID_atributa == "btnCancel").prijevod;
                btnSave.Text = translations.First(t => t.ID_atributa == "btnSave").prijevod;
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void msChangeTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (msChangeTheme.Checked)
            {
                changeTheme.Theme = MaterialSkinManager.Themes.DARK;
                frmLogin.theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                changeTheme.Theme = MaterialSkinManager.Themes.LIGHT;
                frmLogin.theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void cbLanguage_DropDownClosed(object sender, EventArgs e)
        {
            var user = frmLogin.user;
            var language = cbLanguage.SelectedItem as jezik;
            userServices.setUserLanguage(user, language);
            RefreshGUI();
        }
    }
}
   

