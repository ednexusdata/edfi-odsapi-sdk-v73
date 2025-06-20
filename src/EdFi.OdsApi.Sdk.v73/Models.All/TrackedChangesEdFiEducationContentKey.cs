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
    /// TrackedChangesEdFiEducationContentKey
    /// </summary>
    public partial class TrackedChangesEdFiEducationContentKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiEducationContentKey" /> class.
        /// </summary>
        /// <param name="contentIdentifier">A unique identifier for the education content.</param>
        [JsonConstructor]
        public TrackedChangesEdFiEducationContentKey(Option<string?> contentIdentifier = default)
        {
            ContentIdentifierOption = contentIdentifier;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ContentIdentifier
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContentIdentifierOption { get; private set; }

        /// <summary>
        /// A unique identifier for the education content.
        /// </summary>
        /// <value>A unique identifier for the education content.</value>
        [JsonPropertyName("contentIdentifier")]
        public string? ContentIdentifier { get { return this.ContentIdentifierOption; } set { this.ContentIdentifierOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiEducationContentKey {\n");
            sb.Append("  ContentIdentifier: ").Append(ContentIdentifier).Append("\n");
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
            // ContentIdentifier (string) maxLength
            if (this.ContentIdentifier != null && this.ContentIdentifier.Length > 225)
            {
                yield return new ValidationResult("Invalid value for ContentIdentifier, length must be less than 225.", new [] { "ContentIdentifier" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TrackedChangesEdFiEducationContentKey" />
    /// </summary>
    public class TrackedChangesEdFiEducationContentKeyJsonConverter : JsonConverter<TrackedChangesEdFiEducationContentKey>
    {
        /// <summary>
        /// Deserializes json to <see cref="TrackedChangesEdFiEducationContentKey" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TrackedChangesEdFiEducationContentKey Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> contentIdentifier = default;

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
                        case "contentIdentifier":
                            contentIdentifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (contentIdentifier.IsSet && contentIdentifier.Value == null)
                throw new ArgumentNullException(nameof(contentIdentifier), "Property is not nullable for class TrackedChangesEdFiEducationContentKey.");

            return new TrackedChangesEdFiEducationContentKey(contentIdentifier);
        }

        /// <summary>
        /// Serializes a <see cref="TrackedChangesEdFiEducationContentKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiEducationContentKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TrackedChangesEdFiEducationContentKey trackedChangesEdFiEducationContentKey, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trackedChangesEdFiEducationContentKey, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TrackedChangesEdFiEducationContentKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiEducationContentKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TrackedChangesEdFiEducationContentKey trackedChangesEdFiEducationContentKey, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trackedChangesEdFiEducationContentKey.ContentIdentifierOption.IsSet && trackedChangesEdFiEducationContentKey.ContentIdentifier == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiEducationContentKey.ContentIdentifier), "Property is required for class TrackedChangesEdFiEducationContentKey.");

            if (trackedChangesEdFiEducationContentKey.ContentIdentifierOption.IsSet)
                writer.WriteString("contentIdentifier", trackedChangesEdFiEducationContentKey.ContentIdentifier);
        }
    }
}
