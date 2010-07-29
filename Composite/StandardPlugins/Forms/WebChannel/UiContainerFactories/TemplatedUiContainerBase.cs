﻿using System.Web.UI;
using System.Collections.Generic;
using Composite.Forms.DataServices.UiControls;
using Composite.Forms.WebChannel;
using Composite.ResourceSystem;
using Composite.StandardPlugins.Forms.WebChannel.UiControlFactories;


namespace Composite.StandardPlugins.Forms.WebChannel.UiContainerFactories
{
    /// <summary>    
    /// </summary>
    /// <exclude />
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)] 
    public abstract class TemplatedUiContainerBase : UserControl
    {
        private IWebUiControl _webUiControl;
        public abstract Control GetFormPlaceHolder();
        public abstract Control GetMessagePlaceHolder();
        public abstract void SetContainerTitle(string title);
        public abstract void SetContainerIcon(ResourceHandle icon);

        internal void SetWebUiControlRef(IWebUiControl webUiControl)
        {
            _webUiControl = webUiControl;
        }

        protected override void OnInit(System.EventArgs e)
        {
            base.OnInit(e);

            if (this.IsPostBack == false)
            {
                _webUiControl.InitializeViewState();
            }
            else
            {
                if (_webUiControl is EmbeddedFormUiControl)
                {
                    var container = (_webUiControl as EmbeddedFormUiControl).CompiledUiControl as TemplatedContainerUiControl;
                    if(container != null)
                    {
                        container.InitializeLazyBindedControls();
                    }
                }
            }
        }

        public abstract void ShowFieldMessages(Dictionary<string, string> clientIDPathedMessages);
    }
}
