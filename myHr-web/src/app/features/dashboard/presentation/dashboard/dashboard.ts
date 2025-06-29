import { Component, Inject, inject, Injectable, OnDestroy, OnInit } from '@angular/core';
import { GetEmployeeListService } from '../../../employees/infrastructure/GetEmployeeList.service';
import { GetEmployeeListQueryHandler } from '../../../employees/application/query/get-employee/GetEmployeeListQuery.Handler';
import { PageTitle } from '../../../../shared/components/page-title/page-title';
import { CommonModule } from '@angular/common';
import { BasicCard } from "../../../../shared/components/basic-card/basic-card";
import { IconsModule } from '../../../../shared/components/icons-module/icons-module';


@Component({
  selector: 'app-dashboard',
  imports: [PageTitle, CommonModule, BasicCard, IconsModule],
  templateUrl: './dashboard.html',
  providers: [GetEmployeeListService, GetEmployeeListQueryHandler]
})
export class Dashboard {
  
}
