import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { IBook } from 'app/books/book';
import 'rxjs/add/observable/of';

@Injectable()
export class BookFakeService {

    getBooks(): Observable<IBook[]> {
        return Observable.of([]);
    }

}
