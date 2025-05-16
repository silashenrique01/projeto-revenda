import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Pedido, Produto } from '../models/Pedido';
import { ApiResponse } from '../models/ApiResponse';

@Injectable({
  providedIn: 'root'
})
export class RegistroService {
api = "https://localhost:44307/api/Ordem"
constructor(private http: HttpClient) { }


getAllRegistros(){
  return this.http.get<ApiResponse<Pedido[]>>(`${this.api}`);
}

getAllRegistrosByRevenda(id:any){
  return this.http.get<ApiResponse<Pedido[]>>(`${this.api}/GetByRevenda/${id}`);
}

addRegistro(pedido: Pedido){
  return this.http.post<ApiResponse<Pedido>>(`${this.api}`, pedido);
}

emitirPedido(produto:any){
  return this.http.post<ApiResponse<Pedido>>(`${this.api}/pedidos-revenda`, produto);
}


}
