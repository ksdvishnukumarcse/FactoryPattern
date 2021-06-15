using FactoryPattern.Abstract;
using System.Collections.Generic;

namespace FactoryPattern.ResourcesTypes
{
    /// <summary>
    /// Allergies
    /// </summary>
    /// <seealso cref="FactoryPattern.Abstract.IResource" />
    public class Allergies : Resource
    {
        private object _payload;

        /// <summary>
        /// Initializes a new instance of the <see cref="Allergies"/> class.
        /// </summary>
        /// <param name="payload">The payload.</param>
        public Allergies(object payload)
        {
            _payload = payload;
        }

        /// <summary>
        /// Gets the enrichment.
        /// </summary>
        /// <value>
        /// The enrichment.
        /// </value>
        public override List<string> Enrichment { get => new List<string> { "Enrichment4", "Enrichment5", "Enrichment6" }; }

        /// <summary>
        /// Gets or sets the payload.
        /// </summary>
        /// <value>
        /// The payload.
        /// </value>
        public override object Payload { get { return _payload; } set { _payload = value; } }
    }
}
