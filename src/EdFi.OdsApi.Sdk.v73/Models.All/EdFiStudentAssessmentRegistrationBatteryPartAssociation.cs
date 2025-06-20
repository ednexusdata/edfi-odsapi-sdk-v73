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
    /// EdFiStudentAssessmentRegistrationBatteryPartAssociation
    /// </summary>
    public partial class EdFiStudentAssessmentRegistrationBatteryPartAssociation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentRegistrationBatteryPartAssociation" /> class.
        /// </summary>
        /// <param name="assessmentBatteryPartReference">assessmentBatteryPartReference</param>
        /// <param name="studentAssessmentRegistrationReference">studentAssessmentRegistrationReference</param>
        /// <param name="id">id</param>
        /// <param name="accommodations">An unordered collection of studentAssessmentRegistrationBatteryPartAssociationAccommodations. The special variation(s) to be used for the specific part of the assessment battery on how is presented, how it is administered, or how the test taker is allowed to respond.</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource.</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified.</param>
        /// <param name="ext">Extensions to the StudentAssessmentRegistrationBatteryPartAssociation entity.</param>
        [JsonConstructor]
        public EdFiStudentAssessmentRegistrationBatteryPartAssociation(EdFiAssessmentBatteryPartReference assessmentBatteryPartReference, EdFiStudentAssessmentRegistrationReference studentAssessmentRegistrationReference, Option<string?> id = default, Option<List<EdFiStudentAssessmentRegistrationBatteryPartAssociationAccommodation>?> accommodations = default, Option<string?> etag = default, Option<DateTime?> lastModifiedDate = default, Option<Object?> ext = default)
        {
            AssessmentBatteryPartReference = assessmentBatteryPartReference;
            StudentAssessmentRegistrationReference = studentAssessmentRegistrationReference;
            IdOption = id;
            AccommodationsOption = accommodations;
            EtagOption = etag;
            LastModifiedDateOption = lastModifiedDate;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets AssessmentBatteryPartReference
        /// </summary>
        [JsonPropertyName("assessmentBatteryPartReference")]
        public EdFiAssessmentBatteryPartReference AssessmentBatteryPartReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentAssessmentRegistrationReference
        /// </summary>
        [JsonPropertyName("studentAssessmentRegistrationReference")]
        public EdFiStudentAssessmentRegistrationReference StudentAssessmentRegistrationReference { get; set; }

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
        /// Used to track the state of Accommodations
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<EdFiStudentAssessmentRegistrationBatteryPartAssociationAccommodation>?> AccommodationsOption { get; private set; }

        /// <summary>
        /// An unordered collection of studentAssessmentRegistrationBatteryPartAssociationAccommodations. The special variation(s) to be used for the specific part of the assessment battery on how is presented, how it is administered, or how the test taker is allowed to respond.
        /// </summary>
        /// <value>An unordered collection of studentAssessmentRegistrationBatteryPartAssociationAccommodations. The special variation(s) to be used for the specific part of the assessment battery on how is presented, how it is administered, or how the test taker is allowed to respond.</value>
        [JsonPropertyName("accommodations")]
        public List<EdFiStudentAssessmentRegistrationBatteryPartAssociationAccommodation>? Accommodations { get { return this.AccommodationsOption; } set { this.AccommodationsOption = new(value); } }

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
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the StudentAssessmentRegistrationBatteryPartAssociation entity.
        /// </summary>
        /// <value>Extensions to the StudentAssessmentRegistrationBatteryPartAssociation entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentAssessmentRegistrationBatteryPartAssociation {\n");
            sb.Append("  AssessmentBatteryPartReference: ").Append(AssessmentBatteryPartReference).Append("\n");
            sb.Append("  StudentAssessmentRegistrationReference: ").Append(StudentAssessmentRegistrationReference).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Accommodations: ").Append(Accommodations).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
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
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiStudentAssessmentRegistrationBatteryPartAssociation" />
    /// </summary>
    public class EdFiStudentAssessmentRegistrationBatteryPartAssociationJsonConverter : JsonConverter<EdFiStudentAssessmentRegistrationBatteryPartAssociation>
    {
        /// <summary>
        /// The format to use to serialize LastModifiedDate
        /// </summary>
        public static string LastModifiedDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="EdFiStudentAssessmentRegistrationBatteryPartAssociation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiStudentAssessmentRegistrationBatteryPartAssociation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<EdFiAssessmentBatteryPartReference?> assessmentBatteryPartReference = default;
            Option<EdFiStudentAssessmentRegistrationReference?> studentAssessmentRegistrationReference = default;
            Option<string?> id = default;
            Option<List<EdFiStudentAssessmentRegistrationBatteryPartAssociationAccommodation>?> accommodations = default;
            Option<string?> etag = default;
            Option<DateTime?> lastModifiedDate = default;
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
                        case "assessmentBatteryPartReference":
                            assessmentBatteryPartReference = new Option<EdFiAssessmentBatteryPartReference?>(JsonSerializer.Deserialize<EdFiAssessmentBatteryPartReference>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "studentAssessmentRegistrationReference":
                            studentAssessmentRegistrationReference = new Option<EdFiStudentAssessmentRegistrationReference?>(JsonSerializer.Deserialize<EdFiStudentAssessmentRegistrationReference>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "accommodations":
                            accommodations = new Option<List<EdFiStudentAssessmentRegistrationBatteryPartAssociationAccommodation>?>(JsonSerializer.Deserialize<List<EdFiStudentAssessmentRegistrationBatteryPartAssociationAccommodation>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "_etag":
                            etag = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "_lastModifiedDate":
                            lastModifiedDate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!assessmentBatteryPartReference.IsSet)
                throw new ArgumentException("Property is required for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.", nameof(assessmentBatteryPartReference));

            if (!studentAssessmentRegistrationReference.IsSet)
                throw new ArgumentException("Property is required for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.", nameof(studentAssessmentRegistrationReference));

            if (assessmentBatteryPartReference.IsSet && assessmentBatteryPartReference.Value == null)
                throw new ArgumentNullException(nameof(assessmentBatteryPartReference), "Property is not nullable for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (studentAssessmentRegistrationReference.IsSet && studentAssessmentRegistrationReference.Value == null)
                throw new ArgumentNullException(nameof(studentAssessmentRegistrationReference), "Property is not nullable for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (accommodations.IsSet && accommodations.Value == null)
                throw new ArgumentNullException(nameof(accommodations), "Property is not nullable for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (etag.IsSet && etag.Value == null)
                throw new ArgumentNullException(nameof(etag), "Property is not nullable for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (lastModifiedDate.IsSet && lastModifiedDate.Value == null)
                throw new ArgumentNullException(nameof(lastModifiedDate), "Property is not nullable for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            return new EdFiStudentAssessmentRegistrationBatteryPartAssociation(assessmentBatteryPartReference.Value!, studentAssessmentRegistrationReference.Value!, id, accommodations, etag, lastModifiedDate, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiStudentAssessmentRegistrationBatteryPartAssociation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentAssessmentRegistrationBatteryPartAssociation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiStudentAssessmentRegistrationBatteryPartAssociation edFiStudentAssessmentRegistrationBatteryPartAssociation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiStudentAssessmentRegistrationBatteryPartAssociation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiStudentAssessmentRegistrationBatteryPartAssociation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentAssessmentRegistrationBatteryPartAssociation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiStudentAssessmentRegistrationBatteryPartAssociation edFiStudentAssessmentRegistrationBatteryPartAssociation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.AssessmentBatteryPartReference == null)
                throw new ArgumentNullException(nameof(edFiStudentAssessmentRegistrationBatteryPartAssociation.AssessmentBatteryPartReference), "Property is required for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.StudentAssessmentRegistrationReference == null)
                throw new ArgumentNullException(nameof(edFiStudentAssessmentRegistrationBatteryPartAssociation.StudentAssessmentRegistrationReference), "Property is required for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.IdOption.IsSet && edFiStudentAssessmentRegistrationBatteryPartAssociation.Id == null)
                throw new ArgumentNullException(nameof(edFiStudentAssessmentRegistrationBatteryPartAssociation.Id), "Property is required for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.AccommodationsOption.IsSet && edFiStudentAssessmentRegistrationBatteryPartAssociation.Accommodations == null)
                throw new ArgumentNullException(nameof(edFiStudentAssessmentRegistrationBatteryPartAssociation.Accommodations), "Property is required for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.EtagOption.IsSet && edFiStudentAssessmentRegistrationBatteryPartAssociation.Etag == null)
                throw new ArgumentNullException(nameof(edFiStudentAssessmentRegistrationBatteryPartAssociation.Etag), "Property is required for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.ExtOption.IsSet && edFiStudentAssessmentRegistrationBatteryPartAssociation.Ext == null)
                throw new ArgumentNullException(nameof(edFiStudentAssessmentRegistrationBatteryPartAssociation.Ext), "Property is required for class EdFiStudentAssessmentRegistrationBatteryPartAssociation.");

            writer.WritePropertyName("assessmentBatteryPartReference");
            JsonSerializer.Serialize(writer, edFiStudentAssessmentRegistrationBatteryPartAssociation.AssessmentBatteryPartReference, jsonSerializerOptions);
            writer.WritePropertyName("studentAssessmentRegistrationReference");
            JsonSerializer.Serialize(writer, edFiStudentAssessmentRegistrationBatteryPartAssociation.StudentAssessmentRegistrationReference, jsonSerializerOptions);
            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.IdOption.IsSet)
                writer.WriteString("id", edFiStudentAssessmentRegistrationBatteryPartAssociation.Id);

            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.AccommodationsOption.IsSet)
            {
                writer.WritePropertyName("accommodations");
                JsonSerializer.Serialize(writer, edFiStudentAssessmentRegistrationBatteryPartAssociation.Accommodations, jsonSerializerOptions);
            }
            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.EtagOption.IsSet)
                writer.WriteString("_etag", edFiStudentAssessmentRegistrationBatteryPartAssociation.Etag);

            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.LastModifiedDateOption.IsSet)
                writer.WriteString("_lastModifiedDate", edFiStudentAssessmentRegistrationBatteryPartAssociation.LastModifiedDateOption.Value!.Value.ToString(LastModifiedDateFormat));

            if (edFiStudentAssessmentRegistrationBatteryPartAssociation.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiStudentAssessmentRegistrationBatteryPartAssociation.Ext, jsonSerializerOptions);
            }
        }
    }
}
