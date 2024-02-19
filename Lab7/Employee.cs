using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Employee
    {
        public enum EGender
        {
            Male , Female
        }
        public enum ESecurityLevel
        {
            guest,
            Developer, 
            secretary ,
            DBA
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public ESecurityLevel SecurityLevel { get; set; }
        public HireDate HireDate { get; set; }
        public EGender Gender { get; set; }
        public Employee() { 
        Id = 0;
            Name = "a";
            Salary = 1;
            SecurityLevel = ESecurityLevel.guest;
            HireDate = HireDate;
            Gender = EGender.Male;
                }
        public Employee (int id,string name , int salary , ESecurityLevel security , HireDate hire , EGender gender)
        {
            Id = id;
            Name = name;
            Salary = salary;
            SecurityLevel = security;
            HireDate = new HireDate();
            Gender = gender;
        }

        public override string ToString ()
        {
            string Employe = $"ID= {Id } , Name = {Name} , Salary ={string.Format("{0:C}",Salary)} , SecurityLevel={SecurityLevel}, HireDate={HireDate}, Gender={Gender}";
            return Employe;
        }



        


    }
}
