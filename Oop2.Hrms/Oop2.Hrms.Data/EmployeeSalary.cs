//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oop2.Hrms.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeSalary
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int Basic { get; set; }
        public int HouseAlignment { get; set; }
        public int MedicalFacilities { get; set; }
        public int Total { get; set; }
        public bool IsCurrent { get; set; }
    
        public virtual EmployeeInfo EmployeeInfo { get; set; }
    }
}
