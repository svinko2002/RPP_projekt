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
    /// <summary>
    /// <author>Dominik Josipović</author>
    /// </summary>
    public partial class frmParticipants : MaterialForm
    {
        private dogadaj Event { get; set; }
        private EventServices eventServices = new EventServices();
        PDFServices pDFServices = new PDFServices();
        MaterialSkinManager changeTheme = MaterialSkinManager.Instance;
        UserServices userServices = new UserServices();

        public frmParticipants(dogadaj _event)
        {
            InitializeComponent();
            Event = _event;
            Text = Event.naziv;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string relativePath = Path.Combine(exeDirectory, "Resources", "frmParticipants.pdf");
            helpProvider1.HelpNamespace = relativePath;
        }

        private void frmParticipants_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            var participants = eventServices.GetEventParticipants(Event);
            dgvParticipants.DataSource = participants;
            dgvParticipants.Columns[4].Visible = false;
            dgvParticipants.Columns[5].Visible = false;
            dgvParticipants.Columns[6].Visible = false;
            dgvParticipants.Columns[7].Visible = false;
            dgvParticipants.Columns[8].Visible = false;
            dgvParticipants.Columns[9].Visible = false;
            dgvParticipants.Columns[10].Visible = false;
            dgvParticipants.Columns[11].Visible = false;
            dgvParticipants.Columns[12].Visible = false;

            if (changeTheme.Theme == MaterialSkinManager.Themes.DARK)
            {
                foreach (DataGridViewRow row in dgvParticipants.Rows)
                    row.DefaultCellStyle.BackColor = Color.Black;
                dgvParticipants.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvParticipants.EnableHeadersVisualStyles = false;
                dgvParticipants.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvParticipants.DefaultCellStyle.ForeColor = Color.White;
            } else
            {
                foreach (DataGridViewRow row in dgvParticipants.Rows)
                    row.DefaultCellStyle.BackColor = Color.White;
                dgvParticipants.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvParticipants.EnableHeadersVisualStyles = false;
                dgvParticipants.RowHeadersDefaultCellStyle.BackColor = Color.White;
                dgvParticipants.DefaultCellStyle.ForeColor = Color.Black;
            }

            btnSaveAsPDF.Text = "Spremi kao PDF";
            btnBan.Text = "Zabrani pristup";
            btnRemove.Text = "Izbaci";

            var user = frmLogin.user;
            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                btnSaveAsPDF.Text = translations.First(t => t.ID_atributa == "btnSaveAsPDF").prijevod;
                btnBan.Text = translations.First(t => t.ID_atributa == "btnBan").prijevod;
                btnRemove.Text = translations.First(t => t.ID_atributa == "btnRemove").prijevod;

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var user = dgvParticipants.CurrentRow?.DataBoundItem as korisnik;
            if (user != null)
            {
                var dialogResult = MessageBox.Show($"Ukloniti korisnika {user}?", "Uklanjanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    bool executed = eventServices.RemoveUserFromEvent(Event, user);
                    RefreshGUI();
                    if (executed) MessageBox.Show($"Korisnik {user} uspješno uklonjen!", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Greška prilikom uklanjanja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Morate označiti korisnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            var user = dgvParticipants.CurrentRow?.DataBoundItem as korisnik;
            if (user != null)
            {
                var dialogResult = MessageBox.Show($"Zabraniti pristup korisniku {user}?", "Zabrana", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    bool executed = eventServices.BanUserFromEvent(Event, user);
                    RefreshGUI();
                    if (executed) MessageBox.Show($"Korisniku {user} uspješno zabranjen pristup!", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Greška prilikom uklanjanja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Morate označiti korisnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnSaveAsPDF_Click(object sender, EventArgs e)
        {
            pDFServices.saveParticipantsAsPDF(dgvParticipants.DataSource as List<korisnik>, frmLogin.user ,Event);
        }
    }
}
