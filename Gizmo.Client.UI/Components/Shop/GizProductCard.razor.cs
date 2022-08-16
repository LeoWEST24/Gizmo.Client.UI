﻿using Gizmo.Client.UI.ViewModels;
using Gizmo.Web.Components;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Gizmo.Client.UI.Components
{
    public partial class GizProductCard : CustomDOMComponentBase
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Parameter]
        public bool IsHoverable { get; set; }

        [Parameter]
        public ProductViewModel Product { get; set; }

        [Parameter]
        public EventCallback<int> OnAddProduct { get; set; }

        public async Task AddProduct()
        {
            await OnAddProduct.InvokeAsync(Product.Id);
        }

        public void OpenDetails()
        {
            NavigationManager.NavigateTo($"/productdetails/{Product.Id}");
        }
    }
}