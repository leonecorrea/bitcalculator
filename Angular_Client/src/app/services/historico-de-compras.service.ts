import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class HistoricoDeComprasService {

  constructor(
    private http: Http
  ) { }

  // Url dos dados do historico de compra
  private urlAllCompras = 'http://localhost:37060/compras';
  private urlCompra = 'http://localhost:37060/compra';

  private getCompras() {
    return this.http.get(this.urlAllCompras).map(res => res).subscribe();
  }
  public getAllCompras() {
    return this.getCompras();
  }

  /**
   * Nova Compra
   */
  public newCompra(form) {
    return this.http.post(this.urlCompra, form)
    .toPromise()
    .then(res => console.log(res));

    // const req: any = new XMLHttpRequest();
    // req.open('POST', this.urlCompra, true);
    // req.setRequestHeader('Content-type', 'aplication.json');
  }

}
