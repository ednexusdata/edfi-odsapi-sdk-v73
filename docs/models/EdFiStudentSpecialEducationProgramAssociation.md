# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentSpecialEducationProgramAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**Disabilities** | [**List&lt;EdFiStudentSpecialEducationProgramAssociationDisability&gt;**](EdFiStudentSpecialEducationProgramAssociationDisability.md) | An unordered collection of studentSpecialEducationProgramAssociationDisabilities. The disability condition(s) that best describes an individual&#39;s impairment, as related to special education services received. | [optional] 
**EndDate** | **DateOnly** | The month, day, and year on which the student exited the program or stopped receiving services.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**IdeaEligibility** | **bool** | Indicator of the eligibility of the student to receive special education services according to the Individuals with Disabilities Education Act (IDEA). | [optional] 
**IepBeginDate** | **DateOnly** | The effective date of the most recent IEP.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**IepEndDate** | **DateOnly** | The end date of the most recent IEP.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**IepReviewDate** | **DateOnly** | The date of the last IEP review. | [optional] 
**LastEvaluationDate** | **DateOnly** | The date of the last special education evaluation. | [optional] 
**MedicallyFragile** | **bool** | Indicates whether the student receiving special education and related services is: 1) in the age range of birth to 22 years, and 2) has a serious, ongoing illness or a chronic condition that has lasted or is anticipated to last at least 12 or more months or has required at least one month of hospitalization, and that requires daily, ongoing medical treatments and monitoring by appropriately trained personnel which may include parents or other family members, and 3) requires the routine use of medical device or of assistive technology to compensate for the loss of usefulness of a body function needed to participate in activities of daily living, and 4) lives with ongoing threat to his or her continued well-being. Aligns with federal requirements. | [optional] 
**MultiplyDisabled** | **bool** | Indicates whether the student receiving special education and related services has been designated as multiply disabled by the admission, review, and dismissal committee as aligned with federal requirements. | [optional] 
**ProgramParticipationStatuses** | [**List&lt;EdFiGeneralStudentProgramAssociationProgramParticipationStatus&gt;**](EdFiGeneralStudentProgramAssociationProgramParticipationStatus.md) | An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the student left the program within a school or district. | [optional] 
**ReductionInHoursPerWeekComparedToPeers** | **double** | Records the number of hours reduced for the shortened school day for the IEP student as compared to peers in regular education. | [optional] 
**SchoolHoursPerWeek** | **double** | Indicate the total number of hours of instructional time per week for the school that the student attends. | [optional] 
**ServedOutsideOfRegularSession** | **bool** | Indicates whether the student received services during the summer session or between sessions. | [optional] 
**ServiceProviders** | [**List&lt;EdFiStudentSpecialEducationProgramAssociationServiceProvider&gt;**](EdFiStudentSpecialEducationProgramAssociationServiceProvider.md) | An unordered collection of studentSpecialEducationProgramAssociationServiceProviders. The staff providing special education services to the student. | [optional] 
**ShortenedSchoolDayIndicator** | **bool** | Indicator that the student&#39;s IEP requires a shortened school day. | [optional] 
**SpecialEducationExitDate** | **DateOnly** | The  month, day and year on which a person stops receiving special education services. | [optional] 
**SpecialEducationExitExplained** | **string** | Explanation on why a person stops receiving special education services. | [optional] 
**SpecialEducationExitReasonDescriptor** | **string** | The reason why a person stops receiving special education services. | [optional] 
**SpecialEducationHoursPerWeek** | **double** | The number of hours per week for special education instruction and therapy. | [optional] 
**SpecialEducationProgramServices** | [**List&lt;EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService&gt;**](EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.md) | An unordered collection of studentSpecialEducationProgramAssociationSpecialEducationProgramServices. Indicates the service(s) being provided to the student by the special education program. | [optional] 
**SpecialEducationSettingDescriptor** | **string** | The major instructional setting (more than 50 percent of a student&#39;s special education program). | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentSpecialEducationProgramAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

