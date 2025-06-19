# EdFi.OdsApi.Sdk.v73.Models.All.TrackedChangesEdFiGradeKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GradeTypeDescriptor** | **string** | The type of grade reported (e.g., exam, final, grading period). | [optional] 
**GradingPeriodDescriptor** | **string** | The state&#39;s name of the period for which grades are reported. | [optional] 
**GradingPeriodName** | **string** | The school&#39;s descriptive name of the grading period. | [optional] 
**SchoolId** | **long** | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. | [optional] 
**GradingPeriodSchoolYear** | **int** | The identifier for the grading period school year. | [optional] 
**BeginDate** | **DateOnly** | Month, day, and year of the student&#39;s entry or assignment to the section.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**LocalCourseCode** | **string** | The local code assigned by the School that identifies the course offering provided for the instruction of students. | [optional] 
**SchoolYear** | **int** | The identifier for the school year. | [optional] 
**SectionIdentifier** | **string** | The local identifier assigned to a section. | [optional] 
**SessionName** | **string** | The identifier for the calendar for the academic session. | [optional] 
**StudentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

