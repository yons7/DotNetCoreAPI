using System.Collections.Generic;

namespace DotNetCoreAPI
{
    /// <summary>
    /// EligibilityValue class
    /// </summary>
    public class EligibilityValue
    {
        /// <summary>
        /// List of values
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Minimum value of the criterion
        /// </summary>
        public int? MinValue { get; set; }

        /// <summary>
        /// Maximum value of the criterion
        /// </summary>
        public int? MaxValue { get; set; }        
    }
}
