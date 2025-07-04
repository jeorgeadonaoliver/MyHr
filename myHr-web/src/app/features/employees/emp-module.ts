import { RouterModule, Routes } from "@angular/router";
import { GetEmployeeList_Query_Token, GetEmployeeList_Service_Token } from "./Token/employee.token";
import { GetEmployeeListService } from "./infrastructure/GetEmployeeList.service";
import { GetEmployeeListQueryHandler } from "./application/query/get-employee/GetEmployeeListQuery.Handler";
import { NgModule } from "@angular/core";
import { EmployeePage } from "./presentation/pages/employee.page/employee.page";

const empModuleRoutes : Routes = [
    { path : '', component: EmployeePage}
]


@NgModule({
  imports:[ RouterModule.forChild(empModuleRoutes)],
  exports: [RouterModule],
  providers: [
    { provide: GetEmployeeList_Service_Token, useClass: GetEmployeeListService },
    GetEmployeeListQueryHandler,
    { provide: GetEmployeeList_Query_Token, useClass: GetEmployeeListQueryHandler},
    EmployeePage
  ]
})

export class EmpModule {}