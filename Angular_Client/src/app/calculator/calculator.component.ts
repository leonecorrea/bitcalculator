import { Component, OnInit } from '@angular/core';

import { Exchange } from '../classes/Exchange';
import { Http } from '@angular/http';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {
  f: FormGroup;

  constructor(
    private _http: Http,
    private formBuilder: FormBuilder
  ) {}

  ngSubmit() {
    console.log(this.f);
  }

  // tslint:disable-next-line:member-ordering
  public exchanges: any;

  // tslint:disable-next-line:member-ordering
  compra: any = {
    nome: '',
    valor: ''
  };

  // tslint:disable-next-line:member-ordering
  venda: any = {
    nome: '',
    valor: ''
  };

  ngOnInit() {

    this.f = this.formBuilder.group({
      exchangeCompra: [null],
      valorCompra: [null],
      exchangeVenda: [null],
      valorVenda: [null]
    });

    this._http
      .get('http://localhost:37060/api/Exchanges')
      // .get('https://api.bitvalor.com/v1/exchanges.json')
      .subscribe(data => {
        this.exchanges = data;
        this.getAllExchanges(data);
        console.log(data);
      });
  }

  getAllExchanges(data) {
    for (let i = 0; i < data.length; i++) {
      const count = Array[i];
      const exch = data[i];
      console.log(exch);
    }
  }

  calcularMontante() {
    //
    console.log('Montante');
  }
}
