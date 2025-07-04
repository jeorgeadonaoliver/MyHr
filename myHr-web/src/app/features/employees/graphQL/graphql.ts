/* eslint-disable */
import { TypedDocumentNode as DocumentNode } from '@graphql-typed-document-node/core';
export type Maybe<T> = T | null;
export type InputMaybe<T> = Maybe<T>;
export type Exact<T extends { [key: string]: unknown }> = { [K in keyof T]: T[K] };
export type MakeOptional<T, K extends keyof T> = Omit<T, K> & { [SubKey in K]?: Maybe<T[SubKey]> };
export type MakeMaybe<T, K extends keyof T> = Omit<T, K> & { [SubKey in K]: Maybe<T[SubKey]> };
export type MakeEmpty<T extends { [key: string]: unknown }, K extends keyof T> = { [_ in K]?: never };
export type Incremental<T> = T | { [P in keyof T]?: P extends ' $fragmentName' | '__typename' ? T[P] : never };
/** All built-in and custom scalars, mapped to their actual values */
export type Scalars = {
  ID: { input: string; output: string; }
  String: { input: string; output: string; }
  Boolean: { input: boolean; output: boolean; }
  Int: { input: number; output: number; }
  Float: { input: number; output: number; }
  /** The `DateTime` scalar represents an ISO-8601 compliant date time type. */
  DateTime: { input: any; output: any; }
  /** The `Decimal` scalar type represents a decimal floating-point number. */
  Decimal: { input: any; output: any; }
  /** The `LocalDate` scalar type represents a ISO date string, represented as UTF-8 character sequences YYYY-MM-DD. The scalar follows the specification defined in RFC3339 */
  LocalDate: { input: any; output: any; }
  UUID: { input: any; output: any; }
};

/** Defines when a policy shall be executed. */
export enum ApplyPolicy {
  /** After the resolver was executed. */
  AfterResolver = 'AFTER_RESOLVER',
  /** Before the resolver was executed. */
  BeforeResolver = 'BEFORE_RESOLVER',
  /** The policy is applied in the validation step before the execution. */
  Validation = 'VALIDATION'
}

export type AuthenticateUserCommandInput = {
  password: Scalars['String']['input'];
  username: Scalars['String']['input'];
};

export type CreateDepartmentCommandInput = {
  createdBy: Scalars['String']['input'];
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  departmentName: Scalars['String']['input'];
  id: Scalars['UUID']['input'];
  location?: InputMaybe<Scalars['String']['input']>;
};

export type CreateEmployeeCommandInput = {
  createdBy?: InputMaybe<Scalars['String']['input']>;
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  departmentId?: InputMaybe<Scalars['UUID']['input']>;
  email: Scalars['String']['input'];
  firstName: Scalars['String']['input'];
  hireDate: Scalars['LocalDate']['input'];
  id: Scalars['UUID']['input'];
  lastName: Scalars['String']['input'];
  modifiedBy?: InputMaybe<Scalars['String']['input']>;
  modifiedDate?: InputMaybe<Scalars['DateTime']['input']>;
  phoneNumber?: InputMaybe<Scalars['String']['input']>;
  positionId?: InputMaybe<Scalars['UUID']['input']>;
  salary: Scalars['Decimal']['input'];
};

export type CreateLeaveCreditCommandInput = {
  createdBy?: InputMaybe<Scalars['String']['input']>;
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  employeeId?: InputMaybe<Scalars['UUID']['input']>;
  id: Scalars['UUID']['input'];
  leaveType: Scalars['String']['input'];
  modifiedBy?: InputMaybe<Scalars['String']['input']>;
  modifiedDate?: InputMaybe<Scalars['DateTime']['input']>;
  remainingCredits?: InputMaybe<Scalars['Int']['input']>;
  totalCredits: Scalars['Int']['input'];
  usedCredits?: InputMaybe<Scalars['Int']['input']>;
};

