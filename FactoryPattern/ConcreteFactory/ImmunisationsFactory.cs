using FactoryPattern.Abstract;
using FactoryPattern.Factory;
using FactoryPattern.ResourcesTypes;

namespace FactoryPattern.ConcreteFactory
{
    /// <summary>
    /// ImmunisationsFactory
    /// </summary>
    /// <seealso cref="FactoryPattern.Factory.ResourceFactory" />
    public class ImmunisationsFactory : ResourceFactory
    {
        private readonly object _payload;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImmunisationsFactory"/> class.
        /// </summary>
        /// <param name="payload">The payload.</param>
        public ImmunisationsFactory(object payload)
        {
            _payload = payload;
        }

        /// <summary>
        /// Gets the resource.
        /// </summary>
        /// <returns>Resource</returns>
        public override Resource GetResource()
        {
            return new Immunisations(_payload);
        }
    }
}
