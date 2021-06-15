using FactoryPattern.Abstract;
using FactoryPattern.Factory;
using FactoryPattern.ResourcesTypes;

namespace FactoryPattern.ConcreteFactory
{
    /// <summary>
    /// AllergiesFactory
    /// </summary>
    /// <seealso cref="FactoryPattern.Factory.ResourceFactory" />
    public class AllergiesFactory : ResourceFactory
    {
        private readonly object _payload;

        /// <summary>
        /// Initializes a new instance of the <see cref="AllergiesFactory"/> class.
        /// </summary>
        /// <param name="payload">The payload.</param>
        public AllergiesFactory(object payload)
        {
            _payload = payload;
        }

        /// <summary>
        /// Gets the resource.
        /// </summary>
        /// <returns>Resource</returns>
        public override Resource GetResource()
        {
            return new Allergies(_payload);
        }
    }
}
