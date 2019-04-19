using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikDestekDepartman
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Kayit.Creat();
            Kayit.Creat2();
        }
    }
    public class Tickett
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string SolvedBy { get; set; }
        public bool Solved { get; set; }
        public DateTime TimeCreated { get; set; }
    }
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
