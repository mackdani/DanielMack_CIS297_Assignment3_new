using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    /// <Student>Daniel Mack</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bank_AccountForm());
        }
    }
}
