using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using EntitiesLayer.Exceptions;
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
    public partial class frmEventDetails : MaterialForm
    {
        private EventServices eventServices = new EventServices();
        private dogadaj Event { get; set; }
        public frmEventDetails(dogadaj _event)
        {
            InitializeComponent();
            Event = _event;
            Text = Event.ToString();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string relativePath = Path.Combine(exeDirectory, "Resources", "frmEventDetails.pdf");
            helpProvider1.HelpNamespace = relativePath;
        }

        private void frmEventDetails_Load(object sender, EventArgs e)
        {
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;

            txtName.Text = Event.naziv;
            txtDescription.Text = Event.opis;
            txtLocation.Text = Event.mjesto;
            dtpDate.Value = Event.datum;
            dtpTime.Value = Event.datum;

            RefreshGUI();
        }

        private void RefreshGUI()
        {

            lblName.Text = "Naziv";
            lblOverView.Text = "Opis";
            lblPlace.Text = "Mjesto";
            lblDate.Text = "Datum";
            btnClose.Text = "Odustani";
            btnSave.Text = "Spremi";
           

            UserServices userServices = new UserServices();
            var user = frmLogin.user;
            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                lblName.Text = translations.First(t => t.ID_atributa == "lblName").prijevod;
                lblOverView.Text = translations.First(t => t.ID_atributa == "lblOverView").prijevod;
                lblPlace.Text = translations.First(t => t.ID_atributa == "lblPlace").prijevod;
                lblDate.Text = translations.First(t => t.ID_atributa == "lblDate").prijevod;
                btnClose.Text = translations.First(t => t.ID_atributa == "btnClose").prijevod;
                btnSave.Text = translations.First(t => t.ID_atributa == "btnSave").prijevod;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = true;
            try
            {
                var date = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
                Event.datum = date;
                Event.naziv = txtName.Text;
                Event.opis = txtDescription.Text;
                Event.mjesto = txtLocation.Text;
                eventServices.UpdateEvent(Event);
            }
            catch (EventException ex)
            {
                success = false;
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (success) Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
