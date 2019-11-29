// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Booking.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class BookReservationServiceModel
    {
        /// <summary>
        /// Initializes a new instance of the BookReservationServiceModel
        /// class.
        /// </summary>
        public BookReservationServiceModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BookReservationServiceModel
        /// class.
        /// </summary>
        /// <param name="serviceId">The id of the service you want to
        /// book</param>
        /// <param name="amount">The optional amount for the service for each
        /// service date; It defaults to the service offer amount when not
        /// specified.</param>
        /// <param name="count">The number of services to book for each service
        /// date. It defaults to the service offer count when not
        /// specified.</param>
        /// <param name="dates">The optional dates you want to book the service
        /// for; if not specified the default service pattern will be used
        /// (e.g. whole stay).</param>
        public BookReservationServiceModel(string serviceId, MonetaryValueModel amount = default(MonetaryValueModel), int? count = default(int?), IList<Date> dates = default(IList<Date>))
        {
            Amount = amount;
            Count = count;
            Dates = dates;
            ServiceId = serviceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the optional amount for the service for each service
        /// date; It defaults to the service offer amount when not specified.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public MonetaryValueModel Amount { get; set; }

        /// <summary>
        /// Gets or sets the number of services to book for each service date.
        /// It defaults to the service offer count when not specified.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets the optional dates you want to book the service for;
        /// if not specified the default service pattern will be used (e.g.
        /// whole stay).
        /// </summary>
        [JsonProperty(PropertyName = "dates")]
        public IList<Date> Dates { get; set; }

        /// <summary>
        /// Gets or sets the id of the service you want to book
        /// </summary>
        [JsonProperty(PropertyName = "serviceId")]
        public string ServiceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServiceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServiceId");
            }
            if (Amount != null)
            {
                Amount.Validate();
            }
            if (Dates != null)
            {
                foreach (var element in Dates)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}