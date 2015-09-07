using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace PublicationPanelSearch.Config
{
    /// <summary>
    /// Represents a Extension Group.
    /// </summary>
    public class PublicationPanelSearchExtensionGroup : ExtensionGroup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PublicationPanelSearchExtensionGroup()
        {
            // Add the "PublicationPanelSearchResourceGroup" resource group as Extension to extend the resource "Tridion.Web.UI.Editors.CME.Views.Dashboard"
            AddExtension<PublicationPanelSearchResourceGroup>("Tridion.Web.UI.Editors.CME.Views.Dashboard");
        }
    }
}
