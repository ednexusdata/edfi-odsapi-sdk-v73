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
    /// EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode
    /// </summary>
    public partial class EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode" /> class.
        /// </summary>
        /// <param name="disciplineIncidentParticipationCodeDescriptor">The role or type of participation of a student in a discipline incident.</param>
        /// <param name="ext">Extensions to the StaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode entity.</param>
        [JsonConstructor]
        public EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode(string disciplineIncidentParticipationCodeDescriptor, Option<Object?> ext = default)
        {
            DisciplineIncidentParticipationCodeDescriptor = disciplineIncidentParticipationCodeDescriptor;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The role or type of participation of a student in a discipline incident.
        /// </summary>
        /// <value>The role or type of participation of a student in a discipline incident.</value>
        [JsonPropertyName("disciplineIncidentParticipationCodeDescriptor")]
        public string DisciplineIncidentParticipationCodeDescriptor { get; set; }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the StaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode entity.
        /// </summary>
        /// <value>Extensions to the StaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode {\n");
            sb.Append("  DisciplineIncidentParticipationCodeDescriptor: ").Append(DisciplineIncidentParticipationCodeDescriptor).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            // DisciplineIncidentParticipationCodeDescriptor (string) maxLength
            if (this.DisciplineIncidentParticipationCodeDescriptor != null && this.DisciplineIncidentParticipationCodeDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for DisciplineIncidentParticipationCodeDescriptor, length must be less than 306.", new [] { "DisciplineIncidentParticipationCodeDescriptor" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode" />
    /// </summary>
    public class EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCodeJsonConverter : JsonConverter<EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> disciplineIncidentParticipationCodeDescriptor = default;
            Option<Object?> ext = default;

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
                        case "disciplineIncidentParticipationCodeDescriptor":
                            disciplineIncidentParticipationCodeDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!disciplineIncidentParticipationCodeDescriptor.IsSet)
                throw new ArgumentException("Property is required for class EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.", nameof(disciplineIncidentParticipationCodeDescriptor));

            if (disciplineIncidentParticipationCodeDescriptor.IsSet && disciplineIncidentParticipationCodeDescriptor.Value == null)
                throw new ArgumentNullException(nameof(disciplineIncidentParticipationCodeDescriptor), "Property is not nullable for class EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.");

            return new EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode(disciplineIncidentParticipationCodeDescriptor.Value!, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.DisciplineIncidentParticipationCodeDescriptor == null)
                throw new ArgumentNullException(nameof(edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.DisciplineIncidentParticipationCodeDescriptor), "Property is required for class EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.");

            if (edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.ExtOption.IsSet && edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.Ext == null)
                throw new ArgumentNullException(nameof(edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.Ext), "Property is required for class EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.");

            writer.WriteString("disciplineIncidentParticipationCodeDescriptor", edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.DisciplineIncidentParticipationCodeDescriptor);

            if (edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode.Ext, jsonSerializerOptions);
            }
        }
    }
}
