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
    /// EdFiBellScheduleGradeLevel
    /// </summary>
    public partial class EdFiBellScheduleGradeLevel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiBellScheduleGradeLevel" /> class.
        /// </summary>
        /// <param name="gradeLevelDescriptor">The grade levels the particular bell schedule applies to.</param>
        /// <param name="ext">Extensions to the BellScheduleGradeLevel entity.</param>
        [JsonConstructor]
        public EdFiBellScheduleGradeLevel(string gradeLevelDescriptor, Option<Object?> ext = default)
        {
            GradeLevelDescriptor = gradeLevelDescriptor;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The grade levels the particular bell schedule applies to.
        /// </summary>
        /// <value>The grade levels the particular bell schedule applies to.</value>
        [JsonPropertyName("gradeLevelDescriptor")]
        public string GradeLevelDescriptor { get; set; }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the BellScheduleGradeLevel entity.
        /// </summary>
        /// <value>Extensions to the BellScheduleGradeLevel entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiBellScheduleGradeLevel {\n");
            sb.Append("  GradeLevelDescriptor: ").Append(GradeLevelDescriptor).Append("\n");
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
            // GradeLevelDescriptor (string) maxLength
            if (this.GradeLevelDescriptor != null && this.GradeLevelDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for GradeLevelDescriptor, length must be less than 306.", new [] { "GradeLevelDescriptor" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiBellScheduleGradeLevel" />
    /// </summary>
    public class EdFiBellScheduleGradeLevelJsonConverter : JsonConverter<EdFiBellScheduleGradeLevel>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiBellScheduleGradeLevel" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiBellScheduleGradeLevel Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> gradeLevelDescriptor = default;
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
                        case "gradeLevelDescriptor":
                            gradeLevelDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!gradeLevelDescriptor.IsSet)
                throw new ArgumentException("Property is required for class EdFiBellScheduleGradeLevel.", nameof(gradeLevelDescriptor));

            if (gradeLevelDescriptor.IsSet && gradeLevelDescriptor.Value == null)
                throw new ArgumentNullException(nameof(gradeLevelDescriptor), "Property is not nullable for class EdFiBellScheduleGradeLevel.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiBellScheduleGradeLevel.");

            return new EdFiBellScheduleGradeLevel(gradeLevelDescriptor.Value!, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiBellScheduleGradeLevel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiBellScheduleGradeLevel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiBellScheduleGradeLevel edFiBellScheduleGradeLevel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiBellScheduleGradeLevel, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiBellScheduleGradeLevel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiBellScheduleGradeLevel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiBellScheduleGradeLevel edFiBellScheduleGradeLevel, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiBellScheduleGradeLevel.GradeLevelDescriptor == null)
                throw new ArgumentNullException(nameof(edFiBellScheduleGradeLevel.GradeLevelDescriptor), "Property is required for class EdFiBellScheduleGradeLevel.");

            if (edFiBellScheduleGradeLevel.ExtOption.IsSet && edFiBellScheduleGradeLevel.Ext == null)
                throw new ArgumentNullException(nameof(edFiBellScheduleGradeLevel.Ext), "Property is required for class EdFiBellScheduleGradeLevel.");

            writer.WriteString("gradeLevelDescriptor", edFiBellScheduleGradeLevel.GradeLevelDescriptor);

            if (edFiBellScheduleGradeLevel.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiBellScheduleGradeLevel.Ext, jsonSerializerOptions);
            }
        }
    }
}
