using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Squiggle.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Address {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets JobTitle
    /// </summary>
    [DataMember(Name="job_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_title")]
    public string JobTitle { get; set; }

    /// <summary>
    /// Gets or Sets TelMobile
    /// </summary>
    [DataMember(Name="tel_mobile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tel_mobile")]
    public string TelMobile { get; set; }

    /// <summary>
    /// Gets or Sets TelDirect
    /// </summary>
    [DataMember(Name="tel_direct", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tel_direct")]
    public string TelDirect { get; set; }

    /// <summary>
    /// Gets or Sets Linkedin
    /// </summary>
    [DataMember(Name="linkedin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkedin")]
    public string Linkedin { get; set; }

    /// <summary>
    /// Gets or Sets Facebook
    /// </summary>
    [DataMember(Name="facebook", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "facebook")]
    public string Facebook { get; set; }

    /// <summary>
    /// Gets or Sets Twitter
    /// </summary>
    [DataMember(Name="twitter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitter")]
    public string Twitter { get; set; }

    /// <summary>
    /// Gets or Sets Instagram
    /// </summary>
    [DataMember(Name="instagram", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instagram")]
    public string Instagram { get; set; }

    /// <summary>
    /// Gets or Sets Googleplus
    /// </summary>
    [DataMember(Name="googleplus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "googleplus")]
    public string Googleplus { get; set; }

    /// <summary>
    /// Gets or Sets Signatures
    /// </summary>
    [DataMember(Name="signatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signatures")]
    public List<Signature> Signatures { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public int? User { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Address {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
      sb.Append("  TelMobile: ").Append(TelMobile).Append("\n");
      sb.Append("  TelDirect: ").Append(TelDirect).Append("\n");
      sb.Append("  Linkedin: ").Append(Linkedin).Append("\n");
      sb.Append("  Facebook: ").Append(Facebook).Append("\n");
      sb.Append("  Twitter: ").Append(Twitter).Append("\n");
      sb.Append("  Instagram: ").Append(Instagram).Append("\n");
      sb.Append("  Googleplus: ").Append(Googleplus).Append("\n");
      sb.Append("  Signatures: ").Append(Signatures).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
