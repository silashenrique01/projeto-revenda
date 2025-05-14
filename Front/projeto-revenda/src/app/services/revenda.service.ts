import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Revenda } from '../models/Revenda';
import { ApiResponse } from '../models/ApiResponse';

@Injectable({
  providedIn: 'root'
})
export class RevendaService {
api = "https://localhost:44307/api/Revenda"

constructor(private http: HttpClient) { }


getAllRevendas(){
  return this.http.get<ApiResponse<Revenda[]>>(`${this.api}`);
}

addRevenda(revenda: Revenda){
  return this.http.post(`${this.api}`, revenda);
}

}
