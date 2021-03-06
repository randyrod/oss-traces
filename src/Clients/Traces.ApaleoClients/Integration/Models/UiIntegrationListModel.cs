// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Integration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UiIntegrationListModel
    {
        /// <summary>
        /// Initializes a new instance of the UiIntegrationListModel class.
        /// </summary>
        public UiIntegrationListModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UiIntegrationListModel class.
        /// </summary>
        public UiIntegrationListModel(long count, IList<UiIntegrationItemModel> uiIntegrations)
        {
            Count = count;
            UiIntegrations = uiIntegrations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long Count { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uiIntegrations")]
        public IList<UiIntegrationItemModel> UiIntegrations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UiIntegrations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UiIntegrations");
            }
            if (UiIntegrations != null)
            {
                foreach (var element in UiIntegrations)
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
