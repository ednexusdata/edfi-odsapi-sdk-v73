# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStaffInternationalAddress

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressTypeDescriptor** | **string** | The type of address listed for an individual or organization. For example:  Physical Address, Mailing Address, Home Address, etc.) | 
**CountryDescriptor** | **string** | The name of the country. It is strongly recommended that entries use only ISO 3166 2-letter country codes. | 
**AddressLine1** | **string** | The first line of the address. | 
**AddressLine2** | **string** | The second line of the address. | [optional] 
**AddressLine3** | **string** | The third line of the address. | [optional] 
**AddressLine4** | **string** | The fourth line of the address. | [optional] 
**BeginDate** | **DateOnly** | The first date the address is valid. For physical addresses, the date the individual moved to that address.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**EndDate** | **DateOnly** | The last date the address is valid. For physical addresses, the date the individual moved from that address.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**Latitude** | **string** | The geographic latitude of the physical address. | [optional] 
**Longitude** | **string** | The geographic longitude of the physical address. | [optional] 
**Ext** | **Object** | Extensions to the StaffInternationalAddress entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

