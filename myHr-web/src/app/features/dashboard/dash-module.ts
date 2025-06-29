import { RouterModule, Routes } from "@angular/router";
import { Dashboard } from "./presentation/dashboard/dashboard";
import { GetEmployeeList_Query_Token, GetEmployeeList_Service_Token } from "../employees/Token/employee.token";
import { GetEmployeeListService } from "../employees/infrastructure/GetEmployeeList.service";
import { GetEmployeeListQueryHandler } from "../employees/application/query/get-employee/GetEmployeeListQuery.Handler";
import { NgModule } from "@angular/core";

const dashModeulRoutes : Routes = [
    { path : '', component: Dashboard}
]

@NgModule({
  imports:[ RouterModule.forChild(dashModeulRoutes)],
  exports: [RouterModule],
  providers: [
    { provide: GetEmployeeList_Service_Token, useClass: GetEmployeeListService },
    GetEmployeeListQueryHandler,
    { provide: GetEmployeeList_Query_Token, useClass: GetEmployeeListQueryHandler},
    Dashboard
  ]
})

export class DashModule {}