import { Injectable } from "@angular/core";
import { MutationResult } from "apollo-angular";

@Injectable({providedIn:'root'})
export class ValidateApolloMutateResult<TResult>{
    
    execute(result: MutationResult<TResult>, message: string): void {
            if (result.errors && result.errors.length > 0) {
                console.error('GraphQL errors during login:', result.errors);
                throw new Error(result.errors[0].message || 'Authentication failed.');
            } 

            if(!result.data)
                throw new Error('Authentication failed: Invalid response from server.');
    }
}