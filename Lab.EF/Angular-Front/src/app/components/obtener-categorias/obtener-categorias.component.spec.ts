import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObtenerCategoriasComponent } from './obtener-categorias.component';

describe('ObtenerCategoriasComponent', () => {
  let component: ObtenerCategoriasComponent;
  let fixture: ComponentFixture<ObtenerCategoriasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ObtenerCategoriasComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ObtenerCategoriasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
