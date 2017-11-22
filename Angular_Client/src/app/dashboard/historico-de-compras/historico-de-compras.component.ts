import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

import { HistoricoDeComprasService } from '../../services/historico-de-compras.service';

@Component({
  selector: 'app-historico-de-compras',
  templateUrl: './historico-de-compras.component.html',
  styleUrls: ['./historico-de-compras.component.css']
})
export class HistoricoDeComprasComponent implements OnInit {

  constructor(
    private http: Http,
    private historicoCompras: HistoricoDeComprasService
  ) { }

  ngOnInit() {
    console.log(this.historicoCompras.getAllCompras());
  }

}
