import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { Partida } from '../models/partida.model';


@Injectable()
export class ApiService {
  readonly apiURL: string;  

  constructor(private http: HttpClient) {
    this.apiURL = 'https://localhost:7007/api/Partida';
   
  }

   iniciarPartida(partida: Partida) {
    this.http.post<Partida>(`${this.apiURL}/iniciar`, partida)
       .subscribe(resultado => console.log(resultado));     
  }
  fazerJogada(partida: Partida) {
    this.http.post<Partida>(`${this.apiURL}/jogar`, partida)
      .subscribe(resultado => console.log(resultado));
  }
  obterDadosPartida() {
    this.http.get<Partida[]>(`${this.apiURL}/obter`)
      .subscribe(resultado => console.log(resultado));
  }
}
