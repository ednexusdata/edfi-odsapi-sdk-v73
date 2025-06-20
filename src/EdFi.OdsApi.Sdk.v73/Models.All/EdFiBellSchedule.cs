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
    /// EdFiBellSchedule
    /// </summary>
    public partial class EdFiBellSchedule : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiBellSchedule" /> class.
        /// </summary>
        /// <param name="bellScheduleName">Name or title of the bell schedule.</param>
        /// <param name="classPeriods">An unordered collection of bellScheduleClassPeriods. The class periods that compose this bell schedule.</param>
        /// <param name="schoolReference">schoolReference</param>
        /// <param name="id">id</param>
        /// <param name="alternateDayName">An alternate name for the day (e.g., Red, Blue).</param>
        /// <param name="dates">An unordered collection of bellScheduleDates. The dates for which the bell schedule applies.</param>
        /// <param name="endTime">An indication of the time of day the bell schedule ends.</param>
        /// <param name="gradeLevels">An unordered collection of bellScheduleGradeLevels. The grade levels the particular bell schedule applies to.</param>
        /// <param name="startTime">An indication of the time of day the bell schedule begins.</param>
        /// <param name="totalInstructionalTime">The total instructional time in minutes per day for the bell schedule.</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource.</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified.</param>
        /// <param name="ext">Extensions to the BellSchedule entity.</param>
        [JsonConstructor]
        public EdFiBellSchedule(string bellScheduleName, List<EdFiBellScheduleClassPeriod> classPeriods, EdFiSchoolReference schoolReference, Option<string?> id = default, Option<string?> alternateDayName = default, Option<List<EdFiBellScheduleDate>?> dates = default, Option<string?> endTime = default, Option<List<EdFiBellScheduleGradeLevel>?> gradeLevels = default, Option<string?> startTime = default, Option<int?> totalInstructionalTime = default, Option<string?> etag = default, Option<DateTime?> lastModifiedDate = default, Option<Object?> ext = default)
        {
            BellScheduleName = bellScheduleName;
            ClassPeriods = classPeriods;
            SchoolReference = schoolReference;
            IdOption = id;
            AlternateDayNameOption = alternateDayName;
            DatesOption = dates;
            EndTimeOption = endTime;
            GradeLevelsOption = gradeLevels;
            StartTimeOption = startTime;
            TotalInstructionalTimeOption = totalInstructionalTime;
            EtagOption = etag;
            LastModifiedDateOption = lastModifiedDate;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Name or title of the bell schedule.
        /// </summary>
        /// <value>Name or title of the bell schedule.</value>
        [JsonPropertyName("bellScheduleName")]
        public string BellScheduleName { get; set; }

        /// <summary>
        /// An unordered collection of bellScheduleClassPeriods. The class periods that compose this bell schedule.
        /// </summary>
        /// <value>An unordered collection of bellScheduleClassPeriods. The class periods that compose this bell schedule.</value>
        [JsonPropertyName("classPeriods")]
        public List<EdFiBellScheduleClassPeriod> ClassPeriods { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [JsonPropertyName("schoolReference")]
        public EdFiSchoolReference SchoolReference { get; set; }

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
        /// Used to track the state of AlternateDayName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AlternateDayNameOption { get; private set; }

        /// <summary>
        /// An alternate name for the day (e.g., Red, Blue).
        /// </summary>
        /// <value>An alternate name for the day (e.g., Red, Blue).</value>
        [JsonPropertyName("alternateDayName")]
        public string? AlternateDayName { get { return this.AlternateDayNameOption; } set { this.AlternateDayNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of Dates
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<EdFiBellScheduleDate>?> DatesOption { get; private set; }

        /// <summary>
        /// An unordered collection of bellScheduleDates. The dates for which the bell schedule applies.
        /// </summary>
        /// <value>An unordered collection of bellScheduleDates. The dates for which the bell schedule applies.</value>
        [JsonPropertyName("dates")]
        public List<EdFiBellScheduleDate>? Dates { get { return this.DatesOption; } set { this.DatesOption = new(value); } }

        /// <summary>
        /// Used to track the state of EndTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EndTimeOption { get; private set; }

        /// <summary>
        /// An indication of the time of day the bell schedule ends.
        /// </summary>
        /// <value>An indication of the time of day the bell schedule ends.</value>
        [JsonPropertyName("endTime")]
        public string? EndTime { get { return this.EndTimeOption; } set { this.EndTimeOption = new(value); } }

        /// <summary>
        /// Used to track the state of GradeLevels
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<EdFiBellScheduleGradeLevel>?> GradeLevelsOption { get; private set; }

        /// <summary>
        /// An unordered collection of bellScheduleGradeLevels. The grade levels the particular bell schedule applies to.
        /// </summary>
        /// <value>An unordered collection of bellScheduleGradeLevels. The grade levels the particular bell schedule applies to.</value>
        [JsonPropertyName("gradeLevels")]
        public List<EdFiBellScheduleGradeLevel>? GradeLevels { get { return this.GradeLevelsOption; } set { this.GradeLevelsOption = new(value); } }

        /// <summary>
        /// Used to track the state of StartTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StartTimeOption { get; private set; }

        /// <summary>
        /// An indication of the time of day the bell schedule begins.
        /// </summary>
        /// <value>An indication of the time of day the bell schedule begins.</value>
        [JsonPropertyName("startTime")]
        public string? StartTime { get { return this.StartTimeOption; } set { this.StartTimeOption = new(value); } }

        /// <summary>
        /// Used to track the state of TotalInstructionalTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> TotalInstructionalTimeOption { get; private set; }

        /// <summary>
        /// The total instructional time in minutes per day for the bell schedule.
        /// </summary>
        /// <value>The total instructional time in minutes per day for the bell schedule.</value>
        [JsonPropertyName("totalInstructionalTime")]
        public int? TotalInstructionalTime { get { return this.TotalInstructionalTimeOption; } set { this.TotalInstructionalTimeOption = new(value); } }

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
        /// Extensions to the BellSchedule entity.
        /// </summary>
        /// <value>Extensions to the BellSchedule entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiBellSchedule {\n");
            sb.Append("  BellScheduleName: ").Append(BellScheduleName).Append("\n");
            sb.Append("  ClassPeriods: ").Append(ClassPeriods).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AlternateDayName: ").Append(AlternateDayName).Append("\n");
            sb.Append("  Dates: ").Append(Dates).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  GradeLevels: ").Append(GradeLevels).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  TotalInstructionalTime: ").Append(TotalInstructionalTime).Append("\n");
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
            // BellScheduleName (string) maxLength
            if (this.BellScheduleName != null && this.BellScheduleName.Length > 60)
            {
                yield return new ValidationResult("Invalid value for BellScheduleName, length must be less than 60.", new [] { "BellScheduleName" });
            }

            // AlternateDayName (string) maxLength
            if (this.AlternateDayName != null && this.AlternateDayName.Length > 20)
            {
                yield return new ValidationResult("Invalid value for AlternateDayName, length must be less than 20.", new [] { "AlternateDayName" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiBellSchedule" />
    /// </summary>
    public class EdFiBellScheduleJsonConverter : JsonConverter<EdFiBellSchedule>
    {
        /// <summary>
        /// The format to use to serialize LastModifiedDate
        /// </summary>
        public static string LastModifiedDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="EdFiBellSchedule" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiBellSchedule Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> bellScheduleName = default;
            Option<List<EdFiBellScheduleClassPeriod>?> classPeriods = default;
            Option<EdFiSchoolReference?> schoolReference = default;
            Option<string?> id = default;
            Option<string?> alternateDayName = default;
            Option<List<EdFiBellScheduleDate>?> dates = default;
            Option<string?> endTime = default;
            Option<List<EdFiBellScheduleGradeLevel>?> gradeLevels = default;
            Option<string?> startTime = default;
            Option<int?> totalInstructionalTime = default;
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
                        case "bellScheduleName":
                            bellScheduleName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "classPeriods":
                            classPeriods = new Option<List<EdFiBellScheduleClassPeriod>?>(JsonSerializer.Deserialize<List<EdFiBellScheduleClassPeriod>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "schoolReference":
                            schoolReference = new Option<EdFiSchoolReference?>(JsonSerializer.Deserialize<EdFiSchoolReference>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "alternateDayName":
                            alternateDayName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "dates":
                            dates = new Option<List<EdFiBellScheduleDate>?>(JsonSerializer.Deserialize<List<EdFiBellScheduleDate>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "endTime":
                            endTime = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "gradeLevels":
                            gradeLevels = new Option<List<EdFiBellScheduleGradeLevel>?>(JsonSerializer.Deserialize<List<EdFiBellScheduleGradeLevel>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "startTime":
                            startTime = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "totalInstructionalTime":
                            totalInstructionalTime = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
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

            if (!bellScheduleName.IsSet)
                throw new ArgumentException("Property is required for class EdFiBellSchedule.", nameof(bellScheduleName));

            if (!classPeriods.IsSet)
                throw new ArgumentException("Property is required for class EdFiBellSchedule.", nameof(classPeriods));

            if (!schoolReference.IsSet)
                throw new ArgumentException("Property is required for class EdFiBellSchedule.", nameof(schoolReference));

            if (bellScheduleName.IsSet && bellScheduleName.Value == null)
                throw new ArgumentNullException(nameof(bellScheduleName), "Property is not nullable for class EdFiBellSchedule.");

            if (classPeriods.IsSet && classPeriods.Value == null)
                throw new ArgumentNullException(nameof(classPeriods), "Property is not nullable for class EdFiBellSchedule.");

            if (schoolReference.IsSet && schoolReference.Value == null)
                throw new ArgumentNullException(nameof(schoolReference), "Property is not nullable for class EdFiBellSchedule.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class EdFiBellSchedule.");

            if (dates.IsSet && dates.Value == null)
                throw new ArgumentNullException(nameof(dates), "Property is not nullable for class EdFiBellSchedule.");

            if (gradeLevels.IsSet && gradeLevels.Value == null)
                throw new ArgumentNullException(nameof(gradeLevels), "Property is not nullable for class EdFiBellSchedule.");

            if (etag.IsSet && etag.Value == null)
                throw new ArgumentNullException(nameof(etag), "Property is not nullable for class EdFiBellSchedule.");

            if (lastModifiedDate.IsSet && lastModifiedDate.Value == null)
                throw new ArgumentNullException(nameof(lastModifiedDate), "Property is not nullable for class EdFiBellSchedule.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiBellSchedule.");

            return new EdFiBellSchedule(bellScheduleName.Value!, classPeriods.Value!, schoolReference.Value!, id, alternateDayName, dates, endTime, gradeLevels, startTime, totalInstructionalTime, etag, lastModifiedDate, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiBellSchedule" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiBellSchedule"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiBellSchedule edFiBellSchedule, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiBellSchedule, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiBellSchedule" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiBellSchedule"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiBellSchedule edFiBellSchedule, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiBellSchedule.BellScheduleName == null)
                throw new ArgumentNullException(nameof(edFiBellSchedule.BellScheduleName), "Property is required for class EdFiBellSchedule.");

            if (edFiBellSchedule.ClassPeriods == null)
                throw new ArgumentNullException(nameof(edFiBellSchedule.ClassPeriods), "Property is required for class EdFiBellSchedule.");

            if (edFiBellSchedule.SchoolReference == null)
                throw new ArgumentNullException(nameof(edFiBellSchedule.SchoolReference), "Property is required for class EdFiBellSchedule.");

            if (edFiBellSchedule.IdOption.IsSet && edFiBellSchedule.Id == null)
                throw new ArgumentNullException(nameof(edFiBellSchedule.Id), "Property is required for class EdFiBellSchedule.");

            if (edFiBellSchedule.DatesOption.IsSet && edFiBellSchedule.Dates == null)
                throw new ArgumentNullException(nameof(edFiBellSchedule.Dates), "Property is required for class EdFiBellSchedule.");

            if (edFiBellSchedule.GradeLevelsOption.IsSet && edFiBellSchedule.GradeLevels == null)
                throw new ArgumentNullException(nameof(edFiBellSchedule.GradeLevels), "Property is required for class EdFiBellSchedule.");

            if (edFiBellSchedule.EtagOption.IsSet && edFiBellSchedule.Etag == null)
                throw new ArgumentNullException(nameof(edFiBellSchedule.Etag), "Property is required for class EdFiBellSchedule.");

            if (edFiBellSchedule.ExtOption.IsSet && edFiBellSchedule.Ext == null)
                throw new ArgumentNullException(nameof(edFiBellSchedule.Ext), "Property is required for class EdFiBellSchedule.");

            writer.WriteString("bellScheduleName", edFiBellSchedule.BellScheduleName);

            writer.WritePropertyName("classPeriods");
            JsonSerializer.Serialize(writer, edFiBellSchedule.ClassPeriods, jsonSerializerOptions);
            writer.WritePropertyName("schoolReference");
            JsonSerializer.Serialize(writer, edFiBellSchedule.SchoolReference, jsonSerializerOptions);
            if (edFiBellSchedule.IdOption.IsSet)
                writer.WriteString("id", edFiBellSchedule.Id);

            if (edFiBellSchedule.AlternateDayNameOption.IsSet)
                if (edFiBellSchedule.AlternateDayNameOption.Value != null)
                    writer.WriteString("alternateDayName", edFiBellSchedule.AlternateDayName);
                else
                    writer.WriteNull("alternateDayName");

            if (edFiBellSchedule.DatesOption.IsSet)
            {
                writer.WritePropertyName("dates");
                JsonSerializer.Serialize(writer, edFiBellSchedule.Dates, jsonSerializerOptions);
            }
            if (edFiBellSchedule.EndTimeOption.IsSet)
                if (edFiBellSchedule.EndTimeOption.Value != null)
                    writer.WriteString("endTime", edFiBellSchedule.EndTime);
                else
                    writer.WriteNull("endTime");

            if (edFiBellSchedule.GradeLevelsOption.IsSet)
            {
                writer.WritePropertyName("gradeLevels");
                JsonSerializer.Serialize(writer, edFiBellSchedule.GradeLevels, jsonSerializerOptions);
            }
            if (edFiBellSchedule.StartTimeOption.IsSet)
                if (edFiBellSchedule.StartTimeOption.Value != null)
                    writer.WriteString("startTime", edFiBellSchedule.StartTime);
                else
                    writer.WriteNull("startTime");

            if (edFiBellSchedule.TotalInstructionalTimeOption.IsSet)
                if (edFiBellSchedule.TotalInstructionalTimeOption.Value != null)
                    writer.WriteNumber("totalInstructionalTime", edFiBellSchedule.TotalInstructionalTimeOption.Value!.Value);
                else
                    writer.WriteNull("totalInstructionalTime");

            if (edFiBellSchedule.EtagOption.IsSet)
                writer.WriteString("_etag", edFiBellSchedule.Etag);

            if (edFiBellSchedule.LastModifiedDateOption.IsSet)
                writer.WriteString("_lastModifiedDate", edFiBellSchedule.LastModifiedDateOption.Value!.Value.ToString(LastModifiedDateFormat));

            if (edFiBellSchedule.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiBellSchedule.Ext, jsonSerializerOptions);
            }
        }
    }
}
