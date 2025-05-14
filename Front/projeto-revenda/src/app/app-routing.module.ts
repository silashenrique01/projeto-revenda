import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
   { path: '', redirectTo: '/revenda', pathMatch: 'full' },
   {path:'revenda', loadChildren: () => import('./modules/revenda/revenda.module').then(m => m.RevendaModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
