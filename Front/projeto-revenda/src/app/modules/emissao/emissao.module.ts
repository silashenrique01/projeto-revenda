import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmissaoComponent } from './emissao.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EmissaoRoutingModule } from './registro.routing';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    EmissaoRoutingModule
  ],
  declarations: [EmissaoComponent]
})
export class EmissaoModule { }
