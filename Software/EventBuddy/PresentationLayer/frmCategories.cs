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
using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PresentationLayer
{
    public partial class frmCategories : MaterialForm
    {
        public UserServices userServices = new UserServices();
        public CategoryServices categoryServices = new CategoryServices();
        public PDFServices pDFServices = new PDFServices();
        public frmCategories()
        {
            InitializeComponent();

            string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string relativePath = Path.Combine(exeDirectory, "Resources", "frmCategories.pdf");
            helpProvider1.HelpNamespace = relativePath;
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void frmCategories_Load(object sender, EventArgs e)
        {
            RefreshGUI();
            RefreshData();
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void RefreshData()
        {
            dgvCategory.DataSource = categoryServices.getAllRequests();
            dgvCategory.Columns[2].Visible = false;
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void RefreshGUI()
        {
            lblCategory.Text = "Kategorije";
            btnSaveAsPDF.Text = "Spremi kao PDF";
            btnAdd.Text = "Dodaj";
            btnRequest.Text = "Zahtjevi";
            btnCancel.Text = "Odustani";
            btnSave.Text = "Spremi";
            lblNewCategory2.Text = "Nova kategorija:";

            var user = frmLogin.user;
            var translations = userServices.getUserTranslations(user);
            if (translations.Count > 0)
            {
                lblCategory.Text = translations.First(t => t.ID_atributa == "lblCategory").prijevod;
                btnSaveAsPDF.Text = translations.First(t => t.ID_atributa == "btnSaveAsPDF").prijevod;
                btnAdd.Text = translations.First(t => t.ID_atributa == "btnAdd").prijevod;
                btnRequest.Text = translations.First(t => t.ID_atributa == "btnRequest").prijevod;
                btnCancel.Text = translations.First(t => t.ID_atributa == "btnCancel").prijevod;
                btnSave.Text = translations.First(t => t.ID_atributa == "btnSave").prijevod;
                lblNewCategory2.Text = translations.First(t => t.ID_atributa == "lblNewCategory").prijevod;
            }
            
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void btnRequest_Click(object sender, EventArgs e)
        {
            frmRequest frmRequest = new frmRequest();
            frmRequest.ShowDialog();
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblNewCategory2.Visible = true;
            btnAdd.Visible = false;
            btnRequest.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            txtNameOfCategory.Visible = true;
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblNewCategory2.Visible = false;
            btnAdd.Visible = true;
            btnRequest.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            txtNameOfCategory.Visible = false;
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNameOfCategory.Text  != "")
            {
                kategorija newCategory = new kategorija
                {
                    naziv = txtNameOfCategory.Text
                };
                categoryServices.addNewCategory(newCategory);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Naziv kategorije ne smije biti prazan");
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        private void btnSaveAsPDF_Click(object sender, EventArgs e)
        {
            pDFServices.saveCategoriesAsPDF(dgvCategory.DataSource as List<kategorija>, frmLogin.user);
        }
    }
}
