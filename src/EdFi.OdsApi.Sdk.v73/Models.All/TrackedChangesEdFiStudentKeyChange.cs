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
    /// TrackedChangesEdFiStudentKeyChange
    /// </summary>
    public partial class TrackedChangesEdFiStudentKeyChange : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStudentKeyChange" /> class.
        /// </summary>
        /// <param name="id">Resource identifier</param>
        /// <param name="changeVersion">Change version</param>
        /// <param name="oldKeyValues">oldKeyValues</param>
        /// <param name="newKeyValues">newKeyValues</param>
        [JsonConstructor]
        public TrackedChangesEdFiStudentKeyChange(Option<string?> id = default, Option<decimal?> changeVersion = default, Option<TrackedChangesEdFiStudentKey?> oldKeyValues = default, Option<TrackedChangesEdFiStudentKey?> newKeyValues = default)
        {
            IdOption = id;
            ChangeVersionOption = changeVersion;
            OldKeyValuesOption = oldKeyValues;
            NewKeyValuesOption = newKeyValues;
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
        /// Used to track the state of OldKeyValues
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TrackedChangesEdFiStudentKey?> OldKeyValuesOption { get; private set; }

        /// <summary>
        /// Gets or Sets OldKeyValues
        /// </summary>
        [JsonPropertyName("oldKeyValues")]
        public TrackedChangesEdFiStudentKey? OldKeyValues { get { return this.OldKeyValuesOption; } set { this.OldKeyValuesOption = new(value); } }

        /// <summary>
        /// Used to track the state of NewKeyValues
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TrackedChangesEdFiStudentKey?> NewKeyValuesOption { get; private set; }

        /// <summary>
        /// Gets or Sets NewKeyValues
        /// </summary>
        [JsonPropertyName("newKeyValues")]
        public TrackedChangesEdFiStudentKey? NewKeyValues { get { return this.NewKeyValuesOption; } set { this.NewKeyValuesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiStudentKeyChange {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChangeVersion: ").Append(ChangeVersion).Append("\n");
            sb.Append("  OldKeyValues: ").Append(OldKeyValues).Append("\n");
            sb.Append("  NewKeyValues: ").Append(NewKeyValues).Append("\n");
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
    /// A Json converter for type <see cref="TrackedChangesEdFiStudentKeyChange" />
    /// </summary>
    public class TrackedChangesEdFiStudentKeyChangeJsonConverter : JsonConverter<TrackedChangesEdFiStudentKeyChange>
    {
        /// <summary>
        /// Deserializes json to <see cref="TrackedChangesEdFiStudentKeyChange" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TrackedChangesEdFiStudentKeyChange Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<decimal?> changeVersion = default;
            Option<TrackedChangesEdFiStudentKey?> oldKeyValues = default;
            Option<TrackedChangesEdFiStudentKey?> newKeyValues = default;

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
                        case "oldKeyValues":
                            oldKeyValues = new Option<TrackedChangesEdFiStudentKey?>(JsonSerializer.Deserialize<TrackedChangesEdFiStudentKey>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "newKeyValues":
                            newKeyValues = new Option<TrackedChangesEdFiStudentKey?>(JsonSerializer.Deserialize<TrackedChangesEdFiStudentKey>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class TrackedChangesEdFiStudentKeyChange.");

            if (changeVersion.IsSet && changeVersion.Value == null)
                throw new ArgumentNullException(nameof(changeVersion), "Property is not nullable for class TrackedChangesEdFiStudentKeyChange.");

            if (oldKeyValues.IsSet && oldKeyValues.Value == null)
                throw new ArgumentNullException(nameof(oldKeyValues), "Property is not nullable for class TrackedChangesEdFiStudentKeyChange.");

            if (newKeyValues.IsSet && newKeyValues.Value == null)
                throw new ArgumentNullException(nameof(newKeyValues), "Property is not nullable for class TrackedChangesEdFiStudentKeyChange.");

            return new TrackedChangesEdFiStudentKeyChange(id, changeVersion, oldKeyValues, newKeyValues);
        }

        /// <summary>
        /// Serializes a <see cref="TrackedChangesEdFiStudentKeyChange" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiStudentKeyChange"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TrackedChangesEdFiStudentKeyChange trackedChangesEdFiStudentKeyChange, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trackedChangesEdFiStudentKeyChange, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TrackedChangesEdFiStudentKeyChange" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiStudentKeyChange"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TrackedChangesEdFiStudentKeyChange trackedChangesEdFiStudentKeyChange, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trackedChangesEdFiStudentKeyChange.IdOption.IsSet && trackedChangesEdFiStudentKeyChange.Id == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStudentKeyChange.Id), "Property is required for class TrackedChangesEdFiStudentKeyChange.");

            if (trackedChangesEdFiStudentKeyChange.OldKeyValuesOption.IsSet && trackedChangesEdFiStudentKeyChange.OldKeyValues == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStudentKeyChange.OldKeyValues), "Property is required for class TrackedChangesEdFiStudentKeyChange.");

            if (trackedChangesEdFiStudentKeyChange.NewKeyValuesOption.IsSet && trackedChangesEdFiStudentKeyChange.NewKeyValues == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStudentKeyChange.NewKeyValues), "Property is required for class TrackedChangesEdFiStudentKeyChange.");

            if (trackedChangesEdFiStudentKeyChange.IdOption.IsSet)
                writer.WriteString("id", trackedChangesEdFiStudentKeyChange.Id);

            if (trackedChangesEdFiStudentKeyChange.ChangeVersionOption.IsSet)
                writer.WriteNumber("changeVersion", trackedChangesEdFiStudentKeyChange.ChangeVersionOption.Value!.Value);

            if (trackedChangesEdFiStudentKeyChange.OldKeyValuesOption.IsSet)
            {
                writer.WritePropertyName("oldKeyValues");
                JsonSerializer.Serialize(writer, trackedChangesEdFiStudentKeyChange.OldKeyValues, jsonSerializerOptions);
            }
            if (trackedChangesEdFiStudentKeyChange.NewKeyValuesOption.IsSet)
            {
                writer.WritePropertyName("newKeyValues");
                JsonSerializer.Serialize(writer, trackedChangesEdFiStudentKeyChange.NewKeyValues, jsonSerializerOptions);
            }
        }
    }
}
