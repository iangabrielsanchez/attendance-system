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
        public string Position;
        public string Address;
        public string Sex;
        public Date BirthDate;
        public Date DateEmployed;
        public string TIN;
        public string SSN;
        public string PhilHealth;
        public string Pagibig;
        public string Contact;
        public decimal Rate;
        public string Fingerprint;
        public string FingerprintLocation;
        public string ImageLocation;

        public Employee(int Id, string FirstName, string MiddleName, string LastName,
            int DepartmentId, string Position, string Address, string Sex, Date BirthDate,
            Date DateEmployed, string TIN, string SSN, string PhilHealth, string Pagibig,
            string Contact, decimal Rate, string Fingerprint, string FingerprintLocation,
            string ImageLocation)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.DepartmentId = DepartmentId;
            this.Position = Position;
            this.Address = Address;
            this.Sex = Sex;
            this.BirthDate = BirthDate;
            this.DateEmployed = DateEmployed;
            this.TIN = TIN;
            this.SSN = SSN;
            this.PhilHealth = PhilHealth;
            this.Pagibig = Pagibig;
            this.Contact = Contact;
            this.Rate = Rate;
            this.Fingerprint = Fingerprint;
            this.FingerprintLocation = FingerprintLocation;
            this.ImageLocation = ImageLocation;
        }

        public static Employee[] GetEmployees()
        {
            var employeesList = new List<Employee>();
            var resultSet = Program.Database.GetData("SELECT * FROM employees");
            
            while (resultSet.Read())
            {
                var employee = new Employee(
                    (int)resultSet["id"],
                    (string)resultSet["firstname"],
                    (string)resultSet["middlename"],
                    (string)resultSet["lastname"],
                    (int)resultSet["deparment_id"],
                    (string)resultSet["position"],
                    (string)resultSet["address"],
                    (string)resultSet["sex"],
                    (Date)resultSet["birthdate"],
                    (Date)resultSet["date_employed"],
                    (string)resultSet["tin"],
                    (string)resultSet["ssn"],
                    (string)resultSet["philhealth"],
                    (string)resultSet["pagibig"],
                    (string)resultSet["contact"],
                    (decimal)resultSet["rate"],
                    (string)resultSet["fingerprint"],
                    (string)resultSet["fp_imglocation"],
                    (string)resultSet["imglocation"]
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
                    (string)resultSet["firstname"],
                    (string)resultSet["middlename"],
                    (string)resultSet["lastname"],
                    (int)resultSet["deparment_id"],
                    (string)resultSet["position"],
                    (string)resultSet["address"],
                    (string)resultSet["sex"],
                    (Date)resultSet["birthdate"],
                    (Date)resultSet["date_employed"],
                    (string)resultSet["tin"],
                    (string)resultSet["ssn"],
                    (string)resultSet["philhealth"],
                    (string)resultSet["pagibig"],
                    (string)resultSet["contact"],
                    (decimal)resultSet["rate"],
                    (string)resultSet["fingerprint"],
                    (string)resultSet["fp_imglocation"],
                    (string)resultSet["imglocation"]
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
                "VALUES (null, @firstname, @middlename, @lastname, @deparment_id, @position, " +
                "@address, @sex, @birthdate, @date_employed, @tin, @ssn, @philhealth, @pagibig, " +
                "@contact, @rate, @fingerprint, @fp_imglocation, @imglocation); " +
                "SELECT LAST_INSERT_ID() as id; ",
                new[]
                {
                    new MySqlParameter("@firstname", employee.FirstName),
                    new MySqlParameter("@middlename", employee.MiddleName),
                    new MySqlParameter("@lastname", employee.LastName),
                    new MySqlParameter("@deparment_id", employee.DepartmentId),
                    new MySqlParameter("@position", employee.Position),
                    new MySqlParameter("@address", employee.Address),
                    new MySqlParameter("@sex", employee.Sex),
                    new MySqlParameter("@birthdate", employee.BirthDate),
                    new MySqlParameter("@date_employed", employee.DateEmployed),
                    new MySqlParameter("@tin", employee.TIN),
                    new MySqlParameter("@ssn", employee.SSN),
                    new MySqlParameter("@philhealth", employee.PhilHealth),
                    new MySqlParameter("@pagibig", employee.Pagibig),
                    new MySqlParameter("@contact", employee.Contact),
                    new MySqlParameter("@rate", employee.Rate),
                    new MySqlParameter("@fingerprint", employee.Fingerprint),
                    new MySqlParameter("@fp_imglocation", employee.FingerprintLocation),
                    new MySqlParameter("@imglocation", employee.ImageLocation)
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
                "firstname = @firstname, middlename = @middlename, lastname = @lastname, " +
                "deparment_id = @deparment_id, position = @position, address = @address, sex = @sex, " +
                "birthdate = @birthdate, date_employed = @date_employed, tin = @tin, ssn = @ssn, " +
                "philhealth = @philhealth, pagibig = @pagibig, contact = @contact, rate = @rate, " +
                "fingerprint = @fingerprint, fp_imglocation = @fp_imglocation, imglocation = @imglocation " +
                "WHERE id = @id",
                new[]{
                    new MySqlParameter("@id", employee.Id),
                    new MySqlParameter("@firstname", employee.FirstName),
                    new MySqlParameter("@middlename", employee.MiddleName),
                    new MySqlParameter("@lastname", employee.LastName),
                    new MySqlParameter("@deparment_id", employee.DepartmentId),
                    new MySqlParameter("@position", employee.Position),
                    new MySqlParameter("@address", employee.Address),
                    new MySqlParameter("@sex", employee.Sex),
                    new MySqlParameter("@birthdate", employee.BirthDate),
                    new MySqlParameter("@date_employed", employee.DateEmployed),
                    new MySqlParameter("@tin", employee.TIN),
                    new MySqlParameter("@ssn", employee.SSN),
                    new MySqlParameter("@philhealth", employee.PhilHealth),
                    new MySqlParameter("@pagibig", employee.Pagibig),
                    new MySqlParameter("@contact", employee.Contact),
                    new MySqlParameter("@rate", employee.Rate),
                    new MySqlParameter("@fingerprint", employee.Fingerprint),
                    new MySqlParameter("@fp_imglocation", employee.FingerprintLocation),
                    new MySqlParameter("@imglocation", employee.ImageLocation)
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
