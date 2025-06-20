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
    /// EdFiGraduationPlanCreditsBySubject
    /// </summary>
    public partial class EdFiGraduationPlanCreditsBySubject : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanCreditsBySubject" /> class.
        /// </summary>
        /// <param name="academicSubjectDescriptor">The intended major subject area of the graduation requirement.</param>
        /// <param name="credits">The value of credits or units of value awarded for the completion of a course.</param>
        /// <param name="creditTypeDescriptor">The type of credits or units of value awarded for the completion of a course.</param>
        /// <param name="creditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</param>
        /// <param name="ext">Extensions to the GraduationPlanCreditsBySubject entity.</param>
        [JsonConstructor]
        public EdFiGraduationPlanCreditsBySubject(string academicSubjectDescriptor, double credits, Option<string?> creditTypeDescriptor = default, Option<double?> creditConversion = default, Option<Object?> ext = default)
        {
            AcademicSubjectDescriptor = academicSubjectDescriptor;
            Credits = credits;
            CreditTypeDescriptorOption = creditTypeDescriptor;
            CreditConversionOption = creditConversion;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The intended major subject area of the graduation requirement.
        /// </summary>
        /// <value>The intended major subject area of the graduation requirement.</value>
        [JsonPropertyName("academicSubjectDescriptor")]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [JsonPropertyName("credits")]
        public double Credits { get; set; }

        /// <summary>
        /// Used to track the state of CreditTypeDescriptor
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CreditTypeDescriptorOption { get; private set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [JsonPropertyName("creditTypeDescriptor")]
        public string? CreditTypeDescriptor { get { return this.CreditTypeDescriptorOption; } set { this.CreditTypeDescriptorOption = new(value); } }

        /// <summary>
        /// Used to track the state of CreditConversion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> CreditConversionOption { get; private set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [JsonPropertyName("creditConversion")]
        public double? CreditConversion { get { return this.CreditConversionOption; } set { this.CreditConversionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the GraduationPlanCreditsBySubject entity.
        /// </summary>
        /// <value>Extensions to the GraduationPlanCreditsBySubject entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiGraduationPlanCreditsBySubject {\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  CreditTypeDescriptor: ").Append(CreditTypeDescriptor).Append("\n");
            sb.Append("  CreditConversion: ").Append(CreditConversion).Append("\n");
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
            // AcademicSubjectDescriptor (string) maxLength
            if (this.AcademicSubjectDescriptor != null && this.AcademicSubjectDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for AcademicSubjectDescriptor, length must be less than 306.", new [] { "AcademicSubjectDescriptor" });
            }

            // Credits (double) maximum
            if (this.Credits > (double)999999.999)
            {
                yield return new ValidationResult("Invalid value for Credits, must be a value less than or equal to 999999.999.", new [] { "Credits" });
            }

            // Credits (double) minimum
            if (this.Credits < (double)0.0)
            {
                yield return new ValidationResult("Invalid value for Credits, must be a value greater than or equal to 0.0.", new [] { "Credits" });
            }

            // CreditTypeDescriptor (string) maxLength
            if (this.CreditTypeDescriptor != null && this.CreditTypeDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for CreditTypeDescriptor, length must be less than 306.", new [] { "CreditTypeDescriptor" });
            }

            // CreditConversion (double) maximum
            if (this.CreditConversionOption.IsSet && this.CreditConversionOption.Value > (double)9999999.99)
            {
                yield return new ValidationResult("Invalid value for CreditConversion, must be a value less than or equal to 9999999.99.", new [] { "CreditConversion" });
            }

            // CreditConversion (double) minimum
            if (this.CreditConversionOption.IsSet && this.CreditConversionOption.Value < (double)-9999999.99)
            {
                yield return new ValidationResult("Invalid value for CreditConversion, must be a value greater than or equal to -9999999.99.", new [] { "CreditConversion" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiGraduationPlanCreditsBySubject" />
    /// </summary>
    public class EdFiGraduationPlanCreditsBySubjectJsonConverter : JsonConverter<EdFiGraduationPlanCreditsBySubject>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiGraduationPlanCreditsBySubject" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiGraduationPlanCreditsBySubject Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> academicSubjectDescriptor = default;
            Option<double?> credits = default;
            Option<string?> creditTypeDescriptor = default;
            Option<double?> creditConversion = default;
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
                        case "academicSubjectDescriptor":
                            academicSubjectDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "credits":
                            credits = new Option<double?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (double?)null : utf8JsonReader.GetDouble());
                            break;
                        case "creditTypeDescriptor":
                            creditTypeDescriptor = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "creditConversion":
                            creditConversion = new Option<double?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (double?)null : utf8JsonReader.GetDouble());
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!academicSubjectDescriptor.IsSet)
                throw new ArgumentException("Property is required for class EdFiGraduationPlanCreditsBySubject.", nameof(academicSubjectDescriptor));

            if (!credits.IsSet)
                throw new ArgumentException("Property is required for class EdFiGraduationPlanCreditsBySubject.", nameof(credits));

            if (academicSubjectDescriptor.IsSet && academicSubjectDescriptor.Value == null)
                throw new ArgumentNullException(nameof(academicSubjectDescriptor), "Property is not nullable for class EdFiGraduationPlanCreditsBySubject.");

            if (credits.IsSet && credits.Value == null)
                throw new ArgumentNullException(nameof(credits), "Property is not nullable for class EdFiGraduationPlanCreditsBySubject.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiGraduationPlanCreditsBySubject.");

            return new EdFiGraduationPlanCreditsBySubject(academicSubjectDescriptor.Value!, credits.Value!.Value!, creditTypeDescriptor, creditConversion, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiGraduationPlanCreditsBySubject" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiGraduationPlanCreditsBySubject"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiGraduationPlanCreditsBySubject edFiGraduationPlanCreditsBySubject, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiGraduationPlanCreditsBySubject, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiGraduationPlanCreditsBySubject" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiGraduationPlanCreditsBySubject"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiGraduationPlanCreditsBySubject edFiGraduationPlanCreditsBySubject, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiGraduationPlanCreditsBySubject.AcademicSubjectDescriptor == null)
                throw new ArgumentNullException(nameof(edFiGraduationPlanCreditsBySubject.AcademicSubjectDescriptor), "Property is required for class EdFiGraduationPlanCreditsBySubject.");

            if (edFiGraduationPlanCreditsBySubject.ExtOption.IsSet && edFiGraduationPlanCreditsBySubject.Ext == null)
                throw new ArgumentNullException(nameof(edFiGraduationPlanCreditsBySubject.Ext), "Property is required for class EdFiGraduationPlanCreditsBySubject.");

            writer.WriteString("academicSubjectDescriptor", edFiGraduationPlanCreditsBySubject.AcademicSubjectDescriptor);

            writer.WriteNumber("credits", edFiGraduationPlanCreditsBySubject.Credits);

            if (edFiGraduationPlanCreditsBySubject.CreditTypeDescriptorOption.IsSet)
                if (edFiGraduationPlanCreditsBySubject.CreditTypeDescriptorOption.Value != null)
                    writer.WriteString("creditTypeDescriptor", edFiGraduationPlanCreditsBySubject.CreditTypeDescriptor);
                else
                    writer.WriteNull("creditTypeDescriptor");

            if (edFiGraduationPlanCreditsBySubject.CreditConversionOption.IsSet)
                if (edFiGraduationPlanCreditsBySubject.CreditConversionOption.Value != null)
                    writer.WriteNumber("creditConversion", edFiGraduationPlanCreditsBySubject.CreditConversionOption.Value!.Value);
                else
                    writer.WriteNull("creditConversion");

            if (edFiGraduationPlanCreditsBySubject.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiGraduationPlanCreditsBySubject.Ext, jsonSerializerOptions);
            }
        }
    }
}
