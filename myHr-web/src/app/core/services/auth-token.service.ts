import { HttpHeaders } from "@angular/common/http";
import { inject, Injectable } from "@angular/core";
import { Operation } from "@apollo/client/core";
import { CookieService } from 'ngx-cookie-service';

@Injectable({providedIn:'root'})
export class AuthTokenService {
    private readonly Auth_Token_Key = 'authTokenAngular';
    private cookieService = inject(CookieService);

    getToken() : string | null { 
        const token = this.cookieService.get(this.Auth_Token_Key);
        return token || null;
    }

    seToken(token: string, rememberMe? : boolean): void {
        const expiresDate = rememberMe ? new Date(Date.now() + 1 * 24 * 60 * 60 * 1000) : undefined;

        this.cookieService.set(this.Auth_Token_Key, token,{
            path:'/',
            secure: true,
            sameSite: "Lax",
            expires: expiresDate
        });
    }
    
    clearToken(): void {
        this.cookieService.delete(this.Auth_Token_Key, '/');
    }

    hasToken(): boolean {
      return !!this.cookieService.get(this.Auth_Token_Key);
    }

}