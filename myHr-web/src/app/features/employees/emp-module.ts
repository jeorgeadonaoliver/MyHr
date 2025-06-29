import { RouterModule, Routes } from "@angular/router";
import { GetEmployeeList_Query_Token, GetEmployeeList_Service_Token } from "./Token/employee.token";
import { GetEmployeeListService } from "./infrastructure/GetEmployeeList.service";
import { GetEmployeeListQueryHandler } from "./application/query/get-employee/GetEmployeeListQuery.Handler";
import { NgModule } from "@angular/core";
import { EmployeeListPage } from "./presentation/employee-list.page/employee-list.page";

const empModeulRoutes : Routes = [
    { path : '', component: EmployeeListPage}
]


@NgModule({
  imports:[ RouterModule.forChild(empModeulRoutes)],
  exports: [RouterModule],
  providers: [
    { provide: GetEmployeeList_Service_Token, useClass: GetEmployeeListService },
    GetEmployeeListQueryHandler,
    { provide: GetEmployeeList_Query_Token, useClass: GetEmployeeListQueryHandler},
    EmployeeListPage
  ]
})

export class EmpModule {}