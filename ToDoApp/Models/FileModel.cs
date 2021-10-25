using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public abstract class FileModel
    {
        [Key]
        public int Id { get; set; }
            
        [ForeignKey("ID")]
        public int taskId { get; set; } 
        public virtual TaskModel parentTask { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string UploadedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
