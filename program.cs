

using System.Runtime.InteropServices;

namespace ChangeBackground
{
    class backgroundChanger
    {
        // Used to set wallpaper
        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPIF_UPDATEINFILE = 1;
        public const int SPIF_SENDCHANGE = 2;


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        static void Main(String[] args) 
        {
            Random random = new Random();
            int index = random.Next(0, 5);
            String[] imageNames = { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg" };
            String imagePath = @"C:\users\shaun\Desktop\Backgrounds\" + imageNames[index];

            // Set wallpaper
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imagePath, SPIF_UPDATEINFILE | SPIF_SENDCHANGE);
        }
    }
}
