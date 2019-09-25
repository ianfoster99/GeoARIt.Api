using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHotspotApi
    {
        /// <summary>
        /// Retrieve hotspot details Try &lt;b&gt;591f69f2-6e35-4270-b3b8-83afe3caf01f&lt;/b&gt; or &lt;b&gt;a765b753-a297-4671-9bfd-9f7a6fd7a080&lt;/b&gt; or &lt;b&gt;83ccd14b-d00e-4e43-a509-3b7c2e64c69b&lt;/b&gt;
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="authorization"></param>
        /// <returns>Hotspot</returns>
        Hotspot Get (Guid? guid, string authorization);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HotspotApi : IHotspotApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HotspotApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HotspotApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HotspotApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HotspotApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Retrieve hotspot details Try &lt;b&gt;591f69f2-6e35-4270-b3b8-83afe3caf01f&lt;/b&gt; or &lt;b&gt;a765b753-a297-4671-9bfd-9f7a6fd7a080&lt;/b&gt; or &lt;b&gt;83ccd14b-d00e-4e43-a509-3b7c2e64c69b&lt;/b&gt;
        /// </summary>
        /// <param name="guid"></param> 
        /// <param name="authorization"></param> 
        /// <returns>Hotspot</returns>            
        public Hotspot Get (Guid? guid, string authorization)
        {
            
            // verify the required parameter 'guid' is set
            if (guid == null) throw new ApiException(400, "Missing required parameter 'guid' when calling Get");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling Get");
            
    
            var path = "/api/hotspot/{guid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "guid" + "}", ApiClient.ParameterToString(guid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Hotspot) ApiClient.Deserialize(response.Content, typeof(Hotspot), response.Headers);
        }
    
    }
}
