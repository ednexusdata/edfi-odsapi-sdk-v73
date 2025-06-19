# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentEducationOrganizationAssociationDisplacedStudent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplacedStudentStatusDescriptor** | **string** | Indicates whether a student has been displaced as a result of a crisis event. | 
**CrisisEventReference** | [**EdFiCrisisEventReference**](EdFiCrisisEventReference.md) |  | 
**CrisisHomelessnessIndicator** | **bool** | Any student considered homeless (defined by the McKinney-Vento Homeless Education Assistance Act as lacking a fixed, regular, and adequate nighttime residence) as a result of the crisis event. | [optional] 
**DisplacedStudentEndDate** | **DateOnly** | The date marking the end of the period during which a student is considered displaced due to a crisis event.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**DisplacedStudentStartDate** | **DateOnly** | The date on which a student is officially identified as displaced due to a crisis event.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**Ext** | **Object** | Extensions to the StudentEducationOrganizationAssociationDisplacedStudent entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

