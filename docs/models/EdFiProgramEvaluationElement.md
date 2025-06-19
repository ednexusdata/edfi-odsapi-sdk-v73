# EdFi.OdsApi.Sdk.v73.Models.All.EdFiProgramEvaluationElement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramEvaluationElementTitle** | **string** | The name or title of the program evaluation element. | 
**ProgramEvaluationReference** | [**EdFiProgramEvaluationReference**](EdFiProgramEvaluationReference.md) |  | 
**Id** | **string** |  | [optional] 
**ProgramEvaluationObjectiveReference** | [**EdFiProgramEvaluationObjectiveReference**](EdFiProgramEvaluationObjectiveReference.md) |  | [optional] 
**ElementMaxNumericRating** | **double** | The maximum summary numerical rating or score for the program evaluation element. | [optional] 
**ElementMinNumericRating** | **double** | The minimum summary numerical rating or score for the program evaluation element. If omitted, assumed to be 0.0. | [optional] 
**ElementSortOrder** | **int** | The sort order of this program evaluation element. | [optional] 
**ProgramEvaluationElementDescription** | **string** | The long description of the program evaluation element. | [optional] 
**ProgramEvaluationLevels** | [**List&lt;EdFiProgramEvaluationElementProgramEvaluationLevel&gt;**](EdFiProgramEvaluationElementProgramEvaluationLevel.md) | An unordered collection of programEvaluationElementProgramEvaluationLevels. The descriptive level(s) of ratings (cut scores) for the program evaluation element. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the ProgramEvaluationElement entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

