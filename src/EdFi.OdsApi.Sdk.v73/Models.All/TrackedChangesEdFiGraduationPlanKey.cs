// <auto-generated>
/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using EdFi.OdsApi.Sdk.v73.Client;

namespace EdFi.OdsApi.Sdk.v73.Models.All
{
    /// <summary>
    /// TrackedChangesEdFiGraduationPlanKey
    /// </summary>
    public partial class TrackedChangesEdFiGraduationPlanKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiGraduationPlanKey" /> class.
        /// </summary>
        /// <param name="graduationPlanTypeDescriptor">The type of academic plan the student is following for graduation.</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization.</param>
        /// <param name="graduationSchoolYear">The school year the student is expected to graduate.</param>
        [JsonConstructor]
        public TrackedChangesEdFiGraduationPlanKey(Option<string?> graduationPlanTypeDescriptor = default, Option<long?> educationOrganizationId = default, Option<int?> graduationSchoolYear = default)
        {
            GraduationPlanTypeDescriptorOption = graduationPlanTypeDescriptor;
            EducationOrganizationIdOption = educationOrganizationId;
            GraduationSchoolYearOption = graduationSchoolYear;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of GraduationPlanTypeDescriptor
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> GraduationPlanTypeDescriptorOption { get; private set; }

        /// <summary>
        /// The type of academic plan the student is following for graduation.
        /// </summary>
        /// <value>The type of academic plan the student is following for graduation.</value>
        [JsonPropertyName("graduationPlanTypeDescriptor")]
        public string? GraduationPlanTypeDescriptor { get { return this.GraduationPlanTypeDescriptorOption; } set { this.GraduationPlanTypeDescriptorOption = new(value); } }

        /// <summary>
        /// Used to track the state of EducationOrganizationId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> EducationOrganizationIdOption { get; private set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [JsonPropertyName("educationOrganizationId")]
        public long? EducationOrganizationId { get { return this.EducationOrganizationIdOption; } set { this.EducationOrganizationIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of GraduationSchoolYear
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> GraduationSchoolYearOption { get; private set; }

        /// <summary>
        /// The school year the student is expected to graduate.
        /// </summary>
        /// <value>The school year the student is expected to graduate.</value>
        [JsonPropertyName("graduationSchoolYear")]
        public int? GraduationSchoolYear { get { return this.GraduationSchoolYearOption; } set { this.GraduationSchoolYearOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiGraduationPlanKey {\n");
            sb.Append("  GraduationPlanTypeDescriptor: ").Append(GraduationPlanTypeDescriptor).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  GraduationSchoolYear: ").Append(GraduationSchoolYear).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // GraduationPlanTypeDescriptor (string) maxLength
            if (this.GraduationPlanTypeDescriptor != null && this.GraduationPlanTypeDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for GraduationPlanTypeDescriptor, length must be less than 306.", new [] { "GraduationPlanTypeDescriptor" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TrackedChangesEdFiGraduationPlanKey" />
    /// </summary>
    public class TrackedChangesEdFiGraduationPlanKeyJsonConverter : JsonConverter<TrackedChangesEdFiGraduationPlanKey>
    {
        /// <summary>
        /// Deserializes json to <see cref="TrackedChangesEdFiGraduationPlanKey" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TrackedChangesEdFiGraduationPlanKey Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> graduationPlanTypeDescriptor = default;
            Option<long?> educationOrganizationId = default;
            Option<int?> graduationSchoolYear = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "graduationPlanTypeDescriptor":
                            graduationPlanTypeDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "educationOrganizationId":
                            educationOrganizationId = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "graduationSchoolYear":
                            graduationSchoolYear = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (graduationPlanTypeDescriptor.IsSet && graduationPlanTypeDescriptor.Value == null)
                throw new ArgumentNullException(nameof(graduationPlanTypeDescriptor), "Property is not nullable for class TrackedChangesEdFiGraduationPlanKey.");

            if (educationOrganizationId.IsSet && educationOrganizationId.Value == null)
                throw new ArgumentNullException(nameof(educationOrganizationId), "Property is not nullable for class TrackedChangesEdFiGraduationPlanKey.");

            if (graduationSchoolYear.IsSet && graduationSchoolYear.Value == null)
                throw new ArgumentNullException(nameof(graduationSchoolYear), "Property is not nullable for class TrackedChangesEdFiGraduationPlanKey.");

            return new TrackedChangesEdFiGraduationPlanKey(graduationPlanTypeDescriptor, educationOrganizationId, graduationSchoolYear);
        }

        /// <summary>
        /// Serializes a <see cref="TrackedChangesEdFiGraduationPlanKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiGraduationPlanKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TrackedChangesEdFiGraduationPlanKey trackedChangesEdFiGraduationPlanKey, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trackedChangesEdFiGraduationPlanKey, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TrackedChangesEdFiGraduationPlanKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiGraduationPlanKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TrackedChangesEdFiGraduationPlanKey trackedChangesEdFiGraduationPlanKey, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trackedChangesEdFiGraduationPlanKey.GraduationPlanTypeDescriptorOption.IsSet && trackedChangesEdFiGraduationPlanKey.GraduationPlanTypeDescriptor == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiGraduationPlanKey.GraduationPlanTypeDescriptor), "Property is required for class TrackedChangesEdFiGraduationPlanKey.");

            if (trackedChangesEdFiGraduationPlanKey.GraduationPlanTypeDescriptorOption.IsSet)
                writer.WriteString("graduationPlanTypeDescriptor", trackedChangesEdFiGraduationPlanKey.GraduationPlanTypeDescriptor);

            if (trackedChangesEdFiGraduationPlanKey.EducationOrganizationIdOption.IsSet)
                writer.WriteNumber("educationOrganizationId", trackedChangesEdFiGraduationPlanKey.EducationOrganizationIdOption.Value!.Value);

            if (trackedChangesEdFiGraduationPlanKey.GraduationSchoolYearOption.IsSet)
                writer.WriteNumber("graduationSchoolYear", trackedChangesEdFiGraduationPlanKey.GraduationSchoolYearOption.Value!.Value);
        }
    }
}
