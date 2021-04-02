using EasyTabs;
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
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            Icon = Properties.Resources.icon4;
        }
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1 { Text = "Cửa sổ mới" }
            };
        }
    }
}
