using System.Collections.Generic;

namespace DotNetCoreAPI
{
    /// <summary>
    /// Criterion Class
    /// </summary>
    public class Criterion
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the property.
        /// </summary>
        /// <value>
        /// The property.
        /// </value>
        public EligibilityProperty Property { get; set; }

        /// <summary>
        /// Gets or sets the eligibility mode.
        /// </summary>
        /// <value>
        /// The eligibility mode.
        /// </value>
        public EligibilityMode EligibilityMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is activated.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is activated; otherwise, <c>false</c>.
        /// </value>
        public bool IsActivated { get; set; }

        /// <summary>
        /// Gets the type of the property data.
        /// </summary>
        /// <value>
        /// The type of the property data.
        /// </value>
        public string PropertyDataType { get; set; }

        /// <summary>
        /// The value to verify
        /// </summary>
        public EligibilityValue Value { get; set; }

        /// <summary>
        /// List of values
        /// </summary>
        public IReadOnlyCollection<EligibilityValue> ValueList { get; set; }        
    }
}
