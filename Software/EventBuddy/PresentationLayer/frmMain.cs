using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using PresentationLayer.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace PresentationLayer
{
    public partial class frmMain : MaterialForm
    {
        EventServices eventServices = new EventServices();
        PDFServices pDFServices = new PDFServices();
        MaterialSkinManager changeTheme = MaterialSkinManager.Instance;
        UserServices userServices = new UserServices();

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string relativePath = Path.Combine(exeDirectory, "Resources", "frmMain.pdf");
            helpProvider1.HelpNamespace = relativePath;
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            var loggedInUser = frmLogin.user;
            var isAdmin = userServices.checkForAdminRole(loggedInUser);
            if (isAdmin)
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnCategories.Visible = true;
                btnUsers.Visible = true;
            }
            //MessageBox.Show(userServices.getUserTranslations(loggedInUser).Count().ToString());
            RefreshGUI();
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void RefreshGUI()
        {
            cmbLocation.DataSource = eventServices.GetLocations();
            dgvEvents.DataSource = eventServices.GetAllEvents();
            HideFields();
            ChangeTheme();

            lblEvent.Text = "Događaji";
            btnSearch.Text = "Pretraži";
            btnRefresh.Text = "Osvježi";
            lblDate.Text = "Datum";
            lblPlace.Text = "Mjesto";
            btnSaveAsPDF.Text = "Spremi kao PDF";
            btnProfile.Text = "Profil";
            btnParticipants.Text = "Sudionici";
            btnHideEvent.Text = "Sakrij događaj";
            btnDismissEvent.Text = "Obustavi";
            btnEdit.Text = "Izmijeni podatke";
            btnDelete.Text = "Obriši događaj";
            btnCategories.Text = "Kategorije";
            btnUsers.Text = "Korisnici";
            Text = "Glavna";

            var user = frmLogin.user;
            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                lblEvent.Text = translations.First(t => t.ID_atributa == "lblEvent").prijevod;
                btnSearch.Text = translations.First(t => t.ID_atributa == "btnSearch").prijevod;
                btnRefresh.Text = translations.First(t => t.ID_atributa == "btnRefresh").prijevod;
                lblDate.Text = translations.First(t => t.ID_atributa == "lblDate").prijevod;
                lblPlace.Text = translations.First(t => t.ID_atributa == "lblPlace").prijevod;
                btnSaveAsPDF.Text = translations.First(t => t.ID_atributa == "btnSaveAsPDF").prijevod;
                btnProfile.Text = translations.First(t => t.ID_atributa == "btnProfile").prijevod;
                btnParticipants.Text = translations.First(t => t.ID_atributa == "btnParticipants").prijevod;
                btnHideEvent.Text = translations.First(t => t.ID_atributa == "btnHideEvent").prijevod;
                btnDismissEvent.Text = translations.First(t => t.ID_atributa == "btnDismissEvent").prijevod;
                btnEdit.Text = translations.First(t => t.ID_atributa == "btnEdit").prijevod;
                btnDelete.Text = translations.First(t => t.ID_atributa == "btnDelete").prijevod;
                btnCategories.Text = translations.First(t => t.ID_atributa == "btnCategories").prijevod;
                btnUsers.Text = translations.First(t => t.ID_atributa == "btnUsers").prijevod;
                Text = translations.First(t => t.ID_atributa == "frmMain").prijevod;
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void ChangeTheme()
        {
            if (changeTheme.Theme == MaterialSkinManager.Themes.DARK)
            {
                foreach (DataGridViewRow row in dgvEvents.Rows)
                    row.DefaultCellStyle.BackColor = Color.Black;
                dgvEvents.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvEvents.EnableHeadersVisualStyles = false;
                dgvEvents.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvEvents.DefaultCellStyle.ForeColor = Color.White;
            } else
            {
                foreach (DataGridViewRow row in dgvEvents.Rows)
                    row.DefaultCellStyle.BackColor = Color.White;
                dgvEvents.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvEvents.EnableHeadersVisualStyles = false;
                dgvEvents.RowHeadersDefaultCellStyle.BackColor = Color.White;
                dgvEvents.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var searched = txtSearch.Text;
            var events = eventServices.GetAllEvents();
            var date = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            var filtered = await Task.Run(() => FilterEvents(searched, date, events));
            dgvEvents.DataSource = filtered;
            ChangeTheme();
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private List<dogadaj> FilterEvents(string searched, DateTime date, List<dogadaj> events)
        {
            return events.FindAll(
                x =>
                    x.naziv.ToLower().Contains(searched.ToLower()) &&
                    x.datum >= date
            );
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private List<dogadaj> FilterEvents(string location, string searched, DateTime date, List<dogadaj> events)
        {
            return events.FindAll(
                x =>
                    x.naziv.ToLower().Contains(searched.ToLower()) &&
                    x.mjesto == location && x.datum >= date
            );
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var location = cmbLocation.SelectedItem as string;
            if (location == null) return;
            var events = eventServices.GetAllEvents();
            var searched = txtSearch.Text;
            var date = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            dgvEvents.DataSource = FilterEvents(location, searched, date, events);
            ChangeTheme();
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void HideFields()
        {
            dgvEvents.Columns[5].Visible = false;
            dgvEvents.Columns[6].Visible = false;
            dgvEvents.Columns[7].Visible = false;
            dgvEvents.Columns[11].Visible = false;
            dgvEvents.Columns[12].Visible = false;
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            var _event = dgvEvents.CurrentRow?.DataBoundItem as dogadaj;
            if (_event != null)
            {
                frmParticipants _frmParticipants = new frmParticipants(_event);
                _frmParticipants.ShowDialog();
                RefreshGUI();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profil frmProfil = new Profil();
            frmProfil.ShowDialog();
            RefreshGUI();
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnHideEvent_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows != null)
            {
                var selectedEvent = dgvEvents.CurrentRow.DataBoundItem as dogadaj;
                HideEventFrm hideEventFrm = new HideEventFrm(selectedEvent);
                hideEventFrm.ShowDialog();
                RefreshGUI();
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersFrm usersFrm = new UsersFrm();
            Hide();
            usersFrm.ShowDialog();
            Show();
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnSaveAsPDF_Click(object sender, EventArgs e)
        {
            pDFServices.saveEventsAsPDF(dgvEvents.DataSource as List<dogadaj>, frmLogin.user);
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        private void btnDismissEvent_Click(object sender, EventArgs e)
        {
            var _event = dgvEvents.CurrentRow?.DataBoundItem as dogadaj;
            if (_event != null)
            {
                var dialogResult = MessageBox.Show($"Jeste li sigurni da želite obustaviti događaj {_event.ID}", "Obustavljanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (eventServices.DismissEvent(_event))
                    {
                        MessageBox.Show($"Događaj {_event.ID} obustavljen!", "Obustavljanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGUI();
                    }
                    else MessageBox.Show($"Greška prilikom obustavljanja događaja {_event.ID}!", "Obustavljanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Morate odabrati neki događaj da biste ga obustavili!", "Obustavljanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var _event = dgvEvents.CurrentRow?.DataBoundItem as dogadaj;
            if (_event != null)
            {
                var dialogResult = MessageBox.Show($"Jeste li sigurni da želite obrisati događaj {_event.ID}", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (eventServices.DeleteEvent(_event))
                    {
                        MessageBox.Show($"Događaj {_event.ID} Obrisan!", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGUI();
                    } else MessageBox.Show($"Greška prilikom brisanja događaja {_event.ID}!", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else MessageBox.Show("Morate odabrati neki događaj da biste ga obrisali!", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var _event = dgvEvents.CurrentRow?.DataBoundItem as dogadaj;
            if (_event != null)
            {
                frmEventDetails frmEventDetails = new frmEventDetails(_event);
                frmEventDetails.ShowDialog();
                RefreshGUI();
            }
            else MessageBox.Show("Morate odabrati događaj", "Izmjena", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategories frmCategories = new frmCategories();
            frmCategories.ShowDialog();
        }
    }
}
