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
        public string Status;
        public DateTime Timestamp;

        public Attendance(int id, int employeeId, string status, DateTime timestamp)
        {

            Id = id;
            EmployeeId = employeeId;
            Status = status;
            Timestamp = timestamp;
        }

        public static Attendance[] GetAttendances(int id)
        {
            var AttendanceList = new List<Attendance>();
            var resultSet = Program.Database.GetData("SELECT * FROM attendance where employee_id = @id",
                new[]{
                    new MySqlParameter("@id", id)
                }
            );

            while (resultSet.Read())
            {
                var Attendance = new Attendance(
                    (int)resultSet["id"],
                    (int)resultSet["employee_id"],
                    (string)resultSet["status"],
                    (DateTime)resultSet["timestamp"]
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
                    (string)resultSet["status"],
                    (DateTime)resultSet["timestamp"]
                );
                Program.Database.Commit();
                return Attendance;
            }
            Program.Database.Commit();
            return null;
        }

        public static string GetLastStatus(int employeeId)
        {
            var result = Program.Database.GetData(
                "SELECT status FROM attendance WHERE employee_id = @employeeId ORDER BY id desc limit 1",
                new[]
                {
                    new MySqlParameter("@employeeId", employeeId)
                }
            );

            if (result.Read())
            {
                string status = (string)result["status"];
                Program.Database.Commit();
                return status;
            }
            return null;
        }

        public static Attendance AddAttendance(int employeeId)
        {
            var result = Program.Database.GetData("INSERT INTO attendance " +
                "VALUES (null, @employeeId, @status, now()); " +
                "SELECT LAST_INSERT_ID() as id; ",
                new[]
                {
                    new MySqlParameter("@employeeId", employeeId),
                    new MySqlParameter("@status", GetLastStatus(employeeId) == "in"? "out":"in")
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
