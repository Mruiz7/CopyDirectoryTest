using DirectoryHelperExtensions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDirectory
{
    public partial class FormCopyDirectory : Form
    {
        #region [ -- Constructors -- ]

        public FormCopyDirectory()
        {
            InitializeComponent();
        }
        #endregion

        #region [ -- Properties & Attributes   -- ]     

        private static int indexRow = 0;

        #endregion

        #region [ -- Click Methods -- ] 

        private async void btnCopyDirectory_Click(object sender, EventArgs e)
        {
            int valueRow = indexRow;
            string originDirectory = txtSourceDirectory.Text;
            string destinationDirectory = txtDestinationDirectory.Text;
            await Task.Run(() => ValidateAndCopyNewDirectory(originDirectory, destinationDirectory, valueRow));
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogSource.ShowDialog() == DialogResult.OK)
            {
                txtSourceDirectory.Text = folderBrowserDialogSource.SelectedPath;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogDestination.ShowDialog() == DialogResult.OK)
            {
                txtDestinationDirectory.Text = folderBrowserDialogDestination.SelectedPath;
            }
        }

        private void btnClearDirectorySelected_Click(object sender, EventArgs e)
        {
            txtSourceDirectory.Text = "";
            txtDestinationDirectory.Text = "";
        }

        #endregion

        #region [ -- Private Methods -- ] 

        private async Task<bool> ValidateAndCopyNewDirectory(string originDirectory, string destinationDirectory, int valueRow)
        {
            if (originDirectory == "" || destinationDirectory == "")
            {
                MessageBox.Show("Requires both folder");
                return false;
            }
            //we increase the number of the column
            indexRow++;
            await CreateRowAndCopyDirectory(originDirectory, destinationDirectory, valueRow);

            return true;
        }

        private async Task CreateRowAndCopyDirectory(string originDirectory, string destinationDirectory, int valueRow)
        {
            try
            {
                Stopwatch swTime = new Stopwatch();
                swTime.Start();

                dataGridViewProgress.Invoke(new Action(() => { dataGridViewProgress.Rows.Add(valueRow, originDirectory, destinationDirectory, "Copying", "In Progress"); }));
                dataGridViewProgress["ColumnStatus", valueRow].Style.BackColor = Color.Yellow;

                bool resultCopy = await Task.Run(() => CopyDirectoryHelper.DirectoryCopy(originDirectory, destinationDirectory));

                swTime.Stop();

                dataGridViewProgress["ColumnTimeCopy", valueRow].Value = swTime.ElapsedTicks.ToString();

                if (resultCopy)
                {
                    dataGridViewProgress["ColumnStatus", valueRow].Style.BackColor = Color.Green;
                    dataGridViewProgress["ColumnStatus", valueRow].Value = "Copied";
                }
                else
                {
                    dataGridViewProgress["ColumnStatus", valueRow].Style.BackColor = Color.Red;
                    dataGridViewProgress["ColumnStatus", valueRow].Value = "Error";
                }
            }
            catch (Exception ex)
            {
                dataGridViewProgress["ColumnStatus", valueRow].Style.BackColor = Color.Red;
                dataGridViewProgress["ColumnStatus", valueRow].Value = "Error";
                dataGridViewProgress["ColumnTimeCopy", valueRow].Value = "0";

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        #endregion

    }
}
