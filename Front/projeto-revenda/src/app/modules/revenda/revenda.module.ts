import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RevendaComponent } from './revenda.component';
import { RevendaRoutingModule } from './revenda-routing.module';
import { CadastroComponent } from './cadastro/cadastro.component';

@NgModule({
  imports: [
    CommonModule,
    RevendaRoutingModule
  ],
  declarations: [RevendaComponent, CadastroComponent]
})
export class RevendaModule { }
