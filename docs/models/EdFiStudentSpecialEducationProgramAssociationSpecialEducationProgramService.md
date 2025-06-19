# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SpecialEducationProgramServiceDescriptor** | **string** | Indicates the service being provided to the student by the special education program. | 
**PrimaryIndicator** | **bool** | True if service is a primary service. | [optional] 
**ServiceBeginDate** | **DateOnly** | First date the student was in this option for the current school year.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**ServiceEndDate** | **DateOnly** | Last date the student was in this option for the current school year.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**Providers** | [**List&lt;EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider&gt;**](EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider.md) | An unordered collection of studentSpecialEducationProgramAssociationSpecialEducationProgramServiceProviders. The staff providing the service to the student. | [optional] 
**Ext** | **Object** | Extensions to the StudentSpecialEducationProgramAssociationSpecialEducationProgramService entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

