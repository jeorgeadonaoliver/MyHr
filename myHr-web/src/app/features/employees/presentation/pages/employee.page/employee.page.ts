import { AfterContentInit, ChangeDetectorRef, Component, Inject, OnDestroy, OnInit, signal } from '@angular/core';
import { Subscription } from 'rxjs';
import { GetEmployeeList_Query_Token } from '../../../Token/employee.token';
import { IQuery } from '../../../../../core/interface/query.interface';
import { GetEmployeeListQuery } from '../../../application/query/get-employee/GetEmployeeListQuery';
import { GetEmployeeByIdResponseModel } from '../../../domain/GetEmployeeByIdResponse.model';
import { EmployeeList } from "../../components/employee-list/employee-list";
import { GetEmployeeListResponseModel } from '../../../domain/GetEmployeeListResponse.model';
import { BasicCard } from "../../../../../shared/components/basic-card/basic-card";
import { IconsModule } from '../../../../../shared/components/icons-module/icons-module';
import { AddEmployeeModal } from '../../components/add-employee-modal/add-employee-modal';

@Component({
  selector: 'app-employee.page',
  imports: [EmployeeList, BasicCard, IconsModule, AddEmployeeModal],
  template: `

  <app-basic-card cardTitle="Employee List">
      <button card-action (click)="openModal()" 
        class="flex items-center gap-2 px-4 py-2 text-white bg-gray-700 hover:bg-indigo-500 rounded-3xl hover:rounded-xl transition-all duration-300 ease-in-out">
        <ng-icon name="matAdd" size="25"></ng-icon>
        Add Employee
      </button>
      @if(isLoading){
        <div class="flex justify-center items-center h-48">
          <p class="text-lg text-gray-700">Loading employees...</p>
          <div class="animate-spin rounded-full h-10 w-10 border-b-2 border-gray-900 ml-3"></div>
        </div>
      }
      @else {
        <app-employee-list [employeeList]="employees"></app-employee-list>
      }
  </app-basic-card>

  @if(isModalOpen()){
    <app-add-employee-modal (close)="closeModal()"></app-add-employee-modal>
  }

  `,
  styleUrl: './employee.page.css'
})
export class EmployeePage implements OnInit, OnDestroy {
  private subscriptions = new Subscription();
  employees: GetEmployeeListResponseModel[] = [];
  isModalOpen = signal(false);
  isLoading: boolean = true;

  constructor(
    @Inject(GetEmployeeList_Query_Token)
    private getEmployeeList : IQuery<GetEmployeeListQuery, GetEmployeeListResponseModel[]>,
    private cdr : ChangeDetectorRef
  ){
  }

  openModal(): void {
    this.isModalOpen.set(true);
    console.log('isModalOpen ', this.isModalOpen);
  }

  closeModal(): void{
    this.isModalOpen.set(false);
    console.log('closeModal ', this.isModalOpen);
  }

  loadEmployeeList(){
    this.isLoading = true;
     const sub = this.getEmployeeList.executeQuery([]).subscribe({
          next: data => {
          console.log('data :',data);
          this.employees = data.map(x => ({
            id: x.id,
            lastName: x.lastName,
            firstName : x.firstName,
            email: x.email,
            createdBy : x.createdBy,
            createdDate: x.createdDate,
            departmentId: x.departmentId,
            hireDate: x.hireDate,
            modifiedBy: x.modifiedBy,
            modifiedDate: x.createdDate,
            phoneNumber : x.phoneNumber,
            salary: x.salary,
            positionId: x.positionId 
          }));
          this.isLoading = false;
          this.cdr.detectChanges();
        }
    });
    this.subscriptions.add(sub);
  }

  ngOnInit(): void {
    this.loadEmployeeList();
    this.isLoading = true;
  }

  ngOnDestroy(): void {
    this.subscriptions.unsubscribe();
  }

}
