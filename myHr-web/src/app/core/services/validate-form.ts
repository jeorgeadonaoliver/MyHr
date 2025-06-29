import { FormGroup } from "@angular/forms";
import { ValidateFormResponse } from "../models/validate-form-response.model";
import { Injectable } from "@angular/core";

@Injectable({providedIn:'root'})
export class ValidateForm{

    execute(formgroup: FormGroup ) : ValidateFormResponse {
        if (formgroup.invalid) {
            formgroup.markAllAsTouched();
            return {
                isValid: false,
                message: 'Please provide necessary details!'
            } as ValidateFormResponse;
        }
        return {
            isValid: true,
            message: 'Form is valid!'
        } as ValidateFormResponse;
    }
}