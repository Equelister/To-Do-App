using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class TaskModel
    {
        public int ID { get; set; }

        [Required]
        public string Subject { get; set; }
        
        public string Content { get; set; }

        public DateTime Insert_Date { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Task_Date { get; set; }

        public string Location { get; set; }

        public bool Completed { get; set; }

        public string UserID { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
