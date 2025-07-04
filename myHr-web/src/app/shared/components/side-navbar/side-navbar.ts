import { Component } from '@angular/core';
import { LayoutModule } from '@angular/cdk/layout';
import { CommonModule } from '@angular/common';
import { IconsModule } from '../icons-module/icons-module';
import { SideNavbarIcons } from './side-navbar-icons/side-navbar-icons';

@Component({
  selector: 'app-side-navbar',
  imports: [LayoutModule, CommonModule, IconsModule, SideNavbarIcons],
  template:`
      <div class="fixed top-0 left-0 h-screen w-20 flex flex-col bg-gray-800 shadow-lg z-50 ">
        <div class="flex items-center justify-center h-20 mt-2">
          <img src="venve-logo.png" alt="Venve Logo" class="h-full object-contain transition-all duration-300 hover:brightness-150">
        </div>
        <nav class="relative flex flex-col items-center flex-grow py-4 space-y-3 overflow-hidden">
          <app-side-navbar-icons  link ='/main/dashboard'>
            <ng-icon name="matDashboard" routerLinkActive="router-link-active" size="26" color="white"></ng-icon>
          </app-side-navbar-icons>
          <app-side-navbar-icons link ='/main/employeelist' label="Employee List">
            <ng-icon name="matPeopleAlt" routerLinkActive="router-link-active" size="26" color="white"></ng-icon>
          </app-side-navbar-icons>
          <app-side-navbar-icons>
            <ng-icon name="matFolder" size="26" color="white"></ng-icon>
          </app-side-navbar-icons>
          <app-side-navbar-icons>
            <ng-icon name="matSettings" size="26" color="white"></ng-icon>
          </app-side-navbar-icons>

          <div class="mt-auto flex flex-col items-center space-y-3">
            <app-side-navbar-icons>
              <ng-icon name="matManageAccounts" size="26" color="white"></ng-icon>
            </app-side-navbar-icons>
            <app-side-navbar-icons>
              <ng-icon name="matLogout" size="26" color="white"></ng-icon>
            </app-side-navbar-icons> 
          </div>
        </nav>
      </div>
  `
})
export class SideNavbar{}
