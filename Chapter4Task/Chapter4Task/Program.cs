using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Chapter4Task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Serialize("Employees.xml");
                Deserialize("Employees.xml");

            }

            catch (SerializationException serEx)
            {
                Console.WriteLine("Serialization Failed");
                Console.WriteLine(serEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The serialization failed: {0} StackTrace is: {1}", ex.Message, ex.StackTrace);
            }

            finally
            {
                Console.WriteLine("Press <Enter> to exit....");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// Creating employees and creating start xml file
        /// </summary>
        /// <param name="fileName"></param>
        public static void Serialize(string fileName)
        {
            Console.WriteLine("Creating objects and serializing them...");

            #region CreateEmployees
            Employee employee1 = new Employee("Sukharev", "Alex", 24, "Office", "My address");
            Employee employee2 = new Employee("Sel", "Mark", 40, "Microsoft", "His address");
            Employee employee3 = new Employee("Skopel", "Fabio", 32, "Microsoft", "No address");
            Employee employee4 = new Employee("Richter", "Jeff", 64, "Orbita", "New address");
            Employee employee5 = new Employee("Albahari", "Joe", 28, "Google", "Few addresses");
            Employee employee6 = new Employee("Tribiani", "Joe", 27, "Friends", "Test address");
            Employee employee7 = new Employee("Lipmann", "Stan", 30, "HP", "USA");
            Employee employee8 = new Employee("Troelsen", "Andrew", 34, "Smalltalk", "Unknown address");
            Employee employee9 = new Employee("Crowford", "Denis", 29, "Noway", "His address");
            Employee employee10 = new Employee("Palermo", "Jeff", 56, "Google", "Few addresses");
            #endregion

            var list = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };

            FileStream writer = new FileStream(fileName, FileMode.Create);
            DataContractSerializer ser = new DataContractSerializer(typeof(List<Employee>), "Employees", String.Empty, new[] { list.GetType() });
            ser.WriteObject(writer, list);
            writer.Close();
        }

        /// <summary>
        /// Deserializing employees from xml file, select necessary, order them and serializing to new file
        /// </summary>
        /// <param name="fileName"></param>
        public static void Deserialize(string fileName)
        {
            const string _selectedObjectsDoc = "SelectedObjects.xml";

            Console.WriteLine("Deserializing objects...");
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            DataContractSerializer ser = new DataContractSerializer(typeof(List<Employee>), "Employees", String.Empty);

            List<Employee> employees = (List<Employee>)ser.ReadObject(reader, true);

            Console.WriteLine("All employees:");
            foreach (Employee emp in employees)
            {
                Type field = emp.GetType();

                //get value of private member EmployeeId
                string id = (string)field.InvokeMember("EmployeeId", BindingFlags.GetField | BindingFlags.Instance | BindingFlags.NonPublic, null, emp, null);

                //get info about public Address property and get it`s value
                PropertyInfo info = field.GetProperty("Address");
                string address = (string)info.GetValue(emp, null);

                Console.WriteLine(" Last name: {0} \n First name: {1} \n Age: {2} \n Department: {3} \n Address: {4} \n ID: {5}\n", emp.LastName, emp.FirstName, emp.Age, emp.Department, address, id);
            }

            reader.Close();
            fs.Close();

            var result = from temp in employees where temp.Age >= 25 && temp.Age <= 35 orderby temp.GetType().InvokeMember("EmployeeId", BindingFlags.GetField | BindingFlags.Instance | BindingFlags.NonPublic, null, temp, null) select temp;

            Console.WriteLine("Select employees from 25 years to 35 and sort them by ID...\nSelected employees are:\n");
            foreach (Employee emp in result)
            {
                Type field = emp.GetType();

                //get value of private member EmployeeId
                string id = (string)field.InvokeMember("EmployeeId", BindingFlags.GetField | BindingFlags.Instance | BindingFlags.NonPublic, null, emp, null);

                //get info about public Address property and get it`s value
                PropertyInfo info = field.GetProperty("Address");
                string address = (string)info.GetValue(emp, null);

                Console.WriteLine(" Last name: {0} \n First name: {1} \n Age: {2} \n Department: {3} \n Address: {4} \n ID: {5}\n", emp.LastName, emp.FirstName, emp.Age, emp.Department, address, id);
            }

            #region Serealize ordered and necessary employees to new file
            Console.WriteLine("Serializing selected objects...");
            try
            {
                FileStream stream = new FileStream(_selectedObjectsDoc, FileMode.Create);
                DataContractSerializer finalSer = new DataContractSerializer(typeof(List<Employee>), "Employees", String.Empty, new[] { result.GetType() });
                finalSer.WriteObject(stream, result.ToList());
                stream.Close();
            }
            catch (SerializationException serEx)
            {
                Console.WriteLine("Serialization Failed");
                Console.WriteLine(serEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The serialization failed: {0} StackTrace is: {1}", ex.Message, ex.StackTrace);
            }

            Console.WriteLine("Your objects successfully serialized!\n");
            #endregion
        }
    }
}
