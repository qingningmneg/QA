using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Taskbar;

namespace QA
{
    static class Program
    {
        public static string user_guid = "";
        public static string FrmTeachUserEditPosition_guid = "";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if NET5_0_OR_GREATER
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new winfrom.FrmUserLogin());


            //����ǰ̨�߳�
            ////BackGroundTest background = new BackGroundTest(10);
            //Thread fThread = new Thread(new ThreadStart(background.RunLoop));
            ////���߳�����
            //fThread.Name = "ǰ̨�߳�";
        }
    }
}
