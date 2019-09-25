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
    public interface IVenuesNearbyICalApi
    {
        /// <summary>
        /// List of venues within a given radius in ICalendar format  Radius to search (in meters) has max of 10000. Return format is iCalendar
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <param name="maxToLoad"></param>
        /// <param name="radiusMeters"></param>
        /// <param name="authorization"></param>
        /// <returns>List&lt;Venue&gt;</returns>
        List<Venue> VenuesICalendar (double? lat, double? lng, int? maxToLoad, int? radiusMeters, string authorization);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VenuesNearbyICalApi : IVenuesNearbyICalApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenuesNearbyICalApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VenuesNearbyICalApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VenuesNearbyICalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VenuesNearbyICalApi(String basePath)
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
        /// List of venues within a given radius in ICalendar format  Radius to search (in meters) has max of 10000. Return format is iCalendar
        /// </summary>
        /// <param name="lat"></param> 
        /// <param name="lng"></param> 
        /// <param name="maxToLoad"></param> 
        /// <param name="radiusMeters"></param> 
        /// <param name="authorization"></param> 
        /// <returns>List&lt;Venue&gt;</returns>            
        public List<Venue> VenuesICalendar (double? lat, double? lng, int? maxToLoad, int? radiusMeters, string authorization = null)
        {
            
            // verify the required parameter 'lat' is set
            if (lat == null) throw new ApiException(400, "Missing required parameter 'lat' when calling VenuesICalendar");
            
            // verify the required parameter 'lng' is set
            if (lng == null) throw new ApiException(400, "Missing required parameter 'lng' when calling VenuesICalendar");
            
            // verify the required parameter 'maxToLoad' is set
            if (maxToLoad == null) throw new ApiException(400, "Missing required parameter 'maxToLoad' when calling VenuesICalendar");
            
            // verify the required parameter 'radiusMeters' is set
            if (radiusMeters == null) throw new ApiException(400, "Missing required parameter 'radiusMeters' when calling VenuesICalendar");

            var path = "/api/venue/nearby/{lat}/{lng}/{maxToLoad}/{radiusMeters}/icalendar";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "lat" + "}", ApiClient.ParameterToString(lat));
path = path.Replace("{" + "lng" + "}", ApiClient.ParameterToString(lng));
path = path.Replace("{" + "maxToLoad" + "}", ApiClient.ParameterToString(maxToLoad));
path = path.Replace("{" + "radiusMeters" + "}", ApiClient.ParameterToString(radiusMeters));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling VenuesICalendar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VenuesICalendar: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Venue>) ApiClient.Deserialize(response.Content, typeof(List<Venue>), response.Headers);
        }
    
    }
}
