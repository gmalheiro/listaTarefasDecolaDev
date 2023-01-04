import { TarefasListaComponent } from './tarefas-lista/tarefas-lista.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TarefasDetalheComponent } from './tarefas-detalhe/tarefas-detalhe.component';

const routes: Routes = [
  { path: 'lista', component: TarefasListaComponent },
  { path: '**', redirectTo: 'lista' },
  {path:'detalhe/id',component: TarefasDetalheComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
