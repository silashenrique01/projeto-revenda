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
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent implements OnInit {
  
  formGroup: FormGroup = new FormGroup({});
  revendas:Revenda[] | null = [];


    get f():any{
    return this.formGroup.controls;
  }
  constructor(private fb: FormBuilder, private serviceRegistro: RegistroService, private revendaService:RevendaService, private toastr: ToastrService, private router: Router) { }

  ngOnInit() {
    this.validation()
    this.getAllRevendas();
  }

   public validation():void{
      this.formGroup = this.fb.group({
         clienteId:[''],
         produto:[''],
         quantidade:[''],
         revendaId:['']
      })

    }

    enviar(){
      console.log(this.formGroup.value)

      var produto = new Produto();
      produto.quantidade = this.formGroup.get('quantidade')?.value;
      produto.nome = this.formGroup.get('produto')?.value;
      var pedido = new Pedido();
      pedido.clienteId = this.formGroup.get('clienteId')?.value;
      pedido.revendaId = this.formGroup.get('revendaId')?.value;
      pedido.produtos.push(produto)

      this.serviceRegistro.addRegistro(pedido).subscribe((res:ApiResponse<Pedido>) => {
        console.log(res);
        this.toastr.success('Cadastrado realizado', 'Sucesso');
       this.router.navigate(['/registro']);
      }, (error) =>{
 this.toastr.error('Não foi possivel realizar a emissão do pedido', 'Erro');
        console.error(error);
      })

    }

    getAllRevendas(){
      this.revendaService.getAllRevendas().subscribe((res:ApiResponse<Revenda[]>) =>{
          this.revendas = res.data;

      })
    }

}
