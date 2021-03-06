import { TestBed, inject } from '@angular/core/testing';

import { CalculadoraService } from './calculadora.service';

describe('CalculadoraService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CalculadoraService = TestBed.get(CalculadoraService);
    expect(service).toBeTruthy();
  });

  it('deve garantir que 1 + 4 = 5',
    inject([CalculadoraService], (service: CalculadoraService) => {
      let soma = service.calcular(1,4,CalculadoraService.SOMA);
      expect(soma).toEqual(5);
    })
  );

  it('deve garantir que 1 - 4 = -3',
    inject([CalculadoraService], (service: CalculadoraService) => {
      let subtracao = service.calcular(1,4,CalculadoraService.SUBTRACAO);
      expect(subtracao).toEqual(-3)
    })
  );

  it('deve garantir que 2 / 2 = 1',
    inject([CalculadoraService],(service: CalculadoraService) =>{
      let divisao = service.calcular(2,2,CalculadoraService.DIVISAO);
      expect(divisao).toEqual(1)
    })
  )

  it('deve garantir que 3 * 2 = 6',
    inject([CalculadoraService], (service: CalculadoraService) => {
      let multiplicacao = service.calcular(3,2,CalculadoraService.MULTIPLICACAO);
      expect(multiplicacao).toEqual(6)
    })
  )

  it('Deve retornar 0 para operação inválida',
    inject([CalculadoraService],(service: CalculadoraService) => {
      let operacaoInvalida = service.calcular(1,4,'&');
      expect(operacaoInvalida).toEqual(0)
    })
  )

});
