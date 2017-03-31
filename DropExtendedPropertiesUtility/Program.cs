using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropExtendedPropertiesUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = new DropExtendedPropertyHelper();
            h.Run();
        }
    }

    class DropExtendedPropertyHelper
    {
        public void Run()
        {
            var viewNames = new List<string>();

            var input = File.ReadAllLines("input.txt");
            foreach (var line in input)
            {
                //EXEC sp_dropextendedproperty N'MS_DiagramPaneCount', 'SCHEMA', N'dbo', 'VIEW', N'vwAddress', NULL, NULL
                if (line.StartsWith("EXEC sp_dropextendedproperty N'MS_DiagramPaneCount', 'SCHEMA', N'dbo', 'VIEW', N'"))
                {
                    var truncatedLine =
                        line.Replace(
                            "EXEC sp_dropextendedproperty N'MS_DiagramPaneCount', 'SCHEMA', N'dbo', 'VIEW', N'", "");

                    var idx = truncatedLine.IndexOf("'");
                    var viewName = truncatedLine.Substring(0, idx);
                    Console.WriteLine(viewName);

                    viewNames.Add(viewName);
                }
                   
            }

            var sb = new StringBuilder();
            foreach (var viewName in viewNames)
            {
                sb.AppendLine($"IF EXISTS (SELECT 1 FROM SYS.EXTENDED_PROPERTIES WHERE [major_id] = OBJECT_ID('{viewName}') AND [name] = N'MS_DiagramPane1' AND [minor_id] = 0)");
                sb.AppendLine("BEGIN");
                sb.AppendLine($"EXEC sp_dropextendedproperty N'MS_DiagramPane1', 'SCHEMA', N'dbo', 'VIEW', N'{viewName}', NULL, NULL");
                sb.AppendLine("END;");
                sb.AppendLine("GO");
                sb.AppendLine("IF @@ERROR <> 0 SET NOEXEC ON");
                sb.AppendLine("GO");
                sb.AppendLine($"IF EXISTS (SELECT 1 FROM SYS.EXTENDED_PROPERTIES WHERE [major_id] = OBJECT_ID('{viewName}') AND [name] = N'MS_DiagramPaneCount' AND [minor_id] = 0)");
                sb.AppendLine("BEGIN");
                sb.AppendLine($"EXEC sp_dropextendedproperty N'MS_DiagramPaneCount', 'SCHEMA', N'dbo', 'VIEW', N'{viewName}', NULL, NULL");
                sb.AppendLine("END;");
                sb.AppendLine("GO");
                sb.AppendLine("IF @@ERROR <> 0 SET NOEXEC ON");
                sb.AppendLine("GO");
            }

            File.WriteAllText("output.txt",sb.ToString());
            Console.WriteLine("Done.  Results written to output.txt");
            Console.ReadLine();

        }

    }
}
