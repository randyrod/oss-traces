// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Identity
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IdentityApi.
    /// </summary>
    public static partial class IdentityApiExtensions
    {
            /// <summary>
            /// Returns a list of invitations for the current account
            /// </summary>
            /// <remarks>
            /// Returns a list of all invitations to the current account.&lt;br&gt;Scopes
            /// required: 'identity:account-users.manage, identity:account-users.read'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='propertyId'>
            /// </param>
            public static InvitationListModel ApiAccountInvitationsGet(this IIdentityApi operations, string propertyId = default(string))
            {
                return operations.ApiAccountInvitationsGetAsync(propertyId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of invitations for the current account
            /// </summary>
            /// <remarks>
            /// Returns a list of all invitations to the current account.&lt;br&gt;Scopes
            /// required: 'identity:account-users.manage, identity:account-users.read'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='propertyId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvitationListModel> ApiAccountInvitationsGetAsync(this IIdentityApi operations, string propertyId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiAccountInvitationsGetWithHttpMessagesAsync(propertyId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Invites a user to the current account
            /// </summary>
            /// <remarks>
            /// Invites a person to the current account with the requested roles and
            /// properties.&lt;br /&gt;
            /// When you specify 'IsAccountAdmin', the user will automatically have access
            /// to all properties in all roles.&lt;br /&gt;
            /// The &lt;i&gt;user&lt;/i&gt; will only be created or linked to the account,
            /// when the person accepts the invitation.&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static MessageItemCollection ApiAccountInvitationsPost(this IIdentityApi operations, CreateInvitationModel request = default(CreateInvitationModel))
            {
                return operations.ApiAccountInvitationsPostAsync(request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Invites a user to the current account
            /// </summary>
            /// <remarks>
            /// Invites a person to the current account with the requested roles and
            /// properties.&lt;br /&gt;
            /// When you specify 'IsAccountAdmin', the user will automatically have access
            /// to all properties in all roles.&lt;br /&gt;
            /// The &lt;i&gt;user&lt;/i&gt; will only be created or linked to the account,
            /// when the person accepts the invitation.&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MessageItemCollection> ApiAccountInvitationsPostAsync(this IIdentityApi operations, CreateInvitationModel request = default(CreateInvitationModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiAccountInvitationsPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of users for the current account
            /// </summary>
            /// <remarks>
            /// Returns a list of all users that have access to the current
            /// account.&lt;br&gt;Scopes required: 'identity:account-users.manage,
            /// identity:account-users.read'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static AccountUsersListModel ApiAccountUsersGet(this IIdentityApi operations)
            {
                return operations.ApiAccountUsersGetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of users for the current account
            /// </summary>
            /// <remarks>
            /// Returns a list of all users that have access to the current
            /// account.&lt;br&gt;Scopes required: 'identity:account-users.manage,
            /// identity:account-users.read'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccountUsersListModel> ApiAccountUsersGetAsync(this IIdentityApi operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiAccountUsersGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Allows to modify an account user
            /// </summary>
            /// <remarks>
            /// Allows to modify an account user. Only modification of Enabled status and
            /// Roles are allowed.&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='email'>
            /// </param>
            /// <param name='requestBody'>
            /// </param>
            public static MessageItemCollection ApiAccountUsersByEmailPatch(this IIdentityApi operations, string email, IList<Operation> requestBody = default(IList<Operation>))
            {
                return operations.ApiAccountUsersByEmailPatchAsync(email, requestBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Allows to modify an account user
            /// </summary>
            /// <remarks>
            /// Allows to modify an account user. Only modification of Enabled status and
            /// Roles are allowed.&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='email'>
            /// </param>
            /// <param name='requestBody'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MessageItemCollection> ApiAccountUsersByEmailPatchAsync(this IIdentityApi operations, string email, IList<Operation> requestBody = default(IList<Operation>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiAccountUsersByEmailPatchWithHttpMessagesAsync(email, requestBody, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a static list of all roles.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static RoleListModel ApiRolesGet(this IIdentityApi operations)
            {
                return operations.ApiRolesGetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a static list of all roles.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleListModel> ApiRolesGetAsync(this IIdentityApi operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiRolesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of users for the current account.
            /// </summary>
            /// <remarks>
            /// Returns a list of all users that have access to the current
            /// account.&lt;br&gt;Scopes required: 'identity:account-users.manage,
            /// identity:account-users.read'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='propertyIds'>
            /// </param>
            public static UsersListModel ApiUsersGet(this IIdentityApi operations, IList<string> propertyIds = default(IList<string>))
            {
                return operations.ApiUsersGetAsync(propertyIds).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of users for the current account.
            /// </summary>
            /// <remarks>
            /// Returns a list of all users that have access to the current
            /// account.&lt;br&gt;Scopes required: 'identity:account-users.manage,
            /// identity:account-users.read'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='propertyIds'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UsersListModel> ApiUsersGetAsync(this IIdentityApi operations, IList<string> propertyIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiUsersGetWithHttpMessagesAsync(propertyIds, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a user for the current account.
            /// </summary>
            /// <remarks>
            /// Returns a user in the current account for a specific subjectId or email
            /// address.&lt;br&gt;Scopes required: 'identity:account-users.manage,
            /// identity:account-users.read'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// User's subjectId or email.
            /// </param>
            public static UserModel ApiUsersByUserIdGet(this IIdentityApi operations, string userId)
            {
                return operations.ApiUsersByUserIdGetAsync(userId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a user for the current account.
            /// </summary>
            /// <remarks>
            /// Returns a user in the current account for a specific subjectId or email
            /// address.&lt;br&gt;Scopes required: 'identity:account-users.manage,
            /// identity:account-users.read'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// User's subjectId or email.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserModel> ApiUsersByUserIdGetAsync(this IIdentityApi operations, string userId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiUsersByUserIdGetWithHttpMessagesAsync(userId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modify user in an account.
            /// </summary>
            /// <remarks>
            /// Modify user in an account.
            /// Allowed operations:
            /// - Replace firstName and lastName
            /// - Replace isAccountAdmin (setting it to true or false)
            /// - Replace enabled (setting it to true or false)&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// User's subjectId or email.
            /// </param>
            /// <param name='requestBody'>
            /// </param>
            public static MessageItemCollection ApiUsersByUserIdPatch(this IIdentityApi operations, string userId, IList<Operation> requestBody = default(IList<Operation>))
            {
                return operations.ApiUsersByUserIdPatchAsync(userId, requestBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modify user in an account.
            /// </summary>
            /// <remarks>
            /// Modify user in an account.
            /// Allowed operations:
            /// - Replace firstName and lastName
            /// - Replace isAccountAdmin (setting it to true or false)
            /// - Replace enabled (setting it to true or false)&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// User's subjectId or email.
            /// </param>
            /// <param name='requestBody'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MessageItemCollection> ApiUsersByUserIdPatchAsync(this IIdentityApi operations, string userId, IList<Operation> requestBody = default(IList<Operation>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiUsersByUserIdPatchWithHttpMessagesAsync(userId, requestBody, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove property access.
            /// </summary>
            /// <remarks>
            /// Remove access to a property.&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// User's subjectId or email.
            /// </param>
            /// <param name='propertyId'>
            /// Property ID.
            /// </param>
            public static void ApiUsersByUserIdPropertiesByPropertyIdDelete(this IIdentityApi operations, string userId, string propertyId)
            {
                operations.ApiUsersByUserIdPropertiesByPropertyIdDeleteAsync(userId, propertyId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove property access.
            /// </summary>
            /// <remarks>
            /// Remove access to a property.&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// User's subjectId or email.
            /// </param>
            /// <param name='propertyId'>
            /// Property ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiUsersByUserIdPropertiesByPropertyIdDeleteAsync(this IIdentityApi operations, string userId, string propertyId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiUsersByUserIdPropertiesByPropertyIdDeleteWithHttpMessagesAsync(userId, propertyId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns property roles for a user.
            /// </summary>
            /// <remarks>
            /// Returns property roles for a user.&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage, identity:account-users.read'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// User's subjectId or email
            /// </param>
            /// <param name='propertyId'>
            /// Property ID.
            /// </param>
            public static PropertyRolesModel ApiUsersByUserIdPropertiesByPropertyIdRolesGet(this IIdentityApi operations, string userId, string propertyId)
            {
                return operations.ApiUsersByUserIdPropertiesByPropertyIdRolesGetAsync(userId, propertyId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns property roles for a user.
            /// </summary>
            /// <remarks>
            /// Returns property roles for a user.&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage, identity:account-users.read'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// User's subjectId or email
            /// </param>
            /// <param name='propertyId'>
            /// Property ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PropertyRolesModel> ApiUsersByUserIdPropertiesByPropertyIdRolesGetAsync(this IIdentityApi operations, string userId, string propertyId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiUsersByUserIdPropertiesByPropertyIdRolesGetWithHttpMessagesAsync(userId, propertyId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modify user's roles for a property.
            /// </summary>
            /// <remarks>
            /// Modify user's roles for a property.&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// User's subjectId or email.
            /// </param>
            /// <param name='propertyId'>
            /// Property ID.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static MessageItemCollection ApiUsersByUserIdPropertiesByPropertyIdRolesPut(this IIdentityApi operations, string userId, string propertyId, PropertyRolesModel request = default(PropertyRolesModel))
            {
                return operations.ApiUsersByUserIdPropertiesByPropertyIdRolesPutAsync(userId, propertyId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modify user's roles for a property.
            /// </summary>
            /// <remarks>
            /// Modify user's roles for a property.&lt;br&gt;Scopes required:
            /// 'identity:account-users.manage'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// User's subjectId or email.
            /// </param>
            /// <param name='propertyId'>
            /// Property ID.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MessageItemCollection> ApiUsersByUserIdPropertiesByPropertyIdRolesPutAsync(this IIdentityApi operations, string userId, string propertyId, PropertyRolesModel request = default(PropertyRolesModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiUsersByUserIdPropertiesByPropertyIdRolesPutWithHttpMessagesAsync(userId, propertyId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
