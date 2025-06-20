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
    /// EdFiAssessmentReference
    /// </summary>
    public partial class EdFiAssessmentReference : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentReference" /> class.
        /// </summary>
        /// <param name="assessmentIdentifier">A unique number or alphanumeric code assigned to an assessment.</param>
        /// <param name="namespace">Namespace for the assessment.</param>
        /// <param name="link">link</param>
        [JsonConstructor]
        public EdFiAssessmentReference(string assessmentIdentifier, string @namespace, Option<Link?> link = default)
        {
            AssessmentIdentifier = assessmentIdentifier;
            Namespace = @namespace;
            LinkOption = link;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// A unique number or alphanumeric code assigned to an assessment.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an assessment.</value>
        [JsonPropertyName("assessmentIdentifier")]
        public string AssessmentIdentifier { get; set; }

        /// <summary>
        /// Namespace for the assessment.
        /// </summary>
        /// <value>Namespace for the assessment.</value>
        [JsonPropertyName("namespace")]
        public string Namespace { get; set; }

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
            sb.Append("class EdFiAssessmentReference {\n");
            sb.Append("  AssessmentIdentifier: ").Append(AssessmentIdentifier).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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
            // AssessmentIdentifier (string) maxLength
            if (this.AssessmentIdentifier != null && this.AssessmentIdentifier.Length > 60)
            {
                yield return new ValidationResult("Invalid value for AssessmentIdentifier, length must be less than 60.", new [] { "AssessmentIdentifier" });
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

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiAssessmentReference" />
    /// </summary>
    public class EdFiAssessmentReferenceJsonConverter : JsonConverter<EdFiAssessmentReference>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiAssessmentReference" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiAssessmentReference Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> assessmentIdentifier = default;
            Option<string?> varNamespace = default;
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
                        case "assessmentIdentifier":
                            assessmentIdentifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "namespace":
                            varNamespace = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "link":
                            link = new Option<Link?>(JsonSerializer.Deserialize<Link>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!assessmentIdentifier.IsSet)
                throw new ArgumentException("Property is required for class EdFiAssessmentReference.", nameof(assessmentIdentifier));

            if (!varNamespace.IsSet)
                throw new ArgumentException("Property is required for class EdFiAssessmentReference.", nameof(varNamespace));

            if (assessmentIdentifier.IsSet && assessmentIdentifier.Value == null)
                throw new ArgumentNullException(nameof(assessmentIdentifier), "Property is not nullable for class EdFiAssessmentReference.");

            if (varNamespace.IsSet && varNamespace.Value == null)
                throw new ArgumentNullException(nameof(varNamespace), "Property is not nullable for class EdFiAssessmentReference.");

            if (link.IsSet && link.Value == null)
                throw new ArgumentNullException(nameof(link), "Property is not nullable for class EdFiAssessmentReference.");

            return new EdFiAssessmentReference(assessmentIdentifier.Value!, varNamespace.Value!, link);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiAssessmentReference" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiAssessmentReference"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiAssessmentReference edFiAssessmentReference, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiAssessmentReference, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiAssessmentReference" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiAssessmentReference"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiAssessmentReference edFiAssessmentReference, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiAssessmentReference.AssessmentIdentifier == null)
                throw new ArgumentNullException(nameof(edFiAssessmentReference.AssessmentIdentifier), "Property is required for class EdFiAssessmentReference.");

            if (edFiAssessmentReference.Namespace == null)
                throw new ArgumentNullException(nameof(edFiAssessmentReference.Namespace), "Property is required for class EdFiAssessmentReference.");

            if (edFiAssessmentReference.LinkOption.IsSet && edFiAssessmentReference.Link == null)
                throw new ArgumentNullException(nameof(edFiAssessmentReference.Link), "Property is required for class EdFiAssessmentReference.");

            writer.WriteString("assessmentIdentifier", edFiAssessmentReference.AssessmentIdentifier);

            writer.WriteString("namespace", edFiAssessmentReference.Namespace);

            if (edFiAssessmentReference.LinkOption.IsSet)
            {
                writer.WritePropertyName("link");
                JsonSerializer.Serialize(writer, edFiAssessmentReference.Link, jsonSerializerOptions);
            }
        }
    }
}
