using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Biometric_Attendance_System.Model;

namespace Biometric_Attendance_System
{
    static class Program
    {
        public static Database Database;
        public static AttendanceMonitor AttendanceMonitor;
        public static MainForm MainForm; 
        public static Biometrics biometrics = new Biometrics();
        public static SHA1 sha1 = SHA1.Create();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += (s, e) => biometrics.Shutdown();
            Database = new Database("attendance_system", "localhost", "root", "toor");
            Employee[] employees = Employee.GetEmployees();
            //Department[] departments = Department.GetDepartments();
            //if (departments.Length >= 1)
            //{
            //    Department dept = new Department(-1, "IT Department", "", new DateTime(), new DateTime());
            //    Department.AddDepartments(dept);
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AttendanceMonitor = new AttendanceMonitor();
            MainForm = new MainForm();
            Application.Run(MainForm);
        }
    }
}
