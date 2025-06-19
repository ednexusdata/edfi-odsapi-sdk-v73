# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentSectionAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | Month, day, and year of the student&#39;s entry or assignment to the section.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**SectionReference** | [**EdFiSectionReference**](EdFiSectionReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**DualCreditEducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | [optional] 
**AttemptStatusDescriptor** | **string** | An indication of the student&#39;s completion status for the section. | [optional] 
**DualCreditIndicator** | **bool** | Indicates whether the student assigned to the section is to receive dual credit upon successful completion. | [optional] 
**DualCreditInstitutionDescriptor** | **string** | Descriptor for the postsecondary institution offering college credit. This descriptor may be used to select a postsecondary institution that is not defined as an education organization, and/or select a general type of postsecondary institution. | [optional] 
**DualCreditTypeDescriptor** | **string** | For a student taking a dual credit course in a college or high school setting, indicates the type of dual credit program. | [optional] 
**DualHighSchoolCreditIndicator** | **bool** | Indicates whether successful completion of the course will result in credits toward high school graduation. | [optional] 
**EndDate** | **DateOnly** | Month, day, and year of the withdrawal or exit of the student from the section.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**HomeroomIndicator** | **bool** | Indicates the section is the student&#39;s homeroom. Homeroom period may the convention for taking daily attendance. | [optional] 
**Programs** | [**List&lt;EdFiStudentSectionAssociationProgram&gt;**](EdFiStudentSectionAssociationProgram.md) | An unordered collection of studentSectionAssociationPrograms. The program(s) that the student is participating in the context of the course. | [optional] 
**RepeatIdentifierDescriptor** | **string** | An indication as to whether a student has previously taken a given course. | [optional] 
**TeacherStudentDataLinkExclusion** | **bool** | Indicates that the student-section combination is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentSectionAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

