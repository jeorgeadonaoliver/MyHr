import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { IconsModule } from '../../components/icons-module/icons-module';
import { SideNavbar } from "../../components/side-navbar/side-navbar";

@Component({
  selector: 'app-main-layout',
  imports: [RouterOutlet, CommonModule, IconsModule, SideNavbar],
  template:`
      <app-side-navbar/>
      <main class="flex-grow p-6 md:p-8 transition-all duration-300 ease-in-out ml-20 bg-gray-200 h-full">
        <router-outlet />
      </main>
  `,
})

export class MainLayout {}
