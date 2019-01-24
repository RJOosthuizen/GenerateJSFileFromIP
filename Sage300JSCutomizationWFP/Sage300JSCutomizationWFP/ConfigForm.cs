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
            string ipAddress = IpInputTextBox.Text;
            if (ipAddress != "")
            {
                IpCapturedLabel.Text = "IP: " + ipAddress + " has been captured!";
                GenerateFileInfo(ipAddress);
            }
        }
        public void GenerateFileInfo(string ipAddress)
        {
            FileInfo myFile = new FileInfo();
            myFile.JsFileContent = Properties.Resources.APInvoiceEntry_Customization;
            myFile.JsFileName = "APInvoiceEntry_Customization.js";
            myFile.DocPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Sage300CustomizationScreens";
            myFile.SubPath = "\\APInvoice";

            //replace ip with new ip
            myFile.IpAddress = ipAddress;
            myFile.JsFileContent = myFile.JsFileContent.Replace("REPLACEME", myFile.IpAddress);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(myFile.DocPath + myFile.SubPath, myFile.JsFileName)))
            {
                outputFile.WriteLine(myFile.JsFileContent);
                outputFile.Close();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
