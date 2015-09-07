using Alchemy4Tridion.Plugins.GUI.Configuration;
using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;

namespace PublicationPanelSearch.Config
{
    /// <summary>
    /// Represents the ResourceGroup element within the editor configuration that contains this plugin's files
    /// and references.
    /// </summary>
    public class PublicationPanelSearchResourceGroup : ResourceGroup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PublicationPanelSearchResourceGroup()
        {

            // When adding files you only need to specify the filename and not full path
            AddFile("sieve.js");
            AddFile("PublicationPanelSearch.js");
            AddFile("Style.css");

            // Adding the JQuery dependancy
            Dependencies.AddLibraryJQuery();
            //Dependencies.AddAlchemyCore();

        }
    }
}
