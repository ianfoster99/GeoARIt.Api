using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GeoARIt.Api.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
  public class Venue {
    /// <summary>
    /// Gets or Sets Hotspots
    /// </summary>
    [DataMember(Name="hotspots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotspots")]
    public List<Hotspot> Hotspots { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Guid
    /// </summary>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public Guid? Guid { get; set; }

    /// <summary>
    /// Gets or Sets OwnerId
    /// </summary>
    [DataMember(Name="ownerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string OwnerId { get; set; }

    /// <summary>
    /// Gets or Sets Demo
    /// </summary>
    [DataMember(Name="demo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "demo")]
    public bool? Demo { get; set; }

    /// <summary>
    /// Gets or Sets CaptureStatistics
    /// </summary>
    [DataMember(Name="captureStatistics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "captureStatistics")]
    public bool? CaptureStatistics { get; set; }

    /// <summary>
    /// Gets or Sets CountryId
    /// </summary>
    [DataMember(Name="countryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryId")]
    public int? CountryId { get; set; }

    /// <summary>
    /// Gets or Sets VenueTypeId
    /// </summary>
    [DataMember(Name="venueTypeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "venueTypeId")]
    public int? VenueTypeId { get; set; }

    /// <summary>
    /// Gets or Sets LogoUrl
    /// </summary>
    [DataMember(Name="logoUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logoUrl")]
    public string LogoUrl { get; set; }

    /// <summary>
    /// Gets or Sets WebsiteUrl
    /// </summary>
    [DataMember(Name="websiteUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "websiteUrl")]
    public string WebsiteUrl { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets Postcode
    /// </summary>
    [DataMember(Name="postcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postcode")]
    public string Postcode { get; set; }

    /// <summary>
    /// Gets or Sets Latitude
    /// </summary>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public float? Latitude { get; set; }

    /// <summary>
    /// Gets or Sets Longitude
    /// </summary>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public float? Longitude { get; set; }

    /// <summary>
    /// Gets or Sets EnabledFrom
    /// </summary>
    [DataMember(Name="enabledFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabledFrom")]
    public DateTime? EnabledFrom { get; set; }

    /// <summary>
    /// Gets or Sets EnabledTo
    /// </summary>
    [DataMember(Name="enabledTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabledTo")]
    public DateTime? EnabledTo { get; set; }

    /// <summary>
    /// Gets or Sets HashTag
    /// </summary>
    [DataMember(Name="hashTag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hashTag")]
    public string HashTag { get; set; }

    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets Updated
    /// </summary>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated")]
    public DateTime? Updated { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedBy
    /// </summary>
    [DataMember(Name="updatedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedBy")]
    public string UpdatedBy { get; set; }

    /// <summary>
    /// Gets or Sets ReportingInterval
    /// </summary>
    [DataMember(Name="reportingInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportingInterval")]
    public string ReportingInterval { get; set; }

    /// <summary>
    /// Gets or Sets IsEnabled
    /// </summary>
    [DataMember(Name="isEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets IsEnabledText
    /// </summary>
    [DataMember(Name="isEnabledText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEnabledText")]
    public string IsEnabledText { get; set; }

    /// <summary>
    /// Gets or Sets TextClass
    /// </summary>
    [DataMember(Name="textClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "textClass")]
    public string TextClass { get; set; }

    /// <summary>
    /// Gets or Sets IsEnabledSummary
    /// </summary>
    [DataMember(Name="isEnabledSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEnabledSummary")]
    public string IsEnabledSummary { get; set; }

    /// <summary>
    /// Gets or Sets HotspotCount
    /// </summary>
    [DataMember(Name="hotspotCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotspotCount")]
    public int? HotspotCount { get; set; }

    /// <summary>
    /// Gets or Sets Route
    /// </summary>
    [DataMember(Name="route", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "route")]
    public string Route { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Venue {\n");
      sb.Append("  Hotspots: ").Append(Hotspots).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  Demo: ").Append(Demo).Append("\n");
      sb.Append("  CaptureStatistics: ").Append(CaptureStatistics).Append("\n");
      sb.Append("  CountryId: ").Append(CountryId).Append("\n");
      sb.Append("  VenueTypeId: ").Append(VenueTypeId).Append("\n");
      sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
      sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Postcode: ").Append(Postcode).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      sb.Append("  EnabledFrom: ").Append(EnabledFrom).Append("\n");
      sb.Append("  EnabledTo: ").Append(EnabledTo).Append("\n");
      sb.Append("  HashTag: ").Append(HashTag).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  Updated: ").Append(Updated).Append("\n");
      sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
      sb.Append("  ReportingInterval: ").Append(ReportingInterval).Append("\n");
      sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
      sb.Append("  IsEnabledText: ").Append(IsEnabledText).Append("\n");
      sb.Append("  TextClass: ").Append(TextClass).Append("\n");
      sb.Append("  IsEnabledSummary: ").Append(IsEnabledSummary).Append("\n");
      sb.Append("  HotspotCount: ").Append(HotspotCount).Append("\n");
      sb.Append("  Route: ").Append(Route).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
