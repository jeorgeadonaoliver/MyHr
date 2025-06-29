import { Component, Inject, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { GetEmployeeList_Query_Token } from '../../Token/employee.token';
import { IQuery } from '../../../../core/interface/query.interface';
import { GetEmployeeListQuery } from '../../application/query/get-employee/GetEmployeeListQuery';
import { GetEmployeeListResponseModel } from '../../domain/GetEmployeeListResponse.model';

@Component({
  selector: 'app-employee-list.page.ts',
  imports: [],
  templateUrl: './employee-list.page.html',
})
export class EmployeeListPage implements OnInit {
  private subscriptions = new Subscription();

  constructor(@Inject(GetEmployeeList_Query_Token) private getEmployeeListQuery : IQuery<GetEmployeeListQuery, GetEmployeeListResponseModel>){}

  getEmployeeList(){
    this.subscriptions.add(
        this.getEmployeeListQuery.executeQuery([]).subscribe({
          next: data => {
          console.log('data :',data);
        }
      })
    );
  }

  ngOnDestroy(): void {
    this.subscriptions.unsubscribe();
  }

  ngOnInit(): void {
    this.getEmployeeList();
  }
}
