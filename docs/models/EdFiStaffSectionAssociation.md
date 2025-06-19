# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStaffSectionAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | Month, day, and year of a teacher&#39;s assignment to the section.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**SectionReference** | [**EdFiSectionReference**](EdFiSectionReference.md) |  | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**ClassroomPositionDescriptor** | **string** | The type of position the staff member holds in the specific class/section. | 
**Id** | **string** |  | [optional] 
**EndDate** | **DateOnly** | Month, day, and year of the last day of a staff member&#39;s assignment to the section.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**HighlyQualifiedTeacher** | **bool** | An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for this section being taught. | [optional] 
**PercentageContribution** | **double** | Indicates the percentage of the total scheduled course time, academic standards, and/or learning activities delivered in this section by this staff member. A teacher of record designation may be based solely or partially on this contribution percentage. | [optional] 
**TeacherStudentDataLinkExclusion** | **bool** | Indicates that the entire section is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StaffSectionAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