export type CreateLeaveRequestCommandInput = {
  createdBy?: InputMaybe<Scalars['String']['input']>;
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  creditId?: InputMaybe<Scalars['UUID']['input']>;
  employeeId?: InputMaybe<Scalars['UUID']['input']>;
  endDate: Scalars['LocalDate']['input'];
  id: Scalars['UUID']['input'];
  leaveType: Scalars['String']['input'];
  modifiedBy?: InputMaybe<Scalars['String']['input']>;
  modifiedDate?: InputMaybe<Scalars['DateTime']['input']>;
  startDate: Scalars['LocalDate']['input'];
  status?: InputMaybe<Scalars['String']['input']>;
};

export type CreatePerformanceEvaluationCommandInput = {
  comments?: InputMaybe<Scalars['String']['input']>;
  createdBy?: InputMaybe<Scalars['String']['input']>;
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  employeeId?: InputMaybe<Scalars['UUID']['input']>;
  evaluationDate: Scalars['LocalDate']['input'];
  evaluator: Scalars['String']['input'];
  id: Scalars['UUID']['input'];
  modifiedBy?: InputMaybe<Scalars['String']['input']>;
  modifiedDate?: InputMaybe<Scalars['DateTime']['input']>;
  score: Scalars['Decimal']['input'];
};

export type GetAllDepartmentsQueryDto = {
  __typename?: 'GetAllDepartmentsQueryDto';
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  departmentName: Scalars['String']['output'];
  id: Scalars['UUID']['output'];
  location?: Maybe<Scalars['String']['output']>;
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
};

export type GetAllEmployeeQueryDto = {
  __typename?: 'GetAllEmployeeQueryDto';
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  departmentId?: Maybe<Scalars['UUID']['output']>;
  email: Scalars['String']['output'];
  firstName: Scalars['String']['output'];
  hireDate: Scalars['LocalDate']['output'];
  id: Scalars['UUID']['output'];
  lastName: Scalars['String']['output'];
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
  phoneNumber?: Maybe<Scalars['String']['output']>;
  positionId?: Maybe<Scalars['UUID']['output']>;
  salary: Scalars['Decimal']['output'];
};

export type GetAllJobPositionsQueryDto = {
  __typename?: 'GetAllJobPositionsQueryDto';
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  departmentId?: Maybe<Scalars['UUID']['output']>;
  description?: Maybe<Scalars['String']['output']>;
  id: Scalars['UUID']['output'];
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
  positionTitle: Scalars['String']['output'];
};

export type GetAllLeaveCreditQueryDto = {
  __typename?: 'GetAllLeaveCreditQueryDto';
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  employeeId?: Maybe<Scalars['UUID']['output']>;
  id: Scalars['UUID']['output'];
  leaveType: Scalars['String']['output'];
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
  remainingCredits?: Maybe<Scalars['Int']['output']>;
  totalCredits: Scalars['Int']['output'];
  usedCredits?: Maybe<Scalars['Int']['output']>;
};

export type GetAllLeaveRequestQueryDto = {
  __typename?: 'GetAllLeaveRequestQueryDto';
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  creditId?: Maybe<Scalars['UUID']['output']>;
  employeeId?: Maybe<Scalars['UUID']['output']>;
  endDate: Scalars['LocalDate']['output'];
  id: Scalars['UUID']['output'];
  leaveType: Scalars['String']['output'];
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
  startDate: Scalars['LocalDate']['output'];
  status?: Maybe<Scalars['String']['output']>;
};

export type GetAllPerformanceEvaluationQueryDto = {
  __typename?: 'GetAllPerformanceEvaluationQueryDto';
  comments?: Maybe<Scalars['String']['output']>;
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  employeeId?: Maybe<Scalars['UUID']['output']>;
  evaluationDate: Scalars['LocalDate']['output'];
  evaluator: Scalars['String']['output'];
  id: Scalars['UUID']['output'];
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
  score: Scalars['Decimal']['output'];
};

export type GetDepartmentByIdQueryDto = {
  __typename?: 'GetDepartmentByIdQueryDto';
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  departmentName: Scalars['String']['output'];
  id: Scalars['UUID']['output'];
  location?: Maybe<Scalars['String']['output']>;
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
};

