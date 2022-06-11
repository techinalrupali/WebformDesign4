using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"E:\S&QBatch";
            if(Directory.Exists(path))
            {
                MessageBox.Show("Folder is already exists");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Folder is created");
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"E:\S&QBatch\Test.txt";
            if(File.Exists(path))
            {
                MessageBox.Show("File is already exists");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("File is created");
            }
        }
        //DirectoryInfo class
        private void btnDirectoryInfo_Click(object sender, EventArgs e)
        {
            string path = @"E:\S&QBatch1";
            DirectoryInfo di = new DirectoryInfo(path);
            if(di.Exists)
            {
                MessageBox.Show("Folder is already exists");
            }
            else
            {
                di.Create();
                MessageBox.Show("Folder is created");
            }
        }

        private void btnCreateDirectoryFile_Click(object sender, EventArgs e)
        {
            string path = @"E:\S&QBatch1\Test.txt";
            FileInfo fi = new FileInfo(path);
            if(fi.Exists)
            {
                MessageBox.Show("File is already exists");
            }
            else
            {
                fi.Create();
                MessageBox.Show("file is created");
            }
        }
    }
}
