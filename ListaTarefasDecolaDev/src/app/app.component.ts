import { ITarefaDTO } from './../interfaces/ITarefaDTO';
import {
  Component,
  ElementRef,
  ViewChild,
} from '@angular/core';

import {
  trigger,
  transition,
  style,
  animate,
  keyframes
} from '@angular/animations';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  animations: [trigger("moveInLeft", [transition("void=> *", [style({ transform: "translateX(300px)" }), animate(200, keyframes([style({ transform: "translateX(300px)" }), style({ transform: "translateX(0)" })]))]),
  transition("*=>void", [style({ transform: "translateX(0px)" }), animate(100, keyframes([style({ transform: "translateX(0px)" }), style({ transform: "translateX(300px)" })]))])])
  ]
})
export class AppComponent {
  listaTarefaTipada :ITarefaDTO[] = [];
  idBancoFake:number = 1;
  tarefaNomeModel:string = "";
  @ViewChild('tarefa') inputNomeTarefa!: ElementRef;

  adicionarTarefa(valor: string) {
    this.listaTarefaTipada.push({ id: this.idBancoFake, nome: valor });
    // this.storageInfo.setItem('listaDeTarefas', JSON.stringify(this.listaTarefaTipada));

    this.idBancoFake++;
    console.log(`Adicionando a tarefa: ${valor}`);
    console.log(`Indice da tarefa: ${this.idBancoFake}`);

    this.tarefaNomeModel = '';
    this.inputNomeTarefa.nativeElement.focus();
  }

  removerTarefa(id: number) {
    for (let i = 0; i < this.listaTarefaTipada.length; i++) {
      if (id == this.listaTarefaTipada[i].id) {
        this.listaTarefaTipada.splice(i, 1);
        console.log(`Removendo tarefa pelo id: ${id}`);
      }
    }
  }

  submitFormularioTarefa(valorFormulario: any) {
    console.log(`Valor do formulário: ${JSON.stringify(valorFormulario)}`);
    this.adicionarTarefa(valorFormulario.tarefa);
  }

  editarTarefa(id: number) {
    this.router.navigate([`editar/${id}`]);
  }

  constructor() {
  }

}
