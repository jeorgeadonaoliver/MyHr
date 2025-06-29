import { InjectionToken } from '@angular/core';
import { ICommand } from '../../../../core/interface/command.interface';
import { LoginCommand } from '../../application/login/command/login.command';
import { CommandResponse } from '../../../../core/models/command-response.model';
import { IApolloService } from '../../../../core/interface/apollo-service.interface';
import { LoginMutationResponseModel } from '../models/login-mutation-reponse.model';

export const Login_Apollo_Service_Token = new InjectionToken<IApolloService<LoginCommand, LoginMutationResponseModel>>('Login_Apollo_Service_Token');
export const Login_Command_Token = new InjectionToken<ICommand<LoginCommand, CommandResponse>>('Login_Command_Token');
