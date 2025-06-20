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
    /// EdFiSurveyQuestionMatrix
    /// </summary>
    public partial class EdFiSurveyQuestionMatrix : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyQuestionMatrix" /> class.
        /// </summary>
        /// <param name="matrixElement">For matrix questions, the text identifying each row of the matrix.</param>
        /// <param name="maxRawScore">The maximum score possible on a survey.</param>
        /// <param name="minRawScore">The minimum score possible on a survey.</param>
        /// <param name="ext">Extensions to the SurveyQuestionMatrix entity.</param>
        [JsonConstructor]
        public EdFiSurveyQuestionMatrix(string matrixElement, Option<int?> maxRawScore = default, Option<int?> minRawScore = default, Option<Object?> ext = default)
        {
            MatrixElement = matrixElement;
            MaxRawScoreOption = maxRawScore;
            MinRawScoreOption = minRawScore;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// For matrix questions, the text identifying each row of the matrix.
        /// </summary>
        /// <value>For matrix questions, the text identifying each row of the matrix.</value>
        [JsonPropertyName("matrixElement")]
        public string MatrixElement { get; set; }

        /// <summary>
        /// Used to track the state of MaxRawScore
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> MaxRawScoreOption { get; private set; }

        /// <summary>
        /// The maximum score possible on a survey.
        /// </summary>
        /// <value>The maximum score possible on a survey.</value>
        [JsonPropertyName("maxRawScore")]
        public int? MaxRawScore { get { return this.MaxRawScoreOption; } set { this.MaxRawScoreOption = new(value); } }

        /// <summary>
        /// Used to track the state of MinRawScore
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> MinRawScoreOption { get; private set; }

        /// <summary>
        /// The minimum score possible on a survey.
        /// </summary>
        /// <value>The minimum score possible on a survey.</value>
        [JsonPropertyName("minRawScore")]
        public int? MinRawScore { get { return this.MinRawScoreOption; } set { this.MinRawScoreOption = new(value); } }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the SurveyQuestionMatrix entity.
        /// </summary>
        /// <value>Extensions to the SurveyQuestionMatrix entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiSurveyQuestionMatrix {\n");
            sb.Append("  MatrixElement: ").Append(MatrixElement).Append("\n");
            sb.Append("  MaxRawScore: ").Append(MaxRawScore).Append("\n");
            sb.Append("  MinRawScore: ").Append(MinRawScore).Append("\n");
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
            // MatrixElement (string) maxLength
            if (this.MatrixElement != null && this.MatrixElement.Length > 255)
            {
                yield return new ValidationResult("Invalid value for MatrixElement, length must be less than 255.", new [] { "MatrixElement" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiSurveyQuestionMatrix" />
    /// </summary>
    public class EdFiSurveyQuestionMatrixJsonConverter : JsonConverter<EdFiSurveyQuestionMatrix>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiSurveyQuestionMatrix" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiSurveyQuestionMatrix Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> matrixElement = default;
            Option<int?> maxRawScore = default;
            Option<int?> minRawScore = default;
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
                        case "matrixElement":
                            matrixElement = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "maxRawScore":
                            maxRawScore = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "minRawScore":
                            minRawScore = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!matrixElement.IsSet)
                throw new ArgumentException("Property is required for class EdFiSurveyQuestionMatrix.", nameof(matrixElement));

            if (matrixElement.IsSet && matrixElement.Value == null)
                throw new ArgumentNullException(nameof(matrixElement), "Property is not nullable for class EdFiSurveyQuestionMatrix.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiSurveyQuestionMatrix.");

            return new EdFiSurveyQuestionMatrix(matrixElement.Value!, maxRawScore, minRawScore, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiSurveyQuestionMatrix" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiSurveyQuestionMatrix"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiSurveyQuestionMatrix edFiSurveyQuestionMatrix, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiSurveyQuestionMatrix, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiSurveyQuestionMatrix" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiSurveyQuestionMatrix"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiSurveyQuestionMatrix edFiSurveyQuestionMatrix, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiSurveyQuestionMatrix.MatrixElement == null)
                throw new ArgumentNullException(nameof(edFiSurveyQuestionMatrix.MatrixElement), "Property is required for class EdFiSurveyQuestionMatrix.");

            if (edFiSurveyQuestionMatrix.ExtOption.IsSet && edFiSurveyQuestionMatrix.Ext == null)
                throw new ArgumentNullException(nameof(edFiSurveyQuestionMatrix.Ext), "Property is required for class EdFiSurveyQuestionMatrix.");

            writer.WriteString("matrixElement", edFiSurveyQuestionMatrix.MatrixElement);

            if (edFiSurveyQuestionMatrix.MaxRawScoreOption.IsSet)
                if (edFiSurveyQuestionMatrix.MaxRawScoreOption.Value != null)
                    writer.WriteNumber("maxRawScore", edFiSurveyQuestionMatrix.MaxRawScoreOption.Value!.Value);
                else
                    writer.WriteNull("maxRawScore");

            if (edFiSurveyQuestionMatrix.MinRawScoreOption.IsSet)
                if (edFiSurveyQuestionMatrix.MinRawScoreOption.Value != null)
                    writer.WriteNumber("minRawScore", edFiSurveyQuestionMatrix.MinRawScoreOption.Value!.Value);
                else
                    writer.WriteNull("minRawScore");

            if (edFiSurveyQuestionMatrix.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiSurveyQuestionMatrix.Ext, jsonSerializerOptions);
            }
        }
    }
}
