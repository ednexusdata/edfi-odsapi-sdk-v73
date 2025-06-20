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
    /// EdFiCourseTranscriptEarnedAdditionalCredits
    /// </summary>
    public partial class EdFiCourseTranscriptEarnedAdditionalCredits : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseTranscriptEarnedAdditionalCredits" /> class.
        /// </summary>
        /// <param name="additionalCreditTypeDescriptor">The type of credits or units of value awarded for the completion of a course.</param>
        /// <param name="credits">The value of credits or units of value awarded for the completion of a course</param>
        /// <param name="ext">Extensions to the CourseTranscriptEarnedAdditionalCredits entity.</param>
        [JsonConstructor]
        public EdFiCourseTranscriptEarnedAdditionalCredits(string additionalCreditTypeDescriptor, double credits, Option<Object?> ext = default)
        {
            AdditionalCreditTypeDescriptor = additionalCreditTypeDescriptor;
            Credits = credits;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [JsonPropertyName("additionalCreditTypeDescriptor")]
        public string AdditionalCreditTypeDescriptor { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course</value>
        [JsonPropertyName("credits")]
        public double Credits { get; set; }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the CourseTranscriptEarnedAdditionalCredits entity.
        /// </summary>
        /// <value>Extensions to the CourseTranscriptEarnedAdditionalCredits entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiCourseTranscriptEarnedAdditionalCredits {\n");
            sb.Append("  AdditionalCreditTypeDescriptor: ").Append(AdditionalCreditTypeDescriptor).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
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
            // AdditionalCreditTypeDescriptor (string) maxLength
            if (this.AdditionalCreditTypeDescriptor != null && this.AdditionalCreditTypeDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for AdditionalCreditTypeDescriptor, length must be less than 306.", new [] { "AdditionalCreditTypeDescriptor" });
            }

            // Credits (double) maximum
            if (this.Credits > (double)999999.999)
            {
                yield return new ValidationResult("Invalid value for Credits, must be a value less than or equal to 999999.999.", new [] { "Credits" });
            }

            // Credits (double) minimum
            if (this.Credits < (double)0.0)
            {
                yield return new ValidationResult("Invalid value for Credits, must be a value greater than or equal to 0.0.", new [] { "Credits" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiCourseTranscriptEarnedAdditionalCredits" />
    /// </summary>
    public class EdFiCourseTranscriptEarnedAdditionalCreditsJsonConverter : JsonConverter<EdFiCourseTranscriptEarnedAdditionalCredits>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiCourseTranscriptEarnedAdditionalCredits" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiCourseTranscriptEarnedAdditionalCredits Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> additionalCreditTypeDescriptor = default;
            Option<double?> credits = default;
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
                        case "additionalCreditTypeDescriptor":
                            additionalCreditTypeDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "credits":
                            credits = new Option<double?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (double?)null : utf8JsonReader.GetDouble());
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!additionalCreditTypeDescriptor.IsSet)
                throw new ArgumentException("Property is required for class EdFiCourseTranscriptEarnedAdditionalCredits.", nameof(additionalCreditTypeDescriptor));

            if (!credits.IsSet)
                throw new ArgumentException("Property is required for class EdFiCourseTranscriptEarnedAdditionalCredits.", nameof(credits));

            if (additionalCreditTypeDescriptor.IsSet && additionalCreditTypeDescriptor.Value == null)
                throw new ArgumentNullException(nameof(additionalCreditTypeDescriptor), "Property is not nullable for class EdFiCourseTranscriptEarnedAdditionalCredits.");

            if (credits.IsSet && credits.Value == null)
                throw new ArgumentNullException(nameof(credits), "Property is not nullable for class EdFiCourseTranscriptEarnedAdditionalCredits.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiCourseTranscriptEarnedAdditionalCredits.");

            return new EdFiCourseTranscriptEarnedAdditionalCredits(additionalCreditTypeDescriptor.Value!, credits.Value!.Value!, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiCourseTranscriptEarnedAdditionalCredits" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiCourseTranscriptEarnedAdditionalCredits"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiCourseTranscriptEarnedAdditionalCredits edFiCourseTranscriptEarnedAdditionalCredits, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiCourseTranscriptEarnedAdditionalCredits, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiCourseTranscriptEarnedAdditionalCredits" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiCourseTranscriptEarnedAdditionalCredits"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiCourseTranscriptEarnedAdditionalCredits edFiCourseTranscriptEarnedAdditionalCredits, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiCourseTranscriptEarnedAdditionalCredits.AdditionalCreditTypeDescriptor == null)
                throw new ArgumentNullException(nameof(edFiCourseTranscriptEarnedAdditionalCredits.AdditionalCreditTypeDescriptor), "Property is required for class EdFiCourseTranscriptEarnedAdditionalCredits.");

            if (edFiCourseTranscriptEarnedAdditionalCredits.ExtOption.IsSet && edFiCourseTranscriptEarnedAdditionalCredits.Ext == null)
                throw new ArgumentNullException(nameof(edFiCourseTranscriptEarnedAdditionalCredits.Ext), "Property is required for class EdFiCourseTranscriptEarnedAdditionalCredits.");

            writer.WriteString("additionalCreditTypeDescriptor", edFiCourseTranscriptEarnedAdditionalCredits.AdditionalCreditTypeDescriptor);

            writer.WriteNumber("credits", edFiCourseTranscriptEarnedAdditionalCredits.Credits);

            if (edFiCourseTranscriptEarnedAdditionalCredits.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiCourseTranscriptEarnedAdditionalCredits.Ext, jsonSerializerOptions);
            }
        }
    }
}
