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

    /// <summary>
    /// With this request you can create a group booking request
    /// </summary>
    public partial class CreateGroupModel
    {
        /// <summary>
        /// Initializes a new instance of the CreateGroupModel class.
        /// </summary>
        public CreateGroupModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateGroupModel class.
        /// </summary>
        /// <param name="booker">The person requesting the group
        /// booking</param>
        /// <param name="name">Name of the group</param>
        /// <param name="propertyIds">List of property ids the group booking
        /// belongs to</param>
        /// <param name="bookerComment">Additional information and comment by
        /// the booker</param>
        /// <param name="comment">Additional information and comments</param>
        /// <param name="paymentAccount">Payment information</param>
        public CreateGroupModel(BookerModel booker, string name, IList<string> propertyIds, string bookerComment = default(string), string comment = default(string), CreatePaymentAccountModel paymentAccount = default(CreatePaymentAccountModel))
        {
            Booker = booker;
            BookerComment = bookerComment;
            Comment = comment;
            Name = name;
            PaymentAccount = paymentAccount;
            PropertyIds = propertyIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the person requesting the group booking
        /// </summary>
        [JsonProperty(PropertyName = "booker")]
        public BookerModel Booker { get; set; }

        /// <summary>
        /// Gets or sets additional information and comment by the booker
        /// </summary>
        [JsonProperty(PropertyName = "bookerComment")]
        public string BookerComment { get; set; }

        /// <summary>
        /// Gets or sets additional information and comments
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets name of the group
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets payment information
        /// </summary>
        [JsonProperty(PropertyName = "paymentAccount")]
        public CreatePaymentAccountModel PaymentAccount { get; set; }

        /// <summary>
        /// Gets or sets list of property ids the group booking belongs to
        /// </summary>
        [JsonProperty(PropertyName = "propertyIds")]
        public IList<string> PropertyIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Booker == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Booker");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (PropertyIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PropertyIds");
            }
            if (Booker != null)
            {
                Booker.Validate();
            }
            if (PaymentAccount != null)
            {
                PaymentAccount.Validate();
            }
        }
    }
}