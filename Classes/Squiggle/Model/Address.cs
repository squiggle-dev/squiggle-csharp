using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Squiggle.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Address :  IEquatable<Address>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        public Address()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name="job_title", EmitDefaultValue=false)]
        public string JobTitle { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TelMobile
        /// </summary>
        [DataMember(Name="tel_mobile", EmitDefaultValue=false)]
        public string TelMobile { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TelDirect
        /// </summary>
        [DataMember(Name="tel_direct", EmitDefaultValue=false)]
        public string TelDirect { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Linkedin
        /// </summary>
        [DataMember(Name="linkedin", EmitDefaultValue=false)]
        public string Linkedin { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Facebook
        /// </summary>
        [DataMember(Name="facebook", EmitDefaultValue=false)]
        public string Facebook { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Twitter
        /// </summary>
        [DataMember(Name="twitter", EmitDefaultValue=false)]
        public string Twitter { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Instagram
        /// </summary>
        [DataMember(Name="instagram", EmitDefaultValue=false)]
        public string Instagram { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Googleplus
        /// </summary>
        [DataMember(Name="googleplus", EmitDefaultValue=false)]
        public string Googleplus { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Signatures
        /// </summary>
        [DataMember(Name="signatures", EmitDefaultValue=false)]
        public List<Signature> Signatures { get; set; }
  
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
            return this.Equals(obj as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="other">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
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
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.JobTitle == other.JobTitle ||
                    this.JobTitle != null &&
                    this.JobTitle.Equals(other.JobTitle)
                ) && 
                (
                    this.TelMobile == other.TelMobile ||
                    this.TelMobile != null &&
                    this.TelMobile.Equals(other.TelMobile)
                ) && 
                (
                    this.TelDirect == other.TelDirect ||
                    this.TelDirect != null &&
                    this.TelDirect.Equals(other.TelDirect)
                ) && 
                (
                    this.Linkedin == other.Linkedin ||
                    this.Linkedin != null &&
                    this.Linkedin.Equals(other.Linkedin)
                ) && 
                (
                    this.Facebook == other.Facebook ||
                    this.Facebook != null &&
                    this.Facebook.Equals(other.Facebook)
                ) && 
                (
                    this.Twitter == other.Twitter ||
                    this.Twitter != null &&
                    this.Twitter.Equals(other.Twitter)
                ) && 
                (
                    this.Instagram == other.Instagram ||
                    this.Instagram != null &&
                    this.Instagram.Equals(other.Instagram)
                ) && 
                (
                    this.Googleplus == other.Googleplus ||
                    this.Googleplus != null &&
                    this.Googleplus.Equals(other.Googleplus)
                ) && 
                (
                    this.Signatures == other.Signatures ||
                    this.Signatures != null &&
                    this.Signatures.SequenceEqual(other.Signatures)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.JobTitle != null)
                    hash = hash * 59 + this.JobTitle.GetHashCode();
                
                if (this.TelMobile != null)
                    hash = hash * 59 + this.TelMobile.GetHashCode();
                
                if (this.TelDirect != null)
                    hash = hash * 59 + this.TelDirect.GetHashCode();
                
                if (this.Linkedin != null)
                    hash = hash * 59 + this.Linkedin.GetHashCode();
                
                if (this.Facebook != null)
                    hash = hash * 59 + this.Facebook.GetHashCode();
                
                if (this.Twitter != null)
                    hash = hash * 59 + this.Twitter.GetHashCode();
                
                if (this.Instagram != null)
                    hash = hash * 59 + this.Instagram.GetHashCode();
                
                if (this.Googleplus != null)
                    hash = hash * 59 + this.Googleplus.GetHashCode();
                
                if (this.Signatures != null)
                    hash = hash * 59 + this.Signatures.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                return hash;
            }
        }

    }
}
