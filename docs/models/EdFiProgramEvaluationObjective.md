# EdFi.OdsApi.Sdk.v73.Models.All.EdFiProgramEvaluationObjective

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramEvaluationObjectiveTitle** | **string** | The name or title of the program evaluation objective. | 
**ProgramEvaluationReference** | [**EdFiProgramEvaluationReference**](EdFiProgramEvaluationReference.md) |  | 
**Id** | **string** |  | [optional] 
**ObjectiveMaxNumericRating** | **double** | The maximum summary numerical rating or score for the program evaluation objective. | [optional] 
**ObjectiveMinNumericRating** | **double** | The minimum summary numerical rating or score for the program evaluation objective. If omitted, assumed to be 0.0 | [optional] 
**ObjectiveSortOrder** | **int** | The sort order of this program evaluation objective. | [optional] 
**ProgramEvaluationLevels** | [**List&lt;EdFiProgramEvaluationObjectiveProgramEvaluationLevel&gt;**](EdFiProgramEvaluationObjectiveProgramEvaluationLevel.md) | An unordered collection of programEvaluationObjectiveProgramEvaluationLevels. The descriptive level(s) of ratings (cut scores) for the program evaluation objective. | [optional] 
**ProgramEvaluationObjectiveDescription** | **string** | The long description of the program evaluation objective. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the ProgramEvaluationObjective entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

