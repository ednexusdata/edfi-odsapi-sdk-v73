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
    /// EdFiCohortProgram
    /// </summary>
    public partial class EdFiCohortProgram : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCohortProgram" /> class.
        /// </summary>
        /// <param name="programReference">programReference</param>
        /// <param name="ext">Extensions to the CohortProgram entity.</param>
        [JsonConstructor]
        public EdFiCohortProgram(EdFiProgramReference programReference, Option<Object?> ext = default)
        {
            ProgramReference = programReference;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ProgramReference
        /// </summary>
        [JsonPropertyName("programReference")]
        public EdFiProgramReference ProgramReference { get; set; }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the CohortProgram entity.
        /// </summary>
        /// <value>Extensions to the CohortProgram entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiCohortProgram {\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
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
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiCohortProgram" />
    /// </summary>
    public class EdFiCohortProgramJsonConverter : JsonConverter<EdFiCohortProgram>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiCohortProgram" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiCohortProgram Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<EdFiProgramReference?> programReference = default;
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
                        case "programReference":
                            programReference = new Option<EdFiProgramReference?>(JsonSerializer.Deserialize<EdFiProgramReference>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!programReference.IsSet)
                throw new ArgumentException("Property is required for class EdFiCohortProgram.", nameof(programReference));

            if (programReference.IsSet && programReference.Value == null)
                throw new ArgumentNullException(nameof(programReference), "Property is not nullable for class EdFiCohortProgram.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiCohortProgram.");

            return new EdFiCohortProgram(programReference.Value!, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiCohortProgram" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiCohortProgram"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiCohortProgram edFiCohortProgram, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiCohortProgram, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiCohortProgram" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiCohortProgram"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiCohortProgram edFiCohortProgram, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiCohortProgram.ProgramReference == null)
                throw new ArgumentNullException(nameof(edFiCohortProgram.ProgramReference), "Property is required for class EdFiCohortProgram.");

            if (edFiCohortProgram.ExtOption.IsSet && edFiCohortProgram.Ext == null)
                throw new ArgumentNullException(nameof(edFiCohortProgram.Ext), "Property is required for class EdFiCohortProgram.");

            writer.WritePropertyName("programReference");
            JsonSerializer.Serialize(writer, edFiCohortProgram.ProgramReference, jsonSerializerOptions);
            if (edFiCohortProgram.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiCohortProgram.Ext, jsonSerializerOptions);
            }
        }
    }
}
