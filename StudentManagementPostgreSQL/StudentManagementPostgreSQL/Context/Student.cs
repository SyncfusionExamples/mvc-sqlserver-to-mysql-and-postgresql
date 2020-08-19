using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentManagementPostgreSQL.Context
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "text")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Column(TypeName = "text")]
        public string ProfileImage { get; set; }

        [Column(TypeName = "text")]
        public string Address { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Age { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime DOB { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool IsDeleted { get; set; }

    }
}