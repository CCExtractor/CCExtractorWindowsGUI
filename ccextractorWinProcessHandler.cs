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
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (nowRunning)
                CancelProcess = true;
            else
            {
                initReportLabels();
                textBox1.Clear();
                CancelProcess = false;
                TSProgramNumberList = new List<String>();
                btnGo.Text = "Cancel";
                int currentFile = 0;
                while ((currentFile < listViewInputFiles.Items.Count || rbInputUTP.Checked) && !CancelProcess)
                {
                    String filename;
                    if (rbInputUTP.Checked)
                        filename = "";
                    else
                        filename = listViewInputFiles.Items[currentFile].Text.ToString();
                    eState state = eState.Init; // 0=> init, 1=> wtvccdump.exe pass, 2=> ccextractorwin.exe pass, 3=> Done
                    nowRunning = true;
                    state = eState.ccextractorwin;
                    if (state == eState.ccextractorwin && rbInputUTP.Checked)
                        progressBarActivity.Visible = true;
                    else
                        progressBarActivity.Visible = false;
                    while (state != eState.Done)
                    {
                        Process myProcess = new Process();
                        string processargs = "";
                        if (state == eState.wtvccdump)
                        {
                            myProcess.StartInfo.FileName = App_Path() + "wtvccdump.exe";
                            myProcess.StartInfo.UseShellExecute = false;
                            myProcess.StartInfo.CreateNoWindow = true;
                            myProcess.StartInfo.RedirectStandardInput = true;
                            myProcess.StartInfo.RedirectStandardOutput = true;
                            myProcess.StartInfo.RedirectStandardError = true;
                            processargs = "--with-gui-reports=1 --input " + "\"" + filename + "\"";
                            // Don't increment current file. The next state will do it for us
                        }
                        if (state == eState.ccextractorwin)
                        {
                            myProcess.StartInfo.FileName = App_Path() + getBinaryName();
                            myProcess.StartInfo.UseShellExecute = false;
                            myProcess.StartInfo.CreateNoWindow = true;
                            myProcess.StartInfo.RedirectStandardInput = true;
                            myProcess.StartInfo.RedirectStandardOutput = true;
                            myProcess.StartInfo.RedirectStandardError = true;
                            processargs = getSwitches();

                            if (rbSplitIndividual.Checked)
                            {
                                processargs = processargs + " \"" + filename + "\"";
                                currentFile++;
                            }
                            else
                            {
                                for (int i = currentFile; i < listViewInputFiles.Items.Count; i++)
                                    processargs = processargs + " \"" + listViewInputFiles.Items[i].Text.ToString() + "\"";
                                currentFile = listViewInputFiles.Items.Count;
                            }
                        }

                        myProcess.StartInfo.Arguments = processargs;
                        myProcess.Start();
                        LabReportsStatus.Text = "Running (PID " + myProcess.Id + ")";
                        myProcess.BeginErrorReadLine();
                        myProcess.BeginOutputReadLine();
                        StreamWriter sIn = myProcess.StandardInput;
                        // StreamReader sOut=myProcess.StandardOutput;                    
                        myProcess.ErrorDataReceived += new DataReceivedEventHandler(StderrHandler);
                        myProcess.OutputDataReceived += new DataReceivedEventHandler(StdoutHandler);
                        textBoxActivity.Text = Environment.NewLine;
                        while (!CancelProcess && !myProcess.HasExited)
                        {
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }
                        Application.DoEvents();
                        if (!myProcess.HasExited)
                        {
                            myProcess.Kill();
                            LabReportsStatus.Text = "Killed";
                            LabReportsCurrentFile.Text = "-";
                        }
                        else
                        {
                            LabReportsStatus.Text = "Done, code=" + myProcess.ExitCode.ToString();
                        }
                        //textBoxActivity.AppendText(sOut.ReadToEnd());
                        sIn.Close();
                        // sOut.Close();
                        switch (state)
                        {
                            case eState.wtvccdump:
                                if (myProcess.ExitCode == 0 && CancelProcess == false)
                                {
                                    state = eState.ccextractorwin;
                                    filename = filename + ".hex";
                                }
                                else
                                {
                                    // Something happened in wtvccdump so we can't continue                                    
                                    LabReportsCurrentFile.Text = "-";
                                    if (CancelProcess)
                                        LabReportsStatus.Text = "Cancelled by user.";
                                    else
                                        LabReportsStatus.Text = "wtvccdump failed: " + GetTextErrorFromHRESUL(myProcess.ExitCode);
                                    currentFile++; // Move on to next file.
                                    state = eState.Done;
                                }
                                break;
                            case eState.ccextractorwin:
                                /* if (isWTV && cbInputOptionsDeleteIntermediateFilesWTV.Checked)
                                    File.Delete(filename); */
                                state = eState.Done;
                                if (TSProgramNumberList.Count > 0 && myProcess.ExitCode != 0)
                                {
                                    MessageBox.Show("Processing was cancelled by CCExtractor because input is a multiprogram TS but no program was manually selected. You can do it from the Advanced input tab. A list of found PIDs is available in the activity window.");
                                    TSProgramNumberList.Clear();
                                }
                                break;
                        }
                        myProcess.Close();
                    } // while (state != eState.Done)
                    if (rbInputUTP.Checked) // Get out, there's no files here
                        break;
                } // file loop
                btnGo.Text = "Start";
                nowRunning = false;
                progressBarActivity.Visible = false;
            }
        }

        private void ProcessStdoutStringMethod(String data)
        {
            textBoxActivity.AppendText(data + Environment.NewLine);
            textBoxActivity.Refresh();
        }

        private void ProcessStderrStringMethod(String data)
        {
            try
            {
                if (data.StartsWith("###"))
                {
                    String[] parms = data.Substring(3).Split('#');
                    string remainder = ""; // Everything after the first token
                    if (data.Length > 4 + parms[0].Length)
                        remainder = data.Substring(4 + parms[0].Length);

                    switch (parms[0])
                    {
                        case "VERSION":
                            if (parms.Length == 3)
                            {
                                LabReportsCCExtractorVersion.Text = parms[1] + " " + parms[2];
                                LabReportsCCExtractorVersion.Refresh();
                            }
                            break;
                        case "PROGRESS":
                            if (parms.Length == 4)
                            {
                                int progress = int.Parse(parms[1]);
                                if (progress == -1)
                                {
                                    LabReportsProgress.Text = "Streaming";
                                    progressBarCCE.Visible = false;
                                }
                                else
                                {
                                    LabReportsProgress.Text = progress.ToString() + "%";
                                    progressBarCCE.Visible = true;
                                    progressBarCCE.Value = progress;
                                }
                                LabReportsPosition.Text = int.Parse(parms[2]).ToString("#####00") +
                                    ":" + int.Parse(parms[3]).ToString("00");
                            }
                            break;
                        case "INPUTFILECLOSED":
                            LabReportsCurrentFile.Text = "-";
                            break;
                        case "INPUTFILEOPEN":
                            LabReportsCurrentFile.Text = remainder;
                            break;
                        case "XDSPROGRAMNAME":
                            LABReportsXDSProgramName.Text = remainder;
                            break;
                        case "XDSNETWORKCALLLETTERS":
                            LABReportsXDSNetworkCallLetters.Text = remainder;
                            break;
                        case "XDSPROGRAMIDENTIFICATIONNUMBER":
                            if (parms.Length == 4)
                            {
                                LABReportsXDSProgramID.Text =
                                int.Parse(parms[3]).ToString("00") + "/" +
                                int.Parse(parms[4]).ToString("00") + " " +
                                int.Parse(parms[2]).ToString("00") + ":" +
                                int.Parse(parms[1]).ToString("00");
                            }
                            break;
                        case "MESSAGE":
                            LabReportsLastMessage.Text = remainder;
                            break;
                        case "VIDEOINFO":
                            if (parms.Length == 5)
                            {
                                LabReportsVideoResolution.Text = parms[1] + " * " + parms[2];
                                LabReportsAspectRatio.Text = parms[3];
                                LabReportsFramerate.Text = parms[4];
                            }
                            break;
                        case "SUBTITLE":
                            if (parms.Length >= 4)
                            {
                                string start_time = "      " + parms[1];
                                string end_time = "      " + parms[2];
                                string subs = "";
                                for (int i = 3; i < parms.Length; i++)
                                {
                                    string result = Encoding.UTF8.GetString(Encoding.GetEncoding("ISO-8859-1").GetBytes(parms[i]));
                                    subs = subs + result + "#"; // To compensate for the split                                        
                                }

                                string line = start_time.Substring(start_time.Length - 6) +
                                    " " + end_time.Substring(end_time.Length - 6) + "  " +
                                    subs.Substring(0, subs.Length - 1) + Environment.NewLine;
                                int pos = textBox1.Text.Length;
                                textBox1.AppendText(line);
                                textBox1.SelectionStart = pos;
                                textBox1.ScrollToCaret();
                            }
                            break;
                        case "TSPROGRAMNUMBER":
                            TSProgramNumberList.Add(remainder);
                            break;
                        case "DATAREAD":
                            progressBarActivity.Value = (progressBarActivity.Value + 1) % 3;
                            break;
                    }
                }
            }
            catch
            {
                // No error here justifies any action. 
            }
        }

        // Called whenever the main app reports something in stderr
        private void StderrHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            try
            {
                this.Invoke(err_delegate, outLine.Data);
            }
            catch {}
        }

        private void StdoutHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            this.Invoke(stdout_delegate, outLine.Data);
        }
    }

}
