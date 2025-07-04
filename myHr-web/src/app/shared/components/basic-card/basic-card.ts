import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-basic-card',
  imports: [],
  template: `
      <div class="bg-white p-6 rounded-xl shadow-md">
        <div class="flex items-center justify-between mb-4">
          <h3 class="text-xl font-semibold m-0">{{ cardTitle }}</h3>
          <ng-content select="[card-action]"></ng-content>
        </div>
        <ng-content></ng-content>
      </div>


  `
})
export class BasicCard {

  @Input() cardTitle!: string;
}
