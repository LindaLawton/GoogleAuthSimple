using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace GoogleAuthWinForm
{
    public partial class Auth : Form
    {

        public const string clientId = "1046123799103-d0vpdthl4ms0soutcrpe036ckqn7rfpn.apps.googleusercontent.com";
        public const string clientSecret = "NDmluNfTgUk6wgmy7cFo64RV";
        public const string redirectURI = "urn:ietf:wg:oauth:2.0:oob";

        public AuthResponse access;

        public Auth()
        {
            InitializeComponent();

            //Display the authenticationRequest to the user.
            webBrowser1.Navigate(AuthResponse.GetAutenticationURI(clientId, redirectURI));
        }       


        /// <summary>
        /// The authentication code is returned in the webbrowser.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string Mytitle = ((WebBrowser)sender).DocumentTitle.ToLower();
            if (Mytitle.IndexOf("success code=") > -1)
            {
                webBrowser1.Visible = false;

                // searching the body for our code
                string AuthCode = webBrowser1.DocumentTitle.Replace("Success code=", "");
                string webText = ((WebBrowser)sender).DocumentText;
                int start = webText.IndexOf("id=\"code\"");
                start = webText.IndexOf(AuthCode, start);
                int end = webText.IndexOf('"', start);
                string authCode = webText.Substring(start, end - start);

                //Exchange the code for Access token and refreshtoken.
                access = AuthResponse.Exchange(authCode, clientId, clientSecret, redirectURI);

                processAccess();
            }
        }

        public void processAccess()
        {
            if (access.Access_token != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }






}
