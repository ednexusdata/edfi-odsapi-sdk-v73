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
    /// TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey
    /// </summary>
    public partial class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey" /> class.
        /// </summary>
        /// <param name="consentToEvaluationReceivedDate">Indicates the date on which the local education agency received written consent for the evaluation from the student&#39;s parent or guardian. This is the first day of the evaluation timeframe.</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization.</param>
        /// <param name="programEducationOrganizationId">The identifier assigned to an education organization.</param>
        /// <param name="programName">The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies.</param>
        /// <param name="programTypeDescriptor">The type of program.</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student.</param>
        [JsonConstructor]
        public TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey(Option<DateOnly?> consentToEvaluationReceivedDate = default, Option<long?> educationOrganizationId = default, Option<long?> programEducationOrganizationId = default, Option<string?> programName = default, Option<string?> programTypeDescriptor = default, Option<string?> studentUniqueId = default)
        {
            ConsentToEvaluationReceivedDateOption = consentToEvaluationReceivedDate;
            EducationOrganizationIdOption = educationOrganizationId;
            ProgramEducationOrganizationIdOption = programEducationOrganizationId;
            ProgramNameOption = programName;
            ProgramTypeDescriptorOption = programTypeDescriptor;
            StudentUniqueIdOption = studentUniqueId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ConsentToEvaluationReceivedDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> ConsentToEvaluationReceivedDateOption { get; private set; }

        /// <summary>
        /// Indicates the date on which the local education agency received written consent for the evaluation from the student&#39;s parent or guardian. This is the first day of the evaluation timeframe.
        /// </summary>
        /// <value>Indicates the date on which the local education agency received written consent for the evaluation from the student&#39;s parent or guardian. This is the first day of the evaluation timeframe.</value>
        [JsonPropertyName("consentToEvaluationReceivedDate")]
        public DateOnly? ConsentToEvaluationReceivedDate { get { return this.ConsentToEvaluationReceivedDateOption; } set { this.ConsentToEvaluationReceivedDateOption = new(value); } }

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
        /// Used to track the state of ProgramEducationOrganizationId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> ProgramEducationOrganizationIdOption { get; private set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [JsonPropertyName("programEducationOrganizationId")]
        public long? ProgramEducationOrganizationId { get { return this.ProgramEducationOrganizationIdOption; } set { this.ProgramEducationOrganizationIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ProgramName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ProgramNameOption { get; private set; }

        /// <summary>
        /// The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies.
        /// </summary>
        /// <value>The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies.</value>
        [JsonPropertyName("programName")]
        public string? ProgramName { get { return this.ProgramNameOption; } set { this.ProgramNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of ProgramTypeDescriptor
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ProgramTypeDescriptorOption { get; private set; }

        /// <summary>
        /// The type of program.
        /// </summary>
        /// <value>The type of program.</value>
        [JsonPropertyName("programTypeDescriptor")]
        public string? ProgramTypeDescriptor { get { return this.ProgramTypeDescriptorOption; } set { this.ProgramTypeDescriptorOption = new(value); } }

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
            sb.Append("class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey {\n");
            sb.Append("  ConsentToEvaluationReceivedDate: ").Append(ConsentToEvaluationReceivedDate).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  ProgramEducationOrganizationId: ").Append(ProgramEducationOrganizationId).Append("\n");
            sb.Append("  ProgramName: ").Append(ProgramName).Append("\n");
            sb.Append("  ProgramTypeDescriptor: ").Append(ProgramTypeDescriptor).Append("\n");
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
            // ProgramName (string) maxLength
            if (this.ProgramName != null && this.ProgramName.Length > 60)
            {
                yield return new ValidationResult("Invalid value for ProgramName, length must be less than 60.", new [] { "ProgramName" });
            }

            // ProgramTypeDescriptor (string) maxLength
            if (this.ProgramTypeDescriptor != null && this.ProgramTypeDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for ProgramTypeDescriptor, length must be less than 306.", new [] { "ProgramTypeDescriptor" });
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
    /// A Json converter for type <see cref="TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey" />
    /// </summary>
    public class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKeyJsonConverter : JsonConverter<TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey>
    {
        /// <summary>
        /// The format to use to serialize ConsentToEvaluationReceivedDate
        /// </summary>
        public static string ConsentToEvaluationReceivedDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateOnly?> consentToEvaluationReceivedDate = default;
            Option<long?> educationOrganizationId = default;
            Option<long?> programEducationOrganizationId = default;
            Option<string?> programName = default;
            Option<string?> programTypeDescriptor = default;
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
                        case "consentToEvaluationReceivedDate":
                            consentToEvaluationReceivedDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "educationOrganizationId":
                            educationOrganizationId = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "programEducationOrganizationId":
                            programEducationOrganizationId = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "programName":
                            programName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "programTypeDescriptor":
                            programTypeDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "studentUniqueId":
                            studentUniqueId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (consentToEvaluationReceivedDate.IsSet && consentToEvaluationReceivedDate.Value == null)
                throw new ArgumentNullException(nameof(consentToEvaluationReceivedDate), "Property is not nullable for class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.");

            if (educationOrganizationId.IsSet && educationOrganizationId.Value == null)
                throw new ArgumentNullException(nameof(educationOrganizationId), "Property is not nullable for class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.");

            if (programEducationOrganizationId.IsSet && programEducationOrganizationId.Value == null)
                throw new ArgumentNullException(nameof(programEducationOrganizationId), "Property is not nullable for class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.");

            if (programName.IsSet && programName.Value == null)
                throw new ArgumentNullException(nameof(programName), "Property is not nullable for class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.");

            if (programTypeDescriptor.IsSet && programTypeDescriptor.Value == null)
                throw new ArgumentNullException(nameof(programTypeDescriptor), "Property is not nullable for class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.");

            if (studentUniqueId.IsSet && studentUniqueId.Value == null)
                throw new ArgumentNullException(nameof(studentUniqueId), "Property is not nullable for class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.");

            return new TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey(consentToEvaluationReceivedDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId);
        }

        /// <summary>
        /// Serializes a <see cref="TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramNameOption.IsSet && trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramName == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramName), "Property is required for class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.");

            if (trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramTypeDescriptorOption.IsSet && trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramTypeDescriptor == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramTypeDescriptor), "Property is required for class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.");

            if (trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.StudentUniqueIdOption.IsSet && trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.StudentUniqueId == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.StudentUniqueId), "Property is required for class TrackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.");

            if (trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ConsentToEvaluationReceivedDateOption.IsSet)
                writer.WriteString("consentToEvaluationReceivedDate", trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ConsentToEvaluationReceivedDateOption.Value!.Value.ToString(ConsentToEvaluationReceivedDateFormat));

            if (trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.EducationOrganizationIdOption.IsSet)
                writer.WriteNumber("educationOrganizationId", trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.EducationOrganizationIdOption.Value!.Value);

            if (trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramEducationOrganizationIdOption.IsSet)
                writer.WriteNumber("programEducationOrganizationId", trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramEducationOrganizationIdOption.Value!.Value);

            if (trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramNameOption.IsSet)
                writer.WriteString("programName", trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramName);

            if (trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramTypeDescriptorOption.IsSet)
                writer.WriteString("programTypeDescriptor", trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.ProgramTypeDescriptor);

            if (trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.StudentUniqueIdOption.IsSet)
                writer.WriteString("studentUniqueId", trackedChangesEdFiStudentSpecialEducationProgramEligibilityAssociationKey.StudentUniqueId);
        }
    }
}
