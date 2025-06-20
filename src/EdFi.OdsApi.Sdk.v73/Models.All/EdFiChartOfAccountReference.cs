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
    /// EdFiChartOfAccountReference
    /// </summary>
    public partial class EdFiChartOfAccountReference : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiChartOfAccountReference" /> class.
        /// </summary>
        /// <param name="accountIdentifier">SEA populated code value for the valid combination of account dimensions under which financials are reported.</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization.</param>
        /// <param name="fiscalYear">The fiscal year for the account</param>
        /// <param name="link">link</param>
        [JsonConstructor]
        public EdFiChartOfAccountReference(string accountIdentifier, long educationOrganizationId, int fiscalYear, Option<Link?> link = default)
        {
            AccountIdentifier = accountIdentifier;
            EducationOrganizationId = educationOrganizationId;
            FiscalYear = fiscalYear;
            LinkOption = link;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// SEA populated code value for the valid combination of account dimensions under which financials are reported.
        /// </summary>
        /// <value>SEA populated code value for the valid combination of account dimensions under which financials are reported.</value>
        [JsonPropertyName("accountIdentifier")]
        public string AccountIdentifier { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [JsonPropertyName("educationOrganizationId")]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// The fiscal year for the account
        /// </summary>
        /// <value>The fiscal year for the account</value>
        [JsonPropertyName("fiscalYear")]
        public int FiscalYear { get; set; }

        /// <summary>
        /// Used to track the state of Link
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Link?> LinkOption { get; private set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [JsonPropertyName("link")]
        public Link? Link { get { return this.LinkOption; } set { this.LinkOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiChartOfAccountReference {\n");
            sb.Append("  AccountIdentifier: ").Append(AccountIdentifier).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            // AccountIdentifier (string) maxLength
            if (this.AccountIdentifier != null && this.AccountIdentifier.Length > 50)
            {
                yield return new ValidationResult("Invalid value for AccountIdentifier, length must be less than 50.", new [] { "AccountIdentifier" });
            }

            // FiscalYear (int) maximum
            if (this.FiscalYear > (int)2040)
            {
                yield return new ValidationResult("Invalid value for FiscalYear, must be a value less than or equal to 2040.", new [] { "FiscalYear" });
            }

            // FiscalYear (int) minimum
            if (this.FiscalYear < (int)2020)
            {
                yield return new ValidationResult("Invalid value for FiscalYear, must be a value greater than or equal to 2020.", new [] { "FiscalYear" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EdFiChartOfAccountReference" />
    /// </summary>
    public class EdFiChartOfAccountReferenceJsonConverter : JsonConverter<EdFiChartOfAccountReference>
    {
        /// <summary>
        /// Deserializes json to <see cref="EdFiChartOfAccountReference" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EdFiChartOfAccountReference Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> accountIdentifier = default;
            Option<long?> educationOrganizationId = default;
            Option<int?> fiscalYear = default;
            Option<Link?> link = default;

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
                        case "accountIdentifier":
                            accountIdentifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "educationOrganizationId":
                            educationOrganizationId = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "fiscalYear":
                            fiscalYear = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "link":
                            link = new Option<Link?>(JsonSerializer.Deserialize<Link>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!accountIdentifier.IsSet)
                throw new ArgumentException("Property is required for class EdFiChartOfAccountReference.", nameof(accountIdentifier));

            if (!educationOrganizationId.IsSet)
                throw new ArgumentException("Property is required for class EdFiChartOfAccountReference.", nameof(educationOrganizationId));

            if (!fiscalYear.IsSet)
                throw new ArgumentException("Property is required for class EdFiChartOfAccountReference.", nameof(fiscalYear));

            if (accountIdentifier.IsSet && accountIdentifier.Value == null)
                throw new ArgumentNullException(nameof(accountIdentifier), "Property is not nullable for class EdFiChartOfAccountReference.");

            if (educationOrganizationId.IsSet && educationOrganizationId.Value == null)
                throw new ArgumentNullException(nameof(educationOrganizationId), "Property is not nullable for class EdFiChartOfAccountReference.");

            if (fiscalYear.IsSet && fiscalYear.Value == null)
                throw new ArgumentNullException(nameof(fiscalYear), "Property is not nullable for class EdFiChartOfAccountReference.");

            if (link.IsSet && link.Value == null)
                throw new ArgumentNullException(nameof(link), "Property is not nullable for class EdFiChartOfAccountReference.");

            return new EdFiChartOfAccountReference(accountIdentifier.Value!, educationOrganizationId.Value!.Value!, fiscalYear.Value!.Value!, link);
        }

        /// <summary>
        /// Serializes a <see cref="EdFiChartOfAccountReference" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiChartOfAccountReference"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EdFiChartOfAccountReference edFiChartOfAccountReference, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, edFiChartOfAccountReference, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EdFiChartOfAccountReference" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="edFiChartOfAccountReference"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, EdFiChartOfAccountReference edFiChartOfAccountReference, JsonSerializerOptions jsonSerializerOptions)
        {
            if (edFiChartOfAccountReference.AccountIdentifier == null)
                throw new ArgumentNullException(nameof(edFiChartOfAccountReference.AccountIdentifier), "Property is required for class EdFiChartOfAccountReference.");

            if (edFiChartOfAccountReference.LinkOption.IsSet && edFiChartOfAccountReference.Link == null)
                throw new ArgumentNullException(nameof(edFiChartOfAccountReference.Link), "Property is required for class EdFiChartOfAccountReference.");

            writer.WriteString("accountIdentifier", edFiChartOfAccountReference.AccountIdentifier);

            writer.WriteNumber("educationOrganizationId", edFiChartOfAccountReference.EducationOrganizationId);

            writer.WriteNumber("fiscalYear", edFiChartOfAccountReference.FiscalYear);

            if (edFiChartOfAccountReference.LinkOption.IsSet)
            {
                writer.WritePropertyName("link");
                JsonSerializer.Serialize(writer, edFiChartOfAccountReference.Link, jsonSerializerOptions);
            }
        }
    }
}
