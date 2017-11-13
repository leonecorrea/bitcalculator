import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import {
  FormsModule,
  FormGroup,
  FormControl,
  FormBuilder,
  ReactiveFormsModule
} from '@angular/forms';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app.routing';
import { ExchangeService } from './services/exchange.service';
import { ComprasComponent } from './compras/compras.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { LayoutComponent } from './layout/layout.component';
import { HeaderComponent } from './layout/header/header.component';
import { SharedModule } from './shared/shared.module';
import { CalculatorService } from './services/calculator.service';
import { FullLayoutComponent } from './layout/full-layout/full-layout.component';

@NgModule({
  declarations: [
    AppComponent,
    ComprasComponent,
    CalculatorComponent,
    LayoutComponent,
    HeaderComponent,
    FullLayoutComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRoutingModule,
    ReactiveFormsModule,
    SharedModule
  ],
  providers: [ExchangeService, CalculatorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
