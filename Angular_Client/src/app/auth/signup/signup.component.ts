import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Http } from '@angular/http';

import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {
  f: FormGroup;
  token: any;

  constructor(
    private _http: Http,
    private _authService: AuthService,
    private _formBuilder: FormBuilder
  ) { }

  ngOnInit() {
    this.f = this._formBuilder.group({
      name: [null],
      email: [null],
      password: [null],
      password2: [null]
    });
  }

  registrar() {
    this._authService.signup(this.f.value);
  }

}
