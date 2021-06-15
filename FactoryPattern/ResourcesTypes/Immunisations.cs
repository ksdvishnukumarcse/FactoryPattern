using FactoryPattern.Abstract;
using System.Collections.Generic;

namespace FactoryPattern.ResourcesTypes
{
    /// <summary>
    /// Immunisations
    /// </summary>
    /// <seealso cref="FactoryPattern.Abstract.IResource" />
    public class Immunisations : Resource
    {
        private object _payload;

        /// <summary>
        /// Initializes a new instance of the <see cref="Immunisations"/> class.
        /// </summary>
        /// <param name="payload">The payload.</param>
        public Immunisations(object payload)
        {
            _payload = payload;
        }

        /// <summary>
        /// Gets the enrichment.
        /// </summary>
        /// <value>
        /// The enrichment.
        /// </value>
        public override List<string> Enrichment { get => new List<string> { "Enrichment7", "Enrichment8", "Enrichment9" }; }

        /// <summary>
        /// Gets or sets the payload.
        /// </summary>
        /// <value>
        /// The payload.
        /// </value>
        public override object Payload { get { return _payload; } set { _payload = value; } }
    }
}
