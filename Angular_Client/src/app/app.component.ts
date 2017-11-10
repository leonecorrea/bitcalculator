import { Component } from '@angular/core';
import { Observable } from 'rxjs/Observable';

import { ExchangeService } from './exchange/exchange.service';
import { Exchange } from './classes/Exchange';

@Component({
  selector: 'app-root',
  template: '<router-outlet></router-outlet>',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor() { }

}
