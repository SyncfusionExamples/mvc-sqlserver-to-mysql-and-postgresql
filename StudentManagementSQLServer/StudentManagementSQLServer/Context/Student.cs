using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSQLServer.Context
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string ProfileImage { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Address { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Age { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DOB { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool IsDeleted { get; set; }

    }
}
