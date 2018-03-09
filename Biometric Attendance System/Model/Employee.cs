using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Biometric_Attendance_System.Model
{
    class Employee
    {
        public int Id;
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public int DepartmentId;
        public ulong Status;
        public DateTime DateCreated;
        public DateTime DateUpdated;

        public Employee(int id, string firstName, string middleName, string lastName, int departmentId, ulong status, DateTime dateCreated, DateTime dateUpdated)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DepartmentId = departmentId;
            Status = status;
            DateCreated = dateCreated;
            DateUpdated = dateUpdated;
        }

        public static Employee[] GetEmployees()
        {
            var employeesList = new List<Employee>();
            var resultSet = Program.Database.GetData("SELECT * FROM employees");
            
            while (resultSet.Read())
            {
                var employee = new Employee(
                    (int)resultSet["id"],
                    (string)resultSet["first_name"],
                    (string)resultSet["middle_name"],
                    (string)resultSet["last_name"],
                    (int)resultSet["department_id"],
                    (ulong)resultSet["status"],
                    (DateTime)resultSet["date_created"],
                    (DateTime)resultSet["date_updated"]
                );
                employeesList.Add(employee);
            }
            Program.Database.Commit();
            return employeesList.ToArray();
        }

        public static Employee GetEmployee(int id)
        {
            var resultSet = Program.Database.GetData(
                "SELECT * FROM employees where id = @id",
                new[]{
                    new MySqlParameter("@id", id)
                }
            );

            if (resultSet.Read())
            {
                var employee = new Employee(
                    (int)resultSet["id"],
                    (string)resultSet["first_name"],
                    (string)resultSet["middle_name"],
                    (string)resultSet["last_name"],
                    (int)resultSet["department_id"],
                    (ulong)resultSet["status"],
                    (DateTime)resultSet["date_created"],
                    (DateTime)resultSet["date_updated"]
                );
                Program.Database.Commit();
                return employee;
            }
            Program.Database.Commit();
            return null;
        }

        public static Employee AddEmployee(Employee employee)
        {
            var result = Program.Database.GetData("INSERT INTO employees " +
                "VALUES (null, @firstName, @middleName, @lastName, @departmentId, @status, null, null); " +
                "SELECT LAST_INSERT_ID() as id; ",
                new[]
                {
                    new MySqlParameter("@firstName", employee.FirstName),
                    new MySqlParameter("@middleName", employee.MiddleName),
                    new MySqlParameter("@lastName", employee.LastName),
                    new MySqlParameter("@departmentId", employee.DepartmentId),
                    new MySqlParameter("@status", employee.Status)
                }
            );
            if (result.Read())
            {
                int generatedId = Convert.ToInt32((ulong)result["id"]);
                Program.Database.Commit();
                return GetEmployee(generatedId);
            }
            return null;
        }

        public static Employee EditEmployee(int id, Employee employee)
        {
            var result = Program.Database.ExecuteCommand("UPDATE employees SET " +
                "first_name = CASE WHEN @firstName IS NULL THEN first_name ELSE @firstName END, " +
                "middle_name = CASE WHEN @middleName IS NULL THEN middle_name ELSE @middleName END, " +
                "last_name = CASE WHEN @lastName IS NULL THEN last_name ELSE @lastName END, " +
                "department_id = CASE WHEN @departmentId IS NULL THEN department_id ELSE @departmentId END, " +
                "status = CASE WHEN @status IS NULL THEN status ELSE @status END " +
                "WHERE id = @id",
                new[]{
                    new MySqlParameter("@firstName", employee.FirstName),
                    new MySqlParameter("@middleName", employee.MiddleName),
                    new MySqlParameter("@lastName", employee.LastName),
                    new MySqlParameter("@departmentId", employee.DepartmentId),
                    new MySqlParameter("@status", employee.Status),
                    new MySqlParameter("@id", id),
                }
            );
            Program.Database.Commit();
            return GetEmployee(id);
        }

        public static bool DeleteEmployee(int id)
        {
            var result = Program.Database.ExecuteCommand("DELETE FROM employees WHERE id = @id",
                new[]{
                    new MySqlParameter("@id", id)
                }
            );
            Program.Database.Commit();
            return result;
        }
    }
}
