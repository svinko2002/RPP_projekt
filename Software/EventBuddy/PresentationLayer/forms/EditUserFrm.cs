using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
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
using System.IO;

namespace PresentationLayer.forms
{
    public partial class EditUserFrm : MaterialForm
    {
        korisnik _selectedUser;
        UserServices userService = new UserServices();
        bool organizerRoleInit = false;
        bool organizerRoleAfter = false;
        bool modRoleInit = false;
        bool modRoleAfter = false;

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public EditUserFrm(korisnik selectedUser)
        {
            InitializeComponent();
            _selectedUser = selectedUser;
            btnMod.Visible = false;
            if (userService.checkForAdminRole(frmLogin.user))
            {
                btnMod.Visible = true;
            }

            string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string relativePath = Path.Combine(exeDirectory, "Resources", "EditUserFrm.pdf");
            helpProvider1.HelpNamespace = relativePath;
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void EditUserFrm_Load(object sender, EventArgs e)
        {
            txtName.Text = _selectedUser.ime;
            txtSurname.Text = _selectedUser.prezime;
            txtUsername.Text = _selectedUser.korime;
            txtNumberOfWarnings.Text = _selectedUser.upozorenja.ToString();

            btnOrganizerBox.BackColor = Color.LightSalmon;
            btnModBox.BackColor = Color.LightSalmon;

            if(userService.checkForOrganizerRole(_selectedUser))
            {
                btnOrganizerBox.BackColor = Color.LightGreen;
                btnOrganizer.Text = "Makni ulogu";
                organizerRoleInit = true;
                organizerRoleAfter = true;
            }
            if (userService.checkForModRole(_selectedUser))
            {
                btnModBox.BackColor = Color.LightGreen;
                btnMod.Text = "Makni ulogu";
                modRoleInit = true;
                modRoleAfter = true;
            }

            RefreshGUI();
        }

        private void RefreshGUI()
        {

            lblName.Text = "Ime";
            lblSurname.Text = "Prezime";
            lblUsername.Text = "Korisničko ime";
            lblAlertNumber.Text = "Broj upozorenja:";
            lblRole.Text = "Uloge:";
            btnOrganizerBox.Text = "Organizator";
            btnModBox.Text = "Moderator";
            btnOrganizer.Text = "Dodaj ulogu";
            btnMod.Text = "Dodaj ulogu";
            btnQuit.Text = "Odustani";
            btnSave.Text = "Spremi";


            UserServices userServices = new UserServices();
            var user = frmLogin.user;
            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                lblName.Text = translations.First(t => t.ID_atributa == "lblName").prijevod;
                lblSurname.Text = translations.First(t => t.ID_atributa == "lblSurname").prijevod;
                lblUsername.Text = translations.First(t => t.ID_atributa == "lblUsername").prijevod;
                lblAlertNumber.Text = translations.First(t => t.ID_atributa == "lblAlertNumber").prijevod;
                lblRole.Text = translations.First(t => t.ID_atributa == "lblRole").prijevod;
                btnOrganizerBox.Text = translations.First(t => t.ID_atributa == "btnOrganizerBox").prijevod;
                btnModBox.Text = translations.First(t => t.ID_atributa == "btnModBox").prijevod;
                btnOrganizer.Text = translations.First(t => t.ID_atributa == "btnOrganizer").prijevod;
                btnMod.Text = translations.First(t => t.ID_atributa == "btnMod").prijevod;
                btnQuit.Text = translations.First(t => t.ID_atributa == "btnQuit").prijevod;
                btnSave.Text = translations.First(t => t.ID_atributa == "btnSave").prijevod;

            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnOrganizer_Click(object sender, EventArgs e)
        {
            if(btnOrganizerBox.BackColor == Color.LightGreen)
            {
                btnOrganizerBox.BackColor = Color.LightSalmon;
                btnOrganizer.Text = "Dodaj ulogu";
                organizerRoleAfter = false;
            }
            else
            {
                btnOrganizerBox.BackColor = Color.LightGreen;
                btnOrganizer.Text = "Makni ulogu";
                organizerRoleAfter = true;
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnMod_Click(object sender, EventArgs e)
        {
            if (btnModBox.BackColor == Color.LightGreen)
            {
                btnModBox.BackColor = Color.LightSalmon;
                btnMod.Text = "Dodaj ulogu";
                modRoleAfter = false;
            }
            else
            {
                btnModBox.BackColor = Color.LightGreen;
                btnMod.Text = "Makni ulogu";
                modRoleAfter = true;
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (organizerRoleInit != organizerRoleAfter)
            {
                MessageBox.Show("Promijenjena uloga organizatora");
                if(!organizerRoleAfter)
                {
                    userService.revokeOrganizerRole(_selectedUser.ID);
                }
                else
                {
                    userService.addOrganizerRole(_selectedUser.ID);
                }
            }

            if (modRoleInit != modRoleAfter)
            {
                MessageBox.Show("Promijenjena uloga moderatora");
                if(!modRoleAfter)
                {
                    userService.revokeModRole(_selectedUser.ID);
                }
                else
                {
                    userService.addModRole(_selectedUser.ID);
                }
            }

            Close();
        }
    }
}
