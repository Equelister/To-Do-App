﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class FileUploadModel : TaskModel
    {
        public byte[] Data { get; set; }
    }
}