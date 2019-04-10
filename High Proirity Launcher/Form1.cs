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
using Microsoft.Win32;


namespace High_Proirity_Launcher
{
    public partial class Form1 : Form
    {
        public string Steam32, Steam64;
        public OpenFileDialog fd = new OpenFileDialog();
        public Process Current_Process = new Process();
        public Form1 ok;
        public string ExeLocation;

        public Form1()
        {
            InitializeComponent();
            priorList.SelectedIndex = 4;
            SteamLoc();
        }

        private void BtnChooseProgram_Click(object sender, EventArgs e)
        {
            ProgramLocation();
        }
        private void BtnRunProgram_Click(object sender, EventArgs e)
        {
            if (steamCheck.Checked)
            {
                RunSteam();
            }
            else
            {
                RunProgram();
            }
        }

        public void SetPriority(Process process)
        {
            switch (priorList.SelectedIndex)
            {
                case 0:
                    process.PriorityClass = ProcessPriorityClass.Idle;
                    break;
                case 1:
                    process.PriorityClass = ProcessPriorityClass.BelowNormal;
                    break;
                case 2:
                    process.PriorityClass = ProcessPriorityClass.Normal;
                    break;
                case 3:
                    process.PriorityClass = ProcessPriorityClass.AboveNormal;
                    break;
                case 4:
                    process.PriorityClass = ProcessPriorityClass.High;
                    break;
                case 5:
                    process.PriorityClass = ProcessPriorityClass.RealTime;
                    break;
                default:
                    process.PriorityClass = ProcessPriorityClass.High;
                    break;
            }
        }

        public bool Is64Bit()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ProgramLocation()
        {
            fd.Filter = "Executable Files(*.exe;*.cmd;*.bat;)|*.exe;*.cmd;*.bat;";
            fd.Title = "Select an executable.";
            if (fd.ShowDialog() == DialogResult.OK || ok.steamCheck.Checked)
            {
                ExeLocation = fd.FileName;
                return ExeLocation;
            }
            else
            {
                return string.Empty;
            }
        }

        public void RunProgram()
        {
            Current_Process.StartInfo = new ProcessStartInfo
            {
                FileName = ExeLocation,
            };
            Current_Process.Start();
            if (!Current_Process.HasExited)
            {
                Current_Process.Refresh();
                SetPriority(Current_Process);
            }

        }
        public string SteamLoc()
        {
            if (Is64Bit() == true)
            {
                object idk = null;
                var steamLocation = Registry.GetValue(
                "HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Valve\\Steam", "InstallPath", idk).ToString();
                SteamTxt.Text = $"Found steam at: {steamLocation}";
                ExeLocation = steamLocation + "\\Steam.exe";
                return Steam64;
            }
            else
            {
                object idk = null;
                var steamLocation = Registry.GetValue(
                "HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam", "InstallPath", idk).ToString();
                SteamTxt.Text = $"Found steam at: {steamLocation}";
                ExeLocation = string.Concat(steamLocation + "\\Steam.exe");
                return Steam32;
            }
        }

        public void RunSteam()
        {
            SteamLoc();
            if (Is64Bit())
            {
                ExeLocation = Steam64;
            }
            else
            {
                ExeLocation = Steam32;
            }
            if (!Current_Process.HasExited)
            {
                // Discard cached information about the process.
                Current_Process.Refresh();
                SetPriority(Current_Process);
            }
        }
    }
}


