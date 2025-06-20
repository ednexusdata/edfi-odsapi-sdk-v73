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
    /// EdFiStudentPersonalIdentificationDocument
    /// </summary>
    public partial class EdFiStudentPersonalIdentificationDocument : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentPersonalIdentificationDocument" /> class.
        /// </summary>
        /// <param name="identificationDocumentUseDescriptor">The primary function of the document used for establishing identity.</param>
        /// <param name="personalInformationVerificationDescriptor">The category of the document relative to its purpose.</param>
        /// <param name="issuerCountryDescriptor">Country of origin of the document. It is strongly recommended that entries use only ISO 3166 2-letter country codes.</param>
        /// <param name="documentExpirationDate">The day when the document  expires, if null then never expires.</param>
        /// <param name="documentTitle">The title of the document given by the issuer.</param>
        /// <param name="issuerDocumentIdentificationCode">The unique identifier on the issuer&#39;s identification system.</param>
        /// <param name="issuerName">Name of the entity or institution that issued the document.</param>
        /// <param name="ext">Extensions to the StudentPersonalIdentificationDocument entity.</param>
        [JsonConstructor]
        public EdFiStudentPersonalIdentificationDocument(string identificationDocumentUseDescriptor, string personalInformationVerificationDescriptor, Option<string?> issuerCountryDescriptor = default, Option<DateOnly?> documentExpirationDate = default, Option<string?> documentTitle = default, Option<string?> issuerDocumentIdentificationCode = default, Option<string?> issuerName = default, Option<Object?> ext = default)
        {
            IdentificationDocumentUseDescriptor = identificationDocumentUseDescriptor;
            PersonalInformationVerificationDescriptor = personalInformationVerificationDescriptor;
            IssuerCountryDescriptorOption = issuerCountryDescriptor;
            DocumentExpirationDateOption = documentExpirationDate;
            DocumentTitleOption = documentTitle;
            IssuerDocumentIdentificationCodeOption = issuerDocumentIdentificationCode;
            IssuerNameOption = issuerName;
            ExtOption = ext;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The primary function of the document used for establishing identity.
        /// </summary>
        /// <value>The primary function of the document used for establishing identity.</value>
        [JsonPropertyName("identificationDocumentUseDescriptor")]
        public string IdentificationDocumentUseDescriptor { get; set; }

        /// <summary>
        /// The category of the document relative to its purpose.
        /// </summary>
        /// <value>The category of the document relative to its purpose.</value>
        [JsonPropertyName("personalInformationVerificationDescriptor")]
        public string PersonalInformationVerificationDescriptor { get; set; }

        /// <summary>
        /// Used to track the state of IssuerCountryDescriptor
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IssuerCountryDescriptorOption { get; private set; }

        /// <summary>
        /// Country of origin of the document. It is strongly recommended that entries use only ISO 3166 2-letter country codes.
        /// </summary>
        /// <value>Country of origin of the document. It is strongly recommended that entries use only ISO 3166 2-letter country codes.</value>
        [JsonPropertyName("issuerCountryDescriptor")]
        public string? IssuerCountryDescriptor { get { return this.IssuerCountryDescriptorOption; } set { this.IssuerCountryDescriptorOption = new(value); } }

        /// <summary>
        /// Used to track the state of DocumentExpirationDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateOnly?> DocumentExpirationDateOption { get; private set; }

        /// <summary>
        /// The day when the document  expires, if null then never expires.
        /// </summary>
        /// <value>The day when the document  expires, if null then never expires.</value>
        [JsonPropertyName("documentExpirationDate")]
        public DateOnly? DocumentExpirationDate { get { return this.DocumentExpirationDateOption; } set { this.DocumentExpirationDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of DocumentTitle
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DocumentTitleOption { get; private set; }

        /// <summary>
        /// The title of the document given by the issuer.
        /// </summary>
        /// <value>The title of the document given by the issuer.</value>
        [JsonPropertyName("documentTitle")]
        public string? DocumentTitle { get { return this.DocumentTitleOption; } set { this.DocumentTitleOption = new(value); } }

        /// <summary>
        /// Used to track the state of IssuerDocumentIdentificationCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IssuerDocumentIdentificationCodeOption { get; private set; }

        /// <summary>
        /// The unique identifier on the issuer&#39;s identification system.
        /// </summary>
        /// <value>The unique identifier on the issuer&#39;s identification system.</value>
        [JsonPropertyName("issuerDocumentIdentificationCode")]
        public string? IssuerDocumentIdentificationCode { get { return this.IssuerDocumentIdentificationCodeOption; } set { this.IssuerDocumentIdentificationCodeOption = new(value); } }

        /// <summary>
        /// Used to track the state of IssuerName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IssuerNameOption { get; private set; }

        /// <summary>
        /// Name of the entity or institution that issued the document.
        /// </summary>
        /// <value>Name of the entity or institution that issued the document.</value>
        [JsonPropertyName("issuerName")]
        public string? IssuerName { get { return this.IssuerNameOption; } set { this.IssuerNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of Ext
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ExtOption { get; private set; }

        /// <summary>
        /// Extensions to the StudentPersonalIdentificationDocument entity.
        /// </summary>
        /// <value>Extensions to the StudentPersonalIdentificationDocument entity.</value>
        [JsonPropertyName("_ext")]
        public Object? Ext { get { return this.ExtOption; } set { this.ExtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentPersonalIdentificationDocument {\n");
            sb.Append("  IdentificationDocumentUseDescriptor: ").Append(IdentificationDocumentUseDescriptor).Append("\n");
            sb.Append("  PersonalInformationVerificationDescriptor: ").Append(PersonalInformationVerificationDescriptor).Append("\n");
            sb.Append("  IssuerCountryDescriptor: ").Append(IssuerCountryDescriptor).Append("\n");
            sb.Append("  DocumentExpirationDate: ").Append(DocumentExpirationDate).Append("\n");
            sb.Append("  DocumentTitle: ").Append(DocumentTitle).Append("\n");
            sb.Append("  IssuerDocumentIdentificationCode: ").Append(IssuerDocumentIdentificationCode).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
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
            // IdentificationDocumentUseDescriptor (string) maxLength
            if (this.IdentificationDocumentUseDescriptor != null && this.IdentificationDocumentUseDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for IdentificationDocumentUseDescriptor, length must be less than 306.", new [] { "IdentificationDocumentUseDescriptor" });
            }

            // PersonalInformationVerificationDescriptor (string) maxLength
            if (this.PersonalInformationVerificationDescriptor != null && this.PersonalInformationVerificationDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for PersonalInformationVerificationDescriptor, length must be less than 306.", new [] { "PersonalInformationVerificationDescriptor" });
            }

            // IssuerCountryDescriptor (string) maxLength
            if (this.IssuerCountryDescriptor != null && this.IssuerCountryDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for IssuerCountryDescriptor, length must be less than 306.", new [] { "IssuerCountryDescriptor" });
            }

            // DocumentTitle (string) maxLength
            if (this.DocumentTitle != null && this.DocumentTitle.Length > 60)
            {
                yield return new ValidationResult("Invalid value for DocumentTitle, length must be less than 60.", new [] { "DocumentTitle" });
            }

            // IssuerDocumentIdentificationCode (string) maxLength
            if (this.IssuerDocumentIdentificationCode != null && this.IssuerDocumentIdentificationCode.Length > 60)
            {
                yield return new ValidationResult("Invalid value for IssuerDocumentIdentificationCode, length must be less than 60.", new [] { "IssuerDocumentIdentificationCode" });
            }

            // IssuerName (string) maxLength
            if (this.IssuerName != null && this.IssuerName.Length > 150)
            {
                yield return new ValidationResult("Invalid value for IssuerName, length must be less than 150.", new [] { "IssuerName" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiStudentPersonalIdentificationDocument" />
    /// </summary>
    public class EdFiStudentPersonalIdentificationDocumentJsonConverter : JsonConverter<EdFiStudentPersonalIdentificationDocument>
    {
        /// <summary>
        /// The format to use to serialize DocumentExpirationDate
        /// </summary>
        public static string DocumentExpirationDateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="EdFiStudentPersonalIdentificationDocument" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiStudentPersonalIdentificationDocument Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> identificationDocumentUseDescriptor = default;
            Option<string?> personalInformationVerificationDescriptor = default;
            Option<string?> issuerCountryDescriptor = default;
            Option<DateOnly?> documentExpirationDate = default;
            Option<string?> documentTitle = default;
            Option<string?> issuerDocumentIdentificationCode = default;
            Option<string?> issuerName = default;
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
                        case "identificationDocumentUseDescriptor":
                            identificationDocumentUseDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "personalInformationVerificationDescriptor":
                            personalInformationVerificationDescriptor = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "issuerCountryDescriptor":
                            issuerCountryDescriptor = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "documentExpirationDate":
                            documentExpirationDate = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "documentTitle":
                            documentTitle = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "issuerDocumentIdentificationCode":
                            issuerDocumentIdentificationCode = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "issuerName":
                            issuerName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "_ext":
                            ext = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!identificationDocumentUseDescriptor.IsSet)
                throw new ArgumentException("Property is required for class EdFiStudentPersonalIdentificationDocument.", nameof(identificationDocumentUseDescriptor));

            if (!personalInformationVerificationDescriptor.IsSet)
                throw new ArgumentException("Property is required for class EdFiStudentPersonalIdentificationDocument.", nameof(personalInformationVerificationDescriptor));

            if (identificationDocumentUseDescriptor.IsSet && identificationDocumentUseDescriptor.Value == null)
                throw new ArgumentNullException(nameof(identificationDocumentUseDescriptor), "Property is not nullable for class EdFiStudentPersonalIdentificationDocument.");

            if (personalInformationVerificationDescriptor.IsSet && personalInformationVerificationDescriptor.Value == null)
                throw new ArgumentNullException(nameof(personalInformationVerificationDescriptor), "Property is not nullable for class EdFiStudentPersonalIdentificationDocument.");

            if (ext.IsSet && ext.Value == null)
                throw new ArgumentNullException(nameof(ext), "Property is not nullable for class EdFiStudentPersonalIdentificationDocument.");

            return new EdFiStudentPersonalIdentificationDocument(identificationDocumentUseDescriptor.Value!, personalInformationVerificationDescriptor.Value!, issuerCountryDescriptor, documentExpirationDate, documentTitle, issuerDocumentIdentificationCode, issuerName, ext);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiStudentPersonalIdentificationDocument" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentPersonalIdentificationDocument"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiStudentPersonalIdentificationDocument edFiStudentPersonalIdentificationDocument, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiStudentPersonalIdentificationDocument, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiStudentPersonalIdentificationDocument" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiStudentPersonalIdentificationDocument"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiStudentPersonalIdentificationDocument edFiStudentPersonalIdentificationDocument, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiStudentPersonalIdentificationDocument.IdentificationDocumentUseDescriptor == null)
                throw new ArgumentNullException(nameof(edFiStudentPersonalIdentificationDocument.IdentificationDocumentUseDescriptor), "Property is required for class EdFiStudentPersonalIdentificationDocument.");

            if (edFiStudentPersonalIdentificationDocument.PersonalInformationVerificationDescriptor == null)
                throw new ArgumentNullException(nameof(edFiStudentPersonalIdentificationDocument.PersonalInformationVerificationDescriptor), "Property is required for class EdFiStudentPersonalIdentificationDocument.");

            if (edFiStudentPersonalIdentificationDocument.ExtOption.IsSet && edFiStudentPersonalIdentificationDocument.Ext == null)
                throw new ArgumentNullException(nameof(edFiStudentPersonalIdentificationDocument.Ext), "Property is required for class EdFiStudentPersonalIdentificationDocument.");

            writer.WriteString("identificationDocumentUseDescriptor", edFiStudentPersonalIdentificationDocument.IdentificationDocumentUseDescriptor);

            writer.WriteString("personalInformationVerificationDescriptor", edFiStudentPersonalIdentificationDocument.PersonalInformationVerificationDescriptor);

            if (edFiStudentPersonalIdentificationDocument.IssuerCountryDescriptorOption.IsSet)
                if (edFiStudentPersonalIdentificationDocument.IssuerCountryDescriptorOption.Value != null)
                    writer.WriteString("issuerCountryDescriptor", edFiStudentPersonalIdentificationDocument.IssuerCountryDescriptor);
                else
                    writer.WriteNull("issuerCountryDescriptor");

            if (edFiStudentPersonalIdentificationDocument.DocumentExpirationDateOption.IsSet)
                if (edFiStudentPersonalIdentificationDocument.DocumentExpirationDateOption.Value != null)
                    writer.WriteString("documentExpirationDate", edFiStudentPersonalIdentificationDocument.DocumentExpirationDateOption.Value!.Value.ToString(DocumentExpirationDateFormat));
                else
                    writer.WriteNull("documentExpirationDate");

            if (edFiStudentPersonalIdentificationDocument.DocumentTitleOption.IsSet)
                if (edFiStudentPersonalIdentificationDocument.DocumentTitleOption.Value != null)
                    writer.WriteString("documentTitle", edFiStudentPersonalIdentificationDocument.DocumentTitle);
                else
                    writer.WriteNull("documentTitle");

            if (edFiStudentPersonalIdentificationDocument.IssuerDocumentIdentificationCodeOption.IsSet)
                if (edFiStudentPersonalIdentificationDocument.IssuerDocumentIdentificationCodeOption.Value != null)
                    writer.WriteString("issuerDocumentIdentificationCode", edFiStudentPersonalIdentificationDocument.IssuerDocumentIdentificationCode);
                else
                    writer.WriteNull("issuerDocumentIdentificationCode");

            if (edFiStudentPersonalIdentificationDocument.IssuerNameOption.IsSet)
                if (edFiStudentPersonalIdentificationDocument.IssuerNameOption.Value != null)
                    writer.WriteString("issuerName", edFiStudentPersonalIdentificationDocument.IssuerName);
                else
                    writer.WriteNull("issuerName");

            if (edFiStudentPersonalIdentificationDocument.ExtOption.IsSet)
            {
                writer.WritePropertyName("_ext");
                JsonSerializer.Serialize(writer, edFiStudentPersonalIdentificationDocument.Ext, jsonSerializerOptions);
            }
        }
    }
}
