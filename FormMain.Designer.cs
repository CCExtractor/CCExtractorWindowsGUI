namespace CCExtractorGUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage tabPageDecoders;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtlevdistmaxpct = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtlevdistmincnt = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBoxTelext = new System.Windows.Forms.GroupBox();
            this.rbPreferDVB = new System.Windows.Forms.RadioButton();
            this.txtTeletextPage = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.rbTeletextForce = new System.Windows.Forms.RadioButton();
            this.txtTeletextPID = new System.Windows.Forms.TextBox();
            this.rbTeletextDisable = new System.Windows.Forms.RadioButton();
            this.label47 = new System.Windows.Forms.Label();
            this.rbTeletextAuto = new System.Windows.Forms.RadioButton();
            this.label46 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txt708Services = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.cbEnable708Decoder = new System.Windows.Forms.CheckBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxChannel = new System.Windows.Forms.GroupBox();
            this.rbChannel2 = new System.Windows.Forms.RadioButton();
            this.rbChannel1 = new System.Windows.Forms.RadioButton();
            this.groupBoxField = new System.Windows.Forms.GroupBox();
            this.cbField2 = new System.Windows.Forms.CheckBox();
            this.cbField1 = new System.Windows.Forms.CheckBox();
            this.label39 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label44 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.butRestoreDefault = new System.Windows.Forms.Button();
            this.btnSaveAsDefault = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPageInput = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tbUTPListenPort = new System.Windows.Forms.TextBox();
            this.rbInputUTP = new System.Windows.Forms.RadioButton();
            this.butClearInputList = new System.Windows.Forms.Button();
            this.listViewInputFiles = new System.Windows.Forms.ListView();
            this.tabPageInputOptions = new System.Windows.Forms.TabPage();
            this.groupBoxElementaryStream = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbElementaryStreamType = new System.Windows.Forms.TextBox();
            this.tbElementaryDataStreamType = new System.Windows.Forms.TextBox();
            this.rbElementaryStreamSelectType = new System.Windows.Forms.RadioButton();
            this.tbElementaryStreamPID = new System.Windows.Forms.TextBox();
            this.rbElementaryStreamFixedStreamNumber = new System.Windows.Forms.RadioButton();
            this.rbElementaryStreamAuto = new System.Windows.Forms.RadioButton();
            this.groupBoxScreenfulLimits = new System.Windows.Forms.GroupBox();
            this.updownScreenfuls = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rbScreenfulsStopAfter = new System.Windows.Forms.RadioButton();
            this.rbScreenfulsNoLimit = new System.Windows.Forms.RadioButton();
            this.groupBoxEndOfProcessing = new System.Windows.Forms.GroupBox();
            this.updownEndSeconds = new System.Windows.Forms.NumericUpDown();
            this.updownEndMinutes = new System.Windows.Forms.NumericUpDown();
            this.updownEndHours = new System.Windows.Forms.NumericUpDown();
            this.rbProcessingEndToPoint = new System.Windows.Forms.RadioButton();
            this.rbProcessingEndToFinish = new System.Windows.Forms.RadioButton();
            this.groupBoxStartOfProcessing = new System.Windows.Forms.GroupBox();
            this.updownStartSeconds = new System.Windows.Forms.NumericUpDown();
            this.updownStartMinutes = new System.Windows.Forms.NumericUpDown();
            this.updownStartHours = new System.Windows.Forms.NumericUpDown();
            this.rbProcessingStartFromPoint = new System.Windows.Forms.RadioButton();
            this.rbProcessingStartFromBeginning = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.upDwnLiveTimeouts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rbModeLive = new System.Windows.Forms.RadioButton();
            this.rbModeComplete = new System.Windows.Forms.RadioButton();
            this.groupBoxSplitType = new System.Windows.Forms.GroupBox();
            this.label45 = new System.Windows.Forms.Label();
            this.rbSplitGeneric = new System.Windows.Forms.RadioButton();
            this.rbSplitVideoTool = new System.Windows.Forms.RadioButton();
            this.rbSplitIndividual = new System.Windows.Forms.RadioButton();
            this.groupBoxInputType = new System.Windows.Forms.GroupBox();
            this.rbInputTypeM2TS = new System.Windows.Forms.RadioButton();
            this.rbInputTypeWTV = new System.Windows.Forms.RadioButton();
            this.rbInputTypeHexDump = new System.Windows.Forms.RadioButton();
            this.rbInputTypeMP4 = new System.Windows.Forms.RadioButton();
            this.rbInputTypeBin = new System.Windows.Forms.RadioButton();
            this.rbInputTypeMcPoodleRaw = new System.Windows.Forms.RadioButton();
            this.rbInputTypeDVRMS = new System.Windows.Forms.RadioButton();
            this.rbInputTypeElementaryStreams = new System.Windows.Forms.RadioButton();
            this.rbInputTypeProgramStreams = new System.Windows.Forms.RadioButton();
            this.rbInputTypeTransportStreams = new System.Windows.Forms.RadioButton();
            this.rbInputTypeAutodetect = new System.Windows.Forms.RadioButton();
            this.tabPageAdvancedInputOptions = new System.Windows.Forms.TabPage();
            this.groupBoxAdvancedInputClock = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.rbClockPTS = new System.Windows.Forms.RadioButton();
            this.rbClockGOP = new System.Windows.Forms.RadioButton();
            this.rbClockAuto = new System.Windows.Forms.RadioButton();
            this.groupBoxMultiprogramTS = new System.Windows.Forms.GroupBox();
            this.rbMultiProgramTSAutoDetect = new System.Windows.Forms.RadioButton();
            this.rbMultiProgramTSSelect = new System.Windows.Forms.RadioButton();
            this.tbProgramNumber = new System.Windows.Forms.TextBox();
            this.groupBoxAdvancedInputMisc = new System.Windows.Forms.GroupBox();
            this.cb_ignore_scte20 = new System.Windows.Forms.CheckBox();
            this.cb_mp4vidtrack = new System.Windows.Forms.CheckBox();
            this.cb_use_pic_order_cnt = new System.Windows.Forms.CheckBox();
            this.cbHauppage = new System.Windows.Forms.CheckBox();
            this.cbWTVConversionFix = new System.Windows.Forms.CheckBox();
            this.cbLargeGOPs = new System.Windows.Forms.CheckBox();
            this.cbFixPadding = new System.Windows.Forms.CheckBox();
            this.cbClock90090 = new System.Windows.Forms.CheckBox();
            this.groupBoxMythTV = new System.Windows.Forms.GroupBox();
            this.rbMythTVAuto = new System.Windows.Forms.RadioButton();
            this.rbMythTVDisabled = new System.Windows.Forms.RadioButton();
            this.rbMythTVForced = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.groupBoxXDS = new System.Windows.Forms.GroupBox();
            this.cbExportXDS = new System.Windows.Forms.CheckBox();
            this.bgBOM = new System.Windows.Forms.GroupBox();
            this.rbBOMNo = new System.Windows.Forms.RadioButton();
            this.rbBOMYes = new System.Windows.Forms.RadioButton();
            this.groupBoxTimeAdjust = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.upDwnDelay = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOutputFile = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowseOutputFilename = new System.Windows.Forms.Button();
            this.tbOutputFilename = new System.Windows.Forms.TextBox();
            this.rbOutputNameManual = new System.Windows.Forms.RadioButton();
            this.rbOutputNameAuto = new System.Windows.Forms.RadioButton();
            this.groupBoxOutputType = new System.Windows.Forms.GroupBox();
            this.rbOutputTypeG608 = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeSimpleXML = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeReport = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeSpuPNG = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeTTML = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeNull = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeTimedTXT = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeBin = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeDVDRaw = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeRaw = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeTXT = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeSAMI = new System.Windows.Forms.RadioButton();
            this.rbOutputTypeSRT = new System.Windows.Forms.RadioButton();
            this.tabPageOutput2 = new System.Windows.Forms.TabPage();
            this.groupBoxLineTerminator = new System.Windows.Forms.GroupBox();
            this.rbLineTerminatorUNIX = new System.Windows.Forms.RadioButton();
            this.rbLineTerminatorDOS = new System.Windows.Forms.RadioButton();
            this.groupBoxExportTypeset = new System.Windows.Forms.GroupBox();
            this.rbDontExportTypesetting = new System.Windows.Forms.RadioButton();
            this.rbExportTypesetting = new System.Windows.Forms.RadioButton();
            this.groupBoxRollup = new System.Windows.Forms.GroupBox();
            this.rbRollUpLinesLimit1 = new System.Windows.Forms.RadioButton();
            this.rbRollUpLinesLimit2 = new System.Windows.Forms.RadioButton();
            this.rbRollUpLinesLimit3 = new System.Windows.Forms.RadioButton();
            this.rbRollUpLinesLimitNone = new System.Windows.Forms.RadioButton();
            this.label48 = new System.Windows.Forms.Label();
            this.cbRollupNoDupeLines = new System.Windows.Forms.CheckBox();
            this.cbRollupRealtime = new System.Windows.Forms.CheckBox();
            this.groupBoxSentenceCase = new System.Windows.Forms.GroupBox();
            this.btnBrowseCapitalizationWords = new System.Windows.Forms.Button();
            this.tbCapitalizationWordsFilename = new System.Windows.Forms.TextBox();
            this.cbSentenceCaseExtraList = new System.Windows.Forms.CheckBox();
            this.rbSentenceCaseDefault = new System.Windows.Forms.RadioButton();
            this.rbSentenceCaseNone = new System.Windows.Forms.RadioButton();
            this.groupBoxTextPosition = new System.Windows.Forms.GroupBox();
            this.cbAutoDash = new System.Windows.Forms.CheckBox();
            this.rbTextPositionCenter = new System.Windows.Forms.RadioButton();
            this.rbTextPositionOriginal = new System.Windows.Forms.RadioButton();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.tbDecoderColor = new System.Windows.Forms.TextBox();
            this.rbColorsReplace = new System.Windows.Forms.RadioButton();
            this.rbColorsDefault = new System.Windows.Forms.RadioButton();
            this.rbColorsDisable = new System.Windows.Forms.RadioButton();
            this.groupBoxEncoding = new System.Windows.Forms.GroupBox();
            this.rbEncodingUnicode = new System.Windows.Forms.RadioButton();
            this.rbEncodingUTF8 = new System.Windows.Forms.RadioButton();
            this.rbEncodingLatin1 = new System.Windows.Forms.RadioButton();
            this.tabPageCredits = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBoxEndCredits = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.updownEndCreditsMaxDisplayedSS = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.updownEndCreditsMinDisplayedSS = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.tbEndCredits = new System.Windows.Forms.TextBox();
            this.cbWriteEndText = new System.Windows.Forms.CheckBox();
            this.groupBoxStartingCredits = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.updownStartCreditsMaxDisplayedSS = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.updownStartCreditsMinDisplayedSS = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.updownStartCreditsNotAfterSS = new System.Windows.Forms.NumericUpDown();
            this.updownStartCreditsNotAfterMM = new System.Windows.Forms.NumericUpDown();
            this.cbbStartCreditsNotLaterThan = new System.Windows.Forms.CheckBox();
            this.updownStartCreditsNotBeforeSS = new System.Windows.Forms.NumericUpDown();
            this.updownStartCreditsNotBeforeMM = new System.Windows.Forms.NumericUpDown();
            this.cbbStartCreditsNotBeforeThan = new System.Windows.Forms.CheckBox();
            this.tbStartCredits = new System.Windows.Forms.TextBox();
            this.cbWriteStartingText = new System.Windows.Forms.CheckBox();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.cbDebugLevDistance = new System.Windows.Forms.CheckBox();
            this.cbDebugAnalyzePackets = new System.Windows.Forms.CheckBox();
            this.cbDebugPMT = new System.Windows.Forms.CheckBox();
            this.cbDebugPAT = new System.Windows.Forms.CheckBox();
            this.cbDebugXDS = new System.Windows.Forms.CheckBox();
            this.cbFullbin = new System.Windows.Forms.CheckBox();
            this.cbNosync = new System.Windows.Forms.CheckBox();
            this.cbDebugContainer = new System.Windows.Forms.CheckBox();
            this.cbDebugRaw608_708wTimestamps = new System.Windows.Forms.CheckBox();
            this.cbDebugESAnalysis = new System.Windows.Forms.CheckBox();
            this.cbDebugTimestamps = new System.Windows.Forms.CheckBox();
            this.cbDebugTraces708 = new System.Windows.Forms.CheckBox();
            this.cbDebugTraces608 = new System.Windows.Forms.CheckBox();
            this.cbDebugInterestingPackets = new System.Windows.Forms.CheckBox();
            this.btnBrowseElementaryStreamFilename = new System.Windows.Forms.Button();
            this.tbElementaryStreamFilename = new System.Windows.Forms.TextBox();
            this.cbDebugWriteES = new System.Windows.Forms.CheckBox();
            this.tabPageHDHomeRun = new System.Windows.Forms.TabPage();
            this.butFindTuners = new System.Windows.Forms.Button();
            this.listBoxTuners = new System.Windows.Forms.ListBox();
            this.label54 = new System.Windows.Forms.Label();
            this.butHDHomeRunDir = new System.Windows.Forms.Button();
            this.tbHDHomeRunPath = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.tabPageExecution = new System.Windows.Forms.TabPage();
            this.progressBarActivity = new System.Windows.Forms.ProgressBar();
            this.LABReportsXDSProgramID = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.LABReportsXDSNetworkCallLetters = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.LABReportsXDSProgramName = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabReportsFramerate = new System.Windows.Forms.Label();
            this.LabReportsAspectRatio = new System.Windows.Forms.Label();
            this.LabReportsVideoResolution = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LabReportsLastMessage = new System.Windows.Forms.Label();
            this.LabReportsCurrentFile = new System.Windows.Forms.Label();
            this.LabReportsStatus = new System.Windows.Forms.Label();
            this.LabReportsPosition = new System.Windows.Forms.Label();
            this.progressBarCCE = new System.Windows.Forms.ProgressBar();
            this.LabReportsCCExtractorVersion = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.LabReportsProgress = new System.Windows.Forms.Label();
            this.saveFileDialogOutput = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogElementaryStream = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogWordsList = new System.Windows.Forms.OpenFileDialog();
            this.textBoxCommandLine = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.folderBrowserDialogHDHomeRun = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBinaryVersionNoOCR = new System.Windows.Forms.RadioButton();
            this.rbBinaryVersionWithOCR = new System.Windows.Forms.RadioButton();
            tabPageDecoders = new System.Windows.Forms.TabPage();
            tabPageDecoders.SuspendLayout();
            this.groupBoxTelext.SuspendLayout();
            this.groupBoxChannel.SuspendLayout();
            this.groupBoxField.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageInput.SuspendLayout();
            this.tabPageInputOptions.SuspendLayout();
            this.groupBoxElementaryStream.SuspendLayout();
            this.groupBoxScreenfulLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownScreenfuls)).BeginInit();
            this.groupBoxEndOfProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownEndSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownEndMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownEndHours)).BeginInit();
            this.groupBoxStartOfProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartHours)).BeginInit();
            this.groupBoxMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnLiveTimeouts)).BeginInit();
            this.groupBoxSplitType.SuspendLayout();
            this.groupBoxInputType.SuspendLayout();
            this.tabPageAdvancedInputOptions.SuspendLayout();
            this.groupBoxAdvancedInputClock.SuspendLayout();
            this.groupBoxMultiprogramTS.SuspendLayout();
            this.groupBoxAdvancedInputMisc.SuspendLayout();
            this.groupBoxMythTV.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            this.groupBoxXDS.SuspendLayout();
            this.bgBOM.SuspendLayout();
            this.groupBoxTimeAdjust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnDelay)).BeginInit();
            this.groupBoxOutputFile.SuspendLayout();
            this.groupBoxOutputType.SuspendLayout();
            this.tabPageOutput2.SuspendLayout();
            this.groupBoxLineTerminator.SuspendLayout();
            this.groupBoxExportTypeset.SuspendLayout();
            this.groupBoxRollup.SuspendLayout();
            this.groupBoxSentenceCase.SuspendLayout();
            this.groupBoxTextPosition.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.groupBoxEncoding.SuspendLayout();
            this.tabPageCredits.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxEndCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownEndCreditsMaxDisplayedSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownEndCreditsMinDisplayedSS)).BeginInit();
            this.groupBoxStartingCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsMaxDisplayedSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsMinDisplayedSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsNotAfterSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsNotAfterMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsNotBeforeSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsNotBeforeMM)).BeginInit();
            this.tabPageDebug.SuspendLayout();
            this.tabPageHDHomeRun.SuspendLayout();
            this.tabPageExecution.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDecoders
            // 
            tabPageDecoders.Controls.Add(this.txtlevdistmaxpct);
            tabPageDecoders.Controls.Add(this.label52);
            tabPageDecoders.Controls.Add(this.txtlevdistmincnt);
            tabPageDecoders.Controls.Add(this.label51);
            tabPageDecoders.Controls.Add(this.label50);
            tabPageDecoders.Controls.Add(this.label21);
            tabPageDecoders.Controls.Add(this.groupBoxTelext);
            tabPageDecoders.Controls.Add(this.label46);
            tabPageDecoders.Controls.Add(this.label43);
            tabPageDecoders.Controls.Add(this.txt708Services);
            tabPageDecoders.Controls.Add(this.label42);
            tabPageDecoders.Controls.Add(this.cbEnable708Decoder);
            tabPageDecoders.Controls.Add(this.label41);
            tabPageDecoders.Controls.Add(this.label40);
            tabPageDecoders.Controls.Add(this.label6);
            tabPageDecoders.Controls.Add(this.groupBoxChannel);
            tabPageDecoders.Controls.Add(this.groupBoxField);
            tabPageDecoders.Controls.Add(this.label39);
            tabPageDecoders.Location = new System.Drawing.Point(4, 22);
            tabPageDecoders.Margin = new System.Windows.Forms.Padding(2);
            tabPageDecoders.Name = "tabPageDecoders";
            tabPageDecoders.Size = new System.Drawing.Size(746, 462);
            tabPageDecoders.TabIndex = 9;
            tabPageDecoders.Text = "Decoders";
            tabPageDecoders.UseVisualStyleBackColor = true;
            // 
            // txtlevdistmaxpct
            // 
            this.txtlevdistmaxpct.Location = new System.Drawing.Point(560, 422);
            this.txtlevdistmaxpct.Margin = new System.Windows.Forms.Padding(2);
            this.txtlevdistmaxpct.Name = "txtlevdistmaxpct";
            this.txtlevdistmaxpct.Size = new System.Drawing.Size(76, 20);
            this.txtlevdistmaxpct.TabIndex = 24;
            this.txtlevdistmaxpct.TextChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(285, 427);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(270, 13);
            this.label52.TabIndex = 23;
            this.label52.Text = "Maximum allowed distance, as a % of length (default 10)";
            // 
            // txtlevdistmincnt
            // 
            this.txtlevdistmincnt.Location = new System.Drawing.Point(187, 424);
            this.txtlevdistmincnt.Margin = new System.Windows.Forms.Padding(2);
            this.txtlevdistmincnt.Name = "txtlevdistmincnt";
            this.txtlevdistmincnt.Size = new System.Drawing.Size(76, 20);
            this.txtlevdistmincnt.TabIndex = 22;
            this.txtlevdistmincnt.TextChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(2, 427);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(180, 13);
            this.label51.TabIndex = 21;
            this.label51.Text = "Minimum allowed distance (default 2)";
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(2, 396);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(740, 31);
            this.label50.TabIndex = 20;
            this.label50.Text = resources.GetString("label50.Text");
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(-1, 375);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(751, 17);
            this.label21.TabIndex = 19;
            this.label21.Text = "Teletext line deduplication";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxTelext
            // 
            this.groupBoxTelext.Controls.Add(this.rbPreferDVB);
            this.groupBoxTelext.Controls.Add(this.txtTeletextPage);
            this.groupBoxTelext.Controls.Add(this.label49);
            this.groupBoxTelext.Controls.Add(this.rbTeletextForce);
            this.groupBoxTelext.Controls.Add(this.txtTeletextPID);
            this.groupBoxTelext.Controls.Add(this.rbTeletextDisable);
            this.groupBoxTelext.Controls.Add(this.label47);
            this.groupBoxTelext.Controls.Add(this.rbTeletextAuto);
            this.groupBoxTelext.Location = new System.Drawing.Point(2, 272);
            this.groupBoxTelext.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTelext.Name = "groupBoxTelext";
            this.groupBoxTelext.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTelext.Size = new System.Drawing.Size(746, 99);
            this.groupBoxTelext.TabIndex = 18;
            this.groupBoxTelext.TabStop = false;
            // 
            // rbPreferDVB
            // 
            this.rbPreferDVB.AutoSize = true;
            this.rbPreferDVB.Location = new System.Drawing.Point(6, 65);
            this.rbPreferDVB.Margin = new System.Windows.Forms.Padding(2);
            this.rbPreferDVB.Name = "rbPreferDVB";
            this.rbPreferDVB.Size = new System.Drawing.Size(268, 17);
            this.rbPreferDVB.TabIndex = 20;
            this.rbPreferDVB.TabStop = true;
            this.rbPreferDVB.Text = "Prefer DVB over teletext subtitles if both are present";
            this.rbPreferDVB.UseVisualStyleBackColor = true;
            this.rbPreferDVB.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // txtTeletextPage
            // 
            this.txtTeletextPage.Location = new System.Drawing.Point(528, 66);
            this.txtTeletextPage.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeletextPage.Name = "txtTeletextPage";
            this.txtTeletextPage.Size = new System.Drawing.Size(76, 20);
            this.txtTeletextPage.TabIndex = 19;
            this.txtTeletextPage.TextChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            this.txtTeletextPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeletextPage_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(330, 68);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(192, 13);
            this.label49.TabIndex = 18;
            this.label49.Text = "Page for subtitles (blank for autodetect)";
            // 
            // rbTeletextForce
            // 
            this.rbTeletextForce.AutoSize = true;
            this.rbTeletextForce.Location = new System.Drawing.Point(286, 17);
            this.rbTeletextForce.Margin = new System.Windows.Forms.Padding(2);
            this.rbTeletextForce.Name = "rbTeletextForce";
            this.rbTeletextForce.Size = new System.Drawing.Size(232, 17);
            this.rbTeletextForce.TabIndex = 2;
            this.rbTeletextForce.Text = "Force telext processing even if not detected";
            this.rbTeletextForce.UseVisualStyleBackColor = true;
            this.rbTeletextForce.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // txtTeletextPID
            // 
            this.txtTeletextPID.Location = new System.Drawing.Point(528, 34);
            this.txtTeletextPID.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeletextPID.Name = "txtTeletextPID";
            this.txtTeletextPID.Size = new System.Drawing.Size(76, 20);
            this.txtTeletextPID.TabIndex = 17;
            this.txtTeletextPID.TextChanged += new System.EventHandler(this.txtTeletextPID_TextChanged);
            this.txtTeletextPID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeletextPID_KeyPress);
            // 
            // rbTeletextDisable
            // 
            this.rbTeletextDisable.AutoSize = true;
            this.rbTeletextDisable.Location = new System.Drawing.Point(133, 17);
            this.rbTeletextDisable.Margin = new System.Windows.Forms.Padding(2);
            this.rbTeletextDisable.Name = "rbTeletextDisable";
            this.rbTeletextDisable.Size = new System.Drawing.Size(151, 17);
            this.rbTeletextDisable.TabIndex = 1;
            this.rbTeletextDisable.Text = "Disable teletext processing";
            this.rbTeletextDisable.UseVisualStyleBackColor = true;
            this.rbTeletextDisable.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(378, 37);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(147, 13);
            this.label47.TabIndex = 16;
            this.label47.Text = "and extract data from this PID";
            // 
            // rbTeletextAuto
            // 
            this.rbTeletextAuto.AutoSize = true;
            this.rbTeletextAuto.Checked = true;
            this.rbTeletextAuto.Location = new System.Drawing.Point(6, 17);
            this.rbTeletextAuto.Margin = new System.Windows.Forms.Padding(2);
            this.rbTeletextAuto.Name = "rbTeletextAuto";
            this.rbTeletextAuto.Size = new System.Drawing.Size(114, 17);
            this.rbTeletextAuto.TabIndex = 0;
            this.rbTeletextAuto.TabStop = true;
            this.rbTeletextAuto.Text = "Autodetect teletext";
            this.rbTeletextAuto.UseVisualStyleBackColor = true;
            this.rbTeletextAuto.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label46.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(-2, 253);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(751, 17);
            this.label46.TabIndex = 14;
            this.label46.Text = "Teletext decoder";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(2, 203);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(744, 50);
            this.label43.TabIndex = 13;
            this.label43.Text = resources.GetString("label43.Text");
            // 
            // txt708Services
            // 
            this.txt708Services.Location = new System.Drawing.Point(277, 173);
            this.txt708Services.Margin = new System.Windows.Forms.Padding(2);
            this.txt708Services.Name = "txt708Services";
            this.txt708Services.Size = new System.Drawing.Size(122, 20);
            this.txt708Services.TabIndex = 12;
            this.txt708Services.Text = "1,2";
            this.txt708Services.TextChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            this.txt708Services.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt708Services_KeyPress);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(154, 173);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(119, 13);
            this.label42.TabIndex = 11;
            this.label42.Text = "Process these services:";
            // 
            // cbEnable708Decoder
            // 
            this.cbEnable708Decoder.AutoSize = true;
            this.cbEnable708Decoder.Location = new System.Drawing.Point(6, 172);
            this.cbEnable708Decoder.Margin = new System.Windows.Forms.Padding(2);
            this.cbEnable708Decoder.Name = "cbEnable708Decoder";
            this.cbEnable708Decoder.Size = new System.Drawing.Size(122, 17);
            this.cbEnable708Decoder.TabIndex = 10;
            this.cbEnable708Decoder.Text = "Enable 708 decoder";
            this.cbEnable708Decoder.UseVisualStyleBackColor = true;
            this.cbEnable708Decoder.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(2, 121);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(744, 36);
            this.label41.TabIndex = 9;
            this.label41.Text = resources.GetString("label41.Text");
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(-2, 95);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(751, 17);
            this.label40.TabIndex = 8;
            this.label40.Text = "708 Decoder";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(355, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(394, 73);
            this.label6.TabIndex = 7;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // groupBoxChannel
            // 
            this.groupBoxChannel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxChannel.Controls.Add(this.rbChannel2);
            this.groupBoxChannel.Controls.Add(this.rbChannel1);
            this.groupBoxChannel.Location = new System.Drawing.Point(165, 18);
            this.groupBoxChannel.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxChannel.Name = "groupBoxChannel";
            this.groupBoxChannel.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxChannel.Size = new System.Drawing.Size(184, 73);
            this.groupBoxChannel.TabIndex = 6;
            this.groupBoxChannel.TabStop = false;
            this.groupBoxChannel.Text = "Channel";
            // 
            // rbChannel2
            // 
            this.rbChannel2.AutoSize = true;
            this.rbChannel2.Location = new System.Drawing.Point(4, 37);
            this.rbChannel2.Margin = new System.Windows.Forms.Padding(2);
            this.rbChannel2.Name = "rbChannel2";
            this.rbChannel2.Size = new System.Drawing.Size(174, 17);
            this.rbChannel2.TabIndex = 1;
            this.rbChannel2.Text = "Extract captions from channel 2";
            this.rbChannel2.UseVisualStyleBackColor = true;
            this.rbChannel2.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbChannel1
            // 
            this.rbChannel1.AutoSize = true;
            this.rbChannel1.Checked = true;
            this.rbChannel1.Location = new System.Drawing.Point(4, 17);
            this.rbChannel1.Margin = new System.Windows.Forms.Padding(2);
            this.rbChannel1.Name = "rbChannel1";
            this.rbChannel1.Size = new System.Drawing.Size(174, 17);
            this.rbChannel1.TabIndex = 0;
            this.rbChannel1.TabStop = true;
            this.rbChannel1.Text = "Extract captions from channel 1";
            this.rbChannel1.UseVisualStyleBackColor = true;
            this.rbChannel1.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxField
            // 
            this.groupBoxField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxField.Controls.Add(this.cbField2);
            this.groupBoxField.Controls.Add(this.cbField1);
            this.groupBoxField.Location = new System.Drawing.Point(0, 18);
            this.groupBoxField.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxField.Name = "groupBoxField";
            this.groupBoxField.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxField.Size = new System.Drawing.Size(164, 73);
            this.groupBoxField.TabIndex = 5;
            this.groupBoxField.TabStop = false;
            this.groupBoxField.Text = "Field";
            // 
            // cbField2
            // 
            this.cbField2.AutoSize = true;
            this.cbField2.Location = new System.Drawing.Point(4, 39);
            this.cbField2.Margin = new System.Windows.Forms.Padding(2);
            this.cbField2.Name = "cbField2";
            this.cbField2.Size = new System.Drawing.Size(156, 17);
            this.cbField2.TabIndex = 1;
            this.cbField2.Text = "Extract captions from field 2";
            this.cbField2.UseVisualStyleBackColor = true;
            this.cbField2.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbField1
            // 
            this.cbField1.AutoSize = true;
            this.cbField1.Checked = true;
            this.cbField1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbField1.Location = new System.Drawing.Point(4, 17);
            this.cbField1.Margin = new System.Windows.Forms.Padding(2);
            this.cbField1.Name = "cbField1";
            this.cbField1.Size = new System.Drawing.Size(156, 17);
            this.cbField1.TabIndex = 0;
            this.cbField1.Text = "Extract captions from field 1";
            this.cbField1.UseVisualStyleBackColor = true;
            this.cbField1.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(-2, 0);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(751, 17);
            this.label39.TabIndex = 0;
            this.label39.Text = "608 Decoder";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Controls.Add(this.tabPageInput);
            this.tabControlMain.Controls.Add(this.tabPageInputOptions);
            this.tabControlMain.Controls.Add(this.tabPageAdvancedInputOptions);
            this.tabControlMain.Controls.Add(tabPageDecoders);
            this.tabControlMain.Controls.Add(this.tabPageOutput);
            this.tabControlMain.Controls.Add(this.tabPageOutput2);
            this.tabControlMain.Controls.Add(this.tabPageCredits);
            this.tabControlMain.Controls.Add(this.tabPageDebug);
            this.tabControlMain.Controls.Add(this.tabPageHDHomeRun);
            this.tabControlMain.Controls.Add(this.tabPageExecution);
            this.tabControlMain.Location = new System.Drawing.Point(0, 10);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(754, 488);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.linkLabel2);
            this.tabPageAbout.Controls.Add(this.label44);
            this.tabPageAbout.Controls.Add(this.label27);
            this.tabPageAbout.Controls.Add(this.butRestoreDefault);
            this.tabPageAbout.Controls.Add(this.btnSaveAsDefault);
            this.tabPageAbout.Controls.Add(this.pictureBox2);
            this.tabPageAbout.Controls.Add(this.label23);
            this.tabPageAbout.Controls.Add(this.label22);
            this.tabPageAbout.Controls.Add(this.pictureBox1);
            this.tabPageAbout.Controls.Add(this.linkLabel1);
            this.tabPageAbout.Controls.Add(this.label20);
            this.tabPageAbout.Controls.Add(this.label19);
            this.tabPageAbout.Controls.Add(this.label18);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAbout.Size = new System.Drawing.Size(746, 462);
            this.tabPageAbout.TabIndex = 7;
            this.tabPageAbout.Text = "About & Save";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(10, 173);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(177, 13);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "GitHub issue tracker for CCExtractor";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(10, 130);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(730, 43);
            this.label44.TabIndex = 13;
            this.label44.Text = resources.GetString("label44.Text");
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(7, 217);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(565, 36);
            this.label27.TabIndex = 12;
            this.label27.Text = "CCExtractor\'s developers are available for hire for customizations and improvemen" +
    "ts.";
            // 
            // butRestoreDefault
            // 
            this.butRestoreDefault.Location = new System.Drawing.Point(570, 406);
            this.butRestoreDefault.Margin = new System.Windows.Forms.Padding(2);
            this.butRestoreDefault.Name = "butRestoreDefault";
            this.butRestoreDefault.Size = new System.Drawing.Size(146, 21);
            this.butRestoreDefault.TabIndex = 11;
            this.butRestoreDefault.Text = "Restore default settings";
            this.butRestoreDefault.UseVisualStyleBackColor = true;
            this.butRestoreDefault.Click += new System.EventHandler(this.butRestoreDefault_Click);
            // 
            // btnSaveAsDefault
            // 
            this.btnSaveAsDefault.Location = new System.Drawing.Point(373, 406);
            this.btnSaveAsDefault.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAsDefault.Name = "btnSaveAsDefault";
            this.btnSaveAsDefault.Size = new System.Drawing.Size(172, 21);
            this.btnSaveAsDefault.TabIndex = 10;
            this.btnSaveAsDefault.Text = "Save current options as default";
            this.btnSaveAsDefault.UseVisualStyleBackColor = true;
            this.btnSaveAsDefault.Click += new System.EventHandler(this.btnSaveAsDefault_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CCExtractorGUI.Properties.Resources.carlos_email;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(88, 255);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 49);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 264);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Contact email:";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(10, 83);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(733, 36);
            this.label22.TabIndex = 7;
            this.label22.Text = "CCExtractor is tested on samples submitted by users. If there is a specific file " +
    "CCExtractor can\'t handle, or whatever format your recording equipment is not sup" +
    "ported, please help by reporting it.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 47);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(113, 54);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.ccextractor.org";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 54);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Project homepage:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(299, 21);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 7);
            this.label19.TabIndex = 1;
            this.label19.Text = "A free, GPL licensed closed caption tool";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(320, 5);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "CCExtractor";
            // 
            // tabPageInput
            // 
            this.tabPageInput.Controls.Add(this.groupBox1);
            this.tabPageInput.Controls.Add(this.radioButton1);
            this.tabPageInput.Controls.Add(this.tbUTPListenPort);
            this.tabPageInput.Controls.Add(this.rbInputUTP);
            this.tabPageInput.Controls.Add(this.butClearInputList);
            this.tabPageInput.Controls.Add(this.listViewInputFiles);
            this.tabPageInput.Location = new System.Drawing.Point(4, 22);
            this.tabPageInput.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageInput.Name = "tabPageInput";
            this.tabPageInput.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageInput.Size = new System.Drawing.Size(746, 462);
            this.tabPageInput.TabIndex = 0;
            this.tabPageInput.Text = "Input files";
            this.tabPageInput.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 46);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(254, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Process files from box below (drag them into box)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // tbUTPListenPort
            // 
            this.tbUTPListenPort.Location = new System.Drawing.Point(205, 14);
            this.tbUTPListenPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbUTPListenPort.Name = "tbUTPListenPort";
            this.tbUTPListenPort.Size = new System.Drawing.Size(76, 20);
            this.tbUTPListenPort.TabIndex = 4;
            this.tbUTPListenPort.Text = "1235";
            // 
            // rbInputUTP
            // 
            this.rbInputUTP.AutoSize = true;
            this.rbInputUTP.Location = new System.Drawing.Point(6, 14);
            this.rbInputUTP.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputUTP.Name = "rbInputUTP";
            this.rbInputUTP.Size = new System.Drawing.Size(197, 17);
            this.rbInputUTP.TabIndex = 3;
            this.rbInputUTP.Text = "Process input via UTP, listen on port";
            this.rbInputUTP.UseVisualStyleBackColor = true;
            this.rbInputUTP.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // butClearInputList
            // 
            this.butClearInputList.Location = new System.Drawing.Point(667, 42);
            this.butClearInputList.Margin = new System.Windows.Forms.Padding(2);
            this.butClearInputList.Name = "butClearInputList";
            this.butClearInputList.Size = new System.Drawing.Size(76, 21);
            this.butClearInputList.TabIndex = 2;
            this.butClearInputList.Text = "Clear list";
            this.butClearInputList.UseVisualStyleBackColor = true;
            this.butClearInputList.Click += new System.EventHandler(this.butClearInputList_Click);
            // 
            // listViewInputFiles
            // 
            this.listViewInputFiles.AllowDrop = true;
            this.listViewInputFiles.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listViewInputFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewInputFiles.FullRowSelect = true;
            this.listViewInputFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewInputFiles.Location = new System.Drawing.Point(2, 78);
            this.listViewInputFiles.Margin = new System.Windows.Forms.Padding(2);
            this.listViewInputFiles.MultiSelect = false;
            this.listViewInputFiles.Name = "listViewInputFiles";
            this.listViewInputFiles.ShowGroups = false;
            this.listViewInputFiles.Size = new System.Drawing.Size(744, 311);
            this.listViewInputFiles.TabIndex = 0;
            this.listViewInputFiles.UseCompatibleStateImageBehavior = false;
            this.listViewInputFiles.View = System.Windows.Forms.View.List;
            this.listViewInputFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewInputFiles_DragDrop);
            this.listViewInputFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewInputFiles_DragEnter);
            // 
            // tabPageInputOptions
            // 
            this.tabPageInputOptions.Controls.Add(this.groupBoxElementaryStream);
            this.tabPageInputOptions.Controls.Add(this.groupBoxScreenfulLimits);
            this.tabPageInputOptions.Controls.Add(this.groupBoxEndOfProcessing);
            this.tabPageInputOptions.Controls.Add(this.groupBoxStartOfProcessing);
            this.tabPageInputOptions.Controls.Add(this.groupBoxMode);
            this.tabPageInputOptions.Controls.Add(this.groupBoxSplitType);
            this.tabPageInputOptions.Controls.Add(this.groupBoxInputType);
            this.tabPageInputOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageInputOptions.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageInputOptions.Name = "tabPageInputOptions";
            this.tabPageInputOptions.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageInputOptions.Size = new System.Drawing.Size(746, 462);
            this.tabPageInputOptions.TabIndex = 2;
            this.tabPageInputOptions.Text = "Input options";
            this.tabPageInputOptions.UseVisualStyleBackColor = true;
            // 
            // groupBoxElementaryStream
            // 
            this.groupBoxElementaryStream.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxElementaryStream.Controls.Add(this.label1);
            this.groupBoxElementaryStream.Controls.Add(this.tbElementaryStreamType);
            this.groupBoxElementaryStream.Controls.Add(this.tbElementaryDataStreamType);
            this.groupBoxElementaryStream.Controls.Add(this.rbElementaryStreamSelectType);
            this.groupBoxElementaryStream.Controls.Add(this.tbElementaryStreamPID);
            this.groupBoxElementaryStream.Controls.Add(this.rbElementaryStreamFixedStreamNumber);
            this.groupBoxElementaryStream.Controls.Add(this.rbElementaryStreamAuto);
            this.groupBoxElementaryStream.Location = new System.Drawing.Point(0, 320);
            this.groupBoxElementaryStream.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxElementaryStream.Name = "groupBoxElementaryStream";
            this.groupBoxElementaryStream.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxElementaryStream.Size = new System.Drawing.Size(748, 73);
            this.groupBoxElementaryStream.TabIndex = 9;
            this.groupBoxElementaryStream.TabStop = false;
            this.groupBoxElementaryStream.Text = "Elementary Stream";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Process the stream as if its MPEG type is ";
            // 
            // tbElementaryStreamType
            // 
            this.tbElementaryStreamType.Location = new System.Drawing.Point(488, 41);
            this.tbElementaryStreamType.Margin = new System.Windows.Forms.Padding(2);
            this.tbElementaryStreamType.Name = "tbElementaryStreamType";
            this.tbElementaryStreamType.Size = new System.Drawing.Size(68, 20);
            this.tbElementaryStreamType.TabIndex = 5;
            this.tbElementaryStreamType.TextChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // tbElementaryDataStreamType
            // 
            this.tbElementaryDataStreamType.Location = new System.Drawing.Point(488, 17);
            this.tbElementaryDataStreamType.Margin = new System.Windows.Forms.Padding(2);
            this.tbElementaryDataStreamType.Name = "tbElementaryDataStreamType";
            this.tbElementaryDataStreamType.Size = new System.Drawing.Size(76, 20);
            this.tbElementaryDataStreamType.TabIndex = 4;
            this.tbElementaryDataStreamType.TextChanged += new System.EventHandler(this.tbElementaryDataStreamType_TextChanged);
            // 
            // rbElementaryStreamSelectType
            // 
            this.rbElementaryStreamSelectType.AutoSize = true;
            this.rbElementaryStreamSelectType.Location = new System.Drawing.Point(286, 17);
            this.rbElementaryStreamSelectType.Margin = new System.Windows.Forms.Padding(2);
            this.rbElementaryStreamSelectType.Name = "rbElementaryStreamSelectType";
            this.rbElementaryStreamSelectType.Size = new System.Drawing.Size(198, 17);
            this.rbElementaryStreamSelectType.TabIndex = 3;
            this.rbElementaryStreamSelectType.Text = "Process the first stream with this type";
            this.rbElementaryStreamSelectType.UseVisualStyleBackColor = true;
            this.rbElementaryStreamSelectType.CheckedChanged += new System.EventHandler(this.rbElementaryStreamSelectType_CheckedChanged);
            // 
            // tbElementaryStreamPID
            // 
            this.tbElementaryStreamPID.Location = new System.Drawing.Point(182, 38);
            this.tbElementaryStreamPID.Margin = new System.Windows.Forms.Padding(2);
            this.tbElementaryStreamPID.Name = "tbElementaryStreamPID";
            this.tbElementaryStreamPID.Size = new System.Drawing.Size(76, 20);
            this.tbElementaryStreamPID.TabIndex = 2;
            this.tbElementaryStreamPID.TextChanged += new System.EventHandler(this.tbElementaryStreamPID_TextChanged);
            // 
            // rbElementaryStreamFixedStreamNumber
            // 
            this.rbElementaryStreamFixedStreamNumber.AutoSize = true;
            this.rbElementaryStreamFixedStreamNumber.Location = new System.Drawing.Point(4, 39);
            this.rbElementaryStreamFixedStreamNumber.Margin = new System.Windows.Forms.Padding(2);
            this.rbElementaryStreamFixedStreamNumber.Name = "rbElementaryStreamFixedStreamNumber";
            this.rbElementaryStreamFixedStreamNumber.Size = new System.Drawing.Size(177, 17);
            this.rbElementaryStreamFixedStreamNumber.TabIndex = 1;
            this.rbElementaryStreamFixedStreamNumber.Text = "Process the stream with this PID";
            this.rbElementaryStreamFixedStreamNumber.UseVisualStyleBackColor = true;
            this.rbElementaryStreamFixedStreamNumber.CheckedChanged += new System.EventHandler(this.rbElementaryStreamFixedStreamNumber_CheckedChanged);
            // 
            // rbElementaryStreamAuto
            // 
            this.rbElementaryStreamAuto.AutoSize = true;
            this.rbElementaryStreamAuto.Checked = true;
            this.rbElementaryStreamAuto.Location = new System.Drawing.Point(4, 17);
            this.rbElementaryStreamAuto.Margin = new System.Windows.Forms.Padding(2);
            this.rbElementaryStreamAuto.Name = "rbElementaryStreamAuto";
            this.rbElementaryStreamAuto.Size = new System.Drawing.Size(232, 17);
            this.rbElementaryStreamAuto.TabIndex = 0;
            this.rbElementaryStreamAuto.TabStop = true;
            this.rbElementaryStreamAuto.Text = "Select the stream most likely to contain data";
            this.rbElementaryStreamAuto.UseVisualStyleBackColor = true;
            this.rbElementaryStreamAuto.CheckedChanged += new System.EventHandler(this.rbElementaryStreamAuto_CheckedChanged);
            // 
            // groupBoxScreenfulLimits
            // 
            this.groupBoxScreenfulLimits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxScreenfulLimits.Controls.Add(this.updownScreenfuls);
            this.groupBoxScreenfulLimits.Controls.Add(this.label5);
            this.groupBoxScreenfulLimits.Controls.Add(this.rbScreenfulsStopAfter);
            this.groupBoxScreenfulLimits.Controls.Add(this.rbScreenfulsNoLimit);
            this.groupBoxScreenfulLimits.Location = new System.Drawing.Point(390, 263);
            this.groupBoxScreenfulLimits.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxScreenfulLimits.Name = "groupBoxScreenfulLimits";
            this.groupBoxScreenfulLimits.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxScreenfulLimits.Size = new System.Drawing.Size(358, 57);
            this.groupBoxScreenfulLimits.TabIndex = 8;
            this.groupBoxScreenfulLimits.TabStop = false;
            this.groupBoxScreenfulLimits.Text = "\"Screenfuls\" limit";
            // 
            // updownScreenfuls
            // 
            this.updownScreenfuls.Location = new System.Drawing.Point(70, 37);
            this.updownScreenfuls.Margin = new System.Windows.Forms.Padding(2);
            this.updownScreenfuls.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updownScreenfuls.Name = "updownScreenfuls";
            this.updownScreenfuls.Size = new System.Drawing.Size(49, 20);
            this.updownScreenfuls.TabIndex = 2;
            this.updownScreenfuls.ValueChanged += new System.EventHandler(this.updownScreenfuls_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "screenfuls";
            // 
            // rbScreenfulsStopAfter
            // 
            this.rbScreenfulsStopAfter.AutoSize = true;
            this.rbScreenfulsStopAfter.Location = new System.Drawing.Point(4, 37);
            this.rbScreenfulsStopAfter.Margin = new System.Windows.Forms.Padding(2);
            this.rbScreenfulsStopAfter.Name = "rbScreenfulsStopAfter";
            this.rbScreenfulsStopAfter.Size = new System.Drawing.Size(71, 17);
            this.rbScreenfulsStopAfter.TabIndex = 1;
            this.rbScreenfulsStopAfter.Text = "Stop after";
            this.rbScreenfulsStopAfter.UseVisualStyleBackColor = true;
            this.rbScreenfulsStopAfter.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbScreenfulsNoLimit
            // 
            this.rbScreenfulsNoLimit.AutoSize = true;
            this.rbScreenfulsNoLimit.Checked = true;
            this.rbScreenfulsNoLimit.Location = new System.Drawing.Point(4, 17);
            this.rbScreenfulsNoLimit.Margin = new System.Windows.Forms.Padding(2);
            this.rbScreenfulsNoLimit.Name = "rbScreenfulsNoLimit";
            this.rbScreenfulsNoLimit.Size = new System.Drawing.Size(59, 17);
            this.rbScreenfulsNoLimit.TabIndex = 0;
            this.rbScreenfulsNoLimit.TabStop = true;
            this.rbScreenfulsNoLimit.Text = "No limit";
            this.rbScreenfulsNoLimit.UseVisualStyleBackColor = true;
            this.rbScreenfulsNoLimit.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxEndOfProcessing
            // 
            this.groupBoxEndOfProcessing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxEndOfProcessing.Controls.Add(this.updownEndSeconds);
            this.groupBoxEndOfProcessing.Controls.Add(this.updownEndMinutes);
            this.groupBoxEndOfProcessing.Controls.Add(this.updownEndHours);
            this.groupBoxEndOfProcessing.Controls.Add(this.rbProcessingEndToPoint);
            this.groupBoxEndOfProcessing.Controls.Add(this.rbProcessingEndToFinish);
            this.groupBoxEndOfProcessing.Location = new System.Drawing.Point(195, 263);
            this.groupBoxEndOfProcessing.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEndOfProcessing.Name = "groupBoxEndOfProcessing";
            this.groupBoxEndOfProcessing.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEndOfProcessing.Size = new System.Drawing.Size(195, 57);
            this.groupBoxEndOfProcessing.TabIndex = 7;
            this.groupBoxEndOfProcessing.TabStop = false;
            this.groupBoxEndOfProcessing.Text = "End of processing";
            // 
            // updownEndSeconds
            // 
            this.updownEndSeconds.Location = new System.Drawing.Point(138, 36);
            this.updownEndSeconds.Margin = new System.Windows.Forms.Padding(2);
            this.updownEndSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownEndSeconds.Name = "updownEndSeconds";
            this.updownEndSeconds.Size = new System.Drawing.Size(35, 20);
            this.updownEndSeconds.TabIndex = 4;
            this.updownEndSeconds.ValueChanged += new System.EventHandler(this.EndAtTimeChanged);
            // 
            // updownEndMinutes
            // 
            this.updownEndMinutes.Location = new System.Drawing.Point(98, 36);
            this.updownEndMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.updownEndMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownEndMinutes.Name = "updownEndMinutes";
            this.updownEndMinutes.Size = new System.Drawing.Size(35, 20);
            this.updownEndMinutes.TabIndex = 3;
            this.updownEndMinutes.ValueChanged += new System.EventHandler(this.EndAtTimeChanged);
            // 
            // updownEndHours
            // 
            this.updownEndHours.Location = new System.Drawing.Point(58, 36);
            this.updownEndHours.Margin = new System.Windows.Forms.Padding(2);
            this.updownEndHours.Name = "updownEndHours";
            this.updownEndHours.Size = new System.Drawing.Size(35, 20);
            this.updownEndHours.TabIndex = 2;
            this.updownEndHours.ValueChanged += new System.EventHandler(this.EndAtTimeChanged);
            // 
            // rbProcessingEndToPoint
            // 
            this.rbProcessingEndToPoint.AutoSize = true;
            this.rbProcessingEndToPoint.Location = new System.Drawing.Point(4, 37);
            this.rbProcessingEndToPoint.Margin = new System.Windows.Forms.Padding(2);
            this.rbProcessingEndToPoint.Name = "rbProcessingEndToPoint";
            this.rbProcessingEndToPoint.Size = new System.Drawing.Size(56, 17);
            this.rbProcessingEndToPoint.TabIndex = 1;
            this.rbProcessingEndToPoint.Text = "End at";
            this.rbProcessingEndToPoint.UseVisualStyleBackColor = true;
            this.rbProcessingEndToPoint.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbProcessingEndToFinish
            // 
            this.rbProcessingEndToFinish.AutoSize = true;
            this.rbProcessingEndToFinish.Checked = true;
            this.rbProcessingEndToFinish.Location = new System.Drawing.Point(4, 17);
            this.rbProcessingEndToFinish.Margin = new System.Windows.Forms.Padding(2);
            this.rbProcessingEndToFinish.Name = "rbProcessingEndToFinish";
            this.rbProcessingEndToFinish.Size = new System.Drawing.Size(173, 17);
            this.rbProcessingEndToFinish.TabIndex = 0;
            this.rbProcessingEndToFinish.TabStop = true;
            this.rbProcessingEndToFinish.Text = "Process the input up to the end";
            this.rbProcessingEndToFinish.UseVisualStyleBackColor = true;
            this.rbProcessingEndToFinish.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxStartOfProcessing
            // 
            this.groupBoxStartOfProcessing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxStartOfProcessing.Controls.Add(this.updownStartSeconds);
            this.groupBoxStartOfProcessing.Controls.Add(this.updownStartMinutes);
            this.groupBoxStartOfProcessing.Controls.Add(this.updownStartHours);
            this.groupBoxStartOfProcessing.Controls.Add(this.rbProcessingStartFromPoint);
            this.groupBoxStartOfProcessing.Controls.Add(this.rbProcessingStartFromBeginning);
            this.groupBoxStartOfProcessing.Location = new System.Drawing.Point(0, 263);
            this.groupBoxStartOfProcessing.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxStartOfProcessing.Name = "groupBoxStartOfProcessing";
            this.groupBoxStartOfProcessing.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxStartOfProcessing.Size = new System.Drawing.Size(195, 57);
            this.groupBoxStartOfProcessing.TabIndex = 6;
            this.groupBoxStartOfProcessing.TabStop = false;
            this.groupBoxStartOfProcessing.Text = "Start of processing";
            // 
            // updownStartSeconds
            // 
            this.updownStartSeconds.Location = new System.Drawing.Point(138, 36);
            this.updownStartSeconds.Margin = new System.Windows.Forms.Padding(2);
            this.updownStartSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownStartSeconds.Name = "updownStartSeconds";
            this.updownStartSeconds.Size = new System.Drawing.Size(35, 20);
            this.updownStartSeconds.TabIndex = 4;
            this.updownStartSeconds.ValueChanged += new System.EventHandler(this.StartAtTimeChanged);
            // 
            // updownStartMinutes
            // 
            this.updownStartMinutes.Location = new System.Drawing.Point(98, 35);
            this.updownStartMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.updownStartMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownStartMinutes.Name = "updownStartMinutes";
            this.updownStartMinutes.Size = new System.Drawing.Size(35, 20);
            this.updownStartMinutes.TabIndex = 3;
            this.updownStartMinutes.ValueChanged += new System.EventHandler(this.StartAtTimeChanged);
            // 
            // updownStartHours
            // 
            this.updownStartHours.Location = new System.Drawing.Point(58, 36);
            this.updownStartHours.Margin = new System.Windows.Forms.Padding(2);
            this.updownStartHours.Name = "updownStartHours";
            this.updownStartHours.Size = new System.Drawing.Size(35, 20);
            this.updownStartHours.TabIndex = 2;
            this.updownStartHours.ValueChanged += new System.EventHandler(this.StartAtTimeChanged);
            // 
            // rbProcessingStartFromPoint
            // 
            this.rbProcessingStartFromPoint.AutoSize = true;
            this.rbProcessingStartFromPoint.Location = new System.Drawing.Point(4, 37);
            this.rbProcessingStartFromPoint.Margin = new System.Windows.Forms.Padding(2);
            this.rbProcessingStartFromPoint.Name = "rbProcessingStartFromPoint";
            this.rbProcessingStartFromPoint.Size = new System.Drawing.Size(59, 17);
            this.rbProcessingStartFromPoint.TabIndex = 1;
            this.rbProcessingStartFromPoint.Text = "Start at";
            this.rbProcessingStartFromPoint.UseVisualStyleBackColor = true;
            this.rbProcessingStartFromPoint.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbProcessingStartFromBeginning
            // 
            this.rbProcessingStartFromBeginning.AutoSize = true;
            this.rbProcessingStartFromBeginning.Checked = true;
            this.rbProcessingStartFromBeginning.Location = new System.Drawing.Point(4, 17);
            this.rbProcessingStartFromBeginning.Margin = new System.Windows.Forms.Padding(2);
            this.rbProcessingStartFromBeginning.Name = "rbProcessingStartFromBeginning";
            this.rbProcessingStartFromBeginning.Size = new System.Drawing.Size(171, 17);
            this.rbProcessingStartFromBeginning.TabIndex = 0;
            this.rbProcessingStartFromBeginning.TabStop = true;
            this.rbProcessingStartFromBeginning.Text = "Process the input from the start";
            this.rbProcessingStartFromBeginning.UseVisualStyleBackColor = true;
            this.rbProcessingStartFromBeginning.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxMode.Controls.Add(this.label26);
            this.groupBoxMode.Controls.Add(this.upDwnLiveTimeouts);
            this.groupBoxMode.Controls.Add(this.label3);
            this.groupBoxMode.Controls.Add(this.rbModeLive);
            this.groupBoxMode.Controls.Add(this.rbModeComplete);
            this.groupBoxMode.Location = new System.Drawing.Point(0, 215);
            this.groupBoxMode.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMode.Size = new System.Drawing.Size(748, 48);
            this.groupBoxMode.TabIndex = 5;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(526, 32);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 7);
            this.label26.TabIndex = 5;
            this.label26.Text = "(0 = no limit)";
            // 
            // upDwnLiveTimeouts
            // 
            this.upDwnLiveTimeouts.Location = new System.Drawing.Point(478, 19);
            this.upDwnLiveTimeouts.Margin = new System.Windows.Forms.Padding(2);
            this.upDwnLiveTimeouts.Name = "upDwnLiveTimeouts";
            this.upDwnLiveTimeouts.Size = new System.Drawing.Size(43, 20);
            this.upDwnLiveTimeouts.TabIndex = 4;
            this.upDwnLiveTimeouts.ValueChanged += new System.EventHandler(this.upDwnLiveTimeouts_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "seconds.";
            // 
            // rbModeLive
            // 
            this.rbModeLive.AutoSize = true;
            this.rbModeLive.Location = new System.Drawing.Point(170, 17);
            this.rbModeLive.Margin = new System.Windows.Forms.Padding(2);
            this.rbModeLive.Name = "rbModeLive";
            this.rbModeLive.Size = new System.Drawing.Size(309, 17);
            this.rbModeLive.TabIndex = 1;
            this.rbModeLive.Text = "This is live. Continue reading file until no new data arrives for";
            this.rbModeLive.UseVisualStyleBackColor = true;
            this.rbModeLive.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbModeComplete
            // 
            this.rbModeComplete.AutoSize = true;
            this.rbModeComplete.Checked = true;
            this.rbModeComplete.Location = new System.Drawing.Point(2, 17);
            this.rbModeComplete.Margin = new System.Windows.Forms.Padding(2);
            this.rbModeComplete.Name = "rbModeComplete";
            this.rbModeComplete.Size = new System.Drawing.Size(157, 17);
            this.rbModeComplete.TabIndex = 0;
            this.rbModeComplete.TabStop = true;
            this.rbModeComplete.Text = "This is a complete recording";
            this.rbModeComplete.UseVisualStyleBackColor = true;
            this.rbModeComplete.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxSplitType
            // 
            this.groupBoxSplitType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxSplitType.Controls.Add(this.label45);
            this.groupBoxSplitType.Controls.Add(this.rbSplitGeneric);
            this.groupBoxSplitType.Controls.Add(this.rbSplitVideoTool);
            this.groupBoxSplitType.Controls.Add(this.rbSplitIndividual);
            this.groupBoxSplitType.Location = new System.Drawing.Point(0, 87);
            this.groupBoxSplitType.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSplitType.Name = "groupBoxSplitType";
            this.groupBoxSplitType.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSplitType.Size = new System.Drawing.Size(748, 128);
            this.groupBoxSplitType.TabIndex = 1;
            this.groupBoxSplitType.TabStop = false;
            this.groupBoxSplitType.Text = "Split type";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(4, 91);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(628, 13);
            this.label45.TabIndex = 3;
            this.label45.Text = "Some input types (MP4, hexadecimal dump and WTV) don\'t support cut files and each" +
    " file will be processed as a separate video file.";
            // 
            // rbSplitGeneric
            // 
            this.rbSplitGeneric.AutoSize = true;
            this.rbSplitGeneric.Location = new System.Drawing.Point(4, 61);
            this.rbSplitGeneric.Margin = new System.Windows.Forms.Padding(2);
            this.rbSplitGeneric.Name = "rbSplitGeneric";
            this.rbSplitGeneric.Size = new System.Drawing.Size(360, 17);
            this.rbSplitGeneric.TabIndex = 2;
            this.rbSplitGeneric.Text = "These files are part of the same video. They were cut by a generic tool.";
            this.rbSplitGeneric.UseVisualStyleBackColor = true;
            this.rbSplitGeneric.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbSplitVideoTool
            // 
            this.rbSplitVideoTool.AutoSize = true;
            this.rbSplitVideoTool.Location = new System.Drawing.Point(4, 39);
            this.rbSplitVideoTool.Margin = new System.Windows.Forms.Padding(2);
            this.rbSplitVideoTool.Name = "rbSplitVideoTool";
            this.rbSplitVideoTool.Size = new System.Drawing.Size(359, 17);
            this.rbSplitVideoTool.TabIndex = 1;
            this.rbSplitVideoTool.Text = "These files are part of the same video. They were cut with a video tool.";
            this.rbSplitVideoTool.UseVisualStyleBackColor = true;
            this.rbSplitVideoTool.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbSplitIndividual
            // 
            this.rbSplitIndividual.AutoSize = true;
            this.rbSplitIndividual.Checked = true;
            this.rbSplitIndividual.Location = new System.Drawing.Point(4, 17);
            this.rbSplitIndividual.Margin = new System.Windows.Forms.Padding(2);
            this.rbSplitIndividual.Name = "rbSplitIndividual";
            this.rbSplitIndividual.Size = new System.Drawing.Size(424, 17);
            this.rbSplitIndividual.TabIndex = 0;
            this.rbSplitIndividual.TabStop = true;
            this.rbSplitIndividual.Text = "These are individual, unrelated files. Produce an output subtitle file for each i" +
    "nput file.";
            this.rbSplitIndividual.UseVisualStyleBackColor = true;
            this.rbSplitIndividual.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxInputType
            // 
            this.groupBoxInputType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxInputType.Controls.Add(this.rbInputTypeM2TS);
            this.groupBoxInputType.Controls.Add(this.rbInputTypeWTV);
            this.groupBoxInputType.Controls.Add(this.rbInputTypeHexDump);
            this.groupBoxInputType.Controls.Add(this.rbInputTypeMP4);
            this.groupBoxInputType.Controls.Add(this.rbInputTypeBin);
            this.groupBoxInputType.Controls.Add(this.rbInputTypeMcPoodleRaw);
            this.groupBoxInputType.Controls.Add(this.rbInputTypeDVRMS);
            this.groupBoxInputType.Controls.Add(this.rbInputTypeElementaryStreams);
            this.groupBoxInputType.Controls.Add(this.rbInputTypeProgramStreams);
            this.groupBoxInputType.Controls.Add(this.rbInputTypeTransportStreams);
            this.groupBoxInputType.Controls.Add(this.rbInputTypeAutodetect);
            this.groupBoxInputType.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInputType.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInputType.Name = "groupBoxInputType";
            this.groupBoxInputType.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInputType.Size = new System.Drawing.Size(748, 87);
            this.groupBoxInputType.TabIndex = 0;
            this.groupBoxInputType.TabStop = false;
            this.groupBoxInputType.Text = "Input type";
            // 
            // rbInputTypeM2TS
            // 
            this.rbInputTypeM2TS.AutoSize = true;
            this.rbInputTypeM2TS.Location = new System.Drawing.Point(293, 60);
            this.rbInputTypeM2TS.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeM2TS.Name = "rbInputTypeM2TS";
            this.rbInputTypeM2TS.Size = new System.Drawing.Size(54, 17);
            this.rbInputTypeM2TS.TabIndex = 10;
            this.rbInputTypeM2TS.TabStop = true;
            this.rbInputTypeM2TS.Text = "M2TS";
            this.rbInputTypeM2TS.UseVisualStyleBackColor = true;
            this.rbInputTypeM2TS.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbInputTypeWTV
            // 
            this.rbInputTypeWTV.AutoSize = true;
            this.rbInputTypeWTV.Location = new System.Drawing.Point(170, 60);
            this.rbInputTypeWTV.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeWTV.Name = "rbInputTypeWTV";
            this.rbInputTypeWTV.Size = new System.Drawing.Size(96, 17);
            this.rbInputTypeWTV.TabIndex = 9;
            this.rbInputTypeWTV.TabStop = true;
            this.rbInputTypeWTV.Text = "Microsoft WTV";
            this.rbInputTypeWTV.UseVisualStyleBackColor = true;
            this.rbInputTypeWTV.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbInputTypeHexDump
            // 
            this.rbInputTypeHexDump.AutoSize = true;
            this.rbInputTypeHexDump.Location = new System.Drawing.Point(4, 60);
            this.rbInputTypeHexDump.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeHexDump.Name = "rbInputTypeHexDump";
            this.rbInputTypeHexDump.Size = new System.Drawing.Size(117, 17);
            this.rbInputTypeHexDump.TabIndex = 8;
            this.rbInputTypeHexDump.TabStop = true;
            this.rbInputTypeHexDump.Text = "Hexadecimal Dump";
            this.rbInputTypeHexDump.UseVisualStyleBackColor = true;
            this.rbInputTypeHexDump.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbInputTypeMP4
            // 
            this.rbInputTypeMP4.AutoSize = true;
            this.rbInputTypeMP4.Location = new System.Drawing.Point(416, 39);
            this.rbInputTypeMP4.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeMP4.Name = "rbInputTypeMP4";
            this.rbInputTypeMP4.Size = new System.Drawing.Size(47, 17);
            this.rbInputTypeMP4.TabIndex = 7;
            this.rbInputTypeMP4.TabStop = true;
            this.rbInputTypeMP4.Text = "MP4";
            this.rbInputTypeMP4.UseVisualStyleBackColor = true;
            this.rbInputTypeMP4.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbInputTypeBin
            // 
            this.rbInputTypeBin.AutoSize = true;
            this.rbInputTypeBin.Location = new System.Drawing.Point(416, 17);
            this.rbInputTypeBin.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeBin.Name = "rbInputTypeBin";
            this.rbInputTypeBin.Size = new System.Drawing.Size(114, 17);
            this.rbInputTypeBin.TabIndex = 3;
            this.rbInputTypeBin.Text = ".bin (CCExtractor\'s)";
            this.rbInputTypeBin.UseVisualStyleBackColor = true;
            // 
            // rbInputTypeMcPoodleRaw
            // 
            this.rbInputTypeMcPoodleRaw.AutoSize = true;
            this.rbInputTypeMcPoodleRaw.Location = new System.Drawing.Point(293, 39);
            this.rbInputTypeMcPoodleRaw.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeMcPoodleRaw.Name = "rbInputTypeMcPoodleRaw";
            this.rbInputTypeMcPoodleRaw.Size = new System.Drawing.Size(109, 17);
            this.rbInputTypeMcPoodleRaw.TabIndex = 6;
            this.rbInputTypeMcPoodleRaw.Text = ".raw (McPoodle\'s)";
            this.rbInputTypeMcPoodleRaw.UseVisualStyleBackColor = true;
            this.rbInputTypeMcPoodleRaw.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbInputTypeDVRMS
            // 
            this.rbInputTypeDVRMS.AutoSize = true;
            this.rbInputTypeDVRMS.Location = new System.Drawing.Point(293, 17);
            this.rbInputTypeDVRMS.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeDVRMS.Name = "rbInputTypeDVRMS";
            this.rbInputTypeDVRMS.Size = new System.Drawing.Size(67, 17);
            this.rbInputTypeDVRMS.TabIndex = 2;
            this.rbInputTypeDVRMS.Text = "DVR-MS";
            this.rbInputTypeDVRMS.UseVisualStyleBackColor = true;
            this.rbInputTypeDVRMS.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbInputTypeElementaryStreams
            // 
            this.rbInputTypeElementaryStreams.AutoSize = true;
            this.rbInputTypeElementaryStreams.Location = new System.Drawing.Point(170, 39);
            this.rbInputTypeElementaryStreams.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeElementaryStreams.Name = "rbInputTypeElementaryStreams";
            this.rbInputTypeElementaryStreams.Size = new System.Drawing.Size(113, 17);
            this.rbInputTypeElementaryStreams.TabIndex = 5;
            this.rbInputTypeElementaryStreams.Text = "Elementary Stream";
            this.rbInputTypeElementaryStreams.UseVisualStyleBackColor = true;
            this.rbInputTypeElementaryStreams.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbInputTypeProgramStreams
            // 
            this.rbInputTypeProgramStreams.AutoSize = true;
            this.rbInputTypeProgramStreams.Location = new System.Drawing.Point(170, 17);
            this.rbInputTypeProgramStreams.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeProgramStreams.Name = "rbInputTypeProgramStreams";
            this.rbInputTypeProgramStreams.Size = new System.Drawing.Size(105, 17);
            this.rbInputTypeProgramStreams.TabIndex = 1;
            this.rbInputTypeProgramStreams.Text = "Program Streams";
            this.rbInputTypeProgramStreams.UseVisualStyleBackColor = true;
            this.rbInputTypeProgramStreams.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbInputTypeTransportStreams
            // 
            this.rbInputTypeTransportStreams.AutoSize = true;
            this.rbInputTypeTransportStreams.Location = new System.Drawing.Point(4, 39);
            this.rbInputTypeTransportStreams.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeTransportStreams.Name = "rbInputTypeTransportStreams";
            this.rbInputTypeTransportStreams.Size = new System.Drawing.Size(106, 17);
            this.rbInputTypeTransportStreams.TabIndex = 4;
            this.rbInputTypeTransportStreams.Text = "Transport Stream";
            this.rbInputTypeTransportStreams.UseVisualStyleBackColor = true;
            this.rbInputTypeTransportStreams.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbInputTypeAutodetect
            // 
            this.rbInputTypeAutodetect.AutoSize = true;
            this.rbInputTypeAutodetect.Checked = true;
            this.rbInputTypeAutodetect.Location = new System.Drawing.Point(4, 17);
            this.rbInputTypeAutodetect.Margin = new System.Windows.Forms.Padding(2);
            this.rbInputTypeAutodetect.Name = "rbInputTypeAutodetect";
            this.rbInputTypeAutodetect.Size = new System.Drawing.Size(163, 17);
            this.rbInputTypeAutodetect.TabIndex = 0;
            this.rbInputTypeAutodetect.TabStop = true;
            this.rbInputTypeAutodetect.Text = "Autodetect the correct format";
            this.rbInputTypeAutodetect.UseVisualStyleBackColor = true;
            this.rbInputTypeAutodetect.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // tabPageAdvancedInputOptions
            // 
            this.tabPageAdvancedInputOptions.Controls.Add(this.groupBoxAdvancedInputClock);
            this.tabPageAdvancedInputOptions.Controls.Add(this.groupBoxMultiprogramTS);
            this.tabPageAdvancedInputOptions.Controls.Add(this.groupBoxAdvancedInputMisc);
            this.tabPageAdvancedInputOptions.Controls.Add(this.groupBoxMythTV);
            this.tabPageAdvancedInputOptions.Controls.Add(this.label2);
            this.tabPageAdvancedInputOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdvancedInputOptions.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdvancedInputOptions.Name = "tabPageAdvancedInputOptions";
            this.tabPageAdvancedInputOptions.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAdvancedInputOptions.Size = new System.Drawing.Size(746, 462);
            this.tabPageAdvancedInputOptions.TabIndex = 3;
            this.tabPageAdvancedInputOptions.Text = "Advanced input options";
            this.tabPageAdvancedInputOptions.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdvancedInputClock
            // 
            this.groupBoxAdvancedInputClock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxAdvancedInputClock.Controls.Add(this.label35);
            this.groupBoxAdvancedInputClock.Controls.Add(this.rbClockPTS);
            this.groupBoxAdvancedInputClock.Controls.Add(this.rbClockGOP);
            this.groupBoxAdvancedInputClock.Controls.Add(this.rbClockAuto);
            this.groupBoxAdvancedInputClock.Location = new System.Drawing.Point(0, 321);
            this.groupBoxAdvancedInputClock.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAdvancedInputClock.Name = "groupBoxAdvancedInputClock";
            this.groupBoxAdvancedInputClock.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAdvancedInputClock.Size = new System.Drawing.Size(752, 85);
            this.groupBoxAdvancedInputClock.TabIndex = 5;
            this.groupBoxAdvancedInputClock.TabStop = false;
            this.groupBoxAdvancedInputClock.Text = "Clock";
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(4, 37);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(738, 49);
            this.label35.TabIndex = 3;
            this.label35.Text = resources.GetString("label35.Text");
            // 
            // rbClockPTS
            // 
            this.rbClockPTS.AutoSize = true;
            this.rbClockPTS.Location = new System.Drawing.Point(146, 17);
            this.rbClockPTS.Margin = new System.Windows.Forms.Padding(2);
            this.rbClockPTS.Name = "rbClockPTS";
            this.rbClockPTS.Size = new System.Drawing.Size(46, 17);
            this.rbClockPTS.TabIndex = 2;
            this.rbClockPTS.Text = "PTS";
            this.rbClockPTS.UseVisualStyleBackColor = true;
            this.rbClockPTS.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbClockGOP
            // 
            this.rbClockGOP.AutoSize = true;
            this.rbClockGOP.Location = new System.Drawing.Point(70, 17);
            this.rbClockGOP.Margin = new System.Windows.Forms.Padding(2);
            this.rbClockGOP.Name = "rbClockGOP";
            this.rbClockGOP.Size = new System.Drawing.Size(48, 17);
            this.rbClockGOP.TabIndex = 1;
            this.rbClockGOP.Text = "GOP";
            this.rbClockGOP.UseVisualStyleBackColor = true;
            this.rbClockGOP.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbClockAuto
            // 
            this.rbClockAuto.AutoSize = true;
            this.rbClockAuto.Checked = true;
            this.rbClockAuto.Location = new System.Drawing.Point(7, 17);
            this.rbClockAuto.Margin = new System.Windows.Forms.Padding(2);
            this.rbClockAuto.Name = "rbClockAuto";
            this.rbClockAuto.Size = new System.Drawing.Size(47, 17);
            this.rbClockAuto.TabIndex = 0;
            this.rbClockAuto.TabStop = true;
            this.rbClockAuto.Text = "Auto";
            this.rbClockAuto.UseVisualStyleBackColor = true;
            this.rbClockAuto.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxMultiprogramTS
            // 
            this.groupBoxMultiprogramTS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxMultiprogramTS.Controls.Add(this.rbMultiProgramTSAutoDetect);
            this.groupBoxMultiprogramTS.Controls.Add(this.rbMultiProgramTSSelect);
            this.groupBoxMultiprogramTS.Controls.Add(this.tbProgramNumber);
            this.groupBoxMultiprogramTS.Location = new System.Drawing.Point(0, 406);
            this.groupBoxMultiprogramTS.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMultiprogramTS.Name = "groupBoxMultiprogramTS";
            this.groupBoxMultiprogramTS.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMultiprogramTS.Size = new System.Drawing.Size(748, 60);
            this.groupBoxMultiprogramTS.TabIndex = 4;
            this.groupBoxMultiprogramTS.TabStop = false;
            this.groupBoxMultiprogramTS.Text = "Multiprogram Transport Streams";
            this.groupBoxMultiprogramTS.Enter += new System.EventHandler(this.groupBoxMultiprogramTS_Enter);
            // 
            // rbMultiProgramTSAutoDetect
            // 
            this.rbMultiProgramTSAutoDetect.AutoSize = true;
            this.rbMultiProgramTSAutoDetect.Checked = true;
            this.rbMultiProgramTSAutoDetect.Location = new System.Drawing.Point(7, 40);
            this.rbMultiProgramTSAutoDetect.Margin = new System.Windows.Forms.Padding(2);
            this.rbMultiProgramTSAutoDetect.Name = "rbMultiProgramTSAutoDetect";
            this.rbMultiProgramTSAutoDetect.Size = new System.Drawing.Size(428, 17);
            this.rbMultiProgramTSAutoDetect.TabIndex = 3;
            this.rbMultiProgramTSAutoDetect.TabStop = true;
            this.rbMultiProgramTSAutoDetect.Text = "If the TS contains more than one program, select the first one found with suitabl" +
    "e data";
            this.rbMultiProgramTSAutoDetect.UseVisualStyleBackColor = true;
            this.rbMultiProgramTSAutoDetect.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbMultiProgramTSSelect
            // 
            this.rbMultiProgramTSSelect.AutoSize = true;
            this.rbMultiProgramTSSelect.Location = new System.Drawing.Point(7, 18);
            this.rbMultiProgramTSSelect.Margin = new System.Windows.Forms.Padding(2);
            this.rbMultiProgramTSSelect.Name = "rbMultiProgramTSSelect";
            this.rbMultiProgramTSSelect.Size = new System.Drawing.Size(335, 17);
            this.rbMultiProgramTSSelect.TabIndex = 2;
            this.rbMultiProgramTSSelect.Text = "File is known to contain more than one program. Process this one:";
            this.rbMultiProgramTSSelect.UseVisualStyleBackColor = true;
            this.rbMultiProgramTSSelect.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // tbProgramNumber
            // 
            this.tbProgramNumber.Location = new System.Drawing.Point(340, 17);
            this.tbProgramNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbProgramNumber.Name = "tbProgramNumber";
            this.tbProgramNumber.Size = new System.Drawing.Size(76, 20);
            this.tbProgramNumber.TabIndex = 1;
            this.tbProgramNumber.TextChanged += new System.EventHandler(this.tbProgramNumber_TextChanged);
            this.tbProgramNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProgramNumber_KeyPress);
            // 
            // groupBoxAdvancedInputMisc
            // 
            this.groupBoxAdvancedInputMisc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxAdvancedInputMisc.Controls.Add(this.cb_ignore_scte20);
            this.groupBoxAdvancedInputMisc.Controls.Add(this.cb_mp4vidtrack);
            this.groupBoxAdvancedInputMisc.Controls.Add(this.cb_use_pic_order_cnt);
            this.groupBoxAdvancedInputMisc.Controls.Add(this.cbHauppage);
            this.groupBoxAdvancedInputMisc.Controls.Add(this.cbWTVConversionFix);
            this.groupBoxAdvancedInputMisc.Controls.Add(this.cbLargeGOPs);
            this.groupBoxAdvancedInputMisc.Controls.Add(this.cbFixPadding);
            this.groupBoxAdvancedInputMisc.Controls.Add(this.cbClock90090);
            this.groupBoxAdvancedInputMisc.Location = new System.Drawing.Point(0, 126);
            this.groupBoxAdvancedInputMisc.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAdvancedInputMisc.Name = "groupBoxAdvancedInputMisc";
            this.groupBoxAdvancedInputMisc.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAdvancedInputMisc.Size = new System.Drawing.Size(748, 191);
            this.groupBoxAdvancedInputMisc.TabIndex = 3;
            this.groupBoxAdvancedInputMisc.TabStop = false;
            this.groupBoxAdvancedInputMisc.Text = "Miscellaneous options";
            // 
            // cb_ignore_scte20
            // 
            this.cb_ignore_scte20.AutoSize = true;
            this.cb_ignore_scte20.Location = new System.Drawing.Point(7, 168);
            this.cb_ignore_scte20.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ignore_scte20.Name = "cb_ignore_scte20";
            this.cb_ignore_scte20.Size = new System.Drawing.Size(126, 17);
            this.cb_ignore_scte20.TabIndex = 7;
            this.cb_ignore_scte20.Text = "Ignore SCTE-20 data";
            this.cb_ignore_scte20.UseVisualStyleBackColor = true;
            this.cb_ignore_scte20.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cb_mp4vidtrack
            // 
            this.cb_mp4vidtrack.AutoSize = true;
            this.cb_mp4vidtrack.Location = new System.Drawing.Point(7, 146);
            this.cb_mp4vidtrack.Margin = new System.Windows.Forms.Padding(2);
            this.cb_mp4vidtrack.Name = "cb_mp4vidtrack";
            this.cb_mp4vidtrack.Size = new System.Drawing.Size(405, 17);
            this.cb_mp4vidtrack.TabIndex = 6;
            this.cb_mp4vidtrack.Text = "In MP4, process video track even if a dedicated closed captions track is present";
            this.cb_mp4vidtrack.UseVisualStyleBackColor = true;
            this.cb_mp4vidtrack.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cb_use_pic_order_cnt
            // 
            this.cb_use_pic_order_cnt.AutoSize = true;
            this.cb_use_pic_order_cnt.Location = new System.Drawing.Point(7, 124);
            this.cb_use_pic_order_cnt.Margin = new System.Windows.Forms.Padding(2);
            this.cb_use_pic_order_cnt.Name = "cb_use_pic_order_cnt";
            this.cb_use_pic_order_cnt.Size = new System.Drawing.Size(410, 17);
            this.cb_use_pic_order_cnt.TabIndex = 5;
            this.cb_use_pic_order_cnt.Text = "Use the pic_order_cnt_lsb in AVC/H.264 data streams to order the CC information";
            this.cb_use_pic_order_cnt.UseVisualStyleBackColor = true;
            this.cb_use_pic_order_cnt.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbHauppage
            // 
            this.cbHauppage.AutoSize = true;
            this.cbHauppage.Location = new System.Drawing.Point(7, 102);
            this.cbHauppage.Margin = new System.Windows.Forms.Padding(2);
            this.cbHauppage.Name = "cbHauppage";
            this.cbHauppage.Size = new System.Drawing.Size(494, 17);
            this.cbHauppage.TabIndex = 4;
            this.cbHauppage.Text = "File was captured with a Hauppage card (try to extract captions in Hauppage\'s pro" +
    "pietary encoding)";
            this.cbHauppage.UseVisualStyleBackColor = true;
            this.cbHauppage.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbWTVConversionFix
            // 
            this.cbWTVConversionFix.AutoSize = true;
            this.cbWTVConversionFix.Location = new System.Drawing.Point(7, 80);
            this.cbWTVConversionFix.Margin = new System.Windows.Forms.Padding(2);
            this.cbWTVConversionFix.Name = "cbWTVConversionFix";
            this.cbWTVConversionFix.Size = new System.Drawing.Size(526, 17);
            this.cbWTVConversionFix.TabIndex = 3;
            this.cbWTVConversionFix.Text = "Input file was originally a WTV file that has been converted to DVR-MS and CCExtr" +
    "actor finds no captions.";
            this.cbWTVConversionFix.UseVisualStyleBackColor = true;
            this.cbWTVConversionFix.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbLargeGOPs
            // 
            this.cbLargeGOPs.AutoSize = true;
            this.cbLargeGOPs.Location = new System.Drawing.Point(7, 59);
            this.cbLargeGOPs.Margin = new System.Windows.Forms.Padding(2);
            this.cbLargeGOPs.Name = "cbLargeGOPs";
            this.cbLargeGOPs.Size = new System.Drawing.Size(354, 17);
            this.cbLargeGOPs.TabIndex = 2;
            this.cbLargeGOPs.Text = "This recording has very large GOPs, don\'t discard GOP timing anyway";
            this.cbLargeGOPs.UseVisualStyleBackColor = true;
            this.cbLargeGOPs.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbFixPadding
            // 
            this.cbFixPadding.AutoSize = true;
            this.cbFixPadding.Location = new System.Drawing.Point(7, 39);
            this.cbFixPadding.Margin = new System.Windows.Forms.Padding(2);
            this.cbFixPadding.Name = "cbFixPadding";
            this.cbFixPadding.Size = new System.Drawing.Size(351, 17);
            this.cbFixPadding.TabIndex = 1;
            this.cbFixPadding.Text = "Fix incorrect padding data (by replacing 00 with 80 where appropiate)";
            this.cbFixPadding.UseVisualStyleBackColor = true;
            this.cbFixPadding.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbClock90090
            // 
            this.cbClock90090.AutoSize = true;
            this.cbClock90090.Location = new System.Drawing.Point(7, 17);
            this.cbClock90090.Margin = new System.Windows.Forms.Padding(2);
            this.cbClock90090.Name = "cbClock90090";
            this.cbClock90090.Size = new System.Drawing.Size(379, 17);
            this.cbClock90090.TabIndex = 0;
            this.cbClock90090.Text = "Use a clock frequency of 90090 instead of 90000 (needed for some DVDs)";
            this.cbClock90090.UseVisualStyleBackColor = true;
            this.cbClock90090.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxMythTV
            // 
            this.groupBoxMythTV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxMythTV.Controls.Add(this.rbMythTVAuto);
            this.groupBoxMythTV.Controls.Add(this.rbMythTVDisabled);
            this.groupBoxMythTV.Controls.Add(this.rbMythTVForced);
            this.groupBoxMythTV.Location = new System.Drawing.Point(0, 44);
            this.groupBoxMythTV.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMythTV.Name = "groupBoxMythTV";
            this.groupBoxMythTV.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMythTV.Size = new System.Drawing.Size(748, 81);
            this.groupBoxMythTV.TabIndex = 2;
            this.groupBoxMythTV.TabStop = false;
            this.groupBoxMythTV.Text = "MythTV";
            // 
            // rbMythTVAuto
            // 
            this.rbMythTVAuto.AutoSize = true;
            this.rbMythTVAuto.Checked = true;
            this.rbMythTVAuto.Location = new System.Drawing.Point(4, 59);
            this.rbMythTVAuto.Margin = new System.Windows.Forms.Padding(2);
            this.rbMythTVAuto.Name = "rbMythTVAuto";
            this.rbMythTVAuto.Size = new System.Drawing.Size(292, 17);
            this.rbMythTVAuto.TabIndex = 2;
            this.rbMythTVAuto.TabStop = true;
            this.rbMythTVAuto.Text = "Autodetect this and use MyTV\'s code only when needed";
            this.rbMythTVAuto.UseVisualStyleBackColor = true;
            this.rbMythTVAuto.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbMythTVDisabled
            // 
            this.rbMythTVDisabled.AutoSize = true;
            this.rbMythTVDisabled.Location = new System.Drawing.Point(4, 39);
            this.rbMythTVDisabled.Margin = new System.Windows.Forms.Padding(2);
            this.rbMythTVDisabled.Name = "rbMythTVDisabled";
            this.rbMythTVDisabled.Size = new System.Drawing.Size(258, 17);
            this.rbMythTVDisabled.TabIndex = 1;
            this.rbMythTVDisabled.Text = "Do not use MyTV\'s code even if there is VBI data";
            this.rbMythTVDisabled.UseVisualStyleBackColor = true;
            this.rbMythTVDisabled.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbMythTVForced
            // 
            this.rbMythTVForced.AutoSize = true;
            this.rbMythTVForced.Location = new System.Drawing.Point(4, 17);
            this.rbMythTVForced.Margin = new System.Windows.Forms.Padding(2);
            this.rbMythTVForced.Name = "rbMythTVForced";
            this.rbMythTVForced.Size = new System.Drawing.Size(442, 17);
            this.rbMythTVForced.TabIndex = 0;
            this.rbMythTVForced.Text = "This recording have the closed captions in the VBI data, so use MythTV\'s code to " +
    "read it";
            this.rbMythTVForced.UseVisualStyleBackColor = true;
            this.rbMythTVForced.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(740, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Note: While you can\'t break anything (other than the output subtitles) by playing" +
    " with these options, they are usually not needed.";
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.groupBoxXDS);
            this.tabPageOutput.Controls.Add(this.bgBOM);
            this.tabPageOutput.Controls.Add(this.groupBoxTimeAdjust);
            this.tabPageOutput.Controls.Add(this.groupBoxOutputFile);
            this.tabPageOutput.Controls.Add(this.groupBoxOutputType);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageOutput.Size = new System.Drawing.Size(746, 462);
            this.tabPageOutput.TabIndex = 1;
            this.tabPageOutput.Text = "Output (1)";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // groupBoxXDS
            // 
            this.groupBoxXDS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxXDS.Controls.Add(this.cbExportXDS);
            this.groupBoxXDS.Location = new System.Drawing.Point(1, 193);
            this.groupBoxXDS.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxXDS.Name = "groupBoxXDS";
            this.groupBoxXDS.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxXDS.Size = new System.Drawing.Size(748, 54);
            this.groupBoxXDS.TabIndex = 5;
            this.groupBoxXDS.TabStop = false;
            this.groupBoxXDS.Text = "XDS";
            // 
            // cbExportXDS
            // 
            this.cbExportXDS.AutoSize = true;
            this.cbExportXDS.Location = new System.Drawing.Point(4, 17);
            this.cbExportXDS.Margin = new System.Windows.Forms.Padding(2);
            this.cbExportXDS.Name = "cbExportXDS";
            this.cbExportXDS.Size = new System.Drawing.Size(388, 17);
            this.cbExportXDS.TabIndex = 0;
            this.cbExportXDS.Text = "Export XDS information if the output format allows it (currently only transcripts" +
    ")";
            this.cbExportXDS.UseVisualStyleBackColor = true;
            this.cbExportXDS.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // bgBOM
            // 
            this.bgBOM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bgBOM.Controls.Add(this.rbBOMNo);
            this.bgBOM.Controls.Add(this.rbBOMYes);
            this.bgBOM.Location = new System.Drawing.Point(0, 346);
            this.bgBOM.Margin = new System.Windows.Forms.Padding(2);
            this.bgBOM.Name = "bgBOM";
            this.bgBOM.Padding = new System.Windows.Forms.Padding(2);
            this.bgBOM.Size = new System.Drawing.Size(748, 46);
            this.bgBOM.TabIndex = 4;
            this.bgBOM.TabStop = false;
            this.bgBOM.Text = "Byte Order Mark (BOM)";
            // 
            // rbBOMNo
            // 
            this.rbBOMNo.AutoSize = true;
            this.rbBOMNo.Location = new System.Drawing.Point(324, 17);
            this.rbBOMNo.Margin = new System.Windows.Forms.Padding(2);
            this.rbBOMNo.Name = "rbBOMNo";
            this.rbBOMNo.Size = new System.Drawing.Size(317, 17);
            this.rbBOMNo.TabIndex = 1;
            this.rbBOMNo.Text = "Don\'t add BOM in UTF files (often required by UNIX programs)";
            this.rbBOMNo.UseVisualStyleBackColor = true;
            this.rbBOMNo.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbBOMYes
            // 
            this.rbBOMYes.AutoSize = true;
            this.rbBOMYes.Checked = true;
            this.rbBOMYes.Location = new System.Drawing.Point(7, 17);
            this.rbBOMYes.Margin = new System.Windows.Forms.Padding(2);
            this.rbBOMYes.Name = "rbBOMYes";
            this.rbBOMYes.Size = new System.Drawing.Size(308, 17);
            this.rbBOMYes.TabIndex = 0;
            this.rbBOMYes.TabStop = true;
            this.rbBOMYes.Text = "Add BOM in UTF files (often required by Windows programs)";
            this.rbBOMYes.UseVisualStyleBackColor = true;
            this.rbBOMYes.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxTimeAdjust
            // 
            this.groupBoxTimeAdjust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxTimeAdjust.Controls.Add(this.label7);
            this.groupBoxTimeAdjust.Controls.Add(this.upDwnDelay);
            this.groupBoxTimeAdjust.Location = new System.Drawing.Point(0, 392);
            this.groupBoxTimeAdjust.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTimeAdjust.Name = "groupBoxTimeAdjust";
            this.groupBoxTimeAdjust.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTimeAdjust.Size = new System.Drawing.Size(748, 49);
            this.groupBoxTimeAdjust.TabIndex = 3;
            this.groupBoxTimeAdjust.TabStop = false;
            this.groupBoxTimeAdjust.Text = "Time adjust";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(445, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Delay subtitles this number of milliseconds (use negative values to make them app" +
    "ear sooner)";
            // 
            // upDwnDelay
            // 
            this.upDwnDelay.Location = new System.Drawing.Point(7, 17);
            this.upDwnDelay.Margin = new System.Windows.Forms.Padding(2);
            this.upDwnDelay.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.upDwnDelay.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.upDwnDelay.Name = "upDwnDelay";
            this.upDwnDelay.Size = new System.Drawing.Size(50, 20);
            this.upDwnDelay.TabIndex = 0;
            this.upDwnDelay.ValueChanged += new System.EventHandler(this.upDwnDelay_ValueChanged);
            // 
            // groupBoxOutputFile
            // 
            this.groupBoxOutputFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxOutputFile.Controls.Add(this.label4);
            this.groupBoxOutputFile.Controls.Add(this.btnBrowseOutputFilename);
            this.groupBoxOutputFile.Controls.Add(this.tbOutputFilename);
            this.groupBoxOutputFile.Controls.Add(this.rbOutputNameManual);
            this.groupBoxOutputFile.Controls.Add(this.rbOutputNameAuto);
            this.groupBoxOutputFile.Location = new System.Drawing.Point(0, 247);
            this.groupBoxOutputFile.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOutputFile.Name = "groupBoxOutputFile";
            this.groupBoxOutputFile.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOutputFile.Size = new System.Drawing.Size(748, 99);
            this.groupBoxOutputFile.TabIndex = 2;
            this.groupBoxOutputFile.TabStop = false;
            this.groupBoxOutputFile.Text = "Output file";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(61, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(569, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Note: When producing more than one file (i.e. when extracting the data from more " +
    "than one service or language),  a numeric suffix will be appended to the file.";
            // 
            // btnBrowseOutputFilename
            // 
            this.btnBrowseOutputFilename.Location = new System.Drawing.Point(438, 39);
            this.btnBrowseOutputFilename.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseOutputFilename.Name = "btnBrowseOutputFilename";
            this.btnBrowseOutputFilename.Size = new System.Drawing.Size(56, 21);
            this.btnBrowseOutputFilename.TabIndex = 3;
            this.btnBrowseOutputFilename.Text = "Browse";
            this.btnBrowseOutputFilename.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFilename.Click += new System.EventHandler(this.btnBrowseOutputFilename_Click);
            // 
            // tbOutputFilename
            // 
            this.tbOutputFilename.Location = new System.Drawing.Point(150, 39);
            this.tbOutputFilename.Margin = new System.Windows.Forms.Padding(2);
            this.tbOutputFilename.Name = "tbOutputFilename";
            this.tbOutputFilename.Size = new System.Drawing.Size(266, 20);
            this.tbOutputFilename.TabIndex = 2;
            this.tbOutputFilename.TextChanged += new System.EventHandler(this.tbOutputFilename_TextChanged);
            // 
            // rbOutputNameManual
            // 
            this.rbOutputNameManual.AutoSize = true;
            this.rbOutputNameManual.Location = new System.Drawing.Point(4, 39);
            this.rbOutputNameManual.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputNameManual.Name = "rbOutputNameManual";
            this.rbOutputNameManual.Size = new System.Drawing.Size(144, 17);
            this.rbOutputNameManual.TabIndex = 1;
            this.rbOutputNameManual.Text = "Save the ouput in this file";
            this.rbOutputNameManual.UseVisualStyleBackColor = true;
            this.rbOutputNameManual.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputNameAuto
            // 
            this.rbOutputNameAuto.AutoSize = true;
            this.rbOutputNameAuto.Checked = true;
            this.rbOutputNameAuto.Location = new System.Drawing.Point(4, 17);
            this.rbOutputNameAuto.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputNameAuto.Name = "rbOutputNameAuto";
            this.rbOutputNameAuto.Size = new System.Drawing.Size(405, 17);
            this.rbOutputNameAuto.TabIndex = 0;
            this.rbOutputNameAuto.TabStop = true;
            this.rbOutputNameAuto.Text = "Use the same name as the input file, replacing the extension with the correct one" +
    "";
            this.rbOutputNameAuto.UseVisualStyleBackColor = true;
            this.rbOutputNameAuto.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxOutputType
            // 
            this.groupBoxOutputType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeG608);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeSimpleXML);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeReport);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeSpuPNG);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeTTML);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeNull);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeTimedTXT);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeBin);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeDVDRaw);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeRaw);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeTXT);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeSAMI);
            this.groupBoxOutputType.Controls.Add(this.rbOutputTypeSRT);
            this.groupBoxOutputType.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputType.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOutputType.Name = "groupBoxOutputType";
            this.groupBoxOutputType.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOutputType.Size = new System.Drawing.Size(748, 193);
            this.groupBoxOutputType.TabIndex = 1;
            this.groupBoxOutputType.TabStop = false;
            this.groupBoxOutputType.Text = "Output type";
            // 
            // rbOutputTypeG608
            // 
            this.rbOutputTypeG608.AutoSize = true;
            this.rbOutputTypeG608.Location = new System.Drawing.Point(7, 148);
            this.rbOutputTypeG608.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeG608.Name = "rbOutputTypeG608";
            this.rbOutputTypeG608.Size = new System.Drawing.Size(99, 17);
            this.rbOutputTypeG608.TabIndex = 12;
            this.rbOutputTypeG608.TabStop = true;
            this.rbOutputTypeG608.Text = ".g608 (608 grid)";
            this.rbOutputTypeG608.UseVisualStyleBackColor = true;
            this.rbOutputTypeG608.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeSimpleXML
            // 
            this.rbOutputTypeSimpleXML.AutoSize = true;
            this.rbOutputTypeSimpleXML.Location = new System.Drawing.Point(324, 104);
            this.rbOutputTypeSimpleXML.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeSimpleXML.Name = "rbOutputTypeSimpleXML";
            this.rbOutputTypeSimpleXML.Size = new System.Drawing.Size(78, 17);
            this.rbOutputTypeSimpleXML.TabIndex = 9;
            this.rbOutputTypeSimpleXML.TabStop = true;
            this.rbOutputTypeSimpleXML.Text = "SimpleXML";
            this.rbOutputTypeSimpleXML.UseVisualStyleBackColor = true;
            this.rbOutputTypeSimpleXML.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeReport
            // 
            this.rbOutputTypeReport.AutoSize = true;
            this.rbOutputTypeReport.Location = new System.Drawing.Point(324, 126);
            this.rbOutputTypeReport.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeReport.Name = "rbOutputTypeReport";
            this.rbOutputTypeReport.Size = new System.Drawing.Size(111, 17);
            this.rbOutputTypeReport.TabIndex = 11;
            this.rbOutputTypeReport.TabStop = true;
            this.rbOutputTypeReport.Text = "File analysis report";
            this.rbOutputTypeReport.UseVisualStyleBackColor = true;
            this.rbOutputTypeReport.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeSpuPNG
            // 
            this.rbOutputTypeSpuPNG.AutoSize = true;
            this.rbOutputTypeSpuPNG.Location = new System.Drawing.Point(324, 82);
            this.rbOutputTypeSpuPNG.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeSpuPNG.Name = "rbOutputTypeSpuPNG";
            this.rbOutputTypeSpuPNG.Size = new System.Drawing.Size(60, 17);
            this.rbOutputTypeSpuPNG.TabIndex = 7;
            this.rbOutputTypeSpuPNG.TabStop = true;
            this.rbOutputTypeSpuPNG.Text = "spupng";
            this.rbOutputTypeSpuPNG.UseVisualStyleBackColor = true;
            this.rbOutputTypeSpuPNG.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeTTML
            // 
            this.rbOutputTypeTTML.AutoSize = true;
            this.rbOutputTypeTTML.Location = new System.Drawing.Point(4, 104);
            this.rbOutputTypeTTML.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeTTML.Name = "rbOutputTypeTTML";
            this.rbOutputTypeTTML.Size = new System.Drawing.Size(211, 17);
            this.rbOutputTypeTTML.TabIndex = 8;
            this.rbOutputTypeTTML.TabStop = true;
            this.rbOutputTypeTTML.Text = ".ttml (SMPTE Timed Text - W3C TTML)";
            this.rbOutputTypeTTML.UseVisualStyleBackColor = true;
            this.rbOutputTypeTTML.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeNull
            // 
            this.rbOutputTypeNull.AutoSize = true;
            this.rbOutputTypeNull.Location = new System.Drawing.Point(6, 126);
            this.rbOutputTypeNull.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeNull.Name = "rbOutputTypeNull";
            this.rbOutputTypeNull.Size = new System.Drawing.Size(156, 17);
            this.rbOutputTypeNull.TabIndex = 10;
            this.rbOutputTypeNull.TabStop = true;
            this.rbOutputTypeNull.Text = "Null (don\'t generate any file)";
            this.rbOutputTypeNull.UseVisualStyleBackColor = true;
            this.rbOutputTypeNull.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeTimedTXT
            // 
            this.rbOutputTypeTimedTXT.AutoSize = true;
            this.rbOutputTypeTimedTXT.Location = new System.Drawing.Point(4, 82);
            this.rbOutputTypeTimedTXT.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeTimedTXT.Name = "rbOutputTypeTimedTXT";
            this.rbOutputTypeTimedTXT.Size = new System.Drawing.Size(130, 17);
            this.rbOutputTypeTimedTXT.TabIndex = 6;
            this.rbOutputTypeTimedTXT.TabStop = true;
            this.rbOutputTypeTimedTXT.Text = ".ttxt (Timed Transcript)";
            this.rbOutputTypeTimedTXT.UseVisualStyleBackColor = true;
            this.rbOutputTypeTimedTXT.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeBin
            // 
            this.rbOutputTypeBin.AutoSize = true;
            this.rbOutputTypeBin.Location = new System.Drawing.Point(324, 61);
            this.rbOutputTypeBin.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeBin.Name = "rbOutputTypeBin";
            this.rbOutputTypeBin.Size = new System.Drawing.Size(198, 17);
            this.rbOutputTypeBin.TabIndex = 5;
            this.rbOutputTypeBin.Text = ".bin (CC data in CCExtractor\'s format)";
            this.rbOutputTypeBin.UseVisualStyleBackColor = true;
            this.rbOutputTypeBin.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeDVDRaw
            // 
            this.rbOutputTypeDVDRaw.AutoSize = true;
            this.rbOutputTypeDVDRaw.Location = new System.Drawing.Point(324, 39);
            this.rbOutputTypeDVDRaw.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeDVDRaw.Name = "rbOutputTypeDVDRaw";
            this.rbOutputTypeDVDRaw.Size = new System.Drawing.Size(237, 17);
            this.rbOutputTypeDVDRaw.TabIndex = 3;
            this.rbOutputTypeDVDRaw.Text = ".dvdraw (CC data in McPoodle\'s DVD format)";
            this.rbOutputTypeDVDRaw.UseVisualStyleBackColor = true;
            this.rbOutputTypeDVDRaw.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeRaw
            // 
            this.rbOutputTypeRaw.AutoSize = true;
            this.rbOutputTypeRaw.Location = new System.Drawing.Point(324, 17);
            this.rbOutputTypeRaw.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeRaw.Name = "rbOutputTypeRaw";
            this.rbOutputTypeRaw.Size = new System.Drawing.Size(243, 17);
            this.rbOutputTypeRaw.TabIndex = 1;
            this.rbOutputTypeRaw.Text = ".raw (CC data in McPoodle\'s broadcast format)";
            this.rbOutputTypeRaw.UseVisualStyleBackColor = true;
            this.rbOutputTypeRaw.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeTXT
            // 
            this.rbOutputTypeTXT.AutoSize = true;
            this.rbOutputTypeTXT.Location = new System.Drawing.Point(4, 61);
            this.rbOutputTypeTXT.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeTXT.Name = "rbOutputTypeTXT";
            this.rbOutputTypeTXT.Size = new System.Drawing.Size(143, 17);
            this.rbOutputTypeTXT.TabIndex = 4;
            this.rbOutputTypeTXT.Text = ".txt (Transcript, no timing)";
            this.rbOutputTypeTXT.UseVisualStyleBackColor = true;
            this.rbOutputTypeTXT.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeSAMI
            // 
            this.rbOutputTypeSAMI.AutoSize = true;
            this.rbOutputTypeSAMI.Location = new System.Drawing.Point(4, 39);
            this.rbOutputTypeSAMI.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeSAMI.Name = "rbOutputTypeSAMI";
            this.rbOutputTypeSAMI.Size = new System.Drawing.Size(314, 17);
            this.rbOutputTypeSAMI.TabIndex = 2;
            this.rbOutputTypeSAMI.Text = ".sami (Microsoft Synchronized Accessible Media Interchange)";
            this.rbOutputTypeSAMI.UseVisualStyleBackColor = true;
            this.rbOutputTypeSAMI.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbOutputTypeSRT
            // 
            this.rbOutputTypeSRT.AutoSize = true;
            this.rbOutputTypeSRT.Checked = true;
            this.rbOutputTypeSRT.Location = new System.Drawing.Point(4, 17);
            this.rbOutputTypeSRT.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutputTypeSRT.Name = "rbOutputTypeSRT";
            this.rbOutputTypeSRT.Size = new System.Drawing.Size(83, 17);
            this.rbOutputTypeSRT.TabIndex = 0;
            this.rbOutputTypeSRT.TabStop = true;
            this.rbOutputTypeSRT.Text = ".srt (SubRip)";
            this.rbOutputTypeSRT.UseVisualStyleBackColor = true;
            this.rbOutputTypeSRT.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // tabPageOutput2
            // 
            this.tabPageOutput2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageOutput2.Controls.Add(this.groupBoxLineTerminator);
            this.tabPageOutput2.Controls.Add(this.groupBoxExportTypeset);
            this.tabPageOutput2.Controls.Add(this.groupBoxRollup);
            this.tabPageOutput2.Controls.Add(this.groupBoxSentenceCase);
            this.tabPageOutput2.Controls.Add(this.groupBoxTextPosition);
            this.tabPageOutput2.Controls.Add(this.groupBoxColors);
            this.tabPageOutput2.Controls.Add(this.groupBoxEncoding);
            this.tabPageOutput2.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageOutput2.Name = "tabPageOutput2";
            this.tabPageOutput2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageOutput2.Size = new System.Drawing.Size(746, 462);
            this.tabPageOutput2.TabIndex = 5;
            this.tabPageOutput2.Text = "Output (2)";
            this.tabPageOutput2.UseVisualStyleBackColor = true;
            // 
            // groupBoxLineTerminator
            // 
            this.groupBoxLineTerminator.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxLineTerminator.Controls.Add(this.rbLineTerminatorUNIX);
            this.groupBoxLineTerminator.Controls.Add(this.rbLineTerminatorDOS);
            this.groupBoxLineTerminator.Location = new System.Drawing.Point(374, 389);
            this.groupBoxLineTerminator.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxLineTerminator.Name = "groupBoxLineTerminator";
            this.groupBoxLineTerminator.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxLineTerminator.Size = new System.Drawing.Size(374, 67);
            this.groupBoxLineTerminator.TabIndex = 6;
            this.groupBoxLineTerminator.TabStop = false;
            this.groupBoxLineTerminator.Text = "Line terminators";
            // 
            // rbLineTerminatorUNIX
            // 
            this.rbLineTerminatorUNIX.AutoSize = true;
            this.rbLineTerminatorUNIX.Location = new System.Drawing.Point(7, 39);
            this.rbLineTerminatorUNIX.Margin = new System.Windows.Forms.Padding(2);
            this.rbLineTerminatorUNIX.Name = "rbLineTerminatorUNIX";
            this.rbLineTerminatorUNIX.Size = new System.Drawing.Size(72, 17);
            this.rbLineTerminatorUNIX.TabIndex = 1;
            this.rbLineTerminatorUNIX.Text = "UNIX (LF)";
            this.rbLineTerminatorUNIX.UseVisualStyleBackColor = true;
            this.rbLineTerminatorUNIX.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbLineTerminatorDOS
            // 
            this.rbLineTerminatorDOS.AutoSize = true;
            this.rbLineTerminatorDOS.Checked = true;
            this.rbLineTerminatorDOS.Location = new System.Drawing.Point(7, 17);
            this.rbLineTerminatorDOS.Margin = new System.Windows.Forms.Padding(2);
            this.rbLineTerminatorDOS.Name = "rbLineTerminatorDOS";
            this.rbLineTerminatorDOS.Size = new System.Drawing.Size(133, 17);
            this.rbLineTerminatorDOS.TabIndex = 0;
            this.rbLineTerminatorDOS.TabStop = true;
            this.rbLineTerminatorDOS.Text = "DOS/Windows (CRLF)";
            this.rbLineTerminatorDOS.UseVisualStyleBackColor = true;
            this.rbLineTerminatorDOS.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxExportTypeset
            // 
            this.groupBoxExportTypeset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxExportTypeset.Controls.Add(this.rbDontExportTypesetting);
            this.groupBoxExportTypeset.Controls.Add(this.rbExportTypesetting);
            this.groupBoxExportTypeset.Location = new System.Drawing.Point(0, 389);
            this.groupBoxExportTypeset.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxExportTypeset.Name = "groupBoxExportTypeset";
            this.groupBoxExportTypeset.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxExportTypeset.Size = new System.Drawing.Size(374, 67);
            this.groupBoxExportTypeset.TabIndex = 5;
            this.groupBoxExportTypeset.TabStop = false;
            this.groupBoxExportTypeset.Text = "Typesetting";
            // 
            // rbDontExportTypesetting
            // 
            this.rbDontExportTypesetting.AutoSize = true;
            this.rbDontExportTypesetting.Location = new System.Drawing.Point(7, 39);
            this.rbDontExportTypesetting.Margin = new System.Windows.Forms.Padding(2);
            this.rbDontExportTypesetting.Name = "rbDontExportTypesetting";
            this.rbDontExportTypesetting.Size = new System.Drawing.Size(171, 17);
            this.rbDontExportTypesetting.TabIndex = 1;
            this.rbDontExportTypesetting.Text = "Do not export typesettings tags";
            this.rbDontExportTypesetting.UseVisualStyleBackColor = true;
            this.rbDontExportTypesetting.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbExportTypesetting
            // 
            this.rbExportTypesetting.AutoSize = true;
            this.rbExportTypesetting.Checked = true;
            this.rbExportTypesetting.Location = new System.Drawing.Point(7, 17);
            this.rbExportTypesetting.Margin = new System.Windows.Forms.Padding(2);
            this.rbExportTypesetting.Name = "rbExportTypesetting";
            this.rbExportTypesetting.Size = new System.Drawing.Size(226, 17);
            this.rbExportTypesetting.TabIndex = 0;
            this.rbExportTypesetting.TabStop = true;
            this.rbExportTypesetting.Text = "Export typesetting tags (for italics and bold)";
            this.rbExportTypesetting.UseVisualStyleBackColor = true;
            this.rbExportTypesetting.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxRollup
            // 
            this.groupBoxRollup.Controls.Add(this.rbRollUpLinesLimit1);
            this.groupBoxRollup.Controls.Add(this.rbRollUpLinesLimit2);
            this.groupBoxRollup.Controls.Add(this.rbRollUpLinesLimit3);
            this.groupBoxRollup.Controls.Add(this.rbRollUpLinesLimitNone);
            this.groupBoxRollup.Controls.Add(this.label48);
            this.groupBoxRollup.Controls.Add(this.cbRollupNoDupeLines);
            this.groupBoxRollup.Controls.Add(this.cbRollupRealtime);
            this.groupBoxRollup.Location = new System.Drawing.Point(0, 266);
            this.groupBoxRollup.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRollup.Name = "groupBoxRollup";
            this.groupBoxRollup.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRollup.Size = new System.Drawing.Size(748, 124);
            this.groupBoxRollup.TabIndex = 4;
            this.groupBoxRollup.TabStop = false;
            this.groupBoxRollup.Text = "Roll-Up";
            // 
            // rbRollUpLinesLimit1
            // 
            this.rbRollUpLinesLimit1.AutoSize = true;
            this.rbRollUpLinesLimit1.Location = new System.Drawing.Point(525, 85);
            this.rbRollUpLinesLimit1.Margin = new System.Windows.Forms.Padding(2);
            this.rbRollUpLinesLimit1.Name = "rbRollUpLinesLimit1";
            this.rbRollUpLinesLimit1.Size = new System.Drawing.Size(50, 17);
            this.rbRollUpLinesLimit1.TabIndex = 6;
            this.rbRollUpLinesLimit1.TabStop = true;
            this.rbRollUpLinesLimit1.Text = "1 line";
            this.rbRollUpLinesLimit1.UseVisualStyleBackColor = true;
            this.rbRollUpLinesLimit1.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbRollUpLinesLimit2
            // 
            this.rbRollUpLinesLimit2.AutoSize = true;
            this.rbRollUpLinesLimit2.Location = new System.Drawing.Point(468, 85);
            this.rbRollUpLinesLimit2.Margin = new System.Windows.Forms.Padding(2);
            this.rbRollUpLinesLimit2.Name = "rbRollUpLinesLimit2";
            this.rbRollUpLinesLimit2.Size = new System.Drawing.Size(55, 17);
            this.rbRollUpLinesLimit2.TabIndex = 5;
            this.rbRollUpLinesLimit2.Text = "2 lines";
            this.rbRollUpLinesLimit2.UseVisualStyleBackColor = true;
            this.rbRollUpLinesLimit2.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbRollUpLinesLimit3
            // 
            this.rbRollUpLinesLimit3.AutoSize = true;
            this.rbRollUpLinesLimit3.Location = new System.Drawing.Point(411, 85);
            this.rbRollUpLinesLimit3.Margin = new System.Windows.Forms.Padding(2);
            this.rbRollUpLinesLimit3.Name = "rbRollUpLinesLimit3";
            this.rbRollUpLinesLimit3.Size = new System.Drawing.Size(55, 17);
            this.rbRollUpLinesLimit3.TabIndex = 4;
            this.rbRollUpLinesLimit3.Text = "3 lines";
            this.rbRollUpLinesLimit3.UseVisualStyleBackColor = true;
            this.rbRollUpLinesLimit3.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbRollUpLinesLimitNone
            // 
            this.rbRollUpLinesLimitNone.AutoSize = true;
            this.rbRollUpLinesLimitNone.Checked = true;
            this.rbRollUpLinesLimitNone.Location = new System.Drawing.Point(226, 85);
            this.rbRollUpLinesLimitNone.Margin = new System.Windows.Forms.Padding(2);
            this.rbRollUpLinesLimitNone.Name = "rbRollUpLinesLimitNone";
            this.rbRollUpLinesLimitNone.Size = new System.Drawing.Size(181, 17);
            this.rbRollUpLinesLimitNone.TabIndex = 3;
            this.rbRollUpLinesLimitNone.TabStop = true;
            this.rbRollUpLinesLimitNone.Text = "No limit (as defined by broadcast)";
            this.rbRollUpLinesLimitNone.UseVisualStyleBackColor = true;
            this.rbRollUpLinesLimitNone.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(19, 87);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(200, 13);
            this.label48.TabIndex = 2;
            this.label48.Text = "Bypass number of visible lines and limit to";
            // 
            // cbRollupNoDupeLines
            // 
            this.cbRollupNoDupeLines.Location = new System.Drawing.Point(4, 51);
            this.cbRollupNoDupeLines.Margin = new System.Windows.Forms.Padding(2);
            this.cbRollupNoDupeLines.Name = "cbRollupNoDupeLines";
            this.cbRollupNoDupeLines.Size = new System.Drawing.Size(568, 34);
            this.cbRollupNoDupeLines.TabIndex = 1;
            this.cbRollupNoDupeLines.Text = resources.GetString("cbRollupNoDupeLines.Text");
            this.cbRollupNoDupeLines.UseVisualStyleBackColor = true;
            this.cbRollupNoDupeLines.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbRollupRealtime
            // 
            this.cbRollupRealtime.Location = new System.Drawing.Point(4, 17);
            this.cbRollupRealtime.Margin = new System.Windows.Forms.Padding(2);
            this.cbRollupRealtime.Name = "cbRollupRealtime";
            this.cbRollupRealtime.Size = new System.Drawing.Size(567, 37);
            this.cbRollupRealtime.TabIndex = 0;
            this.cbRollupRealtime.Text = "For roll-up captions, make letters appear in real time instead of one line at a t" +
    "ime, at the expense of duplicating the screen for each new letter (produces very" +
    " large files)";
            this.cbRollupRealtime.UseVisualStyleBackColor = true;
            this.cbRollupRealtime.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxSentenceCase
            // 
            this.groupBoxSentenceCase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxSentenceCase.Controls.Add(this.btnBrowseCapitalizationWords);
            this.groupBoxSentenceCase.Controls.Add(this.tbCapitalizationWordsFilename);
            this.groupBoxSentenceCase.Controls.Add(this.cbSentenceCaseExtraList);
            this.groupBoxSentenceCase.Controls.Add(this.rbSentenceCaseDefault);
            this.groupBoxSentenceCase.Controls.Add(this.rbSentenceCaseNone);
            this.groupBoxSentenceCase.Location = new System.Drawing.Point(0, 183);
            this.groupBoxSentenceCase.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSentenceCase.Name = "groupBoxSentenceCase";
            this.groupBoxSentenceCase.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSentenceCase.Size = new System.Drawing.Size(748, 84);
            this.groupBoxSentenceCase.TabIndex = 3;
            this.groupBoxSentenceCase.TabStop = false;
            this.groupBoxSentenceCase.Text = "Sentence case";
            // 
            // btnBrowseCapitalizationWords
            // 
            this.btnBrowseCapitalizationWords.Location = new System.Drawing.Point(493, 59);
            this.btnBrowseCapitalizationWords.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseCapitalizationWords.Name = "btnBrowseCapitalizationWords";
            this.btnBrowseCapitalizationWords.Size = new System.Drawing.Size(74, 19);
            this.btnBrowseCapitalizationWords.TabIndex = 4;
            this.btnBrowseCapitalizationWords.Text = "Browse";
            this.btnBrowseCapitalizationWords.UseVisualStyleBackColor = true;
            this.btnBrowseCapitalizationWords.Click += new System.EventHandler(this.btnBrowseCapitalizationWords_Click);
            // 
            // tbCapitalizationWordsFilename
            // 
            this.tbCapitalizationWordsFilename.Location = new System.Drawing.Point(330, 61);
            this.tbCapitalizationWordsFilename.Margin = new System.Windows.Forms.Padding(2);
            this.tbCapitalizationWordsFilename.Name = "tbCapitalizationWordsFilename";
            this.tbCapitalizationWordsFilename.Size = new System.Drawing.Size(159, 20);
            this.tbCapitalizationWordsFilename.TabIndex = 3;
            this.tbCapitalizationWordsFilename.TextChanged += new System.EventHandler(this.tbCapitalizationWordsFilename_TextChanged);
            // 
            // cbSentenceCaseExtraList
            // 
            this.cbSentenceCaseExtraList.AutoSize = true;
            this.cbSentenceCaseExtraList.Location = new System.Drawing.Point(139, 61);
            this.cbSentenceCaseExtraList.Margin = new System.Windows.Forms.Padding(2);
            this.cbSentenceCaseExtraList.Name = "cbSentenceCaseExtraList";
            this.cbSentenceCaseExtraList.Size = new System.Drawing.Size(188, 17);
            this.cbSentenceCaseExtraList.TabIndex = 2;
            this.cbSentenceCaseExtraList.Text = "Also use the list of words in this file";
            this.cbSentenceCaseExtraList.UseVisualStyleBackColor = true;
            this.cbSentenceCaseExtraList.CheckedChanged += new System.EventHandler(this.cbSentenceCaseExtraList_CheckedChanged);
            // 
            // rbSentenceCaseDefault
            // 
            this.rbSentenceCaseDefault.AutoSize = true;
            this.rbSentenceCaseDefault.Location = new System.Drawing.Point(4, 39);
            this.rbSentenceCaseDefault.Margin = new System.Windows.Forms.Padding(2);
            this.rbSentenceCaseDefault.Name = "rbSentenceCaseDefault";
            this.rbSentenceCaseDefault.Size = new System.Drawing.Size(556, 17);
            this.rbSentenceCaseDefault.TabIndex = 1;
            this.rbSentenceCaseDefault.Text = "Apply standard capitalization rules and use the built-in (small) list of words th" +
    "at must be capitalized (such as Spain)";
            this.rbSentenceCaseDefault.UseVisualStyleBackColor = true;
            this.rbSentenceCaseDefault.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbSentenceCaseNone
            // 
            this.rbSentenceCaseNone.AutoSize = true;
            this.rbSentenceCaseNone.Checked = true;
            this.rbSentenceCaseNone.Location = new System.Drawing.Point(4, 17);
            this.rbSentenceCaseNone.Margin = new System.Windows.Forms.Padding(2);
            this.rbSentenceCaseNone.Name = "rbSentenceCaseNone";
            this.rbSentenceCaseNone.Size = new System.Drawing.Size(323, 17);
            this.rbSentenceCaseNone.TabIndex = 0;
            this.rbSentenceCaseNone.TabStop = true;
            this.rbSentenceCaseNone.Text = "Do not modify case. Leave letters as they are (possibly all caps)";
            this.rbSentenceCaseNone.UseVisualStyleBackColor = true;
            this.rbSentenceCaseNone.CheckedChanged += new System.EventHandler(this.rbSentenceCaseNone_CheckedChanged);
            // 
            // groupBoxTextPosition
            // 
            this.groupBoxTextPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxTextPosition.Controls.Add(this.cbAutoDash);
            this.groupBoxTextPosition.Controls.Add(this.rbTextPositionCenter);
            this.groupBoxTextPosition.Controls.Add(this.rbTextPositionOriginal);
            this.groupBoxTextPosition.Location = new System.Drawing.Point(0, 83);
            this.groupBoxTextPosition.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTextPosition.Name = "groupBoxTextPosition";
            this.groupBoxTextPosition.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTextPosition.Size = new System.Drawing.Size(748, 100);
            this.groupBoxTextPosition.TabIndex = 2;
            this.groupBoxTextPosition.TabStop = false;
            this.groupBoxTextPosition.Text = "Text position";
            // 
            // cbAutoDash
            // 
            this.cbAutoDash.AutoSize = true;
            this.cbAutoDash.Location = new System.Drawing.Point(94, 60);
            this.cbAutoDash.Margin = new System.Windows.Forms.Padding(2);
            this.cbAutoDash.Name = "cbAutoDash";
            this.cbAutoDash.Size = new System.Drawing.Size(349, 17);
            this.cbAutoDash.TabIndex = 2;
            this.cbAutoDash.Text = "Add a dash (-) when the speaker changes (only for .srt and with -trim)";
            this.cbAutoDash.UseVisualStyleBackColor = true;
            this.cbAutoDash.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbTextPositionCenter
            // 
            this.rbTextPositionCenter.AutoSize = true;
            this.rbTextPositionCenter.Location = new System.Drawing.Point(7, 39);
            this.rbTextPositionCenter.Margin = new System.Windows.Forms.Padding(2);
            this.rbTextPositionCenter.Name = "rbTextPositionCenter";
            this.rbTextPositionCenter.Size = new System.Drawing.Size(234, 17);
            this.rbTextPositionCenter.TabIndex = 1;
            this.rbTextPositionCenter.Text = "Center text by removing left and right spaces";
            this.rbTextPositionCenter.UseVisualStyleBackColor = true;
            this.rbTextPositionCenter.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbTextPositionOriginal
            // 
            this.rbTextPositionOriginal.AutoSize = true;
            this.rbTextPositionOriginal.Checked = true;
            this.rbTextPositionOriginal.Location = new System.Drawing.Point(7, 17);
            this.rbTextPositionOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.rbTextPositionOriginal.Name = "rbTextPositionOriginal";
            this.rbTextPositionOriginal.Size = new System.Drawing.Size(518, 17);
            this.rbTextPositionOriginal.TabIndex = 0;
            this.rbTextPositionOriginal.TabStop = true;
            this.rbTextPositionOriginal.Text = "Export text in its original position by adding spaces where needed (this makes al" +
    "l lines 32 characters long)";
            this.rbTextPositionOriginal.UseVisualStyleBackColor = true;
            this.rbTextPositionOriginal.CheckedChanged += new System.EventHandler(this.rbTextPositionOriginal_CheckedChanged);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxColors.Controls.Add(this.tbDecoderColor);
            this.groupBoxColors.Controls.Add(this.rbColorsReplace);
            this.groupBoxColors.Controls.Add(this.rbColorsDefault);
            this.groupBoxColors.Controls.Add(this.rbColorsDisable);
            this.groupBoxColors.Location = new System.Drawing.Point(94, 0);
            this.groupBoxColors.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxColors.Size = new System.Drawing.Size(655, 83);
            this.groupBoxColors.TabIndex = 1;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Colors";
            // 
            // tbDecoderColor
            // 
            this.tbDecoderColor.Location = new System.Drawing.Point(390, 60);
            this.tbDecoderColor.Margin = new System.Windows.Forms.Padding(2);
            this.tbDecoderColor.MaxLength = 6;
            this.tbDecoderColor.Name = "tbDecoderColor";
            this.tbDecoderColor.Size = new System.Drawing.Size(76, 20);
            this.tbDecoderColor.TabIndex = 3;
            this.tbDecoderColor.TextChanged += new System.EventHandler(this.tbDecoderColor_TextChanged);
            // 
            // rbColorsReplace
            // 
            this.rbColorsReplace.AutoSize = true;
            this.rbColorsReplace.Location = new System.Drawing.Point(4, 61);
            this.rbColorsReplace.Margin = new System.Windows.Forms.Padding(2);
            this.rbColorsReplace.Name = "rbColorsReplace";
            this.rbColorsReplace.Size = new System.Drawing.Size(386, 17);
            this.rbColorsReplace.TabIndex = 2;
            this.rbColorsReplace.Text = "Add color information when possible, and replace the default color with this #";
            this.rbColorsReplace.UseVisualStyleBackColor = true;
            this.rbColorsReplace.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbColorsDefault
            // 
            this.rbColorsDefault.AutoSize = true;
            this.rbColorsDefault.Checked = true;
            this.rbColorsDefault.Location = new System.Drawing.Point(4, 39);
            this.rbColorsDefault.Margin = new System.Windows.Forms.Padding(2);
            this.rbColorsDefault.Name = "rbColorsDefault";
            this.rbColorsDefault.Size = new System.Drawing.Size(421, 17);
            this.rbColorsDefault.TabIndex = 1;
            this.rbColorsDefault.TabStop = true;
            this.rbColorsDefault.Text = "Add color information when possible, but leave the default color (usually white) " +
    "alone";
            this.rbColorsDefault.UseVisualStyleBackColor = true;
            this.rbColorsDefault.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbColorsDisable
            // 
            this.rbColorsDisable.AutoSize = true;
            this.rbColorsDisable.Location = new System.Drawing.Point(4, 17);
            this.rbColorsDisable.Margin = new System.Windows.Forms.Padding(2);
            this.rbColorsDisable.Name = "rbColorsDisable";
            this.rbColorsDisable.Size = new System.Drawing.Size(221, 17);
            this.rbColorsDisable.TabIndex = 0;
            this.rbColorsDisable.Text = "Don\'t add any color information to the text";
            this.rbColorsDisable.UseVisualStyleBackColor = true;
            this.rbColorsDisable.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxEncoding
            // 
            this.groupBoxEncoding.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxEncoding.Controls.Add(this.rbEncodingUnicode);
            this.groupBoxEncoding.Controls.Add(this.rbEncodingUTF8);
            this.groupBoxEncoding.Controls.Add(this.rbEncodingLatin1);
            this.groupBoxEncoding.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEncoding.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEncoding.Name = "groupBoxEncoding";
            this.groupBoxEncoding.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEncoding.Size = new System.Drawing.Size(94, 83);
            this.groupBoxEncoding.TabIndex = 0;
            this.groupBoxEncoding.TabStop = false;
            this.groupBoxEncoding.Text = "Encoding";
            // 
            // rbEncodingUnicode
            // 
            this.rbEncodingUnicode.AutoSize = true;
            this.rbEncodingUnicode.Location = new System.Drawing.Point(4, 61);
            this.rbEncodingUnicode.Margin = new System.Windows.Forms.Padding(2);
            this.rbEncodingUnicode.Name = "rbEncodingUnicode";
            this.rbEncodingUnicode.Size = new System.Drawing.Size(65, 17);
            this.rbEncodingUnicode.TabIndex = 2;
            this.rbEncodingUnicode.Text = "Unicode";
            this.rbEncodingUnicode.UseVisualStyleBackColor = true;
            this.rbEncodingUnicode.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbEncodingUTF8
            // 
            this.rbEncodingUTF8.AutoSize = true;
            this.rbEncodingUTF8.Checked = true;
            this.rbEncodingUTF8.Location = new System.Drawing.Point(4, 39);
            this.rbEncodingUTF8.Margin = new System.Windows.Forms.Padding(2);
            this.rbEncodingUTF8.Name = "rbEncodingUTF8";
            this.rbEncodingUTF8.Size = new System.Drawing.Size(55, 17);
            this.rbEncodingUTF8.TabIndex = 1;
            this.rbEncodingUTF8.TabStop = true;
            this.rbEncodingUTF8.Text = "UTF-8";
            this.rbEncodingUTF8.UseVisualStyleBackColor = true;
            this.rbEncodingUTF8.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbEncodingLatin1
            // 
            this.rbEncodingLatin1.AutoSize = true;
            this.rbEncodingLatin1.Location = new System.Drawing.Point(4, 17);
            this.rbEncodingLatin1.Margin = new System.Windows.Forms.Padding(2);
            this.rbEncodingLatin1.Name = "rbEncodingLatin1";
            this.rbEncodingLatin1.Size = new System.Drawing.Size(57, 17);
            this.rbEncodingLatin1.TabIndex = 0;
            this.rbEncodingLatin1.Text = "Latin-1";
            this.rbEncodingLatin1.UseVisualStyleBackColor = true;
            this.rbEncodingLatin1.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // tabPageCredits
            // 
            this.tabPageCredits.Controls.Add(this.panel1);
            this.tabPageCredits.Controls.Add(this.groupBoxEndCredits);
            this.tabPageCredits.Controls.Add(this.groupBoxStartingCredits);
            this.tabPageCredits.Location = new System.Drawing.Point(4, 22);
            this.tabPageCredits.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCredits.Name = "tabPageCredits";
            this.tabPageCredits.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCredits.Size = new System.Drawing.Size(746, 462);
            this.tabPageCredits.TabIndex = 8;
            this.tabPageCredits.Text = "Credits";
            this.tabPageCredits.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.label34);
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 53);
            this.panel1.TabIndex = 15;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(4, 2);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(515, 26);
            this.label34.TabIndex = 0;
            this.label34.Text = "- All conditions must be met, otherwise no text will be added.\r\n- If you plan to " +
    "distribute the output files non-comercially, please consider leaving a reference" +
    " to CCExtractor.";
            // 
            // groupBoxEndCredits
            // 
            this.groupBoxEndCredits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxEndCredits.Controls.Add(this.label31);
            this.groupBoxEndCredits.Controls.Add(this.updownEndCreditsMaxDisplayedSS);
            this.groupBoxEndCredits.Controls.Add(this.label32);
            this.groupBoxEndCredits.Controls.Add(this.updownEndCreditsMinDisplayedSS);
            this.groupBoxEndCredits.Controls.Add(this.label33);
            this.groupBoxEndCredits.Controls.Add(this.tbEndCredits);
            this.groupBoxEndCredits.Controls.Add(this.cbWriteEndText);
            this.groupBoxEndCredits.Location = new System.Drawing.Point(0, 150);
            this.groupBoxEndCredits.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEndCredits.Name = "groupBoxEndCredits";
            this.groupBoxEndCredits.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEndCredits.Size = new System.Drawing.Size(748, 124);
            this.groupBoxEndCredits.TabIndex = 14;
            this.groupBoxEndCredits.TabStop = false;
            this.groupBoxEndCredits.Text = "End credits";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(341, 98);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 13);
            this.label31.TabIndex = 13;
            this.label31.Text = "seconds";
            // 
            // updownEndCreditsMaxDisplayedSS
            // 
            this.updownEndCreditsMaxDisplayedSS.Location = new System.Drawing.Point(294, 97);
            this.updownEndCreditsMaxDisplayedSS.Margin = new System.Windows.Forms.Padding(2);
            this.updownEndCreditsMaxDisplayedSS.Name = "updownEndCreditsMaxDisplayedSS";
            this.updownEndCreditsMaxDisplayedSS.Size = new System.Drawing.Size(35, 20);
            this.updownEndCreditsMaxDisplayedSS.TabIndex = 12;
            this.updownEndCreditsMaxDisplayedSS.ValueChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(228, 97);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(62, 13);
            this.label32.TabIndex = 11;
            this.label32.Text = "and at most";
            // 
            // updownEndCreditsMinDisplayedSS
            // 
            this.updownEndCreditsMinDisplayedSS.Location = new System.Drawing.Point(182, 97);
            this.updownEndCreditsMinDisplayedSS.Margin = new System.Windows.Forms.Padding(2);
            this.updownEndCreditsMinDisplayedSS.Name = "updownEndCreditsMinDisplayedSS";
            this.updownEndCreditsMinDisplayedSS.Size = new System.Drawing.Size(35, 20);
            this.updownEndCreditsMinDisplayedSS.TabIndex = 10;
            this.updownEndCreditsMinDisplayedSS.ValueChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(18, 97);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(152, 13);
            this.label33.TabIndex = 9;
            this.label33.Text = "It must be displayed for at least";
            // 
            // tbEndCredits
            // 
            this.tbEndCredits.Location = new System.Drawing.Point(22, 39);
            this.tbEndCredits.Margin = new System.Windows.Forms.Padding(2);
            this.tbEndCredits.Multiline = true;
            this.tbEndCredits.Name = "tbEndCredits";
            this.tbEndCredits.Size = new System.Drawing.Size(542, 56);
            this.tbEndCredits.TabIndex = 1;
            this.tbEndCredits.TextChanged += new System.EventHandler(this.tbEndCredits_TextChanged);
            // 
            // cbWriteEndText
            // 
            this.cbWriteEndText.AutoSize = true;
            this.cbWriteEndText.Location = new System.Drawing.Point(4, 17);
            this.cbWriteEndText.Margin = new System.Windows.Forms.Padding(2);
            this.cbWriteEndText.Name = "cbWriteEndText";
            this.cbWriteEndText.Size = new System.Drawing.Size(481, 17);
            this.cbWriteEndText.TabIndex = 0;
            this.cbWriteEndText.Text = "If there is a chance, write this text after the last caption and as close as poss" +
    "ible to the video end";
            this.cbWriteEndText.UseVisualStyleBackColor = true;
            this.cbWriteEndText.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // groupBoxStartingCredits
            // 
            this.groupBoxStartingCredits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxStartingCredits.Controls.Add(this.label30);
            this.groupBoxStartingCredits.Controls.Add(this.updownStartCreditsMaxDisplayedSS);
            this.groupBoxStartingCredits.Controls.Add(this.label29);
            this.groupBoxStartingCredits.Controls.Add(this.updownStartCreditsMinDisplayedSS);
            this.groupBoxStartingCredits.Controls.Add(this.label28);
            this.groupBoxStartingCredits.Controls.Add(this.updownStartCreditsNotAfterSS);
            this.groupBoxStartingCredits.Controls.Add(this.updownStartCreditsNotAfterMM);
            this.groupBoxStartingCredits.Controls.Add(this.cbbStartCreditsNotLaterThan);
            this.groupBoxStartingCredits.Controls.Add(this.updownStartCreditsNotBeforeSS);
            this.groupBoxStartingCredits.Controls.Add(this.updownStartCreditsNotBeforeMM);
            this.groupBoxStartingCredits.Controls.Add(this.cbbStartCreditsNotBeforeThan);
            this.groupBoxStartingCredits.Controls.Add(this.tbStartCredits);
            this.groupBoxStartingCredits.Controls.Add(this.cbWriteStartingText);
            this.groupBoxStartingCredits.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStartingCredits.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxStartingCredits.Name = "groupBoxStartingCredits";
            this.groupBoxStartingCredits.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxStartingCredits.Size = new System.Drawing.Size(752, 150);
            this.groupBoxStartingCredits.TabIndex = 0;
            this.groupBoxStartingCredits.TabStop = false;
            this.groupBoxStartingCredits.Text = "Start credits";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(344, 129);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "seconds";
            // 
            // updownStartCreditsMaxDisplayedSS
            // 
            this.updownStartCreditsMaxDisplayedSS.Location = new System.Drawing.Point(296, 128);
            this.updownStartCreditsMaxDisplayedSS.Margin = new System.Windows.Forms.Padding(2);
            this.updownStartCreditsMaxDisplayedSS.Name = "updownStartCreditsMaxDisplayedSS";
            this.updownStartCreditsMaxDisplayedSS.Size = new System.Drawing.Size(35, 20);
            this.updownStartCreditsMaxDisplayedSS.TabIndex = 12;
            this.updownStartCreditsMaxDisplayedSS.ValueChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(230, 128);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 13);
            this.label29.TabIndex = 11;
            this.label29.Text = "and at most";
            // 
            // updownStartCreditsMinDisplayedSS
            // 
            this.updownStartCreditsMinDisplayedSS.Location = new System.Drawing.Point(184, 128);
            this.updownStartCreditsMinDisplayedSS.Margin = new System.Windows.Forms.Padding(2);
            this.updownStartCreditsMinDisplayedSS.Name = "updownStartCreditsMinDisplayedSS";
            this.updownStartCreditsMinDisplayedSS.Size = new System.Drawing.Size(35, 20);
            this.updownStartCreditsMinDisplayedSS.TabIndex = 10;
            this.updownStartCreditsMinDisplayedSS.ValueChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(20, 128);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(152, 13);
            this.label28.TabIndex = 9;
            this.label28.Text = "It must be displayed for at least";
            // 
            // updownStartCreditsNotAfterSS
            // 
            this.updownStartCreditsNotAfterSS.Location = new System.Drawing.Point(420, 94);
            this.updownStartCreditsNotAfterSS.Margin = new System.Windows.Forms.Padding(2);
            this.updownStartCreditsNotAfterSS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownStartCreditsNotAfterSS.Name = "updownStartCreditsNotAfterSS";
            this.updownStartCreditsNotAfterSS.Size = new System.Drawing.Size(35, 20);
            this.updownStartCreditsNotAfterSS.TabIndex = 8;
            this.updownStartCreditsNotAfterSS.ValueChanged += new System.EventHandler(this.updownStartCreditsNotAfter_ValueChanged);
            // 
            // updownStartCreditsNotAfterMM
            // 
            this.updownStartCreditsNotAfterMM.Location = new System.Drawing.Point(380, 95);
            this.updownStartCreditsNotAfterMM.Margin = new System.Windows.Forms.Padding(2);
            this.updownStartCreditsNotAfterMM.Name = "updownStartCreditsNotAfterMM";
            this.updownStartCreditsNotAfterMM.Size = new System.Drawing.Size(35, 20);
            this.updownStartCreditsNotAfterMM.TabIndex = 7;
            this.updownStartCreditsNotAfterMM.ValueChanged += new System.EventHandler(this.updownStartCreditsNotAfter_ValueChanged);
            // 
            // cbbStartCreditsNotLaterThan
            // 
            this.cbbStartCreditsNotLaterThan.AutoSize = true;
            this.cbbStartCreditsNotLaterThan.Location = new System.Drawing.Point(277, 96);
            this.cbbStartCreditsNotLaterThan.Margin = new System.Windows.Forms.Padding(2);
            this.cbbStartCreditsNotLaterThan.Name = "cbbStartCreditsNotLaterThan";
            this.cbbStartCreditsNotLaterThan.Size = new System.Drawing.Size(111, 17);
            this.cbbStartCreditsNotLaterThan.TabIndex = 6;
            this.cbbStartCreditsNotLaterThan.Text = "Not after (MM:SS)";
            this.cbbStartCreditsNotLaterThan.UseVisualStyleBackColor = true;
            this.cbbStartCreditsNotLaterThan.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // updownStartCreditsNotBeforeSS
            // 
            this.updownStartCreditsNotBeforeSS.Location = new System.Drawing.Point(184, 94);
            this.updownStartCreditsNotBeforeSS.Margin = new System.Windows.Forms.Padding(2);
            this.updownStartCreditsNotBeforeSS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownStartCreditsNotBeforeSS.Name = "updownStartCreditsNotBeforeSS";
            this.updownStartCreditsNotBeforeSS.Size = new System.Drawing.Size(35, 20);
            this.updownStartCreditsNotBeforeSS.TabIndex = 5;
            this.updownStartCreditsNotBeforeSS.ValueChanged += new System.EventHandler(this.updownStartCreditsNotBefore_ValueChanged);
            // 
            // updownStartCreditsNotBeforeMM
            // 
            this.updownStartCreditsNotBeforeMM.Location = new System.Drawing.Point(144, 95);
            this.updownStartCreditsNotBeforeMM.Margin = new System.Windows.Forms.Padding(2);
            this.updownStartCreditsNotBeforeMM.Name = "updownStartCreditsNotBeforeMM";
            this.updownStartCreditsNotBeforeMM.Size = new System.Drawing.Size(35, 20);
            this.updownStartCreditsNotBeforeMM.TabIndex = 4;
            this.updownStartCreditsNotBeforeMM.ValueChanged += new System.EventHandler(this.updownStartCreditsNotBefore_ValueChanged);
            // 
            // cbbStartCreditsNotBeforeThan
            // 
            this.cbbStartCreditsNotBeforeThan.AutoSize = true;
            this.cbbStartCreditsNotBeforeThan.Location = new System.Drawing.Point(22, 95);
            this.cbbStartCreditsNotBeforeThan.Margin = new System.Windows.Forms.Padding(2);
            this.cbbStartCreditsNotBeforeThan.Name = "cbbStartCreditsNotBeforeThan";
            this.cbbStartCreditsNotBeforeThan.Size = new System.Drawing.Size(120, 17);
            this.cbbStartCreditsNotBeforeThan.TabIndex = 2;
            this.cbbStartCreditsNotBeforeThan.Text = "Not before (MM:SS)";
            this.cbbStartCreditsNotBeforeThan.UseVisualStyleBackColor = true;
            this.cbbStartCreditsNotBeforeThan.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // tbStartCredits
            // 
            this.tbStartCredits.Location = new System.Drawing.Point(22, 39);
            this.tbStartCredits.Margin = new System.Windows.Forms.Padding(2);
            this.tbStartCredits.Multiline = true;
            this.tbStartCredits.Name = "tbStartCredits";
            this.tbStartCredits.Size = new System.Drawing.Size(722, 53);
            this.tbStartCredits.TabIndex = 1;
            this.tbStartCredits.TextChanged += new System.EventHandler(this.tbStartCredits_TextChanged);
            // 
            // cbWriteStartingText
            // 
            this.cbWriteStartingText.AutoSize = true;
            this.cbWriteStartingText.Location = new System.Drawing.Point(4, 17);
            this.cbWriteStartingText.Margin = new System.Windows.Forms.Padding(2);
            this.cbWriteStartingText.Name = "cbWriteStartingText";
            this.cbWriteStartingText.Size = new System.Drawing.Size(279, 17);
            this.cbWriteStartingText.TabIndex = 0;
            this.cbWriteStartingText.Text = "If there is a chance, write this text as soon as possible";
            this.cbWriteStartingText.UseVisualStyleBackColor = true;
            this.cbWriteStartingText.CheckedChanged += new System.EventHandler(this.cbWriteStartingText_CheckedChanged);
            // 
            // tabPageDebug
            // 
            this.tabPageDebug.Controls.Add(this.cbDebugLevDistance);
            this.tabPageDebug.Controls.Add(this.cbDebugAnalyzePackets);
            this.tabPageDebug.Controls.Add(this.cbDebugPMT);
            this.tabPageDebug.Controls.Add(this.cbDebugPAT);
            this.tabPageDebug.Controls.Add(this.cbDebugXDS);
            this.tabPageDebug.Controls.Add(this.cbFullbin);
            this.tabPageDebug.Controls.Add(this.cbNosync);
            this.tabPageDebug.Controls.Add(this.cbDebugContainer);
            this.tabPageDebug.Controls.Add(this.cbDebugRaw608_708wTimestamps);
            this.tabPageDebug.Controls.Add(this.cbDebugESAnalysis);
            this.tabPageDebug.Controls.Add(this.cbDebugTimestamps);
            this.tabPageDebug.Controls.Add(this.cbDebugTraces708);
            this.tabPageDebug.Controls.Add(this.cbDebugTraces608);
            this.tabPageDebug.Controls.Add(this.cbDebugInterestingPackets);
            this.tabPageDebug.Controls.Add(this.btnBrowseElementaryStreamFilename);
            this.tabPageDebug.Controls.Add(this.tbElementaryStreamFilename);
            this.tabPageDebug.Controls.Add(this.cbDebugWriteES);
            this.tabPageDebug.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebug.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDebug.Size = new System.Drawing.Size(746, 462);
            this.tabPageDebug.TabIndex = 4;
            this.tabPageDebug.Text = "Debug";
            this.tabPageDebug.UseVisualStyleBackColor = true;
            // 
            // cbDebugLevDistance
            // 
            this.cbDebugLevDistance.AutoSize = true;
            this.cbDebugLevDistance.Location = new System.Drawing.Point(6, 311);
            this.cbDebugLevDistance.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugLevDistance.Name = "cbDebugLevDistance";
            this.cbDebugLevDistance.Size = new System.Drawing.Size(336, 17);
            this.cbDebugLevDistance.TabIndex = 16;
            this.cbDebugLevDistance.Text = "Output Levenshtein debug info (calculated distance, allowed, etc)";
            this.cbDebugLevDistance.UseVisualStyleBackColor = true;
            this.cbDebugLevDistance.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugAnalyzePackets
            // 
            this.cbDebugAnalyzePackets.AutoSize = true;
            this.cbDebugAnalyzePackets.Location = new System.Drawing.Point(6, 289);
            this.cbDebugAnalyzePackets.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugAnalyzePackets.Name = "cbDebugAnalyzePackets";
            this.cbDebugAnalyzePackets.Size = new System.Drawing.Size(441, 17);
            this.cbDebugAnalyzePackets.TabIndex = 15;
            this.cbDebugAnalyzePackets.Text = "If no suitable CC packet is found in PMT, analyze packet contents and scan for CC" +
    " data";
            this.cbDebugAnalyzePackets.UseVisualStyleBackColor = true;
            this.cbDebugAnalyzePackets.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugPMT
            // 
            this.cbDebugPMT.AutoSize = true;
            this.cbDebugPMT.Location = new System.Drawing.Point(6, 267);
            this.cbDebugPMT.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugPMT.Name = "cbDebugPMT";
            this.cbDebugPMT.Size = new System.Drawing.Size(198, 17);
            this.cbDebugPMT.TabIndex = 14;
            this.cbDebugPMT.Text = "Output Program Map Table contents";
            this.cbDebugPMT.UseVisualStyleBackColor = true;
            this.cbDebugPMT.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugPAT
            // 
            this.cbDebugPAT.AutoSize = true;
            this.cbDebugPAT.Location = new System.Drawing.Point(6, 245);
            this.cbDebugPAT.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugPAT.Name = "cbDebugPAT";
            this.cbDebugPAT.Size = new System.Drawing.Size(231, 17);
            this.cbDebugPAT.TabIndex = 13;
            this.cbDebugPAT.Text = "Output Program Association Table contents";
            this.cbDebugPAT.UseVisualStyleBackColor = true;
            this.cbDebugPAT.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugXDS
            // 
            this.cbDebugXDS.AutoSize = true;
            this.cbDebugXDS.Location = new System.Drawing.Point(6, 223);
            this.cbDebugXDS.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugXDS.Name = "cbDebugXDS";
            this.cbDebugXDS.Size = new System.Drawing.Size(149, 17);
            this.cbDebugXDS.TabIndex = 12;
            this.cbDebugXDS.Text = "Enable XDS debug traces";
            this.cbDebugXDS.UseVisualStyleBackColor = true;
            this.cbDebugXDS.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbFullbin
            // 
            this.cbFullbin.AutoSize = true;
            this.cbFullbin.Location = new System.Drawing.Point(6, 202);
            this.cbFullbin.Margin = new System.Windows.Forms.Padding(2);
            this.cbFullbin.Name = "cbFullbin";
            this.cbFullbin.Size = new System.Drawing.Size(245, 17);
            this.cbFullbin.TabIndex = 11;
            this.cbFullbin.Text = "[.bin only] Don\'t remove trailing padding blocks";
            this.cbFullbin.UseVisualStyleBackColor = true;
            this.cbFullbin.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbNosync
            // 
            this.cbNosync.AutoSize = true;
            this.cbNosync.Location = new System.Drawing.Point(6, 180);
            this.cbNosync.Margin = new System.Windows.Forms.Padding(2);
            this.cbNosync.Name = "cbNosync";
            this.cbNosync.Size = new System.Drawing.Size(292, 17);
            this.cbNosync.TabIndex = 10;
            this.cbNosync.Text = "[.bin only] Disable sync code when there\'s a timeline gap";
            this.cbNosync.UseVisualStyleBackColor = true;
            this.cbNosync.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugContainer
            // 
            this.cbDebugContainer.AutoSize = true;
            this.cbDebugContainer.Location = new System.Drawing.Point(4, 158);
            this.cbDebugContainer.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugContainer.Name = "cbDebugContainer";
            this.cbDebugContainer.Size = new System.Drawing.Size(411, 17);
            this.cbDebugContainer.TabIndex = 9;
            this.cbDebugContainer.Text = "Print debug info about the parsed container file. (Only for ASF files at the mome" +
    "nt.)";
            this.cbDebugContainer.UseVisualStyleBackColor = true;
            this.cbDebugContainer.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugRaw608_708wTimestamps
            // 
            this.cbDebugRaw608_708wTimestamps.AutoSize = true;
            this.cbDebugRaw608_708wTimestamps.Location = new System.Drawing.Point(4, 136);
            this.cbDebugRaw608_708wTimestamps.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugRaw608_708wTimestamps.Name = "cbDebugRaw608_708wTimestamps";
            this.cbDebugRaw608_708wTimestamps.Size = new System.Drawing.Size(318, 17);
            this.cbDebugRaw608_708wTimestamps.TabIndex = 8;
            this.cbDebugRaw608_708wTimestamps.Text = "Print debug trace with the raw 608/708 data with time stamps.";
            this.cbDebugRaw608_708wTimestamps.UseVisualStyleBackColor = true;
            this.cbDebugRaw608_708wTimestamps.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugESAnalysis
            // 
            this.cbDebugESAnalysis.AutoSize = true;
            this.cbDebugESAnalysis.Location = new System.Drawing.Point(4, 115);
            this.cbDebugESAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugESAnalysis.Name = "cbDebugESAnalysis";
            this.cbDebugESAnalysis.Size = new System.Drawing.Size(313, 17);
            this.cbDebugESAnalysis.TabIndex = 7;
            this.cbDebugESAnalysis.Text = "Print debug info about the analysed elementary video stream.";
            this.cbDebugESAnalysis.UseVisualStyleBackColor = true;
            this.cbDebugESAnalysis.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugTimestamps
            // 
            this.cbDebugTimestamps.AutoSize = true;
            this.cbDebugTimestamps.Location = new System.Drawing.Point(4, 93);
            this.cbDebugTimestamps.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugTimestamps.Name = "cbDebugTimestamps";
            this.cbDebugTimestamps.Size = new System.Drawing.Size(179, 17);
            this.cbDebugTimestamps.TabIndex = 6;
            this.cbDebugTimestamps.Text = "Enable lots of time stamp output.";
            this.cbDebugTimestamps.UseVisualStyleBackColor = true;
            this.cbDebugTimestamps.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugTraces708
            // 
            this.cbDebugTraces708.AutoSize = true;
            this.cbDebugTraces708.Location = new System.Drawing.Point(4, 71);
            this.cbDebugTraces708.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugTraces708.Name = "cbDebugTraces708";
            this.cbDebugTraces708.Size = new System.Drawing.Size(239, 17);
            this.cbDebugTraces708.TabIndex = 5;
            this.cbDebugTraces708.Text = "Print debug traces from the EIA-708 decoder.";
            this.cbDebugTraces708.UseVisualStyleBackColor = true;
            this.cbDebugTraces708.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugTraces608
            // 
            this.cbDebugTraces608.AutoSize = true;
            this.cbDebugTraces608.Location = new System.Drawing.Point(4, 49);
            this.cbDebugTraces608.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugTraces608.Name = "cbDebugTraces608";
            this.cbDebugTraces608.Size = new System.Drawing.Size(239, 17);
            this.cbDebugTraces608.TabIndex = 4;
            this.cbDebugTraces608.Text = "Print debug traces from the EIA-608 decoder.";
            this.cbDebugTraces608.UseVisualStyleBackColor = true;
            this.cbDebugTraces608.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // cbDebugInterestingPackets
            // 
            this.cbDebugInterestingPackets.AutoSize = true;
            this.cbDebugInterestingPackets.Location = new System.Drawing.Point(4, 27);
            this.cbDebugInterestingPackets.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugInterestingPackets.Name = "cbDebugInterestingPackets";
            this.cbDebugInterestingPackets.Size = new System.Drawing.Size(367, 17);
            this.cbDebugInterestingPackets.TabIndex = 3;
            this.cbDebugInterestingPackets.Text = "Dump interesting packets - usually, those that don\'t seem to follow specs";
            this.cbDebugInterestingPackets.UseVisualStyleBackColor = true;
            this.cbDebugInterestingPackets.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // btnBrowseElementaryStreamFilename
            // 
            this.btnBrowseElementaryStreamFilename.Location = new System.Drawing.Point(418, 5);
            this.btnBrowseElementaryStreamFilename.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseElementaryStreamFilename.Name = "btnBrowseElementaryStreamFilename";
            this.btnBrowseElementaryStreamFilename.Size = new System.Drawing.Size(56, 21);
            this.btnBrowseElementaryStreamFilename.TabIndex = 2;
            this.btnBrowseElementaryStreamFilename.Text = "Browse";
            this.btnBrowseElementaryStreamFilename.UseVisualStyleBackColor = true;
            this.btnBrowseElementaryStreamFilename.Click += new System.EventHandler(this.btnBrowseElementaryStreamFilename_Click);
            // 
            // tbElementaryStreamFilename
            // 
            this.tbElementaryStreamFilename.Location = new System.Drawing.Point(195, 5);
            this.tbElementaryStreamFilename.Margin = new System.Windows.Forms.Padding(2);
            this.tbElementaryStreamFilename.Name = "tbElementaryStreamFilename";
            this.tbElementaryStreamFilename.Size = new System.Drawing.Size(212, 20);
            this.tbElementaryStreamFilename.TabIndex = 1;
            this.tbElementaryStreamFilename.TextChanged += new System.EventHandler(this.tbElementaryStreamFilename_TextChanged);
            // 
            // cbDebugWriteES
            // 
            this.cbDebugWriteES.AutoSize = true;
            this.cbDebugWriteES.Location = new System.Drawing.Point(4, 5);
            this.cbDebugWriteES.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebugWriteES.Name = "cbDebugWriteES";
            this.cbDebugWriteES.Size = new System.Drawing.Size(186, 17);
            this.cbDebugWriteES.TabIndex = 0;
            this.cbDebugWriteES.Text = "Write elementary stream to this file";
            this.cbDebugWriteES.UseVisualStyleBackColor = true;
            this.cbDebugWriteES.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // tabPageHDHomeRun
            // 
            this.tabPageHDHomeRun.Controls.Add(this.butFindTuners);
            this.tabPageHDHomeRun.Controls.Add(this.listBoxTuners);
            this.tabPageHDHomeRun.Controls.Add(this.label54);
            this.tabPageHDHomeRun.Controls.Add(this.butHDHomeRunDir);
            this.tabPageHDHomeRun.Controls.Add(this.tbHDHomeRunPath);
            this.tabPageHDHomeRun.Controls.Add(this.label53);
            this.tabPageHDHomeRun.Location = new System.Drawing.Point(4, 22);
            this.tabPageHDHomeRun.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHDHomeRun.Name = "tabPageHDHomeRun";
            this.tabPageHDHomeRun.Size = new System.Drawing.Size(746, 462);
            this.tabPageHDHomeRun.TabIndex = 10;
            this.tabPageHDHomeRun.Text = "HDHomeRun";
            this.tabPageHDHomeRun.UseVisualStyleBackColor = true;
            // 
            // butFindTuners
            // 
            this.butFindTuners.Location = new System.Drawing.Point(45, 35);
            this.butFindTuners.Margin = new System.Windows.Forms.Padding(2);
            this.butFindTuners.Name = "butFindTuners";
            this.butFindTuners.Size = new System.Drawing.Size(148, 19);
            this.butFindTuners.TabIndex = 5;
            this.butFindTuners.Text = "Find HDHomeRun devices";
            this.butFindTuners.UseVisualStyleBackColor = true;
            this.butFindTuners.Click += new System.EventHandler(this.butFindTuners_Click);
            // 
            // listBoxTuners
            // 
            this.listBoxTuners.FormattingEnabled = true;
            this.listBoxTuners.Items.AddRange(new object[] {
            "No devices found yet."});
            this.listBoxTuners.Location = new System.Drawing.Point(8, 58);
            this.listBoxTuners.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTuners.Name = "listBoxTuners";
            this.listBoxTuners.Size = new System.Drawing.Size(186, 69);
            this.listBoxTuners.TabIndex = 4;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 37);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 13);
            this.label54.TabIndex = 3;
            this.label54.Text = "Device";
            // 
            // butHDHomeRunDir
            // 
            this.butHDHomeRunDir.Location = new System.Drawing.Point(641, 10);
            this.butHDHomeRunDir.Margin = new System.Windows.Forms.Padding(2);
            this.butHDHomeRunDir.Name = "butHDHomeRunDir";
            this.butHDHomeRunDir.Size = new System.Drawing.Size(72, 19);
            this.butHDHomeRunDir.TabIndex = 2;
            this.butHDHomeRunDir.Text = "Browse";
            this.butHDHomeRunDir.UseVisualStyleBackColor = true;
            this.butHDHomeRunDir.Click += new System.EventHandler(this.butHDHomeRunDir_Click);
            // 
            // tbHDHomeRunPath
            // 
            this.tbHDHomeRunPath.Location = new System.Drawing.Point(304, 11);
            this.tbHDHomeRunPath.Margin = new System.Windows.Forms.Padding(2);
            this.tbHDHomeRunPath.Name = "tbHDHomeRunPath";
            this.tbHDHomeRunPath.Size = new System.Drawing.Size(323, 20);
            this.tbHDHomeRunPath.TabIndex = 1;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(6, 13);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(295, 13);
            this.label53.TabIndex = 0;
            this.label53.Text = "HDHomeRun tools location (where hdhomerun_config.exe is)";
            // 
            // tabPageExecution
            // 
            this.tabPageExecution.Controls.Add(this.progressBarActivity);
            this.tabPageExecution.Controls.Add(this.LABReportsXDSProgramID);
            this.tabPageExecution.Controls.Add(this.label38);
            this.tabPageExecution.Controls.Add(this.LABReportsXDSNetworkCallLetters);
            this.tabPageExecution.Controls.Add(this.label37);
            this.tabPageExecution.Controls.Add(this.LABReportsXDSProgramName);
            this.tabPageExecution.Controls.Add(this.label36);
            this.tabPageExecution.Controls.Add(this.label25);
            this.tabPageExecution.Controls.Add(this.textBox1);
            this.tabPageExecution.Controls.Add(this.label13);
            this.tabPageExecution.Controls.Add(this.label12);
            this.tabPageExecution.Controls.Add(this.LabReportsFramerate);
            this.tabPageExecution.Controls.Add(this.LabReportsAspectRatio);
            this.tabPageExecution.Controls.Add(this.LabReportsVideoResolution);
            this.tabPageExecution.Controls.Add(this.label17);
            this.tabPageExecution.Controls.Add(this.label16);
            this.tabPageExecution.Controls.Add(this.label15);
            this.tabPageExecution.Controls.Add(this.LabReportsLastMessage);
            this.tabPageExecution.Controls.Add(this.LabReportsCurrentFile);
            this.tabPageExecution.Controls.Add(this.LabReportsStatus);
            this.tabPageExecution.Controls.Add(this.LabReportsPosition);
            this.tabPageExecution.Controls.Add(this.progressBarCCE);
            this.tabPageExecution.Controls.Add(this.LabReportsCCExtractorVersion);
            this.tabPageExecution.Controls.Add(this.label14);
            this.tabPageExecution.Controls.Add(this.label11);
            this.tabPageExecution.Controls.Add(this.label10);
            this.tabPageExecution.Controls.Add(this.label9);
            this.tabPageExecution.Controls.Add(this.label8);
            this.tabPageExecution.Controls.Add(this.textBoxActivity);
            this.tabPageExecution.Controls.Add(this.btnGo);
            this.tabPageExecution.Controls.Add(this.LabReportsProgress);
            this.tabPageExecution.Location = new System.Drawing.Point(4, 22);
            this.tabPageExecution.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageExecution.Name = "tabPageExecution";
            this.tabPageExecution.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageExecution.Size = new System.Drawing.Size(746, 462);
            this.tabPageExecution.TabIndex = 6;
            this.tabPageExecution.Text = "Execution";
            this.tabPageExecution.UseVisualStyleBackColor = true;
            // 
            // progressBarActivity
            // 
            this.progressBarActivity.ForeColor = System.Drawing.Color.Lime;
            this.progressBarActivity.Location = new System.Drawing.Point(712, 446);
            this.progressBarActivity.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarActivity.MarqueeAnimationSpeed = 0;
            this.progressBarActivity.Maximum = 3;
            this.progressBarActivity.Name = "progressBarActivity";
            this.progressBarActivity.Size = new System.Drawing.Size(30, 10);
            this.progressBarActivity.TabIndex = 30;
            // 
            // LABReportsXDSProgramID
            // 
            this.LABReportsXDSProgramID.AutoSize = true;
            this.LABReportsXDSProgramID.Location = new System.Drawing.Point(112, 345);
            this.LABReportsXDSProgramID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABReportsXDSProgramID.Name = "LABReportsXDSProgramID";
            this.LABReportsXDSProgramID.Size = new System.Drawing.Size(10, 13);
            this.LABReportsXDSProgramID.TabIndex = 29;
            this.LABReportsXDSProgramID.Text = "-";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(22, 346);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(88, 13);
            this.label38.TabIndex = 28;
            this.label38.Text = "XDS Program ID:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LABReportsXDSNetworkCallLetters
            // 
            this.LABReportsXDSNetworkCallLetters.AutoSize = true;
            this.LABReportsXDSNetworkCallLetters.Location = new System.Drawing.Point(113, 332);
            this.LABReportsXDSNetworkCallLetters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABReportsXDSNetworkCallLetters.Name = "LABReportsXDSNetworkCallLetters";
            this.LABReportsXDSNetworkCallLetters.Size = new System.Drawing.Size(10, 13);
            this.LABReportsXDSNetworkCallLetters.TabIndex = 27;
            this.LABReportsXDSNetworkCallLetters.Text = "-";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(13, 332);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(99, 13);
            this.label37.TabIndex = 26;
            this.label37.Text = "XDS Network call l:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LABReportsXDSProgramName
            // 
            this.LABReportsXDSProgramName.AutoSize = true;
            this.LABReportsXDSProgramName.Location = new System.Drawing.Point(113, 318);
            this.LABReportsXDSProgramName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABReportsXDSProgramName.Name = "LABReportsXDSProgramName";
            this.LABReportsXDSProgramName.Size = new System.Drawing.Size(10, 13);
            this.LABReportsXDSProgramName.TabIndex = 25;
            this.LABReportsXDSProgramName.Text = "-";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(4, 318);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(105, 13);
            this.label36.TabIndex = 24;
            this.label36.Text = "XDS Program Name:";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(398, 198);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 13);
            this.label25.TabIndex = 23;
            this.label25.Text = "Preview";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(400, 214);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(342, 201);
            this.textBox1.TabIndex = 22;
            this.textBox1.WordWrap = false;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(34, 387);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "Position:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(34, 374);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Progress:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabReportsFramerate
            // 
            this.LabReportsFramerate.AutoSize = true;
            this.LabReportsFramerate.Location = new System.Drawing.Point(113, 304);
            this.LabReportsFramerate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabReportsFramerate.Name = "LabReportsFramerate";
            this.LabReportsFramerate.Size = new System.Drawing.Size(10, 13);
            this.LabReportsFramerate.TabIndex = 21;
            this.LabReportsFramerate.Text = "-";
            // 
            // LabReportsAspectRatio
            // 
            this.LabReportsAspectRatio.AutoSize = true;
            this.LabReportsAspectRatio.Location = new System.Drawing.Point(113, 290);
            this.LabReportsAspectRatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabReportsAspectRatio.Name = "LabReportsAspectRatio";
            this.LabReportsAspectRatio.Size = new System.Drawing.Size(10, 13);
            this.LabReportsAspectRatio.TabIndex = 20;
            this.LabReportsAspectRatio.Text = "-";
            // 
            // LabReportsVideoResolution
            // 
            this.LabReportsVideoResolution.AutoSize = true;
            this.LabReportsVideoResolution.Location = new System.Drawing.Point(113, 276);
            this.LabReportsVideoResolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabReportsVideoResolution.Name = "LabReportsVideoResolution";
            this.LabReportsVideoResolution.Size = new System.Drawing.Size(10, 13);
            this.LabReportsVideoResolution.TabIndex = 19;
            this.LabReportsVideoResolution.Text = "-";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(34, 304);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 19);
            this.label17.TabIndex = 18;
            this.label17.Text = "Framerate:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(34, 290);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 19);
            this.label16.TabIndex = 17;
            this.label16.Text = "Aspect ratio:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(-4, 276);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 19);
            this.label15.TabIndex = 16;
            this.label15.Text = "Video resolution:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabReportsLastMessage
            // 
            this.LabReportsLastMessage.AutoSize = true;
            this.LabReportsLastMessage.Location = new System.Drawing.Point(113, 248);
            this.LabReportsLastMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabReportsLastMessage.Name = "LabReportsLastMessage";
            this.LabReportsLastMessage.Size = new System.Drawing.Size(10, 13);
            this.LabReportsLastMessage.TabIndex = 15;
            this.LabReportsLastMessage.Text = "-";
            // 
            // LabReportsCurrentFile
            // 
            this.LabReportsCurrentFile.AutoSize = true;
            this.LabReportsCurrentFile.Location = new System.Drawing.Point(113, 262);
            this.LabReportsCurrentFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabReportsCurrentFile.Name = "LabReportsCurrentFile";
            this.LabReportsCurrentFile.Size = new System.Drawing.Size(10, 13);
            this.LabReportsCurrentFile.TabIndex = 14;
            this.LabReportsCurrentFile.Text = "-";
            // 
            // LabReportsStatus
            // 
            this.LabReportsStatus.AutoSize = true;
            this.LabReportsStatus.Location = new System.Drawing.Point(113, 235);
            this.LabReportsStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabReportsStatus.Name = "LabReportsStatus";
            this.LabReportsStatus.Size = new System.Drawing.Size(10, 13);
            this.LabReportsStatus.TabIndex = 13;
            this.LabReportsStatus.Text = "-";
            // 
            // LabReportsPosition
            // 
            this.LabReportsPosition.AutoSize = true;
            this.LabReportsPosition.Location = new System.Drawing.Point(113, 387);
            this.LabReportsPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabReportsPosition.Name = "LabReportsPosition";
            this.LabReportsPosition.Size = new System.Drawing.Size(10, 13);
            this.LabReportsPosition.TabIndex = 12;
            this.LabReportsPosition.Text = "-";
            // 
            // progressBarCCE
            // 
            this.progressBarCCE.Location = new System.Drawing.Point(196, 427);
            this.progressBarCCE.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarCCE.Name = "progressBarCCE";
            this.progressBarCCE.Size = new System.Drawing.Size(315, 15);
            this.progressBarCCE.TabIndex = 11;
            this.progressBarCCE.Visible = false;
            // 
            // LabReportsCCExtractorVersion
            // 
            this.LabReportsCCExtractorVersion.AutoSize = true;
            this.LabReportsCCExtractorVersion.Location = new System.Drawing.Point(113, 221);
            this.LabReportsCCExtractorVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabReportsCCExtractorVersion.Name = "LabReportsCCExtractorVersion";
            this.LabReportsCCExtractorVersion.Size = new System.Drawing.Size(10, 13);
            this.LabReportsCCExtractorVersion.TabIndex = 9;
            this.LabReportsCCExtractorVersion.Text = "-";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(15, 262);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "Now processing:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(34, 248);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Last message:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(34, 235);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Status:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(2, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "CCExtractor version:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Activity";
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxActivity.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActivity.Location = new System.Drawing.Point(4, 19);
            this.textBoxActivity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxActivity.Multiline = true;
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxActivity.Size = new System.Drawing.Size(739, 178);
            this.textBoxActivity.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(686, 418);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(56, 24);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Start";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // LabReportsProgress
            // 
            this.LabReportsProgress.Location = new System.Drawing.Point(113, 374);
            this.LabReportsProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabReportsProgress.Name = "LabReportsProgress";
            this.LabReportsProgress.Size = new System.Drawing.Size(215, 19);
            this.LabReportsProgress.TabIndex = 10;
            this.LabReportsProgress.Text = "-";
            // 
            // textBoxCommandLine
            // 
            this.textBoxCommandLine.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCommandLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCommandLine.Location = new System.Drawing.Point(3, 515);
            this.textBoxCommandLine.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCommandLine.Multiline = true;
            this.textBoxCommandLine.Name = "textBoxCommandLine";
            this.textBoxCommandLine.ReadOnly = true;
            this.textBoxCommandLine.Size = new System.Drawing.Size(749, 64);
            this.textBoxCommandLine.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1, 500);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Command line";
            // 
            // folderBrowserDialogHDHomeRun
            // 
            this.folderBrowserDialogHDHomeRun.SelectedPath = "C:\\Program Files\\Silicondust\\HDHomeRun";
            this.folderBrowserDialogHDHomeRun.ShowNewFolderButton = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.rbBinaryVersionWithOCR);
            this.groupBox1.Controls.Add(this.rbBinaryVersionNoOCR);
            this.groupBox1.Location = new System.Drawing.Point(0, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CCExtractor binary version";
            // 
            // rbBinaryVersionNoOCR
            // 
            this.rbBinaryVersionNoOCR.AutoSize = true;
            this.rbBinaryVersionNoOCR.Checked = true;
            this.rbBinaryVersionNoOCR.Location = new System.Drawing.Point(8, 19);
            this.rbBinaryVersionNoOCR.Name = "rbBinaryVersionNoOCR";
            this.rbBinaryVersionNoOCR.Size = new System.Drawing.Size(340, 17);
            this.rbBinaryVersionNoOCR.TabIndex = 0;
            this.rbBinaryVersionNoOCR.TabStop = true;
            this.rbBinaryVersionNoOCR.Text = "Without OCR (no external dependencies, should work everywhere)";
            this.rbBinaryVersionNoOCR.UseVisualStyleBackColor = true;
            this.rbBinaryVersionNoOCR.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // rbBinaryVersionWithOCR
            // 
            this.rbBinaryVersionWithOCR.AutoSize = true;
            this.rbBinaryVersionWithOCR.Location = new System.Drawing.Point(370, 19);
            this.rbBinaryVersionWithOCR.Name = "rbBinaryVersionWithOCR";
            this.rbBinaryVersionWithOCR.Size = new System.Drawing.Size(344, 17);
            this.rbBinaryVersionWithOCR.TabIndex = 1;
            this.rbBinaryVersionWithOCR.Text = "With OCR (use if you need to convert bitmaps to text, such as DVB)";
            this.rbBinaryVersionWithOCR.UseVisualStyleBackColor = true;
            this.rbBinaryVersionWithOCR.CheckedChanged += new System.EventHandler(this.GenericCheckedChangedHandler);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 592);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.textBoxCommandLine);
            this.Controls.Add(this.tabControlMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(772, 631);
            this.MinimumSize = new System.Drawing.Size(772, 631);
            this.Name = "FormMain";
            this.Text = "CCExtractor GUI 0.84";
            this.Load += new System.EventHandler(this.FormMain_Load);
            tabPageDecoders.ResumeLayout(false);
            tabPageDecoders.PerformLayout();
            this.groupBoxTelext.ResumeLayout(false);
            this.groupBoxTelext.PerformLayout();
            this.groupBoxChannel.ResumeLayout(false);
            this.groupBoxChannel.PerformLayout();
            this.groupBoxField.ResumeLayout(false);
            this.groupBoxField.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageInput.ResumeLayout(false);
            this.tabPageInput.PerformLayout();
            this.tabPageInputOptions.ResumeLayout(false);
            this.groupBoxElementaryStream.ResumeLayout(false);
            this.groupBoxElementaryStream.PerformLayout();
            this.groupBoxScreenfulLimits.ResumeLayout(false);
            this.groupBoxScreenfulLimits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownScreenfuls)).EndInit();
            this.groupBoxEndOfProcessing.ResumeLayout(false);
            this.groupBoxEndOfProcessing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownEndSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownEndMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownEndHours)).EndInit();
            this.groupBoxStartOfProcessing.ResumeLayout(false);
            this.groupBoxStartOfProcessing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartHours)).EndInit();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnLiveTimeouts)).EndInit();
            this.groupBoxSplitType.ResumeLayout(false);
            this.groupBoxSplitType.PerformLayout();
            this.groupBoxInputType.ResumeLayout(false);
            this.groupBoxInputType.PerformLayout();
            this.tabPageAdvancedInputOptions.ResumeLayout(false);
            this.groupBoxAdvancedInputClock.ResumeLayout(false);
            this.groupBoxAdvancedInputClock.PerformLayout();
            this.groupBoxMultiprogramTS.ResumeLayout(false);
            this.groupBoxMultiprogramTS.PerformLayout();
            this.groupBoxAdvancedInputMisc.ResumeLayout(false);
            this.groupBoxAdvancedInputMisc.PerformLayout();
            this.groupBoxMythTV.ResumeLayout(false);
            this.groupBoxMythTV.PerformLayout();
            this.tabPageOutput.ResumeLayout(false);
            this.groupBoxXDS.ResumeLayout(false);
            this.groupBoxXDS.PerformLayout();
            this.bgBOM.ResumeLayout(false);
            this.bgBOM.PerformLayout();
            this.groupBoxTimeAdjust.ResumeLayout(false);
            this.groupBoxTimeAdjust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnDelay)).EndInit();
            this.groupBoxOutputFile.ResumeLayout(false);
            this.groupBoxOutputFile.PerformLayout();
            this.groupBoxOutputType.ResumeLayout(false);
            this.groupBoxOutputType.PerformLayout();
            this.tabPageOutput2.ResumeLayout(false);
            this.groupBoxLineTerminator.ResumeLayout(false);
            this.groupBoxLineTerminator.PerformLayout();
            this.groupBoxExportTypeset.ResumeLayout(false);
            this.groupBoxExportTypeset.PerformLayout();
            this.groupBoxRollup.ResumeLayout(false);
            this.groupBoxRollup.PerformLayout();
            this.groupBoxSentenceCase.ResumeLayout(false);
            this.groupBoxSentenceCase.PerformLayout();
            this.groupBoxTextPosition.ResumeLayout(false);
            this.groupBoxTextPosition.PerformLayout();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            this.groupBoxEncoding.ResumeLayout(false);
            this.groupBoxEncoding.PerformLayout();
            this.tabPageCredits.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxEndCredits.ResumeLayout(false);
            this.groupBoxEndCredits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownEndCreditsMaxDisplayedSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownEndCreditsMinDisplayedSS)).EndInit();
            this.groupBoxStartingCredits.ResumeLayout(false);
            this.groupBoxStartingCredits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsMaxDisplayedSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsMinDisplayedSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsNotAfterSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsNotAfterMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsNotBeforeSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownStartCreditsNotBeforeMM)).EndInit();
            this.tabPageDebug.ResumeLayout(false);
            this.tabPageDebug.PerformLayout();
            this.tabPageHDHomeRun.ResumeLayout(false);
            this.tabPageHDHomeRun.PerformLayout();
            this.tabPageExecution.ResumeLayout(false);
            this.tabPageExecution.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageInput;
        private System.Windows.Forms.TabPage tabPageOutput;
        private System.Windows.Forms.ListView listViewInputFiles;
        private System.Windows.Forms.Button butClearInputList;
        private System.Windows.Forms.TabPage tabPageInputOptions;
        private System.Windows.Forms.GroupBox groupBoxInputType;
        private System.Windows.Forms.RadioButton rbInputTypeAutodetect;
        private System.Windows.Forms.RadioButton rbInputTypeMcPoodleRaw;
        private System.Windows.Forms.RadioButton rbInputTypeDVRMS;
        private System.Windows.Forms.RadioButton rbInputTypeElementaryStreams;
        private System.Windows.Forms.RadioButton rbInputTypeProgramStreams;
        private System.Windows.Forms.RadioButton rbInputTypeTransportStreams;
        private System.Windows.Forms.GroupBox groupBoxSplitType;
        private System.Windows.Forms.RadioButton rbSplitGeneric;
        private System.Windows.Forms.RadioButton rbSplitVideoTool;
        private System.Windows.Forms.RadioButton rbSplitIndividual;
        private System.Windows.Forms.TabPage tabPageAdvancedInputOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxMythTV;
        private System.Windows.Forms.RadioButton rbMythTVAuto;
        private System.Windows.Forms.RadioButton rbMythTVDisabled;
        private System.Windows.Forms.RadioButton rbMythTVForced;
        private System.Windows.Forms.GroupBox groupBoxAdvancedInputMisc;
        private System.Windows.Forms.CheckBox cbClock90090;
        private System.Windows.Forms.CheckBox cbLargeGOPs;
        private System.Windows.Forms.CheckBox cbFixPadding;
        private System.Windows.Forms.GroupBox groupBoxOutputType;
        private System.Windows.Forms.RadioButton rbOutputTypeRaw;
        private System.Windows.Forms.RadioButton rbOutputTypeTXT;
        private System.Windows.Forms.RadioButton rbOutputTypeSAMI;
        private System.Windows.Forms.RadioButton rbOutputTypeSRT;
        private System.Windows.Forms.GroupBox groupBoxOutputFile;
        private System.Windows.Forms.RadioButton rbOutputNameAuto;
        private System.Windows.Forms.Button btnBrowseOutputFilename;
        private System.Windows.Forms.TextBox tbOutputFilename;
        private System.Windows.Forms.RadioButton rbOutputNameManual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbOutputTypeDVDRaw;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton rbModeLive;
        private System.Windows.Forms.RadioButton rbModeComplete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxStartOfProcessing;
        private System.Windows.Forms.GroupBox groupBoxEndOfProcessing;
        private System.Windows.Forms.NumericUpDown updownEndSeconds;
        private System.Windows.Forms.NumericUpDown updownEndMinutes;
        private System.Windows.Forms.NumericUpDown updownEndHours;
        private System.Windows.Forms.RadioButton rbProcessingEndToPoint;
        private System.Windows.Forms.RadioButton rbProcessingEndToFinish;
        private System.Windows.Forms.NumericUpDown updownStartSeconds;
        private System.Windows.Forms.NumericUpDown updownStartMinutes;
        private System.Windows.Forms.NumericUpDown updownStartHours;
        private System.Windows.Forms.RadioButton rbProcessingStartFromPoint;
        private System.Windows.Forms.RadioButton rbProcessingStartFromBeginning;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.GroupBox groupBoxScreenfulLimits;
        private System.Windows.Forms.NumericUpDown updownScreenfuls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbScreenfulsStopAfter;
        private System.Windows.Forms.RadioButton rbScreenfulsNoLimit;
        private System.Windows.Forms.CheckBox cbDebugTraces708;
        private System.Windows.Forms.CheckBox cbDebugTraces608;
        private System.Windows.Forms.CheckBox cbDebugInterestingPackets;
        private System.Windows.Forms.Button btnBrowseElementaryStreamFilename;
        private System.Windows.Forms.TextBox tbElementaryStreamFilename;
        private System.Windows.Forms.CheckBox cbDebugWriteES;
        private System.Windows.Forms.CheckBox cbDebugContainer;
        private System.Windows.Forms.CheckBox cbDebugRaw608_708wTimestamps;
        private System.Windows.Forms.CheckBox cbDebugESAnalysis;
        private System.Windows.Forms.CheckBox cbDebugTimestamps;
        private System.Windows.Forms.TabPage tabPageOutput2;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.GroupBox groupBoxEncoding;
        private System.Windows.Forms.RadioButton rbEncodingUnicode;
        private System.Windows.Forms.RadioButton rbEncodingUTF8;
        private System.Windows.Forms.RadioButton rbEncodingLatin1;
        private System.Windows.Forms.RadioButton rbColorsReplace;
        private System.Windows.Forms.RadioButton rbColorsDefault;
        private System.Windows.Forms.RadioButton rbColorsDisable;
        private System.Windows.Forms.GroupBox groupBoxTextPosition;
        private System.Windows.Forms.RadioButton rbTextPositionCenter;
        private System.Windows.Forms.RadioButton rbTextPositionOriginal;
        private System.Windows.Forms.GroupBox groupBoxSentenceCase;
        private System.Windows.Forms.RadioButton rbSentenceCaseNone;
        private System.Windows.Forms.Button btnBrowseCapitalizationWords;
        private System.Windows.Forms.TextBox tbCapitalizationWordsFilename;
        private System.Windows.Forms.CheckBox cbSentenceCaseExtraList;
        private System.Windows.Forms.RadioButton rbSentenceCaseDefault;
        private System.Windows.Forms.GroupBox groupBoxRollup;
        private System.Windows.Forms.CheckBox cbRollupNoDupeLines;
        private System.Windows.Forms.CheckBox cbRollupRealtime;
        private System.Windows.Forms.GroupBox groupBoxTimeAdjust;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown upDwnDelay;
        private System.Windows.Forms.TabPage tabPageExecution;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox textBoxActivity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabReportsCCExtractorVersion;
        private System.Windows.Forms.Label LabReportsProgress;
        private System.Windows.Forms.ProgressBar progressBarCCE;
        private System.Windows.Forms.Label LabReportsPosition;
        private System.Windows.Forms.Label LabReportsStatus;
        private System.Windows.Forms.Label LabReportsCurrentFile;
        private System.Windows.Forms.Label LabReportsLastMessage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LabReportsAspectRatio;
        private System.Windows.Forms.Label LabReportsVideoResolution;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LabReportsFramerate;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSaveAsDefault;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown upDwnLiveTimeouts;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutput;
        private System.Windows.Forms.SaveFileDialog saveFileDialogElementaryStream;
        private System.Windows.Forms.TextBox tbDecoderColor;
        private System.Windows.Forms.OpenFileDialog openFileDialogWordsList;
        private System.Windows.Forms.Button butRestoreDefault;
        private System.Windows.Forms.RadioButton rbInputTypeBin;
        private System.Windows.Forms.RadioButton rbOutputTypeBin;
        private System.Windows.Forms.CheckBox cbFullbin;
        private System.Windows.Forms.CheckBox cbNosync;
        private System.Windows.Forms.TabPage tabPageCredits;
        private System.Windows.Forms.GroupBox groupBoxStartingCredits;
        private System.Windows.Forms.TextBox tbStartCredits;
        private System.Windows.Forms.CheckBox cbWriteStartingText;
        private System.Windows.Forms.CheckBox cbbStartCreditsNotBeforeThan;
        private System.Windows.Forms.NumericUpDown updownStartCreditsNotBeforeSS;
        private System.Windows.Forms.NumericUpDown updownStartCreditsNotBeforeMM;
        private System.Windows.Forms.NumericUpDown updownStartCreditsNotAfterSS;
        private System.Windows.Forms.NumericUpDown updownStartCreditsNotAfterMM;
        private System.Windows.Forms.CheckBox cbbStartCreditsNotLaterThan;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown updownStartCreditsMaxDisplayedSS;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown updownStartCreditsMinDisplayedSS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBoxEndCredits;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown updownEndCreditsMaxDisplayedSS;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown updownEndCreditsMinDisplayedSS;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbEndCredits;
        private System.Windows.Forms.CheckBox cbWriteEndText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox cbWTVConversionFix;
        private System.Windows.Forms.CheckBox cbHauppage;
        private System.Windows.Forms.GroupBox groupBoxMultiprogramTS;
        private System.Windows.Forms.TextBox tbProgramNumber;
        private System.Windows.Forms.CheckBox cb_use_pic_order_cnt;
        private System.Windows.Forms.RadioButton rbOutputTypeTimedTXT;
        private System.Windows.Forms.GroupBox groupBoxExportTypeset;
        private System.Windows.Forms.RadioButton rbDontExportTypesetting;
        private System.Windows.Forms.RadioButton rbExportTypesetting;
        private System.Windows.Forms.Label LABReportsXDSProgramName;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox cbDebugXDS;
        private System.Windows.Forms.Label LABReportsXDSNetworkCallLetters;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label LABReportsXDSProgramID;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.RadioButton rbOutputTypeNull;
        private System.Windows.Forms.RadioButton rbInputTypeMP4;
        private System.Windows.Forms.CheckBox cb_mp4vidtrack;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxChannel;
        private System.Windows.Forms.RadioButton rbChannel2;
        private System.Windows.Forms.RadioButton rbChannel1;
        private System.Windows.Forms.GroupBox groupBoxField;
        private System.Windows.Forms.CheckBox cbField2;
        private System.Windows.Forms.CheckBox cbField1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txt708Services;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.CheckBox cbEnable708Decoder;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBoxCommandLine;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RadioButton rbInputTypeWTV;
        private System.Windows.Forms.RadioButton rbInputTypeHexDump;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtTeletextPID;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.RadioButton rbRollUpLinesLimit2;
        private System.Windows.Forms.RadioButton rbRollUpLinesLimit3;
        private System.Windows.Forms.RadioButton rbRollUpLinesLimitNone;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox groupBoxAdvancedInputClock;
        private System.Windows.Forms.RadioButton rbClockPTS;
        private System.Windows.Forms.RadioButton rbClockGOP;
        private System.Windows.Forms.RadioButton rbClockAuto;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBoxTelext;
        private System.Windows.Forms.RadioButton rbTeletextForce;
        private System.Windows.Forms.RadioButton rbTeletextDisable;
        private System.Windows.Forms.RadioButton rbTeletextAuto;
        private System.Windows.Forms.TextBox txtTeletextPage;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.RadioButton rbOutputTypeTTML;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox tbUTPListenPort;
        private System.Windows.Forms.RadioButton rbInputUTP;
        private System.Windows.Forms.GroupBox groupBoxElementaryStream;
        private System.Windows.Forms.RadioButton rbElementaryStreamSelectType;
        private System.Windows.Forms.TextBox tbElementaryStreamPID;
        private System.Windows.Forms.RadioButton rbElementaryStreamFixedStreamNumber;
        private System.Windows.Forms.RadioButton rbElementaryStreamAuto;
        private System.Windows.Forms.TextBox tbElementaryDataStreamType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbElementaryStreamType;
        private System.Windows.Forms.CheckBox cbDebugPMT;
        private System.Windows.Forms.CheckBox cbDebugPAT;
        private System.Windows.Forms.CheckBox cbDebugAnalyzePackets;
        private System.Windows.Forms.RadioButton rbMultiProgramTSAutoDetect;
        private System.Windows.Forms.RadioButton rbMultiProgramTSSelect;
        private System.Windows.Forms.GroupBox groupBoxLineTerminator;
        private System.Windows.Forms.RadioButton rbLineTerminatorUNIX;
        private System.Windows.Forms.RadioButton rbLineTerminatorDOS;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtlevdistmincnt;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txtlevdistmaxpct;
        private System.Windows.Forms.CheckBox cbDebugLevDistance;
        private System.Windows.Forms.CheckBox cbAutoDash;
        private System.Windows.Forms.RadioButton rbRollUpLinesLimit1;
        private System.Windows.Forms.RadioButton rbOutputTypeSpuPNG;
        private System.Windows.Forms.TabPage tabPageHDHomeRun;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogHDHomeRun;
        private System.Windows.Forms.Button butHDHomeRunDir;
        private System.Windows.Forms.TextBox tbHDHomeRunPath;
        private System.Windows.Forms.Button butFindTuners;
        private System.Windows.Forms.ListBox listBoxTuners;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ProgressBar progressBarActivity;
        private System.Windows.Forms.RadioButton rbOutputTypeReport;
        private System.Windows.Forms.GroupBox bgBOM;
        private System.Windows.Forms.RadioButton rbBOMNo;
        private System.Windows.Forms.RadioButton rbBOMYes;
        private System.Windows.Forms.RadioButton rbPreferDVB;
        private System.Windows.Forms.GroupBox groupBoxXDS;
        private System.Windows.Forms.CheckBox cbExportXDS;
        private System.Windows.Forms.RadioButton rbInputTypeM2TS;
        private System.Windows.Forms.RadioButton rbOutputTypeSimpleXML;
        private System.Windows.Forms.RadioButton rbOutputTypeG608;
        private System.Windows.Forms.CheckBox cb_ignore_scte20;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBinaryVersionWithOCR;
        private System.Windows.Forms.RadioButton rbBinaryVersionNoOCR;
    }
}

