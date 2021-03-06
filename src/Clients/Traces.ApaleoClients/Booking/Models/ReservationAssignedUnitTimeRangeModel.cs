// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Booking.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ReservationAssignedUnitTimeRangeModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReservationAssignedUnitTimeRangeModel class.
        /// </summary>
        public ReservationAssignedUnitTimeRangeModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ReservationAssignedUnitTimeRangeModel class.
        /// </summary>
        /// <param name="fromProperty">The start date and time of the period
        /// for which the unit is assigned to the reservation&lt;br
        /// /&gt;Specify a date and time (without fractional second part) in
        /// UTC or with UTC offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="to">The end date and time of the period for which the
        /// unit is assigned to the reservation&lt;br /&gt;Specify a date and
        /// time (without fractional second part) in UTC or with UTC offset as
        /// defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        public ReservationAssignedUnitTimeRangeModel(System.DateTime fromProperty, System.DateTime to)
        {
            FromProperty = fromProperty;
            To = to;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the start date and time of the period for which the
        /// unit is assigned to the reservation&amp;lt;br /&amp;gt;Specify a
        /// date and time (without fractional second part) in UTC or with UTC
        /// offset as defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public System.DateTime FromProperty { get; set; }

        /// <summary>
        /// Gets or sets the end date and time of the period for which the unit
        /// is assigned to the reservation&amp;lt;br /&amp;gt;Specify a date
        /// and time (without fractional second part) in UTC or with UTC offset
        /// as defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public System.DateTime To { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
