# EdFi.OdsApi.Sdk.v73.Models.All.EdFiLearningStandardContentStandard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The name of the content standard, for example Common Core. | 
**PublicationStatusDescriptor** | **string** | The publication status of the document (i.e., Adopted, Draft, Published, Deprecated, Unknown). | [optional] 
**BeginDate** | **DateOnly** | The beginning of the period during which this learning standard document is intended for use.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**EndDate** | **DateOnly** | The end of the period during which this learning standard document is intended for use.  Note: Date interpretation may vary. Ed-Fi recommends inclusive dates, but states may define dates as inclusive or exclusive. For calculations, align with local guidelines. | [optional] 
**PublicationDate** | **DateOnly** | The date on which this content was first published. | [optional] 
**PublicationYear** | **int** | The year at which this content was first published. | [optional] 
**Uri** | **string** | An unambiguous reference to the standards using a network-resolvable URI. | [optional] 
**VarVersion** | **string** | The version identifier for the content. | [optional] 
**MandatingEducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | [optional] 
**Authors** | [**List&lt;EdFiLearningStandardContentStandardAuthor&gt;**](EdFiLearningStandardContentStandardAuthor.md) | An unordered collection of learningStandardContentStandardAuthors. The person or organization chiefly responsible for the intellectual content of the standard. | [optional] 
**Ext** | **Object** | Extensions to the LearningStandardContentStandard entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

