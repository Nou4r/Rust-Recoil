using System;
using System.Threading;
using System.Windows.Forms;

namespace Recoil
{
    static class Program
    {
        public static bool g_enabled = false;
        public static bool g_humanization = false;

        public static float g_sensitivity = 0.42F;
        public static float g_field_of_view = 90.0F;

        public static WeaponIndex g_weapon_index;

        public static Barrel g_barrel = Barrel.None;
        public static Sight g_sight = Sight.None;

        [STAThread]
        static void Main()
        {
            Timer.QueryFrequency();

            g_weapon_index = WeaponIndex.AR;

            Thread mouse_thread = new Thread(MouseListener.Listen);
            mouse_thread.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
