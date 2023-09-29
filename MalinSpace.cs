using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

//Author: Lan Song ID:30072745 26/9/2023 Murdoch
namespace MalinAstrionics
{
    public partial class MalinSpace : Form
    {
        public MalinSpace()
        {
            InitializeComponent();
            //TraceInformation
            string timeNow = DateTime.Now.ToString();
            //Start Trace with empty new line
            Trace.WriteLine(Environment.NewLine);
            Trace.TraceInformation(timeNow + " MalinClient loaded.");
        }
        #region Main Events
        private void ButtonVelocity_Click(object sender, EventArgs e)
        {
            try
            {
                //Address, Binding, Contract
                ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(
                new NetNamedPipeBinding(),
                new EndpointAddress("net.pipe://localhost/SpaceServer1"));
                IAstroContract pipeProxy = pipeFactory.CreateChannel();

                string velocity = "";
                string distance = "";
                string kelvin = "";
                string horizon = "";
                if (IsValidMayEmptyCelsius())
                {
                    //Redo 
                    if (string.IsNullOrEmpty(TextBoxObserved.Text) && string.IsNullOrEmpty(distance)
                       && string.IsNullOrEmpty(kelvin) && string.IsNullOrEmpty(horizon))
                    {
                        SetMessage("NO Input.", "warning");
                    }
                    else
                    {
                        //Calculate Star velocity
                        if (!string.IsNullOrEmpty(TextBoxObserved.Text) && !string.IsNullOrEmpty(TextBoxRest.Text))
                        {
                            double observed = double.Parse(TextBoxObserved.Text);
                            double rest = double.Parse(TextBoxRest.Text);
                            velocity = pipeProxy.GetStarVelocity(observed, rest).ToString("F2"); //Keep 2 digits after decimal point
                        }
                        //Calculate Star distance
                        if (!string.IsNullOrEmpty(TextBoxParaAngle.Text))
                        {
                            double angle = double.Parse(TextBoxParaAngle.Text);
                            distance = pipeProxy.GetStarDistance(angle).ToString("F4"); //Keep 4 digits after decimal point
                        }
                        //Celcius to Kelvin
                        if (!string.IsNullOrEmpty(TextBoxMass.Text))
                        {
                            double celsius = double.Parse(UpDownPlusMinus.Text + TextBoxCelsius.Text);
                            kelvin = pipeProxy.GetTempKelvin(celsius).ToString();
                        }
                        //Calculate Event horizon
                        if (!string.IsNullOrEmpty(TextBoxMass.Text))
                        {
                            double mass = double.Parse(TextBoxMass.Text + "E" + UpDownNotation.Value.ToString());
                            horizon = pipeProxy.GetSchRadius(mass).ToString("E1");  // kepp 1 decimal place
                        }
                        //Populate the results in ListView
                        string[] row = { distance, kelvin, horizon };   //Prepare row with results
                        ListViewResults.Items.Add(velocity.ToString()).SubItems.AddRange(row);  //Add the row to listView
                        ResetInputs();  //ResetInputs
                    }
                }
            }
            //Catch all the exceptions with communication errors.
            catch (ActionNotSupportedException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (AddressAlreadyInUseException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (AddressAccessDeniedException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (System.ServiceModel.Channels.RedirectionException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (System.ServiceModel.Channels.RetryException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (System.ServiceModel.ChannelTerminatedException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (CommunicationObjectFaultedException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (CommunicationObjectAbortedException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (System.ServiceModel.Dispatcher.MessageFilterException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (EndpointNotFoundException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (System.ServiceModel.FaultException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (System.ServiceModel.PoisonMessageException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (System.ServiceModel.Security.MessageSecurityException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (ProtocolException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (System.ServiceModel.Security.SecurityAccessDeniedException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (System.ServiceModel.Security.SecurityNegotiationException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (System.ServiceModel.ServiceActivationException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (CommunicationException ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                SetMessage(GetExceptionMessage(ex), "error");
            }
        }
        private string GetExceptionMessage(Exception ex)
        { // Get the first 60 characters of the exception message
            string message = ex.Message.Substring(0, 60);
            // Append the ellipsis and the instruction to check the trace file
            message += "…(Check TraceFile.)"; 
            // Return the message
            return message;
        }
        private bool IsValidMayEmptyCelsius()
        {
            if (!string.IsNullOrEmpty(TextBoxCelsius.Text))
            {   //Temperature is Celsius (C) = a value must be greater than -273.
                if (double.Parse(UpDownPlusMinus.Text + TextBoxCelsius.Text) < -273)
                {
                    SetMessage("Invalid temperature.", "error");
                    return false;
                }
                else
                { 
                    return true; 
                }
            }
            else
            { return true; }
        }
        private void ResetInputs()
        {   //Reset Inputs
            TextBoxObserved.Clear();
            TextBoxRest.Clear();
            TextBoxCelsius.Clear();
            TextBoxMass.Clear();
            TextBoxParaAngle.Clear();
            UpDownNotation.Value = 1;
            UpDownPlusMinus.Text = "-";
        }
        private void TextBoxObserved_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((Control)sender).Text;
            if (!IsNumber(e.KeyChar, text))
            {
                e.Handled = true;
            }
        }
        private bool IsNumber(char ch, string text)
        {
            bool res = true;
            char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            //check if it´s a decimal separator and if doesn´t already have one in the text string
            if (ch == decimalChar && text.IndexOf(decimalChar) != -1)
            {
                res = false;
                return res;
            }
            //check if it´s a digit, decimal separator and backspace
            if (!Char.IsDigit(ch) && ch != decimalChar && ch != (char)Keys.Back)
            {
                res = false;
            }
            return res;
        }
        private void MalinSpace_Load(object sender, EventArgs e)
        {
            //Set the minus as a default value in Celsius
            UpDownPlusMinus.SelectedIndex = 1;
        }
        private void ButtonUK_Click(object sender, EventArgs e)
        {
            //Get the buttons (UK, French, German) name 
            string flagName = ((Control)sender).Name;
                switch (flagName)
                {
                    case "ButtonUK":
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
                        break;
                    case "ButtonFrench":
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
                        break;
                    case "ButtonGerman":
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
                        break;
                }
                Controls.Clear();
                InitializeComponent();
        }
        #endregion

        #region StatusBar Message
        /// <summary>
        /// Set StatusBar Message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mode">Default error:Red info:Blue warning:Yellow</param>
        private void SetMessage(string message, string mode)
        {
            toolStripStatusInfo.Text = message;
            //Defult colour: Red for error
            System.Drawing.Color color = System.Drawing.Color.FromArgb(245, 66, 87);
            if (mode == "info")
            {   //Blue
                color = System.Drawing.Color.FromArgb(66, 164, 245);
            }
            else if (mode == "warning")
            {   //Orange
                color = System.Drawing.Color.FromArgb(237, 152, 5);
            }
            //Set back color
            toolStripStatusInfo.BackColor = color;
            //Call timer
            StatusbarTimer();
        }
        private void StatusbarTimer()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            int interval = 5000;
            timer.Interval = interval;
            timer.Tick += OnTickEvent; // Add an event handler
            timer.Start(); // Start the timer 
        }
        private void OnTickEvent(object sender, EventArgs e)
        {
            toolStripStatusInfo.Text = string.Empty;
            toolStripStatusInfo.Text = string.Empty;
            // Get the timer object
            System.Windows.Forms.Timer timer = sender as System.Windows.Forms.Timer;
            // Stop the timer
            timer.Stop();
            // Dispose the timer
            timer.Dispose();
        }
        #endregion

        #region Day, Night and Original mode
        private void DayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
            BackColor = Color.LightGray;
            ForeColor = Color.FromArgb(25, 42, 86);
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                groupBox.ForeColor = Color.FromArgb(25, 42, 86);   //Blue
            }
            ListViewResults.BackColor = Color.FromArgb(247, 241, 227);
        }
        private void NightToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            this.ForeColor = Color.FromArgb(245, 246, 250);
            this.BackColor = Color.FromArgb(47, 54, 64);
            
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                groupBox.ForeColor = Color.FromArgb(72, 52, 212);   //Blue
            }
            ListViewResults.BackColor = Color.FromArgb(164, 176, 190);
        }
        private void OriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ForeColor = default(Color);
            this.BackColor = default(Color);
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                groupBox.ForeColor = default(Color);
            }
            ListViewResults.BackColor = default(Color);
        }
        private void ColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDlg.Color;
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                ForeColor = Color.FromArgb(r, g, b);
                foreach (var textBox in Controls.OfType<TextBox>())
                {
                    textBox.ForeColor = Color.FromArgb(r, g, b);
                }
            }
        }
        #endregion
    }
}
