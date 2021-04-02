using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_GiuaKy
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser WVNWebBrowser;
        public Form1()
        {
            InitializeComponent();
            WVNWebBrowser = new ChromiumWebBrowser("http://google.com");
            WVNWebBrowser.AddressChanged += WVNWebBrowser_AddressChanged;
        }

        private void WVNWebBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            txtAdress.Text = WVNWebBrowser.Address;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(WVNWebBrowser.CanGoBack)
            {
                WVNWebBrowser.Back();
            }
        }

        private void txtAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            String link = txtAdress.Text;
            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(Kiem_Tra_Cau_Truc(txtAdress.Text))
                {
                    txtAdress.Text = Chuyen_doi(txtAdress.Text);
                    WVNWebBrowser.Load(txtAdress.Text);
                }
                else
                {
                    link = "https://www.google.com/search?q=" +
                        txtAdress.Text +
                        "&hl=vi&sxsrf=ALeKk02b_jsjH6Qp399Bewybfr2Mlb3MKg%3A1616121721435&ei" +
                        "=eQ9UYL6AGo770gTF35_4DQ&oq=minh+quan&gs_lcp=Cgdnd3Mtd2l6EAMYADIICAA" +
                        "QxwEQrwEyAggAMggIABDHARCvATICCAA6BAgjECc6BAgAEEM6BggjECcQEzoECC4QQzo" +
                        "HCAAQsQMQQzoCCC46BwgjEOoCECc6CQgjEOoCECcQEzoICAAQsQMQgwE6BQguELEDOgUI" +
                        "ABCxA1DSJlicR2CsTWgFcAB4AIABkgGIAbsOkgEEMC4xNZgBAKABAaoBB2d3cy13aXqwAQ" +
                        "rAAQE&sclient=gws-wiz";
                    WVNWebBrowser.Load(link);
                    txtAdress.Text = link;
                }
                
            }
        }
        public String Chuyen_doi(string link)
        {
            string[] linkarr = new string[link.Length];
            Char ch;
            String chuoichuyendoi= "";
            for (int i = 0; i < link.Length; i++)
            {
                ch = link[i];
                if (Char.IsUpper(ch))
                {
                    linkarr[i] = Char.ToLower(ch).ToString();
                }
                else
                {
                    linkarr[i] = ch.ToString();
                }
                chuoichuyendoi += linkarr[i];
            }
            return chuoichuyendoi;
        }
        public bool Kiem_Tra_Cau_Truc(String link)
        {
            link = Chuyen_doi(link);
            for (int i = 0; i < link.Length-3; i++)
            {
                if(link[i] == '.')
                {
                    if (link[i + 1] == 'c')
                    {
                        if (link[i + 2] == 'o')
                        {
                            if (link[i + 3] == 'm')
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            pnWeb.Size = new Size(this.Width, this.Height-40);
            //WVNWebBrowser.Size = new Size(pnWeb.Width, pnWeb.Height);
            txtAdress.Size = new Size(pnWeb.Width - 160,txtAdress.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WVNWebBrowser.Stop();
            WVNWebBrowser.Reload();
            //txtAdress.Text = WVNWebBrowser.Address;
        }

        private void btnGo_Click_1(object sender, EventArgs e)
        {
            if(WVNWebBrowser.CanGoForward)
            {
                WVNWebBrowser.Forward();
                //txtAdress.Text = WVNWebBrowser.Address;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WVNWebBrowser = new ChromiumWebBrowser("www.google.com");
            WVNWebBrowser.Dock = DockStyle.Fill;
            pnWeb.Controls.Add(WVNWebBrowser);
            //txtAdress.Text = WVNWebBrowser.Address;
            pnWeb.Size = new Size(this.Width, this.Height-40);
        }

        private void txtAdress_Click(object sender, EventArgs e)
        {
            txtAdress.BackColor = Color.White;
        }

        private void txtAdress_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdress.BackColor = Color.White;
            txtAdress.SelectAll();
        }

        private void txtAdress_MouseMove(object sender, MouseEventArgs e)
        {
            //txtAdress.BackColor = Color.WhiteSmoke;
        }

        private void txtAdress_Leave(object sender, EventArgs e)
        {
            txtAdress.BackColor = Color.WhiteSmoke;
        }

        private void pnWeb_ControlAdded(object sender, ControlEventArgs e)
        {
            txtAdress.Text = WVNWebBrowser.Address;
        }

        private void txtAdress_Enter(object sender, EventArgs e)
        {

        }
    }
}
