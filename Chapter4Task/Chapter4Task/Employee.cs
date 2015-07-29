using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Task
{
    [DataContract(Name = "Employee", Namespace = "")]
    public class Employee
    {
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Department { get; set; }
        [DataMember]
        public string Address { get; set; }

        [DataMember]
        private string EmployeeId;

        public Employee(string lastname, string firstname, int age, string department, string address)
        {
            LastName = lastname;
            FirstName = firstname;
            Age = age;
            Department = department;
            Address = address;
            EmployeeId = lastname + firstname;
        }
    }
}
