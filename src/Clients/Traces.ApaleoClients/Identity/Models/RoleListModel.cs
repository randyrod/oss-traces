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

    public partial class RoleListModel
    {
        /// <summary>
        /// Initializes a new instance of the RoleListModel class.
        /// </summary>
        public RoleListModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleListModel class.
        /// </summary>
        /// <param name="roles">A list of all existing roles</param>
        public RoleListModel(IList<string> roles)
        {
            Roles = roles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of all existing roles
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<string> Roles { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Roles == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Roles");
            }
        }
    }
}
