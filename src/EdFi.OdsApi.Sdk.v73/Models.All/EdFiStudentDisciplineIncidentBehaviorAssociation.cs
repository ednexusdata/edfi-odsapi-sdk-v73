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
    /// EdFiStudentDisciplineIncidentBehaviorAssociation
    /// </summary>
    public partial class EdFiStudentDisciplineIncidentBehaviorAssociation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentDisciplineIncidentBehaviorAssociation" /> class.
        /// </summary>
        /// <param name="behaviorDescriptor">Describes behavior by category.</param>
        /// <param name="disciplineIncidentReference">disciplineIncidentReference</param>
        /// <param name="studentReference">studentReference</param>
        /// <param name="id">id</param>
        /// <param name="behaviorDetailedDescription">Specifies a more granular level of detail of a behavior involved in the incident.</param>
        /// <param name="disciplineIncidentParticipationCodes">An unordered collection of studentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCodes. The role or type of participation of a student in a discipline incident.</param>
        /// <param name="weapons">An unordered collection of studentDisciplineIncidentBehaviorAssociationWeapons. Identifies the type(s) of weapon used by the student during a discipline incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm.</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource.</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified.</param>
        /// <param name="ext">Extensions to the StudentDisciplineIncidentBehaviorAssociation entity.</param>
        [JsonConstructor]
        public EdFiStudentDisciplineIncidentBehaviorAssociation(string behaviorDescriptor, EdFiDisciplineIncidentReference disciplineIncidentReference, EdFiStudentReference studentReference, Option<string?> id = default, Option<string?> behaviorDetailedDescription = default, Option<List<EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode>?> disciplineIncidentParticipationCodes = default, Option<List<EdFiStudentDisciplineIncidentBehaviorAssociationWeapon>?> weapons = default, Option<string?> etag = default, Option<DateTime?> lastModifiedDate = default, Option<Object?> ext = default)
        {
            BehaviorDescriptor = behaviorDescriptor;
            DisciplineIncidentReference = disciplineIncidentReference;
            StudentReference = studentReference;
            IdOption = id;
            BehaviorDetailedDescriptionOption = behaviorDetailedDescription;
            DisciplineIncidentParticipationCodesOption = disciplineIncidentParticipationCodes;
            WeaponsOption = weapons;
            EtagOption = etag;
            LastModifiedDateOption = lastModifiedDate;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Describes behavior by category.
        /// </summary>
        /// <value>Describes behavior by category.</value>
        [JsonPropertyName("behaviorDescriptor")]
        public string BehaviorDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets DisciplineIncidentReference
        /// </summary>
        [JsonPropertyName("disciplineIncidentReference")]
        public EdFiDisciplineIncidentReference DisciplineIncidentReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [JsonPropertyName("studentReference")]
        public EdFiStudentReference StudentReference { get; set; }

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
        /// Used to track the state of BehaviorDetailedDescription
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BehaviorDetailedDescriptionOption { get; private set; }

        /// <summary>
        /// Specifies a more granular level of detail of a behavior involved in the incident.
        /// </summary>
        /// <value>Specifies a more granular level of detail of a behavior involved in the incident.</value>
        [JsonPropertyName("behaviorDetailedDescription")]
        public string? BehaviorDetailedDescription { get { return this.BehaviorDetailedDescriptionOption; } set { this.BehaviorDetailedDescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of DisciplineIncidentParticipationCodes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode>?> DisciplineIncidentParticipationCodesOption { get; private set; }

        /// <summary>
        /// An unordered collection of studentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCodes. The role or type of participation of a student in a discipline incident.
        /// </summary>
        /// <value>An unordered collection of studentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCodes. The role or type of participation of a student in a discipline incident.</value>
        [JsonPropertyName("disciplineIncidentParticipationCodes")]
        public List<EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode>? DisciplineIncidentParticipationCodes { get { return this.DisciplineIncidentParticipationCodesOption; } set { this.DisciplineIncidentParticipationCodesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Weapons
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<EdFiStudentDisciplineIncidentBehaviorAssociationWeapon>?> WeaponsOption { get; private set; }

        /// <summary>
        /// An unordered collection of studentDisciplineIncidentBehaviorAssociationWeapons. Identifies the type(s) of weapon used by the student during a discipline incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm.
        /// </summary>
        /// <value>An unordered collection of studentDisciplineIncidentBehaviorAssociationWeapons. Identifies the type(s) of weapon used by the student during a discipline incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm.</value>
        [JsonPropertyName("weapons")]
        public List<EdFiStudentDisciplineIncidentBehaviorAssociationWeapon>? Weapons { get { return this.WeaponsOption; } set { this.WeaponsOption = new(value); } }

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
        /// Extensions to the StudentDisciplineIncidentBehaviorAssociation entity.
        /// </summary>
        /// <value>Extensions to the StudentDisciplineIncidentBehaviorAssociation entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentDisciplineIncidentBehaviorAssociation {\n");
            sb.Append("  BehaviorDescriptor: ").Append(BehaviorDescriptor).Append("\n");
            sb.Append("  DisciplineIncidentReference: ").Append(DisciplineIncidentReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BehaviorDetailedDescription: ").Append(BehaviorDetailedDescription).Append("\n");
            sb.Append("  DisciplineIncidentParticipationCodes: ").Append(DisciplineIncidentParticipationCodes).Append("\n");
            sb.Append("  Weapons: ").Append(Weapons).Append("\n");
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
            // BehaviorDescriptor (string) maxLength
            if (this.BehaviorDescriptor != null && this.BehaviorDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for BehaviorDescriptor, length must be less than 306.", new [] { "BehaviorDescriptor" });
            }

            // BehaviorDetailedDescription (string) maxLength
            if (this.BehaviorDetailedDescription != null && this.BehaviorDetailedDescription.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for BehaviorDetailedDescription, length must be less than 1024.", new [] { "BehaviorDetailedDescription" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiStudentDisciplineIncidentBehaviorAssociation" />
    /// </summary>
    public class EdFiStudentDisciplineIncidentBehaviorAssociationJsonConverter : JsonConverter<EdFiStudentDisciplineIncidentBehaviorAssociation>
    {
        /// <summary>
        /// The format to use to serialize LastModifiedDate
        /// </summary>
        public static string LastModifiedDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="EdFiStudentDisciplineIncidentBehaviorAssociation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiStudentDisciplineIncidentBehaviorAssociation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> behaviorDescriptor = default;
            Option<EdFiDisciplineIncidentReference?> disciplineIncidentReference = default;
            Option<EdFiStudentReference?> studentReference = default;
            Option<string?> id = default;
            Option<string?> behaviorDetailedDescription = default;
            Option<List<EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode>?> disciplineIncidentParticipationCodes = default;
            Option<List<EdFiStudentDisciplineIncidentBehaviorAssociationWeapon>?> weapons = default;
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
                        case "behaviorDescriptor":
                            behaviorDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "disciplineIncidentReference":
                            disciplineIncidentReference = new Option<EdFiDisciplineIncidentReference?>(JsonSerializer.Deserialize<EdFiDisciplineIncidentReference>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "studentReference":
                            studentReference = new Option<EdFiStudentReference?>(JsonSerializer.Deserialize<EdFiStudentReference>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "behaviorDetailedDescription":
                            behaviorDetailedDescription = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "disciplineIncidentParticipationCodes":
                            disciplineIncidentParticipationCodes = new Option<List<EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode>?>(JsonSerializer.Deserialize<List<EdFiStudentDisciplineIncidentBehaviorAssociationDisciplineIncidentParticipationCode>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "weapons":
                            weapons = new Option<List<EdFiStudentDisciplineIncidentBehaviorAssociationWeapon>?>(JsonSerializer.Deserialize<List<EdFiStudentDisciplineIncidentBehaviorAssociationWeapon>>(ref utf8JsonReader, jsonSerializerOptions)!);
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

            if (!behaviorDescriptor.IsSet)
                throw new ArgumentException("Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.", nameof(behaviorDescriptor));

            if (!disciplineIncidentReference.IsSet)
                throw new ArgumentException("Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.", nameof(disciplineIncidentReference));

            if (!studentReference.IsSet)
                throw new ArgumentException("Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.", nameof(studentReference));

            if (behaviorDescriptor.IsSet && behaviorDescriptor.Value == null)
                throw new ArgumentNullException(nameof(behaviorDescriptor), "Property is not nullable for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (disciplineIncidentReference.IsSet && disciplineIncidentReference.Value == null)
                throw new ArgumentNullException(nameof(disciplineIncidentReference), "Property is not nullable for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (studentReference.IsSet && studentReference.Value == null)
                throw new ArgumentNullException(nameof(studentReference), "Property is not nullable for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (disciplineIncidentParticipationCodes.IsSet && disciplineIncidentParticipationCodes.Value == null)
                throw new ArgumentNullException(nameof(disciplineIncidentParticipationCodes), "Property is not nullable for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (weapons.IsSet && weapons.Value == null)
                throw new ArgumentNullException(nameof(weapons), "Property is not nullable for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (etag.IsSet && etag.Value == null)
                throw new ArgumentNullException(nameof(etag), "Property is not nullable for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (lastModifiedDate.IsSet && lastModifiedDate.Value == null)
                throw new ArgumentNullException(nameof(lastModifiedDate), "Property is not nullable for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            return new EdFiStudentDisciplineIncidentBehaviorAssociation(behaviorDescriptor.Value!, disciplineIncidentReference.Value!, studentReference.Value!, id, behaviorDetailedDescription, disciplineIncidentParticipationCodes, weapons, etag, lastModifiedDate, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiStudentDisciplineIncidentBehaviorAssociation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentDisciplineIncidentBehaviorAssociation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiStudentDisciplineIncidentBehaviorAssociation edFiStudentDisciplineIncidentBehaviorAssociation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiStudentDisciplineIncidentBehaviorAssociation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiStudentDisciplineIncidentBehaviorAssociation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentDisciplineIncidentBehaviorAssociation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiStudentDisciplineIncidentBehaviorAssociation edFiStudentDisciplineIncidentBehaviorAssociation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiStudentDisciplineIncidentBehaviorAssociation.BehaviorDescriptor == null)
                throw new ArgumentNullException(nameof(edFiStudentDisciplineIncidentBehaviorAssociation.BehaviorDescriptor), "Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (edFiStudentDisciplineIncidentBehaviorAssociation.DisciplineIncidentReference == null)
                throw new ArgumentNullException(nameof(edFiStudentDisciplineIncidentBehaviorAssociation.DisciplineIncidentReference), "Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (edFiStudentDisciplineIncidentBehaviorAssociation.StudentReference == null)
                throw new ArgumentNullException(nameof(edFiStudentDisciplineIncidentBehaviorAssociation.StudentReference), "Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (edFiStudentDisciplineIncidentBehaviorAssociation.IdOption.IsSet && edFiStudentDisciplineIncidentBehaviorAssociation.Id == null)
                throw new ArgumentNullException(nameof(edFiStudentDisciplineIncidentBehaviorAssociation.Id), "Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (edFiStudentDisciplineIncidentBehaviorAssociation.DisciplineIncidentParticipationCodesOption.IsSet && edFiStudentDisciplineIncidentBehaviorAssociation.DisciplineIncidentParticipationCodes == null)
                throw new ArgumentNullException(nameof(edFiStudentDisciplineIncidentBehaviorAssociation.DisciplineIncidentParticipationCodes), "Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (edFiStudentDisciplineIncidentBehaviorAssociation.WeaponsOption.IsSet && edFiStudentDisciplineIncidentBehaviorAssociation.Weapons == null)
                throw new ArgumentNullException(nameof(edFiStudentDisciplineIncidentBehaviorAssociation.Weapons), "Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (edFiStudentDisciplineIncidentBehaviorAssociation.EtagOption.IsSet && edFiStudentDisciplineIncidentBehaviorAssociation.Etag == null)
                throw new ArgumentNullException(nameof(edFiStudentDisciplineIncidentBehaviorAssociation.Etag), "Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            if (edFiStudentDisciplineIncidentBehaviorAssociation.ExtOption.IsSet && edFiStudentDisciplineIncidentBehaviorAssociation.Ext == null)
                throw new ArgumentNullException(nameof(edFiStudentDisciplineIncidentBehaviorAssociation.Ext), "Property is required for class EdFiStudentDisciplineIncidentBehaviorAssociation.");

            writer.WriteString("behaviorDescriptor", edFiStudentDisciplineIncidentBehaviorAssociation.BehaviorDescriptor);

            writer.WritePropertyName("disciplineIncidentReference");
            JsonSerializer.Serialize(writer, edFiStudentDisciplineIncidentBehaviorAssociation.DisciplineIncidentReference, jsonSerializerOptions);
            writer.WritePropertyName("studentReference");
            JsonSerializer.Serialize(writer, edFiStudentDisciplineIncidentBehaviorAssociation.StudentReference, jsonSerializerOptions);
            if (edFiStudentDisciplineIncidentBehaviorAssociation.IdOption.IsSet)
                writer.WriteString("id", edFiStudentDisciplineIncidentBehaviorAssociation.Id);

            if (edFiStudentDisciplineIncidentBehaviorAssociation.BehaviorDetailedDescriptionOption.IsSet)
                if (edFiStudentDisciplineIncidentBehaviorAssociation.BehaviorDetailedDescriptionOption.Value != null)
                    writer.WriteString("behaviorDetailedDescription", edFiStudentDisciplineIncidentBehaviorAssociation.BehaviorDetailedDescription);
                else
                    writer.WriteNull("behaviorDetailedDescription");

            if (edFiStudentDisciplineIncidentBehaviorAssociation.DisciplineIncidentParticipationCodesOption.IsSet)
            {
                writer.WritePropertyName("disciplineIncidentParticipationCodes");
                JsonSerializer.Serialize(writer, edFiStudentDisciplineIncidentBehaviorAssociation.DisciplineIncidentParticipationCodes, jsonSerializerOptions);
            }
            if (edFiStudentDisciplineIncidentBehaviorAssociation.WeaponsOption.IsSet)
            {
                writer.WritePropertyName("weapons");
                JsonSerializer.Serialize(writer, edFiStudentDisciplineIncidentBehaviorAssociation.Weapons, jsonSerializerOptions);
            }
            if (edFiStudentDisciplineIncidentBehaviorAssociation.EtagOption.IsSet)
                writer.WriteString("_etag", edFiStudentDisciplineIncidentBehaviorAssociation.Etag);

            if (edFiStudentDisciplineIncidentBehaviorAssociation.LastModifiedDateOption.IsSet)
                writer.WriteString("_lastModifiedDate", edFiStudentDisciplineIncidentBehaviorAssociation.LastModifiedDateOption.Value!.Value.ToString(LastModifiedDateFormat));

            if (edFiStudentDisciplineIncidentBehaviorAssociation.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiStudentDisciplineIncidentBehaviorAssociation.Ext, jsonSerializerOptions);
            }
        }
    }
}
