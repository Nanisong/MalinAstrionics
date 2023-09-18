using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                if (!string.IsNullOrEmpty(TextBoxObserved.Text) && !string.IsNullOrEmpty(TextBoxRest.Text))
                {
                    double observed = double.Parse(TextBoxObserved.Text);
                    double rest = double.Parse(TextBoxRest.Text);
                    velocity = pipeProxy.GetStarVelocity(observed, rest).ToString("F2"); //Keep 2 digits after decimal point
                }
                if (!string.IsNullOrEmpty(TextBoxParaAngle.Text))
                {
                    double angle = double.Parse(TextBoxParaAngle.Text);
                    distance = pipeProxy.GetStarDistance(angle).ToString("F4"); //Keep 4 digits after decimal point
                }
                if (!string.IsNullOrEmpty(TextBoxCelsius.Text))
                {
                    double celsius = double.Parse(UpDownPlusMinus.Text + TextBoxCelsius.Text);
                    kelvin = pipeProxy.GetTempKelvin(celsius).ToString();
                }
                if (!string.IsNullOrEmpty(TextBoxMass.Text))
                {
                    double mass = double.Parse(TextBoxMass.Text + "E" + UpDownNotation.Value.ToString());
                    horizon = pipeProxy.GetSchRadius(mass).ToString("E1");  // kepp 1 decimal place
                }
                string[] row = { distance, kelvin, horizon };
                ListViewResults.Items.Add(velocity.ToString()).SubItems.AddRange(row);
                ResetInputs();  //ResetInputs
            }
            catch (ActionNotSupportedException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (AddressAlreadyInUseException ex)
            {   
                Trace.WriteLine(ex.Message);
            }
            catch (AddressAccessDeniedException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (System.ServiceModel.Channels.RedirectionException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (System.ServiceModel.Channels.RetryException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (System.ServiceModel.ChannelTerminatedException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (CommunicationObjectFaultedException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (CommunicationObjectAbortedException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (System.ServiceModel.Dispatcher.MessageFilterException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (EndpointNotFoundException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (System.ServiceModel.FaultException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (System.ServiceModel.PoisonMessageException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (System.ServiceModel.Security.MessageSecurityException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (ProtocolException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (System.ServiceModel.Security.SecurityAccessDeniedException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (System.ServiceModel.Security.SecurityNegotiationException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (System.ServiceModel.ServiceActivationException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (CommunicationException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
        //Reset Inputs
        private void ResetInputs()
        { 
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
                e.Handled = true;
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
                res = false;

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


    }
}
