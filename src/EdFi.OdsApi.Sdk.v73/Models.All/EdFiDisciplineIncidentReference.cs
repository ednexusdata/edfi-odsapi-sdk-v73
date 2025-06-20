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
    /// EdFiDisciplineIncidentReference
    /// </summary>
    public partial class EdFiDisciplineIncidentReference : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineIncidentReference" /> class.
        /// </summary>
        /// <param name="incidentIdentifier">A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire discipline incident even if it included multiple offenses and multiple offenders.</param>
        /// <param name="schoolId">The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication.</param>
        /// <param name="link">link</param>
        [JsonConstructor]
        public EdFiDisciplineIncidentReference(string incidentIdentifier, long schoolId, Option<Link?> link = default)
        {
            IncidentIdentifier = incidentIdentifier;
            SchoolId = schoolId;
            LinkOption = link;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire discipline incident even if it included multiple offenses and multiple offenders.
        /// </summary>
        /// <value>A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire discipline incident even if it included multiple offenses and multiple offenders.</value>
        [JsonPropertyName("incidentIdentifier")]
        public string IncidentIdentifier { get; set; }

        /// <summary>
        /// The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication.
        /// </summary>
        /// <value>The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication.</value>
        [JsonPropertyName("schoolId")]
        public long SchoolId { get; set; }

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
            sb.Append("class EdFiDisciplineIncidentReference {\n");
            sb.Append("  IncidentIdentifier: ").Append(IncidentIdentifier).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
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
            // IncidentIdentifier (string) maxLength
            if (this.IncidentIdentifier != null && this.IncidentIdentifier.Length > 36)
            {
                yield return new ValidationResult("Invalid value for IncidentIdentifier, length must be less than 36.", new [] { "IncidentIdentifier" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiDisciplineIncidentReference" />
    /// </summary>
    public class EdFiDisciplineIncidentReferenceJsonConverter : JsonConverter<EdFiDisciplineIncidentReference>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiDisciplineIncidentReference" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiDisciplineIncidentReference Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> incidentIdentifier = default;
            Option<long?> schoolId = default;
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
                        case "incidentIdentifier":
                            incidentIdentifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "schoolId":
                            schoolId = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "link":
                            link = new Option<Link?>(JsonSerializer.Deserialize<Link>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!incidentIdentifier.IsSet)
                throw new ArgumentException("Property is required for class EdFiDisciplineIncidentReference.", nameof(incidentIdentifier));

            if (!schoolId.IsSet)
                throw new ArgumentException("Property is required for class EdFiDisciplineIncidentReference.", nameof(schoolId));

            if (incidentIdentifier.IsSet && incidentIdentifier.Value == null)
                throw new ArgumentNullException(nameof(incidentIdentifier), "Property is not nullable for class EdFiDisciplineIncidentReference.");

            if (schoolId.IsSet && schoolId.Value == null)
                throw new ArgumentNullException(nameof(schoolId), "Property is not nullable for class EdFiDisciplineIncidentReference.");

            if (link.IsSet && link.Value == null)
                throw new ArgumentNullException(nameof(link), "Property is not nullable for class EdFiDisciplineIncidentReference.");

            return new EdFiDisciplineIncidentReference(incidentIdentifier.Value!, schoolId.Value!.Value!, link);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiDisciplineIncidentReference" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiDisciplineIncidentReference"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiDisciplineIncidentReference edFiDisciplineIncidentReference, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiDisciplineIncidentReference, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiDisciplineIncidentReference" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiDisciplineIncidentReference"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiDisciplineIncidentReference edFiDisciplineIncidentReference, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiDisciplineIncidentReference.IncidentIdentifier == null)
                throw new ArgumentNullException(nameof(edFiDisciplineIncidentReference.IncidentIdentifier), "Property is required for class EdFiDisciplineIncidentReference.");

            if (edFiDisciplineIncidentReference.LinkOption.IsSet && edFiDisciplineIncidentReference.Link == null)
                throw new ArgumentNullException(nameof(edFiDisciplineIncidentReference.Link), "Property is required for class EdFiDisciplineIncidentReference.");

            writer.WriteString("incidentIdentifier", edFiDisciplineIncidentReference.IncidentIdentifier);

            writer.WriteNumber("schoolId", edFiDisciplineIncidentReference.SchoolId);

            if (edFiDisciplineIncidentReference.LinkOption.IsSet)
            {
                writer.WritePropertyName("link");
                JsonSerializer.Serialize(writer, edFiDisciplineIncidentReference.Link, jsonSerializerOptions);
            }
        }
    }
}
