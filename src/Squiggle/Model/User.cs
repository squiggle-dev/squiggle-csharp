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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="ShowBranding">ShowBranding.</param>
        /// <param name="WebhookUrl">WebhookUrl.</param>
        /// <param name="Email">Email.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Domain">Domain.</param>
        /// <param name="Address1">Address1.</param>
        /// <param name="Address2">Address2.</param>
        /// <param name="Address3">Address3.</param>
        /// <param name="AddressCity">AddressCity.</param>
        /// <param name="AddressPostcode">AddressPostcode.</param>
        /// <param name="AddressCountry">AddressCountry.</param>
        /// <param name="Website">Website.</param>
        /// <param name="Tel">Tel.</param>
        /// <param name="Linkedin">Linkedin.</param>
        /// <param name="Facebook">Facebook.</param>
        /// <param name="Twitter">Twitter.</param>
        /// <param name="Instagram">Instagram.</param>
        /// <param name="Googleplus">Googleplus.</param>
        /// <param name="AdditionalText">AdditionalText.</param>
        /// <param name="Logo">Logo.</param>
        /// <param name="Snippet">Snippet.</param>
        /// <param name="Template">Template.</param>
        /// <param name="SnippetEnabled">SnippetEnabled.</param>
        public User(string Status = null, bool? ShowBranding = null, string WebhookUrl = null, string Email = null, string CompanyName = null, string FirstName = null, string LastName = null, string Domain = null, string Address1 = null, string Address2 = null, string Address3 = null, string AddressCity = null, string AddressPostcode = null, string AddressCountry = null, string Website = null, string Tel = null, string Linkedin = null, string Facebook = null, string Twitter = null, string Instagram = null, string Googleplus = null, string AdditionalText = null, FileObject Logo = null, Snippet Snippet = null, int? Template = null, bool? SnippetEnabled = null)
        {
            this.Status = Status;
            this.ShowBranding = ShowBranding;
            this.WebhookUrl = WebhookUrl;
            this.Email = Email;
            this.CompanyName = CompanyName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Domain = Domain;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.Address3 = Address3;
            this.AddressCity = AddressCity;
            this.AddressPostcode = AddressPostcode;
            this.AddressCountry = AddressCountry;
            this.Website = Website;
            this.Tel = Tel;
            this.Linkedin = Linkedin;
            this.Facebook = Facebook;
            this.Twitter = Twitter;
            this.Instagram = Instagram;
            this.Googleplus = Googleplus;
            this.AdditionalText = AdditionalText;
            this.Logo = Logo;
            this.Snippet = Snippet;
            this.Template = Template;
            this.SnippetEnabled = SnippetEnabled;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets ShowBranding
        /// </summary>
        [DataMember(Name="show_branding", EmitDefaultValue=false)]
        public bool? ShowBranding { get; set; }
        /// <summary>
        /// Gets or Sets WebhookUrl
        /// </summary>
        [DataMember(Name="webhook_url", EmitDefaultValue=false)]
        public string WebhookUrl { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
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
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }
        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }
        /// <summary>
        /// Gets or Sets Address3
        /// </summary>
        [DataMember(Name="address3", EmitDefaultValue=false)]
        public string Address3 { get; set; }
        /// <summary>
        /// Gets or Sets AddressCity
        /// </summary>
        [DataMember(Name="address_city", EmitDefaultValue=false)]
        public string AddressCity { get; set; }
        /// <summary>
        /// Gets or Sets AddressPostcode
        /// </summary>
        [DataMember(Name="address_postcode", EmitDefaultValue=false)]
        public string AddressPostcode { get; set; }
        /// <summary>
        /// Gets or Sets AddressCountry
        /// </summary>
        [DataMember(Name="address_country", EmitDefaultValue=false)]
        public string AddressCountry { get; set; }
        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }
        /// <summary>
        /// Gets or Sets Tel
        /// </summary>
        [DataMember(Name="tel", EmitDefaultValue=false)]
        public string Tel { get; set; }
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
        /// Gets or Sets AdditionalText
        /// </summary>
        [DataMember(Name="additional_text", EmitDefaultValue=false)]
        public string AdditionalText { get; set; }
        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public FileObject Logo { get; set; }
        /// <summary>
        /// Gets or Sets Snippet
        /// </summary>
        [DataMember(Name="snippet", EmitDefaultValue=false)]
        public Snippet Snippet { get; set; }
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public int? Template { get; set; }
        /// <summary>
        /// Gets or Sets AddressCount
        /// </summary>
        [DataMember(Name="address_count", EmitDefaultValue=false)]
        public int? AddressCount { get; private set; }
        /// <summary>
        /// Gets or Sets SnippetEnabled
        /// </summary>
        [DataMember(Name="snippet_enabled", EmitDefaultValue=false)]
        public bool? SnippetEnabled { get; set; }
        /// <summary>
        /// Gets or Sets SecretKey
        /// </summary>
        [DataMember(Name="secret_key", EmitDefaultValue=false)]
        public string SecretKey { get; private set; }
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; private set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; private set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ShowBranding: ").Append(ShowBranding).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
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
            sb.Append("  AdditionalText: ").Append(AdditionalText).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Snippet: ").Append(Snippet).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  AddressCount: ").Append(AddressCount).Append("\n");
            sb.Append("  SnippetEnabled: ").Append(SnippetEnabled).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ShowBranding == other.ShowBranding ||
                    this.ShowBranding != null &&
                    this.ShowBranding.Equals(other.ShowBranding)
                ) && 
                (
                    this.WebhookUrl == other.WebhookUrl ||
                    this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(other.WebhookUrl)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
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
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.Address3 == other.Address3 ||
                    this.Address3 != null &&
                    this.Address3.Equals(other.Address3)
                ) && 
                (
                    this.AddressCity == other.AddressCity ||
                    this.AddressCity != null &&
                    this.AddressCity.Equals(other.AddressCity)
                ) && 
                (
                    this.AddressPostcode == other.AddressPostcode ||
                    this.AddressPostcode != null &&
                    this.AddressPostcode.Equals(other.AddressPostcode)
                ) && 
                (
                    this.AddressCountry == other.AddressCountry ||
                    this.AddressCountry != null &&
                    this.AddressCountry.Equals(other.AddressCountry)
                ) && 
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) && 
                (
                    this.Tel == other.Tel ||
                    this.Tel != null &&
                    this.Tel.Equals(other.Tel)
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
                    this.AdditionalText == other.AdditionalText ||
                    this.AdditionalText != null &&
                    this.AdditionalText.Equals(other.AdditionalText)
                ) && 
                (
                    this.Logo == other.Logo ||
                    this.Logo != null &&
                    this.Logo.Equals(other.Logo)
                ) && 
                (
                    this.Snippet == other.Snippet ||
                    this.Snippet != null &&
                    this.Snippet.Equals(other.Snippet)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.AddressCount == other.AddressCount ||
                    this.AddressCount != null &&
                    this.AddressCount.Equals(other.AddressCount)
                ) && 
                (
                    this.SnippetEnabled == other.SnippetEnabled ||
                    this.SnippetEnabled != null &&
                    this.SnippetEnabled.Equals(other.SnippetEnabled)
                ) && 
                (
                    this.SecretKey == other.SecretKey ||
                    this.SecretKey != null &&
                    this.SecretKey.Equals(other.SecretKey)
                ) && 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ShowBranding != null)
                    hash = hash * 59 + this.ShowBranding.GetHashCode();
                if (this.WebhookUrl != null)
                    hash = hash * 59 + this.WebhookUrl.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.Address3 != null)
                    hash = hash * 59 + this.Address3.GetHashCode();
                if (this.AddressCity != null)
                    hash = hash * 59 + this.AddressCity.GetHashCode();
                if (this.AddressPostcode != null)
                    hash = hash * 59 + this.AddressPostcode.GetHashCode();
                if (this.AddressCountry != null)
                    hash = hash * 59 + this.AddressCountry.GetHashCode();
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                if (this.Tel != null)
                    hash = hash * 59 + this.Tel.GetHashCode();
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
                if (this.AdditionalText != null)
                    hash = hash * 59 + this.AdditionalText.GetHashCode();
                if (this.Logo != null)
                    hash = hash * 59 + this.Logo.GetHashCode();
                if (this.Snippet != null)
                    hash = hash * 59 + this.Snippet.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.AddressCount != null)
                    hash = hash * 59 + this.AddressCount.GetHashCode();
                if (this.SnippetEnabled != null)
                    hash = hash * 59 + this.SnippetEnabled.GetHashCode();
                if (this.SecretKey != null)
                    hash = hash * 59 + this.SecretKey.GetHashCode();
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
