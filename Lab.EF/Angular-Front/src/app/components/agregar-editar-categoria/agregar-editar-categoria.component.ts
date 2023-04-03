import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Categoria } from '../../models/categorias';
import { CategoriaService } from 'src/app/servicio/categoria.service';
import { Router, ActivatedRoute } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-agregar-editar-categoria',
  templateUrl: './agregar-editar-categoria.component.html',
  styleUrls: ['./agregar-editar-categoria.component.css']
})

export class AgregarEditarCategoriaComponent implements OnInit {

  id: number;
  formulario: FormGroup;
  titulo: string = 'Agregar';
  // formularioCategoriaInputs!: Categoria;

  constructor(private formBuilder: FormBuilder, private categoriaService: CategoriaService,
    private router: Router, private activatedRoute: ActivatedRoute,
    private _snackBar: MatSnackBar) {

    this.id = Number(this.activatedRoute.snapshot.paramMap.get('id'));

    this.formulario = this.formBuilder.group({

      inputCategoria: ['', [Validators.required, Validators.maxLength(15),
      Validators.pattern('^[a-zA-Z]+$')]],
      inputDescripcion: ['', [Validators.pattern('^[a-zA-Z]+$')]]
    });
  }

  ngOnInit(): void {

    if (this.id != 0) {

      this.titulo = 'Editar';
      this.obtenerCategoria(this.id);
    }
  }

  obtenerCategoria(id: number) {

    this.categoriaService.obtenerCategoria(id).subscribe((data) => {

      this.formulario.patchValue({
        inputCategoria: data.Nombre,
        inputDescripcion: data.Descripcion
      });
    })
  }

  agregarEditarCategoria() {

    const categoria: Categoria = {

      Nombre: this.formulario.value.inputCategoria,
      Descripcion: this.formulario.value.inputDescripcion,
    }

    if (this.id != 0) {

      categoria.Id = this.id;
      this.editarCategoria(this.id, categoria);
    }
    else {

      this.agregarCategoria(categoria);
    }
  }

  agregarCategoria(insertarCategoria: Categoria) {

    this.categoriaService.agregarCategoria(insertarCategoria).subscribe({

      next: (e) => {

        this._snackBar.open('Categoria agregada.', undefined, {
          duration: 3000
        })

        this.router.navigate(['/listadoCategorias']);
      },
      error: () => {

        this._snackBar.open('Formulario no valido, verifique los campos.', undefined,
          {
            duration: 3000
          });
      },
    });
  }

  editarCategoria(id: number, modificarCategoria: Categoria) {

    this.categoriaService.editarCategoria(id, modificarCategoria).subscribe({

      next: () => {

        this._snackBar.open('Categoria modificada', undefined, {
          duration: 3000
        })

        this.router.navigate(['/listadoCategorias']);
      },
      error: () => {
        this._snackBar.open('Formulario no valido, verifique los campos.', undefined,
          {
            duration: 3000
          });
      }
    });
  }
}