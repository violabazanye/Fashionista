// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	IViewModel.tt
// Version:		2.0
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// makeuptutorials_Detail ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Imakeuptutorials_DetailViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentRssSearchResult property.
        /// </summary>
		EntitiesBase.RssSearchResult CurrentRssSearchResult { get; set; }
        /// <summary>
        /// Gets/Sets the HasNextpanoramamakeuptutorials_Detail0 property.
        /// </summary>
		bool HasNextpanoramamakeuptutorials_Detail0 { get; set; }
        /// <summary>
        /// Gets/Sets the HasPreviouspanoramamakeuptutorials_Detail0 property.
        /// </summary>
		bool HasPreviouspanoramamakeuptutorials_Detail0 { get; set; }
        
        /// <summary>
        /// Gets the TextToSpeechmakeuptutorials_DetailStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechmakeuptutorials_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the Sharemakeuptutorials_DetailStaticControlCommand command.
        /// </summary>
		ICommand Sharemakeuptutorials_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartmakeuptutorials_DetailStaticControlCommand command.
        /// </summary>
		ICommand PinToStartmakeuptutorials_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the GoToSourcemakeuptutorials_DetailStaticControlCommand command.
        /// </summary>
		ICommand GoToSourcemakeuptutorials_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the Nextpanoramamakeuptutorials_Detail0 command.
        /// </summary>
		ICommand Nextpanoramamakeuptutorials_Detail0 { get; }

        
        /// <summary>
        /// Gets the Previouspanoramamakeuptutorials_Detail0 command.
        /// </summary>
		ICommand Previouspanoramamakeuptutorials_Detail0 { get; }

	}
}