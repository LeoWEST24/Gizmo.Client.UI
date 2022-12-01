﻿using Gizmo.Client.UI.View.Services;
using Gizmo.Web.Api.Models;
using Gizmo.Web.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gizmo.Client.UI.Components
{
    public partial class QuantityPicker : CustomDOMComponentBase
    {
        [Parameter]
        public int Quantity { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnAddQuantityButtonClick { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnRemoveQuantityButtonClick { get; set; }

        public Task RemoveQuantity(MouseEventArgs args)
        {
            return OnAddQuantityButtonClick.InvokeAsync(args);
        }

        public Task AddQuantity(MouseEventArgs args)
        {
            return OnRemoveQuantityButtonClick.InvokeAsync(args);
        }
    }
}
