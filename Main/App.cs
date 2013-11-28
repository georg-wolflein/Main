using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{

    /// <summary>
    /// Uniform application characteristics and behaviour are ensured in this class. 
    /// </summary>
    public class App
    {
        #region Properties

        /// <summary>
        /// The name of the application. 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The application version. 
        /// </summary>
        public Version Version { get; set; }

        /// <summary>
        /// The application's icon. 
        /// </summary>
        public Icon Icon { get; set; }

        /// <summary>
        /// The application information that should be displayed on title bars. 
        /// </summary>
        public string Info
        {
            get
            {
                return this.Name + " (" + this.Version.ToLongString() + ")";
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of a <see cref="App"/> type. 
        /// </summary>
        /// <param name="name">The name of the application. </param>
        /// <param name="version">The current application version. </param>
        /// <param name="icon">The application icon. </param>
        public App(string name = "", Version version = null, Icon icon = null)
        {
            // Assign property values. 
            // Application name. 
            this.Name = name;

            // Application version. 
            this.Version = version;

            // Application icon.
            this.Icon = icon;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Generates the text that should be shown on the title bar. 
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public string GenerateWindowText(string description = "")
        {
            // Check if the description is nothing or empty. 
            if (description == null || description == "")
            {
                // Only return the application info if the description is empty. 
                return this.Info;
            }
            else
            {
                // Return the description followed by the application info if the description contains text. 
                return description + " - " + this.Info;
            }
        }

        /// <summary>
        /// Configures the given Form to match uniform behaviour. 
        /// </summary>
        /// <param name="window">The Form that should be configured. </param>
        /// <param name="description">Optionally give a decription of the Form to show in the title. If this is not set, the current window text will be used. </param>
        public void ConfigureWindow(ref Form window, string description = "")
        {
            // If description is empty, take the form's title. 
            if (description == null || description == "") description = window.Text;
            
            // Only set the window text if it does not already end with the application info. 
            if (!description.EndsWith(this.Info))
            {
                // Set the window text. 
                window.Text = GenerateWindowText(description);
            }

            // Try to set the icon as well. 
            if (this.Icon != null) window.Icon = this.Icon;
        }

        #endregion
    }
}
