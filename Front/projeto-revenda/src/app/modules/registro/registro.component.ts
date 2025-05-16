import { Component, OnInit } from '@angular/core';
import { ApiResponse } from 'src/app/models/ApiResponse';
import { Pedido } from 'src/app/models/Pedido';
import { RegistroService } from 'src/app/services/registro.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.scss']
})
export class RegistroComponent implements OnInit {
  pedidos:Pedido[] | null = [];
  constructor(private serviceRegistro: RegistroService) { }

  ngOnInit() {
    this.getRegistros()
  }

  getRegistros(){
    this.serviceRegistro.getAllRegistros().subscribe((res:ApiResponse<Pedido[]>) =>{
      this.pedidos = res.data
    })
  }
}
