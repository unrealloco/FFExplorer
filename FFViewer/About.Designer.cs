﻿namespace FFViewer_cs
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.AppNameVer = new System.Windows.Forms.Label();
            this.LicenseButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.CopyrightJames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppNameVer
            // 
            resources.ApplyResources(this.AppNameVer, "AppNameVer");
            this.AppNameVer.Name = "AppNameVer";
            // 
            // LicenseButton
            // 
            resources.ApplyResources(this.LicenseButton, "LicenseButton");
            this.LicenseButton.Name = "LicenseButton";
            this.LicenseButton.UseVisualStyleBackColor = true;
            this.LicenseButton.Click += new System.EventHandler(this.LicenseButton_Click);
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.Name = "OkButton";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CopyrightJames
            // 
            resources.ApplyResources(this.CopyrightJames, "CopyrightJames");
            this.CopyrightJames.Name = "CopyrightJames";
            // 
            // About
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AppNameVer);
            this.Controls.Add(this.LicenseButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CopyrightJames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label AppNameVer;
        internal System.Windows.Forms.Button LicenseButton;
        internal System.Windows.Forms.Button OkButton;
        internal System.Windows.Forms.Label CopyrightJames;
    }
}