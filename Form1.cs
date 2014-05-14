using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DriveSpace
{
    public partial class Form1 : Form
    {
        Directories directory;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load settings

            // set the default directory locations
            popupDirectoryAdd.RootFolder = Environment.SpecialFolder.MyComputer;
            popupDirectoryUpdate.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        private void btnDirAdd_Click(object sender, EventArgs e)
        {
            if (popupDirectoryAdd.ShowDialog() == DialogResult.OK)
            {                               
                directory = new Directories();

                directory.Path = popupDirectoryAdd.SelectedPath.ToString();
                directory.Drive = Directory.GetDirectoryRoot(popupDirectoryAdd.SelectedPath);
                if (directory.Drive == "\\")
                {
                    directory.Drive = "(Network drive)";
                }


                txtDriveLetter.Text = directory.Drive;
                listDirectories.Items.Add(popupDirectoryAdd.SelectedPath);

                directory.Space = Math.Round(directory.GetDirectorySize(directory.Path) / 1024, 2);

                txtDirSpace.Text = directory.Space.ToString();                
            }
        }

        private void btnDirUpdate_Click(object sender, EventArgs e)
        {

            if (popupDirectoryUpdate.ShowDialog() == DialogResult.OK)
            {
                directory.Path = popupDirectoryUpdate.SelectedPath.ToString();
                MessageBox.Show(directory.Path);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       


    }
}
