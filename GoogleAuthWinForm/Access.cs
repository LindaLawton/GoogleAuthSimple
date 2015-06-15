using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GoogleAuthWinForm
{
    public partial class Access : Form
    {
        public Access()
        {
            InitializeComponent();

            AccessToken.Text = "";
            refreshToken.Text = "";
            Expire.Text = "";
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            Auth m = new Auth();
            var result = m.ShowDialog();

            if (result == DialogResult.OK)
            {
                AccessToken.Text = m.access.Access_token;
                refreshToken.Text = m.access.refresh_token;

                if (DateTime.Now < m.access.created.AddHours(1))
                {
                    Expire.Text = m.access.created.AddHours(1).Subtract(DateTime.Now).Minutes.ToString();
                }
            }


        }


    }
}
