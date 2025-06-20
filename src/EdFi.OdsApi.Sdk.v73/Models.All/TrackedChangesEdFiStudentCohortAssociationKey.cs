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
    /// TrackedChangesEdFiStudentCohortAssociationKey
    /// </summary>
    public partial class TrackedChangesEdFiStudentCohortAssociationKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStudentCohortAssociationKey" /> class.
        /// </summary>
        /// <param name="beginDate">The month, day, and year on which the student was first identified as part of the cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.</param>
        /// <param name="cohortIdentifier">The name or ID for the cohort.</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization.</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student.</param>
        [JsonConstructor]
        public TrackedChangesEdFiStudentCohortAssociationKey(Option<DateOnly?> beginDate = default, Option<string?> cohortIdentifier = default, Option<long?> educationOrganizationId = default, Option<string?> studentUniqueId = default)
        {
            BeginDateOption = beginDate;
            CohortIdentifierOption = cohortIdentifier;
            EducationOrganizationIdOption = educationOrganizationId;
            StudentUniqueIdOption = studentUniqueId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of BeginDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> BeginDateOption { get; private set; }

        /// <summary>
        /// The month, day, and year on which the student was first identified as part of the cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.
        /// </summary>
        /// <value>The month, day, and year on which the student was first identified as part of the cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.</value>
        [JsonPropertyName("beginDate")]
        public DateOnly? BeginDate { get { return this.BeginDateOption; } set { this.BeginDateOption = new(value); } }

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
        /// Used to track the state of StudentUniqueId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StudentUniqueIdOption { get; private set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [JsonPropertyName("studentUniqueId")]
        public string? StudentUniqueId { get { return this.StudentUniqueIdOption; } set { this.StudentUniqueIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiStudentCohortAssociationKey {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  CohortIdentifier: ").Append(CohortIdentifier).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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

            // StudentUniqueId (string) maxLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TrackedChangesEdFiStudentCohortAssociationKey" />
    /// </summary>
    public class TrackedChangesEdFiStudentCohortAssociationKeyJsonConverter : JsonConverter<TrackedChangesEdFiStudentCohortAssociationKey>
    {
        /// <summary>
        /// The format to use to serialize BeginDate
        /// </summary>
        public static string BeginDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="TrackedChangesEdFiStudentCohortAssociationKey" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TrackedChangesEdFiStudentCohortAssociationKey Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateOnly?> beginDate = default;
            Option<string?> cohortIdentifier = default;
            Option<long?> educationOrganizationId = default;
            Option<string?> studentUniqueId = default;

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
                        case "beginDate":
                            beginDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "cohortIdentifier":
                            cohortIdentifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "educationOrganizationId":
                            educationOrganizationId = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "studentUniqueId":
                            studentUniqueId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (beginDate.IsSet && beginDate.Value == null)
                throw new ArgumentNullException(nameof(beginDate), "Property is not nullable for class TrackedChangesEdFiStudentCohortAssociationKey.");

            if (cohortIdentifier.IsSet && cohortIdentifier.Value == null)
                throw new ArgumentNullException(nameof(cohortIdentifier), "Property is not nullable for class TrackedChangesEdFiStudentCohortAssociationKey.");

            if (educationOrganizationId.IsSet && educationOrganizationId.Value == null)
                throw new ArgumentNullException(nameof(educationOrganizationId), "Property is not nullable for class TrackedChangesEdFiStudentCohortAssociationKey.");

            if (studentUniqueId.IsSet && studentUniqueId.Value == null)
                throw new ArgumentNullException(nameof(studentUniqueId), "Property is not nullable for class TrackedChangesEdFiStudentCohortAssociationKey.");

            return new TrackedChangesEdFiStudentCohortAssociationKey(beginDate, cohortIdentifier, educationOrganizationId, studentUniqueId);
        }

        /// <summary>
        /// Serializes a <see cref="TrackedChangesEdFiStudentCohortAssociationKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiStudentCohortAssociationKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TrackedChangesEdFiStudentCohortAssociationKey trackedChangesEdFiStudentCohortAssociationKey, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trackedChangesEdFiStudentCohortAssociationKey, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TrackedChangesEdFiStudentCohortAssociationKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiStudentCohortAssociationKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TrackedChangesEdFiStudentCohortAssociationKey trackedChangesEdFiStudentCohortAssociationKey, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trackedChangesEdFiStudentCohortAssociationKey.CohortIdentifierOption.IsSet && trackedChangesEdFiStudentCohortAssociationKey.CohortIdentifier == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStudentCohortAssociationKey.CohortIdentifier), "Property is required for class TrackedChangesEdFiStudentCohortAssociationKey.");

            if (trackedChangesEdFiStudentCohortAssociationKey.StudentUniqueIdOption.IsSet && trackedChangesEdFiStudentCohortAssociationKey.StudentUniqueId == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStudentCohortAssociationKey.StudentUniqueId), "Property is required for class TrackedChangesEdFiStudentCohortAssociationKey.");

            if (trackedChangesEdFiStudentCohortAssociationKey.BeginDateOption.IsSet)
                writer.WriteString("beginDate", trackedChangesEdFiStudentCohortAssociationKey.BeginDateOption.Value!.Value.ToString(BeginDateFormat));

            if (trackedChangesEdFiStudentCohortAssociationKey.CohortIdentifierOption.IsSet)
                writer.WriteString("cohortIdentifier", trackedChangesEdFiStudentCohortAssociationKey.CohortIdentifier);

            if (trackedChangesEdFiStudentCohortAssociationKey.EducationOrganizationIdOption.IsSet)
                writer.WriteNumber("educationOrganizationId", trackedChangesEdFiStudentCohortAssociationKey.EducationOrganizationIdOption.Value!.Value);

            if (trackedChangesEdFiStudentCohortAssociationKey.StudentUniqueIdOption.IsSet)
                writer.WriteString("studentUniqueId", trackedChangesEdFiStudentCohortAssociationKey.StudentUniqueId);
        }
    }
}
