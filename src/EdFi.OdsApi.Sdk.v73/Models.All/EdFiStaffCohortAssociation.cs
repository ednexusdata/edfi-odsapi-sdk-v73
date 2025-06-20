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
    /// EdFiStaffCohortAssociation
    /// </summary>
    public partial class EdFiStaffCohortAssociation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffCohortAssociation" /> class.
        /// </summary>
        /// <param name="beginDate">Start date for the association of staff to this cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.</param>
        /// <param name="cohortReference">cohortReference</param>
        /// <param name="staffReference">staffReference</param>
        /// <param name="id">id</param>
        /// <param name="endDate">End date for the association of staff to this cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.</param>
        /// <param name="studentRecordAccess">Indicator of whether the staff has access to the student records of the cohort per district interpretation of FERPA and other privacy laws, regulations, and policies.</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource.</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified.</param>
        /// <param name="ext">Extensions to the StaffCohortAssociation entity.</param>
        [JsonConstructor]
        public EdFiStaffCohortAssociation(DateOnly beginDate, EdFiCohortReference cohortReference, EdFiStaffReference staffReference, Option<string?> id = default, Option<DateOnly?> endDate = default, Option<bool?> studentRecordAccess = default, Option<string?> etag = default, Option<DateTime?> lastModifiedDate = default, Option<Object?> ext = default)
        {
            BeginDate = beginDate;
            CohortReference = cohortReference;
            StaffReference = staffReference;
            IdOption = id;
            EndDateOption = endDate;
            StudentRecordAccessOption = studentRecordAccess;
            EtagOption = etag;
            LastModifiedDateOption = lastModifiedDate;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Start date for the association of staff to this cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.
        /// </summary>
        /// <value>Start date for the association of staff to this cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.</value>
        [JsonPropertyName("beginDate")]
        public DateOnly BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets CohortReference
        /// </summary>
        [JsonPropertyName("cohortReference")]
        public EdFiCohortReference CohortReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [JsonPropertyName("staffReference")]
        public EdFiStaffReference StaffReference { get; set; }

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
        /// Used to track the state of EndDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> EndDateOption { get; private set; }

        /// <summary>
        /// End date for the association of staff to this cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.
        /// </summary>
        /// <value>End date for the association of staff to this cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines.</value>
        [JsonPropertyName("endDate")]
        public DateOnly? EndDate { get { return this.EndDateOption; } set { this.EndDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of StudentRecordAccess
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> StudentRecordAccessOption { get; private set; }

        /// <summary>
        /// Indicator of whether the staff has access to the student records of the cohort per district interpretation of FERPA and other privacy laws, regulations, and policies.
        /// </summary>
        /// <value>Indicator of whether the staff has access to the student records of the cohort per district interpretation of FERPA and other privacy laws, regulations, and policies.</value>
        [JsonPropertyName("studentRecordAccess")]
        public bool? StudentRecordAccess { get { return this.StudentRecordAccessOption; } set { this.StudentRecordAccessOption = new(value); } }

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
        /// Extensions to the StaffCohortAssociation entity.
        /// </summary>
        /// <value>Extensions to the StaffCohortAssociation entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStaffCohortAssociation {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  CohortReference: ").Append(CohortReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StudentRecordAccess: ").Append(StudentRecordAccess).Append("\n");
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
    /// A Json converter for type <see cref="EdFiStaffCohortAssociation" />
    /// </summary>
    public class EdFiStaffCohortAssociationJsonConverter : JsonConverter<EdFiStaffCohortAssociation>
    {
        /// <summary>
        /// The format to use to serialize BeginDate
        /// </summary>
        public static string BeginDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize EndDate
        /// </summary>
        public static string EndDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize LastModifiedDate
        /// </summary>
        public static string LastModifiedDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="EdFiStaffCohortAssociation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiStaffCohortAssociation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateOnly?> beginDate = default;
            Option<EdFiCohortReference?> cohortReference = default;
            Option<EdFiStaffReference?> staffReference = default;
            Option<string?> id = default;
            Option<DateOnly?> endDate = default;
            Option<bool?> studentRecordAccess = default;
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
                        case "beginDate":
                            beginDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "cohortReference":
                            cohortReference = new Option<EdFiCohortReference?>(JsonSerializer.Deserialize<EdFiCohortReference>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "staffReference":
                            staffReference = new Option<EdFiStaffReference?>(JsonSerializer.Deserialize<EdFiStaffReference>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "endDate":
                            endDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "studentRecordAccess":
                            studentRecordAccess = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
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

            if (!beginDate.IsSet)
                throw new ArgumentException("Property is required for class EdFiStaffCohortAssociation.", nameof(beginDate));

            if (!cohortReference.IsSet)
                throw new ArgumentException("Property is required for class EdFiStaffCohortAssociation.", nameof(cohortReference));

            if (!staffReference.IsSet)
                throw new ArgumentException("Property is required for class EdFiStaffCohortAssociation.", nameof(staffReference));

            if (beginDate.IsSet && beginDate.Value == null)
                throw new ArgumentNullException(nameof(beginDate), "Property is not nullable for class EdFiStaffCohortAssociation.");

            if (cohortReference.IsSet && cohortReference.Value == null)
                throw new ArgumentNullException(nameof(cohortReference), "Property is not nullable for class EdFiStaffCohortAssociation.");

            if (staffReference.IsSet && staffReference.Value == null)
                throw new ArgumentNullException(nameof(staffReference), "Property is not nullable for class EdFiStaffCohortAssociation.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class EdFiStaffCohortAssociation.");

            if (etag.IsSet && etag.Value == null)
                throw new ArgumentNullException(nameof(etag), "Property is not nullable for class EdFiStaffCohortAssociation.");

            if (lastModifiedDate.IsSet && lastModifiedDate.Value == null)
                throw new ArgumentNullException(nameof(lastModifiedDate), "Property is not nullable for class EdFiStaffCohortAssociation.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiStaffCohortAssociation.");

            return new EdFiStaffCohortAssociation(beginDate.Value!.Value!, cohortReference.Value!, staffReference.Value!, id, endDate, studentRecordAccess, etag, lastModifiedDate, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiStaffCohortAssociation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStaffCohortAssociation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiStaffCohortAssociation edFiStaffCohortAssociation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiStaffCohortAssociation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiStaffCohortAssociation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStaffCohortAssociation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiStaffCohortAssociation edFiStaffCohortAssociation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiStaffCohortAssociation.CohortReference == null)
                throw new ArgumentNullException(nameof(edFiStaffCohortAssociation.CohortReference), "Property is required for class EdFiStaffCohortAssociation.");

            if (edFiStaffCohortAssociation.StaffReference == null)
                throw new ArgumentNullException(nameof(edFiStaffCohortAssociation.StaffReference), "Property is required for class EdFiStaffCohortAssociation.");

            if (edFiStaffCohortAssociation.IdOption.IsSet && edFiStaffCohortAssociation.Id == null)
                throw new ArgumentNullException(nameof(edFiStaffCohortAssociation.Id), "Property is required for class EdFiStaffCohortAssociation.");

            if (edFiStaffCohortAssociation.EtagOption.IsSet && edFiStaffCohortAssociation.Etag == null)
                throw new ArgumentNullException(nameof(edFiStaffCohortAssociation.Etag), "Property is required for class EdFiStaffCohortAssociation.");

            if (edFiStaffCohortAssociation.ExtOption.IsSet && edFiStaffCohortAssociation.Ext == null)
                throw new ArgumentNullException(nameof(edFiStaffCohortAssociation.Ext), "Property is required for class EdFiStaffCohortAssociation.");

            writer.WriteString("beginDate", edFiStaffCohortAssociation.BeginDate.ToString(BeginDateFormat));

            writer.WritePropertyName("cohortReference");
            JsonSerializer.Serialize(writer, edFiStaffCohortAssociation.CohortReference, jsonSerializerOptions);
            writer.WritePropertyName("staffReference");
            JsonSerializer.Serialize(writer, edFiStaffCohortAssociation.StaffReference, jsonSerializerOptions);
            if (edFiStaffCohortAssociation.IdOption.IsSet)
                writer.WriteString("id", edFiStaffCohortAssociation.Id);

            if (edFiStaffCohortAssociation.EndDateOption.IsSet)
                if (edFiStaffCohortAssociation.EndDateOption.Value != null)
                    writer.WriteString("endDate", edFiStaffCohortAssociation.EndDateOption.Value!.Value.ToString(EndDateFormat));
                else
                    writer.WriteNull("endDate");

            if (edFiStaffCohortAssociation.StudentRecordAccessOption.IsSet)
                if (edFiStaffCohortAssociation.StudentRecordAccessOption.Value != null)
                    writer.WriteBoolean("studentRecordAccess", edFiStaffCohortAssociation.StudentRecordAccessOption.Value!.Value);
                else
                    writer.WriteNull("studentRecordAccess");

            if (edFiStaffCohortAssociation.EtagOption.IsSet)
                writer.WriteString("_etag", edFiStaffCohortAssociation.Etag);

            if (edFiStaffCohortAssociation.LastModifiedDateOption.IsSet)
                writer.WriteString("_lastModifiedDate", edFiStaffCohortAssociation.LastModifiedDateOption.Value!.Value.ToString(LastModifiedDateFormat));

            if (edFiStaffCohortAssociation.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiStaffCohortAssociation.Ext, jsonSerializerOptions);
            }
        }
    }
}
