import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Categoria } from '../models/categorias';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})

export class CategoriaService {

  private url: string = environment.categoriaApi;

  constructor(private http: HttpClient) { }

  public obtenerCategorias(): Observable<Array<Categoria>> {

    return this.http.get<Array<Categoria>>(this.url);
  }

  public obtenerCategoria(id: number): Observable<Categoria> {

    return this.http.get<Categoria>(`${this.url}/${id}`);
  }

  public agregarCategoria(insertarCategoria: Categoria): Observable<Categoria> {

    return this.http.post<Categoria>(this.url, insertarCategoria);
  }

  public editarCategoria(id: number, editarCategoria: Categoria): Observable<Categoria> {

    return this.http.put<Categoria>(`${this.url}/${id}`, editarCategoria);
  }

  public eliminarCategoria(id: number): Observable<any> {

    return this.http.delete<any>(`${this.url}/${id}`);
  }
}