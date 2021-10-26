using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchMaker
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var text = Clipboard.GetText();


            Clipboard.SetText($"git fetch && git checkout {text}");
        }
    }
}
