import { Component, Input, signal, WritableSignal } from '@angular/core';
import { GetEmployeeListResponseModel } from '../../../domain/GetEmployeeListResponse.model';
import { CommonModule } from '@angular/common';
import { IconsModule } from '../../../../../shared/components/icons-module/icons-module';

@Component({
  selector: 'app-employee-list',
  imports: [CommonModule, IconsModule],
  template: `
<div class="overflow-x-auto rounded-3xl">
<table class="min-w-full text-sm text-left text-gray-700 dark:text-gray-500 rounded-3xl">
  <thead class="bg-gray-100 dark:bg-gray-800 text-xs uppercase text-gray-500 dark:text-gray-300">
    <tr class="text-center">
      <th scope="col" class="px-4 py-3 text-right">Actions</th>
      @for (thItem of _tblHeader; track $index) {
        <th scope="col" class="px-4 py-3">
          {{thItem}}
        </th>
      }
    </tr>
  </thead>

    <tbody class="divide-y divide-gray-300 dark:divide-gray-600">
      @for (item of _employeeListSignal(); track $index) {
        <tr class="hover:bg-gray-200 hover:text-black transition-colors">
          <td class="px-4 py-3 text-right flex">
            <button class=" inline-flex items-center justify-center
                w-10 h-10 rounded-full
                text-blue-600 dark:text-blue-400
                hover:bg-blue-100 dark:hover:bg-blue-900
                focus:outline-none focus:ring-2 focus:ring-blue-500 focus:ring-opacity-50
                transition-colors duration-200 ease-in-out
                mr-2">
              <ng-icon name='matEdit' size="20"></ng-icon>
            </button>
            <button class="inline-flex items-center justify-center
              w-10 h-10 rounded-full
              text-red-600 dark:text-red-400
              hover:bg-red-100 dark:hover:bg-red-900
              focus:outline-none focus:ring-2 focus:ring-red-500 focus:ring-opacity-50
              transition-colors duration-200 ease-in-out">
              <ng-icon name="matDelete" size="20"></ng-icon>
            </button>
          </td>
          <td class="px-4 py-3 text-center">{{item.id}}</td>
          <td class="px-4 py-3 text-center">{{item.lastName}}</td>
          <td class="px-4 py-3 text-center">{{item.firstName}}</td>
          <td class="px-4 py-3 text-center">{{item.email}}</td>
          <td class="px-4 py-3 text-center">{{item.createdBy}}</td>
          <td class="px-4 py-3 text-center">{{item.createdDate}}</td>
          <td class="px-4 py-3 text-center">{{item.departmentId}}</td>
          <td class="px-4 py-3 text-center">{{item.hireDate}}</td>
          <td class="px-4 py-3 text-center">{{item.modifiedBy}}</td>
          <td class="px-4 py-3 text-center">{{item.modifiedDate}}</td>
          <td class="px-4 py-3 text-center">{{item.phoneNumber}}</td>
          <td class="px-4 py-3 text-center">{{item.salary}}</td>
          <td class="px-4 py-3 text-center">{{item.positionId}}</td>
        </tr>
      }
    </tbody>
  </table>
  </div>

  `,
  styleUrl: './employee-list.css'
})
export class EmployeeList {
   readonly _employeeListSignal = signal<GetEmployeeListResponseModel[]>([]);
     _tblHeader : string[] = ['Employee Id','Last Name', 'First Name', 'Email', 'Created By', 'Created Date','Department Id',
    'Hire Date', 'Modified By', 'Modified Date', 'Phone Number', 'Salary', 'Position Id'
  ];

  trackById(index: number, item: GetEmployeeListResponseModel): string {
    return item.id;
  }

  @Input()
  set employeeList(value: GetEmployeeListResponseModel[]){
    this._employeeListSignal.set(value);
    console.log('Set: ', this._employeeListSignal());
  }

  // The getter is fine as it already calls the signal to return its value
  get employeeListSignal(){
    console.log('Get: ', this._employeeListSignal());
    return this._employeeListSignal();
  }

}
