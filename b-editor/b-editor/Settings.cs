using Microsoft.Win32;
using System.IO;

namespace b_editor
{
    public class Settings
    {
        public string savePath = "";

        private Settings() {}

        public static Settings Load()
        {
            Settings settings = new Settings();

            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"b-editor");

                if (rk != null)
                {
                    settings.savePath = (string)rk.GetValue("savePath");
                }
            }
            catch (Exception e) { }
            
            if (settings.savePath == "")
            {
                settings.savePath = Directory.GetCurrentDirectory();
            }

            return settings;
        }

        public void Save()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"b-editor");

                rk.SetValue("savePath", savePath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\r\n설정 저장에 실패했습니다.");
            }
        }
    }
}
