using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace CCExtractorGUI
{
    public partial class FormMain : Form
    {
        private void run_hdhr_config()
        {
            Process myHDHRProcess = new Process();
            bool done = false;
            do
            {
                try
                {
                    CancelProcess = false;
                    myHDHRProcess.StartInfo.FileName = tbHDHomeRunPath.Text + "\\hdhomerun_config.exe";
                    myHDHRProcess.StartInfo.UseShellExecute = false;
                    myHDHRProcess.StartInfo.CreateNoWindow = true;
                    myHDHRProcess.StartInfo.RedirectStandardInput = true;
                    myHDHRProcess.StartInfo.RedirectStandardOutput = true;
                    myHDHRProcess.StartInfo.RedirectStandardError = true;
                    switch (hdhr_mode)
                    {
                        case eHDHomeRunMode.HDHR_LOOK_FOR_TUNERS:
                            listBoxTuners.Items.Clear();
                            myHDHRProcess.StartInfo.Arguments = "discover";
                            break;
                    }

                    myHDHRProcess.Start();
                    myHDHRProcess.BeginErrorReadLine();
                    myHDHRProcess.BeginOutputReadLine();
                    myHDHRProcess.ErrorDataReceived += new DataReceivedEventHandler(HDHRStderrHandler);
                    myHDHRProcess.OutputDataReceived += new DataReceivedEventHandler(HDHRStdoutHandler);
                    //StreamWriter sIn = myHDHRProcess.StandardInput;
                    // StreamReader sOut=myProcess.StandardOutput;                    
                    textBoxActivity.Text = "";
                    while (!CancelProcess && !myHDHRProcess.HasExited)
                    {
                        Application.DoEvents();
                        Thread.Sleep(1);
                    }
                    Application.DoEvents();
                    if (!myHDHRProcess.HasExited)
                    {
                        myHDHRProcess.Kill();
                        LabReportsStatus.Text = "Killed";
                        LabReportsCurrentFile.Text = "-";
                    }
                    else
                    {
                        LabReportsStatus.Text = "Done, code=" + myHDHRProcess.ExitCode.ToString();
                    }
                    myHDHRProcess.StandardInput.Close();
                    myHDHRProcess.Close();
                    // myHDHRProcess.WaitForExit();                

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    nowRunning = false;
                }
                switch (hdhr_mode)
                {
                    case eHDHomeRunMode.HDHR_LOOK_FOR_TUNERS:
                        done = true;
                        break;
                }
            }
            while (!done);
        }

    }
}
