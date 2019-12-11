using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace messengerApplication
{

    static class Program
    {
        public static ClientSystem clientSystem;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitMaterial();
            clientSystem = new ClientSystem();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Если есть сохранённый аккаунт

            Application.Run(new authWindow(Properties.Settings.Default.SavedAccount));
        }

        static void InitMaterial()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.LightBlue900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);
        }
    }
}
