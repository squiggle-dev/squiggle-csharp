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
  public class User {
    
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
    /// Gets or Sets CompanyName
    /// </summary>
    [DataMember(Name="company_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company_name")]
    public string CompanyName { get; set; }

    
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
    /// Gets or Sets Domain
    /// </summary>
    [DataMember(Name="domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domain")]
    public string Domain { get; set; }

    
    /// <summary>
    /// Gets or Sets Address1
    /// </summary>
    [DataMember(Name="address1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address1")]
    public string Address1 { get; set; }

    
    /// <summary>
    /// Gets or Sets Address2
    /// </summary>
    [DataMember(Name="address2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address2")]
    public string Address2 { get; set; }

    
    /// <summary>
    /// Gets or Sets Address3
    /// </summary>
    [DataMember(Name="address3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address3")]
    public string Address3 { get; set; }

    
    /// <summary>
    /// Gets or Sets AddressCity
    /// </summary>
    [DataMember(Name="address_city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_city")]
    public string AddressCity { get; set; }

    
    /// <summary>
    /// Gets or Sets AddressPostcode
    /// </summary>
    [DataMember(Name="address_postcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_postcode")]
    public string AddressPostcode { get; set; }

    
    /// <summary>
    /// Gets or Sets AddressCountry
    /// </summary>
    [DataMember(Name="address_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_country")]
    public string AddressCountry { get; set; }

    
    /// <summary>
    /// Gets or Sets Website
    /// </summary>
    [DataMember(Name="website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "website")]
    public string Website { get; set; }

    
    /// <summary>
    /// Gets or Sets Tel
    /// </summary>
    [DataMember(Name="tel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tel")]
    public string Tel { get; set; }

    
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
    /// Gets or Sets Logo
    /// </summary>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo")]
    public int? Logo { get; set; }

    
    /// <summary>
    /// Gets or Sets Snippet
    /// </summary>
    [DataMember(Name="snippet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "snippet")]
    public int? Snippet { get; set; }

    
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
      sb.Append("class User {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Email: ").Append(Email).Append("\n");
      
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      
      sb.Append("  Address3: ").Append(Address3).Append("\n");
      
      sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
      
      sb.Append("  AddressPostcode: ").Append(AddressPostcode).Append("\n");
      
      sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
      
      sb.Append("  Website: ").Append(Website).Append("\n");
      
      sb.Append("  Tel: ").Append(Tel).Append("\n");
      
      sb.Append("  Linkedin: ").Append(Linkedin).Append("\n");
      
      sb.Append("  Facebook: ").Append(Facebook).Append("\n");
      
      sb.Append("  Twitter: ").Append(Twitter).Append("\n");
      
      sb.Append("  Instagram: ").Append(Instagram).Append("\n");
      
      sb.Append("  Googleplus: ").Append(Googleplus).Append("\n");
      
      sb.Append("  Logo: ").Append(Logo).Append("\n");
      
      sb.Append("  Snippet: ").Append(Snippet).Append("\n");
      
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
