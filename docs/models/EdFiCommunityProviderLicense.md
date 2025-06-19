# EdFi.OdsApi.Sdk.v73.Models.All.EdFiCommunityProviderLicense

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LicenseIdentifier** | **string** | The unique identifier issued by the licensing organization. | 
**LicensingOrganization** | **string** | The organization issuing the license. | 
**CommunityProviderReference** | [**EdFiCommunityProviderReference**](EdFiCommunityProviderReference.md) |  | 
**LicenseEffectiveDate** | **DateOnly** | The month, day, and year on which a license is active or becomes effective.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**LicenseTypeDescriptor** | **string** | An indication of the category of the license. | 
**Id** | **string** |  | [optional] 
**AuthorizedFacilityCapacity** | **int** | The maximum number that can be contained or accommodated which a provider is authorized or licensed to serve. | [optional] 
**LicenseExpirationDate** | **DateOnly** | The month, day, and year on which a license will expire.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**LicenseIssueDate** | **DateOnly** | The month, day, and year on which an active license was issued. | [optional] 
**LicenseStatusDescriptor** | **string** | An indication of the status of the license. | [optional] 
**OldestAgeAuthorizedToServe** | **int** | The oldest age of children a provider is authorized or licensed to serve. | [optional] 
**YoungestAgeAuthorizedToServe** | **int** | The youngest age of children a provider is authorized or licensed to serve. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the CommunityProviderLicense entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

