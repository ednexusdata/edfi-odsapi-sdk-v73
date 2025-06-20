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
    /// EdFiProgramReference
    /// </summary>
    public partial class EdFiProgramReference : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiProgramReference" /> class.
        /// </summary>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization.</param>
        /// <param name="programName">The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies.</param>
        /// <param name="programTypeDescriptor">The type of program.</param>
        /// <param name="link">link</param>
        [JsonConstructor]
        public EdFiProgramReference(long educationOrganizationId, string programName, string programTypeDescriptor, Option<Link?> link = default)
        {
            EducationOrganizationId = educationOrganizationId;
            ProgramName = programName;
            ProgramTypeDescriptor = programTypeDescriptor;
            LinkOption = link;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [JsonPropertyName("educationOrganizationId")]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies.
        /// </summary>
        /// <value>The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies.</value>
        [JsonPropertyName("programName")]
        public string ProgramName { get; set; }

        /// <summary>
        /// The type of program.
        /// </summary>
        /// <value>The type of program.</value>
        [JsonPropertyName("programTypeDescriptor")]
        public string ProgramTypeDescriptor { get; set; }

        /// <summary>
        /// Used to track the state of Link
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Link?> LinkOption { get; private set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [JsonPropertyName("link")]
        public Link? Link { get { return this.LinkOption; } set { this.LinkOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiProgramReference {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  ProgramName: ").Append(ProgramName).Append("\n");
            sb.Append("  ProgramTypeDescriptor: ").Append(ProgramTypeDescriptor).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiProgramReference" />
    /// </summary>
    public class EdFiProgramReferenceJsonConverter : JsonConverter<EdFiProgramReference>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiProgramReference" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiProgramReference Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> educationOrganizationId = default;
            Option<string?> programName = default;
            Option<string?> programTypeDescriptor = default;
            Option<Link?> link = default;

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
                        case "educationOrganizationId":
                            educationOrganizationId = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "programName":
                            programName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "programTypeDescriptor":
                            programTypeDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "link":
                            link = new Option<Link?>(JsonSerializer.Deserialize<Link>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!educationOrganizationId.IsSet)
                throw new ArgumentException("Property is required for class EdFiProgramReference.", nameof(educationOrganizationId));

            if (!programName.IsSet)
                throw new ArgumentException("Property is required for class EdFiProgramReference.", nameof(programName));

            if (!programTypeDescriptor.IsSet)
                throw new ArgumentException("Property is required for class EdFiProgramReference.", nameof(programTypeDescriptor));

            if (educationOrganizationId.IsSet && educationOrganizationId.Value == null)
                throw new ArgumentNullException(nameof(educationOrganizationId), "Property is not nullable for class EdFiProgramReference.");

            if (programName.IsSet && programName.Value == null)
                throw new ArgumentNullException(nameof(programName), "Property is not nullable for class EdFiProgramReference.");

            if (programTypeDescriptor.IsSet && programTypeDescriptor.Value == null)
                throw new ArgumentNullException(nameof(programTypeDescriptor), "Property is not nullable for class EdFiProgramReference.");

            if (link.IsSet && link.Value == null)
                throw new ArgumentNullException(nameof(link), "Property is not nullable for class EdFiProgramReference.");

            return new EdFiProgramReference(educationOrganizationId.Value!.Value!, programName.Value!, programTypeDescriptor.Value!, link);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiProgramReference" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiProgramReference"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiProgramReference edFiProgramReference, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiProgramReference, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiProgramReference" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiProgramReference"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiProgramReference edFiProgramReference, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiProgramReference.ProgramName == null)
                throw new ArgumentNullException(nameof(edFiProgramReference.ProgramName), "Property is required for class EdFiProgramReference.");

            if (edFiProgramReference.ProgramTypeDescriptor == null)
                throw new ArgumentNullException(nameof(edFiProgramReference.ProgramTypeDescriptor), "Property is required for class EdFiProgramReference.");

            if (edFiProgramReference.LinkOption.IsSet && edFiProgramReference.Link == null)
                throw new ArgumentNullException(nameof(edFiProgramReference.Link), "Property is required for class EdFiProgramReference.");

            writer.WriteNumber("educationOrganizationId", edFiProgramReference.EducationOrganizationId);

            writer.WriteString("programName", edFiProgramReference.ProgramName);

            writer.WriteString("programTypeDescriptor", edFiProgramReference.ProgramTypeDescriptor);

            if (edFiProgramReference.LinkOption.IsSet)
            {
                writer.WritePropertyName("link");
                JsonSerializer.Serialize(writer, edFiProgramReference.Link, jsonSerializerOptions);
            }
        }
    }
}
