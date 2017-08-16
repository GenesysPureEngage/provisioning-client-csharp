/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.00.813
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Genesys.Provisioning.Client;
using Genesys.Provisioning.Model;

namespace Genesys.Provisioning.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves audit data
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch Audit API with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="asc">Sort results ascending/descending (optional, default to desc)</param>
        /// <param name="orderBy">comma-separated list of fields to sort on, supported: id, createdAt, msg, username  (optional, default to id)</param>
        /// <param name="username">Only users with exact match will pass (optional)</param>
        /// <param name="auditId">Only one row will be displayed with specified ID (optional)</param>
        /// <param name="auditFileId">If specified, sends raw file data with content-type application/octet-stream for specified file-id.  (optional)</param>
        /// <returns>ApiAuditSuccessResponse</returns>
        ApiAuditSuccessResponse GetAuditInfo (int? limit = null, string asc = null, string orderBy = null, string username = null, string auditId = null, string auditFileId = null);

        /// <summary>
        /// Retrieves audit data
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch Audit API with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="asc">Sort results ascending/descending (optional, default to desc)</param>
        /// <param name="orderBy">comma-separated list of fields to sort on, supported: id, createdAt, msg, username  (optional, default to id)</param>
        /// <param name="username">Only users with exact match will pass (optional)</param>
        /// <param name="auditId">Only one row will be displayed with specified ID (optional)</param>
        /// <param name="auditFileId">If specified, sends raw file data with content-type application/octet-stream for specified file-id.  (optional)</param>
        /// <returns>ApiResponse of ApiAuditSuccessResponse</returns>
        ApiResponse<ApiAuditSuccessResponse> GetAuditInfoWithHttpInfo (int? limit = null, string asc = null, string orderBy = null, string username = null, string auditId = null, string auditFileId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves audit data
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch Audit API with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="asc">Sort results ascending/descending (optional, default to desc)</param>
        /// <param name="orderBy">comma-separated list of fields to sort on, supported: id, createdAt, msg, username  (optional, default to id)</param>
        /// <param name="username">Only users with exact match will pass (optional)</param>
        /// <param name="auditId">Only one row will be displayed with specified ID (optional)</param>
        /// <param name="auditFileId">If specified, sends raw file data with content-type application/octet-stream for specified file-id.  (optional)</param>
        /// <returns>Task of ApiAuditSuccessResponse</returns>
        System.Threading.Tasks.Task<ApiAuditSuccessResponse> GetAuditInfoAsync (int? limit = null, string asc = null, string orderBy = null, string username = null, string auditId = null, string auditFileId = null);

        /// <summary>
        /// Retrieves audit data
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch Audit API with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="asc">Sort results ascending/descending (optional, default to desc)</param>
        /// <param name="orderBy">comma-separated list of fields to sort on, supported: id, createdAt, msg, username  (optional, default to id)</param>
        /// <param name="username">Only users with exact match will pass (optional)</param>
        /// <param name="auditId">Only one row will be displayed with specified ID (optional)</param>
        /// <param name="auditFileId">If specified, sends raw file data with content-type application/octet-stream for specified file-id.  (optional)</param>
        /// <returns>Task of ApiResponse (ApiAuditSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiAuditSuccessResponse>> GetAuditInfoAsyncWithHttpInfo (int? limit = null, string asc = null, string orderBy = null, string username = null, string auditId = null, string auditFileId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuditApi : IAuditApi
    {
        private Genesys.Provisioning.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Genesys.Provisioning.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuditApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Genesys.Provisioning.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Genesys.Provisioning.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieves audit data The GET operation will fetch Audit API with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="asc">Sort results ascending/descending (optional, default to desc)</param>
        /// <param name="orderBy">comma-separated list of fields to sort on, supported: id, createdAt, msg, username  (optional, default to id)</param>
        /// <param name="username">Only users with exact match will pass (optional)</param>
        /// <param name="auditId">Only one row will be displayed with specified ID (optional)</param>
        /// <param name="auditFileId">If specified, sends raw file data with content-type application/octet-stream for specified file-id.  (optional)</param>
        /// <returns>ApiAuditSuccessResponse</returns>
        public ApiAuditSuccessResponse GetAuditInfo (int? limit = null, string asc = null, string orderBy = null, string username = null, string auditId = null, string auditFileId = null)
        {
             ApiResponse<ApiAuditSuccessResponse> localVarResponse = GetAuditInfoWithHttpInfo(limit, asc, orderBy, username, auditId, auditFileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves audit data The GET operation will fetch Audit API with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="asc">Sort results ascending/descending (optional, default to desc)</param>
        /// <param name="orderBy">comma-separated list of fields to sort on, supported: id, createdAt, msg, username  (optional, default to id)</param>
        /// <param name="username">Only users with exact match will pass (optional)</param>
        /// <param name="auditId">Only one row will be displayed with specified ID (optional)</param>
        /// <param name="auditFileId">If specified, sends raw file data with content-type application/octet-stream for specified file-id.  (optional)</param>
        /// <returns>ApiResponse of ApiAuditSuccessResponse</returns>
        public ApiResponse< ApiAuditSuccessResponse > GetAuditInfoWithHttpInfo (int? limit = null, string asc = null, string orderBy = null, string username = null, string auditId = null, string auditFileId = null)
        {

            var localVarPath = "/audit";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (asc != null) localVarQueryParams.Add("asc", Configuration.ApiClient.ParameterToString(asc)); // query parameter
            if (orderBy != null) localVarQueryParams.Add("orderBy", Configuration.ApiClient.ParameterToString(orderBy)); // query parameter
            if (username != null) localVarQueryParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // query parameter
            if (auditId != null) localVarQueryParams.Add("audit_id", Configuration.ApiClient.ParameterToString(auditId)); // query parameter
            if (auditFileId != null) localVarQueryParams.Add("audit_file_id", Configuration.ApiClient.ParameterToString(auditFileId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAuditInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiAuditSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiAuditSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiAuditSuccessResponse)));
        }

        /// <summary>
        /// Retrieves audit data The GET operation will fetch Audit API with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="asc">Sort results ascending/descending (optional, default to desc)</param>
        /// <param name="orderBy">comma-separated list of fields to sort on, supported: id, createdAt, msg, username  (optional, default to id)</param>
        /// <param name="username">Only users with exact match will pass (optional)</param>
        /// <param name="auditId">Only one row will be displayed with specified ID (optional)</param>
        /// <param name="auditFileId">If specified, sends raw file data with content-type application/octet-stream for specified file-id.  (optional)</param>
        /// <returns>Task of ApiAuditSuccessResponse</returns>
        public async System.Threading.Tasks.Task<ApiAuditSuccessResponse> GetAuditInfoAsync (int? limit = null, string asc = null, string orderBy = null, string username = null, string auditId = null, string auditFileId = null)
        {
             ApiResponse<ApiAuditSuccessResponse> localVarResponse = await GetAuditInfoAsyncWithHttpInfo(limit, asc, orderBy, username, auditId, auditFileId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves audit data The GET operation will fetch Audit API with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="asc">Sort results ascending/descending (optional, default to desc)</param>
        /// <param name="orderBy">comma-separated list of fields to sort on, supported: id, createdAt, msg, username  (optional, default to id)</param>
        /// <param name="username">Only users with exact match will pass (optional)</param>
        /// <param name="auditId">Only one row will be displayed with specified ID (optional)</param>
        /// <param name="auditFileId">If specified, sends raw file data with content-type application/octet-stream for specified file-id.  (optional)</param>
        /// <returns>Task of ApiResponse (ApiAuditSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiAuditSuccessResponse>> GetAuditInfoAsyncWithHttpInfo (int? limit = null, string asc = null, string orderBy = null, string username = null, string auditId = null, string auditFileId = null)
        {

            var localVarPath = "/audit";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (asc != null) localVarQueryParams.Add("asc", Configuration.ApiClient.ParameterToString(asc)); // query parameter
            if (orderBy != null) localVarQueryParams.Add("orderBy", Configuration.ApiClient.ParameterToString(orderBy)); // query parameter
            if (username != null) localVarQueryParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // query parameter
            if (auditId != null) localVarQueryParams.Add("audit_id", Configuration.ApiClient.ParameterToString(auditId)); // query parameter
            if (auditFileId != null) localVarQueryParams.Add("audit_file_id", Configuration.ApiClient.ParameterToString(auditFileId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAuditInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiAuditSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiAuditSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiAuditSuccessResponse)));
        }

    }
}
