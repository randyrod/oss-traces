// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Identity.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AccountUsersListModel
    {
        /// <summary>
        /// Initializes a new instance of the AccountUsersListModel class.
        /// </summary>
        public AccountUsersListModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountUsersListModel class.
        /// </summary>
        /// <param name="accountUsers">A collection of users that have access
        /// to the current account</param>
        public AccountUsersListModel(IList<AccountUserModel> accountUsers)
        {
            AccountUsers = accountUsers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of users that have access to the current
        /// account
        /// </summary>
        [JsonProperty(PropertyName = "accountUsers")]
        public IList<AccountUserModel> AccountUsers { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccountUsers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountUsers");
            }
            if (AccountUsers != null)
            {
                foreach (var element in AccountUsers)
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
