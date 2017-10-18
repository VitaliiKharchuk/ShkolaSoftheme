import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs/Subject';
import 'rxjs/add/operator/debounceTime';
import 'rxjs/add/operator/distinctUntilChanged';
import { BookService } from './books/book.service';

import { AddBookComponent } from './books/add-book/add-book.component';


@Component({
    selector: 'app-app',
    templateUrl: 'app.component.html'
})
export class AppComponent implements OnInit {
    pageTitle = 'Dev Book Store';

    private searchTermStream = new Subject<string>()

    constructor(
        private bookService: BookService
    ) { }

    ngOnInit() {
        this.searchTermStream
            .debounceTime(500)
            .distinctUntilChanged()
            .subscribe((term: string) => this.bookService.searchFor(term));
    }

    search(term: string) {
        this.searchTermStream.next(term);
    }
}
