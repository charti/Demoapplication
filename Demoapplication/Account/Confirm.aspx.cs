﻿using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Demoapplication.Models;

namespace Demoapplication.Account
{
    public partial class Confirm : Page
    {
        protected string StatusMessage
        {
            get;
            private set;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string code = IdentityHelper.GetCodeFromRequest(Request);
            string userId = IdentityHelper.GetUserIdFromRequest(Request);
            if (code != null && userId != null)
            {
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var result = manager.ConfirmEmail(userId, code);
                if (result.Succeeded)
                {
                    StatusMessage = "Danke, dass Sie Ihr Konto bestätigt haben.";
                    return;
                }
            }

            StatusMessage = "Fehler";
        }
    }
}