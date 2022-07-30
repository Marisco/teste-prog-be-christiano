export interface JogadorX {
  JogadorId: number;
  Nome: string;
}

export interface Jogador0 {
  JogadorId: number;
  Nome: string;
}

export interface Tabluleiro {
  TabuleiroId: number;
  Posicao: string[][];
}

export interface Situacao {
  SituacaoId: number;
  SituacaoPartida: string;
}

export interface Partida {
  PartidaId: number;
  JogadorX: JogadorX;
  Jogador0: Jogador0;
  Tabluleiro: Tabluleiro;
  Situacao: Situacao;
  ProximoTurno: string;
  DataPartida: Date;
}



