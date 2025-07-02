using myHr.api.GraphQL.PayLoad;
using myHr.application.Features.Departments.query.get_all_departments;
using myHr.application.Features.Departments.query.get_department.by_id;
using myHr.application.Features.JobPositions.query.get_all_jobpositions;
using myHr.application.Features.JobPositions.query.get_jobpositions.by_id;
using myHr.application.Features.LeaveCredits.query.get_all_leavecredits;
using myHr.application.Features.LeaveRequests.query.get_all_leaverequest;
using myHr.application.Features.LeaveRequests.query.get_leaverequest.by_leaverequest_id;
using myHr.application.Features.PerformanceEvaluations.query.get_all_performanceevaluation;
using myHr.application.Features.PerformanceEvaluations.query.get_performanceevaluation.by_id;
using System.Collections.Generic;

namespace myHr.api.Extension;

public static class GraphQLServiceExtension
{
    public static IServiceCollection AddGraphQLService(this IServiceCollection services) {

        services.AddAuthorization();

        services.AddGraphQLServer()
        .AddQueryType(d => d.Name("Query"))
            .AddTypeExtension<EmployeeQuery>()
            .AddTypeExtension<DepartmentQuery>()
            .AddTypeExtension<JobPositionQuery>()
            .AddTypeExtension<LeaveRequestQuery>()
            .AddTypeExtension<LeaveCreditQuery>()
            .AddTypeExtension<PerformanceEvaluationQuery>()

        .AddMutationType(s => s.Name("Mutation"))
            .AddTypeExtension<LoginMutation>()
            .AddTypeExtension<DepartmentMutation>()
            .AddTypeExtension<EmployeeMutation>()
            .AddTypeExtension<LeaveRequestMutation>()
            .AddTypeExtension<LeaveCreditMutation>()
            .AddTypeExtension<PerformanceEvaluationMutation>()

        .AddType<PayLoad<string>>()
        .AddType<PayLoad<Guid>>()
        .AddType<PayLoad<IEnumerable<GetAllDepartmentsQueryDto>>>()
        .AddType<PayLoad<GetDepartmentByIdQueryDto>>()
        .AddType<PayLoad<GetAllLeaveRequestQueryDto>>()
        .AddType<PayLoad<GetLeaveRequestByIdQueryDto>>()
        .AddType<PayLoad<IEnumerable<GetAllLeaveCreditQueryDto>>>()
        .AddType<PayLoad< IEnumerable<GetAllDepartmentsQueryDto>>>()
        .AddType<PayLoad<GetDepartmentByIdQueryDto>>()
        .AddType<PayLoad<IEnumerable<GetAllEmployeeQueryDto>>>()
        .AddType<PayLoad<GetEmployeeByIdQueryDto>>()
        .AddType<PayLoad<IEnumerable<GetAllJobPositionsQueryDto>>>()
        .AddType<PayLoad<GetJobPositionByIdQueryDto>>()
        .AddType<PayLoad<IEnumerable<GetAllPerformanceEvaluationQueryDto>>>()
        .AddType<PayLoad<GetPerformanceEvaluationByIdQueryDto>>()
        .AddType<PayLoad<IEnumerable<GetAllLeaveCreditQueryDto>>>()
        .AddType<PayLoad<GetLeaveRequestByIdQueryDto>>()

        .AddAuthorization();

        return services;
    }
}   
