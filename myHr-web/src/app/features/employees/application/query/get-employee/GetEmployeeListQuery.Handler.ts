import { catchError, map, Observable, of } from "rxjs";
import { IQuery } from "../../../../../core/interface/query.interface";
import { GetEmployeeListResponseModel } from "../../../domain/GetEmployeeListResponse.model";
import { GetEmployeeListQuery } from "../../../../employees/application/query/get-employee/GetEmployeeListQuery";
import { Inject, Injectable } from "@angular/core";
import { GetEmployeeList_Service_Token } from "../../../Token/employee.token";
import { IApolloService } from "../../../../../core/interface/apollo-service.interface";

@Injectable()
export class GetEmployeeListQueryHandler implements IQuery<GetEmployeeListQuery, GetEmployeeListResponseModel[]>{
    constructor(@Inject(GetEmployeeList_Service_Token) private getEmployeeListService : IApolloService<GetEmployeeListQuery, GetEmployeeListResponseModel[]>){}

    executeQuery(entity?: GetEmployeeListQuery): Observable<GetEmployeeListResponseModel[]> {
        if (!entity) {
            return of([] as GetEmployeeListResponseModel[]);
        }
        
        return this.getEmployeeListService.executeService(entity).pipe(
            map( result => result ),
            catchError(
                () => of([] as GetEmployeeListResponseModel[])
            )
        )
    }
}