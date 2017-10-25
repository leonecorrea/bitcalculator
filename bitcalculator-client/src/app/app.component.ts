import { Component } from '@angular/core';
import { Observable } from 'rxjs/Observable';

import { ExchangeService } from './exchange/exchange.service';
import { Exchange } from './classes/Exchange';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  exchange: Exchange;

  constructor(private _exchange: ExchangeService) { }

  getAll(): void {
    this._exchange.GetAll()
      .subscribe((data: Exchange) => this.exchange = data,
      error => console.log(error));
  }
}
