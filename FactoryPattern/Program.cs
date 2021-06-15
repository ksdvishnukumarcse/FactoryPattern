using FactoryPattern.ConcreteFactory;
using FactoryPattern.Factory;
using System;

namespace FactoryPattern
{
    /// <summary>
    /// Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            var demographicsObj = GetResourceObject(ResourceType.Demographics);
            var demographicsData = demographicsObj.GetResource();
            Console.WriteLine($"Object value is {demographicsData.Payload} and Enrichments are {string.Join(", ", demographicsData.Enrichment)}");

            var allergiesObj = GetResourceObject(ResourceType.Allergies);
            var allergiesData = allergiesObj.GetResource();
            Console.WriteLine($"Object value is {allergiesData.Payload} and Enrichments are {string.Join(", ", allergiesData.Enrichment)}");

            var immunisationsObj = GetResourceObject(ResourceType.Immunisations);
            var immunisationsData = immunisationsObj.GetResource();
            Console.WriteLine($"Object value is {immunisationsData.Payload} and Enrichments are {string.Join(", ", immunisationsData.Enrichment)}");

            Console.ReadLine();
        }

        /// <summary>
        /// Gets the resource object.
        /// </summary>
        /// <param name="resourceType">Type of the resource.</param>
        /// <returns>ResourceFactory</returns>
        public static ResourceFactory GetResourceObject(ResourceType resourceType)
        {
            switch (resourceType)
            {
                case ResourceType.Demographics:
                    return new DemographicsFactory("Demographics");
                case ResourceType.Allergies:
                    return new AllergiesFactory("Allergies");
                case ResourceType.Immunisations:
                    return new ImmunisationsFactory("Immunisations");
            }
            return null;
        }

        /// <summary>
        /// ResourceType
        /// </summary>
        public enum ResourceType
        {
            Demographics,
            Allergies,
            Immunisations
        }
    }
}
