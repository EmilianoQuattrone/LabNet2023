export class Categoria {

    Id?: number;
    Nombre: string;
    Descripcion: string;

    constructor(nombre: string, descripcion: string, id?: number) {

        this.Id = id;
        this.Nombre = nombre;
        this.Descripcion = descripcion;
    }
}