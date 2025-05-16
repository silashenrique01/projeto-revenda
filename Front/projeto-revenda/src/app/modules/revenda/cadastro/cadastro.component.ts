import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ValidatorCnpj } from 'src/app/models/helpers/validator-cnpj';
import { Contato, Endereco, Revenda, Telefone } from 'src/app/models/Revenda';
import { RevendaService } from 'src/app/services/revenda.service';

export function phoneValidator(control: AbstractControl): ValidationErrors | null {
  const phonePattern = /^(?:\(?\d{2}\)?[\s-]?)?(?:9\d{4}[\s-]?\d{4}|\d{4}[\s-]?\d{4})$/;
  return phonePattern.test(control.value) ? null : { invalidPhone: true };
}

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent implements OnInit {
  formGroup: FormGroup = new FormGroup({});
  contatoformGroup: FormGroup = new FormGroup({});
  enderecoformGroup: FormGroup = new FormGroup({});
;
  get f():any{
    return this.formGroup.controls;
  }
 
  get c():any{
    return this.contatoformGroup.controls;
  }

  get e():any{
    return this.enderecoformGroup.controls;
  }

 
  

  constructor(private revendaService: RevendaService, private fb: FormBuilder, private toastr: ToastrService, private router: Router) { }

  ngOnInit() {
    this.validation();
  }

  public validation():void{
    this.formGroup = this.fb.group({
       cnpj:['', [Validators.required, ValidatorCnpj.validate]],
       razaoSocial:['', [Validators.required]],
       nomeFantasia:['', [Validators.required]],
       email:['', Validators.required, Validators.email],
       telefones:  [],
       contatos:  [],
       numero: ['', phoneValidator],
       enderecos: []
    })

    this.contatoformGroup = this.fb.group({
      nomePrincipal:['', Validators.required],
      nomeSecundario: ['']
    })

    this.enderecoformGroup = this.fb.group({
      longradouro:['', Validators.required],
      numero:['', Validators.required],
      cidade:['', Validators.required],
      estado:['', Validators.required],
      bairro:['', Validators.required],
      cep:['', Validators.required],
      complemento:['', ],
      pontoReferencia:['']
    })

  }


 

  adicionarTelefone(): void {
    const numero = this.formGroup.get('numero')?.value;
  }

  enviar(){
    console.log(this.formGroup.controls);


    var enderecos:Endereco[] = []
    enderecos.push(this.enderecoformGroup.value)
    this.formGroup.get('enderecos')?.setValue(enderecos)
    
    var telefones:Telefone[] = []
    telefones.push({numero:this.formGroup.get('numero')?.value})
    this.formGroup.get('telefones')?.setValue(telefones)
    
    var contato:Contato[] = []
    contato.push({nome: this.contatoformGroup.get('nomePrincipal')?.value, sobrenome:"", contatoPrincipal:true}, {nome:this.contatoformGroup.get('nomeSecundario')?.value, sobrenome:"", contatoPrincipal:false})
    this.formGroup.get('contatos')?.setValue(contato)

    var revenda = new Revenda();
    revenda = this.formGroup.value;

    this.AddRevenda(revenda);


  }

  AddRevenda(revenda: Revenda){
    this.revendaService.addRevenda(revenda).subscribe((res)=>{
      console.log(res)
       this.toastr.success('Cadastrado realizado', 'Sucesso');
       this.router.navigate(['/registro']);
    }, (error) => {
      console.error(error);
      this.toastr.error('Não foi possivel realizar o cadastro', 'Erro');
    })
  }


}
