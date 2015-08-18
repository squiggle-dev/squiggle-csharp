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
  public class Template {
    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    public string Description { get; set; }

    
    /// <summary>
    /// Gets or Sets Thumbnail
    /// </summary>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    public string Thumbnail { get; set; }

    
    /// <summary>
    /// Gets or Sets ContentHtml
    /// </summary>
    [DataMember(Name="content_html", EmitDefaultValue=false)]
    public string ContentHtml { get; set; }

    
    /// <summary>
    /// Gets or Sets ContentPlaintext
    /// </summary>
    [DataMember(Name="content_plaintext", EmitDefaultValue=false)]
    public string ContentPlaintext { get; set; }

    
    /// <summary>
    /// Gets or Sets ContentRichtext
    /// </summary>
    [DataMember(Name="content_richtext", EmitDefaultValue=false)]
    public string ContentRichtext { get; set; }

    
    /// <summary>
    /// Gets or Sets Settings
    /// </summary>
    [DataMember(Name="settings", EmitDefaultValue=false)]
    public string Settings { get; set; }

    
    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    public int? User { get; set; }

    
    /// <summary>
    /// Gets or Sets Template
    /// </summary>
    [DataMember(Name="template", EmitDefaultValue=false)]
    public int? Template { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Template {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
      
      sb.Append("  ContentHtml: ").Append(ContentHtml).Append("\n");
      
      sb.Append("  ContentPlaintext: ").Append(ContentPlaintext).Append("\n");
      
      sb.Append("  ContentRichtext: ").Append(ContentRichtext).Append("\n");
      
      sb.Append("  Settings: ").Append(Settings).Append("\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
      sb.Append("  Template: ").Append(Template).Append("\n");
      
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
