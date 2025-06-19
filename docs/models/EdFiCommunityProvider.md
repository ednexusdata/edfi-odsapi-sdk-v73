# EdFi.OdsApi.Sdk.v73.Models.All.EdFiCommunityProvider

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Categories** | [**List&lt;EdFiEducationOrganizationCategory&gt;**](EdFiEducationOrganizationCategory.md) | An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. | 
**CommunityProviderId** | **long** | The identifier assigned to a community provider. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. | 
**NameOfInstitution** | **string** | The full, legally accepted name of the institution. | 
**ProviderCategoryDescriptor** | **string** | Indicates the category of the provider. | 
**ProviderStatusDescriptor** | **string** | Indicates the status of the provider. | 
**Id** | **string** |  | [optional] 
**CommunityOrganizationReference** | [**EdFiCommunityOrganizationReference**](EdFiCommunityOrganizationReference.md) |  | [optional] 
**Addresses** | [**List&lt;EdFiEducationOrganizationAddress&gt;**](EdFiEducationOrganizationAddress.md) | An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4. | [optional] 
**IdentificationCodes** | [**List&lt;EdFiEducationOrganizationIdentificationCode&gt;**](EdFiEducationOrganizationIdentificationCode.md) | An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity. | [optional] 
**Indicators** | [**List&lt;EdFiEducationOrganizationIndicator&gt;**](EdFiEducationOrganizationIndicator.md) | An unordered collection of educationOrganizationIndicators. An indicator or metric of an education organization. | [optional] 
**InstitutionTelephones** | [**List&lt;EdFiEducationOrganizationInstitutionTelephone&gt;**](EdFiEducationOrganizationInstitutionTelephone.md) | An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity. | [optional] 
**InternationalAddresses** | [**List&lt;EdFiEducationOrganizationInternationalAddress&gt;**](EdFiEducationOrganizationInternationalAddress.md) | An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity. | [optional] 
**LicenseExemptIndicator** | **bool** | An indication of whether the provider is exempt from having a license. | [optional] 
**OperationalStatusDescriptor** | **string** | The current operational status of the education organization (e.g., active, inactive). | [optional] 
**ProviderProfitabilityDescriptor** | **string** | Indicates the profitability status of the provider. | [optional] 
**SchoolIndicator** | **bool** | An indication of whether the community provider is a school. | [optional] 
**ShortNameOfInstitution** | **string** | A short name for the institution. | [optional] 
**WebSite** | **string** | The public web site address (URL) for the education organization. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the CommunityProvider entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

