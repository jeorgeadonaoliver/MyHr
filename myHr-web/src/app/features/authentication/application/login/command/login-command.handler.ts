import { LoginCommand } from "../command/login.command";
import { catchError, Observable, of, map } from "rxjs";
import { Inject, Injectable } from "@angular/core";
import { LoginMutationResponseModel } from "../../../domain/models/login-mutation-reponse.model";
import { Login_Apollo_Service_Token } from "../../../domain/tokens/authentication.token";
import { ICommand } from "../../../../../core/interface/command.interface";
import { CommandResponse } from "../../../../../core/models/command-response.model";
import { IApolloService } from "../../../../../core/interface/apollo-service.interface";
import { AuthService } from "../../../../../core/services/auth.service";

@Injectable()
export class LoginCommandHandler implements ICommand<LoginCommand, CommandResponse>{
    constructor(@Inject(Login_Apollo_Service_Token) 
                private loginApolloService: IApolloService<LoginCommand, LoginMutationResponseModel>,
                private authService : AuthService){}

    executeCommand(command: LoginCommand): Observable<CommandResponse> {
        return this.loginApolloService.executeService(command).pipe(
            map((response) => {
                this.authService.setToken(response.login.token);
                console.log('passed handler');

                return {
                    isSuccess: response.login.success,
                    message: response.login.message
                } as CommandResponse
            }),
            catchError(err => {
                return of({
                    isSuccess: false,
                    message: 'Login Failed! ' + (err?.message || 'unknown error'),
                } as CommandResponse)
            })  
        );
    }
}