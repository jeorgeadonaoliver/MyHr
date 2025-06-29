import { Apollo } from "apollo-angular";
import { LoginCommand } from "../application/login/command/login.command";
import { catchError, map, Observable, of, tap } from 'rxjs';
import { Failed_LoginMutationResponse, LoginMutationResponseModel } from "../domain/models/login-mutation-reponse.model";
import { inject, Injectable } from "@angular/core";
import { LoginDocument } from "../graphQL/graphql";
import { IApolloService } from "../../../core/interface/apollo-service.interface";
import { ValidateApolloMutateResult } from "../../../core/services/apollo-mutate-result";

@Injectable()
export class LoginApolloService implements IApolloService<LoginCommand, LoginMutationResponseModel> {
    private apollo = inject(Apollo);
    private validateApolloMutateResult = inject(ValidateApolloMutateResult<LoginMutationResponseModel>);

    executeService(entity: LoginCommand): Observable<LoginMutationResponseModel>{
        return this.apollo.mutate<LoginMutationResponseModel>({
                mutation: LoginDocument,
                variables: {
                    command:{
                        username : entity.username,
                        password : entity.password
                    },  
                },
            }).pipe(
                tap(result =>{
                    this.validateApolloMutateResult.execute(result, "LoginApolloService");
                }),
                map(result => {return result.data!}),
                catchError(error => {
                    console.error('Login failed (network/unexpected error):', error);
                    return of(Failed_LoginMutationResponse);
                })
        );
    }
};