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
    /// EdFiStudentProgramEvaluationStudentEvaluationElement
    /// </summary>
    public partial class EdFiStudentProgramEvaluationStudentEvaluationElement : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentProgramEvaluationStudentEvaluationElement" /> class.
        /// </summary>
        /// <param name="programEvaluationElementReference">programEvaluationElementReference</param>
        /// <param name="evaluationElementRatingLevelDescriptor">The rating level achieved based upon the rating or score for the evaluation element.</param>
        /// <param name="evaluationElementNumericRating">The numerical rating or score for the evaluation element.</param>
        /// <param name="ext">Extensions to the StudentProgramEvaluationStudentEvaluationElement entity.</param>
        [JsonConstructor]
        public EdFiStudentProgramEvaluationStudentEvaluationElement(EdFiProgramEvaluationElementReference programEvaluationElementReference, Option<string?> evaluationElementRatingLevelDescriptor = default, Option<double?> evaluationElementNumericRating = default, Option<Object?> ext = default)
        {
            ProgramEvaluationElementReference = programEvaluationElementReference;
            EvaluationElementRatingLevelDescriptorOption = evaluationElementRatingLevelDescriptor;
            EvaluationElementNumericRatingOption = evaluationElementNumericRating;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ProgramEvaluationElementReference
        /// </summary>
        [JsonPropertyName("programEvaluationElementReference")]
        public EdFiProgramEvaluationElementReference ProgramEvaluationElementReference { get; set; }

        /// <summary>
        /// Used to track the state of EvaluationElementRatingLevelDescriptor
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EvaluationElementRatingLevelDescriptorOption { get; private set; }

        /// <summary>
        /// The rating level achieved based upon the rating or score for the evaluation element.
        /// </summary>
        /// <value>The rating level achieved based upon the rating or score for the evaluation element.</value>
        [JsonPropertyName("evaluationElementRatingLevelDescriptor")]
        public string? EvaluationElementRatingLevelDescriptor { get { return this.EvaluationElementRatingLevelDescriptorOption; } set { this.EvaluationElementRatingLevelDescriptorOption = new(value); } }

        /// <summary>
        /// Used to track the state of EvaluationElementNumericRating
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> EvaluationElementNumericRatingOption { get; private set; }

        /// <summary>
        /// The numerical rating or score for the evaluation element.
        /// </summary>
        /// <value>The numerical rating or score for the evaluation element.</value>
        [JsonPropertyName("evaluationElementNumericRating")]
        public double? EvaluationElementNumericRating { get { return this.EvaluationElementNumericRatingOption; } set { this.EvaluationElementNumericRatingOption = new(value); } }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the StudentProgramEvaluationStudentEvaluationElement entity.
        /// </summary>
        /// <value>Extensions to the StudentProgramEvaluationStudentEvaluationElement entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentProgramEvaluationStudentEvaluationElement {\n");
            sb.Append("  ProgramEvaluationElementReference: ").Append(ProgramEvaluationElementReference).Append("\n");
            sb.Append("  EvaluationElementRatingLevelDescriptor: ").Append(EvaluationElementRatingLevelDescriptor).Append("\n");
            sb.Append("  EvaluationElementNumericRating: ").Append(EvaluationElementNumericRating).Append("\n");
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
            // EvaluationElementRatingLevelDescriptor (string) maxLength
            if (this.EvaluationElementRatingLevelDescriptor != null && this.EvaluationElementRatingLevelDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for EvaluationElementRatingLevelDescriptor, length must be less than 306.", new [] { "EvaluationElementRatingLevelDescriptor" });
            }

            // EvaluationElementNumericRating (double) maximum
            if (this.EvaluationElementNumericRatingOption.IsSet && this.EvaluationElementNumericRatingOption.Value > (double)999.999)
            {
                yield return new ValidationResult("Invalid value for EvaluationElementNumericRating, must be a value less than or equal to 999.999.", new [] { "EvaluationElementNumericRating" });
            }

            // EvaluationElementNumericRating (double) minimum
            if (this.EvaluationElementNumericRatingOption.IsSet && this.EvaluationElementNumericRatingOption.Value < (double)-999.999)
            {
                yield return new ValidationResult("Invalid value for EvaluationElementNumericRating, must be a value greater than or equal to -999.999.", new [] { "EvaluationElementNumericRating" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiStudentProgramEvaluationStudentEvaluationElement" />
    /// </summary>
    public class EdFiStudentProgramEvaluationStudentEvaluationElementJsonConverter : JsonConverter<EdFiStudentProgramEvaluationStudentEvaluationElement>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiStudentProgramEvaluationStudentEvaluationElement" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiStudentProgramEvaluationStudentEvaluationElement Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<EdFiProgramEvaluationElementReference?> programEvaluationElementReference = default;
            Option<string?> evaluationElementRatingLevelDescriptor = default;
            Option<double?> evaluationElementNumericRating = default;
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
                        case "programEvaluationElementReference":
                            programEvaluationElementReference = new Option<EdFiProgramEvaluationElementReference?>(JsonSerializer.Deserialize<EdFiProgramEvaluationElementReference>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "evaluationElementRatingLevelDescriptor":
                            evaluationElementRatingLevelDescriptor = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "evaluationElementNumericRating":
                            evaluationElementNumericRating = new Option<double?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (double?)null : utf8JsonReader.GetDouble());
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!programEvaluationElementReference.IsSet)
                throw new ArgumentException("Property is required for class EdFiStudentProgramEvaluationStudentEvaluationElement.", nameof(programEvaluationElementReference));

            if (programEvaluationElementReference.IsSet && programEvaluationElementReference.Value == null)
                throw new ArgumentNullException(nameof(programEvaluationElementReference), "Property is not nullable for class EdFiStudentProgramEvaluationStudentEvaluationElement.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiStudentProgramEvaluationStudentEvaluationElement.");

            return new EdFiStudentProgramEvaluationStudentEvaluationElement(programEvaluationElementReference.Value!, evaluationElementRatingLevelDescriptor, evaluationElementNumericRating, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiStudentProgramEvaluationStudentEvaluationElement" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentProgramEvaluationStudentEvaluationElement"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiStudentProgramEvaluationStudentEvaluationElement edFiStudentProgramEvaluationStudentEvaluationElement, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiStudentProgramEvaluationStudentEvaluationElement, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiStudentProgramEvaluationStudentEvaluationElement" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentProgramEvaluationStudentEvaluationElement"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiStudentProgramEvaluationStudentEvaluationElement edFiStudentProgramEvaluationStudentEvaluationElement, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiStudentProgramEvaluationStudentEvaluationElement.ProgramEvaluationElementReference == null)
                throw new ArgumentNullException(nameof(edFiStudentProgramEvaluationStudentEvaluationElement.ProgramEvaluationElementReference), "Property is required for class EdFiStudentProgramEvaluationStudentEvaluationElement.");

            if (edFiStudentProgramEvaluationStudentEvaluationElement.ExtOption.IsSet && edFiStudentProgramEvaluationStudentEvaluationElement.Ext == null)
                throw new ArgumentNullException(nameof(edFiStudentProgramEvaluationStudentEvaluationElement.Ext), "Property is required for class EdFiStudentProgramEvaluationStudentEvaluationElement.");

            writer.WritePropertyName("programEvaluationElementReference");
            JsonSerializer.Serialize(writer, edFiStudentProgramEvaluationStudentEvaluationElement.ProgramEvaluationElementReference, jsonSerializerOptions);
            if (edFiStudentProgramEvaluationStudentEvaluationElement.EvaluationElementRatingLevelDescriptorOption.IsSet)
                if (edFiStudentProgramEvaluationStudentEvaluationElement.EvaluationElementRatingLevelDescriptorOption.Value != null)
                    writer.WriteString("evaluationElementRatingLevelDescriptor", edFiStudentProgramEvaluationStudentEvaluationElement.EvaluationElementRatingLevelDescriptor);
                else
                    writer.WriteNull("evaluationElementRatingLevelDescriptor");

            if (edFiStudentProgramEvaluationStudentEvaluationElement.EvaluationElementNumericRatingOption.IsSet)
                if (edFiStudentProgramEvaluationStudentEvaluationElement.EvaluationElementNumericRatingOption.Value != null)
                    writer.WriteNumber("evaluationElementNumericRating", edFiStudentProgramEvaluationStudentEvaluationElement.EvaluationElementNumericRatingOption.Value!.Value);
                else
                    writer.WriteNull("evaluationElementNumericRating");

            if (edFiStudentProgramEvaluationStudentEvaluationElement.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiStudentProgramEvaluationStudentEvaluationElement.Ext, jsonSerializerOptions);
            }
        }
    }
}
