# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentSection504ProgramAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Section504Eligibility** | **bool** | Indicates whether student has a disability, either temporary or permenant, that qualifies student for Section 504 consideration. Selection of FALSE for this boolean is equivalent to marking student as &#39;Did Not Qualify&#39;. | 
**Id** | **string** |  | [optional] 
**AccommodationPlan** | **bool** | Indicates whether student has a Section 504 accommodation plan. | [optional] 
**EndDate** | **DateOnly** | The month, day, and year on which the student exited the program or stopped receiving services.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**ProgramParticipationStatuses** | [**List&lt;EdFiGeneralStudentProgramAssociationProgramParticipationStatus&gt;**](EdFiGeneralStudentProgramAssociationProgramParticipationStatus.md) | An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the student left the program within a school or district. | [optional] 
**Section504DisabilityDescriptor** | **string** | Defines one or more disabilities student has that qualifies them for a Section 504 plan. | [optional] 
**Section504EligibilityDecisionDate** | **DateOnly** | The month, day, and year on which the Section 504 eligibility decision is made. | [optional] 
**Section504MeetingDate** | **DateOnly** | The month, day, and year on which the meeting with student&#39;s parent/guardian held to discuss the 504 eligibility of the student. | [optional] 
**ServedOutsideOfRegularSession** | **bool** | Indicates whether the student received services during the summer session or between sessions. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentSection504ProgramAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

