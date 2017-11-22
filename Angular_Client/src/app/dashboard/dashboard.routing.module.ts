import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DashboardComponent } from './dashboard.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { HistoricoDeComprasComponent } from './historico-de-compras/historico-de-compras.component';
import { AuthGuard } from '../guards/auth.guard';

const ROUTER: Routes = [
  {
    path: '', component: DashboardComponent, canActivate: [AuthGuard],
    children: [
      { path: 'calcular', component: CalculatorComponent },
      { path: 'historico-de-compras', component: HistoricoDeComprasComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(ROUTER)],
  exports: [RouterModule]
})

export class DashboardRoutingModule {}
