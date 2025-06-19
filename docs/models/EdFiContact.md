# EdFi.OdsApi.Sdk.v73.Models.All.EdFiContact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactUniqueId** | **string** | A unique alphanumeric code assigned to a contact. | 
**FirstName** | **string** | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. | 
**LastSurname** | **string** | The name borne in common by members of a family. | 
**Id** | **string** |  | [optional] 
**PersonReference** | [**EdFiPersonReference**](EdFiPersonReference.md) |  | [optional] 
**Addresses** | [**List&lt;EdFiContactAddress&gt;**](EdFiContactAddress.md) | An unordered collection of contactAddresses. Contact&#39;s address, if different from the student address. | [optional] 
**ElectronicMails** | [**List&lt;EdFiContactElectronicMail&gt;**](EdFiContactElectronicMail.md) | An unordered collection of contactElectronicMails. The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the individual or organization belongs. | [optional] 
**GenderIdentity** | **string** | The gender the contact identifies themselves as. | [optional] 
**GenerationCodeSuffix** | **string** | An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III). | [optional] 
**HighestCompletedLevelOfEducationDescriptor** | **string** | The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received). | [optional] 
**InternationalAddresses** | [**List&lt;EdFiContactInternationalAddress&gt;**](EdFiContactInternationalAddress.md) | An unordered collection of contactInternationalAddresses. The set of elements that describes an international address. | [optional] 
**Languages** | [**List&lt;EdFiContactLanguage&gt;**](EdFiContactLanguage.md) | An unordered collection of contactLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-2 language codes. | [optional] 
**LoginId** | **string** | The login ID for the user; used for security access control interface. | [optional] 
**MaidenName** | **string** | The individual&#39;s maiden name. | [optional] 
**MiddleName** | **string** | A secondary name given to an individual at birth, baptism, or during another naming ceremony. | [optional] 
**OtherNames** | [**List&lt;EdFiContactOtherName&gt;**](EdFiContactOtherName.md) | An unordered collection of contactOtherNames. Other names (e.g., alias, nickname, previous legal name) associated with a person. | [optional] 
**PersonalIdentificationDocuments** | [**List&lt;EdFiContactPersonalIdentificationDocument&gt;**](EdFiContactPersonalIdentificationDocument.md) | An unordered collection of contactPersonalIdentificationDocuments. The documents presented as evident to verify one&#39;s personal identity; for example: drivers license, passport, birth certificate, etc. | [optional] 
**PersonalTitlePrefix** | **string** | A prefix used to denote the title, degree, position, or seniority of the individual. | [optional] 
**PreferredFirstName** | **string** | The first name the individual prefers, if different from their legal first name | [optional] 
**PreferredLastSurname** | **string** | The last name the individual prefers, if different from their legal last name | [optional] 
**SexDescriptor** | **string** | A person&#39;s birth sex. | [optional] 
**Telephones** | [**List&lt;EdFiContactTelephone&gt;**](EdFiContactTelephone.md) | An unordered collection of contactTelephones. The 10-digit telephone number, including the area code, for the person. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the Contact entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

