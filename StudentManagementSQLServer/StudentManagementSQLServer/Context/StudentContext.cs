using System.Data.Entity;


namespace StudentManagementSQLServer.Context
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public StudentContext() : base("StudentDBConnection") { }
    }
}