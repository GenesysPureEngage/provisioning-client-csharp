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
    public interface ISessionApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <remarks>
        /// Initialize-provisioning operation will create a new sessionId and set default.yml:common.cookieName cookie (PROVISIONING_SESSIONID by default). 
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">Authentication code received from the Auth service</param>
        /// <returns>LoginSuccessResponse</returns>
        LoginSuccessResponse InitializeProvisioning (InitProvData code);

        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <remarks>
        /// Initialize-provisioning operation will create a new sessionId and set default.yml:common.cookieName cookie (PROVISIONING_SESSIONID by default). 
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">Authentication code received from the Auth service</param>
        /// <returns>ApiResponse of LoginSuccessResponse</returns>
        ApiResponse<LoginSuccessResponse> InitializeProvisioningWithHttpInfo (InitProvData code);
        /// <summary>
        /// Logout user
        /// </summary>
        /// <remarks>
        /// The POST operation will delete a session and remove associated cookie 
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiSuccessResponse</returns>
        ApiSuccessResponse Logout ();

        /// <summary>
        /// Logout user
        /// </summary>
        /// <remarks>
        /// The POST operation will delete a session and remove associated cookie 
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ApiSuccessResponse</returns>
        ApiResponse<ApiSuccessResponse> LogoutWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <remarks>
        /// Initialize-provisioning operation will create a new sessionId and set default.yml:common.cookieName cookie (PROVISIONING_SESSIONID by default). 
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">Authentication code received from the Auth service</param>
        /// <returns>Task of LoginSuccessResponse</returns>
        System.Threading.Tasks.Task<LoginSuccessResponse> InitializeProvisioningAsync (InitProvData code);

        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <remarks>
        /// Initialize-provisioning operation will create a new sessionId and set default.yml:common.cookieName cookie (PROVISIONING_SESSIONID by default). 
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">Authentication code received from the Auth service</param>
        /// <returns>Task of ApiResponse (LoginSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoginSuccessResponse>> InitializeProvisioningAsyncWithHttpInfo (InitProvData code);
        /// <summary>
        /// Logout user
        /// </summary>
        /// <remarks>
        /// The POST operation will delete a session and remove associated cookie 
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiSuccessResponse</returns>
        System.Threading.Tasks.Task<ApiSuccessResponse> LogoutAsync ();

        /// <summary>
        /// Logout user
        /// </summary>
        /// <remarks>
        /// The POST operation will delete a session and remove associated cookie 
        /// </remarks>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ApiSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiSuccessResponse>> LogoutAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SessionApi : ISessionApi
    {
        private Genesys.Provisioning.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SessionApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Genesys.Provisioning.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SessionApi(Configuration configuration = null)
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
        /// Authenticate user Initialize-provisioning operation will create a new sessionId and set default.yml:common.cookieName cookie (PROVISIONING_SESSIONID by default). 
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">Authentication code received from the Auth service</param>
        /// <returns>LoginSuccessResponse</returns>
        public LoginSuccessResponse InitializeProvisioning (InitProvData code)
        {
             ApiResponse<LoginSuccessResponse> localVarResponse = InitializeProvisioningWithHttpInfo(code);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticate user Initialize-provisioning operation will create a new sessionId and set default.yml:common.cookieName cookie (PROVISIONING_SESSIONID by default). 
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">Authentication code received from the Auth service</param>
        /// <returns>ApiResponse of LoginSuccessResponse</returns>
        public ApiResponse< LoginSuccessResponse > InitializeProvisioningWithHttpInfo (InitProvData code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling SessionApi->InitializeProvisioning");

            var localVarPath = "/initialize-provisioning";
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

            if (code != null && code.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(code); // http body (model) parameter
            }
            else
            {
                localVarPostBody = code; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InitializeProvisioning", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LoginSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoginSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoginSuccessResponse)));
        }

        /// <summary>
        /// Authenticate user Initialize-provisioning operation will create a new sessionId and set default.yml:common.cookieName cookie (PROVISIONING_SESSIONID by default). 
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">Authentication code received from the Auth service</param>
        /// <returns>Task of LoginSuccessResponse</returns>
        public async System.Threading.Tasks.Task<LoginSuccessResponse> InitializeProvisioningAsync (InitProvData code)
        {
             ApiResponse<LoginSuccessResponse> localVarResponse = await InitializeProvisioningAsyncWithHttpInfo(code);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Authenticate user Initialize-provisioning operation will create a new sessionId and set default.yml:common.cookieName cookie (PROVISIONING_SESSIONID by default). 
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">Authentication code received from the Auth service</param>
        /// <returns>Task of ApiResponse (LoginSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoginSuccessResponse>> InitializeProvisioningAsyncWithHttpInfo (InitProvData code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling SessionApi->InitializeProvisioning");

            var localVarPath = "/initialize-provisioning";
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

            if (code != null && code.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(code); // http body (model) parameter
            }
            else
            {
                localVarPostBody = code; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InitializeProvisioning", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LoginSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoginSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoginSuccessResponse)));
        }

        /// <summary>
        /// Logout user The POST operation will delete a session and remove associated cookie 
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiSuccessResponse</returns>
        public ApiSuccessResponse Logout ()
        {
             ApiResponse<ApiSuccessResponse> localVarResponse = LogoutWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Logout user The POST operation will delete a session and remove associated cookie 
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ApiSuccessResponse</returns>
        public ApiResponse< ApiSuccessResponse > LogoutWithHttpInfo ()
        {

            var localVarPath = "/logout";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Logout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiSuccessResponse)));
        }

        /// <summary>
        /// Logout user The POST operation will delete a session and remove associated cookie 
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiSuccessResponse</returns>
        public async System.Threading.Tasks.Task<ApiSuccessResponse> LogoutAsync ()
        {
             ApiResponse<ApiSuccessResponse> localVarResponse = await LogoutAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Logout user The POST operation will delete a session and remove associated cookie 
        /// </summary>
        /// <exception cref="Genesys.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ApiSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiSuccessResponse>> LogoutAsyncWithHttpInfo ()
        {

            var localVarPath = "/logout";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Logout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiSuccessResponse)));
        }

    }
}
