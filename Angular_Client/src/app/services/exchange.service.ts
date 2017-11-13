import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';

import { Exchange } from '../classes/Exchange';

@Injectable()
export class ExchangeService {
  exchanges: any;

  private readonly _exchangesUrl = 'https://api.bitvalor.com/v1/exchanges.json';
  // private _exchangesUrl = 'http://localhost:37060/Exchanges';

  constructor(private _http: Http) {}

  // O Observable serve para emitir uma notificação toda vez em que houver alteração item.
  public getAllExchanges() {
    this._http.get(this._exchangesUrl).subscribe(
      success => {
        console.log(success.json());
      },
      error => {
        console.log(error.json());
      }
    );
  }
}
