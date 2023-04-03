import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AgregarEditarCategoriaComponent } from './components/agregar-editar-categoria/agregar-editar-categoria.component';
import { EliminarCategoriaComponent } from './components/eliminar-categoria/eliminar-categoria.component';
import { ObtenerCategoriasComponent } from './components/obtener-categorias/obtener-categorias.component';
import { PaginaErrorComponent } from './components/pagina-error/pagina-error.component';

const routes: Routes = [
  { path: '', redirectTo: '/listadoCategorias', pathMatch: 'full' },
  { path: 'listadoCategorias', component: ObtenerCategoriasComponent },
  { path: 'insertarCategoria', component: AgregarEditarCategoriaComponent },
  { path: 'editarCategoria/:id', component: AgregarEditarCategoriaComponent },
  { path: 'eliminarCategoria/:id', component: EliminarCategoriaComponent },
  { path: '**', component: PaginaErrorComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }