﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guidMakerConsole
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Clipboard.SetText(Guid.NewGuid().ToString().ToUpper());
        }
    }
}
