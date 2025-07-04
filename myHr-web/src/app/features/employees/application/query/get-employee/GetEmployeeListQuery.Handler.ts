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

    executeQuery(_: GetEmployeeListQuery = {}): Observable<GetEmployeeListResponseModel[]> {
        
        return this.getEmployeeListService.executeService({}).pipe(
            map( result => { 
                console.log("Handler: ", result);
                return result
            }),
            catchError(
                () => of([] as GetEmployeeListResponseModel[])
            )
        )
    }
}