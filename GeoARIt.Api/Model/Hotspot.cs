using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace GeoARIt.Api.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
  public class Hotspot {
    /// <summary>
    /// Gets or Sets Prefab
    /// </summary>
    [DataMember(Name="prefab", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefab")]
    public Prefab Prefab { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

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
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Route
    /// </summary>
    [DataMember(Name="route", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "route")]
    public string Route { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets TextClass
    /// </summary>
    [DataMember(Name="textClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "textClass")]
    public string TextClass { get; set; }

    /// <summary>
    /// Gets or Sets IsEnabledText
    /// </summary>
    [DataMember(Name="isEnabledText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEnabledText")]
    public string IsEnabledText { get; set; }

    /// <summary>
    /// Gets or Sets IsEnabledSummary
    /// </summary>
    [DataMember(Name="isEnabledSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEnabledSummary")]
    public string IsEnabledSummary { get; set; }

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
    /// Gets or Sets IsEnabled
    /// </summary>
    [DataMember(Name="isEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets VenueId
    /// </summary>
    [DataMember(Name="venueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "venueId")]
    public int? VenueId { get; set; }

    /// <summary>
    /// Gets or Sets VenueGuid
    /// </summary>
    [DataMember(Name="venueGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "venueGuid")]
    public Guid? VenueGuid { get; set; }

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
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Gets or Sets PrefabId
    /// </summary>
    [DataMember(Name="prefabId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefabId")]
    public int? PrefabId { get; set; }

    /// <summary>
    /// Gets or Sets PrefabGuid
    /// </summary>
    [DataMember(Name="prefabGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefabGuid")]
    public Guid? PrefabGuid { get; set; }

    /// <summary>
    /// Gets or Sets RefreshMinutes
    /// </summary>
    [DataMember(Name="refreshMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refreshMinutes")]
    public float? RefreshMinutes { get; set; }

    /// <summary>
    /// Gets or Sets Altitude
    /// </summary>
    [DataMember(Name="altitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "altitude")]
    public double? Altitude { get; set; }

    /// <summary>
    /// Gets or Sets FaceTowardsDegrees
    /// </summary>
    [DataMember(Name="faceTowardsDegrees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faceTowardsDegrees")]
    public int? FaceTowardsDegrees { get; set; }

    /// <summary>
    /// Gets or Sets RotateXDegreesPerSecond
    /// </summary>
    [DataMember(Name="rotateXDegreesPerSecond", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rotateXDegreesPerSecond")]
    public int? RotateXDegreesPerSecond { get; set; }

    /// <summary>
    /// Gets or Sets RotateZDegreesPerSecond
    /// </summary>
    [DataMember(Name="rotateZDegreesPerSecond", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rotateZDegreesPerSecond")]
    public int? RotateZDegreesPerSecond { get; set; }

    /// <summary>
    /// Gets or Sets RotateYDegreesPerSecond
    /// </summary>
    [DataMember(Name="rotateYDegreesPerSecond", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rotateYDegreesPerSecond")]
    public int? RotateYDegreesPerSecond { get; set; }

    /// <summary>
    /// Gets or Sets WidthX
    /// </summary>
    [DataMember(Name="widthX", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widthX")]
    public double? WidthX { get; set; }

    /// <summary>
    /// Gets or Sets HeightY
    /// </summary>
    [DataMember(Name="heightY", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "heightY")]
    public double? HeightY { get; set; }

    /// <summary>
    /// Gets or Sets DepthZ
    /// </summary>
    [DataMember(Name="depthZ", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "depthZ")]
    public double? DepthZ { get; set; }

    /// <summary>
    /// Gets or Sets HaloColour
    /// </summary>
    [DataMember(Name="haloColour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "haloColour")]
    public string HaloColour { get; set; }

    /// <summary>
    /// Gets or Sets HaloSize
    /// </summary>
    [DataMember(Name="haloSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "haloSize")]
    public int? HaloSize { get; set; }

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
    /// Gets or Sets DistanceMeters
    /// </summary>
    [DataMember(Name="distanceMeters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distanceMeters")]
    public float? DistanceMeters { get; set; }

    /// <summary>
    /// Gets or Sets SortOrder
    /// </summary>
    [DataMember(Name="sortOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sortOrder")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// Gets or Sets UrlToModel
    /// </summary>
    [DataMember(Name="urlToModel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "urlToModel")]
    public string UrlToModel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Hotspot {\n");
      sb.Append("  Prefab: ").Append(Prefab).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Route: ").Append(Route).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  TextClass: ").Append(TextClass).Append("\n");
      sb.Append("  IsEnabledText: ").Append(IsEnabledText).Append("\n");
      sb.Append("  IsEnabledSummary: ").Append(IsEnabledSummary).Append("\n");
      sb.Append("  EnabledFrom: ").Append(EnabledFrom).Append("\n");
      sb.Append("  EnabledTo: ").Append(EnabledTo).Append("\n");
      sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
      sb.Append("  VenueId: ").Append(VenueId).Append("\n");
      sb.Append("  VenueGuid: ").Append(VenueGuid).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  PrefabId: ").Append(PrefabId).Append("\n");
      sb.Append("  PrefabGuid: ").Append(PrefabGuid).Append("\n");
      sb.Append("  RefreshMinutes: ").Append(RefreshMinutes).Append("\n");
      sb.Append("  Altitude: ").Append(Altitude).Append("\n");
      sb.Append("  FaceTowardsDegrees: ").Append(FaceTowardsDegrees).Append("\n");
      sb.Append("  RotateXDegreesPerSecond: ").Append(RotateXDegreesPerSecond).Append("\n");
      sb.Append("  RotateZDegreesPerSecond: ").Append(RotateZDegreesPerSecond).Append("\n");
      sb.Append("  RotateYDegreesPerSecond: ").Append(RotateYDegreesPerSecond).Append("\n");
      sb.Append("  WidthX: ").Append(WidthX).Append("\n");
      sb.Append("  HeightY: ").Append(HeightY).Append("\n");
      sb.Append("  DepthZ: ").Append(DepthZ).Append("\n");
      sb.Append("  HaloColour: ").Append(HaloColour).Append("\n");
      sb.Append("  HaloSize: ").Append(HaloSize).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  Updated: ").Append(Updated).Append("\n");
      sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
      sb.Append("  DistanceMeters: ").Append(DistanceMeters).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  UrlToModel: ").Append(UrlToModel).Append("\n");
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
