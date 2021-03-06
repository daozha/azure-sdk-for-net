// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ProjectsOperations operations.
    /// </summary>
    public partial interface IProjectsOperations
    {
        /// <summary>
        /// Get projects in a service
        /// </summary>
        /// <remarks>
        /// The project resource is a nested resource representing a stored
        /// migration project. This method returns a list of projects owned by
        /// a service resource.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Project>>> ListWithHttpMessagesAsync(string groupName, string serviceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update project
        /// </summary>
        /// <remarks>
        /// The project resource is a nested resource representing a stored
        /// migration project. The PUT method creates a new project or updates
        /// an existing one.
        /// </remarks>
        /// <param name='parameters'>
        /// Information about the project
        /// </param>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Project>> CreateOrUpdateWithHttpMessagesAsync(Project parameters, string groupName, string serviceName, string projectName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get project information
        /// </summary>
        /// <remarks>
        /// The project resource is a nested resource representing a stored
        /// migration project. The GET method retrieves information about a
        /// project.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Project>> GetWithHttpMessagesAsync(string groupName, string serviceName, string projectName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete project
        /// </summary>
        /// <remarks>
        /// The project resource is a nested resource representing a stored
        /// migration project. The DELETE method deletes a project.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='deleteRunningTasks'>
        /// Delete the resource even if it contains running tasks
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string groupName, string serviceName, string projectName, bool? deleteRunningTasks = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update project
        /// </summary>
        /// <remarks>
        /// The project resource is a nested resource representing a stored
        /// migration project. The PATCH method updates an existing project.
        /// </remarks>
        /// <param name='parameters'>
        /// Information about the project
        /// </param>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Project>> UpdateWithHttpMessagesAsync(Project parameters, string groupName, string serviceName, string projectName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get projects in a service
        /// </summary>
        /// <remarks>
        /// The project resource is a nested resource representing a stored
        /// migration project. This method returns a list of projects owned by
        /// a service resource.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Project>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
