﻿using Gizmo.Client.UI.View.Services;
using Gizmo.Web.Components;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Client.UI.Pages
{
    [Route("/")]
    public partial class Login : CustomDOMComponentBase
    {
        [Inject]
        UserLoginService UserLoginService { get; set; }

        private void SelectLoginType(ICollection<Button> selectedItems)
        {
            if (selectedItems.Where(a => a.Name == "Username").Any())
                UserLoginService.ViewState.LoginType = View.UserLoginType.UsernameOrEmail;
            else
                UserLoginService.ViewState.LoginType = View.UserLoginType.MobilePhone;
        }

        protected override void OnInitialized()
        {
            this.SubscribeChange(UserLoginService.ViewState);
            base.OnInitialized();
        }

        public override void Dispose()
        {
            this.UnsubscribeChange(UserLoginService.ViewState);
            base.Dispose();
        }
    }
}