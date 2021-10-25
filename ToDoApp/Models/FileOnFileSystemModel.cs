using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class FileOnFileSystemModel : FileModel
    {
        public string FilePath { get; set; }
    }
}
