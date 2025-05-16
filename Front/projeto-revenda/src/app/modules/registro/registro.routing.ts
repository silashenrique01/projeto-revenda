import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegistroComponent } from './registro.component';
import { CadastroComponent } from './cadastro/cadastro.component';

const routes: Routes = [
   { path: '', component: RegistroComponent },
   { path: 'registrar-pedido', component: CadastroComponent }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RegistroRoutingModule { }
