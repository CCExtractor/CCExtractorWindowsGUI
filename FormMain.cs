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
        public delegate void ProcessReportString(String data);

        bool nowRunning;
        bool CancelProcess;
        bool inEvent;
        int tuners_found = 0;
        public ProcessReportString err_delegate;
        public ProcessReportString stdout_delegate;
        public ProcessReportString hdhr_err_delegate;
        public ProcessReportString hdhr_stdout_delegate;

        List<String> TSProgramNumberList;
        enum eState { Init, wtvccdump, ccextractorwin, Done };
        enum eHDHomeRunMode  { UNDEFINED, HDHR_LOOK_FOR_TUNERS };
        eHDHomeRunMode hdhr_mode = eHDHomeRunMode.UNDEFINED;

        public FormMain()
        {
            InitializeComponent();
            tabControlMain.SelectedIndex = 1;
            err_delegate=new ProcessReportString(ProcessStderrStringMethod);
            stdout_delegate=new ProcessReportString(ProcessStdoutStringMethod);
            hdhr_err_delegate = new ProcessReportString(ProcessHDHRStderrStringMethod);
            hdhr_stdout_delegate = new ProcessReportString(ProcessHDHRStdoutStringMethod);
            restoreSavedSettings();
            prepareCommandLine();
        }

        private void restoreSavedSettings ()
        {
            getInputTypeRadioButton(Properties.Settings.Default.InputType).Checked = true;
            getSplitRadioButton(Properties.Settings.Default.SplitType).Checked = true;
            cbField1.Checked = Properties.Settings.Default.Field1;
            cbField2.Checked = Properties.Settings.Default.Field2;
            rbChannel1.Checked = !Properties.Settings.Default.Channel2;
            rbChannel2.Checked = Properties.Settings.Default.Channel2;
            rbModeComplete.Checked = !Properties.Settings.Default.ModeLive;
            rbModeLive.Checked = Properties.Settings.Default.ModeLive;
            upDwnLiveTimeouts.Value = Properties.Settings.Default.LiveTimeOut;
            rbProcessingStartFromBeginning.Checked = Properties.Settings.Default.ProcessFromStart;
            rbProcessingStartFromPoint.Checked = !Properties.Settings.Default.ProcessFromStart;
            rbProcessingEndToFinish.Checked = Properties.Settings.Default.ProcessToEnd;
            rbProcessingEndToPoint.Checked = !Properties.Settings.Default.ProcessToEnd;
            updownStartHours.Value = Properties.Settings.Default.ProcessFromHH;
            updownStartMinutes.Value = Properties.Settings.Default.ProcessFromMM;
            updownStartSeconds.Value = Properties.Settings.Default.ProcessFromSS;
            updownEndHours.Value = Properties.Settings.Default.ProcessToHH;
            updownEndMinutes.Value = Properties.Settings.Default.ProcessToMM;
            updownEndSeconds.Value = Properties.Settings.Default.ProcessToSS;
            rbScreenfulsStopAfter.Checked = Properties.Settings.Default.ProcessToScreenfulLimit;
            rbScreenfulsNoLimit.Checked = !Properties.Settings.Default.ProcessToScreenfulLimit;
            updownScreenfuls.Value = Properties.Settings.Default.ScreenfulLimit;
            getMythTVRadioButton(Properties.Settings.Default.UseMythTVbranch).Checked = true;
            cbClock90090.Checked = Properties.Settings.Default.Clock90090;
            cbFixPadding.Checked = Properties.Settings.Default.FixPadding;
            cbLargeGOPs.Checked = Properties.Settings.Default.LargeGOPs;
            getOutputTypeRadioButton(Properties.Settings.Default.OutputType).Checked = true;
            upDwnDelay.Value = Properties.Settings.Default.TimeAdjust;
            cbDebugInterestingPackets.Checked = Properties.Settings.Default.DebugInterestingPackets;
            cbDebugTraces608.Checked = Properties.Settings.Default.Debug608;
            cbDebugTraces708.Checked = Properties.Settings.Default.Debug708;
            cbDebugTimestamps.Checked = Properties.Settings.Default.DebugTimestamp;
            cbDebugESAnalysis.Checked = Properties.Settings.Default.DebugES;
            cbDebugRaw608_708wTimestamps.Checked = Properties.Settings.Default.DebugTrace608_708;
            cbDebugContainer.Checked = Properties.Settings.Default.DebugContainer;
            getEncodingRadioButton(Properties.Settings.Default.Encoding).Checked = true;
            getColorsRadioButton(Properties.Settings.Default.Colors).Checked = true;
            tbDecoderColor.Text = Properties.Settings.Default.ColorReplacement;
            rbTextPositionCenter.Checked = Properties.Settings.Default.TextPositionTrim;
            rbTextPositionOriginal.Checked = !Properties.Settings.Default.TextPositionTrim;
            cbAutoDash.Checked = Properties.Settings.Default.Autodash;
            rbSentenceCaseDefault.Checked = Properties.Settings.Default.SentenceCaseYes;
            rbSentenceCaseNone.Checked = !Properties.Settings.Default.SentenceCaseYes;
            tbCapitalizationWordsFilename.Text = Properties.Settings.Default.SentenceCaseWordList;
            if (Properties.Settings.Default.SentenceCaseWordList != "")
                cbSentenceCaseExtraList.Checked = true;
            else
                cbSentenceCaseExtraList.Checked = false;
            cbRollupRealtime.Checked = Properties.Settings.Default.RollUpRealtime;
            cbRollupNoDupeLines.Checked = Properties.Settings.Default.RollUpNoDupes;
            cbNosync.Checked = Properties.Settings.Default.NoSync;
            cbFullbin.Checked = Properties.Settings.Default.Fullbin;
            tbStartCredits.Text =Properties.Settings.Default.StartCreditsText;
            tbEndCredits.Text =Properties.Settings.Default.EndCreditsText;
            updownStartCreditsNotBeforeMM.Value =Properties.Settings.Default.StartsCreditNotBeforeMM;
            updownStartCreditsNotBeforeSS.Value = Properties.Settings.Default.StartsCreditNotBeforeSS;
            updownStartCreditsNotAfterMM.Value = Properties.Settings.Default.StartsCreditNotAfterMM;
            updownStartCreditsNotAfterSS.Value = Properties.Settings.Default.StartsCreditNotAfterSS;
            updownStartCreditsMaxDisplayedSS.Value=Properties.Settings.Default.StartCreditsMaxDisplayedSS;
            updownStartCreditsMinDisplayedSS.Value = Properties.Settings.Default.StartCreditsMinDisplayedSS;
            updownEndCreditsMinDisplayedSS.Value = Properties.Settings.Default.StartCreditsMinDisplayedSS;
            updownEndCreditsMaxDisplayedSS.Value = Properties.Settings.Default.StartCreditsMaxDisplayedSS;
            cbWTVConversionFix.Checked = Properties.Settings.Default.WTVConversionFix ;
            rbExportTypesetting.Checked = Properties.Settings.Default.ExportTypesetting;
            rbDontExportTypesetting.Checked = !Properties.Settings.Default.ExportTypesetting;
            cbHauppage.Checked = Properties.Settings.Default.Hauppage;
            tbHDHomeRunPath.Text = Properties.Settings.Default.HDHomeRunToolsPath;
            setRollUpLinesLimitRatio(Properties.Settings.Default.RollUpLinesLimit);
            rbBOMYes.Checked = Properties.Settings.Default.BOMinUTF;
            cbExportXDS.Checked = Properties.Settings.Default.ExportXDS;
        }
        
        private void btnSaveAsDefault_Click(object sender, EventArgs e)
        {        
            Properties.Settings.Default.InputType = getInputTypeString();
            Properties.Settings.Default.SplitType = getSplitString();
            Properties.Settings.Default.Field1 = cbField1.Checked;
            Properties.Settings.Default.Field2 = cbField2.Checked;
            Properties.Settings.Default.Channel2 = rbChannel2.Checked;
            Properties.Settings.Default.ModeLive=rbModeLive.Checked;
            Properties.Settings.Default.LiveTimeOut=upDwnLiveTimeouts.Value;
            Properties.Settings.Default.ProcessFromStart=rbProcessingStartFromBeginning.Checked;
            Properties.Settings.Default.ProcessToEnd=rbProcessingEndToFinish.Checked;
            Properties.Settings.Default.ProcessFromHH = updownStartHours.Value;
            Properties.Settings.Default.ProcessFromMM = updownStartMinutes.Value;
            Properties.Settings.Default.ProcessFromSS = updownStartSeconds.Value;
            Properties.Settings.Default.ProcessToHH = updownEndHours.Value;
            Properties.Settings.Default.ProcessToMM = updownEndMinutes.Value;
            Properties.Settings.Default.ProcessToSS = updownEndSeconds.Value;
            Properties.Settings.Default.ProcessToScreenfulLimit = rbScreenfulsStopAfter.Checked;
            Properties.Settings.Default.ScreenfulLimit=updownScreenfuls.Value;
            Properties.Settings.Default.UseMythTVbranch=getMythTVString();
            Properties.Settings.Default.Clock90090=cbClock90090.Checked;
            Properties.Settings.Default.FixPadding=cbFixPadding.Checked;
            Properties.Settings.Default.LargeGOPs=cbLargeGOPs.Checked;
            Properties.Settings.Default.OutputType = getOutputTypeString();
            Properties.Settings.Default.TimeAdjust=upDwnDelay.Value;
            Properties.Settings.Default.DebugInterestingPackets=cbDebugInterestingPackets.Checked;
            Properties.Settings.Default.Debug608=cbDebugTraces608.Checked;
            Properties.Settings.Default.Debug708=cbDebugTraces708.Checked;
            Properties.Settings.Default.DebugTimestamp=cbDebugTimestamps.Checked;
            Properties.Settings.Default.DebugES=cbDebugESAnalysis.Checked;
            Properties.Settings.Default.DebugTrace608_708=cbDebugRaw608_708wTimestamps.Checked;
            Properties.Settings.Default.DebugContainer=cbDebugContainer.Checked;
            Properties.Settings.Default.Encoding=getEncodingString();
            Properties.Settings.Default.Colors=getColorString();
            Properties.Settings.Default.ColorReplacement=tbDecoderColor.Text;
            Properties.Settings.Default.TextPositionTrim=rbTextPositionCenter.Checked;
            Properties.Settings.Default.Autodash=cbAutoDash.Checked;
            Properties.Settings.Default.SentenceCaseYes=rbSentenceCaseDefault.Checked;
            Properties.Settings.Default.SentenceCaseWordList=tbCapitalizationWordsFilename.Text;
            Properties.Settings.Default.RollUpRealtime=cbRollupRealtime.Checked;
            Properties.Settings.Default.RollUpNoDupes=cbRollupNoDupeLines.Checked;
            Properties.Settings.Default.NoSync=cbNosync.Checked;
            Properties.Settings.Default.Fullbin=cbFullbin.Checked;
            Properties.Settings.Default.StartCreditsText=tbStartCredits.Text;
            Properties.Settings.Default.EndCreditsText=tbEndCredits.Text;
            Properties.Settings.Default.StartsCreditNotBeforeMM=updownStartCreditsNotBeforeMM.Value;
            Properties.Settings.Default.StartsCreditNotBeforeSS=updownStartCreditsNotBeforeSS.Value;
            Properties.Settings.Default.StartsCreditNotAfterMM=updownStartCreditsNotAfterMM.Value;
            Properties.Settings.Default.StartsCreditNotAfterSS = updownStartCreditsNotAfterSS.Value;
            Properties.Settings.Default.StartCreditsMaxDisplayedSS = updownStartCreditsMaxDisplayedSS.Value ;
            Properties.Settings.Default.StartCreditsMinDisplayedSS = updownStartCreditsMinDisplayedSS.Value;
            Properties.Settings.Default.StartCreditsMinDisplayedSS = updownEndCreditsMinDisplayedSS.Value ;
            Properties.Settings.Default.StartCreditsMaxDisplayedSS = updownEndCreditsMaxDisplayedSS.Value ;
            Properties.Settings.Default.WTVConversionFix = cbWTVConversionFix.Checked;
            Properties.Settings.Default.ExportTypesetting = rbExportTypesetting.Checked;
            Properties.Settings.Default.Hauppage = cbHauppage.Checked;
            Properties.Settings.Default.RollUpLinesLimit = getRollUpLinesLimit();
            Properties.Settings.Default.HDHomeRunToolsPath = tbHDHomeRunPath.Text;
            Properties.Settings.Default.BOMinUTF = rbBOMYes.Checked;
            Properties.Settings.Default.ExportXDS = cbExportXDS.Checked;
            Properties.Settings.Default.Save();
        }

        string GetTextErrorFromHRESUL(int hr)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(unchecked((int)hr));
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }

            return "OK";
        }
  
        private string getSwitchesFromInputOptionsTab ()
        {
            string switches="";
            if (rbInputUTP.Checked)
                switches = switches + " -udp " + tbUTPListenPort.Text;
            // Input type
            if (rbInputTypeAutodetect.Checked==false)
                switches=switches+" -in="+getInputTypeString();
            // Split type
            if (rbSplitVideoTool.Checked)
                switches = switches + " --videoedited";
            // Field
            if (cbField2.Checked)
            {
                if (cbField1.Checked)
                    switches=switches+" -12";
                else
                    switches = switches + " -2";
            }
            // Channel
            if (rbChannel2.Checked)
                switches=switches+" -cc2";
            // Mode
            if (rbModeLive.Checked)
            {
                switches=switches+" -s";
                if (upDwnLiveTimeouts.Value!=0)
                    switches = switches + " " +upDwnLiveTimeouts.Value;                  
            }
            // Elementary Stream
            if (tbElementaryStreamPID.Text!="")            
                switches = switches + " -datapid " + txtTeletextPID.Text;            
            if (tbElementaryDataStreamType.Text!="")
                switches = switches + " -datastreamtype " + tbElementaryDataStreamType.Text;
            if (tbElementaryStreamType.Text != "")
                switches = switches + " -streamtype " + tbElementaryStreamType.Text;

            // Fragment selection (time based)
            if (rbProcessingStartFromPoint.Checked)
            {
                string s="";
                if (updownStartHours.Value!=0)
                    s=updownStartHours.Value+":";
                if (updownStartMinutes.Value!=0 || s!="")
                    s=s + updownStartMinutes.Value.ToString("00")+":";
                if (updownStartSeconds.Value!=0 || s!="")
                    s=s + updownStartSeconds.Value.ToString("00");
                if (s!="")
                    switches=switches+" -startat "+s;                    
            }
            if (rbProcessingEndToPoint.Checked)
            {
                string s = "";
                if (updownEndHours.Value != 0)
                    s = updownEndHours.Value + ":";
                if (updownEndMinutes.Value != 0 || s != "")
                    s = s + updownEndMinutes.Value.ToString("00") + ":";
                if (updownEndSeconds.Value != 0 || s != "")
                    s = s + updownEndSeconds.Value.ToString("00");
                if (s != "")
                    switches = switches + " -endat " + s;
            }
            // Fragment selection (screenful based)
            if (rbScreenfulsStopAfter.Checked && updownScreenfuls.Value!=0)
                switches=switches+" --screenfuls "+updownScreenfuls.Value;
            return switches;
        }        

        private string getSwitchesFromAdvancedInputOptionsTab ()
        {
            string switches="";
            if (rbMythTVForced.Checked)
                switches=switches+" -myth";
            if (rbMythTVDisabled.Checked)
                switches = switches + " -nomyth";
            if (cbClock90090.Checked)
                switches = switches + " -90090";
            if (cbFixPadding.Checked)
                switches = switches + " --fixpadding";
            if (cbLargeGOPs.Checked)
                switches = switches + " --largegops";
            if (cbWTVConversionFix.Checked)
                switches = switches + " --wtvconvertfix";
            if (cbHauppage.Checked)
                switches = switches + " -haup";
            if (cb_use_pic_order_cnt.Checked)
                switches = switches + " -poc";
            if (cb_mp4vidtrack.Checked)
                switches = switches + " -mp4vidtrack";
            if (rbClockGOP.Checked)
                switches = switches + " --goptime";
            if (rbClockPTS.Checked)
                switches = switches + " --nogoptime";
            if (tbProgramNumber.Text!="")
                switches = switches + " --program-number " + tbProgramNumber.Text;
            if (rbMultiProgramTSAutoDetect.Checked)
                switches = switches + " -autoprogram " + tbProgramNumber.Text;
            if (cb_ignore_scte20.Checked)
                switches = switches + " --noscte20";
            return switches;
        }

        private void setRollUpLinesLimitRatio(int value)
        {
            switch (value)
            {
                case 1:
                    rbRollUpLinesLimit1.Checked = true;
                    break;
                case 2:
                    rbRollUpLinesLimit2.Checked = true;
                    break;
                case 3:
                    rbRollUpLinesLimit3.Checked = true;
                    break;
                default:
                    rbRollUpLinesLimitNone.Checked = true;
                    break;
            }
        }

        private int getRollUpLinesLimit()
        {
            if (rbRollUpLinesLimit3.Checked)
                return 3;
            if (rbRollUpLinesLimit2.Checked)
                return 2;
            if (rbRollUpLinesLimit1.Checked)
                return 1;
            return 0;
        }

        private string getSwitchesFromOutputTab ()
        {
            string switches="";
            // Output format
            if (rbOutputTypeSRT.Checked)
                switches=switches+" -out=srt";
            if (rbOutputTypeSAMI.Checked)
                switches = switches + " -out=sami";
            if (rbOutputTypeTXT.Checked)
                switches = switches + " -out=txt";
            if (rbOutputTypeTimedTXT.Checked)
                switches = switches + " -out=ttxt";
            if (rbOutputTypeRaw.Checked)
                switches = switches + " -out=raw";
            if (rbOutputTypeDVDRaw.Checked)
                switches = switches + " -out=dvdraw";
            if (rbOutputTypeBin.Checked)
                switches = switches + " -out=bin";
            if (rbOutputTypeNull.Checked)
                switches = switches + " -out=null";
            if (rbOutputTypeTTML.Checked)
                switches = switches + " -out=smptett";
            if (rbOutputTypeSpuPNG.Checked)
                switches = switches + " -out=spupng";
            if (rbOutputTypeReport.Checked)
                switches = switches + " -out=report";
            if (rbOutputTypeSimpleXML.Checked)
                switches = switches + " -out=simplexml";
            if (rbOutputTypeG608.Checked)
                switches = switches + " -out=g608";
            if (rbOutputTypeASS.Checked)
                switches = switches + " -out=ass";

            if (rbRollUpLinesLimit3.Checked)
                switches = switches + " -ru3";
            if (rbRollUpLinesLimit2.Checked)
                switches = switches + " -ru2";
            if (rbRollUpLinesLimit1.Checked)
                switches = switches + " -ru1";
            // Filename
            if (rbOutputNameManual.Checked &&
                tbOutputFilename.Text.Trim()!="")
                switches=switches+" -o \""+tbOutputFilename.Text.Trim()+"\"";
            // Delay
            if (upDwnDelay.Value!=0)
                switches=switches+" -delay "+upDwnDelay.Value;
            if (rbLineTerminatorUNIX.Checked)
                switches = switches + " -lf";
            // BOM
            if (rbBOMNo.Checked)
                switches = switches + " -nobom";
            if (rbBOMYes.Checked)
                switches = switches + " -bom";
            // XDS
            if (cbExportXDS.Checked)
                switches = switches + " -xds";


            return switches; 

        }
        
        private string getSwitchesFromDebugTab ()
        {
            string switches = "";
            if (cbDebugWriteES.Checked && 
                tbElementaryStreamFilename.Text.Trim()!="")
                switches=switches+" -cf "+tbElementaryStreamFilename.Text.Trim();
            if (cbDebugInterestingPackets.Checked)
                switches=switches+" -debug";
            if (cbDebugTraces608.Checked)
                switches = switches + " -608";
            if (cbDebugTraces708.Checked)
                switches = switches + " -708";
            if (cbDebugTimestamps.Checked)
                switches = switches + " -goppts";
            if (cbDebugESAnalysis.Checked)
                switches=switches+" -vides";
            if (cbDebugRaw608_708wTimestamps.Checked)
                switches = switches + " -cbraw";
            if (cbDebugContainer.Checked)
                switches = switches + " -parsedebug";
            if (cbNosync.Checked)
                switches=switches+" -nosync";
            if (cbFullbin.Checked)
                switches=switches+" -fullbin";
            if (cbDebugXDS.Checked)
                switches = switches + " -xdsdebug";
            if (cbDebugPAT.Checked)
                switches = switches + " -parsePAT";
            if (cbDebugPMT.Checked)
                switches = switches + " -parsePMT";
            if (cbDebugAnalyzePackets.Checked)
                switches = switches + " -investigate_packets";
            if (cbDebugLevDistance.Checked)
                switches = switches + " -deblev";

            return switches;
        }
        
        private string getSwitchesFromDecoderTab ()
        {
            string switches = "";
            // Encoding
            if (rbEncodingLatin1.Checked)
                switches=switches+" -latin1";
            if (rbEncodingUnicode.Checked)
                switches = switches + " -unicode";
            if (rbEncodingUTF8.Checked)
                switches = switches + " -utf8";
            // Colors
            if (rbColorsDisable.Checked)
                switches = switches + " --nofontcolor";
            if (rbColorsReplace.Checked && tbDecoderColor.Text.Length==6)
                switches = switches + " --defaultcolor #"+tbDecoderColor.Text;
            // Text position
            if (rbTextPositionCenter.Checked)
                switches=switches+" -trim";
            if (cbAutoDash.Checked)
                switches = switches + " -autodash";
            // Capitalization
            if (rbSentenceCaseDefault.Checked)
            {
                switches = switches + " --sentencecap";
                if (cbSentenceCaseExtraList.Checked &&
                    tbCapitalizationWordsFilename.Text.Trim()!="")
                    switches=switches+" --capfile \""+tbCapitalizationWordsFilename.Text+"\"";
            }
            // Rollup
            if (cbRollupNoDupeLines.Checked)
                switches=switches+" --norollup";
            if (cbRollupRealtime.Checked)
                switches=switches+" -dru";
            // Typesetting
            if (rbDontExportTypesetting.Checked)
                switches = switches + " --notypesetting";

            // 708 decoder
            if (cbEnable708Decoder.Checked && txt708Services.Text!="")
                switches = switches+" -svc "+txt708Services.Text;

            // Teletext
            if (rbTeletextForce.Checked)
                switches = switches + " -teletext";
            if (rbTeletextDisable.Checked)
                switches = switches + " -noteletext";
            if (txtTeletextPage.Text.Trim() != "")
                switches = switches + " -tpage " + txtTeletextPage.Text;
            if (rbPreferDVB.Checked)
                switches = switches + " -codec dvbsub";
            if (txtlevdistmincnt.Text.Trim() != "")
                switches = switches + " -levdistmincnt " + txtlevdistmincnt.Text;
            if (txtlevdistmaxpct.Text.Trim() != "")
                switches = switches + " -levdistmaxpct " + txtlevdistmaxpct.Text;
            return switches;

        }
        
        private string getSwitchesFromCreditsTab()
        {
            string switches = "";
            // Start credit switches
            if (cbWriteStartingText.Checked && tbStartCredits.Lines.Length>0)
            {
                StringBuilder sb=new StringBuilder();
                for (int i=0;i<tbStartCredits.Lines.Length;i++)
                {
                    sb.Append(tbStartCredits.Lines[i]);
                    if (i<tbStartCredits.Lines.Length-1)
                        sb.Append("\\n");
                }
                if (sb.Length>0)
                {
                    switches=switches+" --startcreditstext \""+sb.ToString()+"\"";
                    if (cbbStartCreditsNotBeforeThan.Checked)
                    {
                        string s = "";
                        if (updownStartCreditsNotBeforeMM.Value != 0)
                            s = s + updownStartCreditsNotBeforeMM.Value.ToString("00") + ":";
                        if (updownStartCreditsNotBeforeSS.Value != 0 || s != "")
                            s = s + updownStartCreditsNotBeforeSS.Value.ToString("00");
                        if (s != "")                            
                            switches=switches+" --startcreditsnotbefore "+s;
                    }
                    if (cbbStartCreditsNotLaterThan.Checked)
                    {
                        string s = "";
                        if (updownStartCreditsNotAfterMM.Value != 0)
                            s = s + updownStartCreditsNotAfterMM.Value.ToString("00") + ":";
                        if (updownStartCreditsNotAfterSS.Value != 0 || s != "")
                            s = s + updownStartCreditsNotAfterSS.Value.ToString("00");
                        if (s != "")
                            switches = switches + " --startcreditsnotafter " + s;
                    }
                    switches=switches+" --startcreditsforatleast "+updownStartCreditsMinDisplayedSS.Value;
                    switches = switches + " --startcreditsforatmost " + updownStartCreditsMaxDisplayedSS.Value;
                }
            }
            if (cbWriteEndText.Checked && tbEndCredits.Lines.Length>0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < tbEndCredits.Lines.Length; i++)
                {
                    sb.Append(tbEndCredits.Lines[i]);
                    if (i < tbEndCredits.Lines.Length - 1)
                        sb.Append("\\n");
                }            
                if (sb.Length>0)
                {
                    switches=switches+" --endcreditstext \""+sb.ToString()+"\"";
                    switches = switches + " --endcreditsforatleast " + updownEndCreditsMinDisplayedSS.Value;
                    switches = switches + " --endcreditsforatmost " + updownEndCreditsMaxDisplayedSS.Value;                   
                }
            }
            return switches;
        }

        private string getSwitchesFromBurnedInTab()
        {
            string switches = "";
            if (cbPerformBurnedin.Checked)
            {
                switches += " -hardsubx";

                // OCR mode
                // frame is default
                if (rbOcrModeLetter.Checked)
                    switches += " -ocr_mode letter";
                else if (rbOcrModeWord.Checked)
                    switches += " -ocr_mode word";

                // subcolor
                switches += " -subcolor ";
                if (rbBurnedinWhite.Checked)
                    switches += "white";
                else if (rbBurnedinYellow.Checked)
                    switches += "yellow";
                else if (rbBurnedinGreen.Checked)
                    switches += "green";
                else if (rbBurnedinCyan.Checked)
                    switches += "cyan";
                else if (rbBurnedinBlue.Checked)
                    switches += "blue";
                else if (rbBurnedinMagenta.Checked)
                    switches += "magenta";
                else if (rbBurnedinRed.Checked)
                    switches += "red";
                else if (rbBurnedinCustom.Checked)
                    switches += tbBurnedinHue.Text;

                // Min sub duration
                // 0.5 is default
                if (tbMinSubDuration.Text != "0.5")
                    switches += " -min_sub_duration " + tbMinSubDuration.Text;

                // Detect Italics
                if (cbDetectItalics.Checked)
                    switches += " -detect_italics";

                // Confidence Threshold
                switches += " -conf_thresh " + tbConfThresh.Value;
                labelConfThresh.Text = tbConfThresh.Value + ".0";

                // Whiteness Threshold
                // 95 is default
                if (tbWhitenessThresh.Value != 95)
                    switches += " -whiteness_thresh " + tbWhitenessThresh.Value;
                labelWhitenessThresh.Text = tbWhitenessThresh.Value + ".0";
            }
            return switches;
        }
        
        public string getSwitches()
        {
            return  " --gui_mode_reports "+
                    getSwitchesFromInputOptionsTab()+
                    getSwitchesFromAdvancedInputOptionsTab ()+
                    getSwitchesFromOutputTab()+
                    getSwitchesFromDebugTab()+
                    getSwitchesFromDecoderTab()+
                    getSwitchesFromCreditsTab()+
                    getSwitchesFromBurnedInTab()
                    ;
        }

        private string getBinaryName ()
        {
            if (rbBinaryVersionNoOCR.Checked)
                return "ccextractorwin.exe";
            else
                return "ccextractorwinfull.exe";

        }
        
        private void prepareCommandLine ()
        {
            bool ready=false;
            string ccextractorexe = getBinaryName();
            String ccpath = App_Path() + ccextractorexe;
            if (!File.Exists(ccpath))
                textBoxCommandLine.Text = ccextractorexe+ " not found. It must be in the same path as this program."+Environment.NewLine+"Path: \""+ccpath+"\"";
            else
            {
                if (listViewInputFiles.Items.Count==0 && rbInputUTP.Checked==false)             
                    textBoxCommandLine.Text="No input files selected.";
                else
                {
                    try
                    {
                        textBoxCommandLine.Text = ccpath + " " + getSwitches();
                        if (rbInputUTP.Checked==false)
                            textBoxCommandLine.Text = textBoxCommandLine.Text +" [+input files]";
                        ready=true;
                    }
                    catch (Exception e)
                    {
                        textBoxCommandLine.Text=e.Message;
                    }
                }
            }
            btnGo.Enabled=ready;
        }
        
        private void listViewInputFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listViewInputFiles_DragDrop(object sender, DragEventArgs e)
        {
            String[] file_names = (String[]) e.Data.GetData(DataFormats.FileDrop);
            foreach (string file_name in file_names)
            {
                listViewInputFiles.Items.Add(file_name);                
            }
            prepareCommandLine();
        }

        String App_Path()
        {
            String path=System.AppDomain.CurrentDomain.BaseDirectory;
            if (path.EndsWith("\\")==false)
                path=path+"\\";
            return path;
        }
        
        private void initReportLabels()
        {
            LabReportsCCExtractorVersion.Text="-";
            LabReportsProgress.Text="-";
            LabReportsProgress.Visible=true;
            progressBarCCE.Visible=false;
            LabReportsPosition.Text="-";
            LabReportsCurrentFile.Text="-";
            LabReportsVideoResolution.Text="-";
            LabReportsAspectRatio.Text="-";
            LabReportsFramerate.Text="-";
        }

        private void ProcessHDHRStdoutStringMethod(String data)
        {
            if (data == null)
                return;
            textBoxActivity.AppendText(data + Environment.NewLine);
            textBoxActivity.Refresh();
            String tuner_id=null;
            String tuner_ip = null;
            switch (hdhr_mode)
            {
                case eHDHomeRunMode.HDHR_LOOK_FOR_TUNERS:
                    // Sample output
                    // hdhomerun device 12206E95 found at 192.168.20.105
                    if (data.StartsWith("hdhomerun device "))
                    {
                        String t = data.Substring(17);
                        int p = t.IndexOf(" ");
                        if (p > 0)
                        {
                            tuner_id = t.Substring(0, p);
                            t = t.Substring(p+1);
                            if (t.StartsWith("found at "))
                            {
                                tuner_ip = t.Substring(9);

                            }
                        }
                        if (tuner_id != null && tuner_ip != null)
                        {
                            listBoxTuners.Items.Add(tuner_id + " (" + tuner_ip + ") ");
                            tuners_found++;
                            listBoxTuners.Refresh();                            
                        }
                    }
                    break;
            }
            Application.DoEvents();
        }

        private void ProcessHDHRStderrStringMethod(String data)
        {
            //textBoxActivity.AppendText(data + Environment.NewLine);
            //textBoxActivity.Refresh();
            Application.DoEvents();
        }

        

        // HDHomeRun handlers
        private void HDHRStderrHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            this.Invoke(hdhr_err_delegate, outLine.Data);
        }

        private void HDHRStdoutHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            this.Invoke(hdhr_stdout_delegate, outLine.Data);
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ccextractor.org");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://freshmeat.net/projects/ccextractor");
        }

        private void GenericCheckedChangedHandler(object sender, EventArgs e)
        {
            if ((rbInputTypeWTV.Checked || rbInputTypeMP4.Checked || rbInputTypeHexDump.Checked) && 
                !rbSplitIndividual.Checked)
                rbSplitIndividual.Checked = true;
            prepareCommandLine();
        }

        private void upDwnLiveTimeouts_ValueChanged(object sender, EventArgs e)
        {
            if (!rbModeLive.Checked)
                rbModeLive.Checked=true;
            else    
                prepareCommandLine();
        }

        private void updownScreenfuls_ValueChanged(object sender, EventArgs e)
        {
            if (!rbScreenfulsStopAfter.Checked)
                rbScreenfulsStopAfter.Checked=true;
            else
                prepareCommandLine();
        }

        private void StartAtTimeChanged(object sender, EventArgs e)
        {
            if (!rbProcessingStartFromPoint.Checked)
                rbProcessingStartFromPoint.Checked=true;
            else
                prepareCommandLine();
        }

        private void EndAtTimeChanged(object sender, EventArgs e)
        {
            if (!rbProcessingEndToPoint.Checked)
                rbProcessingEndToPoint.Checked=true;
            else
                prepareCommandLine();
        }

        private void btnBrowseOutputFilename_Click(object sender, EventArgs e)
        {
            if (saveFileDialogOutput.ShowDialog()==DialogResult.OK)
                tbOutputFilename.Text=saveFileDialogOutput.FileName;
        }

        private void tbOutputFilename_TextChanged(object sender, EventArgs e)
        {        
            if (tbOutputFilename.Text.Trim()=="")
            {
                if (!rbOutputNameAuto.Checked)
                    rbOutputNameAuto.Checked = true;
                else
                    prepareCommandLine();
            }
            else
            {
                if (!rbOutputNameManual.Checked)
                    rbOutputNameManual.Checked=true;
                else
                    prepareCommandLine();
            }
        }

        private void upDwnDelay_ValueChanged(object sender, EventArgs e)
        {
            prepareCommandLine();
        }

        private void btnBrowseElementaryStreamFilename_Click(object sender, EventArgs e)
        {
            if (saveFileDialogElementaryStream.ShowDialog() == DialogResult.OK)
                tbElementaryStreamFilename.Text = saveFileDialogElementaryStream.FileName;        
        }

        private void tbElementaryStreamFilename_TextChanged(object sender, EventArgs e)
        {
            if (tbElementaryStreamFilename.Text.Trim() == "")
            {
                if (cbDebugWriteES.Checked)
                    cbDebugWriteES.Checked = false;
                else
                    prepareCommandLine();
            }
            else
            {
                if (!cbDebugWriteES.Checked)
                    cbDebugWriteES.Checked = true;
                else
                    prepareCommandLine();
            }
        }

        private void tbDecoderColor_TextChanged(object sender, EventArgs e)
        {
            if (tbDecoderColor.Text.Trim() == "")
            {
                if (!rbColorsDefault.Checked)
                    rbColorsDefault.Checked = true;
                else
                    prepareCommandLine();
            }
            else
            {
                if (!rbColorsReplace.Checked)
                    rbColorsReplace.Checked = true;
                else
                    prepareCommandLine();
            }
        }

        private void tbCapitalizationWordsFilename_TextChanged(object sender, EventArgs e)
        {
            if (tbCapitalizationWordsFilename.Text.Trim() == "")
            {
                if (cbSentenceCaseExtraList.Checked)
                    cbSentenceCaseExtraList.Checked = false;
                else
                    prepareCommandLine();
            }
            else
            {
                if (!cbSentenceCaseExtraList.Checked)
                    cbSentenceCaseExtraList.Checked = true;
                else
                    prepareCommandLine();
            }

        }

        private void btnBrowseCapitalizationWords_Click(object sender, EventArgs e)
        {
            if (openFileDialogWordsList.ShowDialog() == DialogResult.OK)
                tbCapitalizationWordsFilename.Text = openFileDialogWordsList.FileName;        

        }

        private void rbSentenceCaseNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSentenceCaseNone.Checked)
            {
                cbSentenceCaseExtraList.Checked=false;
                tbCapitalizationWordsFilename.Text="";
            }
            prepareCommandLine();
        }

        private void cbSentenceCaseExtraList_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSentenceCaseExtraList.Checked)            
                rbSentenceCaseDefault.Checked=true;
            prepareCommandLine();
        }

        private void butRestoreDefault_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            restoreSavedSettings();
        }

        private void butClearInputList_Click(object sender, EventArgs e)
        {
            listViewInputFiles.Items.Clear();
            prepareCommandLine();
        }

        private void pbSponsor1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.xirvik.com?ref=ccextractor");
        }

        private void tbStartCredits_TextChanged(object sender, EventArgs e)
        {
            if (tbStartCredits.Lines.Length>0)
                cbWriteStartingText.Checked=true;
            else
                cbWriteStartingText.Checked=false;
            prepareCommandLine();
        }

        private void cbWriteStartingText_CheckedChanged(object sender, EventArgs e)
        {
            prepareCommandLine();
        }

        private void updownStartCreditsNotBefore_ValueChanged(object sender, EventArgs e)
        {
            if (!cbbStartCreditsNotBeforeThan.Checked)
                cbbStartCreditsNotBeforeThan.Checked = true;
            else
                prepareCommandLine();
        }

        private void updownStartCreditsNotAfter_ValueChanged(object sender, EventArgs e)
        {
            if (!cbbStartCreditsNotLaterThan.Checked)
                cbbStartCreditsNotLaterThan.Checked = true;
            else
                prepareCommandLine();
        }

        private void tbEndCredits_TextChanged(object sender, EventArgs e)
        {
            prepareCommandLine();
        }

        private void tbProgramNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbProgramNumber.Text == "")
                rbMultiProgramTSAutoDetect.Checked = true;
            else
                rbMultiProgramTSSelect.Checked = true;
            prepareCommandLine();
        }

        private void tbProgramNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
        char.IsSymbol(e.KeyChar) ||
        char.IsWhiteSpace(e.KeyChar) ||
        char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtTeletextPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txt708Services_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)) && e.KeyChar!=',')
                e.Handled = true;
        }

        private void txtTeletextPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTeletextPID_TextChanged(object sender, EventArgs e)
        {
            if (inEvent == false)
            {
                inEvent = true;
                tbElementaryStreamPID.Text = txtTeletextPID.Text;
                tbElementaryDataStreamType.Text = "";
                if (tbElementaryStreamPID.Text == "")
                    rbElementaryStreamAuto.Checked = true;
                else
                    rbElementaryStreamFixedStreamNumber.Checked = true;
                GenericCheckedChangedHandler(sender, e);
                inEvent = false;
            }
        }

        private void tbElementaryStreamPID_TextChanged(object sender, EventArgs e)
        {
            if (inEvent == false)
            {
                inEvent = true;
                tbElementaryDataStreamType.Text = "";
                txtTeletextPID.Text = tbElementaryStreamPID.Text;
                GenericCheckedChangedHandler(sender, e);
                if (tbElementaryStreamPID.Text == "")
                    rbElementaryStreamAuto.Checked = true;
                else
                    rbElementaryStreamFixedStreamNumber.Checked = true;
                inEvent = false;
            }
        }

        private void rbElementaryStreamAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (inEvent == false)
            {
                inEvent = true;
                if (rbElementaryStreamAuto.Checked == true)
                {
                    txtTeletextPID.Text = "";
                    tbElementaryStreamPID.Text = "";
                    tbElementaryDataStreamType.Text = "";
                }
                inEvent = false;
            }
        }

        private void rbElementaryStreamSelectType_CheckedChanged(object sender, EventArgs e)
        {
            if (inEvent == false)
            {
                inEvent = true;
                txtTeletextPID.Text = "";
                tbElementaryStreamPID.Text = "";
                inEvent = false;
            }
        }

        private void tbElementaryDataStreamType_TextChanged(object sender, EventArgs e)
        {
            if (inEvent == false)
            {
                inEvent = true;
                tbElementaryStreamPID.Text = "";
                txtTeletextPID.Text = "";
                GenericCheckedChangedHandler(sender, e);
                if (tbElementaryDataStreamType.Text == "")
                    rbElementaryStreamAuto.Checked = true;
                else
                    rbElementaryStreamSelectType.Checked = true;
                inEvent = false;
            }
        }

        private void rbElementaryStreamFixedStreamNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (inEvent == false)
            {
                inEvent = true;                
                tbElementaryDataStreamType.Text = "";
                inEvent = false;
            }
        }

        private void rbTextPositionOriginal_CheckedChanged(object sender, EventArgs e)
        {
            if (inEvent == false)
            {
                inEvent = true;
                if (rbTextPositionOriginal.Checked)
                    cbAutoDash.Checked = false;
                inEvent = false;
            }
            GenericCheckedChangedHandler(sender, e);
        }

        private void butFindTuners_Click(object sender, EventArgs e)
        {
            tuners_found = 0;
            hdhr_mode = eHDHomeRunMode.HDHR_LOOK_FOR_TUNERS;
            run_hdhr_config();
        }

        private void butHDHomeRunDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogHDHomeRun.ShowDialog()==DialogResult.OK)
                tbHDHomeRunPath.Text = folderBrowserDialogHDHomeRun.SelectedPath;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxMultiprogramTS_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/CCExtractor/ccextractor/issues");
        }
    }        
}
