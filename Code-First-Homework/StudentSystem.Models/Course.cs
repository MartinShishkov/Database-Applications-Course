using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Course
    {
        private ICollection<HomeworkSubmission> _posts;
        private ICollection<Resource> _resources;
        private ICollection<Student> _students; 

        public Course()
        {
            this.Id = Guid.NewGuid();
            this._posts = new HashSet<HomeworkSubmission>();
            this._resources = new HashSet<Resource>();
            this._students = new HashSet<Student>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(512)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<HomeworkSubmission> HomeworkSubmissions
        {
            get { return this._posts; }
            set { this._posts = value; }
        }

        public virtual ICollection<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        public virtual ICollection<Student> Students
        {
            get { return this._students; }
            set { this._students = value; }
        } 
    }
}
