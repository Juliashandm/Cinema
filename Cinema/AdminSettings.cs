using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Cinema
{
    public class AdminSettings
    {
        public static AdminSettings DetSettings()
        {
            AdminSettings settings = null;
            string filename = Globals.AdminSettingsFile;
            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(AdminSettings));
                    settings = (AdminSettings)xser.Deserialize(fs);
                    fs.Close();
                }
            }
            else settings = new AdminSettings();

            return settings;
        }

        public void Save()
        {
            string filename = Globals.AdminSettingsFile;
            if (File.Exists(filename)) File.Delete(filename);

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(AdminSettings));
                xser.Serialize(fs, this);
                fs.Close();
            }
        }

        public string Name { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
        public string Age { get; set; }
        public string Actors { get; set; }
    }
}
