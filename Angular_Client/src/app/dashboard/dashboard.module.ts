import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HttpModule } from '@angular/http';
import {
  FormsModule,
  FormGroup,
  FormControl,
  FormBuilder,
  ReactiveFormsModule
} from '@angular/forms';

import { DashboardRoutingModule } from './dashboard.routing.module';
import { DashboardComponent } from './dashboard.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { ExchangeService } from '../services/exchange.service';
import { LayoutComponent } from '../layout/layout.component';
import { HeaderComponent } from '../layout/header/header.component';
import { SharedModule } from '../shared/shared.module';
import { CalculatorService } from '../services/calculator.service';
import { FullLayoutComponent } from '../layout/full-layout/full-layout.component';
import { HistoricoDeComprasComponent } from './historico-de-compras/historico-de-compras.component';
import { AuthService } from '../services/auth.service';
import { AuthGuard } from '../guards/auth.guard';
import { HistoricoDeComprasService } from '../services/historico-de-compras.service';

@NgModule({
  imports: [
    CommonModule,
    DashboardRoutingModule,
    SharedModule,
    FormsModule,
    HttpModule,
    ReactiveFormsModule,
    SharedModule
  ],
  declarations: [
    DashboardComponent,
    HistoricoDeComprasComponent,
    CalculatorComponent
  ],
  providers: [ExchangeService, CalculatorService, AuthService, AuthGuard, HistoricoDeComprasService]
})
export class DashboardModule { }
