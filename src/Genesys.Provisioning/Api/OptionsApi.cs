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
    public interface IOptionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Read options
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch an application Options (CloudCluster by default) and merges it with person and sgent groups annexes.
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="personDbid">DBID of a person. Options will be merged with the Person&#39;s annex and annexes of it&#39;s agent groups. Mutual with agent_group_dbid. (optional)</param>
        /// <param name="agentGroupDbid">DBID of a person. Options will be merged with the Agent Groups&#39;s annex. Mutual with person_dbid. (optional)</param>
        /// <param name="application">Name of an application (optional)</param>
        /// <returns>GetOptionsResponse</returns>
        GetOptionsResponse GetOptions (string personDbid = null, string agentGroupDbid = null, string application = null);

        /// <summary>
        /// Read options
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch an application Options (CloudCluster by default) and merges it with person and sgent groups annexes.
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="personDbid">DBID of a person. Options will be merged with the Person&#39;s annex and annexes of it&#39;s agent groups. Mutual with agent_group_dbid. (optional)</param>
        /// <param name="agentGroupDbid">DBID of a person. Options will be merged with the Agent Groups&#39;s annex. Mutual with person_dbid. (optional)</param>
        /// <param name="application">Name of an application (optional)</param>
        /// <returns>ApiResponse of GetOptionsResponse</returns>
        ApiResponse<GetOptionsResponse> GetOptionsWithHttpInfo (string personDbid = null, string agentGroupDbid = null, string application = null);
        /// <summary>
        /// Modify options
        /// </summary>
        /// <remarks>
        /// The POST operation will replace CloudCluster/Options with new values
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiSuccessResponse</returns>
        ApiSuccessResponse ModifyOptions (ModifyOptionsData body);

        /// <summary>
        /// Modify options
        /// </summary>
        /// <remarks>
        /// The POST operation will replace CloudCluster/Options with new values
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiResponse of ApiSuccessResponse</returns>
        ApiResponse<ApiSuccessResponse> ModifyOptionsWithHttpInfo (ModifyOptionsData body);
        /// <summary>
        /// Add, edit or delete options
        /// </summary>
        /// <remarks>
        /// The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiSuccessResponse</returns>
        ApiSuccessResponse UpdateOptions (UpdateOptionsData body);

        /// <summary>
        /// Add, edit or delete options
        /// </summary>
        /// <remarks>
        /// The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiResponse of ApiSuccessResponse</returns>
        ApiResponse<ApiSuccessResponse> UpdateOptionsWithHttpInfo (UpdateOptionsData body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Read options
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch an application Options (CloudCluster by default) and merges it with person and sgent groups annexes.
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="personDbid">DBID of a person. Options will be merged with the Person&#39;s annex and annexes of it&#39;s agent groups. Mutual with agent_group_dbid. (optional)</param>
        /// <param name="agentGroupDbid">DBID of a person. Options will be merged with the Agent Groups&#39;s annex. Mutual with person_dbid. (optional)</param>
        /// <param name="application">Name of an application (optional)</param>
        /// <returns>Task of GetOptionsResponse</returns>
        System.Threading.Tasks.Task<GetOptionsResponse> GetOptionsAsync (string personDbid = null, string agentGroupDbid = null, string application = null);

        /// <summary>
        /// Read options
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch an application Options (CloudCluster by default) and merges it with person and sgent groups annexes.
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="personDbid">DBID of a person. Options will be merged with the Person&#39;s annex and annexes of it&#39;s agent groups. Mutual with agent_group_dbid. (optional)</param>
        /// <param name="agentGroupDbid">DBID of a person. Options will be merged with the Agent Groups&#39;s annex. Mutual with person_dbid. (optional)</param>
        /// <param name="application">Name of an application (optional)</param>
        /// <returns>Task of ApiResponse (GetOptionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetOptionsResponse>> GetOptionsAsyncWithHttpInfo (string personDbid = null, string agentGroupDbid = null, string application = null);
        /// <summary>
        /// Modify options
        /// </summary>
        /// <remarks>
        /// The POST operation will replace CloudCluster/Options with new values
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiSuccessResponse</returns>
        System.Threading.Tasks.Task<ApiSuccessResponse> ModifyOptionsAsync (ModifyOptionsData body);

        /// <summary>
        /// Modify options
        /// </summary>
        /// <remarks>
        /// The POST operation will replace CloudCluster/Options with new values
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiResponse (ApiSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiSuccessResponse>> ModifyOptionsAsyncWithHttpInfo (ModifyOptionsData body);
        /// <summary>
        /// Add, edit or delete options
        /// </summary>
        /// <remarks>
        /// The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiSuccessResponse</returns>
        System.Threading.Tasks.Task<ApiSuccessResponse> UpdateOptionsAsync (UpdateOptionsData body);

        /// <summary>
        /// Add, edit or delete options
        /// </summary>
        /// <remarks>
        /// The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiResponse (ApiSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiSuccessResponse>> UpdateOptionsAsyncWithHttpInfo (UpdateOptionsData body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OptionsApi : IOptionsApi
    {
        private Genesys.Provisioning.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OptionsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Genesys.Provisioning.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OptionsApi(Configuration configuration = null)
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
        /// Read options The GET operation will fetch an application Options (CloudCluster by default) and merges it with person and sgent groups annexes.
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="personDbid">DBID of a person. Options will be merged with the Person&#39;s annex and annexes of it&#39;s agent groups. Mutual with agent_group_dbid. (optional)</param>
        /// <param name="agentGroupDbid">DBID of a person. Options will be merged with the Agent Groups&#39;s annex. Mutual with person_dbid. (optional)</param>
        /// <param name="application">Name of an application (optional)</param>
        /// <returns>GetOptionsResponse</returns>
        public GetOptionsResponse GetOptions (string personDbid = null, string agentGroupDbid = null, string application = null)
        {
             ApiResponse<GetOptionsResponse> localVarResponse = GetOptionsWithHttpInfo(personDbid, agentGroupDbid, application);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read options The GET operation will fetch an application Options (CloudCluster by default) and merges it with person and sgent groups annexes.
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="personDbid">DBID of a person. Options will be merged with the Person&#39;s annex and annexes of it&#39;s agent groups. Mutual with agent_group_dbid. (optional)</param>
        /// <param name="agentGroupDbid">DBID of a person. Options will be merged with the Agent Groups&#39;s annex. Mutual with person_dbid. (optional)</param>
        /// <param name="application">Name of an application (optional)</param>
        /// <returns>ApiResponse of GetOptionsResponse</returns>
        public ApiResponse< GetOptionsResponse > GetOptionsWithHttpInfo (string personDbid = null, string agentGroupDbid = null, string application = null)
        {

            var localVarPath = "/options";
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

            if (personDbid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "person_dbid", personDbid)); // query parameter
            if (agentGroupDbid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "agent_group_dbid", agentGroupDbid)); // query parameter
            if (application != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "application", application)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetOptionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetOptionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetOptionsResponse)));
        }

        /// <summary>
        /// Read options The GET operation will fetch an application Options (CloudCluster by default) and merges it with person and sgent groups annexes.
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="personDbid">DBID of a person. Options will be merged with the Person&#39;s annex and annexes of it&#39;s agent groups. Mutual with agent_group_dbid. (optional)</param>
        /// <param name="agentGroupDbid">DBID of a person. Options will be merged with the Agent Groups&#39;s annex. Mutual with person_dbid. (optional)</param>
        /// <param name="application">Name of an application (optional)</param>
        /// <returns>Task of GetOptionsResponse</returns>
        public async System.Threading.Tasks.Task<GetOptionsResponse> GetOptionsAsync (string personDbid = null, string agentGroupDbid = null, string application = null)
        {
             ApiResponse<GetOptionsResponse> localVarResponse = await GetOptionsAsyncWithHttpInfo(personDbid, agentGroupDbid, application);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read options The GET operation will fetch an application Options (CloudCluster by default) and merges it with person and sgent groups annexes.
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="personDbid">DBID of a person. Options will be merged with the Person&#39;s annex and annexes of it&#39;s agent groups. Mutual with agent_group_dbid. (optional)</param>
        /// <param name="agentGroupDbid">DBID of a person. Options will be merged with the Agent Groups&#39;s annex. Mutual with person_dbid. (optional)</param>
        /// <param name="application">Name of an application (optional)</param>
        /// <returns>Task of ApiResponse (GetOptionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetOptionsResponse>> GetOptionsAsyncWithHttpInfo (string personDbid = null, string agentGroupDbid = null, string application = null)
        {

            var localVarPath = "/options";
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

            if (personDbid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "person_dbid", personDbid)); // query parameter
            if (agentGroupDbid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "agent_group_dbid", agentGroupDbid)); // query parameter
            if (application != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "application", application)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetOptionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetOptionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetOptionsResponse)));
        }

        /// <summary>
        /// Modify options The POST operation will replace CloudCluster/Options with new values
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiSuccessResponse</returns>
        public ApiSuccessResponse ModifyOptions (ModifyOptionsData body)
        {
             ApiResponse<ApiSuccessResponse> localVarResponse = ModifyOptionsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify options The POST operation will replace CloudCluster/Options with new values
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiResponse of ApiSuccessResponse</returns>
        public ApiResponse< ApiSuccessResponse > ModifyOptionsWithHttpInfo (ModifyOptionsData body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OptionsApi->ModifyOptions");

            var localVarPath = "/options";
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ModifyOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiSuccessResponse)));
        }

        /// <summary>
        /// Modify options The POST operation will replace CloudCluster/Options with new values
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiSuccessResponse</returns>
        public async System.Threading.Tasks.Task<ApiSuccessResponse> ModifyOptionsAsync (ModifyOptionsData body)
        {
             ApiResponse<ApiSuccessResponse> localVarResponse = await ModifyOptionsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify options The POST operation will replace CloudCluster/Options with new values
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiResponse (ApiSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiSuccessResponse>> ModifyOptionsAsyncWithHttpInfo (ModifyOptionsData body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OptionsApi->ModifyOptions");

            var localVarPath = "/options";
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ModifyOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiSuccessResponse)));
        }

        /// <summary>
        /// Add, edit or delete options The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiSuccessResponse</returns>
        public ApiSuccessResponse UpdateOptions (UpdateOptionsData body)
        {
             ApiResponse<ApiSuccessResponse> localVarResponse = UpdateOptionsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add, edit or delete options The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiResponse of ApiSuccessResponse</returns>
        public ApiResponse< ApiSuccessResponse > UpdateOptionsWithHttpInfo (UpdateOptionsData body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OptionsApi->UpdateOptions");

            var localVarPath = "/options";
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiSuccessResponse)));
        }

        /// <summary>
        /// Add, edit or delete options The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiSuccessResponse</returns>
        public async System.Threading.Tasks.Task<ApiSuccessResponse> UpdateOptionsAsync (UpdateOptionsData body)
        {
             ApiResponse<ApiSuccessResponse> localVarResponse = await UpdateOptionsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add, edit or delete options The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiResponse (ApiSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiSuccessResponse>> UpdateOptionsAsyncWithHttpInfo (UpdateOptionsData body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OptionsApi->UpdateOptions");

            var localVarPath = "/options";
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiSuccessResponse)));
        }

    }
}
