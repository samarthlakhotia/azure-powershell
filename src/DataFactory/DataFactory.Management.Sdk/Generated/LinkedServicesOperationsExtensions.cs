// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LinkedServicesOperations.
    /// </summary>
    public static partial class LinkedServicesOperationsExtensions
    {
            /// <summary>
            /// Lists linked services.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            public static IPage<LinkedServiceResource> ListByFactory(this ILinkedServicesOperations operations, string resourceGroupName, string factoryName)
            {
                return operations.ListByFactoryAsync(resourceGroupName, factoryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists linked services.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LinkedServiceResource>> ListByFactoryAsync(this ILinkedServicesOperations operations, string resourceGroupName, string factoryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFactoryWithHttpMessagesAsync(resourceGroupName, factoryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a linked service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='linkedServiceName'>
            /// The linked service name.
            /// </param>
            /// <param name='properties'>
            /// Properties of linked service.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the linkedService entity.  Should only be specified for update, for
            /// which it should match existing entity or can be * for unconditional update.
            /// </param>
            public static LinkedServiceResource CreateOrUpdate(this ILinkedServicesOperations operations, string resourceGroupName, string factoryName, string linkedServiceName, LinkedService properties, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, factoryName, linkedServiceName, properties, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a linked service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='linkedServiceName'>
            /// The linked service name.
            /// </param>
            /// <param name='properties'>
            /// Properties of linked service.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the linkedService entity.  Should only be specified for update, for
            /// which it should match existing entity or can be * for unconditional update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LinkedServiceResource> CreateOrUpdateAsync(this ILinkedServicesOperations operations, string resourceGroupName, string factoryName, string linkedServiceName, LinkedService properties, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, factoryName, linkedServiceName, properties, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a linked service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='linkedServiceName'>
            /// The linked service name.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// ETag of the linked service entity. Should only be specified for get. If the
            /// ETag matches the existing entity tag, or if * was provided, then no content
            /// will be returned.
            /// </param>
            public static LinkedServiceResource Get(this ILinkedServicesOperations operations, string resourceGroupName, string factoryName, string linkedServiceName, string ifNoneMatch = default(string))
            {
                return operations.GetAsync(resourceGroupName, factoryName, linkedServiceName, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a linked service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='linkedServiceName'>
            /// The linked service name.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// ETag of the linked service entity. Should only be specified for get. If the
            /// ETag matches the existing entity tag, or if * was provided, then no content
            /// will be returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LinkedServiceResource> GetAsync(this ILinkedServicesOperations operations, string resourceGroupName, string factoryName, string linkedServiceName, string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, factoryName, linkedServiceName, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a linked service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='linkedServiceName'>
            /// The linked service name.
            /// </param>
            public static void Delete(this ILinkedServicesOperations operations, string resourceGroupName, string factoryName, string linkedServiceName)
            {
                operations.DeleteAsync(resourceGroupName, factoryName, linkedServiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a linked service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='linkedServiceName'>
            /// The linked service name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILinkedServicesOperations operations, string resourceGroupName, string factoryName, string linkedServiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, factoryName, linkedServiceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists linked services.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LinkedServiceResource> ListByFactoryNext(this ILinkedServicesOperations operations, string nextPageLink)
            {
                return operations.ListByFactoryNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists linked services.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LinkedServiceResource>> ListByFactoryNextAsync(this ILinkedServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFactoryNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
