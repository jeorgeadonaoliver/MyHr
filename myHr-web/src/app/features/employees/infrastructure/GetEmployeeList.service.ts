import { catchError, map, Observable, of, shareReplay, tap } from "rxjs";
import { IApolloService } from "../../../core/interface/apollo-service.interface";
import { GetEmployeeListQuery } from "../application/query/get-employee/GetEmployeeListQuery";
import { GetEmployeeListResponseModel } from "../domain/GetEmployeeListResponse.model";
import { inject, Injectable } from "@angular/core";
import { Apollo } from "apollo-angular";
import { GetEmployeeDocument } from "../graphQL/graphql";
import { ValidateApolloQueryResult } from "../../../core/services/apollo-query-result";
import { AuthTokenService } from "../../../core/services/auth-token.service";

@Injectable()
export class GetEmployeeListService implements IApolloService<GetEmployeeListQuery, GetEmployeeListResponseModel[]>{
    apolloService = inject(Apollo);
    authTokenService = inject(AuthTokenService);
    validateApolloQueryResult = inject(ValidateApolloQueryResult);
    
    executeService(entity: GetEmployeeListQuery): Observable<GetEmployeeListResponseModel[]> {
        //console.log('Auth Service: ', this.authTokenService.getToken());
        return this.apolloService.query<{getEmployee:{data: GetEmployeeListResponseModel[]}}>({
                query: GetEmployeeDocument,
        }).pipe(
            tap( result => {
                this.validateApolloQueryResult.execute(result,"GetEmployeeListService");
            }),
            map( result => { 
                const dt = result.data.getEmployee?.data ?? [];
                console.log('Service', result);
                return result.data?.getEmployee.data ?? []
            }),
            catchError(error => {
                console.error('GetEmployeeListService (network/unexpected error):', error);
                return of([] as GetEmployeeListResponseModel[])
            })
        );
    }
}