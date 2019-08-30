/* 
 * Squiggle API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Squiggle.Model
{
    /// <summary>
    /// RenderOptions
    /// </summary>
    [DataContract]
    public partial class RenderOptions :  IEquatable<RenderOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderOptions" /> class.
        /// </summary>
        /// <param name="AddressId">AddressId.</param>
        /// <param name="TemplateId">TemplateId.</param>
        /// <param name="GlobalTemplateId">GlobalTemplateId.</param>
        /// <param name="Template">Template.</param>
        /// <param name="Context">Context.</param>
        public RenderOptions(int? AddressId = null, int? TemplateId = null, int? GlobalTemplateId = null, string Template = null, AddressTemplate Context = null)
        {
            this.AddressId = AddressId;
            this.TemplateId = TemplateId;
            this.GlobalTemplateId = GlobalTemplateId;
            this.Template = Template;
            this.Context = Context;
        }
        
        /// <summary>
        /// Gets or Sets AddressId
        /// </summary>
        [DataMember(Name="address_id", EmitDefaultValue=false)]
        public int? AddressId { get; set; }
        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="template_id", EmitDefaultValue=false)]
        public int? TemplateId { get; set; }
        /// <summary>
        /// Gets or Sets GlobalTemplateId
        /// </summary>
        [DataMember(Name="global_template_id", EmitDefaultValue=false)]
        public int? GlobalTemplateId { get; set; }
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }
        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public AddressTemplate Context { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenderOptions {\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  GlobalTemplateId: ").Append(GlobalTemplateId).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RenderOptions);
        }

        /// <summary>
        /// Returns true if RenderOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of RenderOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenderOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressId == other.AddressId ||
                    this.AddressId != null &&
                    this.AddressId.Equals(other.AddressId)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.GlobalTemplateId == other.GlobalTemplateId ||
                    this.GlobalTemplateId != null &&
                    this.GlobalTemplateId.Equals(other.GlobalTemplateId)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AddressId != null)
                    hash = hash * 59 + this.AddressId.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.GlobalTemplateId != null)
                    hash = hash * 59 + this.GlobalTemplateId.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}