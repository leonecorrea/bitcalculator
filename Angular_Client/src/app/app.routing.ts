import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { ComprasComponent } from './compras/compras.component';
import { CalculatorComponent } from './calculator/calculator.component';

const APP_ROUTES: Routes = [
  { path: '', component: CalculatorComponent },
  { path: 'dashboard', loadChildren: './dashboard/dashboard.module#DashboardModule' },
  { path: 'login', loadChildren: './auth/login/login.module#LoginModule' },
  { path: 'signup', loadChildren: './auth/signup/signup.module#SignupModule' },
  { path: 'compras', component: ComprasComponent },
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(APP_ROUTES)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
