import { Component, OnInit } from '@angular/core';
import { ApiResponse } from 'src/app/models/ApiResponse';
import { Revenda } from 'src/app/models/Revenda';
import { RevendaService } from 'src/app/services/revenda.service';
export const MOCK_REVENDAS: Revenda[] = [
  {
    cnpj: '12.345.678/0001-99',
    razaoSocial: 'Revenda Automotiva LTDA',
    nomeFantasia: 'AutoRevenda',
    email: 'contato@autorevenda.com.br',
    telefones: [
      { numero: '(11) 98765-4321'},
      { numero: '(11) 3456-7890' }
    ],
    contatos: [
      { nome: 'João Silva', sobrenome: 'joao.silva@autorevenda.com.br', contatoPrincipal: true },
      { nome: 'Maria Oliveira', sobrenome: 'maria.oliveira@autorevenda.com.br', contatoPrincipal: false }
    ],
    enderecos: [
      { longradouro: 'Av. Paulista', numero: '1000', cidade: 'São Paulo', estado: 'SP', cep: '01311-000', bairro:"Jardim Vergueiro", complemento: "", pontoReferencia: "" },
      { longradouro: 'Rua das Flores', numero: '200', cidade: 'Campinas', estado: 'SP', cep: '13000-000', bairro:"Jardim Vergueiro", complemento: "", pontoReferencia: "" }
    ]
  },
  {
    cnpj: '98.765.432/0001-55',
    razaoSocial: 'Super Carros LTDA',
    nomeFantasia: 'SuperCar',
    email: 'contato@supercar.com.br',
    telefones: [
      { numero: '(21) 91234-5678'}
    ],
   contatos: [
      { nome: 'João Silva', sobrenome: 'joao.silva@autorevenda.com.br', contatoPrincipal: true },
      { nome: 'Maria Oliveira', sobrenome: 'maria.oliveira@autorevenda.com.br', contatoPrincipal: false }
    ],
   enderecos: [
      { longradouro: 'Av. Paulista', numero: '5000', cidade: 'São Paulo', estado: 'SP', cep: '01311-000', bairro:"Jardim Vergueiro", complemento: "", pontoReferencia: "" },
      { longradouro: 'Rua das Flores', numero: '850', cidade: 'Campinas', estado: 'SP', cep: '13000-000', bairro:"Jardim Vergueiro", complemento: "", pontoReferencia: "" }
    ]
  }
];


@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent implements OnInit {

  constructor(private revendaService: RevendaService) { }

  ngOnInit() {
    this.AddRevenda(MOCK_REVENDAS[0])
  }


  AddRevenda(revenda: Revenda){
    this.revendaService.addRevenda(revenda).subscribe((res)=>{
      console.log(res)
    }, (error) => {
      console.error(error);
    })
  }


}
