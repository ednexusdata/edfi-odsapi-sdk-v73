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
    /// EdFiStudentEducationOrganizationAssociationDisabilityDesignation
    /// </summary>
    public partial class EdFiStudentEducationOrganizationAssociationDisabilityDesignation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationDisabilityDesignation" /> class.
        /// </summary>
        /// <param name="disabilityDesignationDescriptor">Whether the disability is IDEA, Section 504, or other disability designation.</param>
        /// <param name="ext">Extensions to the StudentEducationOrganizationAssociationDisabilityDesignation entity.</param>
        [JsonConstructor]
        public EdFiStudentEducationOrganizationAssociationDisabilityDesignation(string disabilityDesignationDescriptor, Option<Object?> ext = default)
        {
            DisabilityDesignationDescriptor = disabilityDesignationDescriptor;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Whether the disability is IDEA, Section 504, or other disability designation.
        /// </summary>
        /// <value>Whether the disability is IDEA, Section 504, or other disability designation.</value>
        [JsonPropertyName("disabilityDesignationDescriptor")]
        public string DisabilityDesignationDescriptor { get; set; }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the StudentEducationOrganizationAssociationDisabilityDesignation entity.
        /// </summary>
        /// <value>Extensions to the StudentEducationOrganizationAssociationDisabilityDesignation entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationDisabilityDesignation {\n");
            sb.Append("  DisabilityDesignationDescriptor: ").Append(DisabilityDesignationDescriptor).Append("\n");
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
            // DisabilityDesignationDescriptor (string) maxLength
            if (this.DisabilityDesignationDescriptor != null && this.DisabilityDesignationDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for DisabilityDesignationDescriptor, length must be less than 306.", new [] { "DisabilityDesignationDescriptor" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiStudentEducationOrganizationAssociationDisabilityDesignation" />
    /// </summary>
    public class EdFiStudentEducationOrganizationAssociationDisabilityDesignationJsonConverter : JsonConverter<EdFiStudentEducationOrganizationAssociationDisabilityDesignation>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiStudentEducationOrganizationAssociationDisabilityDesignation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiStudentEducationOrganizationAssociationDisabilityDesignation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> disabilityDesignationDescriptor = default;
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
                        case "disabilityDesignationDescriptor":
                            disabilityDesignationDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!disabilityDesignationDescriptor.IsSet)
                throw new ArgumentException("Property is required for class EdFiStudentEducationOrganizationAssociationDisabilityDesignation.", nameof(disabilityDesignationDescriptor));

            if (disabilityDesignationDescriptor.IsSet && disabilityDesignationDescriptor.Value == null)
                throw new ArgumentNullException(nameof(disabilityDesignationDescriptor), "Property is not nullable for class EdFiStudentEducationOrganizationAssociationDisabilityDesignation.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiStudentEducationOrganizationAssociationDisabilityDesignation.");

            return new EdFiStudentEducationOrganizationAssociationDisabilityDesignation(disabilityDesignationDescriptor.Value!, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiStudentEducationOrganizationAssociationDisabilityDesignation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentEducationOrganizationAssociationDisabilityDesignation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiStudentEducationOrganizationAssociationDisabilityDesignation edFiStudentEducationOrganizationAssociationDisabilityDesignation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiStudentEducationOrganizationAssociationDisabilityDesignation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiStudentEducationOrganizationAssociationDisabilityDesignation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentEducationOrganizationAssociationDisabilityDesignation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiStudentEducationOrganizationAssociationDisabilityDesignation edFiStudentEducationOrganizationAssociationDisabilityDesignation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiStudentEducationOrganizationAssociationDisabilityDesignation.DisabilityDesignationDescriptor == null)
                throw new ArgumentNullException(nameof(edFiStudentEducationOrganizationAssociationDisabilityDesignation.DisabilityDesignationDescriptor), "Property is required for class EdFiStudentEducationOrganizationAssociationDisabilityDesignation.");

            if (edFiStudentEducationOrganizationAssociationDisabilityDesignation.ExtOption.IsSet && edFiStudentEducationOrganizationAssociationDisabilityDesignation.Ext == null)
                throw new ArgumentNullException(nameof(edFiStudentEducationOrganizationAssociationDisabilityDesignation.Ext), "Property is required for class EdFiStudentEducationOrganizationAssociationDisabilityDesignation.");

            writer.WriteString("disabilityDesignationDescriptor", edFiStudentEducationOrganizationAssociationDisabilityDesignation.DisabilityDesignationDescriptor);

            if (edFiStudentEducationOrganizationAssociationDisabilityDesignation.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiStudentEducationOrganizationAssociationDisabilityDesignation.Ext, jsonSerializerOptions);
            }
        }
    }
}
