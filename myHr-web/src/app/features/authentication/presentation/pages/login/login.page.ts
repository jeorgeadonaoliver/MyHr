import { Component, Inject, inject, OnDestroy, OnInit } from '@angular/core';
import { LoginCommand } from '../../../application/login/command/login.command';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { LoginCommandHandler } from '../../../application/login/command/login-command.handler';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { LoginApolloService } from '../../../infrastructure/login.service';
import { Login_Apollo_Service_Token, Login_Command_Token } from '../../../domain/tokens/authentication.token';
import { ValidateForm } from '../../../../../core/services/validate-form';

@Component({
  selector: 'app-login',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './login.page.html',
  providers: [LoginApolloService, LoginCommandHandler]
})
export class LoginPage implements OnInit, OnDestroy{
  constructor(@Inject(Login_Command_Token) private loginCommand : LoginCommandHandler){}

  private validateForm = inject(ValidateForm);
  loginFormGroup!: FormGroup;
  errorMessage: string = '';
  private subscriptions = new Subscription();

  private route = inject(Router);
  private fb = inject(FormBuilder);

  buildForm() : void {
    this.loginFormGroup = this.fb.group({
          username: ['',[Validators.required]],
          password: ['',[Validators.required]]
        });
  }

  ngOnInit(): void {
    this.buildForm();
  }

  onSubmit() : void {
    this.errorMessage = '';

    var _result = this.validateForm.execute(this.loginFormGroup);
    if(!_result.isValid){
      this.errorMessage = _result.message;
      return;
    }
    
    const { username, password } = this.loginFormGroup.value;
    const loginCommand = new LoginCommand(username, password);

    this.subscriptions.add(
       this.loginCommand.executeCommand(loginCommand).subscribe({
        next: result => {
          if(result.isSuccess)
            this.route.navigate(['/main/dashboard']);
          }
      })
    );
  }

  ngOnDestroy(): void {
    this.subscriptions.unsubscribe();
  }
}
