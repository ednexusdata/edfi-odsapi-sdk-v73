# EdFi.OdsApi.Sdk.v73.Models.All.EdFiFeederSchoolAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | The month, day, and year of the first day of the feeder school association.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**FeederSchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**Id** | **string** |  | [optional] 
**EndDate** | **DateOnly** | The month, day, and year of the last day of the feeder school association.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**FeederRelationshipDescription** | **string** | Describes the relationship from the feeder school to the receiving school, for example by program emphasis, such as special education, language immersion, science, or performing art. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the FeederSchoolAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

