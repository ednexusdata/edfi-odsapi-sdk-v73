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
    /// TrackedChangesEdFiIndicatorLevelDescriptorDelete
    /// </summary>
    public partial class TrackedChangesEdFiIndicatorLevelDescriptorDelete : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiIndicatorLevelDescriptorDelete" /> class.
        /// </summary>
        /// <param name="id">Resource identifier</param>
        /// <param name="changeVersion">Change version</param>
        /// <param name="keyValues">keyValues</param>
        [JsonConstructor]
        public TrackedChangesEdFiIndicatorLevelDescriptorDelete(Option<string?> id = default, Option<decimal?> changeVersion = default, Option<TrackedChangesEdFiIndicatorLevelDescriptorKey?> keyValues = default)
        {
            IdOption = id;
            ChangeVersionOption = changeVersion;
            KeyValuesOption = keyValues;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IdOption { get; private set; }

        /// <summary>
        /// Resource identifier
        /// </summary>
        /// <value>Resource identifier</value>
        [JsonPropertyName("id")]
        public string? Id { get { return this.IdOption; } set { this.IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ChangeVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> ChangeVersionOption { get; private set; }

        /// <summary>
        /// Change version
        /// </summary>
        /// <value>Change version</value>
        [JsonPropertyName("changeVersion")]
        public decimal? ChangeVersion { get { return this.ChangeVersionOption; } set { this.ChangeVersionOption = new(value); } }

        /// <summary>
        /// Used to track the state of KeyValues
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TrackedChangesEdFiIndicatorLevelDescriptorKey?> KeyValuesOption { get; private set; }

        /// <summary>
        /// Gets or Sets KeyValues
        /// </summary>
        [JsonPropertyName("keyValues")]
        public TrackedChangesEdFiIndicatorLevelDescriptorKey? KeyValues { get { return this.KeyValuesOption; } set { this.KeyValuesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiIndicatorLevelDescriptorDelete {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChangeVersion: ").Append(ChangeVersion).Append("\n");
            sb.Append("  KeyValues: ").Append(KeyValues).Append("\n");
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
    /// A Json converter for type <see cref="TrackedChangesEdFiIndicatorLevelDescriptorDelete" />
    /// </summary>
    public class TrackedChangesEdFiIndicatorLevelDescriptorDeleteJsonConverter : JsonConverter<TrackedChangesEdFiIndicatorLevelDescriptorDelete>
    {
        /// <summary>
        /// Deserializes json to <see cref="TrackedChangesEdFiIndicatorLevelDescriptorDelete" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TrackedChangesEdFiIndicatorLevelDescriptorDelete Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<decimal?> changeVersion = default;
            Option<TrackedChangesEdFiIndicatorLevelDescriptorKey?> keyValues = default;

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
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "changeVersion":
                            changeVersion = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "keyValues":
                            keyValues = new Option<TrackedChangesEdFiIndicatorLevelDescriptorKey?>(JsonSerializer.Deserialize<TrackedChangesEdFiIndicatorLevelDescriptorKey>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class TrackedChangesEdFiIndicatorLevelDescriptorDelete.");

            if (changeVersion.IsSet && changeVersion.Value == null)
                throw new ArgumentNullException(nameof(changeVersion), "Property is not nullable for class TrackedChangesEdFiIndicatorLevelDescriptorDelete.");

            if (keyValues.IsSet && keyValues.Value == null)
                throw new ArgumentNullException(nameof(keyValues), "Property is not nullable for class TrackedChangesEdFiIndicatorLevelDescriptorDelete.");

            return new TrackedChangesEdFiIndicatorLevelDescriptorDelete(id, changeVersion, keyValues);
        }

        /// <summary>
        /// Serializes a <see cref="TrackedChangesEdFiIndicatorLevelDescriptorDelete" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiIndicatorLevelDescriptorDelete"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TrackedChangesEdFiIndicatorLevelDescriptorDelete trackedChangesEdFiIndicatorLevelDescriptorDelete, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trackedChangesEdFiIndicatorLevelDescriptorDelete, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TrackedChangesEdFiIndicatorLevelDescriptorDelete" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiIndicatorLevelDescriptorDelete"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TrackedChangesEdFiIndicatorLevelDescriptorDelete trackedChangesEdFiIndicatorLevelDescriptorDelete, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trackedChangesEdFiIndicatorLevelDescriptorDelete.IdOption.IsSet && trackedChangesEdFiIndicatorLevelDescriptorDelete.Id == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiIndicatorLevelDescriptorDelete.Id), "Property is required for class TrackedChangesEdFiIndicatorLevelDescriptorDelete.");

            if (trackedChangesEdFiIndicatorLevelDescriptorDelete.KeyValuesOption.IsSet && trackedChangesEdFiIndicatorLevelDescriptorDelete.KeyValues == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiIndicatorLevelDescriptorDelete.KeyValues), "Property is required for class TrackedChangesEdFiIndicatorLevelDescriptorDelete.");

            if (trackedChangesEdFiIndicatorLevelDescriptorDelete.IdOption.IsSet)
                writer.WriteString("id", trackedChangesEdFiIndicatorLevelDescriptorDelete.Id);

            if (trackedChangesEdFiIndicatorLevelDescriptorDelete.ChangeVersionOption.IsSet)
                writer.WriteNumber("changeVersion", trackedChangesEdFiIndicatorLevelDescriptorDelete.ChangeVersionOption.Value!.Value);

            if (trackedChangesEdFiIndicatorLevelDescriptorDelete.KeyValuesOption.IsSet)
            {
                writer.WritePropertyName("keyValues");
                JsonSerializer.Serialize(writer, trackedChangesEdFiIndicatorLevelDescriptorDelete.KeyValues, jsonSerializerOptions);
            }
        }
    }
}
