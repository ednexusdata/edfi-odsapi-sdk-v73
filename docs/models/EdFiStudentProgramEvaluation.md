# EdFi.OdsApi.Sdk.v73.Models.All.EdFiStudentProgramEvaluation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EvaluationDate** | **DateOnly** | The month, day, and year on which the evaluation was conducted. | 
**ProgramEvaluationReference** | [**EdFiProgramEvaluationReference**](EdFiProgramEvaluationReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | [optional] 
**StaffEvaluatorStaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | [optional] 
**EvaluationDuration** | **int** | The actual number of minutes to conduct the evaluation. | [optional] 
**ExternalEvaluators** | [**List&lt;EdFiStudentProgramEvaluationExternalEvaluator&gt;**](EdFiStudentProgramEvaluationExternalEvaluator.md) | An unordered collection of studentProgramEvaluationExternalEvaluators. The external person(s) - not staff - that conducted the evaluation. | [optional] 
**StudentEvaluationElements** | [**List&lt;EdFiStudentProgramEvaluationStudentEvaluationElement&gt;**](EdFiStudentProgramEvaluationStudentEvaluationElement.md) | An unordered collection of studentProgramEvaluationStudentEvaluationElements. The student&#39;s rating and/or rating levels earned for a program evaluation element. | [optional] 
**StudentEvaluationObjectives** | [**List&lt;EdFiStudentProgramEvaluationStudentEvaluationObjective&gt;**](EdFiStudentProgramEvaluationStudentEvaluationObjective.md) | An unordered collection of studentProgramEvaluationStudentEvaluationObjectives. The student&#39;s rating and/or rating levels earned for a program evaluation objective. | [optional] 
**SummaryEvaluationComment** | **string** | Any comments about the summary evaluation to be captured. | [optional] 
**SummaryEvaluationNumericRating** | **double** | The numerical summary rating or score for the evaluation. | [optional] 
**SummaryEvaluationRatingLevelDescriptor** | **string** | The summary rating level achieved based upon the rating or score. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentProgramEvaluation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

