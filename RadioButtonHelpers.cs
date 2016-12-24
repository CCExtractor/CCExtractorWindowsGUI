using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CCExtractorGUI
{
    public partial class FormMain : Form
    {
        #region InputType
        private RadioButton getInputTypeRadioButton(String type)
        {
            switch (type)
            {
                case "ts":
                    return rbInputTypeTransportStreams;
                case "ps":
                    return rbInputTypeProgramStreams;
                case "es":
                    return rbInputTypeElementaryStreams;
                case "asf":
                    return rbInputTypeDVRMS;
                case "raw":
                    return rbInputTypeMcPoodleRaw;
                case "bin":
                    return rbInputTypeBin;    
                default:
                    return rbInputTypeAutodetect;
            }
        }

        private string getInputTypeString()
        {
            if (rbInputTypeTransportStreams.Checked)
                return "ts";
            if (rbInputTypeProgramStreams.Checked)
                return "ps";
            if (rbInputTypeElementaryStreams.Checked)
                return "es";
            if (rbInputTypeDVRMS.Checked)
                return "asf";
            if (rbInputTypeMcPoodleRaw.Checked)
                return "raw";
            if (rbInputTypeBin.Checked)
                return "bin";
            if (rbInputTypeMP4.Checked)
                return "mp4";
            if (rbInputTypeWTV.Checked)
                return "wtv";
            if (rbInputTypeM2TS.Checked)
                return "m2ts";
            return "auto";
        }
        #endregion
        #region splittype
        private string getSplitString()
        {
            if (rbSplitIndividual.Checked)
                return "individual";
            if (rbSplitVideoTool.Checked)
                return "videotool";
            return "generic";
        }

        private RadioButton getSplitRadioButton(string type)
        {
            switch (type)
            {
                case "individual":
                    return rbSplitIndividual;
                case "videotool":
                    return rbSplitVideoTool;
                default:
                    return rbSplitGeneric;
            }
        }
        #endregion
        #region mythtv
        private string getMythTVString()
        {
            if (rbMythTVForced.Checked)
                return "forced";
            if (rbMythTVDisabled.Checked)
                return "disabled";
            return "auto";
        }

        private RadioButton getMythTVRadioButton(string type)
        {
            switch (type)
            {
                case "forced":
                    return rbMythTVForced;
                case "disabled":
                    return rbMythTVDisabled;
                default:
                    return rbMythTVAuto;
            }
        }
        #endregion
        #region OutputType
        private RadioButton getOutputTypeRadioButton(String type)
        {
            switch (type)
            {
                case "sami":
                    return rbOutputTypeSAMI;
                case "raw":
                    return rbOutputTypeRaw;
                case "txt":
                    return rbOutputTypeTXT;
                case "dvdraw":
                    return rbOutputTypeDVDRaw;
                case "bin":
                    return rbOutputTypeBin;
                case "ttml":
                    return rbOutputTypeTTML;
                case "ttxt":
                    return rbOutputTypeTimedTXT;
                case "null":
                    return rbOutputTypeNull;
                case "g608":
                    return rbOutputTypeG608;
                case "spupng":
                    return rbOutputTypeSpuPNG;
                case "simplexml":
                    return rbOutputTypeSimpleXML;
                case "report":
                    return rbOutputTypeReport;
                case "ass":
                    return rbOutputTypeASS;
                default:
                    return rbOutputTypeSRT;
            }
        }

        private string getOutputTypeString()
        {
            if (rbOutputTypeSAMI.Checked)
                return "sami";
            if (rbOutputTypeRaw.Checked)
                return "raw";
            if (rbOutputTypeTXT.Checked)
                return "txt";
            if (rbOutputTypeDVDRaw.Checked)
                return "dvdraw";
            if (rbOutputTypeBin.Checked)
                return "bin";
            if (rbOutputTypeSRT.Checked)
                return "srt";
            if (rbOutputTypeTTML.Checked)
                return "ttml";
            if (rbOutputTypeTimedTXT.Checked)
                return "ttxt";
            if (rbOutputTypeNull.Checked)
                return "null";
            if (rbOutputTypeG608.Checked)
                return "g608";
            if (rbOutputTypeSpuPNG.Checked)
                return "spupng";
            if (rbOutputTypeSimpleXML.Checked)
                return "simplexml";
            if (rbOutputTypeReport.Checked)
                return "report";
            if (rbOutputTypeASS.Checked)
                return "ass";
            return "srt";
        }
        #endregion
#region Encoding
        private string getEncodingString()
        {
            if (rbEncodingUnicode.Checked)
                return "unicode";
            if (rbEncodingUTF8.Checked)
                return "utf8";
            return "latin1";
        }

        private RadioButton getEncodingRadioButton(string type)
        {
            switch (type)
            {
                case "utf8":
                    return rbEncodingUTF8;
                case "unicode":
                    return rbEncodingUnicode;
                default:
                    return rbEncodingLatin1;
            }
        }
#endregion

        #region Colors
        private string getColorString()
        {
            if (rbColorsDisable.Checked)
                return "disabled";
            if (rbColorsReplace.Checked)
                return "replace";
            return "default";
        }

        private RadioButton getColorsRadioButton(string type)
        {
            switch (type)
            {
                case "disabled":
                    return rbColorsDisable;
                case "replace":
                    return rbColorsReplace;
                default:
                    return rbColorsDefault;
            }
        }
        #endregion        

    }
}
