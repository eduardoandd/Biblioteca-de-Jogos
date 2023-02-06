import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-jogos',
  templateUrl: './jogos.component.html',
  styleUrls: ['./jogos.component.scss']
})
export class JogosComponent implements OnInit {

  jogos: any = []
  jogosFiltrados: any = []
  marginImg = 10;
  widthImg = 100;
  mostrarImagem = true;
  private _filtroLista: string='';

  public get filtroLista(): string{
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.jogosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.jogos
  }

  filtrarEventos(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.jogos.filter(
      (jogo: { nome: string; }) => jogo.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1

    );
  }

  alterarImagem(){
    this.mostrarImagem = !this.mostrarImagem;
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos()
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/Jogo').subscribe(
      response =>{
        this.jogos = response
        this.jogosFiltrados = this.jogos
      },
      error => console.log(error)

    )
  }

}
