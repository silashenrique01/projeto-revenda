import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
   { path: '', redirectTo: '/revenda', pathMatch: 'full' },
   {path:'revenda', loadChildren: () => import('./modules/revenda/revenda.module').then(m => m.RevendaModule) },
   {path:'registro', loadChildren: () => import('./modules/registro/registro.module').then(m => m.RegistroModule) },
   {path:'emissao', loadChildren: () => import('./modules/emissao/emissao.module').then(m => m.EmissaoModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
