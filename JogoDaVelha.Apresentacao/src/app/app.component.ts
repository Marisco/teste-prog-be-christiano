import { Component } from "@angular/core";
import { ApiService } from './api/api.service'
import { Jogador0, JogadorX, Partida, Situacao, Tabluleiro } from './models/partida.model';


@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"]
})
export class AppComponent {
  titulo = "Jogo Da Velha";
  situacao = "Não Iniciada";
  tabuleiro = [["", "", ""], ["", "", ""], ["", "", ""]];
  iniciar = false;
  isCirculo = this.iniciar;
  private api: ApiService;
  public model: Partida;


  constructor(api: ApiService) {
    this.api = api;
    this.model = <Partida>{};
    this.model.JogadorX = <JogadorX>{}    
    this.model.Jogador0 = <Jogador0>{}
    this.model.ProximoTurno = "X";
    this.model.Situacao = <Situacao>{};
    this.model.Situacao.SituacaoPartida = this.situacao;
    this.model.Tabluleiro = <Tabluleiro>{};
    this.model.Tabluleiro.Posicao = this.tabuleiro;
  }

  onclick(x: number, y: number) {
    if (this.tabuleiro[x][y] === "") {
      this.api.iniciarPartida(this.model).then();
      if (this.isCirculo) {

        this.tabuleiro[x][y] = "O";
        this.isCirculo = false;
      } else {
        this.tabuleiro[x][y] = "X";
        this.isCirculo = true;
      }
    }
  }

  clear() {
    this.tabuleiro = [["", "", ""], ["", "", ""], ["", "", ""]];
    this.isCirculo = false;
  }
  
  

}
