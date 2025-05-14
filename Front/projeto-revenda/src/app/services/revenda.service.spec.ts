/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { RevendaService } from './revenda.service';

describe('Service: Revenda', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RevendaService]
    });
  });

  it('should ...', inject([RevendaService], (service: RevendaService) => {
    expect(service).toBeTruthy();
  }));
});
