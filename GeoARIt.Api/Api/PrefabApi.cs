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
    public interface IPrefabApi
    {
        /// <summary>
        /// Retrieve details of prefab (3D model) Try &lt;b&gt;2bb0afd1-260c-45b2-b5e2-f051dd762a0e&lt;/b&gt; or &lt;b&gt;de4d60f1-6277-4d88-a26d-7dac597ba9bf&lt;/b&gt; or &lt;b&gt;f774ffe5-0640-4cd9-9938-7fe825226931&lt;/b&gt;
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="authorization"></param>
        /// <returns>Prefab</returns>
        Prefab Prefab (Guid? guid, string authorization);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PrefabApi : IPrefabApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrefabApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PrefabApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PrefabApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PrefabApi(String basePath)
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
        /// Retrieve details of prefab (3D model) Try &lt;b&gt;2bb0afd1-260c-45b2-b5e2-f051dd762a0e&lt;/b&gt; or &lt;b&gt;de4d60f1-6277-4d88-a26d-7dac597ba9bf&lt;/b&gt; or &lt;b&gt;f774ffe5-0640-4cd9-9938-7fe825226931&lt;/b&gt;
        /// </summary>
        /// <param name="guid"></param> 
        /// <param name="authorization"></param> 
        /// <returns>Prefab</returns>            
        public Prefab Prefab (Guid? guid, string authorization = null)
        {
            
            // verify the required parameter 'guid' is set
            if (guid == null) throw new ApiException(400, "Missing required parameter 'guid' when calling Prefab");            
    
            var path = "/api/prefab/{guid}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Prefab: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Prefab: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Prefab) ApiClient.Deserialize(response.Content, typeof(Prefab), response.Headers);
        }
    
    }
}
