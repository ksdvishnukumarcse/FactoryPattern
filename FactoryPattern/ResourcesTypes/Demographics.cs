using FactoryPattern.Abstract;
using System.Collections.Generic;

namespace FactoryPattern.ResourcesTypes
{
    /// <summary>
    /// Demographics
    /// </summary>
    /// <seealso cref="FactoryPattern.Interfaces.IResource" />
    public class Demographics : Resource
    {
        private object _payload;

        /// <summary>
        /// Initializes a new instance of the <see cref="Demographics"/> class.
        /// </summary>
        /// <param name="payload">The payload.</param>
        public Demographics(object payload)
        {
            _payload = payload;
        }

        /// <summary>
        /// Gets the enrichment.
        /// </summary>
        /// <value>
        /// The enrichment.
        /// </value>
        public override List<string> Enrichment { get => new List<string> { "Enrichment1", "Enrichment2", "Enrichment3" }; }

        /// <summary>
        /// Gets or sets the payload.
        /// </summary>
        /// <value>
        /// The payload.
        /// </value>
        public override object Payload { get { return _payload; } set { _payload = value; } }
    }
}
