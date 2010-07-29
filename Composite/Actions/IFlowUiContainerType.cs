﻿

namespace Composite.Actions
{
    /// <summary>    
    /// </summary>
    /// <exclude />
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)] 
    public interface IFlowUiContainerType
    {
        string ContainerName { get; }
        ActionResultResponseType ActionResultResponseType { get; }
    }
}
