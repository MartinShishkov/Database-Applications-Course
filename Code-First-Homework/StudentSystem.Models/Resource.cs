using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Resource
    {
        public Resource()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(512)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Type { get; set; }

        public string Url { get; set; }

        public Guid CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
