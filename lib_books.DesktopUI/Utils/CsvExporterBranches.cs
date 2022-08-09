using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace lib_books.DeskUI.Utils
{
    public static class CsvExporterBranches
    {
        private const string _filepath = "D:\\";
        public static string Export(object[] objects,string filename)
        {
            string fullpath = _filepath + filename;
            Type type = objects[0].GetType();
            foreach (var item in objects)
            {
                if (item.GetType().FullName!=type.FullName)
                {
                    throw new InvalidOperationException("Unable to export");
                }
            }

            StringBuilder builder = new StringBuilder();
            var properties = type.GetProperties();
            bool first = true;
            foreach (var p in properties)
            {
                if (first!)
                {
                    builder.Append(",");
                    
                }
                builder.Append(p.Name);
                first = false;
            }

            foreach (var o in objects)
            {
                bool first2 = true;
                foreach ( var p in properties)
                {
                    if (first2!)
                    {
                        builder.Append(",");
                        
                    }
                    builder.Append(p.GetValue(o));
                    first2 = false;
                    builder.AppendLine();
                }
                File.WriteAllText($"{fullpath}.csv",builder.ToString());
            }
            return fullpath;
        }
    }
}
