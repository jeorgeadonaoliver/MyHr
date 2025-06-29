namespace myHr.application.Features.PerformanceEvaluations.command.create_performance_evaluation;

public static class CreatePerformanceEvaluationCommandExtension
{
    public static PerformanceEvaluation MapToPerformanceEvaluation(this CreatePerformanceEvaluationCommand cmd) 
    {
        return new PerformanceEvaluation
        {
            Comments = cmd.Comments,
            CreatedBy = cmd.CreatedBy,
            CreatedDate = cmd.CreatedDate,
            EmployeeId = cmd.EmployeeId,
            EvaluationDate = cmd.EvaluationDate,
            EvaluationId = cmd.Id,
            ModifiedBy = cmd.ModifiedBy,
            ModifiedDate = cmd.ModifiedDate,
            Evaluator = cmd.Evaluator,
            Score = cmd.Score,
        };
    }

}
