import { Injectable } from '@angular/core';
import { FavoriteBook } from '../models/favorite.model';
import { Observable } from 'rxjs/Observable';
import { Http } from '@angular/http';

@Injectable()
export class FavoriteBooksService {

  constructor(private  http : Http) { }


  getBooks(): Observable<FavoriteBook[]> {
    return this.http.get('http://localhost:3000/favoriteBooks')
      .map((response: any) => response.json());
  }

}
