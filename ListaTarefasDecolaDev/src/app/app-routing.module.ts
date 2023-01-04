import { TarefaEditarComponent } from './tarefa-editar/tarefa-editar.component';
import { TarefasListaComponent } from './tarefas-lista/tarefas-lista.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TarefasDetalheComponent } from './tarefas-detalhe/tarefas-detalhe.component';

const routes: Routes = [
  { path: 'lista', component: TarefasListaComponent },
  {path:'editar/:id',component: TarefaEditarComponent},
  { path: '**', redirectTo: 'lista' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
