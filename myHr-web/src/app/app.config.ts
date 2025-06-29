import { ApplicationConfig, provideBrowserGlobalErrorListeners, provideZonelessChangeDetection, inject } from '@angular/core';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { provideClientHydration, withEventReplay } from '@angular/platform-browser';
import { HttpHeaders, provideHttpClient, withFetch } from '@angular/common/http';
import { provideApollo } from 'apollo-angular';
import { HttpLink } from 'apollo-angular/http';
import { InMemoryCache, Operation, from, ApolloLink } from '@apollo/client/core';
import { AuthTokenService } from './core/services/auth-token.service';
import { AuthService } from './core/services/auth.service';


export const appConfig: ApplicationConfig = {
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZonelessChangeDetection(),
    provideRouter(routes),
    provideHttpClient(withFetch()),
    provideApollo(() => {
      const httpLink = inject(HttpLink);
      const tokenService = inject(AuthTokenService);

      const baseLink = httpLink.create({
         uri: 'https://localhost:7083/graphql/',
         withCredentials: true
      });

      const authLink = new ApolloLink((operation, forward) => {
        const token = tokenService.getToken();
        if (token) {
          operation.setContext(({ headers = {} }) => {
            const newHeader = {
              ...headers,
              Authorization: `Bearer ${token}`,
            }
            console.log("headers " , headers);

            return {headers: newHeader};
          }
        );
        }
        return forward(operation);
      });

      const link = from([
        authLink,
        baseLink,
      ]);

      return {

        // httpLink.create({
        //   uri: 'https://localhost:7083/graphql/',
        //   withCredentials: true
        // }),
        link,
        cache: new InMemoryCache(),
        connectToDevTools: true,
        defaultOptions: {
          mutate: { errorPolicy: 'all' },
          query: { errorPolicy: 'all' },
          watchQuery: { errorPolicy: 'all' },
        }
      };
    })
  ]
};

