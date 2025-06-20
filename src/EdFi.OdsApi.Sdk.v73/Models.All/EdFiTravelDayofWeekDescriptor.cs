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
    /// EdFiTravelDayofWeekDescriptor
    /// </summary>
    public partial class EdFiTravelDayofWeekDescriptor : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiTravelDayofWeekDescriptor" /> class.
        /// </summary>
        /// <param name="codeValue">A code or abbreviation that is used to refer to the descriptor.</param>
        /// <param name="namespace">A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.</param>
        /// <param name="shortDescription">A shortened description for the descriptor.</param>
        /// <param name="id">id</param>
        /// <param name="description">The description of the descriptor.</param>
        /// <param name="effectiveBeginDate">The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.</param>
        /// <param name="effectiveEndDate">The end date of the period when the descriptor is in effect.</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource.</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified.</param>
        [JsonConstructor]
        public EdFiTravelDayofWeekDescriptor(string codeValue, string @namespace, string shortDescription, Option<string?> id = default, Option<string?> description = default, Option<DateOnly?> effectiveBeginDate = default, Option<DateOnly?> effectiveEndDate = default, Option<string?> etag = default, Option<DateTime?> lastModifiedDate = default)
        {
            CodeValue = codeValue;
            Namespace = @namespace;
            ShortDescription = shortDescription;
            IdOption = id;
            DescriptionOption = description;
            EffectiveBeginDateOption = effectiveBeginDate;
            EffectiveEndDateOption = effectiveEndDate;
            EtagOption = etag;
            LastModifiedDateOption = lastModifiedDate;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// A code or abbreviation that is used to refer to the descriptor.
        /// </summary>
        /// <value>A code or abbreviation that is used to refer to the descriptor.</value>
        [JsonPropertyName("codeValue")]
        public string CodeValue { get; set; }

        /// <summary>
        /// A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.
        /// </summary>
        /// <value>A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.</value>
        [JsonPropertyName("namespace")]
        public string Namespace { get; set; }

        /// <summary>
        /// A shortened description for the descriptor.
        /// </summary>
        /// <value>A shortened description for the descriptor.</value>
        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get { return this.IdOption; } set { this.IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DescriptionOption { get; private set; }

        /// <summary>
        /// The description of the descriptor.
        /// </summary>
        /// <value>The description of the descriptor.</value>
        [JsonPropertyName("description")]
        public string? Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of EffectiveBeginDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> EffectiveBeginDateOption { get; private set; }

        /// <summary>
        /// The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.
        /// </summary>
        /// <value>The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.</value>
        [JsonPropertyName("effectiveBeginDate")]
        public DateOnly? EffectiveBeginDate { get { return this.EffectiveBeginDateOption; } set { this.EffectiveBeginDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of EffectiveEndDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> EffectiveEndDateOption { get; private set; }

        /// <summary>
        /// The end date of the period when the descriptor is in effect.
        /// </summary>
        /// <value>The end date of the period when the descriptor is in effect.</value>
        [JsonPropertyName("effectiveEndDate")]
        public DateOnly? EffectiveEndDate { get { return this.EffectiveEndDateOption; } set { this.EffectiveEndDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of Etag
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EtagOption { get; private set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [JsonPropertyName("_etag")]
        public string? Etag { get { return this.EtagOption; } set { this.EtagOption = new(value); } }

        /// <summary>
        /// Used to track the state of LastModifiedDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastModifiedDateOption { get; private set; }

        /// <summary>
        /// The date and time the resource was last modified.
        /// </summary>
        /// <value>The date and time the resource was last modified.</value>
        [JsonPropertyName("_lastModifiedDate")]
        public DateTime? LastModifiedDate { get { return this.LastModifiedDateOption; } set { this.LastModifiedDateOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiTravelDayofWeekDescriptor {\n");
            sb.Append("  CodeValue: ").Append(CodeValue).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EffectiveBeginDate: ").Append(EffectiveBeginDate).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
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
            // CodeValue (string) maxLength
            if (this.CodeValue != null && this.CodeValue.Length > 50)
            {
                yield return new ValidationResult("Invalid value for CodeValue, length must be less than 50.", new [] { "CodeValue" });
            }

            // Namespace (string) maxLength
            if (this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            // ShortDescription (string) maxLength
            if (this.ShortDescription != null && this.ShortDescription.Length > 75)
            {
                yield return new ValidationResult("Invalid value for ShortDescription, length must be less than 75.", new [] { "ShortDescription" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiTravelDayofWeekDescriptor" />
    /// </summary>
    public class EdFiTravelDayofWeekDescriptorJsonConverter : JsonConverter<EdFiTravelDayofWeekDescriptor>
    {
        /// <summary>
        /// The format to use to serialize EffectiveBeginDate
        /// </summary>
        public static string EffectiveBeginDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize EffectiveEndDate
        /// </summary>
        public static string EffectiveEndDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize LastModifiedDate
        /// </summary>
        public static string LastModifiedDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="EdFiTravelDayofWeekDescriptor" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiTravelDayofWeekDescriptor Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> codeValue = default;
            Option<string?> varNamespace = default;
            Option<string?> shortDescription = default;
            Option<string?> id = default;
            Option<string?> description = default;
            Option<DateOnly?> effectiveBeginDate = default;
            Option<DateOnly?> effectiveEndDate = default;
            Option<string?> etag = default;
            Option<DateTime?> lastModifiedDate = default;

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
                        case "codeValue":
                            codeValue = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "namespace":
                            varNamespace = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "shortDescription":
                            shortDescription = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "description":
                            description = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "effectiveBeginDate":
                            effectiveBeginDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "effectiveEndDate":
                            effectiveEndDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "_etag":
                            etag = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "_lastModifiedDate":
                            lastModifiedDate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!codeValue.IsSet)
                throw new ArgumentException("Property is required for class EdFiTravelDayofWeekDescriptor.", nameof(codeValue));

            if (!varNamespace.IsSet)
                throw new ArgumentException("Property is required for class EdFiTravelDayofWeekDescriptor.", nameof(varNamespace));

            if (!shortDescription.IsSet)
                throw new ArgumentException("Property is required for class EdFiTravelDayofWeekDescriptor.", nameof(shortDescription));

            if (codeValue.IsSet && codeValue.Value == null)
                throw new ArgumentNullException(nameof(codeValue), "Property is not nullable for class EdFiTravelDayofWeekDescriptor.");

            if (varNamespace.IsSet && varNamespace.Value == null)
                throw new ArgumentNullException(nameof(varNamespace), "Property is not nullable for class EdFiTravelDayofWeekDescriptor.");

            if (shortDescription.IsSet && shortDescription.Value == null)
                throw new ArgumentNullException(nameof(shortDescription), "Property is not nullable for class EdFiTravelDayofWeekDescriptor.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class EdFiTravelDayofWeekDescriptor.");

            if (etag.IsSet && etag.Value == null)
                throw new ArgumentNullException(nameof(etag), "Property is not nullable for class EdFiTravelDayofWeekDescriptor.");

            if (lastModifiedDate.IsSet && lastModifiedDate.Value == null)
                throw new ArgumentNullException(nameof(lastModifiedDate), "Property is not nullable for class EdFiTravelDayofWeekDescriptor.");

            return new EdFiTravelDayofWeekDescriptor(codeValue.Value!, varNamespace.Value!, shortDescription.Value!, id, description, effectiveBeginDate, effectiveEndDate, etag, lastModifiedDate);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiTravelDayofWeekDescriptor" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiTravelDayofWeekDescriptor"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiTravelDayofWeekDescriptor edFiTravelDayofWeekDescriptor, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiTravelDayofWeekDescriptor, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiTravelDayofWeekDescriptor" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiTravelDayofWeekDescriptor"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiTravelDayofWeekDescriptor edFiTravelDayofWeekDescriptor, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiTravelDayofWeekDescriptor.CodeValue == null)
                throw new ArgumentNullException(nameof(edFiTravelDayofWeekDescriptor.CodeValue), "Property is required for class EdFiTravelDayofWeekDescriptor.");

            if (edFiTravelDayofWeekDescriptor.Namespace == null)
                throw new ArgumentNullException(nameof(edFiTravelDayofWeekDescriptor.Namespace), "Property is required for class EdFiTravelDayofWeekDescriptor.");

            if (edFiTravelDayofWeekDescriptor.ShortDescription == null)
                throw new ArgumentNullException(nameof(edFiTravelDayofWeekDescriptor.ShortDescription), "Property is required for class EdFiTravelDayofWeekDescriptor.");

            if (edFiTravelDayofWeekDescriptor.IdOption.IsSet && edFiTravelDayofWeekDescriptor.Id == null)
                throw new ArgumentNullException(nameof(edFiTravelDayofWeekDescriptor.Id), "Property is required for class EdFiTravelDayofWeekDescriptor.");

            if (edFiTravelDayofWeekDescriptor.EtagOption.IsSet && edFiTravelDayofWeekDescriptor.Etag == null)
                throw new ArgumentNullException(nameof(edFiTravelDayofWeekDescriptor.Etag), "Property is required for class EdFiTravelDayofWeekDescriptor.");

            writer.WriteString("codeValue", edFiTravelDayofWeekDescriptor.CodeValue);

            writer.WriteString("namespace", edFiTravelDayofWeekDescriptor.Namespace);

            writer.WriteString("shortDescription", edFiTravelDayofWeekDescriptor.ShortDescription);

            if (edFiTravelDayofWeekDescriptor.IdOption.IsSet)
                writer.WriteString("id", edFiTravelDayofWeekDescriptor.Id);

            if (edFiTravelDayofWeekDescriptor.DescriptionOption.IsSet)
                if (edFiTravelDayofWeekDescriptor.DescriptionOption.Value != null)
                    writer.WriteString("description", edFiTravelDayofWeekDescriptor.Description);
                else
                    writer.WriteNull("description");

            if (edFiTravelDayofWeekDescriptor.EffectiveBeginDateOption.IsSet)
                if (edFiTravelDayofWeekDescriptor.EffectiveBeginDateOption.Value != null)
                    writer.WriteString("effectiveBeginDate", edFiTravelDayofWeekDescriptor.EffectiveBeginDateOption.Value!.Value.ToString(EffectiveBeginDateFormat));
                else
                    writer.WriteNull("effectiveBeginDate");

            if (edFiTravelDayofWeekDescriptor.EffectiveEndDateOption.IsSet)
                if (edFiTravelDayofWeekDescriptor.EffectiveEndDateOption.Value != null)
                    writer.WriteString("effectiveEndDate", edFiTravelDayofWeekDescriptor.EffectiveEndDateOption.Value!.Value.ToString(EffectiveEndDateFormat));
                else
                    writer.WriteNull("effectiveEndDate");

            if (edFiTravelDayofWeekDescriptor.EtagOption.IsSet)
                writer.WriteString("_etag", edFiTravelDayofWeekDescriptor.Etag);

            if (edFiTravelDayofWeekDescriptor.LastModifiedDateOption.IsSet)
                writer.WriteString("_lastModifiedDate", edFiTravelDayofWeekDescriptor.LastModifiedDateOption.Value!.Value.ToString(LastModifiedDateFormat));
        }
    }
}
