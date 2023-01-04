import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule} from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { TarefasDetalheComponent } from './tarefas-detalhe/tarefas-detalhe.component';
import { TarefasListaComponent } from './tarefas-lista/tarefas-lista.component';

@NgModule({
  declarations: [
    AppComponent,
    TarefasDetalheComponent,
    TarefasListaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
