using myHr.application.Features.PerformanceEvaluations.query.get_all_performanceevaluation;

namespace myHr.application.Extension;

public static class PerformanceEvaluationExtension
{
    public static GetPerformanceEvaluationByIdQueryDto MapToGetPerformanceEvaluationByIdQueryDto(this PerformanceEvaluation pe) 
    {
        return new GetPerformanceEvaluationByIdQueryDto { 
        
            EmployeeId = pe.EmployeeId,
            EvaluationDate = pe.EvaluationDate,
            Comments = pe.Comments,
            CreatedBy = pe.CreatedBy,
            CreatedDate = pe.CreatedDate,
            ModifiedBy = pe.ModifiedBy,
            ModifiedDate = pe.ModifiedDate,
            Id = pe.EvaluationId,
            Evaluator = pe.Evaluator,
            Score = pe.Score,
        };
    }

    public static GetAllPerformanceEvaluationQueryDto MapToGetAllPerformanceEvaluationQueryDto(this PerformanceEvaluation pe)
    {
        return new GetAllPerformanceEvaluationQueryDto
        {

            EmployeeId = pe.EmployeeId,
            EvaluationDate = pe.EvaluationDate,
            Comments = pe.Comments,
            CreatedBy = pe.CreatedBy,
            CreatedDate = pe.CreatedDate,
            ModifiedBy = pe.ModifiedBy,
            ModifiedDate = pe.ModifiedDate,
            Id = pe.EvaluationId,
            Evaluator = pe.Evaluator,
            Score = pe.Score,
        };
    }
}
