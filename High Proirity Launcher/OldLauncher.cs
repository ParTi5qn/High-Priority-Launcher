using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

//    public void run()
//    {
//    }

//    public void runID()
//    {
//        if (!string.IsNullOrWhiteSpace(AppID.Text))
//        {
//            string text = AppID.Text;
//            string text2 = "/C steam://run/" + text;
//            txtFileLoc.Text = text2;
//            game = new Process
//            {
//                StartInfo = new ProcessStartInfo
//                {
//                    FileName = "C:\\Program Files (x86)\\Steam\\steam.exe",
//                    Arguments = text2,
//                    UseShellExecute = false,
//                    RedirectStandardOutput = true
//                }
//            };
//            game.Start();
//            SetPrior();
//        }
//        else
//        {
//            MessageBox.Show("Please enter an App ID", "No App ID found");
//        }
//    }

//    public void btnBrowse_Click(object sender, EventArgs e)
//    {
//        OpenFileDialog openFileDialog = new OpenFileDialog
//        {
//            Filter = "Executable Files(*.exe;*.cmd;*.bat;)|*.exe;*.cmd;*.bat;",
//            Title = "Select an executable."
//        };
//        if (openFileDialog.ShowDialog() == DialogResult.OK)
//        {
//            string fileName = openFileDialog.FileName;
//            txtFileLoc.Text = fileName;
//        }
//    }

//    public void btnRun_Click(object sender, EventArgs e)
//    {
//        try
//        {
//            if (!steamBox.Checked)
//            {
//                string text = txtFileLoc.Text;
//                Process process = new Process();
//                process.StartInfo.FileName = text;
//                process.Start();
//                if (true)
//                {
//                    Thread.Sleep(1000);
//                    Close();
//                }
//            }
//            else
//            {
//                runID();
//            }
//        }
//        catch (InvalidOperationException)
//        {
//            MessageBox.Show("Please select an executable before running.", "No executable selected");
//        }
//        catch (NullReferenceException)
//        {
//        }
//    }

//    public void AppID_TextChanged(object sender, EventArgs e)
//    {
//        if (Regex.IsMatch(AppID.Text, "^[0-9]*$"))
//        {
//            string text = AppID.Text;
//            return;
//        }
//        int num = 0 + 1;
//        AppID.Clear();
//        if (num == 1)
//        {
//            MessageBox.Show("Please enter the AppID of the game", "Steam AppID not found");
//        }
//    }
//}
//}
