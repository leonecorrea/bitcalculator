import { TestBed, inject } from '@angular/core/testing';

import { HistoricoDeComprasService } from './historico-de-compras.service';

describe('HistoricoDeComprasService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HistoricoDeComprasService]
    });
  });

  it('should be created', inject([HistoricoDeComprasService], (service: HistoricoDeComprasService) => {
    expect(service).toBeTruthy();
  }));
});
