/* 
 * Qlik NPrinting API
 *
 * You can extend your reporting system by using the Qlik NPrinting API. This API provides endpoints to perform operations on apps, On-Demand requests and results, reports, filters, and so on.  For all requests, the data returned is filtered based on user permissions. That is, if a user is not authorized to access a certain object, that object is not returned in the reponse.  API Stability: Experimental.  Deprecation period: None. Can change at any point and should be used only to evaluate upcoming functionality.     
 *
 * OpenAPI spec version: 0.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;
using RestSharp;

namespace Qlik.NPrinting.Rest.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Authenticates the caller using NTLM authentication.
        /// </summary>
        /// <remarks>
        /// Call this endpoint to authenticate the user. For cross-site (CORS) requests, set &#x60;withCredentials&#x60; to true.   Javascript clients must pass the NTLM token using XHR credentials.  Examples:  &#x60;&#x60;&#x60;javascript  // Plain javascript // https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials  var xhr &#x3D; new XMLHttpRequest(); xhr.open(&#39;GET&#39;, &#39;http://example.com:port/api/v1/login/ntlm&#39;, true); xhr.withCredentials &#x3D; true; xhr.send(null);  // Jquery // http://api.jquery.com/jquery.ajax/  $.ajax({    url: &#39;http://example.com:port/api/v1/login/ntlm&#39;,    xhrFields: {       withCredentials: true    } });  &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>


        /// <summary>
        /// Authenticates the caller using NTLM authentication.
        /// </summary>
        /// <remarks>
        /// Call this endpoint to authenticate the user. For cross-site (CORS) requests, set &#x60;withCredentials&#x60; to true.   Javascript clients must pass the NTLM token using XHR credentials.  Examples:  &#x60;&#x60;&#x60;javascript  // Plain javascript // https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials  var xhr &#x3D; new XMLHttpRequest(); xhr.open(&#39;GET&#39;, &#39;http://example.com:port/api/v1/login/ntlm&#39;, true); xhr.withCredentials &#x3D; true; xhr.send(null);  // Jquery // http://api.jquery.com/jquery.ajax/  $.ajax({    url: &#39;http://example.com:port/api/v1/login/ntlm&#39;,    xhrFields: {       withCredentials: true    } });  &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IList&lt;RestResponseCookie&gt;</returns>
        IList<RestResponseCookie> GetNPrintingCookiesWithHttpInfo ();
        /// <summary>
        /// Authenticates the caller using Basic authentication.
        /// </summary>
        /// <remarks>
        /// Call this endpoint to authenticate the user 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationRequest">Details about the user to authenticate.</param>
        /// <returns>AuthenticationResponse</returns>
        AuthenticationResponse LoginPost (AuthenticationRequest authenticationRequest);

        /// <summary>
        /// Authenticates the caller using Basic authentication.
        /// </summary>
        /// <remarks>
        /// Call this endpoint to authenticate the user 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationRequest">Details about the user to authenticate.</param>
        /// <returns>ApiResponse of AuthenticationResponse</returns>
        ApiResponse<AuthenticationResponse> LoginPostWithHttpInfo (AuthenticationRequest authenticationRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Authenticates the caller using NTLM authentication.
        /// </summary>
        /// <remarks>
        /// Call this endpoint to authenticate the user. For cross-site (CORS) requests, set &#x60;withCredentials&#x60; to true.   Javascript clients must pass the NTLM token using XHR credentials.  Examples:  &#x60;&#x60;&#x60;javascript  // Plain javascript // https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials  var xhr &#x3D; new XMLHttpRequest(); xhr.open(&#39;GET&#39;, &#39;http://example.com:port/api/v1/login/ntlm&#39;, true); xhr.withCredentials &#x3D; true; xhr.send(null);  // Jquery // http://api.jquery.com/jquery.ajax/  $.ajax({    url: &#39;http://example.com:port/api/v1/login/ntlm&#39;,    xhrFields: {       withCredentials: true    } });  &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetNPrintingCookiesAsync ();

        /// <summary>
        /// Authenticates the caller using NTLM authentication.
        /// </summary>
        /// <remarks>
        /// Call this endpoint to authenticate the user. For cross-site (CORS) requests, set &#x60;withCredentials&#x60; to true.   Javascript clients must pass the NTLM token using XHR credentials.  Examples:  &#x60;&#x60;&#x60;javascript  // Plain javascript // https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials  var xhr &#x3D; new XMLHttpRequest(); xhr.open(&#39;GET&#39;, &#39;http://example.com:port/api/v1/login/ntlm&#39;, true); xhr.withCredentials &#x3D; true; xhr.send(null);  // Jquery // http://api.jquery.com/jquery.ajax/  $.ajax({    url: &#39;http://example.com:port/api/v1/login/ntlm&#39;,    xhrFields: {       withCredentials: true    } });  &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IList&lt;RestResponseCookie&gt;</returns>
        System.Threading.Tasks.Task<IList<RestResponseCookie>> GetNPrintingCookiesAsyncWithHttpInfo ();
        /// <summary>
        /// Authenticates the caller using Basic authentication.
        /// </summary>
        /// <remarks>
        /// Call this endpoint to authenticate the user 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationRequest">Details about the user to authenticate.</param>
        /// <returns>Task of AuthenticationResponse</returns>
        System.Threading.Tasks.Task<AuthenticationResponse> LoginPostAsync (AuthenticationRequest authenticationRequest);

        /// <summary>
        /// Authenticates the caller using Basic authentication.
        /// </summary>
        /// <remarks>
        /// Call this endpoint to authenticate the user 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationRequest">Details about the user to authenticate.</param>
        /// <returns>Task of ApiResponse (AuthenticationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthenticationResponse>> LoginPostAsyncWithHttpInfo (AuthenticationRequest authenticationRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationApi : IAuthenticationApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        
        public AuthenticationApi(ApiClient apiClient)
        {
            this.ApiClient = apiClient;

            ExceptionFactory = ApiClient.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.ApiClient.RestClient.BaseUrl.ToString();
        }

        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
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
        /// Authenticates the caller using NTLM authentication. Call this endpoint to authenticate the user. For cross-site (CORS) requests, set &#x60;withCredentials&#x60; to true.   Javascript clients must pass the NTLM token using XHR credentials.  Examples:  &#x60;&#x60;&#x60;javascript  // Plain javascript // https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials  var xhr &#x3D; new XMLHttpRequest(); xhr.open(&#39;GET&#39;, &#39;http://example.com:port/api/v1/login/ntlm&#39;, true); xhr.withCredentials &#x3D; true; xhr.send(null);  // Jquery // http://api.jquery.com/jquery.ajax/  $.ajax({    url: &#39;http://example.com:port/api/v1/login/ntlm&#39;,    xhrFields: {       withCredentials: true    } });  &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> NtlmAuthentication()
        {

            var localVarPath = ApiClient.ApiPathPrefix + "/login/ntlm";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP authenticationRequest
            IRestResponse localVarResponse = (IRestResponse)this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoginNtlmGet", localVarResponse);
                if (exception != null) throw exception;
            }


            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }



        /// <summary>
        /// Authenticates the caller using NTLM authentication. Call this endpoint to authenticate the user. For cross-site (CORS) requests, set &#x60;withCredentials&#x60; to true.   Javascript clients must pass the NTLM token using XHR credentials.  Examples:  &#x60;&#x60;&#x60;javascript  // Plain javascript // https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials  var xhr &#x3D; new XMLHttpRequest(); xhr.open(&#39;GET&#39;, &#39;http://example.com:port/api/v1/login/ntlm&#39;, true); xhr.withCredentials &#x3D; true; xhr.send(null);  // Jquery // http://api.jquery.com/jquery.ajax/  $.ajax({    url: &#39;http://example.com:port/api/v1/login/ntlm&#39;,    xhrFields: {       withCredentials: true    } });  &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IList&lt;RestResponseCookie&gt;</returns>
        public IList<RestResponseCookie> GetNPrintingCookiesWithHttpInfo () 
        {

            const string localVarPath = "/";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // make the HTTP authenticationRequest
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoginNtlmGet", localVarResponse);
                if (exception != null) throw exception;
            }

            IList<RestResponseCookie> cookies = localVarResponse.Cookies;
            
            return cookies;
        }

        /// <summary>
        /// Authenticates the caller using NTLM authentication. Call this endpoint to authenticate the user. For cross-site (CORS) requests, set &#x60;withCredentials&#x60; to true.   Javascript clients must pass the NTLM token using XHR credentials.  Examples:  &#x60;&#x60;&#x60;javascript  // Plain javascript // https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials  var xhr &#x3D; new XMLHttpRequest(); xhr.open(&#39;GET&#39;, &#39;http://example.com:port/api/v1/login/ntlm&#39;, true); xhr.withCredentials &#x3D; true; xhr.send(null);  // Jquery // http://api.jquery.com/jquery.ajax/  $.ajax({    url: &#39;http://example.com:port/api/v1/login/ntlm&#39;,    xhrFields: {       withCredentials: true    } });  &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetNPrintingCookiesAsync ()
        {
             await GetNPrintingCookiesAsyncWithHttpInfo();

        }

        /// <summary>
        /// Authenticates the caller using NTLM authentication. Call this endpoint to authenticate the user. For cross-site (CORS) requests, set &#x60;withCredentials&#x60; to true.   Javascript clients must pass the NTLM token using XHR credentials.  Examples:  &#x60;&#x60;&#x60;javascript  // Plain javascript // https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/withCredentials  var xhr &#x3D; new XMLHttpRequest(); xhr.open(&#39;GET&#39;, &#39;http://example.com:port/api/v1/login/ntlm&#39;, true); xhr.withCredentials &#x3D; true; xhr.send(null);  // Jquery // http://api.jquery.com/jquery.ajax/  $.ajax({    url: &#39;http://example.com:port/api/v1/login/ntlm&#39;,    xhrFields: {       withCredentials: true    } });  &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<IList<RestResponseCookie>> GetNPrintingCookiesAsyncWithHttpInfo ()
        {

            var localVarPath = "/"; ;
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP authenticationRequest
            IRestResponse localVarResponse = (IRestResponse) await this.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoginNtlmGet", localVarResponse);
                if (exception != null) throw exception;
            }

            IList<RestResponseCookie> cookies = localVarResponse.Cookies;

            return cookies;
        }

        /// <summary>
        /// Authenticates the caller using Basic authentication. Call this endpoint to authenticate the user 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationRequest">Details about the user to authenticate.</param>
        /// <returns>AuthenticationResponse</returns>
        public AuthenticationResponse LoginPost (AuthenticationRequest authenticationRequest)
        {
             ApiResponse<AuthenticationResponse> localVarResponse = LoginPostWithHttpInfo(authenticationRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticates the caller using Basic authentication. Call this endpoint to authenticate the user 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationRequest">Details about the user to authenticate.</param>
        /// <returns>ApiResponse of AuthenticationResponse</returns>
        public ApiResponse< AuthenticationResponse > LoginPostWithHttpInfo (AuthenticationRequest authenticationRequest)
        {
            // verify the required parameter 'authenticationRequest' is set
            if (authenticationRequest == null)
                throw new ApiException(400, "Missing required parameter 'authenticationRequest' when calling AuthenticationApi->LoginPost");

            var localVarPath = "/login";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (authenticationRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.ApiClient.Serialize(authenticationRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authenticationRequest; // byte array
            }


            // make the HTTP authenticationRequest
            IRestResponse localVarResponse = (IRestResponse)this.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoginPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthenticationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthenticationResponse)this.ApiClient.Deserialize(localVarResponse, typeof(AuthenticationResponse)));
            
        }

        /// <summary>
        /// Authenticates the caller using Basic authentication. Call this endpoint to authenticate the user 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationRequest">Details about the user to authenticate.</param>
        /// <returns>Task of AuthenticationResponse</returns>
        public async System.Threading.Tasks.Task<AuthenticationResponse> LoginPostAsync (AuthenticationRequest authenticationRequest)
        {
             ApiResponse<AuthenticationResponse> localVarResponse = await LoginPostAsyncWithHttpInfo(authenticationRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Authenticates the caller using Basic authentication. Call this endpoint to authenticate the user 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationRequest">Details about the user to authenticate.</param>
        /// <returns>Task of ApiResponse (AuthenticationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthenticationResponse>> LoginPostAsyncWithHttpInfo (AuthenticationRequest authenticationRequest)
        {
            // verify the required parameter 'authenticationRequest' is set
            if (authenticationRequest == null)
                throw new ApiException(400, "Missing required parameter 'authenticationRequest' when calling AuthenticationApi->LoginPost");

            const string localVarPath = "/login";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (authenticationRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.ApiClient.Serialize(authenticationRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authenticationRequest; // byte array
            }


            // make the HTTP authenticationRequest
            IRestResponse localVarResponse = (IRestResponse) await this.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoginPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthenticationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthenticationResponse) this.ApiClient.Deserialize(localVarResponse, typeof(AuthenticationResponse)));
            
        }

    }
}
