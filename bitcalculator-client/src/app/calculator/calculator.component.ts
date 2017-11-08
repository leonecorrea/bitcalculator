import { Component, OnInit } from '@angular/core';

import { Exchange } from '../classes/Exchange';
import { Http } from '@angular/http';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {
  constructor(private _http: Http) {}

  public exchanges: any;

  compra: any = {
    nome: '',
    valor: ''
  };

  venda: any = {
    nome: '',
    valor: ''
  };

  ngOnInit(): void {
    this._http
      // .get('http://localhost:37060/api/Exchanges')
      .get('https://api.bitvalor.com/v1/exchanges.json')
      .subscribe(data => {
        this.exchanges = data;
        this.getAllExchanges(data);
        console.log(data);
      });
  }

  getAllExchanges(data) {
    for (let i = 0; i < data.length; i++) {
      const count = Array[i];
    }
  }

  calcularMontante() {
    //
    console.log('Montante');
  }
}
