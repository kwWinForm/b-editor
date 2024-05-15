using Microsoft.Win32;
using System.IO;

namespace b_editor
{
    public class Settings
    {
        public string savePath = "";
        public string currentPost = "";
        public int autosaveInterval = 5000; // milliseconds

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
                    settings.currentPost = (string)rk.GetValue("currentPost");
                    settings.autosaveInterval = Convert.ToInt32(rk.GetValue("autosaveInterval"));
                }
            }
            catch (Exception e) { }
            
            if (settings.savePath == "")
            {
                settings.savePath = Directory.GetCurrentDirectory();
            }

            if (settings.currentPost == null)
            {
                settings.currentPost = "";
            }

            if (settings.autosaveInterval == 0)
            {
                settings.autosaveInterval = 5000;
            }

            return settings;
        }

        public void Save()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"b-editor");

                rk.SetValue("savePath", savePath);
                rk.SetValue("currentPost", currentPost);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\r\n설정 저장에 실패했습니다.");
            }
        }
    }
}
