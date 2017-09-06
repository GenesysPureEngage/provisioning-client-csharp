/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.00.877
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
    public interface IObjectsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Read DNs or Agent Groups
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch objects from configuration server, possible with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType">Object type - &#39;dns&#39; or &#39;agent-groups&#39;</param>
        /// <param name="dnType">DN type if object_type &#x3D; &#39;dns&#39; (e.g. CFGRoutingPoint). Refer Configuration Server API docs. (optional)</param>
        /// <param name="limit">Limit number of objects to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="searchTerm">Part of a key in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="searchKey">A keypath in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="matchMethod">Method to match the search_term (&#39;includes&#39;, &#39;startsWith&#39;, &#39;endsWith&#39;, &#39;isEqual&#39;).  (optional)</param>
        /// <returns>GetObjectsSuccessResponse</returns>
        GetObjectsSuccessResponse GetObject (string objectType, string dnType = null, int? limit = null, int? offset = null, string searchTerm = null, string searchKey = null, string matchMethod = null);

        /// <summary>
        /// Read DNs or Agent Groups
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch objects from configuration server, possible with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType">Object type - &#39;dns&#39; or &#39;agent-groups&#39;</param>
        /// <param name="dnType">DN type if object_type &#x3D; &#39;dns&#39; (e.g. CFGRoutingPoint). Refer Configuration Server API docs. (optional)</param>
        /// <param name="limit">Limit number of objects to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="searchTerm">Part of a key in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="searchKey">A keypath in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="matchMethod">Method to match the search_term (&#39;includes&#39;, &#39;startsWith&#39;, &#39;endsWith&#39;, &#39;isEqual&#39;).  (optional)</param>
        /// <returns>ApiResponse of GetObjectsSuccessResponse</returns>
        ApiResponse<GetObjectsSuccessResponse> GetObjectWithHttpInfo (string objectType, string dnType = null, int? limit = null, int? offset = null, string searchTerm = null, string searchKey = null, string matchMethod = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Read DNs or Agent Groups
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch objects from configuration server, possible with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType">Object type - &#39;dns&#39; or &#39;agent-groups&#39;</param>
        /// <param name="dnType">DN type if object_type &#x3D; &#39;dns&#39; (e.g. CFGRoutingPoint). Refer Configuration Server API docs. (optional)</param>
        /// <param name="limit">Limit number of objects to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="searchTerm">Part of a key in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="searchKey">A keypath in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="matchMethod">Method to match the search_term (&#39;includes&#39;, &#39;startsWith&#39;, &#39;endsWith&#39;, &#39;isEqual&#39;).  (optional)</param>
        /// <returns>Task of GetObjectsSuccessResponse</returns>
        System.Threading.Tasks.Task<GetObjectsSuccessResponse> GetObjectAsync (string objectType, string dnType = null, int? limit = null, int? offset = null, string searchTerm = null, string searchKey = null, string matchMethod = null);

        /// <summary>
        /// Read DNs or Agent Groups
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch objects from configuration server, possible with filters
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType">Object type - &#39;dns&#39; or &#39;agent-groups&#39;</param>
        /// <param name="dnType">DN type if object_type &#x3D; &#39;dns&#39; (e.g. CFGRoutingPoint). Refer Configuration Server API docs. (optional)</param>
        /// <param name="limit">Limit number of objects to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="searchTerm">Part of a key in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="searchKey">A keypath in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="matchMethod">Method to match the search_term (&#39;includes&#39;, &#39;startsWith&#39;, &#39;endsWith&#39;, &#39;isEqual&#39;).  (optional)</param>
        /// <returns>Task of ApiResponse (GetObjectsSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetObjectsSuccessResponse>> GetObjectAsyncWithHttpInfo (string objectType, string dnType = null, int? limit = null, int? offset = null, string searchTerm = null, string searchKey = null, string matchMethod = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ObjectsApi : IObjectsApi
    {
        private Genesys.Provisioning.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ObjectsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectsApi(Configuration configuration = null)
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
        /// Read DNs or Agent Groups The GET operation will fetch objects from configuration server, possible with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType">Object type - &#39;dns&#39; or &#39;agent-groups&#39;</param>
        /// <param name="dnType">DN type if object_type &#x3D; &#39;dns&#39; (e.g. CFGRoutingPoint). Refer Configuration Server API docs. (optional)</param>
        /// <param name="limit">Limit number of objects to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="searchTerm">Part of a key in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="searchKey">A keypath in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="matchMethod">Method to match the search_term (&#39;includes&#39;, &#39;startsWith&#39;, &#39;endsWith&#39;, &#39;isEqual&#39;).  (optional)</param>
        /// <returns>GetObjectsSuccessResponse</returns>
        public GetObjectsSuccessResponse GetObject (string objectType, string dnType = null, int? limit = null, int? offset = null, string searchTerm = null, string searchKey = null, string matchMethod = null)
        {
             ApiResponse<GetObjectsSuccessResponse> localVarResponse = GetObjectWithHttpInfo(objectType, dnType, limit, offset, searchTerm, searchKey, matchMethod);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read DNs or Agent Groups The GET operation will fetch objects from configuration server, possible with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType">Object type - &#39;dns&#39; or &#39;agent-groups&#39;</param>
        /// <param name="dnType">DN type if object_type &#x3D; &#39;dns&#39; (e.g. CFGRoutingPoint). Refer Configuration Server API docs. (optional)</param>
        /// <param name="limit">Limit number of objects to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="searchTerm">Part of a key in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="searchKey">A keypath in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="matchMethod">Method to match the search_term (&#39;includes&#39;, &#39;startsWith&#39;, &#39;endsWith&#39;, &#39;isEqual&#39;).  (optional)</param>
        /// <returns>ApiResponse of GetObjectsSuccessResponse</returns>
        public ApiResponse< GetObjectsSuccessResponse > GetObjectWithHttpInfo (string objectType, string dnType = null, int? limit = null, int? offset = null, string searchTerm = null, string searchKey = null, string matchMethod = null)
        {
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling ObjectsApi->GetObject");

            var localVarPath = "/objects/{object_type}";
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

            if (objectType != null) localVarPathParams.Add("object_type", Configuration.ApiClient.ParameterToString(objectType)); // path parameter
            if (dnType != null) localVarQueryParams.Add("dn_type", Configuration.ApiClient.ParameterToString(dnType)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (searchTerm != null) localVarQueryParams.Add("search_term", Configuration.ApiClient.ParameterToString(searchTerm)); // query parameter
            if (searchKey != null) localVarQueryParams.Add("search_key", Configuration.ApiClient.ParameterToString(searchKey)); // query parameter
            if (matchMethod != null) localVarQueryParams.Add("match_method", Configuration.ApiClient.ParameterToString(matchMethod)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetObject", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetObjectsSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetObjectsSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetObjectsSuccessResponse)));
        }

        /// <summary>
        /// Read DNs or Agent Groups The GET operation will fetch objects from configuration server, possible with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType">Object type - &#39;dns&#39; or &#39;agent-groups&#39;</param>
        /// <param name="dnType">DN type if object_type &#x3D; &#39;dns&#39; (e.g. CFGRoutingPoint). Refer Configuration Server API docs. (optional)</param>
        /// <param name="limit">Limit number of objects to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="searchTerm">Part of a key in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="searchKey">A keypath in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="matchMethod">Method to match the search_term (&#39;includes&#39;, &#39;startsWith&#39;, &#39;endsWith&#39;, &#39;isEqual&#39;).  (optional)</param>
        /// <returns>Task of GetObjectsSuccessResponse</returns>
        public async System.Threading.Tasks.Task<GetObjectsSuccessResponse> GetObjectAsync (string objectType, string dnType = null, int? limit = null, int? offset = null, string searchTerm = null, string searchKey = null, string matchMethod = null)
        {
             ApiResponse<GetObjectsSuccessResponse> localVarResponse = await GetObjectAsyncWithHttpInfo(objectType, dnType, limit, offset, searchTerm, searchKey, matchMethod);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read DNs or Agent Groups The GET operation will fetch objects from configuration server, possible with filters
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType">Object type - &#39;dns&#39; or &#39;agent-groups&#39;</param>
        /// <param name="dnType">DN type if object_type &#x3D; &#39;dns&#39; (e.g. CFGRoutingPoint). Refer Configuration Server API docs. (optional)</param>
        /// <param name="limit">Limit number of objects to fetch (optional)</param>
        /// <param name="offset">Skip first N matches (optional)</param>
        /// <param name="searchTerm">Part of a key in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="searchKey">A keypath in CFGDN or CfgAgentGroup.  (optional)</param>
        /// <param name="matchMethod">Method to match the search_term (&#39;includes&#39;, &#39;startsWith&#39;, &#39;endsWith&#39;, &#39;isEqual&#39;).  (optional)</param>
        /// <returns>Task of ApiResponse (GetObjectsSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetObjectsSuccessResponse>> GetObjectAsyncWithHttpInfo (string objectType, string dnType = null, int? limit = null, int? offset = null, string searchTerm = null, string searchKey = null, string matchMethod = null)
        {
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling ObjectsApi->GetObject");

            var localVarPath = "/objects/{object_type}";
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

            if (objectType != null) localVarPathParams.Add("object_type", Configuration.ApiClient.ParameterToString(objectType)); // path parameter
            if (dnType != null) localVarQueryParams.Add("dn_type", Configuration.ApiClient.ParameterToString(dnType)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (searchTerm != null) localVarQueryParams.Add("search_term", Configuration.ApiClient.ParameterToString(searchTerm)); // query parameter
            if (searchKey != null) localVarQueryParams.Add("search_key", Configuration.ApiClient.ParameterToString(searchKey)); // query parameter
            if (matchMethod != null) localVarQueryParams.Add("match_method", Configuration.ApiClient.ParameterToString(matchMethod)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetObject", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetObjectsSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetObjectsSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetObjectsSuccessResponse)));
        }

    }
}
