import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-jogos',
  templateUrl: './jogos.component.html',
  styleUrls: ['./jogos.component.scss']
})
export class JogosComponent implements OnInit {

  jogos: any

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos()
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/Jogo').subscribe(
      response => this.jogos = response,
      error => console.log(error)

    )
  }

}
