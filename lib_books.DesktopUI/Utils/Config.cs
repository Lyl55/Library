using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace lib_books.DeskUI.Utils
{
    public class Config
    {
        private static Config _configuration;
        private Config()
        {
            
        }
        public  string DbType { get; set; }
        public string Database { get; set; }
        public string Server { get; set; }
        public bool IntegratedSecurity { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public static Config Get()
        {
            if (_configuration == null)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                if (File.Exists($"{path}\\lib_books.config") == false)
                {
                    _configuration = new Config();
                }
                else
                {
                    string txt = File.ReadAllText($"{path}\\lib_books.config");
                    _configuration = JsonConvert.DeserializeObject<Config>(txt);
                }
            }

            return _configuration;
        }

        public void Save()
        {
            string txt = JsonConvert.SerializeObject(this);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            File.WriteAllText($"{path}\\lib_books.config",txt);
        }
    }
}
