import { NgModule } from '@angular/core';

import { SignupComponent } from './signup.component';
import { Routes, RouterModule } from '@angular/router';

const ROUTER: Routes = [
  { path: '', component: SignupComponent }
];

@NgModule({
  imports: [RouterModule.forChild(ROUTER)],
  exports: [RouterModule]
})

export class SignupRoutingModule {
  constructor() {}
}
