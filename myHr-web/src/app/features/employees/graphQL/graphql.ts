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
  createdBy?: InputMaybe<Scalars['String']['input']>;
  createdDate?: InputMaybe<Scalars['DateTime']['input']>;
  departmentName: Scalars['String']['input'];
  id: Scalars['UUID']['input'];
  location?: InputMaybe<Scalars['String']['input']>;
  modifiedBy?: InputMaybe<Scalars['String']['input']>;
  modifiedDate?: InputMaybe<Scalars['DateTime']['input']>;
};

export type DepartmentPayloadOfString = {
  __typename?: 'DepartmentPayloadOfString';
  data?: Maybe<Scalars['String']['output']>;
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
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

export type LoginPayload = {
  __typename?: 'LoginPayload';
  message?: Maybe<Scalars['String']['output']>;
  success: Scalars['Boolean']['output'];
  token?: Maybe<Scalars['String']['output']>;
};

export type Mutation = {
  __typename?: 'Mutation';
  CreateDepartment: DepartmentPayloadOfString;
  login: LoginPayload;
};


export type MutationCreateDepartmentArgs = {
  command: CreateDepartmentCommandInput;
};


export type MutationLoginArgs = {
  command: AuthenticateUserCommandInput;
};

export type Query = {
  __typename?: 'Query';
  GetEmployeeById: GetEmployeeByIdQueryDto;
  getEmployee: Array<GetAllEmployeeQueryDto>;
};


export type QueryGetEmployeeByIdArgs = {
  id: Scalars['UUID']['input'];
};

export type GetEmployeeQueryVariables = Exact<{ [key: string]: never; }>;


export type GetEmployeeQuery = { __typename?: 'Query', getEmployee: Array<{ __typename?: 'GetAllEmployeeQueryDto', createdBy?: string | null, createdDate?: any | null, departmentId?: any | null, email: string, id: any, firstName: string, hireDate: any, lastName: string, modifiedBy?: string | null, modifiedDate?: any | null, phoneNumber?: string | null, positionId?: any | null, salary: any }> };

export type GetEmployeeByIdQueryVariables = Exact<{
  id: Scalars['UUID']['input'];
}>;


export type GetEmployeeByIdQuery = { __typename?: 'Query', GetEmployeeById: { __typename?: 'GetEmployeeByIdQueryDto', lastName: string, firstName: string, email: string, salary: any, createdBy?: string | null, createdDate?: any | null, departmentId?: any | null, hireDate: any, id: any, modifiedBy?: string | null, modifiedDate?: any | null, phoneNumber?: string | null, positionId?: any | null } };


export const GetEmployeeDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"query","name":{"kind":"Name","value":"getEmployee"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"getEmployee"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"createdBy"}},{"kind":"Field","name":{"kind":"Name","value":"createdDate"}},{"kind":"Field","name":{"kind":"Name","value":"departmentId"}},{"kind":"Field","name":{"kind":"Name","value":"email"}},{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"firstName"}},{"kind":"Field","name":{"kind":"Name","value":"hireDate"}},{"kind":"Field","name":{"kind":"Name","value":"lastName"}},{"kind":"Field","name":{"kind":"Name","value":"modifiedBy"}},{"kind":"Field","name":{"kind":"Name","value":"modifiedDate"}},{"kind":"Field","name":{"kind":"Name","value":"phoneNumber"}},{"kind":"Field","name":{"kind":"Name","value":"positionId"}},{"kind":"Field","name":{"kind":"Name","value":"salary"}}]}}]}}]} as unknown as DocumentNode<GetEmployeeQuery, GetEmployeeQueryVariables>;
export const GetEmployeeByIdDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"query","name":{"kind":"Name","value":"GetEmployeeById"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"id"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"UUID"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"GetEmployeeById"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"id"},"value":{"kind":"Variable","name":{"kind":"Name","value":"id"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"lastName"}},{"kind":"Field","name":{"kind":"Name","value":"firstName"}},{"kind":"Field","name":{"kind":"Name","value":"email"}},{"kind":"Field","name":{"kind":"Name","value":"salary"}},{"kind":"Field","name":{"kind":"Name","value":"createdBy"}},{"kind":"Field","name":{"kind":"Name","value":"createdDate"}},{"kind":"Field","name":{"kind":"Name","value":"departmentId"}},{"kind":"Field","name":{"kind":"Name","value":"hireDate"}},{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"modifiedBy"}},{"kind":"Field","name":{"kind":"Name","value":"modifiedDate"}},{"kind":"Field","name":{"kind":"Name","value":"phoneNumber"}},{"kind":"Field","name":{"kind":"Name","value":"positionId"}}]}}]}}]} as unknown as DocumentNode<GetEmployeeByIdQuery, GetEmployeeByIdQueryVariables>;