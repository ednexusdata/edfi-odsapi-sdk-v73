# EdFi.OdsApi.Sdk.v73.Models.All.EdFiAssessmentAdministration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdministrationIdentifier** | **string** | The title or name of the assessment in the context of its administration. | 
**AssessmentReference** | [**EdFiAssessmentReference**](EdFiAssessmentReference.md) |  | 
**AssigningEducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**Id** | **string** |  | [optional] 
**AssessmentBatteryParts** | [**List&lt;EdFiAssessmentAdministrationAssessmentBatteryPart&gt;**](EdFiAssessmentAdministrationAssessmentBatteryPart.md) | An unordered collection of assessmentAdministrationAssessmentBatteryParts. A reference to the parts of the assessment battery that are offered in this administration of the assessment. | [optional] 
**Periods** | [**List&lt;EdFiAssessmentAdministrationPeriod&gt;**](EdFiAssessmentAdministrationPeriod.md) | An unordered collection of assessmentAdministrationPeriods. The anticipated dates for the assessment or administration window. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the AssessmentAdministration entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

