# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentAssessmentRegistration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssessmentAdministrationReference** | [**EdFiAssessmentAdministrationReference**](EdFiAssessmentAdministrationReference.md) |  | 
**StudentEducationOrganizationAssociationReference** | [**EdFiStudentEducationOrganizationAssociationReference**](EdFiStudentEducationOrganizationAssociationReference.md) |  | 
**StudentSchoolAssociationReference** | [**EdFiStudentSchoolAssociationReference**](EdFiStudentSchoolAssociationReference.md) |  | 
**Id** | **string** |  | [optional] 
**ReportingEducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | [optional] 
**ScheduledStudentEducationOrganizationAssessmentAccommodationReference** | [**EdFiStudentEducationOrganizationAssessmentAccommodationReference**](EdFiStudentEducationOrganizationAssessmentAccommodationReference.md) |  | [optional] 
**TestingEducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | [optional] 
**AssessmentAccommodations** | [**List&lt;EdFiStudentAssessmentRegistrationAssessmentAccommodation&gt;**](EdFiStudentAssessmentRegistrationAssessmentAccommodation.md) | An unordered collection of studentAssessmentRegistrationAssessmentAccommodations. The special variation(s) to be used in how assessments (in general) are presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. | [optional] 
**AssessmentCustomizations** | [**List&lt;EdFiStudentAssessmentRegistrationAssessmentCustomization&gt;**](EdFiStudentAssessmentRegistrationAssessmentCustomization.md) | An unordered collection of studentAssessmentRegistrationAssessmentCustomizations. Key/value pairs which may be used to facilitate customization of an assessment or to support vendor reporting/analysis. | [optional] 
**AssessmentGradeLevelDescriptor** | **string** | The grade level or primary instructional level at which the student is to be assessed. | [optional] 
**PlatformTypeDescriptor** | **string** | The environment or format in which the assessment is expected to be administered. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentAssessmentRegistration entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

