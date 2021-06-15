using FactoryPattern.Abstract;

namespace FactoryPattern.Factory
{
    /// <summary>
    /// ResourceFactory
    /// </summary>
    public abstract class ResourceFactory
    {
        /// <summary>
        /// Gets the resource.
        /// </summary>
        /// <returns>Resource</returns>
        public abstract Resource GetResource(); 
    }
}
