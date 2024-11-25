using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group Group {get; set;} = default!;
        public int? GroupId {get; set;} = default!;
        public Parent Parent {get; set;} = default!;
        public int? ParentId {get; set;} = default!;
        public double AverageGrade {get;} = default!;
        public IDictionary<string, double> AverageGradeperSubject {get;} = default!;
        public IDictionary<string, List<GradeScale>>Grades {get;} =default!;
    }
}