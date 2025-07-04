import { Component, output } from '@angular/core';

@Component({
  selector: 'app-add-employee-modal',
  imports: [],
  template:`
  
  <div class="fixed inset-0 z-50 overflow-y-auto">
    <div class="fixed inset-0 bg-black opacity-60" (click)="closeModal()"></div>

  <div class="flex items-center justify-center min-h-screen rounded-3xl">
    <div class="bg-white rounded-lg shadow-xl p-6 m-4 max-w-lg w-full z-10 relative
                transform transition-all ease-out duration-300 scale-100 opacity-100">

      <div class="flex justify-between items-center pb-3 border-b border-gray-200 mb-4">
        <h3 class="text-xl font-semibold text-gray-900">Employee Details</h3>
        <button class="text-gray-400 hover:text-gray-600" (click)="closeModal()">
          <svg class="w-6 h-6" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M6 18L18 6M6 6l12 12"></path></svg>
        </button>
      </div>

      <div class="text-gray-700">
        <p>This is the content of your modal. You can display employee details here, forms, etc.</p>
        <p>Example: Employee Name: John Doe</p>
      </div>

      <div class="mt-6 flex justify-end space-x-4">
        <button (click)="closeModal()"
                class="flex items-center gap-2 px-4 py-2 text-white bg-gray-400 hover:bg-indigo-500 rounded-3xl hover:rounded-xl transition-all duration-300 ease-in-out">
          Close
        </button>
        <button class="flex items-center gap-2 px-4 py-2 text-white bg-gray-700 hover:bg-indigo-500 rounded-3xl hover:rounded-xl transition-all duration-300 ease-in-out">
          Save Changes
        </button>
      </div>

    </div>
  </div>
</div>
  `
})
export class AddEmployeeModal {

  close = output<void>();

  closeModal(): void
  {
    this.close.emit();
  }
}
