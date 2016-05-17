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
  public class Signature {
    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    
    /// <summary>
    /// Gets or Sets Label
    /// </summary>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    
    /// <summary>
    /// Gets or Sets Template
    /// </summary>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public int? Template { get; set; }

    
    /// <summary>
    /// Gets or Sets Plain
    /// </summary>
    [DataMember(Name="plain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plain")]
    public string Plain { get; set; }

    
    /// <summary>
    /// Gets or Sets Html
    /// </summary>
    [DataMember(Name="html", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html")]
    public string Html { get; set; }

    
    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [DataMember(Name="errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errors")]
    public Dictionary<String, string> Errors { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Signature {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Label: ").Append(Label).Append("\n");
      
      sb.Append("  Template: ").Append(Template).Append("\n");
      
      sb.Append("  Plain: ").Append(Plain).Append("\n");
      
      sb.Append("  Html: ").Append(Html).Append("\n");
      
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      
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
