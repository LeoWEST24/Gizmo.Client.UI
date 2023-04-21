﻿using Gizmo.Client.UI.View.Services;
using Gizmo.Client.UI.View.States;
using Gizmo.UI;
using Gizmo.UI.Services;
using Gizmo.Web.Components;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Gizmo.Client.UI.Pages
{
    [DefaultRoute(ClientRoutes.UserProfileRoute, DefaultRouteMatch = NavlinkMatch.Prefix)]
    [Route(ClientRoutes.UserProfileRoute)]
    public partial class Profile : CustomDOMComponentBase
    {
        [Inject]
        ILocalizationService LocalizationService { get; set; }

        [Inject]
        UserProfileViewStateService UserService { get; set; }

        [Inject]
        UserChangeProfileViewStateService UserChangeProfileViewStateService { get; set; }

        [Inject]
        UserChangePasswordViewStateService UserChangePasswordViewStateService { get; set; }

        [Inject]
        UserProfileViewState ViewState { get; set; }

        private async Task OnClickUpdateProfileButtonHandler()
        {
            await UserChangeProfileViewStateService.StartAsync();
        }

        private async Task OnClickUpdateEmailButtonHandler()
        {
            //var s = await DialogService.ShowChangeEmailDialogAsync();
            //if (s.Result == DialogAddResult.Success)
            //{
            //    try
            //    {
            //        var result = await s.WaitForDialogResultAsync();
            //    }
            //    catch (OperationCanceledException)
            //    {
            //    }
            //}
        }

        private async Task OnClickUpdateMobileButtonHandler()
        {
            //var s = await DialogService.ShowChangeMobileDialogAsync();
            //if (s.Result == DialogAddResult.Success)
            //{
            //    try
            //    {
            //        var result = await s.WaitForDialogResultAsync();
            //    }
            //    catch (OperationCanceledException)
            //    {
            //    }
            //}
        }

        private async Task OnClickChangePasswordButtonHandler()
        {
            await UserChangePasswordViewStateService.StartAsync();
        }

        private async Task OnClickChangePictureButtonHandler()
        {
            //var s = await DialogService.ShowChangePictureDialogAsync();
            //if (s.Result == DialogAddResult.Success)
            //{
            //    try
            //    {
            //        var result = await s.WaitForDialogResultAsync();
            //    }
            //    catch (OperationCanceledException)
            //    {
            //    }
            //}
        }

        protected override void OnInitialized()
        {
            this.SubscribeChange(ViewState);

            base.OnInitialized();
        }

        public override void Dispose()
        {
            this.UnsubscribeChange(ViewState);

            base.Dispose();
        }
    }
}
