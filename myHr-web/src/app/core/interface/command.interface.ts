import { Observable } from "rxjs";

export interface ICommand<TEntity, TResponse>{
    executeCommand(command: TEntity) : Observable<TResponse>;
}