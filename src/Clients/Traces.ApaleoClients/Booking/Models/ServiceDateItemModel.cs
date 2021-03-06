// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Booking.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ServiceDateItemModel
    {
        /// <summary>
        /// Initializes a new instance of the ServiceDateItemModel class.
        /// </summary>
        public ServiceDateItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceDateItemModel class.
        /// </summary>
        /// <param name="amount">The total price for all booked
        /// services</param>
        /// <param name="count">The count of booked services</param>
        /// <param name="serviceDate">The date this service is
        /// delivered</param>
        public ServiceDateItemModel(AmountModel amount, int count, System.DateTime serviceDate)
        {
            Amount = amount;
            Count = count;
            ServiceDate = serviceDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the total price for all booked services
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public AmountModel Amount { get; set; }

        /// <summary>
        /// Gets or sets the count of booked services
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the date this service is delivered
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "serviceDate")]
        public System.DateTime ServiceDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Amount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Amount");
            }
            if (Amount != null)
            {
                Amount.Validate();
            }
        }
    }
}
