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
    /// TrackedChangesEdFiCohortKey
    /// </summary>
    public partial class TrackedChangesEdFiCohortKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiCohortKey" /> class.
        /// </summary>
        /// <param name="cohortIdentifier">The name or ID for the cohort.</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization.</param>
        [JsonConstructor]
        public TrackedChangesEdFiCohortKey(Option<string?> cohortIdentifier = default, Option<long?> educationOrganizationId = default)
        {
            CohortIdentifierOption = cohortIdentifier;
            EducationOrganizationIdOption = educationOrganizationId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CohortIdentifier
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CohortIdentifierOption { get; private set; }

        /// <summary>
        /// The name or ID for the cohort.
        /// </summary>
        /// <value>The name or ID for the cohort.</value>
        [JsonPropertyName("cohortIdentifier")]
        public string? CohortIdentifier { get { return this.CohortIdentifierOption; } set { this.CohortIdentifierOption = new(value); } }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiCohortKey {\n");
            sb.Append("  CohortIdentifier: ").Append(CohortIdentifier).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
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
            // CohortIdentifier (string) maxLength
            if (this.CohortIdentifier != null && this.CohortIdentifier.Length > 36)
            {
                yield return new ValidationResult("Invalid value for CohortIdentifier, length must be less than 36.", new [] { "CohortIdentifier" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TrackedChangesEdFiCohortKey" />
    /// </summary>
    public class TrackedChangesEdFiCohortKeyJsonConverter : JsonConverter<TrackedChangesEdFiCohortKey>
    {
        /// <summary>
        /// Deserializes json to <see cref="TrackedChangesEdFiCohortKey" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TrackedChangesEdFiCohortKey Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> cohortIdentifier = default;
            Option<long?> educationOrganizationId = default;

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
                        case "cohortIdentifier":
                            cohortIdentifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "educationOrganizationId":
                            educationOrganizationId = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (cohortIdentifier.IsSet && cohortIdentifier.Value == null)
                throw new ArgumentNullException(nameof(cohortIdentifier), "Property is not nullable for class TrackedChangesEdFiCohortKey.");

            if (educationOrganizationId.IsSet && educationOrganizationId.Value == null)
                throw new ArgumentNullException(nameof(educationOrganizationId), "Property is not nullable for class TrackedChangesEdFiCohortKey.");

            return new TrackedChangesEdFiCohortKey(cohortIdentifier, educationOrganizationId);
        }

        /// <summary>
        /// Serializes a <see cref="TrackedChangesEdFiCohortKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiCohortKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TrackedChangesEdFiCohortKey trackedChangesEdFiCohortKey, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trackedChangesEdFiCohortKey, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TrackedChangesEdFiCohortKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiCohortKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TrackedChangesEdFiCohortKey trackedChangesEdFiCohortKey, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trackedChangesEdFiCohortKey.CohortIdentifierOption.IsSet && trackedChangesEdFiCohortKey.CohortIdentifier == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiCohortKey.CohortIdentifier), "Property is required for class TrackedChangesEdFiCohortKey.");

            if (trackedChangesEdFiCohortKey.CohortIdentifierOption.IsSet)
                writer.WriteString("cohortIdentifier", trackedChangesEdFiCohortKey.CohortIdentifier);

            if (trackedChangesEdFiCohortKey.EducationOrganizationIdOption.IsSet)
                writer.WriteNumber("educationOrganizationId", trackedChangesEdFiCohortKey.EducationOrganizationIdOption.Value!.Value);
        }
    }
}
