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
    /// EdFiGradeLearningStandardGrade
    /// </summary>
    public partial class EdFiGradeLearningStandardGrade : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradeLearningStandardGrade" /> class.
        /// </summary>
        /// <param name="learningStandardReference">learningStandardReference</param>
        /// <param name="performanceBaseConversionDescriptor">A performance level that describes the student proficiency.</param>
        /// <param name="diagnosticStatement">A statement provided by the teacher that provides information in addition to the grade or assessment score.</param>
        /// <param name="letterGradeEarned">A final or interim (grading period) indicator of student performance for a learning standard as submitted by the instructor.</param>
        /// <param name="numericGradeEarned">A final or interim (grading period) indicator of student performance for a learning standard as submitted by the instructor.</param>
        /// <param name="ext">Extensions to the GradeLearningStandardGrade entity.</param>
        [JsonConstructor]
        public EdFiGradeLearningStandardGrade(EdFiLearningStandardReference learningStandardReference, Option<string?> performanceBaseConversionDescriptor = default, Option<string?> diagnosticStatement = default, Option<string?> letterGradeEarned = default, Option<double?> numericGradeEarned = default, Option<Object?> ext = default)
        {
            LearningStandardReference = learningStandardReference;
            PerformanceBaseConversionDescriptorOption = performanceBaseConversionDescriptor;
            DiagnosticStatementOption = diagnosticStatement;
            LetterGradeEarnedOption = letterGradeEarned;
            NumericGradeEarnedOption = numericGradeEarned;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets LearningStandardReference
        /// </summary>
        [JsonPropertyName("learningStandardReference")]
        public EdFiLearningStandardReference LearningStandardReference { get; set; }

        /// <summary>
        /// Used to track the state of PerformanceBaseConversionDescriptor
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PerformanceBaseConversionDescriptorOption { get; private set; }

        /// <summary>
        /// A performance level that describes the student proficiency.
        /// </summary>
        /// <value>A performance level that describes the student proficiency.</value>
        [JsonPropertyName("performanceBaseConversionDescriptor")]
        public string? PerformanceBaseConversionDescriptor { get { return this.PerformanceBaseConversionDescriptorOption; } set { this.PerformanceBaseConversionDescriptorOption = new(value); } }

        /// <summary>
        /// Used to track the state of DiagnosticStatement
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DiagnosticStatementOption { get; private set; }

        /// <summary>
        /// A statement provided by the teacher that provides information in addition to the grade or assessment score.
        /// </summary>
        /// <value>A statement provided by the teacher that provides information in addition to the grade or assessment score.</value>
        [JsonPropertyName("diagnosticStatement")]
        public string? DiagnosticStatement { get { return this.DiagnosticStatementOption; } set { this.DiagnosticStatementOption = new(value); } }

        /// <summary>
        /// Used to track the state of LetterGradeEarned
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LetterGradeEarnedOption { get; private set; }

        /// <summary>
        /// A final or interim (grading period) indicator of student performance for a learning standard as submitted by the instructor.
        /// </summary>
        /// <value>A final or interim (grading period) indicator of student performance for a learning standard as submitted by the instructor.</value>
        [JsonPropertyName("letterGradeEarned")]
        public string? LetterGradeEarned { get { return this.LetterGradeEarnedOption; } set { this.LetterGradeEarnedOption = new(value); } }

        /// <summary>
        /// Used to track the state of NumericGradeEarned
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> NumericGradeEarnedOption { get; private set; }

        /// <summary>
        /// A final or interim (grading period) indicator of student performance for a learning standard as submitted by the instructor.
        /// </summary>
        /// <value>A final or interim (grading period) indicator of student performance for a learning standard as submitted by the instructor.</value>
        [JsonPropertyName("numericGradeEarned")]
        public double? NumericGradeEarned { get { return this.NumericGradeEarnedOption; } set { this.NumericGradeEarnedOption = new(value); } }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the GradeLearningStandardGrade entity.
        /// </summary>
        /// <value>Extensions to the GradeLearningStandardGrade entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiGradeLearningStandardGrade {\n");
            sb.Append("  LearningStandardReference: ").Append(LearningStandardReference).Append("\n");
            sb.Append("  PerformanceBaseConversionDescriptor: ").Append(PerformanceBaseConversionDescriptor).Append("\n");
            sb.Append("  DiagnosticStatement: ").Append(DiagnosticStatement).Append("\n");
            sb.Append("  LetterGradeEarned: ").Append(LetterGradeEarned).Append("\n");
            sb.Append("  NumericGradeEarned: ").Append(NumericGradeEarned).Append("\n");
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
            // PerformanceBaseConversionDescriptor (string) maxLength
            if (this.PerformanceBaseConversionDescriptor != null && this.PerformanceBaseConversionDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for PerformanceBaseConversionDescriptor, length must be less than 306.", new [] { "PerformanceBaseConversionDescriptor" });
            }

            // DiagnosticStatement (string) maxLength
            if (this.DiagnosticStatement != null && this.DiagnosticStatement.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for DiagnosticStatement, length must be less than 1024.", new [] { "DiagnosticStatement" });
            }

            // LetterGradeEarned (string) maxLength
            if (this.LetterGradeEarned != null && this.LetterGradeEarned.Length > 20)
            {
                yield return new ValidationResult("Invalid value for LetterGradeEarned, length must be less than 20.", new [] { "LetterGradeEarned" });
            }

            // NumericGradeEarned (double) maximum
            if (this.NumericGradeEarnedOption.IsSet && this.NumericGradeEarnedOption.Value > (double)9999999.99)
            {
                yield return new ValidationResult("Invalid value for NumericGradeEarned, must be a value less than or equal to 9999999.99.", new [] { "NumericGradeEarned" });
            }

            // NumericGradeEarned (double) minimum
            if (this.NumericGradeEarnedOption.IsSet && this.NumericGradeEarnedOption.Value < (double)-9999999.99)
            {
                yield return new ValidationResult("Invalid value for NumericGradeEarned, must be a value greater than or equal to -9999999.99.", new [] { "NumericGradeEarned" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiGradeLearningStandardGrade" />
    /// </summary>
    public class EdFiGradeLearningStandardGradeJsonConverter : JsonConverter<EdFiGradeLearningStandardGrade>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiGradeLearningStandardGrade" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiGradeLearningStandardGrade Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<EdFiLearningStandardReference?> learningStandardReference = default;
            Option<string?> performanceBaseConversionDescriptor = default;
            Option<string?> diagnosticStatement = default;
            Option<string?> letterGradeEarned = default;
            Option<double?> numericGradeEarned = default;
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
                        case "learningStandardReference":
                            learningStandardReference = new Option<EdFiLearningStandardReference?>(JsonSerializer.Deserialize<EdFiLearningStandardReference>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "performanceBaseConversionDescriptor":
                            performanceBaseConversionDescriptor = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "diagnosticStatement":
                            diagnosticStatement = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "letterGradeEarned":
                            letterGradeEarned = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "numericGradeEarned":
                            numericGradeEarned = new Option<double?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (double?)null : utf8JsonReader.GetDouble());
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!learningStandardReference.IsSet)
                throw new ArgumentException("Property is required for class EdFiGradeLearningStandardGrade.", nameof(learningStandardReference));

            if (learningStandardReference.IsSet && learningStandardReference.Value == null)
                throw new ArgumentNullException(nameof(learningStandardReference), "Property is not nullable for class EdFiGradeLearningStandardGrade.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiGradeLearningStandardGrade.");

            return new EdFiGradeLearningStandardGrade(learningStandardReference.Value!, performanceBaseConversionDescriptor, diagnosticStatement, letterGradeEarned, numericGradeEarned, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiGradeLearningStandardGrade" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiGradeLearningStandardGrade"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiGradeLearningStandardGrade edFiGradeLearningStandardGrade, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiGradeLearningStandardGrade, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiGradeLearningStandardGrade" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiGradeLearningStandardGrade"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiGradeLearningStandardGrade edFiGradeLearningStandardGrade, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiGradeLearningStandardGrade.LearningStandardReference == null)
                throw new ArgumentNullException(nameof(edFiGradeLearningStandardGrade.LearningStandardReference), "Property is required for class EdFiGradeLearningStandardGrade.");

            if (edFiGradeLearningStandardGrade.ExtOption.IsSet && edFiGradeLearningStandardGrade.Ext == null)
                throw new ArgumentNullException(nameof(edFiGradeLearningStandardGrade.Ext), "Property is required for class EdFiGradeLearningStandardGrade.");

            writer.WritePropertyName("learningStandardReference");
            JsonSerializer.Serialize(writer, edFiGradeLearningStandardGrade.LearningStandardReference, jsonSerializerOptions);
            if (edFiGradeLearningStandardGrade.PerformanceBaseConversionDescriptorOption.IsSet)
                if (edFiGradeLearningStandardGrade.PerformanceBaseConversionDescriptorOption.Value != null)
                    writer.WriteString("performanceBaseConversionDescriptor", edFiGradeLearningStandardGrade.PerformanceBaseConversionDescriptor);
                else
                    writer.WriteNull("performanceBaseConversionDescriptor");

            if (edFiGradeLearningStandardGrade.DiagnosticStatementOption.IsSet)
                if (edFiGradeLearningStandardGrade.DiagnosticStatementOption.Value != null)
                    writer.WriteString("diagnosticStatement", edFiGradeLearningStandardGrade.DiagnosticStatement);
                else
                    writer.WriteNull("diagnosticStatement");

            if (edFiGradeLearningStandardGrade.LetterGradeEarnedOption.IsSet)
                if (edFiGradeLearningStandardGrade.LetterGradeEarnedOption.Value != null)
                    writer.WriteString("letterGradeEarned", edFiGradeLearningStandardGrade.LetterGradeEarned);
                else
                    writer.WriteNull("letterGradeEarned");

            if (edFiGradeLearningStandardGrade.NumericGradeEarnedOption.IsSet)
                if (edFiGradeLearningStandardGrade.NumericGradeEarnedOption.Value != null)
                    writer.WriteNumber("numericGradeEarned", edFiGradeLearningStandardGrade.NumericGradeEarnedOption.Value!.Value);
                else
                    writer.WriteNull("numericGradeEarned");

            if (edFiGradeLearningStandardGrade.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiGradeLearningStandardGrade.Ext, jsonSerializerOptions);
            }
        }
    }
}
