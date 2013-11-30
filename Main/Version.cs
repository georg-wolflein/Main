using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Stores the version number of an application. 
    /// </summary>
    public class Version
    {
        #region Properties
        
        /// <summary>
        /// The major version number number. 
        /// </summary>
        public ushort Major { get; set; }
        
        /// <summary>
        /// The minor version number. 
        /// </summary>
        public ushort Minor { get; set; }
        
        /// <summary>
        /// The build version number. 
        /// </summary>
        public ushort Build { get; set; }

        /// <summary>
        /// The revision version number. 
        /// </summary>
        public ushort Revision { get; set; }

        /// <summary>
        /// The type of version. 
        /// </summary>
        public VersionType Type { get; set; }

        #endregion

        #region Constructor
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Version"/> type. 
        /// </summary>
        /// <param name="major">The value of the major version. </param>
        /// <param name="minor">The value of the minor version. </param>
        /// <param name="build">The value of the build version. </param>
        /// <param name="revision">The value of the revision version. </param>
        /// <param name="type">The type of version. </param>
        public Version(ushort major, ushort minor, ushort build, ushort revision, VersionType type)
        {
            // Assign property values. 
            // Major version. 
            this.Major = major;

            // Minor version. 
            this.Minor = minor;

            // Build version. 
            this.Build = build;

            // Revision version. 
            this.Revision = revision;

            // Type of version. 
            this.Type = type;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a string that represents this version. 
        /// </summary>
        /// <param name="format">The format of the string. </param>
        /// <returns></returns>
        public string ToString(string format = "#TYPE# #MAJOR#.#MINOR#.#BUILD#.#REVISION#")
        {
            // Replace the version numbers with the placeholders. 
            // Major version. 
            format = format.Replace("#MAJOR#", Convert.ToString(this.Major));

            // Minor version. 
            format = format.Replace("#MINOR#", Convert.ToString(this.Minor.ToString()));

            // Build version. 
            format = format.Replace("#BUILD#", Convert.ToString(this.Build.ToString()));

            // Revision version. 
            format = format.Replace("#REVISION#", Convert.ToString(this.Revision.ToString()));

            // Type of version. 
            format = format.Replace("#TYPE#", Convert.ToString(this.Type.ToString()));

            // Return version value. 
            return format;
        }

        /// <summary>
        /// Returns a long string representation of this version. 
        /// </summary>
        /// <returns></returns>
        public string ToLongString()
        {
            return this.ToString("#TYPE# #MAJOR#.#MINOR#.#BUILD#.#REVISION#");
        }

        /// <summary>
        /// Returns a long short representation of this version. 
        /// </summary>
        /// <returns></returns>
        public string ToShortString()
        {
            return this.ToString("v#MAJOR#.#MINOR# #TYPE#");
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compare two <see cref="Version"/>s. 
        /// </summary>
        /// <param name="x">The first <see cref="Version"/>. </param>
        /// <param name="y">The other <see cref="Version"/>. </param>
        /// <returns></returns>
        public static bool operator ==(Version x, Version y)
        {
            return (
                (x.Major == y.Major) &&
                (x.Minor == y.Minor) &&
                (x.Build == y.Build) &&
                (x.Revision == y.Revision) &&
                (x.Type == y.Type)
                );
        }

        /// <summary>
        /// Compare two <see cref="Version"/>s and find out if they are unequal. 
        /// </summary>
        /// <param name="x">The first <see cref="Version"/>. </param>
        /// <param name="y">The other <see cref="Version"/>. </param>
        /// <returns></returns>
        public static bool operator !=(Version x, Version y)
        {
            return (!(x == y));
        }

        #endregion
    }
}
