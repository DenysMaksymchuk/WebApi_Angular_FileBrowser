using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.Models
{
    public class FolderDetailedInfo
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public List<FileShortInfo> FilesList;
        public List<FolderDetailedInfo> FoldersList;
    }
}