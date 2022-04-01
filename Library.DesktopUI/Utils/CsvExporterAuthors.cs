using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lib_books.DesktopUI.Utils
{
    public static class CsvExporterAuthors
    {
        private const string _filepath = "D:\\";

        public static string Export(object[] objects, string filename)
        {
            string fulpath = _filepath + filename;
            Type t = objects[0].GetType();
            foreach (var item in objects)
            {
                if (item.GetType().FullName != t.FullName)
                {
                    throw new InvalidOperationException("Unable to export");
                }
            }

            StringBuilder builder = new StringBuilder();
            var prop = t.GetProperties();
            bool first = true;
            foreach (var pro in prop)
            {
                if (!first)
                {
                    builder.Append(",");
                }

                builder.Append(pro.Name);
                first = false;

            }

            builder.AppendLine();

            foreach (var obj in objects)
            {
                bool first2 = true;
                foreach (var p in prop)
                {
                    if (!first2)
                    {
                        builder.Append(",");

                    }

                    builder.Append(p.GetValue(obj));
                    first2 = false;


                }
                builder.AppendLine();
                File.WriteAllText($"{fulpath}.csv", builder.ToString());
            }

            return fulpath;
        }
    }
}