export type GetEmployeeByIdQueryDto = {
  __typename?: 'GetEmployeeByIdQueryDto';
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  departmentId?: Maybe<Scalars['UUID']['output']>;
  email: Scalars['String']['output'];
  firstName: Scalars['String']['output'];
  hireDate: Scalars['LocalDate']['output'];
  id: Scalars['UUID']['output'];
  lastName: Scalars['String']['output'];
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
  phoneNumber?: Maybe<Scalars['String']['output']>;
  positionId?: Maybe<Scalars['UUID']['output']>;
  salary: Scalars['Decimal']['output'];
};

export type GetJobPositionByIdQueryDto = {
  __typename?: 'GetJobPositionByIdQueryDto';
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  departmentId?: Maybe<Scalars['UUID']['output']>;
  description?: Maybe<Scalars['String']['output']>;
  id: Scalars['UUID']['output'];
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
  positionTitle: Scalars['String']['output'];
};

export type GetLeaveRequestByEmployeeIdQueryDto = {
  __typename?: 'GetLeaveRequestByEmployeeIdQueryDto';
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  creditId?: Maybe<Scalars['UUID']['output']>;
  employeeId?: Maybe<Scalars['UUID']['output']>;
  endDate: Scalars['LocalDate']['output'];
  id: Scalars['UUID']['output'];
  leaveType: Scalars['String']['output'];
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
  startDate: Scalars['LocalDate']['output'];
  status?: Maybe<Scalars['String']['output']>;
};

export type GetLeaveRequestByIdQueryDto = {
  __typename?: 'GetLeaveRequestByIdQueryDto';
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  creditId?: Maybe<Scalars['UUID']['output']>;
  employeeId?: Maybe<Scalars['UUID']['output']>;
  endDate: Scalars['LocalDate']['output'];
  id: Scalars['UUID']['output'];
  leaveType: Scalars['String']['output'];
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
  startDate: Scalars['LocalDate']['output'];
  status?: Maybe<Scalars['String']['output']>;
};

export type GetPerformanceEvaluationByIdQueryDto = {
  __typename?: 'GetPerformanceEvaluationByIdQueryDto';
  comments?: Maybe<Scalars['String']['output']>;
  createdBy?: Maybe<Scalars['String']['output']>;
  createdDate?: Maybe<Scalars['DateTime']['output']>;
  employeeId?: Maybe<Scalars['UUID']['output']>;
  evaluationDate: Scalars['LocalDate']['output'];
  evaluator: Scalars['String']['output'];
  id: Scalars['UUID']['output'];
  modifiedBy?: Maybe<Scalars['String']['output']>;
  modifiedDate?: Maybe<Scalars['DateTime']['output']>;
  score: Scalars['Decimal']['output'];
};

export type Mutation = {
  __typename?: 'Mutation';
  CreateDepartment: PayLoadOfGuid;
  CreateEmployee: PayLoadOfGuid;
  CreateLeaveCredit: PayLoadOfGuid;
  CreateLeaveRequest: PayLoadOfGuid;
  CreatePerformanceEvaluation: PayLoadOfGuid;
  UpdateDepartment: PayLoadOfGuid;
  UpdateEmployee: PayLoadOfGuid;
  UpdateLeaveCredit: PayLoadOfGuid;
  UpdateLeaveRequest: PayLoadOfGuid;
  UpdatePerformanceEvaluation: PayLoadOfGuid;
  login: PayLoadOfString;
};


export type MutationCreateDepartmentArgs = {
  command: CreateDepartmentCommandInput;
};


export type MutationCreateEmployeeArgs = {
  cmd: CreateEmployeeCommandInput;
};


export type MutationCreateLeaveCreditArgs = {
  cmd: CreateLeaveCreditCommandInput;
};


export type MutationCreateLeaveRequestArgs = {
  cmd: CreateLeaveRequestCommandInput;
};


export type MutationCreatePerformanceEvaluationArgs = {
  cmd: CreatePerformanceEvaluationCommandInput;
};


export type MutationUpdateDepartmentArgs = {
  command: UpdateDepartmentCommandInput;
};


export type MutationUpdateEmployeeArgs = {
  command: UpdateEmployeeCommandInput;
};


export type MutationUpdateLeaveCreditArgs = {
  cmd: UpdateLeaveCreditCommandInput;
};


