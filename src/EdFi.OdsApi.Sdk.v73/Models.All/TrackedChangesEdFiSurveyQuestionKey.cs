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
    /// TrackedChangesEdFiSurveyQuestionKey
    /// </summary>
    public partial class TrackedChangesEdFiSurveyQuestionKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiSurveyQuestionKey" /> class.
        /// </summary>
        /// <param name="questionCode">The identifying code for the question, unique for the survey.</param>
        /// <param name="namespace">Namespace for the survey.</param>
        /// <param name="surveyIdentifier">The unique survey identifier from the survey tool.</param>
        [JsonConstructor]
        public TrackedChangesEdFiSurveyQuestionKey(Option<string?> questionCode = default, Option<string?> @namespace = default, Option<string?> surveyIdentifier = default)
        {
            QuestionCodeOption = questionCode;
            NamespaceOption = @namespace;
            SurveyIdentifierOption = surveyIdentifier;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of QuestionCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> QuestionCodeOption { get; private set; }

        /// <summary>
        /// The identifying code for the question, unique for the survey.
        /// </summary>
        /// <value>The identifying code for the question, unique for the survey.</value>
        [JsonPropertyName("questionCode")]
        public string? QuestionCode { get { return this.QuestionCodeOption; } set { this.QuestionCodeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Namespace
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NamespaceOption { get; private set; }

        /// <summary>
        /// Namespace for the survey.
        /// </summary>
        /// <value>Namespace for the survey.</value>
        [JsonPropertyName("namespace")]
        public string? Namespace { get { return this.NamespaceOption; } set { this.NamespaceOption = new(value); } }

        /// <summary>
        /// Used to track the state of SurveyIdentifier
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SurveyIdentifierOption { get; private set; }

        /// <summary>
        /// The unique survey identifier from the survey tool.
        /// </summary>
        /// <value>The unique survey identifier from the survey tool.</value>
        [JsonPropertyName("surveyIdentifier")]
        public string? SurveyIdentifier { get { return this.SurveyIdentifierOption; } set { this.SurveyIdentifierOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiSurveyQuestionKey {\n");
            sb.Append("  QuestionCode: ").Append(QuestionCode).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  SurveyIdentifier: ").Append(SurveyIdentifier).Append("\n");
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
            // QuestionCode (string) maxLength
            if (this.QuestionCode != null && this.QuestionCode.Length > 60)
            {
                yield return new ValidationResult("Invalid value for QuestionCode, length must be less than 60.", new [] { "QuestionCode" });
            }

            // Namespace (string) maxLength
            if (this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            // Namespace (string) minLength
            if (this.Namespace != null && this.Namespace.Length < 5)
            {
                yield return new ValidationResult("Invalid value for Namespace, length must be greater than 5.", new [] { "Namespace" });
            }

            // SurveyIdentifier (string) maxLength
            if (this.SurveyIdentifier != null && this.SurveyIdentifier.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SurveyIdentifier, length must be less than 60.", new [] { "SurveyIdentifier" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TrackedChangesEdFiSurveyQuestionKey" />
    /// </summary>
    public class TrackedChangesEdFiSurveyQuestionKeyJsonConverter : JsonConverter<TrackedChangesEdFiSurveyQuestionKey>
    {
        /// <summary>
        /// Deserializes json to <see cref="TrackedChangesEdFiSurveyQuestionKey" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TrackedChangesEdFiSurveyQuestionKey Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> questionCode = default;
            Option<string?> varNamespace = default;
            Option<string?> surveyIdentifier = default;

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
                        case "questionCode":
                            questionCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "namespace":
                            varNamespace = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "surveyIdentifier":
                            surveyIdentifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (questionCode.IsSet && questionCode.Value == null)
                throw new ArgumentNullException(nameof(questionCode), "Property is not nullable for class TrackedChangesEdFiSurveyQuestionKey.");

            if (varNamespace.IsSet && varNamespace.Value == null)
                throw new ArgumentNullException(nameof(varNamespace), "Property is not nullable for class TrackedChangesEdFiSurveyQuestionKey.");

            if (surveyIdentifier.IsSet && surveyIdentifier.Value == null)
                throw new ArgumentNullException(nameof(surveyIdentifier), "Property is not nullable for class TrackedChangesEdFiSurveyQuestionKey.");

            return new TrackedChangesEdFiSurveyQuestionKey(questionCode, varNamespace, surveyIdentifier);
        }

        /// <summary>
        /// Serializes a <see cref="TrackedChangesEdFiSurveyQuestionKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiSurveyQuestionKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TrackedChangesEdFiSurveyQuestionKey trackedChangesEdFiSurveyQuestionKey, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trackedChangesEdFiSurveyQuestionKey, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TrackedChangesEdFiSurveyQuestionKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiSurveyQuestionKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TrackedChangesEdFiSurveyQuestionKey trackedChangesEdFiSurveyQuestionKey, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trackedChangesEdFiSurveyQuestionKey.QuestionCodeOption.IsSet && trackedChangesEdFiSurveyQuestionKey.QuestionCode == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiSurveyQuestionKey.QuestionCode), "Property is required for class TrackedChangesEdFiSurveyQuestionKey.");

            if (trackedChangesEdFiSurveyQuestionKey.NamespaceOption.IsSet && trackedChangesEdFiSurveyQuestionKey.Namespace == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiSurveyQuestionKey.Namespace), "Property is required for class TrackedChangesEdFiSurveyQuestionKey.");

            if (trackedChangesEdFiSurveyQuestionKey.SurveyIdentifierOption.IsSet && trackedChangesEdFiSurveyQuestionKey.SurveyIdentifier == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiSurveyQuestionKey.SurveyIdentifier), "Property is required for class TrackedChangesEdFiSurveyQuestionKey.");

            if (trackedChangesEdFiSurveyQuestionKey.QuestionCodeOption.IsSet)
                writer.WriteString("questionCode", trackedChangesEdFiSurveyQuestionKey.QuestionCode);

            if (trackedChangesEdFiSurveyQuestionKey.NamespaceOption.IsSet)
                writer.WriteString("namespace", trackedChangesEdFiSurveyQuestionKey.Namespace);

            if (trackedChangesEdFiSurveyQuestionKey.SurveyIdentifierOption.IsSet)
                writer.WriteString("surveyIdentifier", trackedChangesEdFiSurveyQuestionKey.SurveyIdentifier);
        }
    }
}
