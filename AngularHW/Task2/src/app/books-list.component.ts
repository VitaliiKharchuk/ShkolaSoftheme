import { Component, OnInit } from '@angular/core';

//import { BooksService } from '../services/books.service';
import { Observable } from 'rxjs/Observable';
import { Book } from './models/book.model';
import { BooksService } from './services/books.service';


@Component({
    selector: 'app-books-list',
    templateUrl: './books-list.component.html',
    styleUrls: ['./books-list.component.css']
})
export class BooksListComponent implements OnInit {
    favoriteMessage = '';
    imageWidth = 159;
    showImage = true;

    books$: Observable<Book[]>;

    constructor(private booksService: BooksService) {
    }

    ngOnInit() {
        this.books$ = this.booksService.getBooks();
    }

    onFavoriteClicked(message: string): void {
        this.favoriteMessage = message;
    }

    toggleImage(): void {
        this.showImage = !this.showImage;
    }
}
