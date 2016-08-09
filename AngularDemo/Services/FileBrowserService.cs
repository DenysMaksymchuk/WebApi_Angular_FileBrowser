using AngularDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AngularDemo.Services
{
    public class FileBrowserService
    {
        public FolderDetailedInfo GetDetailedInfoAboutFolder(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            return getDirectoryTree(dirInfo);
        }
        private FolderDetailedInfo getDirectoryTree(DirectoryInfo root)
        {
            //FileInfo[] files = null;
            //DirectoryInfo[] subDir = null;
            FolderDetailedInfo folderDetailedInfo = new FolderDetailedInfo
            {
                Path = root.FullName,
                Name = root.Name
            };

            folderDetailedInfo.FilesList = root.GetFiles()
                .Select(arg =>
                    new FileShortInfo
                    {
                        Name = arg.Name,
                        SizeInByte = arg.Length
                    }
               ).ToList();
            folderDetailedInfo.FoldersList = root.GetDirectories()
                .Select(arg =>
                       getDirectoryTree(arg)
                ).ToList();
            return folderDetailedInfo;
        }
    }
}