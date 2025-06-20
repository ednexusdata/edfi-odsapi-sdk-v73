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
    /// TrackedChangesEdFiCommunityOrganizationKey
    /// </summary>
    public partial class TrackedChangesEdFiCommunityOrganizationKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiCommunityOrganizationKey" /> class.
        /// </summary>
        /// <param name="communityOrganizationId">The identifier assigned to a community organization. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication.</param>
        [JsonConstructor]
        public TrackedChangesEdFiCommunityOrganizationKey(Option<long?> communityOrganizationId = default)
        {
            CommunityOrganizationIdOption = communityOrganizationId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CommunityOrganizationId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> CommunityOrganizationIdOption { get; private set; }

        /// <summary>
        /// The identifier assigned to a community organization. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication.
        /// </summary>
        /// <value>The identifier assigned to a community organization. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication.</value>
        [JsonPropertyName("communityOrganizationId")]
        public long? CommunityOrganizationId { get { return this.CommunityOrganizationIdOption; } set { this.CommunityOrganizationIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiCommunityOrganizationKey {\n");
            sb.Append("  CommunityOrganizationId: ").Append(CommunityOrganizationId).Append("\n");
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
    /// A Json converter for type <see cref="TrackedChangesEdFiCommunityOrganizationKey" />
    /// </summary>
    public class TrackedChangesEdFiCommunityOrganizationKeyJsonConverter : JsonConverter<TrackedChangesEdFiCommunityOrganizationKey>
    {
        /// <summary>
        /// Deserializes json to <see cref="TrackedChangesEdFiCommunityOrganizationKey" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TrackedChangesEdFiCommunityOrganizationKey Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> communityOrganizationId = default;

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
                        case "communityOrganizationId":
                            communityOrganizationId = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (communityOrganizationId.IsSet && communityOrganizationId.Value == null)
                throw new ArgumentNullException(nameof(communityOrganizationId), "Property is not nullable for class TrackedChangesEdFiCommunityOrganizationKey.");

            return new TrackedChangesEdFiCommunityOrganizationKey(communityOrganizationId);
        }

        /// <summary>
        /// Serializes a <see cref="TrackedChangesEdFiCommunityOrganizationKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiCommunityOrganizationKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TrackedChangesEdFiCommunityOrganizationKey trackedChangesEdFiCommunityOrganizationKey, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, trackedChangesEdFiCommunityOrganizationKey, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TrackedChangesEdFiCommunityOrganizationKey" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="trackedChangesEdFiCommunityOrganizationKey"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TrackedChangesEdFiCommunityOrganizationKey trackedChangesEdFiCommunityOrganizationKey, JsonSerializerOptions jsonSerializerOptions)
        {
            if (trackedChangesEdFiCommunityOrganizationKey.CommunityOrganizationIdOption.IsSet)
                writer.WriteNumber("communityOrganizationId", trackedChangesEdFiCommunityOrganizationKey.CommunityOrganizationIdOption.Value!.Value);
        }
    }
}
