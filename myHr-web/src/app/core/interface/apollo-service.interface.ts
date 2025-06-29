import { Observable } from "rxjs";

export interface IApolloService<TEntity, TResponse> {
    executeService(entity: TEntity) : Observable<TResponse>;
}