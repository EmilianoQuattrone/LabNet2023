import { Component, OnInit, OnDestroy } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { Categoria } from 'src/app/models/categorias';
import { CategoriaService } from 'src/app/servicio/categoria.service';

@Component({
  selector: 'app-eliminar-categoria',
  templateUrl: './eliminar-categoria.component.html',
  styleUrls: ['./eliminar-categoria.component.css']
})
export class EliminarCategoriaComponent implements OnInit {

  id: number;
  formularioEliminar!: Categoria;

  constructor(private categoriaService: CategoriaService,
    private activatedRoute: ActivatedRoute,
    private router: Router, private _snackBar: MatSnackBar) {

    this.id = Number(this.activatedRoute.snapshot.paramMap.get('id'));
  }

  ngOnInit(): void {

    this.obtenerCategoria();
  }

  obtenerCategoria() {

    this.categoriaService.obtenerCategoria(this.id).subscribe(data => {

      this.formularioEliminar = data
    });
  }

  eliminarCategoria() {
    this.categoriaService.eliminarCategoria(this.id).subscribe({

      next: () => {

        this._snackBar.open(`Categoria eliminada`, undefined, {
          duration: 3000
        });
      },
      error: () => {
        this._snackBar.open('No tiene permisos para eliminar esta categoria.', undefined,
          {
            duration: 3000
          });
      }
    })
    this.router.navigate(['/listadoCategorias']);
  }
}