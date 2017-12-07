/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.05.1207
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
    public interface IOperationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get skills of users
        /// </summary>
        /// <remarks>
        /// The GET operation will return CfgSkill objects actually linked with existing CfgPerson objects
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <returns>ApiAsyncSuccessResponse</returns>
        ApiAsyncSuccessResponse GetUsedSkillsAsync (string aioId = null);

        /// <summary>
        /// Get skills of users
        /// </summary>
        /// <remarks>
        /// The GET operation will return CfgSkill objects actually linked with existing CfgPerson objects
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <returns>ApiResponse of ApiAsyncSuccessResponse</returns>
        ApiResponse<ApiAsyncSuccessResponse> GetUsedSkillsAsyncWithHttpInfo (string aioId = null);
        /// <summary>
        /// Read users
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch CfgPerson objects from configuration server, possible with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="order">Sort results ascending/descending (optional)</param>
        /// <param name="sortBy">comma-separated list of fields to sort on, supported: firstName,lastName,userName  (optional)</param>
        /// <param name="filterName">Users filter name (optional)</param>
        /// <param name="filterParameters">Part of users first or last name, if filterName: FirstNameOrLastNameMatches specified.  (optional)</param>
        /// <param name="roles">Only fetch users with specified wwe roles, comma-separated. Supported: ROLE_AGENT,ROLE_ADMIN,ROLE_SUPERVISOR  (optional)</param>
        /// <param name="skills">Only fetch users with specified skills, comma-separated.  (optional)</param>
        /// <param name="userEnabled">Fetch only enabled or disabled users. (optional)</param>
        /// <param name="userValid">Fetch only valid or invalid users. (optional)</param>
        /// <returns>ApiAsyncSuccessResponse</returns>
        ApiAsyncSuccessResponse GetUsersAsync (string aioId = null, int? limit = null, int? offset = null, string order = null, string sortBy = null, string filterName = null, string filterParameters = null, string roles = null, string skills = null, bool? userEnabled = null, string userValid = null);

        /// <summary>
        /// Read users
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch CfgPerson objects from configuration server, possible with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="order">Sort results ascending/descending (optional)</param>
        /// <param name="sortBy">comma-separated list of fields to sort on, supported: firstName,lastName,userName  (optional)</param>
        /// <param name="filterName">Users filter name (optional)</param>
        /// <param name="filterParameters">Part of users first or last name, if filterName: FirstNameOrLastNameMatches specified.  (optional)</param>
        /// <param name="roles">Only fetch users with specified wwe roles, comma-separated. Supported: ROLE_AGENT,ROLE_ADMIN,ROLE_SUPERVISOR  (optional)</param>
        /// <param name="skills">Only fetch users with specified skills, comma-separated.  (optional)</param>
        /// <param name="userEnabled">Fetch only enabled or disabled users. (optional)</param>
        /// <param name="userValid">Fetch only valid or invalid users. (optional)</param>
        /// <returns>ApiResponse of ApiAsyncSuccessResponse</returns>
        ApiResponse<ApiAsyncSuccessResponse> GetUsersAsyncWithHttpInfo (string aioId = null, int? limit = null, int? offset = null, string order = null, string sortBy = null, string filterName = null, string filterParameters = null, string roles = null, string skills = null, bool? userEnabled = null, string userValid = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get skills of users
        /// </summary>
        /// <remarks>
        /// The GET operation will return CfgSkill objects actually linked with existing CfgPerson objects
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <returns>Task of ApiAsyncSuccessResponse</returns>
        System.Threading.Tasks.Task<ApiAsyncSuccessResponse> GetUsedSkillsAsyncAsync (string aioId = null);

        /// <summary>
        /// Get skills of users
        /// </summary>
        /// <remarks>
        /// The GET operation will return CfgSkill objects actually linked with existing CfgPerson objects
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <returns>Task of ApiResponse (ApiAsyncSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiAsyncSuccessResponse>> GetUsedSkillsAsyncAsyncWithHttpInfo (string aioId = null);
        /// <summary>
        /// Read users
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch CfgPerson objects from configuration server, possible with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="order">Sort results ascending/descending (optional)</param>
        /// <param name="sortBy">comma-separated list of fields to sort on, supported: firstName,lastName,userName  (optional)</param>
        /// <param name="filterName">Users filter name (optional)</param>
        /// <param name="filterParameters">Part of users first or last name, if filterName: FirstNameOrLastNameMatches specified.  (optional)</param>
        /// <param name="roles">Only fetch users with specified wwe roles, comma-separated. Supported: ROLE_AGENT,ROLE_ADMIN,ROLE_SUPERVISOR  (optional)</param>
        /// <param name="skills">Only fetch users with specified skills, comma-separated.  (optional)</param>
        /// <param name="userEnabled">Fetch only enabled or disabled users. (optional)</param>
        /// <param name="userValid">Fetch only valid or invalid users. (optional)</param>
        /// <returns>Task of ApiAsyncSuccessResponse</returns>
        System.Threading.Tasks.Task<ApiAsyncSuccessResponse> GetUsersAsyncAsync (string aioId = null, int? limit = null, int? offset = null, string order = null, string sortBy = null, string filterName = null, string filterParameters = null, string roles = null, string skills = null, bool? userEnabled = null, string userValid = null);

        /// <summary>
        /// Read users
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch CfgPerson objects from configuration server, possible with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="order">Sort results ascending/descending (optional)</param>
        /// <param name="sortBy">comma-separated list of fields to sort on, supported: firstName,lastName,userName  (optional)</param>
        /// <param name="filterName">Users filter name (optional)</param>
        /// <param name="filterParameters">Part of users first or last name, if filterName: FirstNameOrLastNameMatches specified.  (optional)</param>
        /// <param name="roles">Only fetch users with specified wwe roles, comma-separated. Supported: ROLE_AGENT,ROLE_ADMIN,ROLE_SUPERVISOR  (optional)</param>
        /// <param name="skills">Only fetch users with specified skills, comma-separated.  (optional)</param>
        /// <param name="userEnabled">Fetch only enabled or disabled users. (optional)</param>
        /// <param name="userValid">Fetch only valid or invalid users. (optional)</param>
        /// <returns>Task of ApiResponse (ApiAsyncSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiAsyncSuccessResponse>> GetUsersAsyncAsyncWithHttpInfo (string aioId = null, int? limit = null, int? offset = null, string order = null, string sortBy = null, string filterName = null, string filterParameters = null, string roles = null, string skills = null, bool? userEnabled = null, string userValid = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OperationsApi : IOperationsApi
    {
        private Genesys.Provisioning.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperationsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Genesys.Provisioning.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OperationsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Genesys.Provisioning.Client.Configuration.DefaultExceptionFactory;
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Get skills of users The GET operation will return CfgSkill objects actually linked with existing CfgPerson objects
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <returns>ApiAsyncSuccessResponse</returns>
        public ApiAsyncSuccessResponse GetUsedSkillsAsync (string aioId = null)
        {
             ApiResponse<ApiAsyncSuccessResponse> localVarResponse = GetUsedSkillsAsyncWithHttpInfo(aioId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get skills of users The GET operation will return CfgSkill objects actually linked with existing CfgPerson objects
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <returns>ApiResponse of ApiAsyncSuccessResponse</returns>
        public ApiResponse< ApiAsyncSuccessResponse > GetUsedSkillsAsyncWithHttpInfo (string aioId = null)
        {

            var localVarPath = "/operations/get-used-skills";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (aioId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "_aioId", aioId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUsedSkillsAsync", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiAsyncSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiAsyncSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiAsyncSuccessResponse)));
        }

        /// <summary>
        /// Get skills of users The GET operation will return CfgSkill objects actually linked with existing CfgPerson objects
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <returns>Task of ApiAsyncSuccessResponse</returns>
        public async System.Threading.Tasks.Task<ApiAsyncSuccessResponse> GetUsedSkillsAsyncAsync (string aioId = null)
        {
             ApiResponse<ApiAsyncSuccessResponse> localVarResponse = await GetUsedSkillsAsyncAsyncWithHttpInfo(aioId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get skills of users The GET operation will return CfgSkill objects actually linked with existing CfgPerson objects
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <returns>Task of ApiResponse (ApiAsyncSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiAsyncSuccessResponse>> GetUsedSkillsAsyncAsyncWithHttpInfo (string aioId = null)
        {

            var localVarPath = "/operations/get-used-skills";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (aioId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "_aioId", aioId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUsedSkillsAsync", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiAsyncSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiAsyncSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiAsyncSuccessResponse)));
        }

        /// <summary>
        /// Read users The GET operation will fetch CfgPerson objects from configuration server, possible with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="order">Sort results ascending/descending (optional)</param>
        /// <param name="sortBy">comma-separated list of fields to sort on, supported: firstName,lastName,userName  (optional)</param>
        /// <param name="filterName">Users filter name (optional)</param>
        /// <param name="filterParameters">Part of users first or last name, if filterName: FirstNameOrLastNameMatches specified.  (optional)</param>
        /// <param name="roles">Only fetch users with specified wwe roles, comma-separated. Supported: ROLE_AGENT,ROLE_ADMIN,ROLE_SUPERVISOR  (optional)</param>
        /// <param name="skills">Only fetch users with specified skills, comma-separated.  (optional)</param>
        /// <param name="userEnabled">Fetch only enabled or disabled users. (optional)</param>
        /// <param name="userValid">Fetch only valid or invalid users. (optional)</param>
        /// <returns>ApiAsyncSuccessResponse</returns>
        public ApiAsyncSuccessResponse GetUsersAsync (string aioId = null, int? limit = null, int? offset = null, string order = null, string sortBy = null, string filterName = null, string filterParameters = null, string roles = null, string skills = null, bool? userEnabled = null, string userValid = null)
        {
             ApiResponse<ApiAsyncSuccessResponse> localVarResponse = GetUsersAsyncWithHttpInfo(aioId, limit, offset, order, sortBy, filterName, filterParameters, roles, skills, userEnabled, userValid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read users The GET operation will fetch CfgPerson objects from configuration server, possible with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="order">Sort results ascending/descending (optional)</param>
        /// <param name="sortBy">comma-separated list of fields to sort on, supported: firstName,lastName,userName  (optional)</param>
        /// <param name="filterName">Users filter name (optional)</param>
        /// <param name="filterParameters">Part of users first or last name, if filterName: FirstNameOrLastNameMatches specified.  (optional)</param>
        /// <param name="roles">Only fetch users with specified wwe roles, comma-separated. Supported: ROLE_AGENT,ROLE_ADMIN,ROLE_SUPERVISOR  (optional)</param>
        /// <param name="skills">Only fetch users with specified skills, comma-separated.  (optional)</param>
        /// <param name="userEnabled">Fetch only enabled or disabled users. (optional)</param>
        /// <param name="userValid">Fetch only valid or invalid users. (optional)</param>
        /// <returns>ApiResponse of ApiAsyncSuccessResponse</returns>
        public ApiResponse< ApiAsyncSuccessResponse > GetUsersAsyncWithHttpInfo (string aioId = null, int? limit = null, int? offset = null, string order = null, string sortBy = null, string filterName = null, string filterParameters = null, string roles = null, string skills = null, bool? userEnabled = null, string userValid = null)
        {

            var localVarPath = "/operations/get-users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (aioId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "_aioId", aioId)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sortBy", sortBy)); // query parameter
            if (filterName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filterName", filterName)); // query parameter
            if (filterParameters != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filterParameters", filterParameters)); // query parameter
            if (roles != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "roles", roles)); // query parameter
            if (skills != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "skills", skills)); // query parameter
            if (userEnabled != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "userEnabled", userEnabled)); // query parameter
            if (userValid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "userValid", userValid)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUsersAsync", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiAsyncSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiAsyncSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiAsyncSuccessResponse)));
        }

        /// <summary>
        /// Read users The GET operation will fetch CfgPerson objects from configuration server, possible with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="order">Sort results ascending/descending (optional)</param>
        /// <param name="sortBy">comma-separated list of fields to sort on, supported: firstName,lastName,userName  (optional)</param>
        /// <param name="filterName">Users filter name (optional)</param>
        /// <param name="filterParameters">Part of users first or last name, if filterName: FirstNameOrLastNameMatches specified.  (optional)</param>
        /// <param name="roles">Only fetch users with specified wwe roles, comma-separated. Supported: ROLE_AGENT,ROLE_ADMIN,ROLE_SUPERVISOR  (optional)</param>
        /// <param name="skills">Only fetch users with specified skills, comma-separated.  (optional)</param>
        /// <param name="userEnabled">Fetch only enabled or disabled users. (optional)</param>
        /// <param name="userValid">Fetch only valid or invalid users. (optional)</param>
        /// <returns>Task of ApiAsyncSuccessResponse</returns>
        public async System.Threading.Tasks.Task<ApiAsyncSuccessResponse> GetUsersAsyncAsync (string aioId = null, int? limit = null, int? offset = null, string order = null, string sortBy = null, string filterName = null, string filterParameters = null, string roles = null, string skills = null, bool? userEnabled = null, string userValid = null)
        {
             ApiResponse<ApiAsyncSuccessResponse> localVarResponse = await GetUsersAsyncAsyncWithHttpInfo(aioId, limit, offset, order, sortBy, filterName, filterParameters, roles, skills, userEnabled, userValid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read users The GET operation will fetch CfgPerson objects from configuration server, possible with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aioId">Async IO ID (optional)</param>
        /// <param name="limit">Limit number of users to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="order">Sort results ascending/descending (optional)</param>
        /// <param name="sortBy">comma-separated list of fields to sort on, supported: firstName,lastName,userName  (optional)</param>
        /// <param name="filterName">Users filter name (optional)</param>
        /// <param name="filterParameters">Part of users first or last name, if filterName: FirstNameOrLastNameMatches specified.  (optional)</param>
        /// <param name="roles">Only fetch users with specified wwe roles, comma-separated. Supported: ROLE_AGENT,ROLE_ADMIN,ROLE_SUPERVISOR  (optional)</param>
        /// <param name="skills">Only fetch users with specified skills, comma-separated.  (optional)</param>
        /// <param name="userEnabled">Fetch only enabled or disabled users. (optional)</param>
        /// <param name="userValid">Fetch only valid or invalid users. (optional)</param>
        /// <returns>Task of ApiResponse (ApiAsyncSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiAsyncSuccessResponse>> GetUsersAsyncAsyncWithHttpInfo (string aioId = null, int? limit = null, int? offset = null, string order = null, string sortBy = null, string filterName = null, string filterParameters = null, string roles = null, string skills = null, bool? userEnabled = null, string userValid = null)
        {

            var localVarPath = "/operations/get-users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (aioId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "_aioId", aioId)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sortBy", sortBy)); // query parameter
            if (filterName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filterName", filterName)); // query parameter
            if (filterParameters != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filterParameters", filterParameters)); // query parameter
            if (roles != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "roles", roles)); // query parameter
            if (skills != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "skills", skills)); // query parameter
            if (userEnabled != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "userEnabled", userEnabled)); // query parameter
            if (userValid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "userValid", userValid)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUsersAsync", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiAsyncSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiAsyncSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiAsyncSuccessResponse)));
        }

    }
}
