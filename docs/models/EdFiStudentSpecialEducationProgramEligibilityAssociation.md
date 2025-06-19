# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentSpecialEducationProgramEligibilityAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConsentToEvaluationReceivedDate** | **DateOnly** | Indicates the date on which the local education agency received written consent for the evaluation from the student&#39;s parent or guardian. This is the first day of the evaluation timeframe. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**IdeaPartDescriptor** | **string** | Indicates if the evaluation is done under Part B IDEA or Part C IDEA. | 
**Id** | **string** |  | [optional] 
**ConsentToEvaluationDate** | **DateOnly** | The date on which the student&#39;s parent gave a consent (Parent Consent Date). | [optional] 
**EligibilityConferenceDate** | **DateOnly** | The month, day, and year when the eligibility conference is held between the parent(s)/guardian(s) and the educational organization responsible staff member(s) to review and make decision on special education related services eligibility. | [optional] 
**EligibilityDelayReasonDescriptor** | **string** | The reason why the eligibility determination was completed beyond the required timeframe. | [optional] 
**EligibilityDeterminationDate** | **DateOnly** | Indicates the month, day, and year the local education agency (LEA) held the admission, review, and dismissal committee meeting regarding the child&#39;s eligibility determination for special education and related services. An individualized education plan (IEP) would be developed and implemented for a child admitted into special education on this same date. | [optional] 
**EligibilityEvaluationDate** | **DateOnly** | Indicates the month, day, and year when the written individual evaluation report was completed. | [optional] 
**EligibilityEvaluationTypeDescriptor** | **string** | Indicates if this is an initial evaluation or a reevaluation. | [optional] 
**EvaluationCompleteIndicator** | **bool** | Indicates the evaluation completed status. | [optional] 
**EvaluationDelayDays** | **int** | Indicates the number of student absences, if any, beginning the first instructional day following the date on which the local education agency (LEA) received written parental or guardian consent for the evaluation. | [optional] 
**EvaluationDelayReasonDescriptor** | **string** | Refers to the justification as to why the evaluation report was completed beyond the state-established timeframe. This descriptor field will have allowed reasons as descriptor values. | [optional] 
**EvaluationLateReason** | **string** | Refers to additional information for delay in doing the evaluation. | [optional] 
**IdeaIndicator** | **bool** | Indicates whether or not the student was determined eligible as a result of an evaluation. | [optional] 
**OriginalECIServicesDate** | **DateOnly** | The month, date, and year when an infant or toddler, from birth through age 2, began participating in the early childhood intervention (ECI) program. | [optional] 
**TransitionConferenceDate** | **DateOnly** | Indicates the month, day, and year when the transition conference was held (for a child receiving early childhood intervention (ECI) services) among the lead agency, the family, and the local education agency (LEA) where the child resides to discuss the child&#39;s potential eligibility for early childhood special education (ECSE) services. | [optional] 
**TransitionNotificationDate** | **DateOnly** | Indicates the month, day, and year the LEA Notification of Potentially Eligible for Special Education Services was sent by the early childhood intervention (ECI) contractor to the local education agency (LEA) to notify them that a child enrolled in ECI will shortly reach the age of eligibility for Part B services and the child is potentially eligible for services under Part B, early childhood special education (ECSE). The LEA Notification constitutes a referral to the LEA for an initial evaluation and eligibility determination of the child which the parent or guardian may opt out from the referral. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentSpecialEducationProgramEligibilityAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

