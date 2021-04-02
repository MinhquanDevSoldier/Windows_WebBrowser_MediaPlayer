using System;
using EasyTabs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_GiuaKy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            AppContainer appContainer = new AppContainer();
            appContainer.Tabs.Add(new EasyTabs.TitleBarTab(appContainer)
            {
                Content = new Form1
                {
                    Text = "Cửa sổ mới"
                }

            });
            appContainer.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext titleBarTabsApplication = new TitleBarTabsApplicationContext();
            titleBarTabsApplication.Start(appContainer);
            Application.Run(titleBarTabsApplication);
            

        }
    }
}
