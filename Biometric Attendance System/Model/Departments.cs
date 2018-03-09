using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Biometric_Attendance_System.Model
{
    class Department
    {
        public int Id;
        public string Name;
        public string Description;
        public TimeSpan? StartMon;
        public TimeSpan? EndMon;
        public TimeSpan? StartTue;
        public TimeSpan? EndTue;
        public TimeSpan? StartWed;
        public TimeSpan? EndWed;
        public TimeSpan? StartThurs;
        public TimeSpan? EndThurs;
        public TimeSpan? StartFri;
        public TimeSpan? EndFri;
        public TimeSpan? StartSat;
        public TimeSpan? EndSat;
        public TimeSpan? StartSun;
        public TimeSpan? EndSun;

        public Department(int id, string departmentName, string departmentDescription, 
            TimeSpan? StartMon, TimeSpan? EndMon, TimeSpan? StartTue, TimeSpan? EndTue, 
            TimeSpan? StartWed, TimeSpan? EndWed, TimeSpan? StartThurs, TimeSpan? EndThurs,
            TimeSpan? StartFri, TimeSpan? EndFri, TimeSpan? StartSat, TimeSpan? EndSat, 
            TimeSpan? StartSun, TimeSpan? EndSun)
        {
            Id = id;
            Name = departmentName;
            Description = departmentDescription;
            this.StartMon = StartMon;
            this.EndMon = EndMon;
            this.StartTue = StartTue;
            this.EndTue = EndTue;
            this.StartWed = StartWed;
            this.EndWed = EndWed;
            this.StartThurs = StartThurs;
            this.EndThurs = EndThurs;
            this.StartFri = StartFri;
            this.EndFri = EndFri;
            this.StartSat = StartSat;
            this.EndSat = EndSat;
            this.StartSun = StartSun;
            this.EndSun = EndSun;
        }

        public static Department[] GetDepartments()
        {
            var DepartmentsList = new List<Department>();
            var resultSet = Program.Database.GetData("SELECT * FROM departments");

            while (resultSet.Read())
            {
                var x1 = Convert.ToInt32((uint)resultSet["id"]);
                var x2 = (string)resultSet["department_name"];
                var x3 = (string)(resultSet["department_description"] == DBNull.Value ? null : resultSet["department_description"]);
                var x4 = (TimeSpan?)(resultSet["start_mon"] == DBNull.Value ? null : resultSet["start_mon"]);
                var x5 = (TimeSpan?)(resultSet["end_mon"] == DBNull.Value ? null : resultSet["end_mon"]);
                var x6 = (TimeSpan?)(resultSet["start_tue"] == DBNull.Value ? null : resultSet["start_tue"]);
                var x7 = (TimeSpan?)(resultSet["end_tue"] == DBNull.Value ? null : resultSet["end_tue"]);
                var x8 = (TimeSpan?)(resultSet["start_wed"] == DBNull.Value ? null : resultSet["start_wed"]);
                var x9 = (TimeSpan?)(resultSet["end_wed"] == DBNull.Value ? null : resultSet["end_wed"]);
                var x0 = (TimeSpan?)(resultSet["start_thurs"] == DBNull.Value ? null : resultSet["start_thurs"]);
                var x99 = (TimeSpan?)(resultSet["end_thurs"] == DBNull.Value ? null : resultSet["end_thurs"]);
                var x88 = (TimeSpan?)(resultSet["start_fri"] == DBNull.Value ? null : resultSet["start_fri"]);
                var x77 = (TimeSpan?)(resultSet["end_fri"] == DBNull.Value ? null : resultSet["end_fri"]);
                var x66 = (TimeSpan?)(resultSet["start_sat"] == DBNull.Value ? null : resultSet["start_sat"]);
                var x55 = (TimeSpan?)(resultSet["end_sat"] == DBNull.Value ? null : resultSet["end_sat"]);
                var x44 = (TimeSpan?)(resultSet["start_sun"] == DBNull.Value ? null : resultSet["start_sun"]);
                var x33 = (TimeSpan?)(resultSet["end_sun"] == DBNull.Value ? null : resultSet["end_sun"]);
                var Departments = new Department(
                    Convert.ToInt32((uint)resultSet["id"]),
                    (string)resultSet["department_name"],
                    (string)(resultSet["department_description"] == DBNull.Value ? "" : resultSet["department_description"]),
                    (TimeSpan?)(resultSet["start_mon"] == DBNull.Value ? null : resultSet["start_mon"]),
                    (TimeSpan?)(resultSet["end_mon"] == DBNull.Value ? null : resultSet["end_mon"]),
                    (TimeSpan?)(resultSet["start_tue"] == DBNull.Value ? null : resultSet["start_tue"]),
                    (TimeSpan?)(resultSet["end_tue"] == DBNull.Value ? null : resultSet["end_tue"]),
                    (TimeSpan?)(resultSet["start_wed"] == DBNull.Value ? null : resultSet["start_wed"]),
                    (TimeSpan?)(resultSet["end_wed"] == DBNull.Value ? null : resultSet["end_wed"]),
                    (TimeSpan?)(resultSet["start_thurs"] == DBNull.Value ? null : resultSet["start_thurs"]),
                    (TimeSpan?)(resultSet["end_thurs"] == DBNull.Value ? null : resultSet["end_thurs"]),
                    (TimeSpan?)(resultSet["start_fri"] == DBNull.Value ? null : resultSet["start_fri"]),
                    (TimeSpan?)(resultSet["end_fri"] == DBNull.Value ? null : resultSet["end_fri"]),
                    (TimeSpan?)(resultSet["start_sat"] == DBNull.Value ? null : resultSet["start_sat"]),
                    (TimeSpan?)(resultSet["end_sat"] == DBNull.Value ? null : resultSet["end_sat"]),
                    (TimeSpan?)(resultSet["start_sun"] == DBNull.Value ? null : resultSet["start_sun"]),
                    (TimeSpan?)(resultSet["end_sun"] == DBNull.Value ? null : resultSet["end_sun"])
                    );
                DepartmentsList.Add(Departments);
            }
            Program.Database.Commit();
            return DepartmentsList.ToArray();
        }

        public static Department GetDepartment(int id)
        {
            var resultSet = Program.Database.GetData(
                "SELECT * FROM departments where id = @id",
                new[]{
                    new MySqlParameter("@id", id)
                }
            );

            if (resultSet.Read())
            {
                var Departments = new Department(
                    Convert.ToInt32((uint)resultSet["id"]),
                    (string)resultSet["department_name"],
                    (string)(resultSet["department_description"] == DBNull.Value ? "" : resultSet["department_description"]),
                    (TimeSpan?)(resultSet["start_mon"] == DBNull.Value ? null : resultSet["start_mon"]),
                    (TimeSpan?)(resultSet["end_mon"] == DBNull.Value ? null : resultSet["end_mon"]),
                    (TimeSpan?)(resultSet["start_tue"] == DBNull.Value ? null : resultSet["start_tue"]),
                    (TimeSpan?)(resultSet["end_tue"] == DBNull.Value ? null : resultSet["end_tue"]),
                    (TimeSpan?)(resultSet["start_wed"] == DBNull.Value ? null : resultSet["start_wed"]),
                    (TimeSpan?)(resultSet["end_wed"] == DBNull.Value ? null : resultSet["end_wed"]),
                    (TimeSpan?)(resultSet["start_thurs"] == DBNull.Value ? null : resultSet["start_thurs"]),
                    (TimeSpan?)(resultSet["end_thurs"] == DBNull.Value ? null : resultSet["end_thurs"]),
                    (TimeSpan?)(resultSet["start_fri"] == DBNull.Value ? null : resultSet["start_fri"]),
                    (TimeSpan?)(resultSet["end_fri"] == DBNull.Value ? null : resultSet["end_fri"]),
                    (TimeSpan?)(resultSet["start_sat"] == DBNull.Value ? null : resultSet["start_sat"]),
                    (TimeSpan?)(resultSet["end_sat"] == DBNull.Value ? null : resultSet["end_sat"]),
                    (TimeSpan?)(resultSet["start_sun"] == DBNull.Value ? null : resultSet["start_sun"]),
                    (TimeSpan?)(resultSet["end_sun"] == DBNull.Value ? null : resultSet["end_sun"])
                    );
                Program.Database.Commit();
                return Departments;
            }
            Program.Database.Commit();
            return null;
        }

        public static Department AddDepartments(Department department)
        {
            var result = Program.Database.GetData("INSERT INTO Departments " +
                "VALUES (null, @departmentName, @departmentDescription,@start_mon,@end_mon," +
                "@start_tue,@end_tue,@start_wed,@end_wed,@start_thurs,@end_thurs,@start_fri," +
                "@end_fri,@start_sat,@end_sat,@start_sun,@end_sun); " +
                "SELECT LAST_INSERT_ID() as id; ",
                new[]
                {
                    new MySqlParameter("@departmentName", department.Name),
                    new MySqlParameter("@departmentDescription", department.Description),
                    new MySqlParameter("@start_mon",department.StartMon),
                    new MySqlParameter("@end_mon",department.EndMon),
                    new MySqlParameter("@start_tue",department.StartTue),
                    new MySqlParameter("@end_tue",department.EndTue),
                    new MySqlParameter("@start_wed",department.StartWed),
                    new MySqlParameter("@end_wed",department.EndWed),
                    new MySqlParameter("@start_thurs",department.StartThurs),
                    new MySqlParameter("@end_thurs",department.EndThurs),
                    new MySqlParameter("@start_fri",department.StartFri),
                    new MySqlParameter("@end_fri",department.EndFri),
                    new MySqlParameter("@start_sat",department.StartSat),
                    new MySqlParameter("@end_sat",department.EndSat),
                    new MySqlParameter("@start_sun",department.StartSun),
                    new MySqlParameter("@end_sun",department.EndSun)
                }
            );
            if (result.Read())
            {
                int generatedId = Convert.ToInt32((ulong)result["id"]);
                Program.Database.Commit();
                return GetDepartment(generatedId);
            }
            return null;
        }

        public static Department EditDepartment(int id, Department department)
        {
            var result = Program.Database.ExecuteCommand("UPDATE deparments SET " +
                "department_name = CASE WHEN @departmentName IS NULL THEN department_name ELSE @departmentName END, " +
                "department_description = CASE WHEN @departmentDescription IS NULL THEN department_description ELSE @departmentDescription END" +
                "WHERE id = @id",
                new[]{
                    new MySqlParameter("@departmentName", department.Name),
                    new MySqlParameter("@departmentDescription", department.Description),
                    new MySqlParameter("@@id", id),
                }
            );
            Program.Database.Commit();
            return GetDepartment(id);
        }

        public static bool DeleteDepartments(int id)
        {
            var result = Program.Database.ExecuteCommand("DELETE FROM departments WHERE id = @id",
                new[]{
                    new MySqlParameter("@id", id)
                }
            );
            Program.Database.Commit();
            return result;
        }
    }
}
