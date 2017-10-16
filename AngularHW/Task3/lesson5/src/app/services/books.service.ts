import { Injectable } from '@angular/core';
import { Http , Response} from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

import { Book } from '../models/book.model';

@Injectable()
export class BooksService {

  constructor(private http: Http) {
  }

  getBooks(): Observable<Book[]> {
    return this.http.get('http://localhost:3000/books')
      .map((response: any) => response.json());
  }

  getBook(id: string): Observable<Book> {
    return this.http.get(`http://localhost:3000/books/${id}`)
      .map((response: any) => response.json());
  }


}
