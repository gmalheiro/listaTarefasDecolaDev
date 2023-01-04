import { ITarefaDTO } from 'src/interfaces/ITarefaDTO';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-tarefas-detalhe',
  templateUrl: './tarefas-detalhe.component.html',
  styleUrls: ['./tarefas-detalhe.component.css']
})
export class TarefasDetalheComponent implements OnInit {

  ngOnInit(): void {

  }

  @Input() tarefaParaDetalhar!: ITarefaDTO;
  @Input() public finalizarVisualizacao!: () => void;

  fecharVisualizacao() {
    this.finalizarVisualizacao();
  }
}
