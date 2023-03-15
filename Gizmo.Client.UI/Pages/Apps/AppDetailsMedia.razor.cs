﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gizmo.Client.UI.View.Services;
using Gizmo.Client.UI.View.States;
using Gizmo.Web.Components;
using Microsoft.AspNetCore.Components;

namespace Gizmo.Client.UI.Pages
{
    public partial class AppDetailsMedia : CustomDOMComponentBase
    {
        private IEnumerable<AppLinkViewState> _appLinksViewState = Enumerable.Empty<AppLinkViewState>();

        #region PROPERTIES

        [Inject]
        AppLinkViewStateLookupService AppLinkViewStateLookupService { get; set; }

        [Parameter]
        public int ApplicationId { get; set; }

        #endregion

        protected override async Task OnInitializedAsync()
        {
            var appLinks = await AppLinkViewStateLookupService.GetStatesAsync();
            _appLinksViewState = appLinks.Where(exe => exe.ApplicationId == ApplicationId);

            await base.OnInitializedAsync();
        }
    }
}
