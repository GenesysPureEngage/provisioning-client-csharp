/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model.  The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.00.423
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
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
        /// The GET operation will fetch CloudCluster/Options
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OptionsGetResponseSuccess</returns>
        OptionsGetResponseSuccess OptionsGet ();

        /// <summary>
        /// Read options
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch CloudCluster/Options
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OptionsGetResponseSuccess</returns>
        ApiResponse<OptionsGetResponseSuccess> OptionsGetWithHttpInfo ();
        /// <summary>
        /// Update options
        /// </summary>
        /// <remarks>
        /// The POST operation will replace CloudCluster/Options with new values
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>OptionsPostResponseStatusSuccess</returns>
        OptionsPostResponseStatusSuccess OptionsPost (OptionsPost body);

        /// <summary>
        /// Update options
        /// </summary>
        /// <remarks>
        /// The POST operation will replace CloudCluster/Options with new values
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiResponse of OptionsPostResponseStatusSuccess</returns>
        ApiResponse<OptionsPostResponseStatusSuccess> OptionsPostWithHttpInfo (OptionsPost body);
        /// <summary>
        /// Add, Edit or delete options
        /// </summary>
        /// <remarks>
        /// The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>OptionsPutResponseStatusSuccess</returns>
        OptionsPutResponseStatusSuccess OptionsPut (OptionsPut body);

        /// <summary>
        /// Add, Edit or delete options
        /// </summary>
        /// <remarks>
        /// The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiResponse of OptionsPutResponseStatusSuccess</returns>
        ApiResponse<OptionsPutResponseStatusSuccess> OptionsPutWithHttpInfo (OptionsPut body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Read options
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch CloudCluster/Options
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OptionsGetResponseSuccess</returns>
        System.Threading.Tasks.Task<OptionsGetResponseSuccess> OptionsGetAsync ();

        /// <summary>
        /// Read options
        /// </summary>
        /// <remarks>
        /// The GET operation will fetch CloudCluster/Options
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OptionsGetResponseSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionsGetResponseSuccess>> OptionsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Update options
        /// </summary>
        /// <remarks>
        /// The POST operation will replace CloudCluster/Options with new values
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of OptionsPostResponseStatusSuccess</returns>
        System.Threading.Tasks.Task<OptionsPostResponseStatusSuccess> OptionsPostAsync (OptionsPost body);

        /// <summary>
        /// Update options
        /// </summary>
        /// <remarks>
        /// The POST operation will replace CloudCluster/Options with new values
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiResponse (OptionsPostResponseStatusSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionsPostResponseStatusSuccess>> OptionsPostAsyncWithHttpInfo (OptionsPost body);
        /// <summary>
        /// Add, Edit or delete options
        /// </summary>
        /// <remarks>
        /// The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of OptionsPutResponseStatusSuccess</returns>
        System.Threading.Tasks.Task<OptionsPutResponseStatusSuccess> OptionsPutAsync (OptionsPut body);

        /// <summary>
        /// Add, Edit or delete options
        /// </summary>
        /// <remarks>
        /// The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiResponse (OptionsPutResponseStatusSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionsPutResponseStatusSuccess>> OptionsPutAsyncWithHttpInfo (OptionsPut body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OptionsApi : IOptionsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OptionsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

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
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Read options The GET operation will fetch CloudCluster/Options
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OptionsGetResponseSuccess</returns>
        public OptionsGetResponseSuccess OptionsGet ()
        {
             ApiResponse<OptionsGetResponseSuccess> localVarResponse = OptionsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read options The GET operation will fetch CloudCluster/Options
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OptionsGetResponseSuccess</returns>
        public ApiResponse< OptionsGetResponseSuccess > OptionsGetWithHttpInfo ()
        {

            var localVarPath = "/options";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionsGetResponseSuccess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OptionsGetResponseSuccess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionsGetResponseSuccess)));
            
        }

        /// <summary>
        /// Read options The GET operation will fetch CloudCluster/Options
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OptionsGetResponseSuccess</returns>
        public async System.Threading.Tasks.Task<OptionsGetResponseSuccess> OptionsGetAsync ()
        {
             ApiResponse<OptionsGetResponseSuccess> localVarResponse = await OptionsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read options The GET operation will fetch CloudCluster/Options
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OptionsGetResponseSuccess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionsGetResponseSuccess>> OptionsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/options";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionsGetResponseSuccess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OptionsGetResponseSuccess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionsGetResponseSuccess)));
            
        }

        /// <summary>
        /// Update options The POST operation will replace CloudCluster/Options with new values
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>OptionsPostResponseStatusSuccess</returns>
        public OptionsPostResponseStatusSuccess OptionsPost (OptionsPost body)
        {
             ApiResponse<OptionsPostResponseStatusSuccess> localVarResponse = OptionsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update options The POST operation will replace CloudCluster/Options with new values
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiResponse of OptionsPostResponseStatusSuccess</returns>
        public ApiResponse< OptionsPostResponseStatusSuccess > OptionsPostWithHttpInfo (OptionsPost body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OptionsApi->OptionsPost");

            var localVarPath = "/options";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionsPostResponseStatusSuccess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OptionsPostResponseStatusSuccess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionsPostResponseStatusSuccess)));
            
        }

        /// <summary>
        /// Update options The POST operation will replace CloudCluster/Options with new values
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of OptionsPostResponseStatusSuccess</returns>
        public async System.Threading.Tasks.Task<OptionsPostResponseStatusSuccess> OptionsPostAsync (OptionsPost body)
        {
             ApiResponse<OptionsPostResponseStatusSuccess> localVarResponse = await OptionsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update options The POST operation will replace CloudCluster/Options with new values
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiResponse (OptionsPostResponseStatusSuccess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionsPostResponseStatusSuccess>> OptionsPostAsyncWithHttpInfo (OptionsPost body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OptionsApi->OptionsPost");

            var localVarPath = "/options";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionsPostResponseStatusSuccess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OptionsPostResponseStatusSuccess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionsPostResponseStatusSuccess)));
            
        }

        /// <summary>
        /// Add, Edit or delete options The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>OptionsPutResponseStatusSuccess</returns>
        public OptionsPutResponseStatusSuccess OptionsPut (OptionsPut body)
        {
             ApiResponse<OptionsPutResponseStatusSuccess> localVarResponse = OptionsPutWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add, Edit or delete options The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>ApiResponse of OptionsPutResponseStatusSuccess</returns>
        public ApiResponse< OptionsPutResponseStatusSuccess > OptionsPutWithHttpInfo (OptionsPut body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OptionsApi->OptionsPut");

            var localVarPath = "/options";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsPut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionsPutResponseStatusSuccess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OptionsPutResponseStatusSuccess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionsPutResponseStatusSuccess)));
            
        }

        /// <summary>
        /// Add, Edit or delete options The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of OptionsPutResponseStatusSuccess</returns>
        public async System.Threading.Tasks.Task<OptionsPutResponseStatusSuccess> OptionsPutAsync (OptionsPut body)
        {
             ApiResponse<OptionsPutResponseStatusSuccess> localVarResponse = await OptionsPutAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add, Edit or delete options The PUT operation will add, change or delete values in CloudCluster/Options.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Body Data</param>
        /// <returns>Task of ApiResponse (OptionsPutResponseStatusSuccess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionsPutResponseStatusSuccess>> OptionsPutAsyncWithHttpInfo (OptionsPut body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OptionsApi->OptionsPut");

            var localVarPath = "/options";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OptionsPut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionsPutResponseStatusSuccess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OptionsPutResponseStatusSuccess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionsPutResponseStatusSuccess)));
            
        }

    }
}
