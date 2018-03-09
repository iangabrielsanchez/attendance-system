using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Biometric_Attendance_System.Model;
using Biometric_Attendance_System.Properties;

namespace Biometric_Attendance_System
{
    static class Program
    {
        public static Database Database;
        public static AttendanceMonitor AttendanceMonitor;
        public static MainForm MainForm;
        public static Biometrics biometrics = new Biometrics();
        public static SHA1 sha1 = SHA1.Create();
        public static Settings settings = Settings.Default;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += (s, e) => biometrics.Shutdown();
            Database = new Database("attendance_system", "localhost", settings.DatabaseUser, settings.DatabasePassword);
            Employee[] employees = Employee.GetEmployees();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AttendanceMonitor = new AttendanceMonitor();
            MainForm = new MainForm();
            Application.Run(MainForm);
        }
    }
}
