using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagementMySQL.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class StudentContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public StudentContext() : base("StudentDBConnection") { }
    }
}