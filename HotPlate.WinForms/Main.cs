using System;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotPlate.WinForms
{
    public partial class Main : Form
    {
        private readonly Core.HotPlate hotPlate;
        private int turns;

        public Main()
        {
            InitializeComponent();
            hotPlate = new Core.HotPlate(6);
            PrintHotPlate();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bgHotPlateIterations.RunWorkerAsync();
            btnStart.Enabled = false;
        }

        private void bgHotPlateIterations_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                turns++;
                hotPlate.NextState();
                bgHotPlateIterations.ReportProgress(0);
                Thread.Sleep(1000);
            } while (hotPlate.HighestDiff >= 0.001);
        }

        private void bgHotPlateIterations_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PrintHotPlate();
        }

        private void PrintHotPlate()
        {
            grdHotPlate.Rows.Clear();
            grdHotPlate.ColumnCount = 6;
            for (var i = 0; i < 6; i++)
            {
                grdHotPlate.Rows.Add(new DataGridViewRow());
                for (var j = 0; j < 6; j++)
                {
                    grdHotPlate.Rows[i].Cells[j].Value = hotPlate[i, j];
                }
            }

            lblStatus.Text = $"Turns: {turns} | Diff: {hotPlate.HighestDiff}";
        }

        private void bgHotPlateIterations_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Enabled = true;
        }
    }
}
