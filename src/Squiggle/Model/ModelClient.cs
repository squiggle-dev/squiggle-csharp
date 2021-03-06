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
    /// ModelClient
    /// </summary>
    [DataContract]
    public partial class ModelClient :  IEquatable<ModelClient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelClient" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">Version.</param>
        /// <param name="OsName">OsName.</param>
        /// <param name="PluginVersion">PluginVersion.</param>
        public ModelClient(string Name = null, string Version = null, string OsName = null, string PluginVersion = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.OsName = OsName;
            this.PluginVersion = PluginVersion;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// Gets or Sets OsName
        /// </summary>
        [DataMember(Name="os_name", EmitDefaultValue=false)]
        public string OsName { get; set; }
        /// <summary>
        /// Gets or Sets PluginVersion
        /// </summary>
        [DataMember(Name="plugin_version", EmitDefaultValue=false)]
        public string PluginVersion { get; set; }
        /// <summary>
        /// Gets or Sets LastCheckin
        /// </summary>
        [DataMember(Name="last_checkin", EmitDefaultValue=false)]
        public DateTime? LastCheckin { get; private set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelClient {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  OsName: ").Append(OsName).Append("\n");
            sb.Append("  PluginVersion: ").Append(PluginVersion).Append("\n");
            sb.Append("  LastCheckin: ").Append(LastCheckin).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(obj as ModelClient);
        }

        /// <summary>
        /// Returns true if ModelClient instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelClient other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.OsName == other.OsName ||
                    this.OsName != null &&
                    this.OsName.Equals(other.OsName)
                ) && 
                (
                    this.PluginVersion == other.PluginVersion ||
                    this.PluginVersion != null &&
                    this.PluginVersion.Equals(other.PluginVersion)
                ) && 
                (
                    this.LastCheckin == other.LastCheckin ||
                    this.LastCheckin != null &&
                    this.LastCheckin.Equals(other.LastCheckin)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.OsName != null)
                    hash = hash * 59 + this.OsName.GetHashCode();
                if (this.PluginVersion != null)
                    hash = hash * 59 + this.PluginVersion.GetHashCode();
                if (this.LastCheckin != null)
                    hash = hash * 59 + this.LastCheckin.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
