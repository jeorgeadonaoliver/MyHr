import { inject, Injectable } from "@angular/core";
import { AuthTokenService } from "./auth-token.service";
import { BehaviorSubject, Observable } from "rxjs";
import { Router } from "@angular/router";

@Injectable({providedIn:'root'})
export class AuthService{
    private tokenService = inject(AuthTokenService);
    private router = inject(Router);
    
    private _isAuthenticated = new BehaviorSubject<boolean>(this.tokenService.hasToken());
    _isAuthenticated$ : Observable<boolean> = this._isAuthenticated.asObservable();

    setToken(token: string): void {
        this.tokenService.seToken(token);
        this._isAuthenticated.next(true);
        console.log('Auth status updated: Logged In');
    }

    getToken(): string | null {
        return this.tokenService.getToken();
    }

    removeToken(): void {
        this.tokenService.clearToken();
        this._isAuthenticated.next(false);
        console.log('Auth status updated: Logged Out');
    }

    logout() : void {
        this.removeToken();
        this.router.navigate(['/login']);
    }
}