using System;
using System.IO;
using System.Windows.Forms;
using Ionic.Zip;

namespace Sage300JSCutomizationWFP
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }
        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmIpButton_Click(object sender, EventArgs e)
        {
            string ipAddress = IpInputTextBox.Text.Trim();
            if (ipAddress != "")
            {
                IpCapturedLabel.Text = "IP: " + ipAddress + " has been captured!";
                GenerateButton.Visible = true;
            }
            else
            {
                IpCapturedLabel.Text = "IP cannot be empty.";
                GenerateButton.Visible = false;
            }
        }
        public void GenerateFileInfo(string ipAddress)
        {
            //CREATE APINVOICE OBJECT
            FileInfo ApInvoiceFile = new FileInfo();
            ApInvoiceFile.JsFileContent = Properties.Resources.APInvoiceEntry_Customization;
            ApInvoiceFile.JsFileName = "APInvoiceEntry_Customization.js";
            ApInvoiceFile.DocPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Sage300CustomizationScreens";
            ApInvoiceFile.SubPath = "\\APInvoiceEntry";

            //replace ApInvoice ip with new ip
            ApInvoiceFile.IpAddress = ipAddress;
            ApInvoiceFile.JsFileContent = ApInvoiceFile.JsFileContent.Replace("REPLACEME", ApInvoiceFile.IpAddress);

            //Write new ApInvoice .js file
            using (StreamWriter ApInvoiceOutputFile = new StreamWriter(Path.Combine(ApInvoiceFile.DocPath + ApInvoiceFile.SubPath, ApInvoiceFile.JsFileName)))
            {
                ApInvoiceOutputFile.WriteLine(ApInvoiceFile.JsFileContent);
                ApInvoiceOutputFile.Close();
            }

            //display feedback
            ListViewResults.Items.Add("Generating...");
            ListViewResults.Items.Add(ApInvoiceFile.JsFileName + " has been generated.");

            //zip files
            ZipFiles(ApInvoiceFile);

            //CREATE ARINVOICE OBJECT
            FileInfo ArInvoiceFile = new FileInfo();
            ArInvoiceFile.JsFileContent = Properties.Resources.ARInvoiceEntry_Customization;
            ArInvoiceFile.JsFileName = "ARInvoiceEntry_Customization.js";
            ArInvoiceFile.DocPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Sage300CustomizationScreens";
            ArInvoiceFile.SubPath = "\\ARInvoiceEntry";

            //replace ArInvoice ip with new ip
            ArInvoiceFile.IpAddress = ipAddress;
            ArInvoiceFile.JsFileContent = ArInvoiceFile.JsFileContent.Replace("REPLACEME", ArInvoiceFile.IpAddress);

            //Write new ArInvoice .js file
            using (StreamWriter ArInvoiceOutputFile = new StreamWriter(Path.Combine(ArInvoiceFile.DocPath + ArInvoiceFile.SubPath, ArInvoiceFile.JsFileName)))
            {
                ArInvoiceOutputFile.WriteLine(ArInvoiceFile.JsFileContent);
                ArInvoiceOutputFile.Close();
            }

            //display feedback
            ListViewResults.Items.Add("Generating...");
            ListViewResults.Items.Add(ArInvoiceFile.JsFileName + " has been generated.");

            //zip files
            ZipFiles(ArInvoiceFile);

            //CREATE APVENDOR OBJECT
            FileInfo ApVendorFile = new FileInfo();
            ApVendorFile.JsFileContent = Properties.Resources.Vendor_Customization;
            ApVendorFile.JsFileName = "Vendor_Customization.js";
            ApVendorFile.DocPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Sage300CustomizationScreens";
            ApVendorFile.SubPath = "\\APVendors";

            //replace ArInvoice ip with new ip
            ApVendorFile.IpAddress = ipAddress;
            ApVendorFile.JsFileContent = ApVendorFile.JsFileContent.Replace("REPLACEME", ApVendorFile.IpAddress);

            //Write new ArInvoice .js file
            using (StreamWriter ApVendorOutputFile = new StreamWriter(Path.Combine(ApVendorFile.DocPath + ApVendorFile.SubPath, ApVendorFile.JsFileName)))
            {
                ApVendorOutputFile.WriteLine(ApVendorFile.JsFileContent);
                ApVendorOutputFile.Close();
            }

            //display feedback
            ListViewResults.Items.Add("Generating...");
            ListViewResults.Items.Add(ApVendorFile.JsFileName + " has been generated.");

            //zip files
            ZipFiles(ApVendorFile);

            //CREATE ARCUSTOMER OBJECT
            FileInfo ArCustomerFile = new FileInfo();
            ArCustomerFile.JsFileContent = Properties.Resources.Customer_Customization;
            ArCustomerFile.JsFileName = "Customer_Customization.js";
            ArCustomerFile.DocPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Sage300CustomizationScreens";
            ArCustomerFile.SubPath = "\\ARCustomers";

            //replace ArInvoice ip with new ip
            ArCustomerFile.IpAddress = ipAddress;
            ArCustomerFile.JsFileContent = ArCustomerFile.JsFileContent.Replace("REPLACEME", ArCustomerFile.IpAddress);

            //Write new ArInvoice .js file
            using (StreamWriter ArCustomerOutputFile = new StreamWriter(Path.Combine(ArCustomerFile.DocPath + ArCustomerFile.SubPath, ArCustomerFile.JsFileName)))
            {
                ArCustomerOutputFile.WriteLine(ArCustomerFile.JsFileContent);
                ArCustomerOutputFile.Close();
            }

            //display feedback
            ListViewResults.Items.Add("Generating...");
            ListViewResults.Items.Add(ArCustomerFile.JsFileName + " has been generated.");

            //zip files
            ZipFiles(ArCustomerFile);

        }

        public void ZipFiles(FileInfo fileInfo)
        {
            //check if zip already exists
            if (File.Exists(fileInfo.DocPath + fileInfo.SubPath + fileInfo.SubPath + ".zip"))
            {
                File.Delete(fileInfo.DocPath + fileInfo.SubPath + fileInfo.SubPath + ".zip");
            }
            //zip files
            using (var zip = new ZipFile())
            {
                zip.AddDirectory(fileInfo.DocPath + fileInfo.SubPath);
                zip.Save(fileInfo.DocPath + fileInfo.SubPath + fileInfo.SubPath + ".zip");
            }
            //display feedback
            ListViewResults.Items.Add("Zipping files...");
            ListViewResults.Items.Add(fileInfo.JsFileName + " has been zipped");
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string ipAddress = IpInputTextBox.Text.Trim();
            if (ipAddress != "")
            {
                GenerateFileInfo(ipAddress);
            }
            else
            {
                IpCapturedLabel.Text = "IP cannot be empty.";
            }
        }
    }
}
