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
    public interface IHotspotsForVenueApi
    {
        /// <summary>
        /// Retrieve hotspots for the specified venue Hotspots for the specified venue will be returned (prefab class will be auto populated). Try &lt;b&gt;11111111-1111-1111-1111-05ecb3f6ea4c&lt;/b&gt;
        /// </summary>
        /// <param name="venueGuid"></param>
        /// <param name="maxToLoad"></param>
        /// <param name="authorization"></param>
        /// <returns>List&lt;Hotspot&gt;</returns>
        List<Hotspot> HotspotsForVenue (Guid? venueGuid, int? maxToLoad, string authorization);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HotspotsForVenueApi : IHotspotsForVenueApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HotspotsForVenueApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HotspotsForVenueApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HotspotsForVenueApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HotspotsForVenueApi(String basePath)
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
        /// Retrieve hotspots for the specified venue Hotspots for the specified venue will be returned (prefab class will be auto populated). Try &lt;b&gt;11111111-1111-1111-1111-05ecb3f6ea4c&lt;/b&gt;
        /// </summary>
        /// <param name="venueGuid"></param> 
        /// <param name="maxToLoad"></param> 
        /// <param name="authorization"></param> 
        /// <returns>List&lt;Hotspot&gt;</returns>            
        public List<Hotspot> HotspotsForVenue (Guid? venueGuid, int? maxToLoad, string authorization = null)
        {
            
            // verify the required parameter 'venueGuid' is set
            if (venueGuid == null) throw new ApiException(400, "Missing required parameter 'venueGuid' when calling HotspotsForVenue");
            
            // verify the required parameter 'maxToLoad' is set
            if (maxToLoad == null) throw new ApiException(400, "Missing required parameter 'maxToLoad' when calling HotspotsForVenue");
    
            var path = "/api/venue/{venueGuid}/hotspots/{maxToLoad}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "venueGuid" + "}", ApiClient.ParameterToString(venueGuid));
            path = path.Replace("{" + "maxToLoad" + "}", ApiClient.ParameterToString(maxToLoad));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotspotsForVenue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotspotsForVenue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Hotspot>) ApiClient.Deserialize(response.Content, typeof(List<Hotspot>), response.Headers);
        }
    
    }
}
