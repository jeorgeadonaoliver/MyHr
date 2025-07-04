import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { AuthModule } from './features/authentication/auth-module';
import { DashModule } from './features/dashboard/dash-module';
import { IconsModule } from './shared/components/icons-module/icons-module';
import { EmpModule } from './features/employees/emp-module';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatInputModule } from '@angular/material/input';
import { ScrollingModule } from '@angular/cdk/scrolling';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, ReactiveFormsModule, AuthModule, DashModule, EmpModule,
    IconsModule,     MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatInputModule,
    ScrollingModule,
    MatProgressSpinnerModule
  ],
  styleUrl: './app.css',
  template: `
    <router-outlet />
  `,
})
export class App {
  protected title = 'myHr-angular';
}
