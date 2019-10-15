using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Xml.Serialization;

namespace _Separina
{
    [Serializable]
    public class Rules
    {
        public Rules()
        {
            templates = new List<Template>();
        }
        public List<Template> templates { get; set; }
        [XmlIgnore]
        private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Rules.rules");       

        public static Rules Deserialise
        {
            get
            {
                try
                {
                    if (!File.Exists(path))
                        return new Rules();
                    XmlSerializer serial = new XmlSerializer(typeof(Rules));
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        return (Rules)serial.Deserialize(fs);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new Rules();
                }
            }
        }

        public static void Serialise(Rules rules)
        {
            File.WriteAllText(path, "");
            try
            {
                XmlSerializer serial = new XmlSerializer(typeof(Rules));
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    serial.Serialize(fs, rules);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    
    [Serializable]
    public class Template
    {
        public Template() { }
        public string Name { get; set; }
        public string Separator { get; set; }
        public string TemplateRow { get; set; }
        public List<string> Rule { get; set; }
        public bool VIPRule { get; set; }
        public DateTime LastUsedTime { get; set; }
        //public static List<Template> Sort(List<Template> templates)
        //{

        //}
        public override string ToString()
        {
            return Name + "\t" + (Separator=="\t"?"\\t":Separator);
        }
    }   

}
