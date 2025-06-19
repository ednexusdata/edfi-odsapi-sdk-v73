# EdFi.OdsApi.Sdk.v73.Models.All.EdFiGrade

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GradeTypeDescriptor** | **string** | The type of grade reported (e.g., exam, final, grading period). | 
**GradingPeriodReference** | [**EdFiGradingPeriodReference**](EdFiGradingPeriodReference.md) |  | 
**StudentSectionAssociationReference** | [**EdFiStudentSectionAssociationReference**](EdFiStudentSectionAssociationReference.md) |  | 
**Id** | **string** |  | [optional] 
**CurrentGradeAsOfDate** | **DateOnly** | As-Of date for a grade posted as the current grade. | [optional] 
**CurrentGradeIndicator** | **bool** | An indicator that the posted grade is an interim grade for the grading period and not the final grade. | [optional] 
**DiagnosticStatement** | **string** | A statement provided by the teacher that provides information in addition to the grade or assessment score. | [optional] 
**GradeEarnedDescription** | **string** | A description of the grade earned by the learner. | [optional] 
**LearningStandardGrades** | [**List&lt;EdFiGradeLearningStandardGrade&gt;**](EdFiGradeLearningStandardGrade.md) | An unordered collection of gradeLearningStandardGrades. A collection of learning standards associated with the grade. | [optional] 
**LetterGradeEarned** | **string** | A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. | [optional] 
**NumericGradeEarned** | **double** | A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. | [optional] 
**PerformanceBaseConversionDescriptor** | **string** | A conversion of the level to a standard set of performance levels. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the Grade entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

