import { Component, Input } from '@angular/core';
import { RouterLinkActive, RouterModule } from '@angular/router';

@Component({
  selector: 'app-side-navbar-icons',
  imports: [RouterModule, RouterLinkActive],
  template: `

      <a routerLink="{{link}}" routerLinkActive="router-link-active" class="group relative flex items-center justify-center w-12 h-12 rounded-full bg-gray-700 text-gray-300 hover:rounded-2xl hover:bg-indigo-500 hover:text-white transition-all duration-300 ease-in-out">
        <span class="absolute left-full ml-4 px-3 py-1 bg-gray-700 text-white text-sm rounded-md opacity-0 group-hover:opacity-100 group-hover:translate-x-0 transition-all duration-300 ease-in-out whitespace-nowrap pointer-events-none" >{{label}}</span>
        <ng-content></ng-content>
      </a>

  `
})
export class SideNavbarIcons {
    @Input() link!: string;
    @Input() label!: string;
}
