import { Component, Input, signal } from '@angular/core';

@Component({
  selector: 'app-page-title',
  imports: [],
  template: `
      <h2 class="text-3xl font-bold text-gray-800 mb-6">{{ pageTitle}}</h2>
  `,
})
export class PageTitle {
    @Input() pageTitle!: string;
}
