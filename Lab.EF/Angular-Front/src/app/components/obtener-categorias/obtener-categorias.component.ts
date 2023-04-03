import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { CategoriaService } from 'src/app/servicio/categoria.service';

@Component({
  selector: 'app-obtener-categorias',
  templateUrl: './obtener-categorias.component.html',
  styleUrls: ['./obtener-categorias.component.css']
})

export class ObtenerCategoriasComponent implements OnInit {

  displayedColumns: string[] = ['nombre', 'descripcion', 'otrasopciones'];
  dataSource = new MatTableDataSource();
  //Leer documentacion
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private categoriaService: CategoriaService, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.obtenerCategorias();
  }

  obtenerCategorias() {

    this.categoriaService.obtenerCategorias().subscribe({

      next: (data) => this.dataSource.data = data,
      error: () => {
        this._snackBar.open('No se pudo cargar las categorias, Refresque la página.',
          undefined,
          {
            duration: 3000
          });
      },
    });
  }

  buscarCategoria(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  ngAfterViewInit() {
    this.dataSource.sort = this.sort;
  }
}