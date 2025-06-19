# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentSectionAssociationReference

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | Month, day, and year of the student&#39;s entry or assignment to the section.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**LocalCourseCode** | **string** | The local code assigned by the School that identifies the course offering provided for the instruction of students. | 
**SchoolId** | **long** | The identifier assigned to a school. It must be distinct from any other identifier assigned to educational organizations, such as a LocalEducationAgencyId, to prevent duplication. | 
**SchoolYear** | **int** | The identifier for the school year. | 
**SectionIdentifier** | **string** | The local identifier assigned to a section. | 
**SessionName** | **string** | The identifier for the calendar for the academic session. | 
**StudentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | 
**Link** | [**Link**](Link.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

