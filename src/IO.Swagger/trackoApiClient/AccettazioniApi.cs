/* 
 * Tracko
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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

namespace IO.Swagger.trackoApiClient
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccettazioniApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oRequest"></param>
        /// <returns>BackofficeModelAPICommonDataSourceResult</returns>
        BackofficeModelAPICommonDataSourceResult AccettazioniGetList (BackofficeModelAccettazioniIndexMaskModel oRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oRequest"></param>
        /// <returns>ApiResponse of BackofficeModelAPICommonDataSourceResult</returns>
        ApiResponse<BackofficeModelAPICommonDataSourceResult> AccettazioniGetListWithHttpInfo (BackofficeModelAccettazioniIndexMaskModel oRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oRequest"></param>
        /// <returns>Task of BackofficeModelAPICommonDataSourceResult</returns>
        System.Threading.Tasks.Task<BackofficeModelAPICommonDataSourceResult> AccettazioniGetListAsync (BackofficeModelAccettazioniIndexMaskModel oRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oRequest"></param>
        /// <returns>Task of ApiResponse (BackofficeModelAPICommonDataSourceResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<BackofficeModelAPICommonDataSourceResult>> AccettazioniGetListAsyncWithHttpInfo (BackofficeModelAccettazioniIndexMaskModel oRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccettazioniApi : IAccettazioniApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccettazioniApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccettazioniApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccettazioniApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccettazioniApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Client.Configuration Configuration {get; set;}

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
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oRequest"></param>
        /// <returns>BackofficeModelAPICommonDataSourceResult</returns>
        public BackofficeModelAPICommonDataSourceResult AccettazioniGetList (BackofficeModelAccettazioniIndexMaskModel oRequest)
        {
             ApiResponse<BackofficeModelAPICommonDataSourceResult> localVarResponse = AccettazioniGetListWithHttpInfo(oRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oRequest"></param>
        /// <returns>ApiResponse of BackofficeModelAPICommonDataSourceResult</returns>
        public ApiResponse< BackofficeModelAPICommonDataSourceResult > AccettazioniGetListWithHttpInfo (BackofficeModelAccettazioniIndexMaskModel oRequest)
        {
            // verify the required parameter 'oRequest' is set
            if (oRequest == null)
                throw new ApiException(400, "Missing required parameter 'oRequest' when calling AccettazioniApi->AccettazioniGetList");

            var localVarPath = "/api/Accettazioni/GetList";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (oRequest != null && oRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(oRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = oRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccettazioniGetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BackofficeModelAPICommonDataSourceResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BackofficeModelAPICommonDataSourceResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BackofficeModelAPICommonDataSourceResult)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oRequest"></param>
        /// <returns>Task of BackofficeModelAPICommonDataSourceResult</returns>
        public async System.Threading.Tasks.Task<BackofficeModelAPICommonDataSourceResult> AccettazioniGetListAsync (BackofficeModelAccettazioniIndexMaskModel oRequest)
        {
             ApiResponse<BackofficeModelAPICommonDataSourceResult> localVarResponse = await AccettazioniGetListAsyncWithHttpInfo(oRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oRequest"></param>
        /// <returns>Task of ApiResponse (BackofficeModelAPICommonDataSourceResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BackofficeModelAPICommonDataSourceResult>> AccettazioniGetListAsyncWithHttpInfo (BackofficeModelAccettazioniIndexMaskModel oRequest)
        {
            // verify the required parameter 'oRequest' is set
            if (oRequest == null)
                throw new ApiException(400, "Missing required parameter 'oRequest' when calling AccettazioniApi->AccettazioniGetList");

            var localVarPath = "/api/Accettazioni/GetList";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (oRequest != null && oRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(oRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = oRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccettazioniGetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BackofficeModelAPICommonDataSourceResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BackofficeModelAPICommonDataSourceResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BackofficeModelAPICommonDataSourceResult)));
        }

    }
}