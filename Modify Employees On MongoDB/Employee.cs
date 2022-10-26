namespace Modify_Employees_On_MongoDB
using System;
using MongoDB.Bson;
using MongoDB.Driver;


namespace com.hr
{
    class Employee
    {
        public string First
        { get; set; }

        public string Last
        { get; set; }

        public decimal Salary
        { get; set; }

        public ObjectId Id
        { get; set; }

        public override string ToString() =>
        "Employee [id =" + Id + ", Firstname=" + First + ", lastname=" +
        Last + ", salary= " + Salary + "]";

        public static void printCollection(IMongoCollection<Employee> collection)
        {
            var emps = collection.Find(_ => true).ToList();
            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp);
            }
        }

    }
}