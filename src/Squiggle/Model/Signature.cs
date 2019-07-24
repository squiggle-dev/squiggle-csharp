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
    /// Signature
    /// </summary>
    [DataContract]
    public partial class Signature :  IEquatable<Signature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Signature" /> class.
        /// </summary>
        /// <param name="Errors">Errors.</param>
        public Signature(Dictionary<string, string> Errors = null)
        {
            this.Errors = Errors;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; private set; }
        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name="preview", EmitDefaultValue=false)]
        public string Preview { get; private set; }
        /// <summary>
        /// Gets or Sets Plain
        /// </summary>
        [DataMember(Name="plain", EmitDefaultValue=false)]
        public string Plain { get; private set; }
        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name="html", EmitDefaultValue=false)]
        public string Html { get; private set; }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public int? Address { get; private set; }
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public int? Template { get; private set; }
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public Dictionary<string, string> Errors { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signature {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  Plain: ").Append(Plain).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as Signature);
        }

        /// <summary>
        /// Returns true if Signature instances are equal
        /// </summary>
        /// <param name="other">Instance of Signature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signature other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Preview == other.Preview ||
                    this.Preview != null &&
                    this.Preview.Equals(other.Preview)
                ) && 
                (
                    this.Plain == other.Plain ||
                    this.Plain != null &&
                    this.Plain.Equals(other.Plain)
                ) && 
                (
                    this.Html == other.Html ||
                    this.Html != null &&
                    this.Html.Equals(other.Html)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Preview != null)
                    hash = hash * 59 + this.Preview.GetHashCode();
                if (this.Plain != null)
                    hash = hash * 59 + this.Plain.GetHashCode();
                if (this.Html != null)
                    hash = hash * 59 + this.Html.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
