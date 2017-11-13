import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FormDebugComponent } from './form-debug/form-debug.component';
import { CampoControlErrorComponent } from './campo-control-error/campo-control-error.component';
import { GuardComponent } from './guard/guard.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    FormDebugComponent,
    CampoControlErrorComponent,
    GuardComponent
  ],
  exports: [
    FormDebugComponent,
    CampoControlErrorComponent
  ]
})
export class SharedModule { }
