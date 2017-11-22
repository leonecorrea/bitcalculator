import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Router } from '@angular/router';
import { User } from '../classes/User';

@Injectable()
export class AuthService {

  constructor(
    private _http: Http,
    private router: Router
  ) { }

  // url do login
  private _urlLogin: any = 'http://localhost:37060/login';
  private _urlSignup: any = 'http://localhost:37060/signup';
  private usuarioAutenticado: boolean;
  private token = false;

  public login(dados) {
    /*this._http
      .post(this._urlLogin, JSON.stringify(user))
      .map(res => res)
      .subscribe(dados => console.log(user));*/

      if (dados.email === 'root' && dados.senha === 'root') {
        this.usuarioAutenticado = true;
        this.router.navigate(['/dashboard']);
      }
      this.usuarioAutenticado = false;
  }

  isAutenticated() {
    return this.login;
  }

  signup(dados) {
    return this._http.post(this._urlSignup, dados)
    .toPromise()
    .then(res => console.log(res));
  }

}
