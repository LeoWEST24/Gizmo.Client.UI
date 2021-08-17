﻿using Microsoft.AspNetCore.Components;

namespace Gizmo.Client.UI
{
    public partial class App : ComponentBase
    {
        #region CONSTRUTCOR
        public App() : base()
        {
        }
        #endregion

        #region PROPERTIES
        
        /// <summary>
        /// Component discovery service.
        /// </summary>
        [Inject()]
        public IComponentDiscoveryService ComponentDiscoveryService
        {
            get;
            protected set;
        }

        #endregion
    }   
}
