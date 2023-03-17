﻿using System.Threading.Tasks;
using Gizmo.Client.UI.View.Services;
using Gizmo.Client.UI.View.States;
using Gizmo.Web.Components;
using Microsoft.AspNetCore.Components;

namespace Gizmo.Client.UI.Components
{
    public partial class GizDockItemExecutionState : CustomDOMComponentBase
    {
        private AppExeExecutionViewState _appExeExecutionViewState { get; set; }

        [Inject()]
        AppExeExecutionViewStateLookupService AppExeExecutionViewStateLookupService { get; set; }

        [Parameter]
        public int ExecutableId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _appExeExecutionViewState = await AppExeExecutionViewStateLookupService.GetStateAsync(ExecutableId);
            this.SubscribeChange(_appExeExecutionViewState);

            await base.OnInitializedAsync();
        }

        public override void Dispose()
        {
            this.UnsubscribeChange(_appExeExecutionViewState);

            base.Dispose();
        }
    }
}
