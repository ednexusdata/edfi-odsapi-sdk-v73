# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStaffLeave

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | The begin date of the staff leave.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**StaffLeaveEventCategoryDescriptor** | **string** | The code describing the type of leave taken. | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**Id** | **string** |  | [optional] 
**EndDate** | **DateOnly** | The end date of the staff leave.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**Reason** | **string** | Expanded reason for the staff leave. | [optional] 
**SubstituteAssigned** | **bool** | Indicator of whether a substitute was assigned during the period of staff leave. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StaffLeave entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

