import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { IBook } from './book';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/delay';

@Injectable()
export class BookService {

    get searchTerm$() {
        return this.searchTermSubject.asObservable();
    }

    private searchTermSubject = new BehaviorSubject(null);

    constructor(private http: Http) { }

    searchFor(nameToSearch: string) {
        this.searchTermSubject.next(nameToSearch);
    }

    getAllBooks() {
        return this.http.get('assets/api/books/books.json').map((res:Response) => res.json());
      }

    getBooks(nameToSearch: string): Observable<IBook[]> {
        return this.http
            .get('assets/api/books/books.json')
            .map((response: Response) => (<IBook[]>response.json())
                .filter(b => !nameToSearch || b.name.toUpperCase().indexOf(nameToSearch.toUpperCase()) !== -1))
            .delay(500);
    }

    getBook(id: string) {
        return this.http
            .get('assets/api/books/books.json')
            .map((response: Response) => (<IBook[]>response.json()).find(b => b.id === id))
            .delay(500);
    }


    putBook(book:IBook)
    {

        let body = JSON.stringify(book);
        return this.http.post('assets/api/books/books.json', body).map((res: Response) => res.json());
    }


}
