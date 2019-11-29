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

    public partial class GuestModel
    {
        /// <summary>
        /// Initializes a new instance of the GuestModel class.
        /// </summary>
        public GuestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GuestModel class.
        /// </summary>
        /// <param name="lastName">Last name of the guest</param>
        /// <param name="address">Address of the guest</param>
        /// <param name="birthDate">Guest's birthdate</param>
        /// <param name="company">The company of the guest, which will be
        /// displayed on the invoice.</param>
        /// <param name="email">Email address of the guest</param>
        /// <param name="firstName">First name of the guest</param>
        /// <param name="gender">Gender of the booker. Possible values include:
        /// 'Female', 'Male', 'Other'</param>
        /// <param name="identificationNumber">The guest's identification
        /// number for the given identificationType.</param>
        /// <param name="identificationType">The type of the
        /// identificationNumber. Possible values include:
        /// 'SocialInsuranceNumber', 'PassportNumber', 'IdNumber',
        /// 'DriverLicenseNumber'</param>
        /// <param name="middleInitial">Middle initial of the guest</param>
        /// <param name="nationalityCountryCode">The guest's nationality, in
        /// ISO 3166-1 alpha-2 code</param>
        /// <param name="phone">Phone number of the guest</param>
        /// <param name="preferredLanguage">Two-letter code (ISO Alpha-2) of a
        /// language preferred for contact</param>
        /// <param name="title">Title of the guest. Possible values include:
        /// 'Mr', 'Ms', 'Dr', 'Prof', 'Other'</param>
        public GuestModel(string lastName, PersonAddressModel address = default(PersonAddressModel), System.DateTime? birthDate = default(System.DateTime?), PersonCompanyModel company = default(PersonCompanyModel), string email = default(string), string firstName = default(string), string gender = default(string), string identificationNumber = default(string), string identificationType = default(string), string middleInitial = default(string), string nationalityCountryCode = default(string), string phone = default(string), string preferredLanguage = default(string), string title = default(string))
        {
            Address = address;
            BirthDate = birthDate;
            Company = company;
            Email = email;
            FirstName = firstName;
            Gender = gender;
            IdentificationNumber = identificationNumber;
            IdentificationType = identificationType;
            LastName = lastName;
            MiddleInitial = middleInitial;
            NationalityCountryCode = nationalityCountryCode;
            Phone = phone;
            PreferredLanguage = preferredLanguage;
            Title = title;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets address of the guest
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public PersonAddressModel Address { get; set; }

        /// <summary>
        /// Gets or sets guest's birthdate
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "birthDate")]
        public System.DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the company of the guest, which will be displayed on
        /// the invoice.
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public PersonCompanyModel Company { get; set; }

        /// <summary>
        /// Gets or sets email address of the guest
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets first name of the guest
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets gender of the booker. Possible values include:
        /// 'Female', 'Male', 'Other'
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the guest's identification number for the given
        /// identificationType.
        /// </summary>
        [JsonProperty(PropertyName = "identificationNumber")]
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the identificationNumber. Possible values
        /// include: 'SocialInsuranceNumber', 'PassportNumber', 'IdNumber',
        /// 'DriverLicenseNumber'
        /// </summary>
        [JsonProperty(PropertyName = "identificationType")]
        public string IdentificationType { get; set; }

        /// <summary>
        /// Gets or sets last name of the guest
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets middle initial of the guest
        /// </summary>
        [JsonProperty(PropertyName = "middleInitial")]
        public string MiddleInitial { get; set; }

        /// <summary>
        /// Gets or sets the guest's nationality, in ISO 3166-1 alpha-2 code
        /// </summary>
        [JsonProperty(PropertyName = "nationalityCountryCode")]
        public string NationalityCountryCode { get; set; }

        /// <summary>
        /// Gets or sets phone number of the guest
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets two-letter code (ISO Alpha-2) of a language preferred
        /// for contact
        /// </summary>
        [JsonProperty(PropertyName = "preferredLanguage")]
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// Gets or sets title of the guest. Possible values include: 'Mr',
        /// 'Ms', 'Dr', 'Prof', 'Other'
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LastName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LastName");
            }
        }
    }
}