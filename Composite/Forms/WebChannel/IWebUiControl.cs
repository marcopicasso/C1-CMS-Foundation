using System.Web.UI;


namespace Composite.Forms.WebChannel
{
    /// <summary>    
    /// </summary>
    /// <exclude />
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)] 
    public interface IWebUiControl : IUiControl
    {
        Control BuildWebControl();
        void InitializeViewState();
        string ClientName { get; }
        bool IsFullWidthControl { get; }
    }
}
