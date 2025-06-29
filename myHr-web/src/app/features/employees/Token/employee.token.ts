import { InjectionToken } from "@angular/core";
import { IApolloService } from "../../../core/interface/apollo-service.interface";
import { GetEmployeeListQuery } from "../application/query/get-employee/GetEmployeeListQuery";
import { GetEmployeeListResponseModel } from "../domain/GetEmployeeListResponse.model";
import { IQuery } from "../../../core/interface/query.interface";

export const GetEmployeeList_Service_Token = new InjectionToken<IApolloService<GetEmployeeListQuery, GetEmployeeListResponseModel[]>>("GetEmployeeList_Service_Token");
export const GetEmployeeList_Query_Token = new InjectionToken<IQuery<GetEmployeeListQuery, GetEmployeeListResponseModel[]>>("GetEmployeeList_Query_Token");