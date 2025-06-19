# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentCTEProgramAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**CteProgramServices** | [**List&lt;EdFiStudentCTEProgramAssociationCTEProgramService&gt;**](EdFiStudentCTEProgramAssociationCTEProgramService.md) | An unordered collection of studentCTEProgramAssociationCTEProgramServices. Indicates the service(s) being provided to the student by the CTE program. | [optional] 
**EndDate** | **DateOnly** | The month, day, and year on which the student exited the program or stopped receiving services.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**NonTraditionalGenderStatus** | **bool** | Indicator that student is from a gender group that comprises less than 25% of the individuals employed in an occupation or field of work. | [optional] 
**PrivateCTEProgram** | **bool** | Indicator that student participated in career and technical education at private agencies or institutions that are reported by the state for purposes of the Elementary and Secondary Education Act (ESEA). Students in private institutions which do not receive Perkins funding are reported only in the state file. | [optional] 
**ProgramParticipationStatuses** | [**List&lt;EdFiGeneralStudentProgramAssociationProgramParticipationStatus&gt;**](EdFiGeneralStudentProgramAssociationProgramParticipationStatus.md) | An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the student left the program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool** | Indicates whether the student received services during the summer session or between sessions. | [optional] 
**TechnicalSkillsAssessmentDescriptor** | **string** | Results of technical skills assessment aligned with industry recognized standards. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentCTEProgramAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