export type MutationUpdateLeaveRequestArgs = {
  cmd: UpdateLeaveRequestCommandInput;
};


export type MutationUpdatePerformanceEvaluationArgs = {
  cmd: UpdatePerformanceEvaluationCommandInput;
};


export type MutationLoginArgs = {
  command: AuthenticateUserCommandInput;
};

export type PayLoadOfGetAllLeaveRequestQueryDto = {
  __typename?: 'PayLoadOfGetAllLeaveRequestQueryDto';
  data?: Maybe<GetAllLeaveRequestQueryDto>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfGetDepartmentByIdQueryDto = {
  __typename?: 'PayLoadOfGetDepartmentByIdQueryDto';
  data?: Maybe<GetDepartmentByIdQueryDto>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfGetEmployeeByIdQueryDto = {
  __typename?: 'PayLoadOfGetEmployeeByIdQueryDto';
  data?: Maybe<GetEmployeeByIdQueryDto>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfGetJobPositionByIdQueryDto = {
  __typename?: 'PayLoadOfGetJobPositionByIdQueryDto';
  data?: Maybe<GetJobPositionByIdQueryDto>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfGetLeaveRequestByIdQueryDto = {
  __typename?: 'PayLoadOfGetLeaveRequestByIdQueryDto';
  data?: Maybe<GetLeaveRequestByIdQueryDto>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfGetPerformanceEvaluationByIdQueryDto = {
  __typename?: 'PayLoadOfGetPerformanceEvaluationByIdQueryDto';
  data?: Maybe<GetPerformanceEvaluationByIdQueryDto>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfGuid = {
  __typename?: 'PayLoadOfGuid';
  data: Scalars['UUID']['output'];
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfIEnumerableOfGetAllDepartmentsQueryDto = {
  __typename?: 'PayLoadOfIEnumerableOfGetAllDepartmentsQueryDto';
  data?: Maybe<Array<Maybe<GetAllDepartmentsQueryDto>>>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfIEnumerableOfGetAllEmployeeQueryDto = {
  __typename?: 'PayLoadOfIEnumerableOfGetAllEmployeeQueryDto';
  data?: Maybe<Array<Maybe<GetAllEmployeeQueryDto>>>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfIEnumerableOfGetAllJobPositionsQueryDto = {
  __typename?: 'PayLoadOfIEnumerableOfGetAllJobPositionsQueryDto';
  data?: Maybe<Array<Maybe<GetAllJobPositionsQueryDto>>>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfIEnumerableOfGetAllLeaveCreditQueryDto = {
  __typename?: 'PayLoadOfIEnumerableOfGetAllLeaveCreditQueryDto';
  data?: Maybe<Array<Maybe<GetAllLeaveCreditQueryDto>>>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfIEnumerableOfGetAllLeaveRequestQueryDto = {
  __typename?: 'PayLoadOfIEnumerableOfGetAllLeaveRequestQueryDto';
  data?: Maybe<Array<Maybe<GetAllLeaveRequestQueryDto>>>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfIEnumerableOfGetAllPerformanceEvaluationQueryDto = {
  __typename?: 'PayLoadOfIEnumerableOfGetAllPerformanceEvaluationQueryDto';
  data?: Maybe<Array<Maybe<GetAllPerformanceEvaluationQueryDto>>>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfIEnumerableOfGetLeaveRequestByEmployeeIdQueryDto = {
  __typename?: 'PayLoadOfIEnumerableOfGetLeaveRequestByEmployeeIdQueryDto';
  data?: Maybe<Array<Maybe<GetLeaveRequestByEmployeeIdQueryDto>>>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type PayLoadOfString = {
  __typename?: 'PayLoadOfString';
  data?: Maybe<Scalars['String']['output']>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
};

export type Query = {
  __typename?: 'Query';
  GetAllDepartment: PayLoadOfIEnumerableOfGetAllDepartmentsQueryDto;
  GetAllJobPosition: PayLoadOfIEnumerableOfGetAllJobPositionsQueryDto;
  GetAllJobPositionById: PayLoadOfGetJobPositionByIdQueryDto;
  GetAllLeaveCredits: PayLoadOfIEnumerableOfGetAllLeaveCreditQueryDto;
  GetAllLeaveRequest: PayLoadOfIEnumerableOfGetAllLeaveRequestQueryDto;
  GetAllPerformanceEvaluation: PayLoadOfIEnumerableOfGetAllPerformanceEvaluationQueryDto;
  GetDepartmentById: PayLoadOfGetDepartmentByIdQueryDto;
  GetEmployeeById: PayLoadOfGetEmployeeByIdQueryDto;
  GetLeaveCreditById: PayLoadOfGetLeaveRequestByIdQueryDto;
  GetLeaveRequestByEmployeeId: PayLoadOfIEnumerableOfGetLeaveRequestByEmployeeIdQueryDto;
  GetLeaveRequestById: PayLoadOfGetLeaveRequestByIdQueryDto;
  GetPerformanceEvaluationById: PayLoadOfGetPerformanceEvaluationByIdQueryDto;
  getEmployee: PayLoadOfIEnumerableOfGetAllEmployeeQueryDto;
};


export type QueryGetAllJobPositionByIdArgs = {
  id: Scalars['UUID']['input'];
};


export type QueryGetDepartmentByIdArgs = {
  id: Scalars['UUID']['input'];
};


export type QueryGetEmployeeByIdArgs = {
  id: Scalars['UUID']['input'];
};


export type QueryGetLeaveCreditByIdArgs = {
  id: Scalars['UUID']['input'];
};


export type QueryGetLeaveRequestByEmployeeIdArgs = {
  empid: Scalars['UUID']['input'];
};


export type QueryGetLeaveRequestByIdArgs = {
  id: Scalars['UUID']['input'];
};


export type QueryGetPerformanceEvaluationByIdArgs = {
  id: Scalars['UUID']['input'];
};

export type UpdateDepartmentCommandInput = {
  createdBy?: InputMaybe<Scalars['String']['input']>;
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  departmentName: Scalars['String']['input'];
  id: Scalars['UUID']['input'];
  location?: InputMaybe<Scalars['String']['input']>;
  modifiedBy?: InputMaybe<Scalars['String']['input']>;
  modifiedDate?: InputMaybe<Scalars['DateTime']['input']>;
};

export type UpdateEmployeeCommandInput = {
  createdBy?: InputMaybe<Scalars['String']['input']>;
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  departmentId?: InputMaybe<Scalars['UUID']['input']>;
  email: Scalars['String']['input'];
  firstName: Scalars['String']['input'];
  hireDate: Scalars['LocalDate']['input'];
  id: Scalars['UUID']['input'];
  lastName: Scalars['String']['input'];
  modifiedBy?: InputMaybe<Scalars['String']['input']>;
  modifiedDate?: InputMaybe<Scalars['DateTime']['input']>;
  phoneNumber?: InputMaybe<Scalars['String']['input']>;
  positionId?: InputMaybe<Scalars['UUID']['input']>;
  salary: Scalars['Decimal']['input'];
};

export type UpdateLeaveCreditCommandInput = {
  createdBy?: InputMaybe<Scalars['String']['input']>;
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  employeeId?: InputMaybe<Scalars['UUID']['input']>;
  id: Scalars['UUID']['input'];
  leaveType: Scalars['String']['input'];
  modifiedBy?: InputMaybe<Scalars['String']['input']>;
  modifiedDate?: InputMaybe<Scalars['DateTime']['input']>;
  remainingCredits?: InputMaybe<Scalars['Int']['input']>;
  totalCredits: Scalars['Int']['input'];
  usedCredits?: InputMaybe<Scalars['Int']['input']>;
};

export type UpdateLeaveRequestCommandInput = {
  createdBy?: InputMaybe<Scalars['String']['input']>;
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  creditId?: InputMaybe<Scalars['UUID']['input']>;
  employeeId?: InputMaybe<Scalars['UUID']['input']>;
  endDate: Scalars['LocalDate']['input'];
  id: Scalars['UUID']['input'];
  leaveType: Scalars['String']['input'];
  modifiedBy?: InputMaybe<Scalars['String']['input']>;
  modifiedDate?: InputMaybe<Scalars['DateTime']['input']>;
  startDate: Scalars['LocalDate']['input'];
  status?: InputMaybe<Scalars['String']['input']>;
};

export type UpdatePerformanceEvaluationCommandInput = {
  comments?: InputMaybe<Scalars['String']['input']>;
  createdBy?: InputMaybe<Scalars['String']['input']>;
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  employeeId?: InputMaybe<Scalars['UUID']['input']>;
  evaluationDate: Scalars['LocalDate']['input'];
  evaluator: Scalars['String']['input'];
  id: Scalars['UUID']['input'];
  modifiedBy?: InputMaybe<Scalars['String']['input']>;
  modifiedDate?: InputMaybe<Scalars['DateTime']['input']>;
  score: Scalars['Decimal']['input'];
};

export type GetEmployeeQueryVariables = Exact<{ [key: string]: never; }>;


export type GetEmployeeQuery = { __typename?: 'Query', getEmployee: { __typename?: 'PayLoadOfIEnumerableOfGetAllEmployeeQueryDto', data?: Array<{ __typename?: 'GetAllEmployeeQueryDto', createdBy?: string | null, createdDate?: any | null, departmentId?: any | null, email: string, id: any, firstName: string, hireDate: any, lastName: string, modifiedBy?: string | null, modifiedDate?: any | null, phoneNumber?: string | null, positionId?: any | null, salary: any } | null> | null } };

export type GetEmployeeByIdQueryVariables = Exact<{
  id: Scalars['UUID']['input'];
}>;


export type GetEmployeeByIdQuery = { __typename?: 'Query', GetEmployeeById: { __typename?: 'PayLoadOfGetEmployeeByIdQueryDto', data?: { __typename?: 'GetEmployeeByIdQueryDto', lastName: string, firstName: string, email: string, salary: any, createdBy?: string | null, createdDate?: any | null, departmentId?: any | null, hireDate: any, id: any, modifiedBy?: string | null, modifiedDate?: any | null, phoneNumber?: string | null, positionId?: any | null } | null } };


export const GetEmployeeDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"query","name":{"kind":"Name","value":"getEmployee"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"getEmployee"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"data"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"createdBy"}},{"kind":"Field","name":{"kind":"Name","value":"createdDate"}},{"kind":"Field","name":{"kind":"Name","value":"departmentId"}},{"kind":"Field","name":{"kind":"Name","value":"email"}},{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"firstName"}},{"kind":"Field","name":{"kind":"Name","value":"hireDate"}},{"kind":"Field","name":{"kind":"Name","value":"lastName"}},{"kind":"Field","name":{"kind":"Name","value":"modifiedBy"}},{"kind":"Field","name":{"kind":"Name","value":"modifiedDate"}},{"kind":"Field","name":{"kind":"Name","value":"phoneNumber"}},{"kind":"Field","name":{"kind":"Name","value":"positionId"}},{"kind":"Field","name":{"kind":"Name","value":"salary"}}]}}]}}]}}]} as unknown as DocumentNode<GetEmployeeQuery, GetEmployeeQueryVariables>;
export const GetEmployeeByIdDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"query","name":{"kind":"Name","value":"GetEmployeeById"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"id"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"UUID"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"GetEmployeeById"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"id"},"value":{"kind":"Variable","name":{"kind":"Name","value":"id"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"data"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"lastName"}},{"kind":"Field","name":{"kind":"Name","value":"firstName"}},{"kind":"Field","name":{"kind":"Name","value":"email"}},{"kind":"Field","name":{"kind":"Name","value":"salary"}},{"kind":"Field","name":{"kind":"Name","value":"createdBy"}},{"kind":"Field","name":{"kind":"Name","value":"createdDate"}},{"kind":"Field","name":{"kind":"Name","value":"departmentId"}},{"kind":"Field","name":{"kind":"Name","value":"hireDate"}},{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"modifiedBy"}},{"kind":"Field","name":{"kind":"Name","value":"modifiedDate"}},{"kind":"Field","name":{"kind":"Name","value":"phoneNumber"}},{"kind":"Field","name":{"kind":"Name","value":"positionId"}}]}}]}}]}}]} as unknown as DocumentNode<GetEmployeeByIdQuery, GetEmployeeByIdQueryVariables>;