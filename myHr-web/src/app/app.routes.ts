import { Routes } from '@angular/router';
import { MainLayout } from './shared/layout/main-layout/main-layout';

export const routes: Routes = [

    {
        path:'',
        loadChildren : () => import('../../src/app/features/authentication/auth-module').then(m => m.AuthModule)
    },
    {
        path: 'main', component: MainLayout,
        children: [{
            path:'dashboard',
            loadChildren: () => import('../app/features/dashboard/dash-module').then(d => d.DashModule)
        },{
            path: 'employeelist',
            loadChildren: () => import('../app/features/employees/emp-module').then(e => e.EmpModule)
        }]
    },
];
