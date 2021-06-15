using FactoryPattern.Abstract;
using FactoryPattern.Factory;
using FactoryPattern.ResourcesTypes;

namespace FactoryPattern.ConcreteFactory
{
    /// <summary>
    /// DemographicsFactory
    /// </summary>
    /// <seealso cref="FactoryPattern.Factory.ResourceFactory" />
    public class DemographicsFactory : ResourceFactory
    {
        private readonly object _payload;

        /// <summary>
        /// Initializes a new instance of the <see cref="DemographicsFactory"/> class.
        /// </summary>
        /// <param name="payload">The payload.</param>
        public DemographicsFactory(object payload)
        {
            _payload = payload;
        }

        /// <summary>
        /// Gets the resource.
        /// </summary>
        /// <returns>Resource</returns>
        public override Resource GetResource()
        {
            return new Demographics(_payload);
        }
    }
}
