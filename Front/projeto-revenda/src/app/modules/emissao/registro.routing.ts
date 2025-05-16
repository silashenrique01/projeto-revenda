import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmissaoComponent } from './emissao.component';

const routes: Routes = [
   { path: '', component: EmissaoComponent },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EmissaoRoutingModule { }
