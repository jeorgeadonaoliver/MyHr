import { Injectable } from "@angular/core";
import { ApolloQueryResult } from "@apollo/client/core";

@Injectable({providedIn:'root'})
export class ValidateApolloQueryResult<TResult>{

    execute(data : ApolloQueryResult<TResult>, message: string):void{

        if(data.errors && data.errors.length > 0)
            throw new Error(data.errors[0].message || `Failed on ${message}`)

        if(!data.data)
            throw new Error(message);
    }
}