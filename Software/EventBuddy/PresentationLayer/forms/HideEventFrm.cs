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
    public partial class HideEventFrm : MaterialForm
    {
        dogadaj _selectedEvent = null;
        EventServices eventServices = new EventServices();
        UserServices userServices = new UserServices();

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public HideEventFrm(dogadaj selectedEvent)
        {
            _selectedEvent = selectedEvent;
            InitializeComponent();

            string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string relativePath = Path.Combine(exeDirectory, "Resources", "HideEventFrm.pdf");
            helpProvider1.HelpNamespace = relativePath;
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnHideEvent_Click(object sender, EventArgs e)
        {
            eventServices.hideEvent(_selectedEvent);
            userServices.warnUser(_selectedEvent.ID_korisnik);
            Close();
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            userServices.revokeOrganizerRole(_selectedEvent.ID_korisnik);
            Close();
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HideEventFrm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {

            btnHideEvent.Text = "Sakrij događaj sa slanjem upozorenja";
            btnRemoveRole.Text = "Makni ulogu organizatora";
            btnQuit.Text = "Odustani od sakrivanja";

            var user = frmLogin.user;
            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                btnHideEvent.Text = translations.First(t => t.ID_atributa == "btnHideEvent").prijevod;
                btnRemoveRole.Text = translations.First(t => t.ID_atributa == "btnRemoveRole").prijevod;
                btnQuit.Text = translations.First(t => t.ID_atributa == "btnQuit").prijevod;
            }
        }
    }
}
