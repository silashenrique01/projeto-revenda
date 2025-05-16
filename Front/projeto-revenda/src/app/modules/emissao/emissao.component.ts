import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ApiResponse } from 'src/app/models/ApiResponse';
import { Pedido, Produto } from 'src/app/models/Pedido';
import { Revenda } from 'src/app/models/Revenda';
import { RegistroService } from 'src/app/services/registro.service';
import { RevendaService } from 'src/app/services/revenda.service';

@Component({
  selector: 'app-emissao',
  templateUrl: './emissao.component.html',
  styleUrls: ['./emissao.component.scss']
})
export class EmissaoComponent implements OnInit {
  pedidos:Pedido[] = []
  revendas:Revenda[] = [];
  formGroup: FormGroup = new FormGroup({});
  revendaSelecionada = "";

     get f():any{
    return this.formGroup.controls;
  }
  constructor(private fb: FormBuilder, private service:RegistroService, private revendaService:RevendaService, private toastr: ToastrService, private router: Router) {
     this.formGroup = this.fb.group({
         revenda:[],
         pedido: [[]]
      })

   }

  ngOnInit() {

    this.getAllRevendas();
  }

  getAll(event: Event){
     const target = event.target as HTMLSelectElement;

    this.service.getAllRegistrosByRevenda(target.value.toString()).subscribe((res:ApiResponse<Pedido[]>) =>{
      this.pedidos = res.data;
    })
  }

      getAllRevendas(){
      this.revendaService.getAllRevendas().subscribe((res:ApiResponse<Revenda[]>) =>{
          this.revendas = res.data;

      })
    }

  enviar(){
    console.log(this.formGroup.value)

    var produtos:Produto[] = [];
    var obj = this.formGroup.value;

    obj.pedido.forEach((element:Pedido) => {
      
      element.produtos.forEach((item:Produto) =>{
          produtos.push(item);
      });

    });

    this.pedidos[0].produtos = produtos;
    console.log(produtos)

    this.service.emitirPedido(this.pedidos[0]).subscribe((res:any) =>{
      console.log(res);
        this.toastr.success(`Pedido realizado, protocolo: ${res.ordemRevendaId}`, 'Sucesso');
       this.router.navigate(['/registro']);

    }, (error) =>{
       this.toastr.error('Não foi possivel realizar o cadastro', 'Erro');
      console.log(error)
    })
  }

}
