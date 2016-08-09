using AngularDemo.Models;
using AngularDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularDemo.Controllers
{
    [RoutePrefix("api/DirectoryDetails")]
    public class DirectoryDetailsController : ApiController
    {


        [HttpGet]
        [Route("{disk}/{*path}")]
        public FolderDetailedInfo Get([FromUri]string disk, [FromUri]string path)
        {
            return new FileBrowserService().GetDetailedInfoAboutFolder(disk + "://" + path);
        }


    }
}
