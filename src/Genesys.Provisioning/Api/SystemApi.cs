/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.00.1086
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
    public interface ISystemApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// execute service method on Node to avoid excessive requests from client
        /// </summary>
        /// <remarks>
        /// This operation will execute service method on Node
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">Service name</param>
        /// <returns></returns>
        void ExecuteServiceMethod (string serviceName);

        /// <summary>
        /// execute service method on Node to avoid excessive requests from client
        /// </summary>
        /// <remarks>
        /// This operation will execute service method on Node
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">Service name</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ExecuteServiceMethodWithHttpInfo (string serviceName);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// execute service method on Node to avoid excessive requests from client
        /// </summary>
        /// <remarks>
        /// This operation will execute service method on Node
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">Service name</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ExecuteServiceMethodAsync (string serviceName);

        /// <summary>
        /// execute service method on Node to avoid excessive requests from client
        /// </summary>
        /// <remarks>
        /// This operation will execute service method on Node
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">Service name</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ExecuteServiceMethodAsyncWithHttpInfo (string serviceName);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SystemApi : ISystemApi
    {
        private Genesys.Provisioning.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Genesys.Provisioning.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SystemApi(Configuration configuration = null)
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
        /// execute service method on Node to avoid excessive requests from client This operation will execute service method on Node
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">Service name</param>
        /// <returns></returns>
        public void ExecuteServiceMethod (string serviceName)
        {
             ExecuteServiceMethodWithHttpInfo(serviceName);
        }

        /// <summary>
        /// execute service method on Node to avoid excessive requests from client This operation will execute service method on Node
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">Service name</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ExecuteServiceMethodWithHttpInfo (string serviceName)
        {
            // verify the required parameter 'serviceName' is set
            if (serviceName == null)
                throw new ApiException(400, "Missing required parameter 'serviceName' when calling SystemApi->ExecuteServiceMethod");

            var localVarPath = "/service-proxy/{serviceName}";
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

            if (serviceName != null) localVarPathParams.Add("serviceName", Configuration.ApiClient.ParameterToString(serviceName)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExecuteServiceMethod", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// execute service method on Node to avoid excessive requests from client This operation will execute service method on Node
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">Service name</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ExecuteServiceMethodAsync (string serviceName)
        {
             await ExecuteServiceMethodAsyncWithHttpInfo(serviceName);

        }

        /// <summary>
        /// execute service method on Node to avoid excessive requests from client This operation will execute service method on Node
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">Service name</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ExecuteServiceMethodAsyncWithHttpInfo (string serviceName)
        {
            // verify the required parameter 'serviceName' is set
            if (serviceName == null)
                throw new ApiException(400, "Missing required parameter 'serviceName' when calling SystemApi->ExecuteServiceMethod");

            var localVarPath = "/service-proxy/{serviceName}";
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

            if (serviceName != null) localVarPathParams.Add("serviceName", Configuration.ApiClient.ParameterToString(serviceName)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExecuteServiceMethod", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
