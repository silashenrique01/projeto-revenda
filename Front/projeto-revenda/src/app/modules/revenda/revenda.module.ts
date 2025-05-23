import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RevendaComponent } from './revenda.component';
import { RevendaRoutingModule } from './revenda-routing.module';
import { CadastroComponent } from './cadastro/cadastro.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    RevendaRoutingModule,
    FormsModule,
    ReactiveFormsModule
    
  ],
  declarations: [RevendaComponent, CadastroComponent]
})
export class RevendaModule { }
