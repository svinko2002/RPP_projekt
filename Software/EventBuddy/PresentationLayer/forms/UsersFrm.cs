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
    public partial class UsersFrm : MaterialForm
    {
        UserServices userService = new UserServices();
        RequestOrganizerService requestOrganizerService = new RequestOrganizerService();
        PDFServices pDFServices = new PDFServices();

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public UsersFrm()
        {
            InitializeComponent();

            string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string relativePath = Path.Combine(exeDirectory, "Resources", "UsersFrm.pdf");
            helpProvider1.HelpNamespace = relativePath;
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnShowEvents_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void UsersFrm_Load(object sender, EventArgs e)
        {
            showRequests();
            showUsers();
            RefreshGUI();
        }

        private void RefreshGUI()
        {

            lblUser.Text = "Korisnici";
            lblAdministratorRequest.Text = "Zahtjev za organizatora";
            btnRefreshUsers.Text = "Osvježi";
            btnSaveAsPDFUsers.Text = "Spremi kao PDF";
            btnRefreshRequests.Text = "Osvježi";
            btnSaveAsPDFRequests.Text = "Spremi kao PDF";
            btnEditUser.Text = "Uredi korisnika";
            btnAccept.Text = "Prihvati";
            btnDecline.Text = "Odbij";

            UserServices userServices = new UserServices();
            var user = frmLogin.user;
            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                lblUser.Text = translations.First(t => t.ID_atributa == "lblUser").prijevod;
                lblAdministratorRequest.Text = translations.First(t => t.ID_atributa == "lblAdministratorRequest").prijevod;
                btnRefreshUsers.Text = translations.First(t => t.ID_atributa == "btnRefreshUsers").prijevod;
                btnSaveAsPDFUsers.Text = translations.First(t => t.ID_atributa == "btnSaveAsPDFUsers").prijevod;
                btnRefreshRequests.Text = translations.First(t => t.ID_atributa == "btnRefreshRequests").prijevod;
                btnSaveAsPDFRequests.Text = translations.First(t => t.ID_atributa == "btnSaveAsPDFRequests").prijevod;
                btnEditUser.Text = translations.First(t => t.ID_atributa == "btnEditUser").prijevod;
                btnAccept.Text = translations.First(t => t.ID_atributa == "btnAccept").prijevod;
                btnDecline.Text = translations.First(t => t.ID_atributa == "btnDecline").prijevod;
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var selectedUser = dgvUsers.CurrentRow?.DataBoundItem as korisnik;
            if (selectedUser != null)
            {
                EditUserFrm editUserFrm = new EditUserFrm(selectedUser);
                editUserFrm.ShowDialog();
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void showRequests()
        {
            dgvUserRequests.DataSource = requestOrganizerService.getAllRequests();
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void showUsers()
        {
            dgvUsers.DataSource = userService.getAllUsers();
            dgvUsers.Columns[6].Visible = false;
            dgvUsers.Columns[7].Visible = false;
            dgvUsers.Columns[8].Visible = false;
            dgvUsers.Columns[9].Visible = false;
            dgvUsers.Columns[10].Visible = false;
            dgvUsers.Columns[11].Visible = false;
            dgvUsers.Columns[12].Visible = false;
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            var selectedRequst = dgvUserRequests.CurrentRow?.DataBoundItem as zahtjev_organizator;
            if (selectedRequst != null)
            {
                requestOrganizerService.acceptOrganizerRequest(selectedRequst);
                userService.addOrganizerRole(selectedRequst.ID_korisnik);
                showRequests();
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnDecline_Click(object sender, EventArgs e)
        {
            var selectedRequst = dgvUserRequests.CurrentRow?.DataBoundItem as zahtjev_organizator;
            if (selectedRequst != null)
            {
                requestOrganizerService.declineOrganizerRequest(selectedRequst);
                showRequests();
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnSaveAsPDFUsers_Click(object sender, EventArgs e)
        {
            pDFServices.saveUsersAsPDF(dgvUsers.DataSource as List<korisnik>, frmLogin.user);
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnSaveAsPDFRequests_Click(object sender, EventArgs e)
        {
            pDFServices.saveOrganizerRequestsAsPDF(dgvUserRequests.DataSource as List<zahtjev_organizator>, frmLogin.user);
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            showUsers();
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnRefreshRequests_Click(object sender, EventArgs e)
        {
            showRequests();
        }
    }
}
