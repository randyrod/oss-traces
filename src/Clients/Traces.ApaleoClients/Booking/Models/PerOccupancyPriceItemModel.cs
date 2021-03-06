// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Booking.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PerOccupancyPriceItemModel
    {
        /// <summary>
        /// Initializes a new instance of the PerOccupancyPriceItemModel class.
        /// </summary>
        public PerOccupancyPriceItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PerOccupancyPriceItemModel class.
        /// </summary>
        /// <param name="adults">Number of adults</param>
        /// <param name="price">The price for this offer</param>
        public PerOccupancyPriceItemModel(int adults, PriceModel price)
        {
            Adults = adults;
            Price = price;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of adults
        /// </summary>
        [JsonProperty(PropertyName = "adults")]
        public int Adults { get; set; }

        /// <summary>
        /// Gets or sets the price for this offer
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public PriceModel Price { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Price == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Price");
            }
            if (Price != null)
            {
                Price.Validate();
            }
        }
    }
}
