using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biometric_Attendance_System.Model
{
    class Attendance
    {
        public int Id;
        public int EmployeeId;
        public DateTime Timelog;

        public Attendance(int id, int employeeId, DateTime timelog)
        {
            Id = id;
            EmployeeId = employeeId;
            Timelog = timelog;
        }

        public static Attendance[] GetAttendances()
        {
            var AttendanceList = new List<Attendance>();
            var resultSet = Program.Database.GetData("SELECT * FROM attendance");

            while (resultSet.Read())
            {
                var Attendance = new Attendance(
                    (int)resultSet["id"],
                    (int)resultSet["employee_id"],
                    (DateTime)resultSet["timelog"]
                );
                AttendanceList.Add(Attendance);
            }
            Program.Database.Commit();
            return AttendanceList.ToArray();
        }

        public static Attendance GetAttendance(int id)
        {
            var resultSet = Program.Database.GetData(
                "SELECT * FROM attendance where id = @id",
                new[]{
                    new MySqlParameter("@id", id)
                }
            );

            if (resultSet.Read())
            {
                var Attendance = new Attendance(
                    (int)resultSet["id"],
                    (int)resultSet["employee_id"],
                    (DateTime)resultSet["timelog"]
                );
                Program.Database.Commit();
                return Attendance;
            }
            Program.Database.Commit();
            return null;
        }

        public static Attendance AddAttendance(int employeeId)
        {
            var result = Program.Database.GetData("INSERT INTO attendance " +
                "VALUES (null, @employeeId, null); " +
                "SELECT LAST_INSERT_ID() as id; ",
                new[]
                {
                    new MySqlParameter("@employeeId", employeeId)
                }
            );
            if (result.Read())
            {
                int generatedId = Convert.ToInt32((ulong)result["id"]);
                Program.Database.Commit();
                return GetAttendance(generatedId);
            }
            return null;
        }

        public static bool DeleteAttendance(int id)
        {
            var result = Program.Database.ExecuteCommand("DELETE FROM attendance WHERE id = @id",
                new[]{
                    new MySqlParameter("@id", id)
                }
            );
            Program.Database.Commit();
            return result;
        }
    }
}
