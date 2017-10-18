import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import 'rxjs/add/operator/switchMap';

import { BookService } from '../book.service';
import { IBook } from '../book';

@Component({
    selector: 'app-book-details',
    templateUrl: 'book-details.component.html'
})
export class BookDetailsComponent implements OnInit {
    book: IBook = <IBook>{};

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private service: BookService
    ) { }

    ngOnInit() {
        this.route.paramMap
            .switchMap((params: ParamMap) =>
                this.service.getBook(params.get('bookId')))
            .subscribe((book: IBook) => this.book = book);
         
    }

    back() {
        this.router.navigate(['/books']);
    }
}
