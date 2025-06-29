import { Observable } from "rxjs";

export interface IQuery<TEntity, TResponse> {
    executeQuery(entity: TEntity): Observable<TResponse>;
}