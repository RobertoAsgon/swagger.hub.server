/*
 * myLIMS API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BaseAccount : IEquatable<BaseAccount>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Identification
        /// </summary>

        [DataMember(Name="Identification")]
        public string Identification { get; set; }

        /// <summary>
        /// Gets or Sets RegistryNumber
        /// </summary>

        [DataMember(Name="RegistryNumber")]
        public string RegistryNumber { get; set; }

        /// <summary>
        /// Gets or Sets EquivalencyId
        /// </summary>

        [DataMember(Name="EquivalencyId")]
        public int? EquivalencyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  RegistryNumber: ").Append(RegistryNumber).Append("\n");
            sb.Append("  EquivalencyId: ").Append(EquivalencyId).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((BaseAccount)obj);
        }

        /// <summary>
        /// Returns true if BaseAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseAccount other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Identification == other.Identification ||
                    Identification != null &&
                    Identification.Equals(other.Identification)
                ) && 
                (
                    RegistryNumber == other.RegistryNumber ||
                    RegistryNumber != null &&
                    RegistryNumber.Equals(other.RegistryNumber)
                ) && 
                (
                    EquivalencyId == other.EquivalencyId ||
                    EquivalencyId != null &&
                    EquivalencyId.Equals(other.EquivalencyId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Identification != null)
                    hashCode = hashCode * 59 + Identification.GetHashCode();
                    if (RegistryNumber != null)
                    hashCode = hashCode * 59 + RegistryNumber.GetHashCode();
                    if (EquivalencyId != null)
                    hashCode = hashCode * 59 + EquivalencyId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BaseAccount left, BaseAccount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BaseAccount left, BaseAccount right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
