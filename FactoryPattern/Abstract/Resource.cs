using System.Collections.Generic;

namespace FactoryPattern.Abstract
{
    /// <summary>
    /// Resource
    /// </summary>
    public abstract class Resource
    {
        /// <summary>
        /// Gets the enrichment.
        /// </summary>
        /// <value>
        /// The enrichment.
        /// </value>
        public abstract List<string> Enrichment { get; }

        /// <summary>
        /// Gets or sets the payload.
        /// </summary>
        /// <value>
        /// The payload.
        /// </value>
        public abstract object Payload { get; set; }
    }
}
