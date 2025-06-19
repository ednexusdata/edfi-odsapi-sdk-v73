# EdFi.OdsApi.Sdk.v73.Models.All.EdFiProgramEvaluation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramEvaluationPeriodDescriptor** | **string** | The name of the period for the program evaluation. | 
**ProgramEvaluationTitle** | **string** | An assigned unique identifier for the student program evaluation. | 
**ProgramEvaluationTypeDescriptor** | **string** | The type of program evaluation conducted. | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**Id** | **string** |  | [optional] 
**EvaluationMaxNumericRating** | **double** | The maximum summary numerical rating or score for the program evaluation. | [optional] 
**EvaluationMinNumericRating** | **double** | The minimum summary numerical rating or score for the program evaluation. If omitted, assumed to be 0.0 | [optional] 
**Levels** | [**List&lt;EdFiProgramEvaluationLevel&gt;**](EdFiProgramEvaluationLevel.md) | An unordered collection of programEvaluationLevels. The descriptive level(s) of ratings (cut scores) for the program evaluation. | [optional] 
**ProgramEvaluationDescription** | **string** | The long description of the program evaluation. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the ProgramEvaluation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

