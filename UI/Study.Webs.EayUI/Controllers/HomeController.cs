﻿using Study.Webs.EayUI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Study.Webs.EayUI.Controllers
{
    public class HomeController : ManageControllerBase
    {
        public string GetTree()
        {
            return "[{\"id\": 1,\"text\": \"应用程序管理\",\"attributes\":{ \"url\":\"/systems/application\"}}]";
        }
    }
}