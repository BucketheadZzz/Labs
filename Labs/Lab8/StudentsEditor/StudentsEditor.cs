using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Lab8Core;

namespace Lab8.StudentsEditor
{
    public partial class StudentsEditor : Form
    {
        public StudentsEditor()
        {
            InitializeComponent();

            openToolStripButton.Click += OpenToolStripButtonOnClick;
            saveToolStripButton.Click += SaveToolStripButtonOnClick;
            saveToolStripButton.Enabled = false;
        }

        private void OpenToolStripButtonOnClick(object? sender, EventArgs e)
        {
            openListDialog.ShowDialog();
        }

        private void openListDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var fileExtenstion = Path.GetExtension(openListDialog.FileName)?.ToLower();
                if (!string.IsNullOrEmpty(fileExtenstion))
                {
                    var parser = ParsersList.Items[fileExtenstion];
                    var data = parser.LoadStudents(openListDialog.FileName);

                    if (data.Any())
                    {
                        studentsSource.DataSource = data;
                        studentsGrid.DataSource = studentsSource;
                        saveToolStripButton.Enabled = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong during loading the data. Please check the data source", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void SaveToolStripButtonOnClick(object? sender, EventArgs e)
        {
            saveStudentsDialog.ShowDialog();
        }

        private void saveStudentsDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var fileExtenstion = Path.GetExtension(saveStudentsDialog.FileName)?.ToLower();
                if (!string.IsNullOrEmpty(fileExtenstion))
                {
                    if (!ParsersList.Items.ContainsKey(fileExtenstion))
                    {
                        throw new Exception("Incorrect extension. There are two supported extensions: .csv, .xml");
                    }

                    var parser = ParsersList.Items[fileExtenstion];
                    parser.Save((IList<Student>)studentsSource.DataSource, saveStudentsDialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong during saving the data. Please check the data or the file name", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                //need to remove the corrupted file if something is wrong
                if (!string.IsNullOrWhiteSpace(saveStudentsDialog.FileName) && File.Exists(saveStudentsDialog.FileName))
                {
                    File.Delete(saveStudentsDialog.FileName);
                }
            }
        }
    }
}
