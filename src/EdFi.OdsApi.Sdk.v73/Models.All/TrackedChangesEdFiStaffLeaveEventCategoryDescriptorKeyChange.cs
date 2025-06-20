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
    /// TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange
    /// </summary>
    public partial class TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange" /> class.
        /// </summary>
        /// <param name="id">Resource identifier</param>
        /// <param name="changeVersion">Change version</param>
        /// <param name="oldKeyValues">oldKeyValues</param>
        /// <param name="newKeyValues">newKeyValues</param>
        [JsonConstructor]
        public TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange(Option<string?> id = default, Option<decimal?> changeVersion = default, Option<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey?> oldKeyValues = default, Option<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey?> newKeyValues = default)
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
        public Option<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey?> OldKeyValuesOption { get; private set; }

        /// <summary>
        /// Gets or Sets OldKeyValues
        /// </summary>
        [JsonPropertyName("oldKeyValues")]
        public TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey? OldKeyValues { get { return this.OldKeyValuesOption; } set { this.OldKeyValuesOption = new(value); } }

        /// <summary>
        /// Used to track the state of NewKeyValues
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey?> NewKeyValuesOption { get; private set; }

        /// <summary>
        /// Gets or Sets NewKeyValues
        /// </summary>
        [JsonPropertyName("newKeyValues")]
        public TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey? NewKeyValues { get { return this.NewKeyValuesOption; } set { this.NewKeyValuesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange {\n");
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
    /// A Json converter for type <see cref="TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange" />
    /// </summary>
    public class TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChangeJsonConverter : JsonConverter<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange>
    {
        /// <summary>
        /// Deserializes json to <see cref="TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<decimal?> changeVersion = default;
            Option<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey?> oldKeyValues = default;
            Option<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey?> newKeyValues = default;

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
                            oldKeyValues = new Option<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey?>(JsonSerializer.Deserialize<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "newKeyValues":
                            newKeyValues = new Option<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey?>(JsonSerializer.Deserialize<TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKey>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.");

            if (changeVersion.IsSet && changeVersion.Value == null)
                throw new ArgumentNullException(nameof(changeVersion), "Property is not nullable for class TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.");

            if (oldKeyValues.IsSet && oldKeyValues.Value == null)
                throw new ArgumentNullException(nameof(oldKeyValues), "Property is not nullable for class TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.");

            if (newKeyValues.IsSet && newKeyValues.Value == null)
                throw new ArgumentNullException(nameof(newKeyValues), "Property is not nullable for class TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.");

            return new TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange(id, changeVersion, oldKeyValues, newKeyValues);
        }

        /// <summary>
        /// Serializes a <see cref="TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.IdOption.IsSet && trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.Id == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.Id), "Property is required for class TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.");

            if (trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.OldKeyValuesOption.IsSet && trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.OldKeyValues == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.OldKeyValues), "Property is required for class TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.");

            if (trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.NewKeyValuesOption.IsSet && trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.NewKeyValues == null)
                throw new ArgumentNullException(nameof(trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.NewKeyValues), "Property is required for class TrackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.");

            if (trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.IdOption.IsSet)
                writer.WriteString("id", trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.Id);

            if (trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.ChangeVersionOption.IsSet)
                writer.WriteNumber("changeVersion", trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.ChangeVersionOption.Value!.Value);

            if (trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.OldKeyValuesOption.IsSet)
            {
                writer.WritePropertyName("oldKeyValues");
                JsonSerializer.Serialize(writer, trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.OldKeyValues, jsonSerializerOptions);
            }
            if (trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.NewKeyValuesOption.IsSet)
            {
                writer.WritePropertyName("newKeyValues");
                JsonSerializer.Serialize(writer, trackedChangesEdFiStaffLeaveEventCategoryDescriptorKeyChange.NewKeyValues, jsonSerializerOptions);
            }
        }
    }
}
