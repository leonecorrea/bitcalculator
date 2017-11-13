import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class CalculatorService {

  constructor(private _http: Http) { }

  private _urlCalculoTaxas: any = 'https://httpbin.org/post';

  /**
   * CalcularMontante
   */
  public calcularTaxas(formulario) {
    this._http
      .post(this._urlCalculoTaxas, JSON.stringify(formulario))
      .map(res => res)
      .subscribe(dados => console.log(dados));
  }
}
