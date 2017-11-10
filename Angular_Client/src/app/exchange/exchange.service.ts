import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';

import { Exchange } from '../classes/Exchange';

@Injectable()
export class ExchangeService {
  private _Url = 'http://localhost:37060/api/Exchanges';

  constructor(private _http: Http) { }

  /**O Observable serve para emitir uma notificação toda vez em que houver alteração em seu
   * item. */

  GetAll(): Observable<Exchange> {
    return this._http.get(this._Url)
            .map((response: Response) => <Exchange>response.json())
            .do(data => console.log('All: ' + JSON.stringify(data)))
            .catch(this.handleError);
  }

/**Na sequência, fazemos a chamada via o método get da classe http e efetuamos o
 * mapeamento, dizendo que a resposta obtida deve ser mapeada para o objeto
 * do tipo Exchange. */

  private handleError(error: Response) {
    console.error(error);
    return Observable.throw(error.json().error || 'Server error');
  }

}
