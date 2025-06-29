

namespace myHr.persistence.Repository;

public class PerformanceEvaluationRepository : GenericRepository<PerformanceEvaluation>, IPerformanceEvaluationRepository
{
    public PerformanceEvaluationRepository(MyHrDbContext context) : base(context)
    {
        
    }
}
