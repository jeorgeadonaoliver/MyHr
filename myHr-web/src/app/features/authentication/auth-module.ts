import { NgModule } from '@angular/core';
import { Login_Apollo_Service_Token, Login_Command_Token } from './domain/tokens/authentication.token';
import { LoginApolloService } from './infrastructure/login.service';
import { LoginCommandHandler } from './application/login/command/login-command.handler';
import { RouterModule, Routes } from '@angular/router';
import { LoginPage } from './presentation/pages/login/login.page';

const authModeulRoutes: Routes = [
    { path: '', component: LoginPage, pathMatch: 'full'},
    { path: 'login', component: LoginPage}
]

@NgModule({
  imports:[ RouterModule.forChild(authModeulRoutes)],
  exports: [RouterModule],
  providers: [
    { provide: Login_Apollo_Service_Token, useClass: LoginApolloService },
    LoginCommandHandler,
    {provide: Login_Command_Token, useClass: LoginCommandHandler},
    LoginPage
  ]
})

export class AuthModule {}
