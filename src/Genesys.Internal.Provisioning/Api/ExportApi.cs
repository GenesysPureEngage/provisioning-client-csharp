/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.15.2202
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Genesys.Internal.Provisioning.Client;
using Genesys.Internal.Provisioning.Model;

namespace Genesys.Internal.Provisioning.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Export users.
        /// </summary>
        /// <remarks>
        /// Export the specified users with the properties you list in the **fields** parameter.
        /// </remarks>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportFileData">Export File Data</param>
        /// <returns>ExportFileResponse</returns>
        ExportFileResponse ExportFile (ExportFileData exportFileData);

        /// <summary>
        /// Export users.
        /// </summary>
        /// <remarks>
        /// Export the specified users with the properties you list in the **fields** parameter.
        /// </remarks>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportFileData">Export File Data</param>
        /// <returns>ApiResponse of ExportFileResponse</returns>
        ApiResponse<ExportFileResponse> ExportFileWithHttpInfo (ExportFileData exportFileData);
        /// <summary>
        /// Get export status.
        /// </summary>
        /// <remarks>
        /// Check the status of the specified export and return the percentage complete.
        /// </remarks>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of a previously started export.</param>
        /// <returns>ExportStatusResponse</returns>
        ExportStatusResponse GetExportStatus (int? id);

        /// <summary>
        /// Get export status.
        /// </summary>
        /// <remarks>
        /// Check the status of the specified export and return the percentage complete.
        /// </remarks>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of a previously started export.</param>
        /// <returns>ApiResponse of ExportStatusResponse</returns>
        ApiResponse<ExportStatusResponse> GetExportStatusWithHttpInfo (int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Export users.
        /// </summary>
        /// <remarks>
        /// Export the specified users with the properties you list in the **fields** parameter.
        /// </remarks>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportFileData">Export File Data</param>
        /// <returns>Task of ExportFileResponse</returns>
        System.Threading.Tasks.Task<ExportFileResponse> ExportFileAsync (ExportFileData exportFileData);

        /// <summary>
        /// Export users.
        /// </summary>
        /// <remarks>
        /// Export the specified users with the properties you list in the **fields** parameter.
        /// </remarks>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportFileData">Export File Data</param>
        /// <returns>Task of ApiResponse (ExportFileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportFileResponse>> ExportFileAsyncWithHttpInfo (ExportFileData exportFileData);
        /// <summary>
        /// Get export status.
        /// </summary>
        /// <remarks>
        /// Check the status of the specified export and return the percentage complete.
        /// </remarks>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of a previously started export.</param>
        /// <returns>Task of ExportStatusResponse</returns>
        System.Threading.Tasks.Task<ExportStatusResponse> GetExportStatusAsync (int? id);

        /// <summary>
        /// Get export status.
        /// </summary>
        /// <remarks>
        /// Check the status of the specified export and return the percentage complete.
        /// </remarks>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of a previously started export.</param>
        /// <returns>Task of ApiResponse (ExportStatusResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportStatusResponse>> GetExportStatusAsyncWithHttpInfo (int? id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExportApi : IExportApi
    {
        private Genesys.Internal.Provisioning.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExportApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Genesys.Internal.Provisioning.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExportApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Genesys.Internal.Provisioning.Client.Configuration.DefaultExceptionFactory;
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
        public Genesys.Internal.Provisioning.Client.ExceptionFactory ExceptionFactory
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
        /// Export users. Export the specified users with the properties you list in the **fields** parameter.
        /// </summary>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportFileData">Export File Data</param>
        /// <returns>ExportFileResponse</returns>
        public ExportFileResponse ExportFile (ExportFileData exportFileData)
        {
             ApiResponse<ExportFileResponse> localVarResponse = ExportFileWithHttpInfo(exportFileData);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Export users. Export the specified users with the properties you list in the **fields** parameter.
        /// </summary>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportFileData">Export File Data</param>
        /// <returns>ApiResponse of ExportFileResponse</returns>
        public ApiResponse< ExportFileResponse > ExportFileWithHttpInfo (ExportFileData exportFileData)
        {
            // verify the required parameter 'exportFileData' is set
            if (exportFileData == null)
                throw new ApiException(400, "Missing required parameter 'exportFileData' when calling ExportApi->ExportFile");

            var localVarPath = "/export-users";
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

            if (exportFileData != null && exportFileData.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(exportFileData); // http body (model) parameter
            }
            else
            {
                localVarPostBody = exportFileData; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExportFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExportFileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportFileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportFileResponse)));
        }

        /// <summary>
        /// Export users. Export the specified users with the properties you list in the **fields** parameter.
        /// </summary>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportFileData">Export File Data</param>
        /// <returns>Task of ExportFileResponse</returns>
        public async System.Threading.Tasks.Task<ExportFileResponse> ExportFileAsync (ExportFileData exportFileData)
        {
             ApiResponse<ExportFileResponse> localVarResponse = await ExportFileAsyncWithHttpInfo(exportFileData);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Export users. Export the specified users with the properties you list in the **fields** parameter.
        /// </summary>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportFileData">Export File Data</param>
        /// <returns>Task of ApiResponse (ExportFileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportFileResponse>> ExportFileAsyncWithHttpInfo (ExportFileData exportFileData)
        {
            // verify the required parameter 'exportFileData' is set
            if (exportFileData == null)
                throw new ApiException(400, "Missing required parameter 'exportFileData' when calling ExportApi->ExportFile");

            var localVarPath = "/export-users";
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

            if (exportFileData != null && exportFileData.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(exportFileData); // http body (model) parameter
            }
            else
            {
                localVarPostBody = exportFileData; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExportFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExportFileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportFileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportFileResponse)));
        }

        /// <summary>
        /// Get export status. Check the status of the specified export and return the percentage complete.
        /// </summary>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of a previously started export.</param>
        /// <returns>ExportStatusResponse</returns>
        public ExportStatusResponse GetExportStatus (int? id)
        {
             ApiResponse<ExportStatusResponse> localVarResponse = GetExportStatusWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get export status. Check the status of the specified export and return the percentage complete.
        /// </summary>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of a previously started export.</param>
        /// <returns>ApiResponse of ExportStatusResponse</returns>
        public ApiResponse< ExportStatusResponse > GetExportStatusWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ExportApi->GetExportStatus");

            var localVarPath = "/export-users";
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

            if (id != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExportStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExportStatusResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportStatusResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportStatusResponse)));
        }

        /// <summary>
        /// Get export status. Check the status of the specified export and return the percentage complete.
        /// </summary>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of a previously started export.</param>
        /// <returns>Task of ExportStatusResponse</returns>
        public async System.Threading.Tasks.Task<ExportStatusResponse> GetExportStatusAsync (int? id)
        {
             ApiResponse<ExportStatusResponse> localVarResponse = await GetExportStatusAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get export status. Check the status of the specified export and return the percentage complete.
        /// </summary>
        /// <exception cref="Genesys.Internal.Provisioning.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of a previously started export.</param>
        /// <returns>Task of ApiResponse (ExportStatusResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportStatusResponse>> GetExportStatusAsyncWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ExportApi->GetExportStatus");

            var localVarPath = "/export-users";
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

            if (id != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExportStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExportStatusResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportStatusResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportStatusResponse)));
        }

    }
}
