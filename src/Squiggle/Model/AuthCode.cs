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
    /// AuthCode
    /// </summary>
    [DataContract]
    public partial class AuthCode :  IEquatable<AuthCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AuthCode()
        {
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; private set; }
        /// <summary>
        /// Gets or Sets CodeExpiry
        /// </summary>
        [DataMember(Name="code_expiry", EmitDefaultValue=false)]
        public DateTime? CodeExpiry { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthCode {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CodeExpiry: ").Append(CodeExpiry).Append("\n");
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
            return this.Equals(obj as AuthCode);
        }

        /// <summary>
        /// Returns true if AuthCode instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthCode other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.CodeExpiry == other.CodeExpiry ||
                    this.CodeExpiry != null &&
                    this.CodeExpiry.Equals(other.CodeExpiry)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.CodeExpiry != null)
                    hash = hash * 59 + this.CodeExpiry.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
