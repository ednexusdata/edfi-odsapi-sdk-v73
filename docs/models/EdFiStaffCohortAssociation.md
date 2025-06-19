# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStaffCohortAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | Start date for the association of staff to this cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**CohortReference** | [**EdFiCohortReference**](EdFiCohortReference.md) |  | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**Id** | **string** |  | [optional] 
**EndDate** | **DateOnly** | End date for the association of staff to this cohort.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**StudentRecordAccess** | **bool** | Indicator of whether the staff has access to the student records of the cohort per district interpretation of FERPA and other privacy laws, regulations, and policies. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StaffCohortAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

