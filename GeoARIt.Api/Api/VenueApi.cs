using System;
using System.Collections.Generic;
using RestSharp;
using GeoARIt.Api.Client;
using GeoARIt.Api.Model;

namespace GeoARIt.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVenueApi
    {
        /// <summary>
        /// Retrieve venue details Try &lt;b&gt;11111111-1111-1111-1111-05ecb3f6ea4c&lt;/b&gt; or &lt;b&gt;22222222-2222-2222-2222-f5d1563277e5&lt;/b&gt; or &lt;b&gt;33333333-3333-3333-3333-05ecb3f6ea4a&lt;/b&gt;
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="authorization"></param>
        /// <returns>Venue</returns>
        Venue Venue (Guid? guid, string authorization);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VenueApi : IVenueApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenueApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VenueApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VenueApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VenueApi(String basePath)
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
        /// Retrieve venue details Try &lt;b&gt;11111111-1111-1111-1111-05ecb3f6ea4c&lt;/b&gt; or &lt;b&gt;22222222-2222-2222-2222-f5d1563277e5&lt;/b&gt; or &lt;b&gt;33333333-3333-3333-3333-05ecb3f6ea4a&lt;/b&gt;
        /// </summary>
        /// <param name="guid"></param> 
        /// <param name="authorization"></param> 
        /// <returns>Venue</returns>            
        public Venue Venue (Guid? guid, string authorization = null)
        {
            
            // verify the required parameter 'guid' is set
            if (guid == null) throw new ApiException(400, "Missing required parameter 'guid' when calling Venue");
                
            var path = "/api/venue/{guid}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Venue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Venue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Venue) ApiClient.Deserialize(response.Content, typeof(Venue), response.Headers);
        }
    
    }
}
