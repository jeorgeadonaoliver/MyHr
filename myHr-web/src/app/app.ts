import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { AuthModule } from './features/authentication/auth-module';
import { DashModule } from './features/dashboard/dash-module';
import { NgIconsModule } from '@ng-icons/core';
import { IconsModule } from './shared/components/icons-module/icons-module';


@Component({
  selector: 'app-root',
  imports: [RouterOutlet, ReactiveFormsModule, AuthModule, DashModule, 
    IconsModule,
  ],
  styleUrl: './app.css',
  template: `
    <router-outlet />
  `,
})
export class App {
  protected title = 'myHr-angular';
}
