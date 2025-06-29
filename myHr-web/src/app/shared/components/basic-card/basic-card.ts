import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-basic-card',
  imports: [],
  template: `
      <div class="bg-white p-6 rounded-xl shadow-md">
        <h3 class="text-xl font-semibold mb-2">{{ cardTitle}}</h3>
          <ng-content> </ng-content>
      </div>

  `
})
export class BasicCard {

  @Input() cardTitle!: string;
}
