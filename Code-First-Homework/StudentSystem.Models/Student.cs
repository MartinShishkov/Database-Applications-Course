using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    // If we want our table to be with
    // a different name we use the [Table()] attribute
    // [Table("TableName")]
    public class Student
    {
        private ICollection<HomeworkSubmission> _homeworkSubmissions;
        private ICollection<Course> _courses; 

        public Student()
        {
            this.Id = Guid.NewGuid();
            this._homeworkSubmissions = new HashSet<HomeworkSubmission>();
            this._courses = new HashSet<Course>();
        }

        // For primary key use [Key] attribute
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Student name cannot be null.")]
        [MaxLength(512)]
        public string FullName { get; set; }

        // Constraint with error message
        [MaxLength(10, ErrorMessage = "Phone number length cannot exceed 10 symbols")]
        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime Birthday { get; set; }

        public virtual ICollection<HomeworkSubmission> HomeworkSubmissions
        {
            get { return this._homeworkSubmissions; }
            set { this._homeworkSubmissions = value; }
        }

        public virtual ICollection<Course> Courses
        {
            get { return this._courses; }
            set { this._courses = value; }
        } 
    }
}
