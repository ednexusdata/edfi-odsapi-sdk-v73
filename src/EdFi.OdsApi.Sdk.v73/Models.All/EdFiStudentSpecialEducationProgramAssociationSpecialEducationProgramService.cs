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
    /// EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService
    /// </summary>
    public partial class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService" /> class.
        /// </summary>
        /// <param name="specialEducationProgramServiceDescriptor">Indicates the service being provided to the student by the special education program.</param>
        /// <param name="primaryIndicator">True if service is a primary service.</param>
        /// <param name="serviceBeginDate">First date the student was in this option for the current school year.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.</param>
        /// <param name="serviceEndDate">Last date the student was in this option for the current school year.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.</param>
        /// <param name="providers">An unordered collection of studentSpecialEducationProgramAssociationSpecialEducationProgramServiceProviders. The staff providing the service to the student.</param>
        /// <param name="ext">Extensions to the StudentSpecialEducationProgramAssociationSpecialEducationProgramService entity.</param>
        [JsonConstructor]
        public EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService(string specialEducationProgramServiceDescriptor, Option<bool?> primaryIndicator = default, Option<DateOnly?> serviceBeginDate = default, Option<DateOnly?> serviceEndDate = default, Option<List<EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider>?> providers = default, Option<Object?> ext = default)
        {
            SpecialEducationProgramServiceDescriptor = specialEducationProgramServiceDescriptor;
            PrimaryIndicatorOption = primaryIndicator;
            ServiceBeginDateOption = serviceBeginDate;
            ServiceEndDateOption = serviceEndDate;
            ProvidersOption = providers;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Indicates the service being provided to the student by the special education program.
        /// </summary>
        /// <value>Indicates the service being provided to the student by the special education program.</value>
        [JsonPropertyName("specialEducationProgramServiceDescriptor")]
        public string SpecialEducationProgramServiceDescriptor { get; set; }

        /// <summary>
        /// Used to track the state of PrimaryIndicator
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> PrimaryIndicatorOption { get; private set; }

        /// <summary>
        /// True if service is a primary service.
        /// </summary>
        /// <value>True if service is a primary service.</value>
        [JsonPropertyName("primaryIndicator")]
        public bool? PrimaryIndicator { get { return this.PrimaryIndicatorOption; } set { this.PrimaryIndicatorOption = new(value); } }

        /// <summary>
        /// Used to track the state of ServiceBeginDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> ServiceBeginDateOption { get; private set; }

        /// <summary>
        /// First date the student was in this option for the current school year.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.
        /// </summary>
        /// <value>First date the student was in this option for the current school year.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.</value>
        [JsonPropertyName("serviceBeginDate")]
        public DateOnly? ServiceBeginDate { get { return this.ServiceBeginDateOption; } set { this.ServiceBeginDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of ServiceEndDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> ServiceEndDateOption { get; private set; }

        /// <summary>
        /// Last date the student was in this option for the current school year.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.
        /// </summary>
        /// <value>Last date the student was in this option for the current school year.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.</value>
        [JsonPropertyName("serviceEndDate")]
        public DateOnly? ServiceEndDate { get { return this.ServiceEndDateOption; } set { this.ServiceEndDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of Providers
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider>?> ProvidersOption { get; private set; }

        /// <summary>
        /// An unordered collection of studentSpecialEducationProgramAssociationSpecialEducationProgramServiceProviders. The staff providing the service to the student.
        /// </summary>
        /// <value>An unordered collection of studentSpecialEducationProgramAssociationSpecialEducationProgramServiceProviders. The staff providing the service to the student.</value>
        [JsonPropertyName("providers")]
        public List<EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider>? Providers { get { return this.ProvidersOption; } set { this.ProvidersOption = new(value); } }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the StudentSpecialEducationProgramAssociationSpecialEducationProgramService entity.
        /// </summary>
        /// <value>Extensions to the StudentSpecialEducationProgramAssociationSpecialEducationProgramService entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService {\n");
            sb.Append("  SpecialEducationProgramServiceDescriptor: ").Append(SpecialEducationProgramServiceDescriptor).Append("\n");
            sb.Append("  PrimaryIndicator: ").Append(PrimaryIndicator).Append("\n");
            sb.Append("  ServiceBeginDate: ").Append(ServiceBeginDate).Append("\n");
            sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
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
            // SpecialEducationProgramServiceDescriptor (string) maxLength
            if (this.SpecialEducationProgramServiceDescriptor != null && this.SpecialEducationProgramServiceDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for SpecialEducationProgramServiceDescriptor, length must be less than 306.", new [] { "SpecialEducationProgramServiceDescriptor" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService" />
    /// </summary>
    public class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceJsonConverter : JsonConverter<EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService>
    {
        /// <summary>
        /// The format to use to serialize ServiceBeginDate
        /// </summary>
        public static string ServiceBeginDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize ServiceEndDate
        /// </summary>
        public static string ServiceEndDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> specialEducationProgramServiceDescriptor = default;
            Option<bool?> primaryIndicator = default;
            Option<DateOnly?> serviceBeginDate = default;
            Option<DateOnly?> serviceEndDate = default;
            Option<List<EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider>?> providers = default;
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
                        case "specialEducationProgramServiceDescriptor":
                            specialEducationProgramServiceDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "primaryIndicator":
                            primaryIndicator = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "serviceBeginDate":
                            serviceBeginDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "serviceEndDate":
                            serviceEndDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "providers":
                            providers = new Option<List<EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider>?>(JsonSerializer.Deserialize<List<EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!specialEducationProgramServiceDescriptor.IsSet)
                throw new ArgumentException("Property is required for class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.", nameof(specialEducationProgramServiceDescriptor));

            if (specialEducationProgramServiceDescriptor.IsSet && specialEducationProgramServiceDescriptor.Value == null)
                throw new ArgumentNullException(nameof(specialEducationProgramServiceDescriptor), "Property is not nullable for class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.");

            if (providers.IsSet && providers.Value == null)
                throw new ArgumentNullException(nameof(providers), "Property is not nullable for class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.");

            return new EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService(specialEducationProgramServiceDescriptor.Value!, primaryIndicator, serviceBeginDate, serviceEndDate, providers, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.SpecialEducationProgramServiceDescriptor == null)
                throw new ArgumentNullException(nameof(edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.SpecialEducationProgramServiceDescriptor), "Property is required for class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.");

            if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.ProvidersOption.IsSet && edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.Providers == null)
                throw new ArgumentNullException(nameof(edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.Providers), "Property is required for class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.");

            if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.ExtOption.IsSet && edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.Ext == null)
                throw new ArgumentNullException(nameof(edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.Ext), "Property is required for class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.");

            writer.WriteString("specialEducationProgramServiceDescriptor", edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.SpecialEducationProgramServiceDescriptor);

            if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.PrimaryIndicatorOption.IsSet)
                if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.PrimaryIndicatorOption.Value != null)
                    writer.WriteBoolean("primaryIndicator", edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.PrimaryIndicatorOption.Value!.Value);
                else
                    writer.WriteNull("primaryIndicator");

            if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.ServiceBeginDateOption.IsSet)
                if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.ServiceBeginDateOption.Value != null)
                    writer.WriteString("serviceBeginDate", edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.ServiceBeginDateOption.Value!.Value.ToString(ServiceBeginDateFormat));
                else
                    writer.WriteNull("serviceBeginDate");

            if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.ServiceEndDateOption.IsSet)
                if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.ServiceEndDateOption.Value != null)
                    writer.WriteString("serviceEndDate", edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.ServiceEndDateOption.Value!.Value.ToString(ServiceEndDateFormat));
                else
                    writer.WriteNull("serviceEndDate");

            if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.ProvidersOption.IsSet)
            {
                writer.WritePropertyName("providers");
                JsonSerializer.Serialize(writer, edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.Providers, jsonSerializerOptions);
            }
            if (edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.Ext, jsonSerializerOptions);
            }
        }
    }
}
