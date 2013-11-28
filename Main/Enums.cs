using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// The development stage of a version. 
    /// </summary>
    public enum VersionType : ushort
    {
        /// <summary>
        /// The build is stable and tested. (Alpha)
        /// </summary>
        Alpha = 1,

        /// <summary>
        /// The build is not stable. (Beta)
        /// </summary>
        Beta = 2
    }
}
