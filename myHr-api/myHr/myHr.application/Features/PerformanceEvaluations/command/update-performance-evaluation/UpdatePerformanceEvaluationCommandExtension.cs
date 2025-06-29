namespace myHr.application.Features.PerformanceEvaluations.command.update_performance_evaluation;

public static class UpdatePerformanceEvaluationCommandExtension 
{
    public static PerformanceEvaluation MapToPerformanceEvaluation(this UpdatePerformanceEvaluationCommand cmd) 
    {
        return new PerformanceEvaluation { 
        
            Comments = cmd.Comments,
            CreatedBy = cmd.CreatedBy,
            CreatedDate = cmd.CreatedDate,
            EmployeeId = cmd.EmployeeId,
            EvaluationDate = cmd.EvaluationDate,
            EvaluationId = cmd.Id,
            Evaluator = cmd.Evaluator,
            ModifiedBy = cmd.ModifiedBy,
            ModifiedDate = cmd.ModifiedDate,
            Score = cmd.Score,
        };
    }
}
