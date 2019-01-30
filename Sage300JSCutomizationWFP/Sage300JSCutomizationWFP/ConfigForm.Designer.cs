namespace Sage300JSCutomizationWFP
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IpAddressLabel = new System.Windows.Forms.Label();
            this.IpInputTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmIpButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.IpCapturedLabel = new System.Windows.Forms.Label();
            this.ListViewResults = new System.Windows.Forms.ListView();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IpAddressLabel
            // 
            this.IpAddressLabel.AutoSize = true;
            this.IpAddressLabel.Location = new System.Drawing.Point(26, 44);
            this.IpAddressLabel.Name = "IpAddressLabel";
            this.IpAddressLabel.Size = new System.Drawing.Size(159, 13);
            this.IpAddressLabel.TabIndex = 0;
            this.IpAddressLabel.Text = "Enter the IP address to be used:";
            // 
            // IpInputTextBox
            // 
            this.IpInputTextBox.Location = new System.Drawing.Point(221, 41);
            this.IpInputTextBox.Name = "IpInputTextBox";
            this.IpInputTextBox.Size = new System.Drawing.Size(126, 20);
            this.IpInputTextBox.TabIndex = 1;
            // 
            // ConfirmIpButton
            // 
            this.ConfirmIpButton.Location = new System.Drawing.Point(404, 39);
            this.ConfirmIpButton.Name = "ConfirmIpButton";
            this.ConfirmIpButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmIpButton.TabIndex = 2;
            this.ConfirmIpButton.Text = "Confirm IP";
            this.ConfirmIpButton.UseVisualStyleBackColor = true;
            this.ConfirmIpButton.Click += new System.EventHandler(this.ConfirmIpButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(713, 415);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // IpCapturedLabel
            // 
            this.IpCapturedLabel.AutoSize = true;
            this.IpCapturedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpCapturedLabel.Location = new System.Drawing.Point(540, 44);
            this.IpCapturedLabel.Name = "IpCapturedLabel";
            this.IpCapturedLabel.Size = new System.Drawing.Size(0, 13);
            this.IpCapturedLabel.TabIndex = 4;
            // 
            // ListViewResults
            // 
            this.ListViewResults.Location = new System.Drawing.Point(29, 165);
            this.ListViewResults.Name = "ListViewResults";
            this.ListViewResults.Size = new System.Drawing.Size(450, 258);
            this.ListViewResults.TabIndex = 6;
            this.ListViewResults.UseCompatibleStateImageBehavior = false;
            this.ListViewResults.View = System.Windows.Forms.View.List;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(66, 105);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 7;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Visible = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ListViewResults);
            this.Controls.Add(this.IpCapturedLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ConfirmIpButton);
            this.Controls.Add(this.IpInputTextBox);
            this.Controls.Add(this.IpAddressLabel);
            this.Name = "ConfigForm";
            this.Text = "Configure IP address";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IpAddressLabel;
        private System.Windows.Forms.TextBox IpInputTextBox;
        private System.Windows.Forms.Button ConfirmIpButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label IpCapturedLabel;
        private System.Windows.Forms.ListView ListViewResults;
        private System.Windows.Forms.Button GenerateButton;
    }
}

