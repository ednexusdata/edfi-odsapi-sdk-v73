# EdFi.OdsApi.Sdk.v73.Models.All.EdFiAssessmentItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentificationCode** | **string** | A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, state, or other agency or entity. | 
**AssessmentReference** | [**EdFiAssessmentReference**](EdFiAssessmentReference.md) |  | 
**Id** | **string** |  | [optional] 
**AssessmentItemCategoryDescriptor** | **string** | Category or type of the assessment item. | [optional] 
**AssessmentItemURI** | **string** | The URI (typical a URL) pointing to the entry in an assessment item bank, which describes this content item. | [optional] 
**ExpectedTimeAssessed** | **string** | The duration allotted for the assessment item expressed in minutes. | [optional] 
**ItemText** | **string** | The text of the item. | [optional] 
**LearningStandards** | [**List&lt;EdFiAssessmentItemLearningStandard&gt;**](EdFiAssessmentItemLearningStandard.md) | An unordered collection of assessmentItemLearningStandards. Learning standard tested by this item. | [optional] 
**MaxRawScore** | **double** | The maximum raw score achievable across all assessment items that are correct and scored at the maximum. | [optional] 
**Nomenclature** | **string** | Reflects the specific nomenclature used for assessment item. | [optional] 
**PossibleResponses** | [**List&lt;EdFiAssessmentItemPossibleResponse&gt;**](EdFiAssessmentItemPossibleResponse.md) | An unordered collection of assessmentItemPossibleResponses. A possible response to an assessment item. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the AssessmentItem entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

