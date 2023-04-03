import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AgregarEditarCategoriaComponent } from './components/agregar-editar-categoria/agregar-editar-categoria.component';
import { EliminarCategoriaComponent } from './components/eliminar-categoria/eliminar-categoria.component';
import { PaginaErrorComponent } from './components/pagina-error/pagina-error.component';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ObtenerCategoriasComponent } from './components/obtener-categorias/obtener-categorias.component';
import { SharedModule } from './shared/shared.module';

@NgModule({
  declarations: [
    AppComponent,
    ObtenerCategoriasComponent,
    EliminarCategoriaComponent,
    PaginaErrorComponent,
    AgregarEditarCategoriaComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }