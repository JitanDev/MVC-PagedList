using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace TestProj.Models
{
    public class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public DateTime JoiningDate { get; set; }

        #endregion Properties

        public IEnumerable<Employee> List()
        {
            IEnumerable<Employee> employees = new List<Employee>() {
                new Employee(){ Id=1,Name="Tony Stark",Department="MCU", Designation="Iron Man", JoiningDate=DateTime.ParseExact("01/05/2008","dd/mm/yyyy",CultureInfo.InvariantCulture)},
                new Employee(){ Id=2,Name="Steve Rozors",Department="MCU", Designation="Captain America", JoiningDate=DateTime.ParseExact("29/07/2011","dd/mm/yyyy",CultureInfo.InvariantCulture)},
                new Employee(){ Id=3,Name="Thor",Department="MCU", Designation="Thor", JoiningDate=DateTime.ParseExact("29/04/2008","dd/mm/yyyy",CultureInfo.InvariantCulture)},
                new Employee(){ Id=4,Name="Brue Banner",Department="MCU", Designation="Hulk", JoiningDate=DateTime.ParseExact("06/06/2008","dd/mm/yyyy",CultureInfo.InvariantCulture)}
            };

            return employees;
        }
    }
}