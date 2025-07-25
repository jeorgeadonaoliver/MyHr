interface LoginPayload{
  success: boolean;
  message: string;
  data: any;
}

export interface LoginMutationResponseModel {
  login: LoginPayload;
}

export const Failed_LoginMutationResponse: LoginMutationResponseModel = {
  login: {
    success: false,
    message: 'Login Failed!',
    data: ''
  }
};