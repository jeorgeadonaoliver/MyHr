using myHr.application.Features.Departments.query.get_all_departments;
using myHr.application.Features.Departments.query.get_department.by_id;

namespace myHr.api.Extension;

public static class GraphQLServiceExtension
{
    public static IServiceCollection AddGraphQLService(this IServiceCollection services) {

        services.AddAuthorization();

        services.AddGraphQLServer()
        .AddQueryType(d => d.Name("Query"))
            .AddTypeExtension<EmployeeQuery>()
            .AddTypeExtension<DepartmentQuery>()

        .AddMutationType(s => s.Name("Mutation"))
            .AddTypeExtension<LoginMutation>()
            .AddTypeExtension<DepartmentMutation>()
            .AddTypeExtension<EmployeeMutation>()

        .AddType<PayLoad<string>>()
        .AddType<PayLoad<Guid>>()
        .AddType<PayLoad<IEnumerable<GetAllDepartmentsQueryDto>>>()
        .AddType<PayLoad<GetDepartmentByIdQueryDto>>()

        .AddAuthorization();

        return services;
    }
}   
