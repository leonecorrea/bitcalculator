import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Http } from '@angular/http';

import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  f: FormGroup;
  token: any;

  constructor(
    private _http: Http,
    private _authService: AuthService,
    private _formBuilder: FormBuilder
  ) { }

  ngOnInit() {
    this.f = this._formBuilder.group({
      email: [null],
      senha: [null],
      lembrar: [false]
    });
  }

  login() {
    this._authService.login(this.f.value);
    console.log(this.f.value);
  }
}
