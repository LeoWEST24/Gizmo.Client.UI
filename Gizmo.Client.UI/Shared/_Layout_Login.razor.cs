﻿using Gizmo.Client.UI.View.States;
using Gizmo.Client.UI.ViewModels;
using Gizmo.UI.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Gizmo.Client.UI.Shared
{
    public partial class _Layout_Login : LayoutComponentBase
    {
        /// <summary>
        /// Gets client version view state.
        /// </summary>
        [Inject()]
        private ClientVersionViewState ClientVersionViewState
        {
            get; set;
        }

        [Inject]
        IOptions<ClientUIOptions> ClientUIOptions { get; set; }

        [Inject]
        ILocalizationService LocalizationService { get; set; }
    }
}
