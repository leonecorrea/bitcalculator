import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { Calculo } from '../classes/Calculo';

@Injectable()
export class CalculatorService {

  constructor(private _http: Http) { }

  private _urlCalculoTaxas: any = 'http://localhost:37060/calculo';

  public calcularTaxas(formulario) {
    return this._http
      .post(this._urlCalculoTaxas, formulario)
      .toPromise()
      .then(res => res.json());
      // .subscribe(success => {
      //     console.log(success.json());
      //     const data = success.json();
      //   }, error => {
      //     console.log(error.json());
      //   });
  }
}
