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

        public Department(int id, string departmentName, string departmentDescription)
        {
            Id = id;
            Name = departmentName;
            Description = departmentDescription;
        }

        public static Department[] GetDepartments()
        {
            var DepartmentsList = new List<Department>();
            var resultSet = Program.Database.GetData("SELECT * FROM departments");

            while (resultSet.Read())
            {
                var Departments = new Department(
                    Convert.ToInt32((uint)resultSet["id"]),
                    (string)resultSet["department_name"],
                    (string)resultSet["department_description"]
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
                    (string)resultSet["department_description"]
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
                "VALUES (null, @departmentName, @departmentDescription); " +
                "SELECT LAST_INSERT_ID() as id; ",
                new[]
                {
                    new MySqlParameter("@departmentName", department.Name),
                    new MySqlParameter("@departmentDescription", department.Description)
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
